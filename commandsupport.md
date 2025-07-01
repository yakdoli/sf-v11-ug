::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d168ab2b-16e7-4c8a-9892-66b05796144a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bc7b2eeb-dc61-4150-baca-ac07039fa9f0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Spreadsheet]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=56efc3c9-36bc-4be8-94d9-f1938dfb1d73){.d2h_breadcrumbsNormal}
:::

## Command Support {#command-support style="tab-stops: 0pt"}

The Spreadsheet control provides the build in commands to show case the features available in Spreadsheet. It can be executed in the Spreadsheet whenever it is bound to Command Property.

 

Table 2: Commands Table

::: {align="center"}
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| Property                         | Description                                                     | Type                | Data Type   | Reference links                 |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| BoldCommand                      | Command which will toggle bold.                                 | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ItalicCommand                    | Command which will toggle Italics.                              | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| UnderlineCommand                 | Command to change the underline.                                | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| CopyCommand                      | Command to copy the selected cells.                             | Dependency Property | CommandBase | NA                              |
|                                  |                                                                 |                     |             |                                 |
|                                  |                                                                 |                     |             |                                 |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| CutCommand                       | Command to cut the selected cells.                              | Dependency Property | CommandBase | NA                              |
|                                  |                                                                 |                     |             |                                 |
|                                  |                                                                 |                     |             |                                 |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| PasteCommand                     | Command to paste the cells from the clipboard.                  | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ColumnWidthCommand               | Command to customize the column width.                          | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ConditionalFormatCommand         | Command to apply conditional formatting for the selected cells. | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| DataValidationCommand            | Command to apply data validation for the selected cells.        | Dependency Property | CommandBase | Data Validation                 |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| DeleteCommentCommand             | Command to delete the comment.                                  | Dependency Property | CommandBase | Comments                        |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| DeleteColumnCommand              | Command to delete column.                                       | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| DeleteRowCommand                 | Command to delete row.                                          | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| DeleteCurrentSheetCommand        | Command to delete current sheet.                                | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| EncryptCommand                   | Command to encrypt the workbook.                                | Dependency Property | CommandBase | Encrypt Workbook                |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ExportToExcelCommand             | Command to save the workbook as Excel.                          | Dependency Property | CommandBase | Save Excel Document             |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| FormatAsTableCommand             | Command to format as table.                                     | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| HyperlinkCommand                 | Command to insert hyperlink.                                    | Dependency Property | CommandBase | Bookmarks and Hyperlink         |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ImportFromExcelCommand           | Command to import the Excel document to Spreadsheet.            | Dependency Property | CommandBase | Open Excel Document             |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| InsertCommentCommand             | Command to insert comment.                                      | Dependency Property | CommandBase | Comments                        |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| InsertPictureCommand             | Command to insert picture.                                      | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| InsertRowCommand                 | Command to insert row.                                          | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| InsertSheetCommand               | Command to insert worksheet.                                    | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ProtectCurrentSheetCommand       | Command to protect current worksheet.                           | Dependency Property | CommandBase | Protect and Unprotect Worksheet |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ProtectWorkbookCommand           | Command to protect workbook.                                    | Dependency Property | CommandBase | Protect and Unprotect Workbook  |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| RowHeightCommand                 | Command to customize row height.                                | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| ShowGridLinesCommand             | Command to show or hide gridlines.                              | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
| RowColumnHeadersVisiblityCommand | Command to show or hide row and column header.                  | Dependency Property | CommandBase | NA                              |
+----------------------------------+-----------------------------------------------------------------+---------------------+-------------+---------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Table 3: Commands Table

::: {align="center"}
  ------------------------------ ----------------------------------------------------------------------------------------------------- --------------------- ------------- --------------- ----------------------------
  Property                       Description                                                                                           Type                  Data Type     Parameter       Reference links
  BorderCommand                  Command to customize the cell border.                                                                 Dependency Property   CommandBase   String          Border
  FreezePaneCommand              Command to freeze rows and column.                                                                    Dependency Property   CommandBase   Freeze          Freeze Panes
  HideColumnCommand              Command to hide the column.                                                                           Dependency Property   CommandBase                   NA
  HideRowCommand                 Command to hide the row.                                                                              Dependency Property   CommandBase   Boolean         NA
  HideCurrentSheetCommand        Command to hide the current sheet.                                                                    Dependency Property   CommandBase   Boolean         Hide and Unhide Worksheet
  VerticalAlignmentCommand       Command to align[ ]{style="BACKGROUND: yellow"}the cells vertically. []{style="BACKGROUND: yellow"}   Dependency Property   CommandBase   String          NA
  MergeCommand                   Command to merge the cells.                                                                           Dependency Property   CommandBase   String          Merge Cells
  NewCommand                     Command to add new workbook.                                                                          Dependency Property   CommandBase   Int             Creating an Excel Document
  NumberFormatCommand            Command to apply number formatting.                                                                   Dependency Property   CommandBase   String          Number Formating
  IncreaseDecimalCommand         Command to increase decimal places.                                                                   Dependency Property   CommandBase   Boolean         NA
  IncreaseIndentCommand          Command to increase text margin.                                                                      Dependency Property   CommandBase   Boolean         NA
  InsertColumnCommand            Command to insert column.                                                                             Dependency Property   CommandBase   Boolean         NA
  HorizontalAlignmentCommand     Command to align the cells horizontally.                                                              Dependency Property   CommandBase   String          NA
  CellStyleCommand               Command to apply cell style.                                                                          Dependency Property   CommandBase   BuiltInStyles   NA
  FontFamilyCommand              Command to specify the font family.                                                                   Dependency Property   CommandBase   String          Font
  FontSizeCommand                Command to specify the font size.                                                                     Dependency Property   CommandBase   Double          Font
  ------------------------------ ----------------------------------------------------------------------------------------------------- --------------------- ------------- --------------- ----------------------------
:::

 

 

[]{#related-topics}
::::::
