::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to align the summary cells in the GridGroupingControl {#how-to-align-the-summary-cells-in-the-gridgroupingcontrol style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can align the summary cells of the GridGroupingControl by making use of the **Horizontal Alignment** property, as shown below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                  |
| [GridSummaryColumnDescriptor]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sumCol1 = [new]{style="COLOR: blue"} [GridSummaryColumnDescriptor]{style="COLOR: #2b91af"}([\"sumCol1\"]{style="COLOR: #a31515"}, SummaryType.DoubleAggregate, [\"Col1\"]{style="COLOR: #a31515"}, [\"{Sum}\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                  |
| [sumCol1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sumCol1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} GridSummaryColumnDescriptor([\"sumCol1\"]{style="COLOR: #a31515"}, SummaryType.DoubleAggregate, [\"Col1\"]{style="COLOR: #a31515"}, [\"{Sum}\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                    |
| [sumCol1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p665} 

 

[]{#related-topics}
:::
