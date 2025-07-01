::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Orientation {#orientation style="tab-stops: 0pt"}

The slider control supports both horizontal and vertical orientations.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Properties

 

Table 3: Proterty Table

+-------------+-------------------------------------+------------------+-------------------------------------------+-------------+
| Name        | Description                         | Type of property | Value it accepts                          | Dependency  |
+-------------+-------------------------------------+------------------+-------------------------------------------+-------------+
| Orientation | Sets the orientation of the slider. | enum             | jQueryModel.SliderOrientation.Horizontal, | NA          |
|             |                                     |                  |                                           |             |
|             |                                     |                  | jQueryModel.SliderOrientation.Vertical    |             |
+-------------+-------------------------------------+------------------+-------------------------------------------+-------------+

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

Using Builder

The following steps explain how to set slider orientation using Builder.**

1.   In **View**, invoke the slider helper with the control ID as an argument, followed by the **Orientation** method with the desired orientation as an argument.

 

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                        |
|                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| [.Orientation([jQueryModel]{style="COLOR: #2b91af"}.[SliderOrientation]{style="COLOR: #2b91af"}.Vertical)[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                      |
|                                                                                                                                                                                         |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                         |
| [.Orientation([jQueryModel]{style="COLOR: #2b91af"}.[SliderOrientation]{style="COLOR: #2b91af"}.Vertical).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

2.   Build and run the application.

 

**[Using Properties Model]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

The following steps explain how to set slider orientation through the properties model.**

1.   In the controller, create an instance of **SliderModel**.

2.   Define the **Orientation** property and pass the instance through the view-specific data to the view.[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                                       |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                       |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                       |
| [            [//Create an instance of TabModel]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                       |
| [            [SliderModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [SliderModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                       |
| [            myModel.Orientation = [jQueryModel]{style="COLOR: #2b91af"}.[SliderOrientation]{style="COLOR: #2b91af"}.Vertical;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [            [//Pass the instance through view data to the view]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                           |
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

3.   In **View**, invoke the slider helper with the view data key as the control ID.**

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                          |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                          |
| **[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Courier New'"}]{.underline}**                                                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*** 

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                                            |
|                                                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().Slider([\"mySlider\"]{style="COLOR: #a31515"}).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| **[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Courier New'"}]{.underline}**                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*** 

4.   Build and run the application.

The following figure shows the orientation output of the slider.

 

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Slider\\concepts\\orientation.png](ImagesExt/image56_243.png){border="0"}

Figure 237: Slider with Vertical Orientation

 

[]{#related-topics}
:::
