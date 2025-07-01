::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=97fa1ac5-0a87-489a-b21f-051b97f21541){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d795f8a3-f119-442d-ab46-8e5ade8ee54e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Spreadsheet]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=625a8128-e556-4a29-9ea6-d472120ad9e1){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data Management](ms-xhelp:///?Id=1127a59c-3e3e-44d6-9cf4-1a5208536317){.d2h_breadcrumbsNormal}
:::

### Import and Export from Data Table {#import-and-export-from-data-table style="tab-stops: 0pt"}

Spreadsheet offers some helper methods that enable you to import and export data form ADO.NET data sources very easily. The ImportDataTable and ExportDataTable methods allow you to use one line of code to import data from a Datatable to a SpreadSheet and export data from a SpreadSheet to a DataTable respectively.

![](ImagesExt/image27_35.jpg){border="0"}

Figure 30: Importing from Data Table

 

Samples Link

The samples for Importing from data table are located at:

**Essential Studio Dashboard \> Spreadsheet \> Data Management \> Import Data Table.**

Refer to section 2.2 Samples and Location to access the samples location.

 

Methods

::: {align="center"}
+---------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+
| Method              | Description                                                                                                                                                                                                                                                                                                                     | Parameters                                                                                                                         | Type        | Return Type |
+---------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+
| ImportFromDataTable | This method imports data from the DataTable into the Spreadsheet.                                                                                                                                                                                                                                                               |  ImportDataTable(DataTable dataTable)                                                                                              | N/A         | void        |
+---------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+
| ImportFromDataTable | This method imports data from a DataTable into a Spreadsheet with parameters Row and Column of the first cell, where DataTable should be imported.                                                                                                                                                                              | ImportFromDataTable(DataTable table, bool isFieldNameShow, int startRow, int startCol)                                             | N/A         | void        |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
+---------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+
| ImportFromDataTable | This method imports data from a DataTable into a Spreadsheet with parameters  Row index and column index of SpreadSheet, where DataTable should be imported and preserve types  (This Indicates whether Spreadsheet should try to preserve types in DataTable)[]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"} | ImportFromDataTable(DataTable table, bool isFieldNameShow, int startRow, int startCol, bool preserveTypes)                         | N/A         | void        |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
+---------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+
| ImportFromDataTable | This method imports data from a DataTable into a Spreadsheet with parameters starting row index and column index and maximum number of rows and columns to import.[]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}                                                                                             | ImportFromDataTable(DataTable table, bool isFieldNameShow, int startRow, int startCol, int maxRow, int maxCol)                     | N/A         | void        |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
+---------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+
| ImportFromDataTable | This method imports data from a DataTable into a Spreadsheet with parameters starting row index and column index and maximum number of rows and columns to import and preserve types.[]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}                                                                          | ImportFromDataTable(DataTable table, bool isFieldNameShow, int startRow, int startCol, int maxRow, int maxCol, bool preserveTypes) | N/A         | void        |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
|                     |                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                    |             |             |
+=====================+=================================================================================================================================================================================================================================================================================================================================+====================================================================================================================================+=============+=============+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Importing from a Data Table](ms-xhelp:///?Id=9935b19c-6170-4726-a98b-4bb88b624fc2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting to a Data Table](ms-xhelp:///?Id=69873066-001e-4112-aef1-7f520c4daeaa){style="TEXT-DECORATION: none"}
:::::
