using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Xpo;
using Northwind;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;
using System.Threading;

namespace Q205267_4 {
    public partial class Form1 : Form {
        public Form1() {
            XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString(@"..\..\nwind.mdb");

            // Uncomment this code to create new database

            //using (UnitOfWork uow = new UnitOfWork()) {
            //    uow.ClearDatabase();
            //    Employees employee = new Employees(uow);
            //    employee.FirstName = "Thomas";
            //    employee.Save();
            //    uow.CommitChanges();
            //    for (int i = 0; i < 10; i++) {
            //        for (int j = 0; j < 10000; j++) {
            //            Orders order = new Orders(uow);
            //            order.ShipCity = "City";
            //            order.EmployeeID = employee;
            //        }
            //        uow.CommitChanges();
            //        Console.WriteLine(string.Format("{0} objects already created", i * 10000));
            //    }
            //}
            InitializeComponent();
        }

        private void myGridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) {
            GridView view = (GridView)sender;
            Employees employee = (Employees)view.GetRow(e.RowHandle);
            XPServerCollectionSource source = CreateChildServerModeSource(employee);
            e.ChildList = ((IListSource)source).GetList();
        }

        private XPServerCollectionSource CreateChildServerModeSource(Employees employee) {
            int employeeId = employee.EmployeeID;
            CriteriaOperator op = new BinaryOperator("EmployeeID", employeeId);
            return new XPServerCollectionSource(employee.Session, typeof(Orders), op);
        }

        private void myGridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e) {
            GridView view = (GridView)sender;
            Employees employee = (Employees)view.GetRow(e.RowHandle);
            XPServerCollectionSource source = CreateChildServerModeSource(employee);
            e.IsEmpty = ((IListSource)source).GetList().Count == 0;
        }

        private void myGridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private void myGridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Employee_Orders";
        }
    }
}