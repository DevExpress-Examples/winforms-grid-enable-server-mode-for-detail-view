Namespace Q205267_4

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Me.xpServerCollectionSource1 = New DevExpress.Xpo.XPServerCollectionSource()
            Me.myGridControl1 = New DXSample.MyGridControl()
            Me.myGridView1 = New DXSample.MyGridView()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.myGridView2 = New DXSample.MyGridView()
            CType((Me.xpServerCollectionSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myGridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xpServerCollectionSource1
            ' 
            Me.xpServerCollectionSource1.ObjectType = GetType(Northwind.Employees)
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.DataSource = Me.xpServerCollectionSource1
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.myGridView2
            gridLevelNode1.RelationName = "Employee_Orders"
            Me.myGridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.myGridControl1.MainView = Me.myGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.ServerMode = True
            Me.myGridControl1.ShowOnlyPredefinedDetails = True
            Me.myGridControl1.Size = New System.Drawing.Size(789, 536)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView1, Me.myGridView2})
            ' 
            ' myGridView1
            ' 
            Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmployeeID, Me.colFirstName})
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            Me.myGridView1.VirtualMasterDetailMode = DXSample.VirtualMasterDetailMode.Master
            AddHandler Me.myGridView1.MasterRowGetRelationName, New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(AddressOf Me.myGridView1_MasterRowGetRelationName)
            AddHandler Me.myGridView1.MasterRowGetChildList, New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(AddressOf Me.myGridView1_MasterRowGetChildList)
            AddHandler Me.myGridView1.MasterRowEmpty, New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(AddressOf Me.myGridView1_MasterRowEmpty)
            AddHandler Me.myGridView1.MasterRowGetRelationCount, New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(AddressOf Me.myGridView1_MasterRowGetRelationCount)
            ' 
            ' colEmployeeID
            ' 
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            Me.colEmployeeID.Visible = True
            Me.colEmployeeID.VisibleIndex = 0
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 1
            ' 
            ' myGridView2
            ' 
            Me.myGridView2.GridControl = Me.myGridControl1
            Me.myGridView2.Name = "myGridView2"
            Me.myGridView2.VirtualMasterDetailMode = DXSample.VirtualMasterDetailMode.Detail
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(789, 536)
            Me.Controls.Add(Me.myGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.xpServerCollectionSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myGridView2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private xpServerCollectionSource1 As DevExpress.Xpo.XPServerCollectionSource

        Private myGridControl1 As DXSample.MyGridControl

        Private myGridView2 As DXSample.MyGridView

        Private myGridView1 As DXSample.MyGridView

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
