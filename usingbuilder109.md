::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps guide in handling client side events through Builder:

[1.   ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}In **View**, [invoke the ProgressBar helper with the **ProgressBarid** as the first argument ]{style="BACKGROUND: white; COLOR: black"}followed[ by the]{style="BACKGROUND: white; COLOR: black"}[ ]{style="BACKGROUND: white; COLOR: black"}**[Client side events]{style="BACKGROUND: white; COLOR: black"}**[.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} [Html.MobSyncfusion().ProgressBar([\"progressBar\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                           |
| [       .Value(30)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                      |
|                                                                                                                                                                                                           |
| [      **.ClientSideOnChange([\"OnChange\"]{style="COLOR: #a31515"})**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                  |
|                                                                                                                                                                                                           |
| **[      .ClientSideOnComplete([\"OnComplete\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                              |
|                                                                                                                                                                                                           |
| **[      .ClientSideOnCreate([\"OnCreate\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                  |
|                                                                                                                                                                                                           |
| **[      .ClientSideOnCustomTextRendering([\"onCustomText\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                 |
|                                                                                                                                                                                                           |
| [      .Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                       |
|                                                                                                                                                                                                           |
| [    [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ ]{style="FONT-SIZE: 12pt"} **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                                                               |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                             |
|                                                                                                                                                               |
|                                                                                                                                                               |
| ```                                                                                                                                                           |
|                                                                                                                                                               |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                             |
|                 @{                                                                                                                                            |
|                                                                                                                                                               |
|                                                                                                                                                               |
| ```                                                                                                                                                           |
|                                                                                                                                                               |
| [      ]{style="COLOR: black"} [Html.MobSyncfusion().ProgressBar([\"progressBar\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                               |
| [       .Value(30)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                          |
|                                                                                                                                                               |
| [      **.ClientSideOnChange([\"OnChange\"]{style="COLOR: #a31515"})**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                      |
|                                                                                                                                                               |
| **[      .ClientSideOnComplete([\"OnComplete\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                  |
|                                                                                                                                                               |
| **[      .ClientSideOnCreate([\"OnCreate\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                      |
|                                                                                                                                                               |
| **[      .ClientSideOnCustomTextRendering([\"onCustomText\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                     |
|                                                                                                                                                               |
| [      .Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                           |
|                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"} []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                |
|                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

2.   In JavaScript, define the handlers.

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                           |
| [\<[script]{style="COLOR: maroon"}[type]{style="COLOR: red"}=\"text/javascript\"\>]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                 function                                                                                                                                                                  |
|                  onComplete(sender, args)                                                                                                                                                 |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                  {                                                                                                                                                                        |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                             //args:                                                                                                                                                       |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|             //  _Value             - Value of the ProgressBar                                                                                                                             |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|             // _ProgressBar        -Details of the ProgressBar                                                                                                                            |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 }                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 function                                                                                                                                                                  |
|                  onCreate(sender, args)                                                                                                                                                   |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                  {                                                                                                                                                                        |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                           |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                           |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 }                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 function                                                                                                                                                                  |
|                  onChange(sender, args)                                                                                                                                                   |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 {                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                           |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                           |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 }                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 function                                                                                                                                                                  |
|                  onCustomText(sender, args)                                                                                                                                               |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                  {                                                                                                                                                                        |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| [ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} [  //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                           |
| [              [//  \_Value                - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                           |
| [             [// \_ProgressBar        -Details of the ProgressBar   ]{style="COLOR: darkgreen"}[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                           |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} [        [//  \_Context              -Context of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                            //  _Width =  width of the ProgressBar;                                                                                                                        |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                            //  _OffsetX = OffsetX of the                                                                                                                                  |
|                 ProgressBar text                                                                                                                                                          |
|                 ;                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                            //  _OffsetY = OffsetY of the                                                                                                                                  |
|                 ProgressBar text                                                                                                                                                          |
|                 ;                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                              //  _Height = height of the                                                                                                                                  |
|                 ProgressBar                                                                                                                                                               |
|                 ;                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                                                                                                                      |
|                             // _Radius = radius of the                                                                                                                                    |
|                 ProgressBar                                                                                                                                                               |
|                 ;                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
|                 }                                                                                                                                                                         |
|                                                                                                                                                                                           |
| ```                                                                                                                                                                                       |
|                                                                                                                                                                                           |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                         |
| </script>                                                                                                                                                                                 |
| ```                                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
