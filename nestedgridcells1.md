::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Nested Grid Cells {#nested-grid-cells style="tab-stops: 0pt"}

Nested grids are an important component of the basic architecture of Essential Grid. They provide for the easy display of complex user interfaces using a flat grid. They also form the underpinnings for the display of hierarchical and grouped data. You can nest grids inside a row, column or covered range. When you nest a grid inside a covered range you can specify whether the rows or columns derive their state from the parent control. You have multiple independent options for both rows and columns.

 

API definition

GridCellNestedGridModel is the class to be used as model class for this cell type. Its constructor accepts two objects of type GridNestedAxisLayout enum, where the first parameter corresponds to row and second parameter corresponds to grid column. This  enum value determines whether to share the row layout or column layout or the rows and columns are independent of parent grid.

Nested Grid inside a Row of Parent Grid[]{style="COLOR: #15428b"}

In this case, the grid will maintain its own row heights. When you resize rows the grid will also notify the parent grid that its total height is changed. While scrolling you can scroll row by row through the nested grid. The nested grid will have no separate scrollbars. They are shared with the parent grid.

 

Example

The code below implements a nested scroll grid. The GridCellNestedScrollGridModel is the model class to be used.

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                     |
|                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                |
| [// Add Nested Scroll Grid cell model.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                      |
|                                                                                                                                                                |
| [GridCellNestedScrollGridModel scrollGridModel = [new]{style="COLOR: blue"} GridCellNestedScrollGridModel();]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                |
| [Model.CellModels.Add([\"ScrollGrid\"]{style="COLOR: #a31515"}, scrollGridModel);]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                |
| [Model\[40, 2\].CellType = [\"ScrollGrid\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [// Create scroll nested grid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                |
| [GridModel nestedGrid = [new]{style="COLOR: blue"} GridModel();]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                |
| [nestedGrid.Options.AllowSelection = GridSelectionFlags.Cell;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                |
| [nestedGrid.RowHeights.DefaultLineSize = 20;]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                |
| [nestedGrid.RowCount = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                |
| [nestedGrid.ColumnWidths.DefaultLineSize = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                |
| [nestedGrid.ColumnCount = 12;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [Brush headerBrush = ColorHelper.CreateFrozenSolidColorBrush(128, Colors.DarkGray);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                |
| [nestedGrid.BaseStylesMap\[[\"Header\"]{style="COLOR: #a31515"}\].StyleInfo.Background = headerBrush;]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} n = 0; n \< nestedGrid.RowCount; n++)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} c = 0; c \< nestedGrid.ColumnCount; c++)]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                |
| [        GridStyleInfo ci = [new]{style="COLOR: blue"} GridStyleInfo();]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                |
| [        ci.CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                |
| [        ci.CellValue = String.Format([\"Scroll{0}:{1}\"]{style="COLOR: #a31515"}, n, c);]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                |
| [        nestedGrid.Data\[n, c\] = ci.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [Model\[40, 2\].CellValue = nestedGrid;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                |
| [CoveredCells.Add([new]{style="COLOR: blue"} CoveredCellInfo(40, 2, 49, 5));]{style="FONT-FAMILY: 'Courier New'"}                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Output

The following output is generated using the code above.

 

![](ImagesExt/image28_41.jpg){border="0"}

Figure 35: Nested Grid

 

The same way you can nest a grid inside a complete row you can also nest a grid inside a whole column.

Nested Grid Inside a Covered Range with its Rows Tied to the Rows of the Parent Grid

In this case, the grid will have its own unique column widths but the row heights are shared with the parent grid. When scrolling through rows in the nested grid you also scroll the rows in the parent grid to keep them in sync. The nested grid will have no separate scrollbars. They are shared with the parent grid. When you resize rows they will also be resized in the parent grid and vice versa.

 

Example

The codes below show a grid whose cell contains a nested grid, which again contains a nested grid in its cell, and this second nested grid again contains a nested grid in its cell and thus forming four grids nested within one another.

 

To specify shared row layout, use Shared option of GridNestedAxisLayout enum in the first parameter.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [// Add appropriate Nested Grid cell model.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                         |
| [GridCellNestedGridModel shareRow = [new]{style="COLOR: blue"} GridCellNestedGridModel (GridNestedAxisLayout.Shared, GridNestedAxisLayout.Normal);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [Model.CellModels.Add([\"ShareRowLayoutGrid\"]{style="COLOR: #a31515"}, shareRow);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [// Setup nested grid with shared row layout]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                                         |
| [Model\[100, 2\].CellType = [\"ShareRowLayoutGrid\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                         |
| [Model\[100, 2\].BorderMargins.Top = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                         |
| [Model\[100, 2\].BorderMargins.Left = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [Model\[100, 2\].BorderMargins.Right = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [Model\[100, 2\].BorderMargins.Bottom = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                         |
| [Model\[100, 2\].Background = SystemColors.InactiveCaptionBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [GridModel nestedGridWithSharedRowsModel = GetNestedGridWithSharedRowsModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                         |
| [Model\[100, 2\].CellValue = nestedGridWithSharedRowsModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                         |
| [CoveredCells.Add([new]{style="COLOR: blue"} CoveredCellInfo(100, 2, 100 + nestedGridWithSharedRowsModel.RowCount - 1, 5));]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [// Setup the top level(parent) nested grid]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                         |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ GridModel GetNestedGridWithSharedRowsModel()]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [GridModel model = [new]{style="COLOR: blue"} GridModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Pen gridLinePen = [new]{style="COLOR: blue"} Pen(Brushes.DarkGray, 1);]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                         |
| [gridLinePen.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [model.Options.AllowSelection = GridSelectionFlags.Cell;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                         |
| [model.ColumnWidths.DefaultLineSize = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [model.ColumnWidths.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [model.ColumnCount = 12;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [model.RowHeights.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model.RowHeights.FooterLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model.RowCount = 601; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                         |
| [Color clr = Color.FromArgb(128, 0, 0, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                         |
| [Brush headerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                         |
| [headerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Color clr2 = Color.FromArgb(128, 128, 0, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                         |
| [Brush footerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr2);]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                         |
| [footerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} n = 0; n \< model.RowCount; n++)]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} c = 0; c \< model.ColumnCount; c++)]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                         |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                         |
| [        GridStyleInfo ci = [new]{style="COLOR: blue"} GridStyleInfo();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                         |
| [        ci.CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                         |
| [        ci.CellValue = String.Format([\"{0}:{1}\"]{style="COLOR: #a31515"}, n, c);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Top = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Left = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Right = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Bottom = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                         |
| [        ci.Borders.Right = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [        ci.Background = [null]{style="COLOR: blue"};[// Brushes.White;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                         |
| [        ci.Borders.Bottom = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        model.Data\[n, c\] = ci.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [        [if]{style="COLOR: blue"} (c == 0 \|\| n == 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [            ci.Background = headerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [        [if]{style="COLOR: blue"} (n == model.RowCount - 1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [            ci.Background = footerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [GridModel nestedGridWithSharedRowsModel = GetSecondNestedGridWithSharedRowsModel();]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                         |
| [model\[10, 2\].CellType = [\"ShareRowLayoutGrid\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                         |
| [model\[10, 2\].BorderMargins.Top = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model\[10, 2\].BorderMargins.Left = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                         |
| [model\[10, 2\].BorderMargins.Right = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [model\[10, 2\].BorderMargins.Bottom = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [model\[10, 2\].Background = SystemColors.InactiveCaptionBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [// Creates a nested grid for second level.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                         |
| [model\[10, 2\].CellValue = nestedGridWithSharedRowsModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| [model.CoveredCells.Add([new]{style="COLOR: blue"} CoveredCellInfo(10, 2, 10 + nestedGridWithSharedRowsModel.RowCount - 1, 7));]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                         |
| [model.SelectedCells = GridRangeInfo.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [return]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ model;]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [// Setup the second level nested grid]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                         |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ GridModel GetSecondNestedGridWithSharedRowsModel()]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [GridModel model = [new]{style="COLOR: blue"} GridModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Pen gridLinePen = [new]{style="COLOR: blue"} Pen(Brushes.DarkGray, 1);]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                         |
| [gridLinePen.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [model.Options.AllowSelection = GridSelectionFlags.Cell;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                         |
| [model.ColumnWidths.DefaultLineSize = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [model.ColumnWidths.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [model.ColumnCount = 8;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [model.RowHeights.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model.RowHeights.FooterLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model.RowCount = 121; [// make sure this matched covered cell size \...]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                         |
| [Color clr = Color.FromArgb(128, 0, 0,128);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                         |
| [Brush headerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                         |
| [headerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Color clr2 = Color.FromArgb(128, 0, 128, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                         |
| [Brush footerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr2);]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                         |
| [footerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} n = 0; n \< model.RowCount; n++)]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} c = 0; c \< model.ColumnCount; c++)]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                         |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                         |
| [        GridStyleInfo ci = [new]{style="COLOR: blue"} GridStyleInfo();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                         |
| [        ci.CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                         |
| [        ci.CellValue = String.Format([\"{0}:{1}\"]{style="COLOR: #a31515"}, n, c);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Top = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Left = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Right = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Bottom = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                         |
| [        ci.Borders.Right = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [        ci.Background = [null]{style="COLOR: blue"};[// Brushes.White;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                         |
| [        ci.Borders.Bottom = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        model.Data\[n, c\] = ci.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [        [if]{style="COLOR: blue"} (c == 0 \|\| n == 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [            ci.Background = headerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [        [if]{style="COLOR: blue"} (n == model.RowCount - 1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [            ci.Background = footerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [GridModel nestedGridWithSharedRowsModel = GetThirdNestedGridWithSharedRowsModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                         |
| [model\[15, 2\].CellType = [\"ShareRowLayoutGrid\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                         |
| [model\[15, 2\].BorderMargins.Top = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model\[15, 2\].BorderMargins.Left = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                         |
| [model\[15, 2\].BorderMargins.Right = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [model\[15, 2\].BorderMargins.Bottom = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [model\[15, 2\].Background = Brushes.Wheat;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                         |
| [// Creates a nested grid for third level.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                                         |
| [model\[15, 2\].CellValue = nestedGridWithSharedRowsModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| [model.CoveredCells.Add([new]{style="COLOR: blue"} CoveredCellInfo(15, 2, 15 + nestedGridWithSharedRowsModel.RowCount - 1, 5));]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                         |
| [model.SelectedCells = GridRangeInfo.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [return]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ model;]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [// Setup the third level nested grid]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                                         |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ GridModel GetThirdNestedGridWithSharedRowsModel()]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [GridModel model = [new]{style="COLOR: blue"} GridModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Pen gridLinePen = [new]{style="COLOR: blue"} Pen(Brushes.DarkGray, 1);]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                         |
| [gridLinePen.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [model.Options.AllowSelection = GridSelectionFlags.Cell;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                         |
| [model.ColumnWidths.DefaultLineSize = 35;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [model.ColumnWidths.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [model.ColumnCount = 4;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [model.RowHeights.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model.RowHeights.FooterLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                         |
| [model.RowCount = 31; [// make sure this matched covered cell size \...]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                         |
| [Color clr = Color.FromArgb(128, 0, 128, 128);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                         |
| [Brush headerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                         |
| [headerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Color clr2 = Color.FromArgb(128, 128, 128, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                         |
| [Brush footerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr2);]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                         |
| [footerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} n = 0; n \< model.RowCount; n++)]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} c = 0; c \< model.ColumnCount; c++)]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                         |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                         |
| [        GridStyleInfo ci = [new]{style="COLOR: blue"} GridStyleInfo();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                         |
| [        ci.CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                         |
| [        ci.CellValue = String.Format([\"{0}:{1}\"]{style="COLOR: #a31515"}, n, c);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Top = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Left = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Right = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                         |
| [        ci.BorderMargins.Bottom = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                         |
| [        ci.Borders.Right = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                         |
| [        ci.Background = [null]{style="COLOR: blue"};[// Brushes.White;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                         |
| [        ci.Borders.Bottom = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        model.Data\[n, c\] = ci.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [        [if]{style="COLOR: blue"} (c == 0 \|\| n == 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [            ci.Background = headerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [        [if]{style="COLOR: blue"} (n == model.RowCount - 1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                         |
| [            ci.Background = footerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                         |
| [model.SelectedCells = GridRangeInfo.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                         |
| [return]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ model;]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Output

The following output is generated using the code above.

 

![](ImagesExt/image28_42.jpg){border="0"}

Figure 36: Nested Grid-Rows tied to the Parent Grid Rows

 

Nested Grid Inside a Covered Range with its Columns Tied to the Columns of the Parent Grid

In this case the grid will have its own unique row height but the column widths are shared with the parent grid. When scrolling through columns in the nested grid you also scroll the columns in the parent grid to keep them in sync. The nested grid will have no scrollbars. They are shared with the parent grid. When you resize columns they will also be resized in parent grid and vice versa.

 

Example

To specify shared column layout, use Shared option of GridNestedAxisLayout enum in the second parameter.

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                 |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [// Add the appropriate nested grid cell model.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                                            |
| [GridCellNestedGridModel shareColumn = [new]{style="COLOR: blue"} GridCellNestedGridModel (GridNestedAxisLayout.Normal, GridNestedAxisLayout.Shared);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [Model.CellModels.Add([\"ShareColumn\"]{style="COLOR: #a31515"}, shareColumnLayoutGridModel);]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                            |
| [Model\[60, 1\].CellType = [\"ShareColumnLayoutGrid\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [Model\[60, 1\].BorderMargins.Top = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                            |
| [Model\[60, 1\].BorderMargins.Left = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                            |
| [Model\[60, 1\].BorderMargins.Right = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                            |
| [Model\[60, 1\].BorderMargins.Bottom = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                            |
| [Model\[60, 1\].Background = SystemColors.InactiveCaptionBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                            |
| [GridModel nestedGridWithSharedColumnsModel = GetNestedGridWithSharedColumnsModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [// Creates a nested grid with shared column layout.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                    |
|                                                                                                                                                                                            |
| [Model\[60, 1\].CellValue = nestedGridWithSharedColumnsModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                            |
| [CoveredCells.Add([new]{style="COLOR: blue"} CoveredCellInfo(60, 1, 80, 1 + nestedGridWithSharedColumnsModel.ColumnCount - 1));]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [// Sets up a nested grid with column layout shared]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                            |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ GridModel GetNestedGridWithSharedColumnsModel()]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                            |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                            |
| [    GridModel model = [new]{style="COLOR: blue"} GridModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    Pen gridLinePen = [new]{style="COLOR: blue"} Pen(Brushes.DarkGray, 1);]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                            |
| [    gridLinePen.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    model.Options.AllowSelection = GridSelectionFlags.Cell;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [    model.ColumnWidths.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                            |
| [    model.ColumnCount = 10;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    model.RowHeights.HeaderLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                            |
| [    model.RowHeights.FooterLineCount = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                            |
| [    model.RowCount = 13;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                            |
| [    model.RowHeights.DefaultLineSize = 30;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    Color clr = Color.FromArgb(128, 0, 0, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                            |
| [    Brush headerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr);]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                            |
| [    headerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    Color clr2 = Color.FromArgb(128, 128, 0, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                            |
| [    Brush footerBrush = [new]{style="COLOR: blue"} SolidColorBrush(clr2);]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                            |
| [    footerBrush.Freeze();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} n = 0; n \< model.RowCount; n++)]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                            |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                            |
| [        [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} c = 0; c \< model.ColumnCount; c++)]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                            |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                            |
| [            GridStyleInfo ci = [new]{style="COLOR: blue"} GridStyleInfo();]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                            |
| [            ci.CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                            |
| [            ci.CellValue = String.Format([\"{0}:{1}\"]{style="COLOR: #a31515"}, n, c);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                            |
| [            ci.BorderMargins.Top = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                            |
| [            ci.BorderMargins.Left = gridLinePen.Thickness;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                            |
| [            ci.BorderMargins.Right = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                            |
| [            ci.BorderMargins.Bottom = gridLinePen.Thickness / 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                            |
| [            ci.Borders.Right = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                            |
| [            ci.Background = [null]{style="COLOR: blue"};[// Brushes.White;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                            |
| [            ci.Borders.Bottom = gridLinePen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                            |
| [            model.Data\[n, c\] = ci.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [            [if]{style="COLOR: blue"} (c == 0 \|\| n == 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [                ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                            |
| [                ci.Background = headerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                            |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [            [if]{style="COLOR: blue"} (c == 3 \|\| n == 3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [                ci.CellType = [\"CheckBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                            |
| [                ci.CellValue = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                            |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [            [if]{style="COLOR: blue"} (c == 4 \|\| n == 4)]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [                ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                            |
| [                ci.CellValue = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                            |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [            [if]{style="COLOR: blue"} (n == model.RowCount - 1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [                ci.CellType = [\"Static\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                            |
| [                ci.Background = footerBrush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                            |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                            |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                            |
| [    model.SelectedCells = GridRangeInfo.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [    [return]{style="COLOR: blue"} model;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                            |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Output

The following output is generated using the code above.

 

![](ImagesExt/image28_43.jpg){border="0"}

Figure 37: Nested Grid-Columns tied to the Parent Grid Columns

 

Nested Grid Inside a Covered Range with its Rows and Columns Independent of Parent Grid

In this case, the nested grid maintains its own row heights and column widths. You can scroll through this grid without scrolling the parent grid. Resizing rows and columns in this grid will also not affect the parent grid.

 

Example

To make rows and columns independent of parent grid, the GridNestedAxisLayout enum must be set to Normal in both the parameters.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                               |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                      |
|                                                                                                                                                                                          |
| [// Add Nested Grid cell model.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                          |
| [GridCellNestedGridModel gridModel = [new]{style="COLOR: blue"} GridCellNestedGridModel (GridNestedAxisLayout.Normal, GridNestedAxisLayout.Normal);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [Model.CellModels.Add([\"Grid\"]{style="COLOR: #a31515"}, gridModel);]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [CoveredCells.Add([new]{style="COLOR: blue"} CoveredCellInfo(6, 2, 8, 4));]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [Model\[6, 2\].CellType = [\"Grid\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [// Create a simple nested grid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                          |
| [GridModel model = [new]{style="COLOR: blue"} GridModel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [model.Options.AllowSelection = GridSelectionFlags.Cell;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                          |
| [model.RowHeights.DefaultLineSize = 20;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                          |
| [model.RowCount = 20;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [model.ColumnWidths.DefaultLineSize = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                          |
| [model.ColumnCount = 8;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [model.HeaderRows = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                          |
| [model.FrozenRows = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                          |
| [model.HeaderColumns = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                          |
| [model.FrozenColumns = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} n = 0; n \< model.RowCount; n++)]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                          |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                          |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} c = 0; c \< model.ColumnCount; c++)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                          |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                          |
| [        GridStyleInfo ci = [new]{style="COLOR: blue"} GridStyleInfo();]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                          |
| [        ci.CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                          |
| [        ci.CellValue = String.Format([\"{0}:{1}\"]{style="COLOR: #a31515"}, n, c);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                          |
| [        [//ci.Background =  transparentBlanchedAlmond;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                          |
| [        model.Data\[n, c\] = ci.Store;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                          |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                          |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [Model\[6, 2\].CellValue = model;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Output

The following output is generated using the code above.

 

![](ImagesExt/image28_44.jpg){border="0"}

Figure 38: Nested Grid-Rows and Columns Independent of Parent Grid

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image28_3.jpg){border="0"}Note: For complete code, please refer to the following browser sample.
:::

*[]{style="COLOR: #15428b"}* 

***\...\\My Documents\\Syncfusion\\EssentialStudio\\\<Version Number\>\\Grid.WPF\\Samples\\3.5\\WindowsSamples\\Cell Types\\Nested Grid Demo***

**** 

[]{#related-topics}
::::
