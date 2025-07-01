::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c4e05552-3f8e-427e-b84b-f4e4428bce43){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0163ec1b-3f51-451f-b67a-7236c3073ab4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Import and Export from Data Table {#import-and-export-from-data-table style="tab-stops: 0pt"}

Spreadsheet offers some helper methods that enable you to import and export data form ADO.NET data sources very easily. The ImportDataTable and ExportDataTable methods allow you to use one line of code to import data from a Datatable to a SpreadSheet and export data from a SpreadSheet to a DataTable respectively.

![](ImagesExt/image17_36.jpg){border="0"}

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

[![](button.gif){border="0" align="absMiddle"}Importing from a Data Table](ms-xhelp:///?Id=e1376e80-c1ba-4aba-9c29-eaceebbf84ff){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting to a Data Table](ms-xhelp:///?Id=f474710d-d9b4-4a76-8b86-222054595c22){style="TEXT-DECORATION: none"}
::::
