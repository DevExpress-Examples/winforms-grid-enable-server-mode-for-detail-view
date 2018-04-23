using System;
using DevExpress.Xpo;
namespace Northwind {

    public class Employees : XPLiteObject {
        int fEmployeeID;
        [Key(true)]
        public int EmployeeID {
            get { return fEmployeeID; }
            set { SetPropertyValue<int>("EmployeeID", ref fEmployeeID, value); }
        }
        string fFirstName;
        [Size(10)]
        public string FirstName {
            get { return fFirstName; }
            set { SetPropertyValue<string>("FirstName", ref fFirstName, value); }
        }
        [Association("Employee-Orders", typeof(Orders))]
        public XPCollection<Orders> Orders { get { return GetCollection<Orders>("Orders"); } }
        public Employees(Session session) : base(session) { }
        public Employees() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class Orders : XPLiteObject {
        int fOrderID;
        [Key(true)]
        public int OrderID {
            get { return fOrderID; }
            set { SetPropertyValue<int>("OrderID", ref fOrderID, value); }
        }
        Employees fEmployeeID;
        [Association("Employee-Orders")]
        public Employees EmployeeID {
            get { return fEmployeeID; }
            set { SetPropertyValue<Employees>("EmployeeID", ref fEmployeeID, value); }
        }
        string fShipCity;
        [Size(15)]
        public string ShipCity {
            get { return fShipCity; }
            set { SetPropertyValue<string>("ShipCity", ref fShipCity, value); }
        }
        public Orders(Session session) : base(session) { }
        public Orders() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}