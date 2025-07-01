::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=68a01bf1-b522-495b-9792-eb7336070ad3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0f13aa59-cfa3-4abe-962e-efdc48361811){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=ad99231a-9920-49c5-b9a3-8c0224163396){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Spreadsheet](ms-xhelp:///?Id=68a01bf1-b522-495b-9792-eb7336070ad3){.d2h_breadcrumbsNormal}
:::

### Excel Engine {#excel-engine style="tab-stops: 0pt"}

 

**ExcelEngine** class provides access to **IApplication** interface that represents an Excel application. This class has the **Dispose** method, which is responsible for disposing the objects after closing the workbook.

 

**Public Properties**

 

The following table lists the public properties and their corresponding descriptions of **ExcelEngine** class:

 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Properties                        | Description                                                                                                                                                                                                                                          |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Excel                             | Interface to the XlsIO Application which gives access to all supported functions.                                                                                                                                                                    |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ThrowNotSavedOnDestroy            | Dispose will throw an ExcelWorkbookNotSaved exception when the workbook is not saved and this property is set to True. Default value is False.                                                                                                       |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ActiveCell                        | Returns a range object that represents the active cell in the active window (the window on top) or in the specified window. If the window isn\'t displaying a worksheet, this property fails. It is a Read-Only property.                            |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ActiveSheet                       | Returns an object that represents the active sheet (the sheet on top) in the active workbook or in the specified window or workbook. Returns nothing if no sheet is active. It is a Read-Only property.                                              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ActiveWorkbook                    | Returns a Workbook object that represents the workbook in the active window (the window on top). It is a Read-Only property. Returns nothing if there are no windows open or if either the Info window or the Clipboard window is the active window. |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ArgumentsSeparator                | Formula arguments separator. This can be used to change the separator used in the formulas as per the culture.                                                                                                                                       |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Build                             | Returns the Microsoft Excel build number. It is a Read-Only property.                                                                                                                                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ChangeStyleOnCellEdit             | If this property is set to True, then if some cells have reference to the same style, changes will influence all these cells. Default value is False.                                                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CSVSeparator                      | Represents CSV Separator. Using for Auto recognize file type.                                                                                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DecimalSeparator                  | Sets or returns the character used for the decimal separator as a String.                                                                                                                                                                            |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DefaultFilePath                   | Returns or sets the default path that Microsoft Excel uses when it opens files.                                                                                                                                                                      |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DefaultVersion                    | Gets/sets default Excel version. This value is used in create methods.                                                                                                                                                                               |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DeleteDestinationFile             | Indicates whether XlsIO should delete the destination file before saving into it. Default value is True.                                                                                                                                             |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FixedDecimal                      | All data entered after this property is set to True will be formatted with the number of fixed decimal places set by the FixedDecimalPlaces property.                                                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FixedDecimalPlaces                | Returns or sets the number of fixed decimal places used when the FixedDecimal property is set to True.                                                                                                                                               |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Path                              | Returns the complete path to the application, excluding the final separator and name of the application. It is a Read-Only property.                                                                                                                 |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| PathSeparator                     | Returns the path separator character (\"\\\"). It is a Read-Only property.                                                                                                                                                                           |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Range                             | Returns a Range object that represents a cell or a range of cells.                                                                                                                                                                                   |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| RowSeparator                      | Gets/sets row separator for array parsing.                                                                                                                                                                                                           |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SheetsInNewWorkbook               | Returns or sets the number of sheets that Microsoft Excel automatically inserts into new workbooks.                                                                                                                                                  |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardFont                      | Returns or sets the name of the standard font.                                                                                                                                                                                                       |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardFontSize                  | Returns or sets the standard font size, in points.                                                                                                                                                                                                   |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardHeight                    | Returns or sets the standard (default) height of all the rows in the worksheet, in points. This value is used only for newly created worksheets.                                                                                                     |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardHeightFlag                | Returns or sets the standard (default) height option flag, which defines that standard (default) row height and book default font height do not match. This value is used only for newly created worksheets.                                         |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardWidth                     | Returns or sets the standard (default) width of all the columns in the worksheet. This value is used only for newly created worksheets.                                                                                                              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ThousandsSeparator                | Sets or returns the character used for the thousands separator as a String.                                                                                                                                                                          |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UseNativeOptimization             | Indicates to use unsafe code.                                                                                                                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UseNativeStorage                  | Indicates whether we should use native storage (standard windows COM object)                                                                                                                                                                         |
|                                   |                                                                                                                                                                                                                                                      |
|                                   | or .NET implementation to open Excel 97-2003 files.                                                                                                                                                                                                  |
|                                   |                                                                                                                                                                                                                                                      |
|                                   | This .NET storage doesn\'t depends on windows APIs and are developed with fully managed code. By default, it is set to true \[uses native storage\].                                                                                                 |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UserName                          | Returns or sets the name of the current user.                                                                                                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UseSystemSeparators               | True (default) if the system separators of Microsoft Excel are enabled.                                                                                                                                                                              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Workbooks                         | Returns a Workbooks collection that represents all the open workbooks.                                                                                                                                                                               |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Worksheets                        | For an Application object, this returns a Sheets collection that represents all the worksheets in the active workbook. For a Workbook object, this returns a Sheets collection that represents all the worksheets in the specified workbook.         |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Public Methods

 

[The following table provides the list of methods and their corresponding descriptions of ExcelEngine class:]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------------- -----------------------------------------------------------------------------------------
  Methods               Description
  CentimetersToPoints   Converts a measurement from centimeters to points (one point equals 0.035 centimeters).
  ConvertUnits          Converts units. 
  InchesToPoints        Converts a measurement from inches to points.
  Save                  Saves changes to the active workbook.
  --------------------- -----------------------------------------------------------------------------------------
:::

 

Public Events

 

[The following table lists the events of the ExcelEngine class and their corresponding descriptions:]{style="FONT-SIZE: 9pt"}

 

::: {align="center"}
  -------------------- ------------------------------------------------------------------------------------------------------------------------------------------------
  Events               Description
  OnPasswordRequired   This event is fired when user tries to open password protected workbook without specifying password. It is used to obtain password.
  OnWrongPassword      This event is fired when user specified wrong password when trying to open password protected workbook. It is used to obtain correct password.
  ProgressEvent        When workbook is read from stream and position of the stream changed, this event is raised.
  -------------------- ------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

[]{#p23}**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}** 

[]{#related-topics}
:::::::
