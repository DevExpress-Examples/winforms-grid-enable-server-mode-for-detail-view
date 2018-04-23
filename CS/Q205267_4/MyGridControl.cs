using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data.Details;
using DevExpress.XtraGrid.Registrator;
using DevExpress.Data;

namespace DXSample {
    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }
    public class MyGridView : GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl gridControl) : base(gridControl) { }
        internal const string MyGridViewName = "MyGridView";
        protected override string ViewName { get { return MyGridViewName; } }
        private VirtualMasterDetailMode fVirtualMasterDetailMode = VirtualMasterDetailMode.Disabled;
        public VirtualMasterDetailMode VirtualMasterDetailMode {
            get { return fVirtualMasterDetailMode; }
            set { fVirtualMasterDetailMode = value; }
        }
        protected override void ApplyLevelDefaults(BaseView newGV, BaseView defaultView, DetailInfo di, string levelName) {
            MyGridView mgv = newGV as MyGridView;
            if (mgv != null) mgv.CheckRecreateDataController(di.DetailList);
            base.ApplyLevelDefaults(newGV, defaultView, di, levelName);
        }
        protected override BaseGridController CreateDataController() {
            switch (fVirtualMasterDetailMode) {
                case VirtualMasterDetailMode.Master: return new VirtualMasterDetailServerModeDataController();
                case VirtualMasterDetailMode.Detail: return new ServerModeDataController();
                default: return base.CreateDataController();
            }
        }
    }
    public enum VirtualMasterDetailMode { Disabled, Master, Detail }
    public class MyGridViewInfoRegistrator : GridInfoRegistrator {
        public MyGridViewInfoRegistrator() : base() { }
        public override string ViewName { get { return MyGridView.MyGridViewName; } }
        public override BaseView CreateView(GridControl grid) {
            return new MyGridView(grid);
        }
    }
    public class VirtualMasterDetailServerModeDataController : ServerModeDataController {
        public VirtualMasterDetailServerModeDataController() : base() { }
        public override void PopulateColumns() {
            Columns.Clear();
            DetailColumns.Clear();
            Helper.PopulateColumns();
            DetailColumns.Clear();
            DoRefresh();
        }
    }
}