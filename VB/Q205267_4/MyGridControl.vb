Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data.Details
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.Data

Namespace DXSample

    Public Class MyGridControl
        Inherits GridControl

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyGridViewInfoRegistrator())
        End Sub
    End Class

    Public Class MyGridView
        Inherits GridView

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal gridControl As GridControl)
            MyBase.New(gridControl)
        End Sub

        Friend Const MyGridViewName As String = "MyGridView"

        Protected Overrides ReadOnly Property ViewName As String
            Get
                Return MyGridViewName
            End Get
        End Property

        Private fVirtualMasterDetailMode As VirtualMasterDetailMode = VirtualMasterDetailMode.Disabled

        Public Property VirtualMasterDetailMode As VirtualMasterDetailMode
            Get
                Return fVirtualMasterDetailMode
            End Get

            Set(ByVal value As VirtualMasterDetailMode)
                fVirtualMasterDetailMode = value
            End Set
        End Property

        Protected Overrides Sub ApplyLevelDefaults(ByVal newGV As BaseView, ByVal defaultView As BaseView, ByVal di As DetailInfo, ByVal levelName As String)
            Dim mgv As MyGridView = TryCast(newGV, MyGridView)
            If mgv IsNot Nothing Then mgv.CheckRecreateDataController(di.DetailList)
            MyBase.ApplyLevelDefaults(newGV, defaultView, di, levelName)
        End Sub

        Protected Overrides Function CreateDataController() As BaseGridController
            Select Case fVirtualMasterDetailMode
                Case VirtualMasterDetailMode.Master
                    Return New VirtualMasterDetailServerModeDataController()
                Case VirtualMasterDetailMode.Detail
                    Return New ServerModeDataController()
                Case Else
                    Return MyBase.CreateDataController()
            End Select
        End Function
    End Class

    Public Enum VirtualMasterDetailMode
        Disabled
        Master
        Detail
    End Enum

    Public Class MyGridViewInfoRegistrator
        Inherits GridInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property ViewName As String
            Get
                Return MyGridView.MyGridViewName
            End Get
        End Property

        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyGridView(grid)
        End Function
    End Class

    Public Class VirtualMasterDetailServerModeDataController
        Inherits ServerModeDataController

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides Sub PopulateColumns()
            Columns.Clear()
            DetailColumns.Clear()
            Helper.PopulateColumns()
            DetailColumns.Clear()
            DoRefresh()
        End Sub
    End Class
End Namespace
