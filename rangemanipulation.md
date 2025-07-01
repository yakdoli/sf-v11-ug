::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Range Manipulation {#range-manipulation style="tab-stops: 0pt"}

 

The **IRange** interface represents a single cell or a group of cells in a worksheet. XlsIO has several useful methods for manipulating the data and formatting it in the ranges. This section discusses the topics listed below.

 

[·      ]{style="FONT-FAMILY: Symbol"}Accessing a Range

[·      ]{style="FONT-FAMILY: Symbol"}IMigrant Range

[·      ]{style="FONT-FAMILY: Symbol"}Copying/Moving a Range

[·      ]{style="FONT-FAMILY: Symbol"}Clearing a Range

[·      ]{style="FONT-FAMILY: Symbol"}Getting Used Range

 

Accessing a Range

 

Range of cells can be accessed through the IRange interface. Following code example illustrates this.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Get cell range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ [this]{style="COLOR: blue"}\[[string]{style="COLOR: blue"} name\] { [get]{style="COLOR: blue"}; }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                                                                                             |
| [        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                             |
| [// Gets/sets cell by row and index.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                             |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ [this]{style="COLOR: blue"}\[[int]{style="COLOR: blue"} row, [int]{style="COLOR: blue"} column\] { [get]{style="COLOR: blue"}; }]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [// Get cell range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ [this]{style="COLOR: blue"}\[[string]{style="COLOR: blue"} name, [bool]{style="COLOR: blue"} IsR1C1Notation\] { [get]{style="COLOR: blue"}; }]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [// Get cells range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                             |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ [this]{style="COLOR: blue"}\[[int]{style="COLOR: blue"} row, [int]{style="COLOR: blue"} column, [int]{style="COLOR: blue"} lastRow, [int]{style="COLOR: blue"} lastColumn\] { [get]{style="COLOR: blue"}; }]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image47_1.jpg){border="0"}Note: Here row and column indexes in the range are \"one based\". Following code example explains various ways of accessing cells.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                        |
| [// Method 1 to Access a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                        |
| [sheet.Range\[[\"A7\"]{style="COLOR: #a31515"}\].Text = [\"Accessing a Range (Method 1)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Method 2 to Access a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                        |
| [sheet.Range\[9, 1\].Text = [\"Accessing a Range (Method 2)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Method 3 to Access a Range(using defined names).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                |
|                                                                                                                                                                        |
| [sheet.Range\[[\"Name\"]{style="COLOR: #a31515"}\].Text = [\"Accessing a Range (Method 3)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Accessing a Range of cells (Method 1).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                        |
| [sheet.Range\[[\"A13:C13\"]{style="COLOR: #a31515"}\].Text = [\"Accessing a Range of Cells (Method 1)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Accessing a Range of cells (Method 2).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                        |
| [sheet.Range\[15, 1, 15, 3\].Text = [\"Accessing a Range of Cells (Method 2)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Accessing a Range of cells (Method 3 using defined names).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                      |
|                                                                                                                                                                        |
| [sheet.Range\[[\"Name1\"]{style="COLOR: #a31515"}\].Text = [\"Accessing a Range of Cells (Method 3)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                   |
| [\' Method 1 to Access a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                |
|                                                                                                                                                                   |
| [sheet.Range([\"A7\"]{style="COLOR: maroon"}).Text = [\"Accessing a Range (Method 1)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                             |
|                                                                                                                                                                   |
| [\' Method 2 to Access a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                |
|                                                                                                                                                                   |
| [sheet.Range(9, 1).Text = [\"Accessing a Range (Method 2)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                             |
|                                                                                                                                                                   |
| [\' Method 3 to Access a Range(using defined names).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                           |
|                                                                                                                                                                   |
| [sheet.Range([\"Name\"]{style="COLOR: maroon"}).Text = [\"Accessing a Range (Method 3)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                             |
|                                                                                                                                                                   |
| [\' Accessing a Range of cells (Method 1).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                                   |
| [sheet.Range([\"A13:C13\"]{style="COLOR: maroon"}).Text = [\"Accessing a Range of Cells (Method 1)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                             |
|                                                                                                                                                                   |
| [\' Accessing a Range of cells (Method 2).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                                   |
| [sheet.Range(15, 1, 15, 3).Text = [\"Accessing a Range of Cells (Method 2)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                             |
|                                                                                                                                                                   |
| [\' Accessing a Range of cells (Method 3 using defined names).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                 |
|                                                                                                                                                                   |
| [sheet.Range([\"Name1\"]{style="COLOR: maroon"}).Text = [\"Accessing a Range of Cells (Method 3)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Accessing Discontinuous Ranges

 

You can also access different discontinuous ranges and add them to the **RangesCollection**, so that the same format is applied to different ranges. Following code example explains the same.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ range1 = sheet.Range\[ [\"A1:A2\"]{style="COLOR: #a31515"} \];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                   |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ range2 = sheet.Range\[[\"C1:C2\"]{style="COLOR: #a31515"} \];]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [RangesCollection ranges = [new]{style="COLOR: blue"} RangesCollection( engine.Excel, sheet );]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [ranges.Add( range1 );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                   |
| [ranges.Add( range2 );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                   |
| [ranges.Text = [\"Test\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                              |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ range1 [As]{style="COLOR: blue"} IRange = sheet.Range([\"A1:A2\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ range2 [As]{style="COLOR: blue"} IRange = sheet.Range([\"C1:C2\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ranges [As]{style="COLOR: blue"} RangesCollection = [New]{style="COLOR: blue"} RangesCollection(engine.Excel, sheet)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [ranges.Add(range1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                   |
| [ranges.Add(range2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                   |
| [ranges.Text = [\"Test\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

IMigrantRange

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **IMigrantRange** interface can be used to access the worksheet range and manipulate it. This is an optimal method of writing strings with better memory performance. Following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                           |
|                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                            |
| [// Writing Data.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                            |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} row = 1; row \<= rowCount; row++)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                            |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                            |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} column = 1; column \<= colCount; column++)]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                            |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                            |
| [        [// Writing values.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                            |
| [        migrantRange.ResetRowColumn(row, column);]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                            |
| [        migrantRange.Text = [\"Test\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                            |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                            |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                           |
|                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                     |
|                                                                                                                                                                                |
| [\' Writing Data.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                           |
|                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ row [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                            |
|                                                                                                                                                                                |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  row = 1 [To]{style="COLOR: blue"}  rowCount [Step]{style="COLOR: blue"}  row + 1]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ column [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                |
| [      [For]{style="COLOR: blue"}  column = 1 [To]{style="COLOR: blue"}  colCount [Step]{style="COLOR: blue"}  column + 1]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [\' Writing values.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                         |
|                                                                                                                                                                                |
| [            migrantRange.ResetRowColumn(row, column)]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                |
| [            migrantRange.Text = [\"Test\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| [      [Next]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Copying/Moving Range

 

Moving and copying cells is a very common procedure when you are creating or editing your worksheets. XlsIO provides support to copy a range of cells from one end to another. **CopyTo** method enables copying range of cells from the source to destination. It has an option to copy all the formats or only specific formats to the destination range by using the **ExcelCopyRangeOptions** enumerator. Following values can be set for the ExcelCopyRangeOptions.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------------
  Member Name              Description
  None                     No flags.
  UpdateFormulas           Indicates whether update formula during copy. WARNING: you should always specify this flag if your operations could change the position of Array formula.
  UpdateMerges             Indicates whether update merges during copy.
  CopyStyles               Indicates that we have to copy styles during range copy.
  CopyShapes               Indicates that we have to copy shapes during range copy.
  CopyErrorIndicators      Indicates that we have to copy error indicators during range copy.
  CopyConditionalFormats   Indicates that we have to copy conditional formats during range copy.
  All                      All flags.
  ------------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

Following code example illustrates how to copy a range of cells from the source to destination preserving only cell styles.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                    |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                          |
|                                                                                                                                                                                     |
| [// Copying a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} IRange = sheet.Range([\"A1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ des [As]{style="COLOR: blue"} IRange = sheet.Range([\"A5\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                     |
| [source.CopyTo(des)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                          |
|                                                                                                                                                                                     |
| [\' Copying a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} IRange = sheet.Range([\"A1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ des [As]{style="COLOR: blue"} IRange = sheet.Range([\"A5\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                     |
| [source.CopyTo(des)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**MoveTo** method is used for moving a range of cells to the destination. The only difference between copy and move operation is that Move will not create a copy in the source. This is similar to the **Cut** and **Paste** option in Excel.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image47_1.jpg){border="0"}Note: Move does not update formulas.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                    |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                          |
|                                                                                                                                                                                     |
| [// Moving a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} IRange = sheet.Range([\"A1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ des [As]{style="COLOR: blue"} IRange = sheet.Range([\"A5\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                     |
| [source.MoveTo(des)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                          |
|                                                                                                                                                                                     |
| [\' Moving a Range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} IRange = sheet.Range([\"A1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ des [As]{style="COLOR: blue"} IRange = sheet.Range([\"A5\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                     |
| [source.MoveTo(des)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Clearing a Range

 

While editing Excel workbooks, one of the most common action that users perform is clearing or deleting cells. Clearing cells mean erasing everything within them, whereas deleting actually deletes the entire cell. You can clear the cell content by using the **Clear** method. XlsIO also provides options to clear styles or data alone.

 

Following code example illustrates how to clear a range along with its formatting.

 

+---------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                            |
|                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                             |
| [// Clearing a Range and its formatting.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                             |
| [sheet.Range\[\"A4\"\].Clear(true);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}      |
+---------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                        |
|                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                             |
| [\' Clearing a Range and its formatting.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                             |
| [sheet.Range(\"A4\").Clear(True)]{style="FONT-FAMILY: 'Courier New'"}                       |
+---------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Getting Used Range

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

XlsIO enables to get the range of cells used in a given sheet. This will help the user to apply the same format to all the cells used in the worksheet. You can also get the first row/column, last row/column, and number of rows/columns used in the sheet, by using the various methods of IRange.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image47_1.jpg){border="0"}Note: By default, XlsIO considers a cell as used, even if there exists some formatting. You can disable this behavior, and make XlsIO consider a cell as used, only when there exists data, by using the UsedRangeIncludesFormatting property.
:::

 

Following code example is used to format the Used Range.

 

+----------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                       |
|                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                        |
| [// Modifying only the Used Ranges.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                        |
| [sheet.UsedRange.ColumnWidth = 20;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}  |
|                                                                                        |
| [sheet.UsedRange.RowHeight = 20;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}    |
+----------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                   |
|                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                        |
| [\' Modifying only the Used Ranges.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                        |
| [sheet.UsedRange.ColumnWidth = 20]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}   |
|                                                                                        |
| [sheet.UsedRange.RowHeight = 20]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}     |
+----------------------------------------------------------------------------------------+

 

[]{#p51}**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}** 

[]{#related-topics}
:::::::
