Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Namespace Northwind

	Public Class Employees
		Inherits XPLiteObject
		Private fEmployeeID As Integer
		<Key(True)> _
		Public Property EmployeeID() As Integer
			Get
				Return fEmployeeID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("EmployeeID", fEmployeeID, value)
			End Set
		End Property
		Private fFirstName As String
		<Size(10)> _
		Public Property FirstName() As String
			Get
				Return fFirstName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("FirstName", fFirstName, value)
			End Set
		End Property
		<Association("Employee-Orders", GetType(Orders))> _
		Public ReadOnly Property Orders() As XPCollection(Of Orders)
			Get
				Return GetCollection(Of Orders)("Orders")
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class
	Public Class Orders
		Inherits XPLiteObject
		Private fOrderID As Integer
		<Key(True)> _
		Public Property OrderID() As Integer
			Get
				Return fOrderID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("OrderID", fOrderID, value)
			End Set
		End Property
		Private fEmployeeID As Employees
		<Association("Employee-Orders")> _
		Public Property EmployeeID() As Employees
			Get
				Return fEmployeeID
			End Get
			Set(ByVal value As Employees)
				SetPropertyValue(Of Employees)("EmployeeID", fEmployeeID, value)
			End Set
		End Property
		Private fShipCity As String
		<Size(15)> _
		Public Property ShipCity() As String
			Get
				Return fShipCity
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ShipCity", fShipCity, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class
End Namespace