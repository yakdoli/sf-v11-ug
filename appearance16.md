::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Appearance {#appearance style="tab-stops: 0pt"}

The Button control supports fourteen built-in themes that gives a high visual appeal.

Use Case Scenarios

It allows for easy customization of the appearance to be displayed on the button.

Adding Appearance to an Application

Appearance can be customized through two ways in button.

[·      ]{style="FONT-FAMILY: Symbol"}Using Builder

[·      ]{style="FONT-FAMILY: Symbol"}Using Properties Model

[]{style="COLOR: black"} 

Using Builder

The following steps guides you in customizing appearance using Builder.

[]{style="COLOR: black"} 

1.   In **View**, invoke the normal Button helper with the button ID as the first argument followed by the **Skin** methods.

 

[]{style="FONT-FAMILY: 'Courier New'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                   |
|                                                                                                                                                                          |
| [        [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Button([\"btnNormal\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                          |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                          |
| [        .Skin([Skins]{style="COLOR: #2b91af"}.Almond)]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                          |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                          |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                          |
| [        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                       |
|                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                     |
|                                                                                                                                                |
| [      [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().Button([\"btnNormal\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                |
| [        .Skin([Skins]{style="COLOR: #2b91af"}.Almond)]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                |
| [        .Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Run the application.

[]{style="COLOR: black"} 

The output is shown in the following screenshot.

[]{style="COLOR: black"} 

![](ImagesExt/image56_90.jpg){border="0"} ![](ImagesExt/image56_91.jpg){border="0"}   ![](ImagesExt/image56_92.jpg){border="0"}   ![](ImagesExt/image56_93.jpg){border="0"}

![](ImagesExt/image56_94.jpg){border="0"} ![](ImagesExt/image56_95.jpg){border="0"}   ![](ImagesExt/image56_96.jpg){border="0"}   ![](ImagesExt/image56_97.jpg){border="0"}

![](ImagesExt/image56_98.jpg){border="0"} ![](ImagesExt/image56_99.jpg){border="0"}   ![](ImagesExt/image56_83.jpg){border="0"}   ![](ImagesExt/image56_100.jpg){border="0"}

![](ImagesExt/image56_101.jpg){border="0"} ![](ImagesExt/image56_102.jpg){border="0"}

Figure 88: Normal Button Themes

Using Properties Model

[]{style="COLOR: black"} 

The following steps guides you in customizing the appearance using the Properties model.

1.   In Controller, create an object for the **ButtonModel** class and set the **Text**, **ImageUrl**, **ContentType**, **ImagePosition**, and **Skin** properties. Assign this model class to view data.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                 |
|                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                          |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                          |
| [            [ButtonModel]{style="COLOR: #2b91af"} buttonModel = [new]{style="COLOR: blue"} [ButtonModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                          |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                          |
| [                Text = [\"Save\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                          |
| [                **Skin=[Skins]{style="COLOR: #2b91af"}.Almond,**]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                          |
| [                ImageUrl = [\"Content/icon_save.png\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                          |
| [                ContentType = [ContentTypes]{style="COLOR: #2b91af"}.TextAndImage,]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                          |
| [                ImagePosition = [ImagePositions]{style="COLOR: #2b91af"}.Right]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                          |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                          |
| [            ViewData\[[\"ButtonModel\"]{style="COLOR: #a31515"}\] = buttonModel;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                          |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                          |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="COLOR: black"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

2.   In View, invoke the normal Button helper with the button id as the first argument followed by the view data of the **ButtonModel** class.

 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Button([\"btnNormal\"]{style="COLOR: #a31515"},([ButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"ButtonModel\"]{style="COLOR: #a31515"}\]) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Button([\"btnNormal\"]{style="COLOR: #a31515"},([ButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"ButtonModel\"]{style="COLOR: #a31515"}\]).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

3.   Run the application.

[]{style="COLOR: black"} 

The output is shown in the following screenshot.

[]{style="COLOR: black"} 

![](ImagesExt/image56_90.jpg){border="0"} ![](ImagesExt/image56_91.jpg){border="0"}   ![](ImagesExt/image56_92.jpg){border="0"}   ![](ImagesExt/image56_93.jpg){border="0"}

![](ImagesExt/image56_94.jpg){border="0"} ![](ImagesExt/image56_95.jpg){border="0"}   ![](ImagesExt/image56_96.jpg){border="0"}   ![](ImagesExt/image56_97.jpg){border="0"}

![](ImagesExt/image56_98.jpg){border="0"} ![](ImagesExt/image56_99.jpg){border="0"}   ![](ImagesExt/image56_83.jpg){border="0"}   ![](ImagesExt/image56_100.jpg){border="0"}

![](ImagesExt/image56_101.jpg){border="0"} ![](ImagesExt/image56_102.jpg){border="0"}

Figure 89: Normal Button Themes

 

 

 

Properties

 

::: {align="center"}
+-----------------------------------------------------------+------------------------------------------------------------------+--------------------------------------------------------------------------+----------------------------------------------------------------+-----------------------------------------------------------------------+-----------------------------------------------------------------+
| **[Name ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Description ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Type of the property]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Data Type ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Value it accepts ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Dependency ]{style="COLOR: black"}**[]{style="COLOR: black"} |
+-----------------------------------------------------------+------------------------------------------------------------------+--------------------------------------------------------------------------+----------------------------------------------------------------+-----------------------------------------------------------------------+-----------------------------------------------------------------+
| Skin                                                      | Specifies the field that provides the appearance of the button.  | Server side                                                              | Enum                                                           | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Almond                    | NA                                                              |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Blend                     |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Blueberry                 |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Marble                    |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Midnight                  |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Monochrome                |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Office2007Black           |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Office2007Blue            |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Office2007Silver          |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Olive                     |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Sandune                   |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Turquoise                 |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Vista                     |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                |                                                                       |                                                                 |
|                                                           |                                                                  |                                                                          |                                                                | [·      ]{style="FONT-FAMILY: Symbol"}Skins.VS2010                    |                                                                 |
+-----------------------------------------------------------+------------------------------------------------------------------+--------------------------------------------------------------------------+----------------------------------------------------------------+-----------------------------------------------------------------------+-----------------------------------------------------------------+
:::

[]{style="COLOR: black"} 

Sample Link

To view the samples, follow the steps below.

1.   Open the Tools sample browser from the dashboard. (Refer to the Samples and Location chapter)

2.   Navigate to Tools.Mvc -\> Button -\> Core Features Demo.

 

[]{#related-topics}
::::
