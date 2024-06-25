<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632348/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1460)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Enable Server Mode for a detail view

This example demonstrates how to create a `GridView` descendant that shows detail records in Server Mode. In this example:

* Set the GridControl's [ShowOnlyPredefinedDetails](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.ShowOnlyPredefinedDetails) property to **true**.
* Add detail levels to the GridControl using the [LevelTree](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.LevelTree).
* Specify an instance of the `MyGridView` class for each level and set the `MyGridView.VirtualMasterDetailMode` property to `Master` or `Detail`. The child list for detail views is created at runtime using events. Read the following help topic for additional information: [Master-Detail: Using Events](https://docs.devexpress.com/WindowsForms/732/controls-and-libraries/data-grid/master-detail/working-with-master-detail-relationships-in-code).


## Files to Review

* [Form1.cs](./CS/Q205267_4/Form1.cs) (VB: [Form1.vb](./VB/Q205267_4/Form1.vb))
* [MyGridControl.cs](./CS/Q205267_4/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/Q205267_4/MyGridControl.vb))
* [PersistentClasses1.cs](./CS/Q205267_4/PersistentClasses1.cs) (VB: [PersistentClasses1.vb](./VB/Q205267_4/PersistentClasses1.vb))


## Documentation

* [Large Data Sources: Server and Instant Feedback Modes](https://docs.devexpress.com/WindowsForms/8398/controls-and-libraries/data-grid/data-binding/large-data-sources-server-and-instant-feedback-modes)
* [Master-Detail Relationships](https://docs.devexpress.com/WindowsForms/3473/controls-and-libraries/data-grid/master-detail-relationships)
* [Working with Master-Detail Relationships in Code](https://docs.devexpress.com/WindowsForms/732/controls-and-libraries/data-grid/master-detail/working-with-master-detail-relationships-in-code)


## See Also

* [Enable Server Mode for detail records providing a list implementing IListSource within the MasterRowGetChildList event handler](https://supportcenter.devexpress.com/ticket/details/s32493/add-the-capability-to-enable-the-server-mode-feature-for-detail-records-providing-a-list)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-enable-server-mode-for-detail-view&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-enable-server-mode-for-detail-view&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
