::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Syncfusion Themes {#syncfusion-themes style="tab-stops: 0pt"}

Captcha supports fourteen pre-defined skins.

 

Properties

+-------------+---------------------------------------------+----------------------+---------------------------------------------------+-------------+
| Name        | Description                                 | Type of the property | Value it accepts                                  | Dependency  |
+-------------+---------------------------------------------+----------------------+---------------------------------------------------+-------------+
| AutoFormat  | Defines one of the fourteen in-built themes | enum                 | [Skins]{style="COLOR: #2b91af"}.Office2007Blue,   | NA          |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Office2007Silver, |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Office2007Black,  |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Vista,            |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Almond,           |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Blueberry,        |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Blend,            |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Olive,            |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Turquoise,        |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Monochrome,       |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Sandune,          |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.VS2010,           |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Marble,           |             |
|             |                                             |                      |                                                   |             |
|             |                                             |                      | [Skins]{style="COLOR: #2b91af"}.Midnight          |             |
+-------------+---------------------------------------------+----------------------+---------------------------------------------------+-------------+

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

Using Builder

The following steps explain the setting of the Syncfusion theme for the Captcha using Builder.

1.   In **View**, invoke the captcha helper with the control id as argument, followed by the **AutoFormat** method with the desired theme as argument.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                  |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().CaptchaControl([\"myCaptcha\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                  |
| [.**AutoFormat([Skins]{style="COLOR: #2b91af"}.Midnight)**[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                    |
|                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().CaptchaControl([\"myCaptcha\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| [.**AutoFormat([Skins]{style="COLOR: #2b91af"}.Midnight).Render();**[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

2.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Using Properties Model

The following steps explain the setting of the Syncfusion theme for the Captcha using properties model.

1.   In the Controller, create an instance of the CaptchaModel, define the **AutoFormat** properties and pass the instance through **view specific data** to **View** as given below. **

 

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                         |
| [            [//create instance of CaptchaModel]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                         |
| [            [CaptchaModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [CaptchaModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [            myModel.AutoFormat = [Skins]{style="COLOR: #2b91af"}.Midnight;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                         |
| [           [//pass the instance through view data to view]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                         |
| [            ViewData\[[\"myCaptcha\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                         |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

2.   In **View**, invoke the captcha helper with the view data key as the control id.

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                   |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().CaptchaControl([\"myCaptcha\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().CaptchaControl([\"myCaptcha\"]{style="COLOR: #a31515"}).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

3.   Build and run the application.       

 

The output is as shown in the following screenshot.

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Captcha\\Apperance\\autoFormat.png](ImagesExt/image56_109.png){border="0"}

Figure 97: Captcha with Midnight theme

 

[]{#related-topics}
:::
