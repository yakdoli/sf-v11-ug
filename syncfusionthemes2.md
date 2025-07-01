::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Syncfusion Themes {#syncfusion-themes style="tab-stops: 0pt"}

The slider control supports fourteen built-in Syncfusion themes to enhance its look and feel.**

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Properties

 

Table 5: Property Table

+-------------+---------------------------------------+------------------+--------------------------------------------------------------+-------------+
| Name        | Description                           | Type of property | Value it accepts                                             | Dependency  |
+-------------+---------------------------------------+------------------+--------------------------------------------------------------+-------------+
| AutoFormat  | Used to define the Syncfusion themes. | enum             | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Office2007Blue   | NA          |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Office2007Silver |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Office2007Black  |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Vista            |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Almond           |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Blueberry        |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Blend            |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Olive            |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Turquoise        |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Monochrome       |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Sandune          |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.VS2010           |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Marble           |             |
|             |                                       |                  |                                                              |             |
|             |                                       |                  | [·      ]{style="FONT-FAMILY: Symbol"}Skins.Midnight         |             |
+-------------+---------------------------------------+------------------+--------------------------------------------------------------+-------------+

 

Using Builder

 

The following steps explain how to set Syncfusion themes through the builder.**

1.   In **View**, invoke the slider helper with the control ID as an argument followed by the **AutoFormat** method with the desired theme as an argument.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                        |
|                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| **[.AutoFormat([Skins]{style="COLOR: #2b91af"}.Midnight)]{style="FONT-FAMILY: 'Courier New'"}**[%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                            |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                                         |
|                                                                                                                                                                                                            |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                            |
| **[.AutoFormat([Skins]{style="COLOR: #2b91af"}.Midnight)]{style="FONT-FAMILY: 'Courier New'"}**[.Render();]{style="FONT-FAMILY: 'Courier New'"}[}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

2.   Build and run the application.

*[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}* 

Using Properties Model

The following steps explain how to set Syncfusion themes through the properties model.**

1.   In the controller, create an instance of **SliderModel**.

2.   Define the **AutoFormat** property and pass the instance through the view-specific data to the view.[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                                       |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                       |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                       |
| [            [//Create an instance of TabModel.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                       |
| [            [SliderModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [SliderModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                       |
| [            **myModel.AutoFormat = [Skins]{style="COLOR: #2b91af"}.Midnight;**]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [            [//Pass the instance through the view data to the view.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                       |
| [            ViewData\[[\"mySlider\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                       |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                       |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

3.   In **View**, invoke the slider helper with the view data key as the control ID.**

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                          |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                                            |
|                                                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"}).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*** 

4.   Build and run the application.

 

The following figure shows the output of the slider with the set theme.

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Slider\\concepts\\syncfusiontheme.png](ImagesExt/image56_245.png){border="0"}

Figure 239: Slider with Syncfusion Theme

 

[]{#related-topics}
:::
