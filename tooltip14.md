::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ToolTip {#tooltip style="tab-stops: 0pt"}

You can set tooltip for specific days in the CalendarEdit control, using the **SetToolTip** method. The following code snippet illustrates tooltip setting for the current system date.

 

+-----------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                      |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                     |
| [//Creating an instance date]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                     |
|                                                                                                     |
| [Date a = [new]{style="COLOR: blue"} Date();]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                     |
| [//Creating an instance of tooltip]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}               |
|                                                                                                     |
| [ToolTip toolTip = [new]{style="COLOR: blue"} ToolTip();]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                |
|                                                                                                     |
| [//Setting tooltip text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                          |
|                                                                                                     |
| [toolTip.Content = [\"CurrentDate\"]{style="COLOR: #a31515"}; ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                |
|                                                                                                     |
| [//Getting the current day]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                       |
|                                                                                                     |
| [a.Day = [DateTime]{style="COLOR: #2b91af"}.Now.Day;   ]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                |
|                                                                                                     |
| [//Getting the current month]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                     |
|                                                                                                     |
| [a.Month = [DateTime]{style="COLOR: #2b91af"}.Now.Month;  ]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                |
|                                                                                                     |
| [//Getting the current year]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                      |
|                                                                                                     |
| [a.Year = [DateTime]{style="COLOR: #2b91af"}.Now.Year;]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                |
|                                                                                                     |
| [//Setting tooltip for current date]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}              |
|                                                                                                     |
| [calendarEdit.SetToolTip(a, toolTip); ]{style="FONT-FAMILY: 'Courier New'"}                         |
+-----------------------------------------------------------------------------------------------------+

 

[]{#p47} 

[]{#related-topics}
:::
