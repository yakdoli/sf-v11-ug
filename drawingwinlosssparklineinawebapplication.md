::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Drawing Win-Loss Sparkline in a web application {#drawing-win-loss-sparkline-in-a-web-application style="tab-stops: 0pt"}

The Win-loss type of Sparkline is similar to column type but all columns have equal length for data points. The vertical column direction represents the negative or positive value.

Refer to the following code snippets to draw the Win-Loss sparkline:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [//Set Sparkline points to source property]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Source =[new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 30, -20, 80, 20, 40, -50, -30, 70, -40, 50 };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                               |
| [//Set line type sparkline]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Type = [SparkLineType]{style="COLOR: #2b91af"}.WinLoss;]{style="FONT-FAMILY: 'Courier New'"}                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

 

 

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [\'Set Sparkline points to source property]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Source = [New]{style="COLOR: blue"} [Double]{style="COLOR: blue"}() {30, -20, 80, 20, 40, -50,-30, 70, -40, 50}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| [\'Set line type sparkline]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                          |
|                                                                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.Type = [SparkLineType]{style="COLOR: #2b91af"}. WinLoss]{style="FONT-FAMILY: 'Courier New'"}                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

![](ImagesExt/image64_92.png){border="0"}

Figure 89: WinLoss SparkLine

[]{#related-topics}
:::
