::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to Copy and Paste the Display Text {#how-to-copy-and-paste-the-display-text style="TEXT-ALIGN: justify; tab-stops: 0pt"}

By default, when you copy and paste the formula cell, the Spreadsheet control will copy and paste the formula from the particular cell. To copy and paste the display text you have to handle the **ClipboardCopy** event of the underling grid control. You can get all the Grid controls in the **WorkBookLoaded** event of the spreadsheet control.

The following code used to copy and paste only the display text.

+---------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                          |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
| void spreadsheetControl_WorkBookLoaded(object sender, WorkbookLoadedEventArgs args)                                       |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
| {                                                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     foreach (var grid in args.GridCollection)                                                                             |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     {                                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|         grid.Model.GridCopyPaste = null;                                                                                  |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|         grid.Model.ClipboardCopy += new GridCutPasteEventHandler(Model_ClipboardCopy);                                    |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     }                                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
| }                                                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
| void Model_ClipboardCopy(object sender, GridCutPasteEventArgs e)                                                          |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
| {                                                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     GridRangeInfoList rowRanges = e.RangeList.GetRowRanges(GridRangeInfoType.Cells | GridRangeInfoType.Rows);             |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     GridRangeInfoList colRanges = e.RangeList.GetColRanges(GridRangeInfoType.Cells | GridRangeInfoType.Cols);             |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     var sb = new StringBuilder();                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     int nrowsdone = 0; int ncolsdone = 0;                                                                                 |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     string tabDelim = "\t";                                                                                               |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     for (int rowindex = 0; rowindex < rowRanges.Count; rowindex++)                                                        |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     {                                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|         for (int nrow = rowRanges[rowindex].Top; nrow <= rowRanges[rowindex].Bottom; nrow++)                              |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|         {                                                                                                                 |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             if (nrowsdone > 0)                                                                                            |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                 sb.Append(Environment.NewLine);                                                                           |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             ncolsdone = 0;                                                                                                |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             bool firstCol;                                                                                                |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             firstCol = true;                                                                                              |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             for (int colindex = 0; colindex < colRanges.Count; colindex++)                                                |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             {                                                                                                             |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                 for (int ncol = colRanges[colindex].Left; ncol <= colRanges[colindex].Right; ncol++)                      |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                 {                                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     if (!firstCol)                                                                                        |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                         sb.Append(tabDelim);                                                                              |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     string text = this.spreadsheetControl.GridProperties.CurrentExcelGridModel[nrow, ncol].FormattedText; |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     if (!e.RangeList.AnyRangeContains(GridRangeInfo.Cell(nrow, ncol)))                                    |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     {                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                         ncolsdone++;                                                                                      |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                         continue;                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     }                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     text = new StringBuilder(text).ToString().Trim();                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     // Append the Cell value to buffer text                                                               |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     sb.Append(text);                                                                                      |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     firstCol = false;                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                     ncolsdone++;                                                                                          |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|                 }                                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             }                                                                                                             |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|             nrowsdone++;                                                                                                  |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|         }                                                                                                                 |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     }                                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     Clipboard.SetText(sb.ToString());                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     e.DataObject = null;                                                                                                  |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
|     e.Handled = true;                                                                                                     |
| ```                                                                                                                       |
|                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                         |
| }                                                                                                                         |
| ```                                                                                                                       |
|                                                                                                                           |
|                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
