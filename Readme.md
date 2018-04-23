# How to create a custom template for the Excel column filter drop-down window


<p>This example illustrates how to create a custom template for the Excel column filter drop-down window. <br><br>In particular, this sample shows how to filter string data by their length. For this, we created a special template containing an additional editor allowing you to enter the required length. For simplicity, we additionally filter a set of the current filter values shown in a list box based on a value of this editor.  This template is assigned to the necessary column filter drop-down window by using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FilterPopupExcelPrepareTemplate.event">FilterPopupExcelPrepareTemplate</a> event. Next, we handle the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FilterPopupExcelCustomizeTemplate.event">FilterPopupExcelCustomizeTemplate</a> event to populate our template controls with the necessary filter values.</p>
<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-custom-template-for-the-excel-column-filter-drop-down-window-t591683/17.2.4+/media/14544b68-0c81-48d0-8c93-4629622d2bc1.png">

<br/>


