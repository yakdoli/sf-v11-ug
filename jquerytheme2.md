::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### jQuery Theme {#jquery-theme style="tab-stops: 0pt"}

 

Aside from the Syncfusion themes, the slider control also supports all the default jQuery themes.**

**[Properties]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

+------------------+-----------------------------------+----------------------+---------------------------------------------------------------+----------------+
| **Name**         | **Description**                   | **Type of property** | **Value it accepts**                                          | **Dependency** |
+==================+===================================+======================+===============================================================+================+
| jQueryAutoFormat | Used to define the jQuery themes. | enum                 | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Smoothness  | NA             |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.UILightness |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.UIDarkness  |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.UIStart     |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Redmond     |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Cupertino   |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.SouthStreet |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Blitzer     |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Humanity    |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.HotSneaks   |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.ExciteBike  |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Vader       |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.DotLuv      |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.MintChoc    |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.BlackTie    |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.Trontastic  |                |
|                  |                                   |                      |                                                               |                |
|                  |                                   |                      | [·      ]{style="FONT-FAMILY: Symbol"}jQuerySkins.SwankyPurse |                |
+------------------+-----------------------------------+----------------------+---------------------------------------------------------------+----------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

**[Using Builder]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

The following steps explain how to set jQuery themes through the builder.**

1.   In **View**, invoke the slider helper with the control ID as an argument, followed by the **jQueryAutoFormat** method with the desired theme as an argument.

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                |
| **[.jQueryAutoFormat([jQuerySkins]{style="COLOR: #2b91af"}.MintChoc)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[%\>]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                             |
|                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                               |
| **View\[cshtml\]**                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[ Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                |
|                                                                                                                                                                                                                                                               |
| **[.jQueryAutoFormat([jQuerySkins]{style="COLOR: #2b91af"}.MintChoc)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[.Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[}]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

2.   Build and run the application.

*[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}* 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Using Properties Model

 

The following steps explain how to set jQuery themes through the properties model.**

1.   In the controller, create an instance of **SliderModel**.

2.   Define the **jQueryAutoFormat** property and pass the instance through the **view-specific data** to the **View**.[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[Controller\]**                                                                                                                                                                 |
|                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}           |
|                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                       |
|                                                                                                                                                                                    |
| [            [//Create an instance of TabModel.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                           |
|                                                                                                                                                                                    |
| [            [SliderModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [SliderModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                    |
| [            **myModel.jQueryAutoFormat = [jQuerySkins]{style="COLOR: #2b91af"}.MintChoc;**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                      |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                |
|                                                                                                                                                                                    |
| [            [//Pass the instance through the view data to the view.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                      |
|                                                                                                                                                                                    |
| [            ViewData\[[\"mySlider\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                    |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                       |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

3.   In **View**, invoke the slider helper with view data key as the control ID.**

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                         |
| **View\[cshtml\]**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                         |
| [\@{]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[ Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"}).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*** 

4.   Build and run the application.

 

The following figure shows the output of the slider with the jQuery theme.

 

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Slider\\concepts\\jQuerytheme.png](ImagesExt/image56_246.png){border="0"}

Figure 240: Slider with jQuery Theme

 

[]{#related-topics}
:::
