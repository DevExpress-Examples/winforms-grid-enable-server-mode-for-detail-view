<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q205267_4/Form1.cs) (VB: [Form1.vb](./VB/Q205267_4/Form1.vb))
* [MyGridControl.cs](./CS/Q205267_4/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/Q205267_4/MyGridControl.vb))
* [PersistentClasses1.cs](./CS/Q205267_4/PersistentClasses1.cs) (VB: [PersistentClasses1.vb](./VB/Q205267_4/PersistentClasses1.vb))
<!-- default file list end -->
# How to use the Server Mode feature for the detail view


<p>This example demonstrates how to create a GridView descendant, that will allow you to show detail records in Server Mode. To make this solution work, set the GridControl's ServerMode and ShowOnlyPredefinedDetails properties to true. Then, add new levels to the GridControl's <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_LevelTreetopic"><u>LevelTree</u></a>. Specify an instance of the MyGridView class for each level and set the MyGridView.VirtualMasterDetailMode property to Master or Detail. The child list for detail views is created at runtime using events. Please see this help topic for more information about this: <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument732"><u>Master-Detail: Using Events</u></a>.<br />
<strong>See </strong><strong>also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/S32493">Add the capability to enable the Server Mode feature for detail records providing a list implementing the IListSource interface within the MasterRowGetChildList event handler</a></p>

<br/>


