::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following section explains how to set the **DateFormat** and **ShowOtherMonths** properties of the DatePicker control using Builder.

1.  [In the **view**, invoke the date picker helper followed by the **DateFormat()** and **ShowOtherMonths()** methods with the desired arguments.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                         |
|                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [{=Html.MobSyncfusion().DatePicker([\"DatePicker\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [        \-\-\-\-\-\-\-\-\-\-\--]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                 |
| [        .DateFormat([\"d MM,y\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                 |
| [        .ShowOtherMonths([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                 |
| [        \-\-\-\-\-\-\-\-\-\-\--]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                 |
| [}[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [ Html.MobSyncfusion().DatePicker([\"DatePicker\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [        \-\-\-\-\-\-\-\-\-\-\--]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                |
| [        .DateFormat([\"d MM,y\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                |
| [        .ShowOtherMonths([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                |
| [        \-\-\-\-\-\-\-\-\-\-\--]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                |
| [        .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

2.  [Build and run the application.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[]{#related-topics}
:::
