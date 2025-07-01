::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding Excel Importing to an Application {#adding-excel-importing-to-an-application style="tab-stops: 0pt"}

You can Import the entire Excel Spreadsheet to a GridControl. You can also import the Excel97to2003 and Excel2007to2010 formats

 

Importing the single sheet to a GridControl

 

In order to import the single sheet to grid control, open the file and pass this file as stream to the ImportFromExcel method as illustrated in the following code snippet:

**** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                         |
| [FileStream]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ fileStream = [new]{style="COLOR: blue"} [FileStream]{style="COLOR: #2b91af"}([@\"..\\..\\Data\\Sample.xlsx\"]{style="COLOR: #a31515"}, [FileMode]{style="COLOR: #2b91af"}.Open);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                         |
| [byte]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] file = [new]{style="COLOR: blue"} [byte]{style="COLOR: blue"}\[fileStream.Length\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                                                                         |
| [fileStream.Read(file, 0, ([int]{style="COLOR: blue"})fileStream.Length);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                         |
| [fileStream.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl.Model.ImportFromExcel([new]{style="COLOR: blue"} [MemoryStream]{style="COLOR: #2b91af"}(file));]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Importing the entire workbook to a GridControl

 

Open the workbook

 

To import the entire workbook to a GridControl, initially you have to open the workbook by using the XLSIO library as shown in the following code snippet:

**** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                         |
| [FileStream]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ fileStream = [new]{style="COLOR: blue"} [FileStream]{style="COLOR: #2b91af"}([@\"..\\..\\Data\\Sample.xlsx\"]{style="COLOR: #a31515"}, [FileMode]{style="COLOR: #2b91af"}.Open);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                         |
| [byte]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] file = [new]{style="COLOR: blue"} [byte]{style="COLOR: blue"}\[fileStream.Length\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                                                                         |
| [fileStream.Read(file, 0, ([int]{style="COLOR: blue"})fileStream.Length);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                         |
| [fileStream.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [ExcelEngine]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ excelEngine = [new]{style="COLOR: blue"} [ExcelEngine]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [IApplication]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ application = excelEngine.Excel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [IWorkbook]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ workbook = application.Workbooks.Open([new]{style="COLOR: blue"} [MemoryStream]{style="COLOR: #2b91af"}(file), [ExcelOpenType]{style="COLOR: #2b91af"}.Automatic);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Import the workbook into GridModel

 

After opening the workbook, you can import the workbook to GridModel by using the ImportFromExcel method. It will return the model collection; you can use it in your application. It will import all the styles, Conditional Formatting, Data Validation and book marks to model. While using this method it will take some time to import all the styles into models.

For importing the workbook you can use the following code snippet.

**** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                           |
|                                                                                                                                                                                                            |
| [GridModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] modelCollection = [GridModelImportExtensions]{style="COLOR: #2b91af"}.ImportFromExcel(workBook);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Importing the entire workbook to a virtual GridControl

Open the workbook

 

To import the entire workbook to a virtual GridControl, initially you have to open the workbook by using the XLSIO library as shown in the following code snippet.

**** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                         |
| [FileStream]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ fileStream = [new]{style="COLOR: blue"} [FileStream]{style="COLOR: #2b91af"}([@\"..\\..\\Data\\Sample.xlsx\"]{style="COLOR: #a31515"}, [FileMode]{style="COLOR: #2b91af"}.Open);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                         |
| [byte]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] file = [new]{style="COLOR: blue"} [byte]{style="COLOR: blue"}\[fileStream.Length\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                                                                         |
| [fileStream.Read(file, 0, ([int]{style="COLOR: blue"})fileStream.Length);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                         |
| [fileStream.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [ExcelEngine]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ excelEngine = [new]{style="COLOR: blue"} [ExcelEngine]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [IApplication]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ application = excelEngine.Excel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                                         |
| [IWorkbook]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ workbook = application.Workbooks.Open([new]{style="COLOR: blue"} [MemoryStream]{style="COLOR: #2b91af"}(file), [ExcelOpenType]{style="COLOR: #2b91af"}.Automatic);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Import the layout into GridModel

 

After that you can import the workbook by using the ImportFromExcelToVirtualGrid method it will return the model collection. GridModel have only the  layout styles, to import the other styles and data for cells you have to use the ConvertExcelRangeToVirtualGrid method.

**** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                         |
| [GridModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] modelCollection = [GridModelImportExtensions]{style="COLOR: #2b91af"}.ImportFromExcelToVirtualGrid(workBook);]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Import data into GridModel

 

To load the data in grid cells, you have to use the ConvertExcelRangeToVirtualGrid method, this will import the formulas, cellvalue, conditional formats, data validation and the styles from the excel range to grid cells. To import the data into cells you can call the ConvertExcelRangeToVirtualGrid method in Querycellinfo Event as shown in the following code snippet:

**** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                    |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_QueryCellInfo([object]{style="COLOR: blue"} sender, [GridQueryCellInfoEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [GridModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ gridModel = sender [as]{style="COLOR: blue"} [GridModel]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                    |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (!e.Style.IsChanged)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ index = modelCollection.ToList().IndexOf(gridModel);]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                    |
| [IWorksheet]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sheet = workBook.Worksheets\[index\];]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                    |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (sheet != [null]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ range = sheet.Range;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                    |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (e.Cell.RowIndex \>= range.Row && e.Cell.ColumnIndex \>= range.Column)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rangeToConvert = sheet.Range\[e.Cell.RowIndex, e.Cell.ColumnIndex\];]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                    |
| [GridModelImportExtensions]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ConvertExcelRangeToVirtualGrid(e.Style, sheet, rangeToConvert, [null]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                    |
| [gridModel.Data\[e.Cell.RowIndex, e.Cell.ColumnIndex\] = e.Style.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
