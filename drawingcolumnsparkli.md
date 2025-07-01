::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Drawing Column Sparkline in  an Application {#drawing-column-sparkline-in-an-application style="tab-stops: 0pt"}

 

The column type of spark line represents each data point by a column. The vertical column direction represents the negative or positive value.

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Refer to the following code snippets to draw the column sparkline:

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                      |
| [//Set Sparkline points to source property]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                              |
|                                                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.ItemSource =[new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 30, -20, 80, 20, 40, -50, -30, 70,    -40, 50 };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                      |
| [//Set line type sparkline]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.SparkLineType = [SparkLine]{style="COLOR: #2b91af"}.[SparkLineType]{style="COLOR: #2b91af"}.Column;]{style="FONT-FAMILY: 'Courier New'"}                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                               |
|                                                                                                                                                                                                                                    |
| [\'Set Sparkline points to source property]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                      |
|                                                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.ItemSource = [New]{style="COLOR: blue"} [Double]{style="COLOR: blue"}() {30, -20, 80, 20, 40, -50,-30, 70, -40, 50}]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [\'Set line type sparkline]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.sparkLine1.SparkLineType = [SparkLine]{style="COLOR: #2b91af"}.[SparkLineType]{style="COLOR: #2b91af"}. Column[]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image81_292.png){border="0"}

Figure 280: Column SparkLine

 

[]{#related-topics}
:::
