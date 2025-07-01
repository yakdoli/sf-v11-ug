::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Excel-like UI {#excel-like-ui style="tab-stops: 0pt"}

Grids can be adopted in many real time applications where the database is of crucial importance. As such applications are widely spread; the grids are indispensably used world-wide.  This section elaborates on some of the real time applications which can use Essential Grid.

 

Real-time Applications

 

Some real time applications which can use Essential Grid are listed below:

 

[·      ]{style="FONT-FAMILY: Symbol"}Applications with high frequency updates

[·      ]{style="FONT-FAMILY: Symbol"}Excel like UI applications

**[]{style="COLOR: #15428b"}** 

1\. Applications with High Frequency Updates

 

Grid can be used in applications with frequent updates, for example stock values in share market. When grid is switched over to virtual mode, it reforms itself as a light weight control that consumes a very little memory and processing power, and provides a very small latency under heavy load. Such virtual grids are typically useful when there is a need to display enormous data very quickly. 

 

Sample

 

A sample which demonstrates such an application is available in the following sample installation location:

 

***\...\\My Documents\\Syncfusion\\EssentialStudio\\\<Version Number\>\\WPF\\Grid.WPF\\Samples\\3.5\\WindowsSamples\\Performance\\Trader Grid Test Demo***

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image28_3.jpg){border="0"}Note: Refer Performance Optimization section which elaborates on this sample.
:::

**[]{style="COLOR: #15428b"}** 

2\. Excel-like UI Applications

**[]{style="COLOR: #15428b"}** 

Another important application is Excel like UI that simulates MS Excel 2007 and gives an appearance that resembles excel. This application exhibits the following excel characteristics:

 

[·      ]{style="FONT-FAMILY: Symbol"}Excel like Current Cell

[·      ]{style="FONT-FAMILY: Symbol"}Formula Cells

[·      ]{style="FONT-FAMILY: Symbol"}Excel like Selection Frame

[·      ]{style="FONT-FAMILY: Symbol"}Markup Headers

[·      ]{style="FONT-FAMILY: Symbol"}Workbook of sheets

[]{style="COLOR: #15428b"} 

a\. Excel-like Current Cell

 

You can select a current cell in the Grid, similar to the current cell behavior in MS Excel. This feature can be enabled, by setting GridModelOptions.ExcelLikeCurrentCell property to *true*, as follows: 

 

+--------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                   |
|                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                          |
|                                                                                                              |
| [grid.Model.Options.ExcelLikeCurrentCell = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

![](ImagesExt/image28_183.jpg){border="0"}

Figure 105: Grid Showing Excel like Current Cell Selection

***[]{style="COLOR: #15428b"}*** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image28_3.jpg){border="0"}Note:  If you have selected a current cell within a specified range, and when you move the current cell selection out of this range, the range will be cleared.
:::

**[]{style="COLOR: #15428b"}** 

b\. Excel-like Selection Frame

 

The active selection can be outlined with a selection frame by setting the GridModelOptions.ExcelLikeSelectionFrame property to true, as follows:

 

+-----------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                      |
|                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                             |
|                                                                                                                 |
| [grid.Model.Options.ExcelLikeSelectionFrame = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

![](ImagesExt/image28_184.jpg){border="0"}

Figure 106: Grid Displaying Excel like Selection Frame

[]{style="COLOR: #15428b"} 

c\. Formula Cells

 

As we discussed in the previous chapter, Grid control provides complete support to formula cells. It can be enabled for the grid by setting the format string, FormulaCell to the TableStyle.CellType property, as follows:

 

+-------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                        |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                               |
|                                                                                                                   |
| [grid.Model.TableStyle.CellType = [\"FormulaCell\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

![](ImagesExt/image28_185.jpg){border="0"}

Figure 107: Grid with Excel like Formula Cell

***[]{style="COLOR: #15428b"}*** 

d\. Markup Headers

 

In Excel, whenever a selection is made, the headers of those rows and columns which are involved in the selection will be highlighted. You can get a similar behavior in the Grid using the OnPrepareRenderCell event. 

 

OnPrepareRenderCell event-This event will be triggered for every cell when they are about to be rendered. Hence, using this event, the cells that are going to be rendered are identified and their headers are highlighted.

 

The following code illustrates how to handle this event:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                  |
|                                                                                                                                                                                                                      |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [override]{style="COLOR: blue"} [void]{style="COLOR: blue"} OnPrepareRenderCell(GridPrepareRenderCellEventArgs e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [    [base]{style="COLOR: blue"}.OnPrepareRenderCell(e);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                      |
| [    [if]{style="COLOR: blue"} (e.Cell.RowIndex == 0 && Model.SelectedRanges.AnyRangeIntersects(GridRangeInfo.Col(e.Cell.ColumnIndex)))]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                                      |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [        e.Style.Background = [this]{style="COLOR: blue"}.excelOrange;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                      |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [    [else]{style="COLOR: blue"} [if]{style="COLOR: blue"} (e.Cell.ColumnIndex == 0 && Model.SelectedRanges.AnyRangeIntersects(GridRangeInfo.Row(e.Cell.RowIndex)))]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                                      |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [        e.Style.Background = [this]{style="COLOR: blue"}.excelOrange;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                      |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

![](ImagesExt/image28_184.jpg){border="0"}

Figure 108: Grid with markup headers

[]{style="COLOR: #15428b"} 

e\. Workbook of Sheets

 

You can create a workbook with multiple sheets similar to excel, using a Tab control, where individual tab represents a worksheet embedded within a Grid control.

 

![](ImagesExt/image28_186.jpg){border="0"}

Figure 109: Grid with workbook of sheets

 

Complete Sample Output

 

![](ImagesExt/image28_187.jpg){border="0"}

Figure 110: Complete Sample Output

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image28_3.jpg){border="0"}Note: For the complete code for this example, refer the following browser sample:
:::

**** 

***\...\\My Documents\\Syncfusion\\EssentialStudio\\\<Version Number\>\\WPF\\Grid.WPF\\Samples\\3.5\\WindowsSamples\\Product Showcase\\Excel Like UI Demo***

**** 

[]{#p248}**** 

**** 

[]{#related-topics}
::::::
