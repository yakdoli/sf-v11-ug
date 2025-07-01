::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Custom theme {#custom-theme style="tab-stops: 0pt"}

The custom theme feature allows you to set the background color, fore color and text color of the captcha image.

 

Properties

 

+---------------------+---------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| Name                | Description                                             | Type of property                                                                                 | Value it accepts                                                                                                                                     | Dependency                                              |
+---------------------+---------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| BackgroundBackColor | Defines the background back color for the captcha image | [[struct]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink} | Properties of [[[System.Drawing.Color]{style="COLOR: blue"}]{.underline}](http://msdn.microsoft.com/en-us/library/system.drawing.color_members.aspx) | Requires                                                |
|                     |                                                         |                                                                                                  |                                                                                                                                                      |                                                         |
|                     |                                                         |                                                                                                  |                                                                                                                                                      | AutoFormat to be *[Skins]{style="COLOR: #2b91af"}.None* |
+---------------------+---------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| BackgroundForeColor | Defines the background fore color for the captcha image | [[struct]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink} | Properties of [[[System.Drawing.Color]{style="COLOR: blue"}]{.underline}](http://msdn.microsoft.com/en-us/library/system.drawing.color_members.aspx) | Requires                                                |
|                     |                                                         |                                                                                                  |                                                                                                                                                      |                                                         |
|                     |                                                         |                                                                                                  |                                                                                                                                                      | AutoFormat to be *[Skins]{style="COLOR: #2b91af"}.None* |
+---------------------+---------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| TextColor           | Defines the text color for the captcha image            | [[struct]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink} | Properties of [[[System.Drawing.Color]{style="COLOR: blue"}]{.underline}](http://msdn.microsoft.com/en-us/library/system.drawing.color_members.aspx) | Requires                                                |
|                     |                                                         |                                                                                                  |                                                                                                                                                      |                                                         |
|                     |                                                         |                                                                                                  |                                                                                                                                                      | AutoFormat to be *[Skins]{style="COLOR: #2b91af"}.None* |
+---------------------+---------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

Using Builder

The following steps explain the setting of custom theme for the captcha using builder.

1.   In **View**, invoke the captcha helper with the control id as argument followed by the **AutoFormat** method with the argument **Skins.None** and **BackgroundBackColor**, **BackgroundForeColor** and **TextColor** methods with the desired colors as argument.

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                  |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().CaptchaControl([\"myCaptcha\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                  |
| [.**AutoFormat([Skins]{style="COLOR: #2b91af"}.None)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                  |
| **[.BackgroundBackColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.White)]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                                                                                                  |
| **[.BackgroundForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.White)]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                                                                                                  |
| **[.TextColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.Brown)]{style="FONT-FAMILY: 'Courier New'"}**[%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                          |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                  |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().CaptchaControl([\"myCaptcha\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                  |
| [.**AutoFormat([Skins]{style="COLOR: #2b91af"}.None)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                  |
| **[.BackgroundBackColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.White)]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                                                                                                  |
| **[.BackgroundForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.White)]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                                                                                                  |
| **[.TextColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.Brown).Render();]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                                                                                                  |
| **[        ]{style="FONT-FAMILY: 'Courier New'"}**[}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                    |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Using Properties Model

The following steps explain the setting of the custom theme for the captcha using Properties model.

1.   In the Controller, create an instance of the CaptchaModel, set the **AutoFormat** property to **Skins.None**, define the **BackgroundBackColor**, **BackgroundForeColor** and **TextColor** properties and pass the instance through view specific data to View as given in the following code. **

 

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
| [            **myModel.AutoFormat = [Skins]{style="COLOR: #2b91af"}.None;**]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                         |
| **[            myModel.BackgroundBackColor = System.Drawing.[Color]{style="COLOR: #2b91af"}.White;]{style="FONT-FAMILY: 'Courier New'"}**                               |
|                                                                                                                                                                         |
| **[            myModel.BackgroundForeColor = System.Drawing.[Color]{style="COLOR: #2b91af"}.White;]{style="FONT-FAMILY: 'Courier New'"}**                               |
|                                                                                                                                                                         |
| **[            myModel.TextColor = System.Drawing.[Color]{style="COLOR: #2b91af"}.Brown;]{style="FONT-FAMILY: 'Courier New'"}**                                         |
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

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

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

The output is shown in the following screen shot.

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Captcha\\Apperance\\custom_style.png](ImagesExt/image56_110.png){border="0"}

Figure 98: Captcha -- Custom style

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[]{#related-topics}
:::
