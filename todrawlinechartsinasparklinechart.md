::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### To draw line charts in a Sparkline Chart {#to-draw-line-charts-in-a-sparkline-chart style="tab-stops: 0pt"}

The line type of spark line represents a set of data points, connected by a line.

Refer to the following code snippets to draw the line Sparkline chart:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [//Set Sparkline points to source property]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Source =[new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 30, -20, 80, 20, 40, -50, -30, 70, -40, 50 };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                               |
| [//Set line type sparkline]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Type = [SparkLineType]{style="COLOR: #2b91af"}.Line;]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [\'Set Sparkline points to source property]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Source = [New]{style="COLOR: blue"} [Double]{style="COLOR: blue"}() {30, -20, 80, 20, 40, -50,-30, 70, -40, 50}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| [\'Set line type sparkline]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                          |
|                                                                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Type = [SparkLineType]{style="COLOR: #2b91af"}.Line]{style="FONT-FAMILY: 'Courier New'"}                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: http://help.syncfusion.com/ug_92/User%20Interface/Windows%20Forms/Chart/ImagesExt/image9_91.png](ImagesExt/image64_90.png){border="0"}

Figure 87: Line SparkLine

[]{#related-topics}
:::
