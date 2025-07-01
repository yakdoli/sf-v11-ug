::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps, explains about the buttons settings in Header control using Builder:

1.   In **View**, invoke the Header helper with the Control ID as the first argument followed by the TargetId, Tilt, AutoFormat, LeftButton, RightButton methods with their respective arguments.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                          |
|                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                  |
|                                                                                                                                                                                                             |
| [                [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.MobSyncfusion().Header([\"Header\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                             |
| [                .TargetId([\"targetHeader\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                             |
| [                .Title([\"Select an action\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                             |
| [                .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.MetroBlue)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                             |
| [                .LeftButton(left =\> left.ShowButton([true]{style="COLOR: blue"}).Caption([\"Back\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                             |
| [                .RightButton(right =\> right.ShowButton([true]{style="COLOR: blue"}).Caption([\"Forward\"]{style="COLOR: #a31515"}))[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                   |
| [        [@(]{style="BACKGROUND: yellow"}Html.MobSyncfusion().Header([\"Header\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                   |
| [        .TargetId([\"targetHeader\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                   |
| [        .Title([\"Select an action\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                   |
| [        .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.MetroBlue)]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                   |
| [        .LeftButton(left =\> left.ShowButton([true]{style="COLOR: blue"}).Caption([\"Back\"]{style="COLOR: #a31515"})) ]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                   |
| [        .RightButton(right =\> right.ShowButton([true]{style="COLOR: blue"}).Caption([\"Forward\"]{style="COLOR: #a31515"}))[)]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

2.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**  

[]{#related-topics}
:::
