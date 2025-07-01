::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model        {#using-properties-model style="tab-stops: 0pt"}

The following steps guide in handling client side events through the Properties model.

[1.   ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} [In ]{style="BACKGROUND: white; COLOR: black"}Controller[, create an object for the]{style="BACKGROUND: white; COLOR: black"}[ **Mob**]{style="BACKGROUND: white; COLOR: black"}**[ProgressBarPropertiesModel]{style="BACKGROUND: white; COLOR: black"}**[ ]{style="BACKGROUND: white; COLOR: black"}[class and set the]{style="BACKGROUND: white; COLOR: black"}[ ]{style="BACKGROUND: white; COLOR: black"}**[ClientSide Events]{style="BACKGROUND: white; COLOR: black"}**[. Assign this model class to view data.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

::: {align="center"}
+-------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                   public                                                                        |
|                                                                                                 |
|                   ActionResult                                                                  |
|                    Index()                                                                      |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                           {                                                                     |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                                                                                                 |
|                   MobProgressBarPropertiesModel                                                 |
|                    model =                                                                      |
|                   new                                                                           |
|                                                                                                 |
|                   MobProgressBarPropertiesModel                                                 |
|                   ();                                                                           |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                               model.Value = 50;                                                 |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                               model.ClientSideOnChange =                                        |
|                                                                                                 |
|                     "onChange"                                                                  |
|                     ;                                                                           |
|                                                                                                 |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                                                                                                 |
|                                 model.ClientSideOnCreate =                                      |
|                     "onCreate"                                                                  |
|                     ;                                                                           |
|                                                                                                 |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                                                                                                 |
|                                 model.ClientSideOnComplete =                                    |
|                     "onComplete"                                                                |
|                     ;                                                                           |
|                                                                                                 |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                                                                                                 |
|                                 model.ClientSideOnCustomTextRendering =                         |
|                     "onCustomText"                                                              |
|                     ;                                                                           |
|                                                                                                 |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                               ViewData[                                                         |
|                   "ProgressBar"                                                                 |
|                   ] = model;                                                                    |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                                                                                                 |
|                   return                                                                        |
|                    View();                                                                      |
|                                                                                                 |
| ```                                                                                             |
|                                                                                                 |
| ``` {style="LINE-HEIGHT: 200%; BACKGROUND: #f2f2f2"}                                            |
|                           }                                                                     |
| ```                                                                                             |
+-------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: black"} 

2.   In View, invoke the ProgressBar helper with the control id and view data key as arguments.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ Html.MobSyncfusion().ProgressBar([\"pBar\"]{style="COLOR: #a31515"}, [\"progressBar\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                              |
| ```                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                              |
| ```                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"} []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                             |
|                                                                                                                                                                                                                                                              |
| [               ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} [Html.MobSyncfusion().ProgressBar([\"pBar\"]{style="COLOR: #a31515"}, [\"progressBar\"]{style="COLOR: #a31515"})[.Render(); ]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"} []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                               |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

[]{style="COLOR: black"} 

3.   [In]{style="BACKGROUND: white"}[ ]{style="BACKGROUND: white"}**[Javascript]{style="BACKGROUND: white"}**[, define the function to handle the specified events:]{style="BACKGROUND: white"}

[]{style="FONT-FAMILY: 'Arial','sans-serif'; COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                |
| [\<[script]{style="COLOR: maroon"}[type]{style="COLOR: red"}=\"text/javascript\"\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                 function                                                                                                                                                                                       |
|                  onComplete(sender, args)                                                                                                                                                                      |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                  {                                                                                                                                                                                             |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| [//args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                |
| [       [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| [      [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 }                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 function                                                                                                                                                                                       |
|                  onCreate(sender, args)                                                                                                                                                                        |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                  {                                                                                                                                                                                             |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| [  //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                |
| [       [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| [      [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 }                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 function                                                                                                                                                                                       |
|                  onChange(sender, args)                                                                                                                                                                        |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 {                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| [//args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                |
| [       [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| [      [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 }                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 function                                                                                                                                                                                       |
|                  onCustomText(sender, args)                                                                                                                                                                    |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                  {                                                                                                                                                                                             |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| [ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} [  //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                |
| [    [//  \_Value                - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| [   [// \_ProgressBar        -Details of the ProgressBar   ]{style="COLOR: darkgreen"}[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} [//  \_Context              -Context of the ProgressBar]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"} []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                                                                                                                                                                                                                |
|                 //  _Width =  width of the                                                                                                                                                                     |
|                 ProgressBar                                                                                                                                                                                    |
|                 ;                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                     //  _OffsetX = OffsetX of the                                                                                                                                                              |
|                 ProgressBar text                                                                                                                                                                               |
|                 ;                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                     //  _OffsetY = OffsetY of the                                                                                                                                                              |
|                 ProgressBar text                                                                                                                                                                               |
|                 ;                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                     //  _Height = height of the                                                                                                                                                                |
|                 ProgressBar                                                                                                                                                                                    |
|                 ;                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="LINE-HEIGHT: 200%; MARGIN-LEFT: 18pt"}                                                                                                                                                             |
|                     // _Radius = radius of the                                                                                                                                                                 |
|                 ProgressBar                                                                                                                                                                                    |
|                 ;                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| ``` {style="MARGIN-LEFT: 18pt"}                                                                                                                                                                                |
|                 }                                                                                                                                                                                              |
|                                                                                                                                                                                                                |
| ```                                                                                                                                                                                                            |
|                                                                                                                                                                                                                |
| [\</[script\>]{style="COLOR: maroon"}[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[[ []{style="TEXT-DECORATION: none"} ]{style="FONT-SIZE: 16pt"}]{.underline}**  

4.   Build and run the application.

You can observe the handlers getting invoked when the corresponding event is triggered.

 

[]{#related-topics}
::::
