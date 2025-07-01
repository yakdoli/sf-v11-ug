::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Builder {#builder style="tab-stops: 0pt"}

 

To create a HiLoOpenClose chart through Builder:

1.   In Controller, return view to the corresponding View page.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                                                        |
|                                                                                                                                               |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} SimpleChart()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                               |
| [        {            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                      |
|                                                                                                                                               |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                          |
|                                                                                                                                               |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                  |
|                                                                                                                                               |
| []{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

2.   In the View page, invoke the ChartBuilder by using the control ID as the first argument.

3.   Add the **Series** to the ChartModel and set the series type to **HiLoOpenClose**, and add the **Points** to the series and set the style.

4.   Set the **ChartModel** and **ChartArea** properties.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                         |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| [   [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Chart([\"chart_Model\"]{style="COLOR: #a31515"}).Text([\"HiLo Chart\"]{style="COLOR: #a31515"}).Series(series =\>]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| **[            series.Add()]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                                          |
| [                  .Name([\"FT\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                          |
| **[                  .Type(Syncfusion.Windows.Forms.Chart.[ChartSeriesType]{style="COLOR: #2b91af"}.HiLoOpenClose)]{style="FONT-FAMILY: 'Courier New'"}**                                                                |
|                                                                                                                                                                                                                          |
| [                  .Points(points =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                          |
| [                  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                          |
| [                      [DateTime]{style="COLOR: #2b91af"} start = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2006, 2, 12);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(0), 456, 214, 364, 386);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(1), 491, 234, 321, 378);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(2), 482, 193, 302, 352);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(3), 437, 243, 354, 391);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(4), 421, 223, 317, 367);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(5), 434, 263, 339, 385);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(6), 425, 245, 365, 396);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(7), 457, 234, 385, 398);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(8), 482, 267, 316, 389);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| **[                      points.Add(start.AddDays(9), 496, 285, 374, 399);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                        |
|                                                                                                                                                                                                                          |
| [                  });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                          |
| [        }).BorderAppearance(border =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| [            border.SkinStyle(Syncfusion.Windows.Forms.Chart.[ChartBorderSkinStyle]{style="COLOR: #2b91af"}.]{style="FONT-FAMILY: 'Courier New'"}[Pinned);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                          |
| [        }).SmoothingMode(System.Drawing.Drawing2D.[SmoothingMode]{style="COLOR: #2b91af"}.AntiAlias)]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                          |
| [              .Size([new]{style="COLOR: blue"} System.Drawing.[Size]{style="COLOR: #2b91af"}(500, 400))]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                          |
| [              .Skins([ChartModelSkins]{style="COLOR: #2b91af"}.Office2007Blue)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                          |
| [              .ChartSeriesSkins([ChartSeriesSkins]{style="COLOR: #2b91af"}.Analog)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                          |
| [              .Indexed([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                          |
| [              .PrimaryXAxis(xaxis =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                          |
| [              {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                          |
| [                  xaxis.Title([\"Week Day\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                          |
| [                       .ValueType(Syncfusion.Windows.Forms.Chart.[ChartValueType]{style="COLOR: #2b91af"}.DateTime)]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                          |
| [                       .DateTimeFormat([\"MMM/dd\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                          |
| [                       .DrawGrid([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                          |
| [                       .LabelRotate([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                          |
| [                       .LabelRotateAngle(270)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                          |
| [                       .HidePartialLabels([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                          |
| [              }).PrimaryYAxis(yaxis =\> {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                          |
| [                  yaxis.Title([\"Price (\$)\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                          |
| [                       .DrawGrid([false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                          |
| [              })   ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                          |
| [    [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                 |
|                                                                                                                                                                                                   |
| [   [\@{]{style="BACKGROUND: yellow"} Html.Chart([\"chart_Model\"]{style="COLOR: #a31515"}).Text([\"HiLo Chart\"]{style="COLOR: #a31515"}).Series(series =\>]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| **[            series.Add()]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                                   |
| [                  .Name([\"FT\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                   |
| **[                  .Type(Syncfusion.Windows.Forms.Chart.[ChartSeriesType]{style="COLOR: #2b91af"}.HiLoOpenClose)]{style="FONT-FAMILY: 'Courier New'"}**                                         |
|                                                                                                                                                                                                   |
| [                  .Points(points =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                   |
| [                  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                   |
| [                      [DateTime]{style="COLOR: #2b91af"} start = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2006, 2, 12);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(0), 456, 214, 364, 386);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(1), 491, 234, 321, 378);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(2), 482, 193, 302, 352);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(3), 437, 243, 354, 391);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(4), 421, 223, 317, 367);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(5), 434, 263, 339, 385);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(6), 425, 245, 365, 396);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(7), 457, 234, 385, 398);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(8), 482, 267, 316, 389);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| **[                      points.Add(start.AddDays(9), 496, 285, 374, 399);]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                                                   |
| [                  });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                   |
| [        }).BorderAppearance(border =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                   |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| [            border.SkinStyle(Syncfusion.Windows.Forms.Chart.[ChartBorderSkinStyle]{style="COLOR: #2b91af"}.]{style="FONT-FAMILY: 'Courier New'"}[Pinned);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                   |
| [        }).SmoothingMode(System.Drawing.Drawing2D.[SmoothingMode]{style="COLOR: #2b91af"}.AntiAlias)]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                   |
| [              .Size([new]{style="COLOR: blue"} System.Drawing.[Size]{style="COLOR: #2b91af"}(500, 400))]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                   |
| [              .Skins([ChartModelSkins]{style="COLOR: #2b91af"}.Office2007Blue)]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                   |
| [              .ChartSeriesSkins([ChartSeriesSkins]{style="COLOR: #2b91af"}.Analog)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                   |
| [              .Indexed([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                   |
| [              .PrimaryXAxis(xaxis =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                   |
| [              {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                   |
| [                  xaxis.Title([\"Week Day\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                   |
| [                       .ValueType(Syncfusion.Windows.Forms.Chart.[ChartValueType]{style="COLOR: #2b91af"}.DateTime)]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                   |
| [                       .DateTimeFormat([\"MMM/dd\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                   |
| [                       .DrawGrid([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                   |
| [                       .LabelRotate([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                   |
| [                       .LabelRotateAngle(270)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                   |
| [                       .HidePartialLabels([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                   |
| [              }).PrimaryYAxis(yaxis =\> {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                   |
| [                  yaxis.Title([\"Price (\$)\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                   |
| [                       .DrawGrid([false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                   |
| [              })    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                   |
| [           .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                   |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

5.   Build and run the application, to get the following output:

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

![](ImagesExt/image69_103.png){border="0"}[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

Figure 129: Chart displaying HiLoOpenClose chart Series

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{#related-topics}
:::
