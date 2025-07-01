::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Chart Axis Events {#chart-axis-events style="tab-stops: 0pt"}

ChartAxis events that could be used to track the Axis changes are as follows.

Axis.Changed

This event is triggered whenever any properties of the axis are changed.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [Area.PrimaryAxis.Changed += [new]{style="COLOR: blue"} [EventHandler]{style="COLOR: #2b91af"}(PrimaryAxis_Changed);   ]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [// PrimaryAxis.Changed Event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                               |
|                                                                                                                                                                                                |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PrimaryAxis_Changed([object]{style="COLOR: blue"} sender, [EventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                |
| [   [MessageBox]{style="COLOR: #2b91af"}.Show(Area.PrimaryAxis.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

Axis.RangeChanged

Both Primary and Secondary Axis comes with **Rangechanged** event. This event occurs when the Range of the axis is changed. We could get the old and new range from this event.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                              |
| [///\<summary\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[Event triggered when Axis range is changed.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                                                                                              |
| [///\</summary\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                              |
| [///\<param name=\"sender\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[Sender Axis of event.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\</param\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                        |
|                                                                                                                                                                                                                                                              |
| [///\<param name=\"e\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ChartAxisRangeArgument that will return old and new range values.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\</param\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"} |
|                                                                                                                                                                                                                                                              |
| [        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                              |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PrimaryAxis_RangeChanged([object]{style="COLOR: blue"} sender, [ChartAxisRangeArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine (e.OldValue.Start.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine (e.OldValue.End.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine (e.NewValue.Start.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine (e.NewValue.End.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also

[[ChartSeries MouseEvents]{.UGHyperlink}](ms-xhelp:///?Id=a61c5b27-730a-4df4-890a-fe72ccbbadd8)[, ]{style="COLOR: #15428b"}[[Chart MouseEventArgs]{.UGHyperlink}](ms-xhelp:///?Id=a61c5b27-730a-4df4-890a-fe72ccbbadd8)

[]{#p159} 

[]{#related-topics}
:::
