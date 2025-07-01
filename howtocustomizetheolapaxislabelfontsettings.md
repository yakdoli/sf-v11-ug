::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to customize the OlapAxis label font settings? {#how-to-customize-the-olapaxis-label-font-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The label font settings of the primary and the secondary axis can easily be applied to an OlapChart by speicifying the label font properties, which are available under the PrimaryAxis and the SecondaryAxis of the OlapChart.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[XAML\]**                                                                                                                                                                                          |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
| [       \<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.PrimaryAxis]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                 |
| [              \<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ChartAxis]{style="COLOR: #a31515"}[ LabelFormat]{style="COLOR: red"}[=\"C\"]{style="COLOR: blue"} |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelFontFamily]{style="COLOR: red"}[=\"Arial\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                   |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelFontSize]{style="COLOR: red"}[=\"14\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                        |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelFontWeight]{style="COLOR: red"}[=\"ExtraBold\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                               |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelForeground]{style="COLOR: red"}[=\"DarkGray\"]{style="COLOR: blue"} [ /\>]{style="COLOR: blue"}\                          |
| [ ]{style="COLOR: red"}[      \</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.PrimaryAxis]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}           |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
| [       \<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.SecondaryAxis]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                               |
| [              \<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ChartAxis]{style="COLOR: #a31515"}[ LabelFormat]{style="COLOR: red"}[=\"C\"]{style="COLOR: blue"} |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelFontFamily]{style="COLOR: red"}[=\"Arial\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                   |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelFontSize]{style="COLOR: red"}[=\"14\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                        |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelFontWeight]{style="COLOR: red"}[=\"ExtraBold\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                               |
|                                                                                                                                                                                                       |
| [ ]{style="COLOR: red"}[                        ]{style="COLOR: blue"}[LabelForeground]{style="COLOR: red"}[=\"DarkGray\"]{style="COLOR: blue"} [ /\>]{style="COLOR: blue"}\                          |
| [ ]{style="COLOR: red"}[      \</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.SecondaryAxis]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}         |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                          |
|                                                                                                                                                                                     |
|                                                                                                                                                                                     |
|                                                                                                                                                                                     |
| [       this]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelForeground = [Brushes]{style="COLOR: #2b91af"}.DarkGray;\                                                             |
| [       this]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelFontFamily = [new]{style="COLOR: blue"} [FontFamily]{style="COLOR: #2b91af"}([\"Arial\"]{style="COLOR: #a31515"});\   |
| [       this]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelFontSize = 14d;\                                                                                                      |
| [       this]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelFontWeight = [FontWeights]{style="COLOR: #2b91af"}.ExtraBold;\                                                        |
|  \                                                                                                                                                                                  |
| [       this]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelForeground = [Brushes]{style="COLOR: #2b91af"}.DarkGray;\                                                           |
| [       this]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelFontFamily = [new]{style="COLOR: blue"} [FontFamily]{style="COLOR: #2b91af"}([\"Arial\"]{style="COLOR: #a31515"});\ |
| [       this]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelFontSize = 14d;\                                                                                                    |
| [       this]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelFontWeight = [FontWeights]{style="COLOR: #2b91af"}.ExtraBold;                                                       |
|                                                                                                                                                                                     |
|                                                                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                                                                               |
|                                                                                                                                                          |
|                                                                                                                                                          |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelForeground = [Brushes]{style="COLOR: #2b91af"}.DarkGray                                   |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelFontFamily = [New]{style="COLOR: blue"} [FontFamily]{style="COLOR: #2b91af"}(\"Arial\")   |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelFontSize = 14R                                                                            |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.PrimaryAxis.LabelFontWeight = [FontWeights]{style="COLOR: #2b91af"}.ExtraBold                              |
|                                                                                                                                                          |
|                                                                                                                                                          |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelForeground = [Brushes]{style="COLOR: #2b91af"}.DarkGray                                 |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelFontFamily = [New]{style="COLOR: blue"} [FontFamily]{style="COLOR: #2b91af"}(\"Arial\") |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelFontSize = 14R                                                                          |
|                                                                                                                                                          |
|           [Me]{style="COLOR: blue"}.olapChart.SecondaryAxis.LabelFontWeight = [FontWeights]{style="COLOR: #2b91af"}.ExtraBold                            |
|                                                                                                                                                          |
|                                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
