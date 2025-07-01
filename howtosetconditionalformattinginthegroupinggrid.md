::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to set conditional formatting in the GroupingGrid {#how-to-set-conditional-formatting-in-the-groupinggrid style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To set up a conditional formatting in the GroupingGrid, use the following code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                   |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                           |
|                                                                                                                                                                  |
| [// Declaring a conditional format descriptor.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                |
|                                                                                                                                                                  |
| [GridConditionalFormatDescriptor gcfd = [new]{style="COLOR: blue"} GridConditionalFormatDescriptor();]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                  |
| [// Setting some properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                   |
|                                                                                                                                                                  |
| [gcfd.Appearance.AnyRecordFieldCell.Font.Bold = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                  |
| [gcfd.Appearance.AnyRecordFieldCell.Interior = [new]{style="COLOR: blue"} BrushInfo(Color.LightGreen);]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                  |
| [//Expression which is applied on the table data.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                             |
|                                                                                                                                                                  |
| [gcfd.Expression = [\"\[ColumnName\] like \\\'true\\\'\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                  |
| [// Setting name to the conditional format and adding it to the grid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                         |
|                                                                                                                                                                  |
| [gcfd.Name = [\"gcfd\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.TableDescriptor.ConditionalFormats.Add(gcfd);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                             |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                       |
|                                                                                                                                                                                                                            |
| [\' Declaring a conditional format descriptor.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ gcfd [As]{style="COLOR: blue"} GridConditionalFormatDescriptor = [New]{style="COLOR: blue"} GridConditionalFormatDescriptor()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [\' Setting some properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                                            |
| [gcfd.Appearance.AnyRecordFieldCell.Font.Bold = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                            |
| [gcfd.Appearance.AnyRecordFieldCell.Interior = [New]{style="COLOR: blue"} BrushInfo(Color.LightGreen)]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [\' Expression which is applied on the table data.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                                                                            |
| [gcfd.Expression = [\"\[ColumnName\] like \'true\'\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                                                      |
|                                                                                                                                                                                                                            |
| [\' Setting name to the conditional format and adding it to the grid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                                                            |
| [gcfd.Name = [\"gcfd\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.TableDescriptor.ConditionalFormats.Add(gcfd)]{style="FONT-FAMILY: 'Courier New'"}                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p681} 

 

[]{#related-topics}
:::
