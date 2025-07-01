::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0f13aa59-cfa3-4abe-962e-efdc48361811){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1b71588e-a2a0-4bc0-924a-e0703e047656){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=ad99231a-9920-49c5-b9a3-8c0224163396){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Spreadsheet](ms-xhelp:///?Id=68a01bf1-b522-495b-9792-eb7336070ad3){.d2h_breadcrumbsNormal}
:::

### Worksheet {#worksheet style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The worksheet object is a member of the **Worksheets** collection. The Worksheets collection contains all the worksheet objects in a workbook. **IWorksheet** interface is responsible for applying settings that are sheet-oriented. This controls the worksheet visibility, importing data from various data sources, and row and column manipulation. Following are the members of the IWorksheets.

 

Public Methods

 

::: {align="center"}
  Method                           Description
  -------------------------------- -------------------------------------------------------------------------------------------------------------------
  Activate                         Makes the current sheet the active sheet. Equivalent to clicking the sheet\'s tab.
  AutofitColumn                    Autofits specified column.
  AutofitRow                       Autofits specified row.
  Clear                            Clears worksheet data. Removes all formatting and merges.
  ClearData                        Clears worksheet. Only the data is removed from each cell.
  ColumnWidthToPixels              Converts column width into pixels.
  CopyToClipboard                  Copies worksheet into the clipboard.
  CreateRangesCollection           Creates new instance of IRanges and group different ranges.
  CreateTemplateMarkersProcessor   Creates object that can be used for template markers processing.
  DeleteColumn                     Removes specified column (with formulas update).
  DeleteRow                        Removes specified row (with formulas update).
  ExportDataTable                  Exports sheet data as data table.
  FindAll                          Finds all matching data.
  FindFirst                        Finds the first data that matches the constraint.
  GetBoolean                       Gets bool value from the cell.
  GetColumnWidth                   Returns width from ColumnInfoRecord if there is corresponding ColumnInfoRecord or StandardWidth if not.
  GetColumnWidthInPixels           Returns width in pixels from ColumnInfoRecord if there is corresponding ColumnInfoRecord or StandardWidth if not.
  GetDefaultColumnStyle            Returns default column style.
  GetDefaultRowStyle               Returns default row style.
  GetError                         Gets error value from cell.
  GetFormula                       Returns formula value corresponding to the cell.
  GetFormulaBoolValue              Gets formula bool value from cell.
  GetFormulaErrorValue             Gets formula error value from cell.
  GetFormulaNumberValue            Returns formula number value corresponding to the cell.
  GetFormulaStringValue            Returns formula string value corresponding to the cell.
  GetNumber                        Returns number value corresponding to the cell.
  GetRowHeight                     Returns height from RowRecord if there is a corresponding RowRecord. Otherwise returns StandardHeight.
  GetRowHeightInPixels             Returns height from RowRecord if there is a corresponding RowRecord. Otherwise returns StandardHeight.
  GetText                          Returns string value corresponding to the cell.
  ImportArray                      Overloaded.
  ImportDataColumn                 Imports data from a DataColumn into worksheet.
  ImportDataTable                  Imports data from a DataTable into worksheet.
  ImportDataView                   Imports data from a DataView into worksheet.
  InsertColumn                     Inserts Column.
  InsertRow                        Inserts row.
  IntersectRanges                  Intersects two ranges.
  IsColumnVisible                  Checks if Column with specified index is visible to end-user or not.
  IsRowVisible                     Checks if Row with specified index is visible to user or not.
  MergeRanges                      Merges two ranges.
  Move                             Moves worksheet.
  PixelsToColumnWidth              Converts pixels into column width (in characters).
  Protect                          Protects worksheet with or without password.
  Remove                           Removes worksheet from parent worksheets collection.
  RemovePanes                      Removes panes from a worksheet.
  Select                           Selects current tab sheet.
  SetBlank                         Sets blank in specified cell.
  SetBoolean                       Sets value in the specified cell.
  SetColumnWidth                   Sets column width.
  SetColumnWidthInPixels           Sets column width in pixels.
  SetDefaultColumnStyle            Sets style for the whole column.
  SetDefaultRowStyle               Sets style for the whole rows.
  SetError                         Sets error in the specified cell.
  SetFormula                       Sets formula in the specified cell.
  SetFormulaBoolValue              Sets formula bool value.
  SetFormulaErrorValue             Sets formula error value.
  SetFormulaNumberValue            Sets formula number value.
  SetFormulaStringValue            Sets formula string value.
  SetNumber                        Sets value in the specified cell.
  SetRowHeight                     Sets row height.
  SetRowHeightInPixels             Sets row height in pixels.
  SetText                          Sets text in the specified cell.
  SetValue                         Sets value in the specified cell.
  ShowColumn                       Shows/Hides the specified column.
  ShowRow                          Shows/Hides the specified row.
  Unprotect                        Unprotects worksheet\'s content with password.
  Unselect                         Unselects current tab sheet.
  MarkAsFinal                      Marks the workbook as final and read-only.
:::

 

Public Properties

 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                                                                                                   |
+===================================+===============================================================================================================================================================================================+
| ActivePane                        | Identifier of pane with active cell cursor.                                                                                                                                                   |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| AutoFilters                       | Returns collection of worksheet\'s autofilters. This is a Read-Only property.                                                                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Cells                             | Returns all used cells in the worksheet. This is a Read-Only property.                                                                                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Charts                            | Returns charts collection. This is a Read-Only property.                                                                                                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CodeName                          | Name that is used by macros to access the workbook items. This is a Read-Only property.                                                                                                       |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Columns                           | For a Worksheet object, returns an array of Range objects that represents all the columns on the specified worksheet.                                                                         |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Comments                          | Comments collection.                                                                                                                                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CustomProperties                  | Returns collection of custom properties. This is a Read-Only property.                                                                                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DisplayPageBreaks                 | This property is set to true if page breaks (both automatic and manual) on the specified worksheet are displayed.                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FirstVisibleColumn                | Index to first visible column in right pane(s).                                                                                                                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FirstVisibleRow                   | Index to first visible row in bottom pane(s).                                                                                                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| HorizontalSplit                   | Position of the horizontal split (by, 0 = No horizontal split): Unfrozen pane: Height of the top pane(s) (in twips = 1/20 of a point) Frozen pane: Number of visible rows in top pane(s)      |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| HPageBreaks                       | Returns an HPageBreaks collection that represents the horizontal page breaks on the sheet. This is a Read-Only property.                                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| HyperLinks                        | Collection of all worksheet\'s hyperlinks.                                                                                                                                                    |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Index                             | Returns the index number of the object within the collection of similar objects. This is a Read-Only property.                                                                                |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsFreezePanes                     | Defines whether freezed panes are applied.                                                                                                                                                    |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsGridLinesVisible                | This property is set to true if gridlines are visible; false otherwise.                                                                                                                       |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsPasswordProtected               | Indicates if the worksheet is password protected.                                                                                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsRightToLeft                     | Indicates whether worksheet is displayed right to left.                                                                                                                                       |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsRowColumnHeadersVisible         | This property is set to true if row and column headers are visible; false otherwise.                                                                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsSelected                        | Indicates whether tab of this sheet is selected.  This is a Read-Only property.                                                                                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsStringsPreserved                | Indicates if all values in the workbook are preserved as strings.                                                                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| MergedCells                       | Returns all merged ranges. This is a Read-Only property.                                                                                                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| MigrantRange                      | Returns instance of migrant range - row and column of this range object can be changed by user. This is a Read-Only property.                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Name                              | Gets/sets name of the tab sheet.                                                                                                                                                              |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Names                             | For a Worksheet object, returns a Names collection that represents all the worksheet-specific names (names defined with the \"WorksheetName!\" prefix). Read-Only Names object.               |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| PageSetup                         | Returns a PageSetup object that contains all the page setup settings for the specified object. This is a Read-Only property.                                                                  |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Pictures                          | Returns pictures collection. This is a Read-Only property.                                                                                                                                    |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ProtectContents                   | Indicates if current sheet is protected.                                                                                                                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ProtectDrawingObjects             | This property is set to true if objects are protected. This is a Read-Only property.                                                                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Protection                        | Gets protected options. For setting the protection options, use \"Protect\" method.                                                                                                           |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ProtectScenarios                  | This property is set to true if the scenarios of the current sheet are protected. This is a Read-Only property.                                                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Range                             | Returns a Range object that represents a cell or a range of cells.                                                                                                                            |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Rows                              | For a Worksheet object, returns an array of Range objects that represents all the rows on the specified worksheet.                                                                            |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SplitCell                         | Return split cell range.                                                                                                                                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardHeight                    | Returns or sets the standard (default) height of all the rows in the worksheet, in points.                                                                                                    |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardHeightFlag                | Returns or sets the standard (default) height option flag, which defines that standard (default) row height and book default font height do not match.                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| StandardWidth                     | Returns or sets the standard (default) width of all the columns in the worksheet.                                                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TabColor                          | Gets/sets tab color.                                                                                                                                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TabColorRGB                       | Gets/sets tab color.                                                                                                                                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TabIndex                          | Returns index in the parent ITabSheets collection. This is a Read-Only property.                                                                                                              |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Type                              | Returns or sets the worksheet type.                                                                                                                                                           |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UsedCells                         | Returns all accessed cells. This is a Read-Only property.                                                                                                                                     |
|                                   |                                                                                                                                                                                               |
|                                   |                                                                                                                                                                                               |
|                                   |                                                                                                                                                                                               |
|                                   | WARNING: This property creates Range object for each cell in the worksheet, and creates new array each time user calls to it. It can cause huge memory usage especially if called frequently. |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UsedRange                         | Returns a Range object that represents the used range on the specified worksheet. This is a Read-Only property.                                                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UseRangesCache                    | Indicates whether all created range objects should be cached. Default value is false.                                                                                                         |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| VerticalSplit                     | Position of the vertical split (px, 0 = No vertical split): Unfrozen pane: Width of the left pane(s) (in twips = 1/20 of a point) Frozen pane: Number of visible columns in left pane(s).     |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Visibility                        | Control visibility of worksheet to end-user.                                                                                                                                                  |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| VPageBreaks                       | Returns a VPageBreaks collection that represents the vertical page breaks on the sheet. This is a Read-Only property.                                                                         |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Workbook                          | Returns parent workbook. This is a Read-Only property.                                                                                                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Zoom                              | Zoom factor of document. Value must be in range from 10 till 400.                                                                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{#related-topics}
::::::
