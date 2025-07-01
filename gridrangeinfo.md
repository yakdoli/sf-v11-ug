::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### GridRangeInfo {#gridrangeinfo style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This class is used extensively to specify a collection of grid cells that are to be used as parameters for other method calls. **GridRangeInfo** class contains static methods that will allow you to specify a single cell, a rectangular range of cells, a row or rows, a column or columns, or the entire table.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------
  GridRangeInfo Method                                            Description
  GridRangeInfo.Cell(int row, int col)                            Returns the GridRangeInfo object with cell row, col.
  GridRangeInfo.Cells(int top, int left, int bottom, int right)   Returns a GridRangeInfo object containing a rectangular collection of cells with top left cell (top, left) and bottom right cell (bot, right).
  GridRangeInfo.Row(int row)                                      Returns GridRangeInfo object with row = row.
  GridRangeInfo.Rows(int fromRow, int toRow)                      Returns a GridRangeInfo object containing rows fromRow through toRow.
  GridRangeInfo.Col(int col)                                      Returns GridRangeInfo object with column col.
  GridRangeInfo.Cols(int fromCol, int toCol)                      Returns a GridRangeInfo object containing columns fromCol through toCol.
  GridRangeInfo.Table()                                           Returns a GridRangeInfo object containing the whole table.
  --------------------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image91_1.jpg){border="0"}Note: For a complete description of the GridRangeInfo class, see the Essential Grid Class Reference.
:::

 

[]{#p76} 

 

[]{#related-topics}
:::::
