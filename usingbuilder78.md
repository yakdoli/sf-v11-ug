::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps explain the setting of the Syncfusion themes to Dialog using Builder:

1.   In **View**, create the contents of the dialog and invoke the dialog helper with the Control ID as first argument followed by the **AutoFormat** method with the desired theme as the argument.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                    |
|                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                            |
|                                                                                                                                       |
| [            [\<%]{style="BACKGROUND: yellow"}{]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                       |
| [                  Html.MobSyncfusion().Dialog([\"MobDialog\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                       |
| [                    .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.DarkNight)]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                       |
| [                    .Title([\"Syncfusion Essential Studio\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                       |
| [                    .DialogIconUrl([\"\~/Content/Images/favicon.ico\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                       |
| [                    .Template(() =\>]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                       |
| [                      {[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                       |
| [            [\<]{style="COLOR: blue"}[div]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                       |
| [                This is the Syncfusion Mobile Dialog control]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                       |
| [            [\</]{style="COLOR: blue"}[div]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                       |
| [            [\<%]{style="BACKGROUND: yellow"}})]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                       |
| [            .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                       |
| [              }[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                        |
|                                                                                                                                                                                   |
| [            [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                   |
| [                Html.MobSyncfusion().Dialog([\"MobDialog\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                   |
| [                    .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.DarkNight)]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                   |
| [                    .Title([\"Syncfusion Essential Studio\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                   |
| [                    .DialogIconUrl([\"\~/Content/Images/favicon.ico\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                   |
| [                    .Template([@]{style="BACKGROUND: yellow"}[\<]{style="COLOR: blue"}[div]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [                        This is the Syncfusion Mobile Dialog control]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                   |
| [                    [\</]{style="COLOR: blue"}[div]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                   |
| [            ).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Build and run the application in emulator.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**  

[]{#related-topics}
:::
