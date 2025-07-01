::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Adding Rating in HTML5 to an MVC application[]{style="FONT-FAMILY: 'Cambria','serif'; FONT-SIZE: 11pt"} {#adding-rating-in-html5-to-an-mvc-application style="tab-stops: 0pt"}

Rating control in HTML5 can be implemented in two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Using Builder

[·      ]{style="FONT-FAMILY: Symbol"}Using Properties model

 

**Using Builder**

The following code snippets illustrate the implementation of the rating control using HTML5:

1.   [In View, invoke the rating helper ]{style="BACKGROUND: white; COLOR: black"}followed[ by the EnableHTML5, Shape and EditMode methods with the desired values as arguments.]{style="BACKGROUND: white; COLOR: black"}

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                            |
|                                                                                                                                                                                                               |
| [    [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Rating([\"html5rating\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [                .ClientSideMouseOver([\"OnMouseOver\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                               |
| [                 .ClientSideMouseOut([\"OnMouseOut\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                               |
| [                 .ClientSideClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                               |
| [                 .ClientSideValueChange([\"OnValueChange\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                               |
| [                 .ClientSideOnLoad([\"OnLoad\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                               |
| [                 .ClientSideOnCustomShapeDrawing([\"onCustomShapeDrawing\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                               |
| [                 .EnableHTML5([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                               |
| [                 .AutoPostBack([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                               |
| [                 .RequestMapper([\"Html5Rating\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                               |
| [                 .CurrentValue(3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                               |
| [                 .EditMode([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                               |
| [                 .MaximumValue(5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                               |
| [                 .IncrementStep(1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                               |
| [                 .Orientation([RatingOrientation]{style="COLOR: #2b91af"}.Horizontal)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                               |
| [                 .Precision([RatingPrecision]{style="COLOR: #2b91af"}.Full)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                               |
| [                 .Shape([RatingShape]{style="COLOR: #2b91af"}.Star)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                               |
| [                 .ShapeWidth(30)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                               |
| [                 .ShapeHeight(30)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                               |
| [    [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"}                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="COLOR: black"}                                                                                                                                   |
|                                                                                                                                                                     |
| []{style="COLOR: black"}                                                                                                                                            |
|                                                                                                                                                                     |
| [\@{]{style="BACKGROUND: yellow; COLOR: black"}[Html.Syncfusion().Rating(]{style="COLOR: black"}[\"html5rating\"]{style="COLOR: #a31515"}[) ]{style="COLOR: black"} |
|                                                                                                                                                                     |
| [                .ClientSideMouseOver(]{style="COLOR: black"}[\"OnMouseOver\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                                     |
|                                                                                                                                                                     |
| [                 .ClientSideMouseOut(]{style="COLOR: black"}[\"OnMouseOut\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                                      |
|                                                                                                                                                                     |
| [                 .ClientSideClick(]{style="COLOR: black"}[\"OnClick\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                                            |
|                                                                                                                                                                     |
| [                 .ClientSideValueChange(]{style="COLOR: black"}[\"OnValueChange\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                                |
|                                                                                                                                                                     |
| [                 .ClientSideOnLoad(]{style="COLOR: black"}[\"OnLoad\"]{style="COLOR: #a31515"}[) ]{style="COLOR: black"}                                           |
|                                                                                                                                                                     |
| [                 .ClientSideOnCustomShapeDrawing(]{style="COLOR: black"}[\"onCustomShapeDrawing\"]{style="COLOR: #a31515"}[) ]{style="COLOR: black"}               |
|                                                                                                                                                                     |
| [                 .EnableHTML5(]{style="COLOR: black"}[true]{style="COLOR: blue"}[)]{style="COLOR: black"}                                                          |
|                                                                                                                                                                     |
| [                 .AutoPostBack(]{style="COLOR: black"}[false]{style="COLOR: blue"}[)]{style="COLOR: black"}                                                        |
|                                                                                                                                                                     |
| [                 .RequestMapper(]{style="COLOR: black"}[\"Html5Rating\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                                          |
|                                                                                                                                                                     |
| [                 .CurrentValue(3)]{style="COLOR: black"}                                                                                                           |
|                                                                                                                                                                     |
| [                 .EditMode(]{style="COLOR: black"}[true]{style="COLOR: blue"}[)]{style="COLOR: black"}                                                             |
|                                                                                                                                                                     |
| [                 .MaximumValue(5)]{style="COLOR: black"}                                                                                                           |
|                                                                                                                                                                     |
| [                 .IncrementStep(1)]{style="COLOR: black"}                                                                                                          |
|                                                                                                                                                                     |
| [                 .Orientation(]{style="COLOR: black"}[RatingOrientation]{style="COLOR: #2b91af"}[.Horizontal)]{style="COLOR: black"}                               |
|                                                                                                                                                                     |
| [                 .Precision(]{style="COLOR: black"}[RatingPrecision]{style="COLOR: #2b91af"}[.Full)]{style="COLOR: black"}                                         |
|                                                                                                                                                                     |
| [                 .Shape(]{style="COLOR: black"}[RatingShape]{style="COLOR: #2b91af"}[.Star)]{style="COLOR: black"}                                                 |
|                                                                                                                                                                     |
| [                 .ShapeWidth(30)]{style="COLOR: black"}                                                                                                            |
|                                                                                                                                                                     |
| [                 .ShapeHeight(30)]{style="COLOR: black"}                                                                                                           |
|                                                                                                                                                                     |
| [                 .Render();]{style="COLOR: black"}                                                                                                                 |
|                                                                                                                                                                     |
| [                 [}]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                                                            |
|                                                                                                                                                                     |
| []{style="FONT-SIZE: 11pt"}                                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

 

2.   [Build and run the ]{style="BACKGROUND: white; COLOR: black"}application[.]{style="BACKGROUND: white; COLOR: black"}

 

![](ImagesExt/image56_199.png){border="0"}

Figure 188: HTML5 Rating using Builder

 

 

**Using Properties Model**

The following code snippet illustrates the implementation of the HTML5 rating control using properties model.

1.   In the controller, create an instance of RatingModel.

2.   Define the **EnableHTML5, Shape** and **CurrentValue** properties and pass the instance through the view-specific data to the view.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                                |
| [            [RatingModel]{style="COLOR: #2b91af"} ratingModel = [new]{style="COLOR: blue"} [RatingModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                |
| [                EnableHTML5 = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                |
| [                AutoPostBack = [false]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                |
| [                RequestMapper = [\"Html5Rating\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                |
| [                CurrentValue = 3,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                |
| [                EditMode = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                |
| [                MaximumValue = 5,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                |
| [                IncrementStep = 1,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                |
| [                Orientation = [RatingOrientation]{style="COLOR: #2b91af"}.Horizontal,]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                |
| [                Precision = [RatingPrecision]{style="COLOR: #2b91af"}.Full,]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                |
| [                Shape = [RatingShape]{style="COLOR: #2b91af"}.Star,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                |
| [                ShapeWidth = 30,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                |
| [                ShapeHeight = 30,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                |
| [                ClientSideMouseOver = [\"OnMouseOver\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                |
| [                ClientSideMouseOut = [\"OnMouseOut\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                |
| [                ClientSideClick = [\"OnClick\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                |
| [                ClientSideValueChange = [\"OnValueChange\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                |
| [                ClientSideOnLoad = [\"OnLoad\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                |
| [                ClientSideOnCustomShapeDrawing = [\"onCustomShapeDrawing\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                |
| [            ViewData\[[\"Html5Rating\"]{style="COLOR: #a31515"}\] = ratingModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                |
| []{style="FONT-SIZE: 11pt"}                                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

3.   [In **View**, invoke the rating helper with the view data key as the control ID.]{style="BACKGROUND: white; COLOR: black"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                             |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Rating([\"Html5Rating\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"}                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                              |
|                                                                                                                                                                         |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[Html.Syncfusion().Rating([\"Html5Rating\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [                 .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                         |
| [                 [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

4.   [Build and run the application.]{style="BACKGROUND: white; COLOR: black"}

 

![](ImagesExt/image56_199.png){border="0"}

Figure 189: HTML5 Rating using properties model

 

 

[]{#related-topics}
:::
