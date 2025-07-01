::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to show milliseconds in the TimeSpanEdit control? {#how-to-show-milliseconds-in-the-timespanedit-control style="tab-stops: 0pt"}

The character z in the format string is used to display milliseconds in the TimeSpanEdit control.

 ![](ImagesExt/image30_991.png){border="0"}

Figure 1103: TimeSpanEdit with milliseconds

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[TimeSpanEdit]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Value]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"10.2:25:52\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Format]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\" d \'days\' h \'hours\' m \'minutes\' :s \'sec\' z \'msec\' \"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                           |
| [timeSpanEdit1.Format = [@\"]{style="COLOR: #a31515"}[ d \'days\' h \'hours\' m \'minutes\' :s \'sec\' z \'msec\']{style="COLOR: blue"}[\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #e36c0a"}** 

**[]{style="COLOR: #e36c0a"}** 

 

 

[]{#related-topics}
:::
