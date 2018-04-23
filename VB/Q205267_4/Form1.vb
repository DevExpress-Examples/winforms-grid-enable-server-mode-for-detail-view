Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Xpo
Imports Northwind
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.DB
Imports System.Threading

Namespace Q205267_4
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString("..\..\nwind.mdb")

			' Uncomment this code to create new database

			'using (UnitOfWork uow = new UnitOfWork()) {
			'    uow.ClearDatabase();
			'    Employees employee = new Employees(uow);
			'    employee.FirstName = "Thomas";
			'    employee.Save();
			'    uow.CommitChanges();
			'    for (int i = 0; i < 10; i++) {
			'        for (int j = 0; j < 10000; j++) {
			'            Orders order = new Orders(uow);
			'            order.ShipCity = "City";
			'            order.EmployeeID = employee;
			'        }
			'        uow.CommitChanges();
			'        Console.WriteLine(string.Format("{0} objects already created", i * 10000));
			'    }
			'}
			InitializeComponent()
		End Sub

		Private Sub myGridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs) Handles myGridView1.MasterRowGetChildList
			Dim view As GridView = CType(sender, GridView)
			Dim employee As Employees = CType(view.GetRow(e.RowHandle), Employees)
			Dim source As XPServerCollectionSource = CreateChildServerModeSource(employee)
			e.ChildList = (CType(source, IListSource)).GetList()
		End Sub

		Private Function CreateChildServerModeSource(ByVal employee As Employees) As XPServerCollectionSource
			Dim employeeId As Integer = employee.EmployeeID
			Dim op As CriteriaOperator = New BinaryOperator("EmployeeID", employeeId)
			Return New XPServerCollectionSource(employee.Session, GetType(Orders), op)
		End Function

		Private Sub myGridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs) Handles myGridView1.MasterRowEmpty
			Dim view As GridView = CType(sender, GridView)
			Dim employee As Employees = CType(view.GetRow(e.RowHandle), Employees)
			Dim source As XPServerCollectionSource = CreateChildServerModeSource(employee)
			e.IsEmpty = (CType(source, IListSource)).GetList().Count = 0
		End Sub

		Private Sub myGridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As MasterRowGetRelationCountEventArgs) Handles myGridView1.MasterRowGetRelationCount
			e.RelationCount = 1
		End Sub

		Private Sub myGridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs) Handles myGridView1.MasterRowGetRelationName
			e.RelationName = "Employee_Orders"
		End Sub
	End Class
End Namespace