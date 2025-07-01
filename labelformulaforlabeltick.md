::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### LabelFormula for LabelTick {#labelformula-for-labeltick style="tab-stops: 0pt"}

Essential Gauge supports formula based label ticks. To enable this set **IsCalculateFormulaEnabled** property to **true**, and specifying a valid formula to the **CalculateFormula**. The value of the **LabelTick** is calculated based upon the formula that is specified.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 12pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[CircularLabelTick]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ DistanceFromScale]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"5\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ FontSize]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"11\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ Name]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"labelTick\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ ]{style="FONT-FAMILY: Consolas"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [  [TickPlacement]{style="COLOR: red"}[=\"Inside\"]{style="COLOR: blue"}[ TickStyle]{style="COLOR: red"}[=\"MajorTick\"]{style="COLOR: blue"} [IsCalculateFormulaEnabled]{style="COLOR: red"}[=\"True\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}]{style="FONT-FAMILY: Consolas"}                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [  CalculateFormula]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"!((x/10)\*10)\"\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[CircularLabelTick]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 16pt"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"}**                                                                                   |
|                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 12pt"}**                                                                                                                                    |
|                                                                                                                                                                                           |
| [CircularLabelTick]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ labeltick = [new]{style="COLOR: blue"} [CircularLabelTick]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas"} |
|                                                                                                                                                                                           |
| [labeltick.DistanceFromScale = 5;]{style="FONT-FAMILY: Consolas"}                                                                                                                         |
|                                                                                                                                                                                           |
| [labeltick.FontSize = 11;]{style="FONT-FAMILY: Consolas"}                                                                                                                                 |
|                                                                                                                                                                                           |
| [labeltick.TickPlacement = [ScalePlacement]{style="COLOR: #2b91af"}.Inside;]{style="FONT-FAMILY: Consolas"}                                                                               |
|                                                                                                                                                                                           |
| [labeltick.TickStyle = [TickStyle]{style="COLOR: #2b91af"}.MajorTick;]{style="FONT-FAMILY: Consolas"}                                                                                     |
|                                                                                                                                                                                           |
| [labeltick.IsCalculateFormulaEnabled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas"}                                                                                       |
|                                                                                                                                                                                           |
| [labeltick.CalculateFormula = [\"!((x/10)\*10)\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: Consolas"}                                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

When the code runs, the following output displays.

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

![](ImagesExt/image54_36.jpg){border="0"}

Figure 33: Formula is Enabled

***[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}*** 

 

[]{#related-topics}
:::
