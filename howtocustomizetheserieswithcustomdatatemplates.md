::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to customize the series with custom data templates? {#how-to-customize-the-series-with-custom-data-templates style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Series can be customized with user defined data templates. The following sample usage describes how to apply a data template to the series in an OlapChart.

The following data template will be used to customize the series:

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[XAML\]**                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                          |
| [\<]{style="COLOR: blue"}[DataTemplate]{style="COLOR: #a31515"}[ x]{style="COLOR: red"}[:]{style="COLOR: blue"}[Key]{style="COLOR: red"}[=\"ColumnTemplate\"\>]{style="COLOR: blue"}\                                                                                                                                    |
| [                ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[Canvas]{style="COLOR: #a31515"}[ Name]{style="COLOR: red"}[=\"myCanvas\"\>]{style="COLOR: blue"}\                                                                                                                                                    |
| [                    ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[Grid]{style="COLOR: #a31515"}[ Name]{style="COLOR: red"}[=\"OuterGrid\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                          |
| [                          Canvas.Left]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[Binding]{style="COLOR: #a31515"}[ X]{style="COLOR: red"}[}\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                          |
| [                          Width]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[Binding]{style="COLOR: #a31515"}[ Width]{style="COLOR: red"}[}\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                          |
| [                          Height]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[Binding]{style="COLOR: #a31515"}[ ElementName]{style="COLOR: red"}[=myCanvas,]{style="COLOR: blue"}[ ]{style="COLOR: red"}                                                                                                             |
|                                                                                                                                                                                                                                                                                                                          |
| [                          Path]{style="COLOR: red"}[=ActualHeight}\" \>]{style="COLOR: blue"}\                                                                                                                                                                                                                          |
| [                        ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[Border]{style="COLOR: #a31515"}[ Name]{style="COLOR: red"}[=\"ColumnRect\"]{style="COLOR: blue"} \                                                                                                                                           |
| [                          VerticalAlignment]{style="COLOR: red"}[=\"Bottom\"]{style="COLOR: blue"} \                                                                                                                                                                                                                    |
| [                          Width]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[Binding]{style="COLOR: #a31515"}[ Width]{style="COLOR: red"}[}\"]{style="COLOR: blue"}[ Height]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[Binding]{style="COLOR: #a31515"}[ Height]{style="COLOR: red"}[}\"]{style="COLOR: blue"}\ |
| [                          CornerRadius]{style="COLOR: red"}[=\"8,8,0,0\"]{style="COLOR: blue"}[ Background]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[Binding]{style="COLOR: #a31515"}[ Interior]{style="COLOR: red"}[}\"\>]{style="COLOR: blue"}\                                                                 |
| [                        ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[Border]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                                                                                                   |
| [                    ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[Grid]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                                                                                                         |
| [                ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[Canvas]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                                                                                                           |
| [\</]{style="COLOR: blue"}[DataTemplate]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The following code snippet explains how to use a data template for a series:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                   |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
|        [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} i = 0; i \< [this]{style="COLOR: blue"}.olapchart1.Series.Count; i++)\                                                         |
|        {\                                                                                                                                                                                    |
|            [//Apply Series Template to display the series cylindrical style]{style="COLOR: green"}\                                                                                          |
|            [this]{style="COLOR: blue"}.olapchart1.Series\[i\].Template =                                                                                                                     |
|                                                                                                                                                                                              |
| [               this]{style="COLOR: blue"}.Resources\[[\"ColumnTemplate\"]{style="COLOR: #a31515"}\] [as]{style="COLOR: blue"} [DataTemplate]{style="COLOR: #2b91af"};                       |
|                                                                                                                                                                                              |
| \                                                                                                                                                                                            |
|            [// Apply Series Interior to display the series in different colors.]{style="COLOR: green"}\                                                                                      |
|            [this]{style="COLOR: blue"}.olapchart1.Series\[i\].Interior =                                                                                                                     |
|                                                                                                                                                                                              |
|                [App]{style="COLOR: #2b91af"}.Current.Resources\[[\"SeriesInterior\"]{style="COLOR: #a31515"} + i\] [as]{style="COLOR: blue"} [LinearGradientBrush]{style="COLOR: #2b91af"};\ |
|        }                                                                                                                                                                                     |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                                                                                                       |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|        [For]{style="COLOR: blue"} i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.olapchart1.Series.Count - 1 |
|                                                                                                                                                                                  |
|            [\'Apply Series Template to display the series cylindrical style]{style="COLOR: green"}                                                                               |
|                                                                                                                                                                                  |
|               [Me]{style="COLOR: blue"}.olapchart1.Series(i).Template = TryCast([Me]{style="COLOR: blue"}.Resources(\"ColumnTemplate\"), DataTemplate)                           |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|            [\' Apply Series Interior to display the series in different colors.]{style="COLOR: green"}                                                                           |
|                                                                                                                                                                                  |
|            [Me]{style="COLOR: blue"}.olapchart1.Series(i).Interior = TryCast(App.Current.Resources(\"SeriesInterior\" & i), LinearGradientBrush)                                 |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|        [Next]{style="COLOR: blue"} i                                                                                                                                             |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

A sample, which demonstrates all the series customization, can be found in the following installation location:

**..\\Syncfusion\\\<Version Number\>\\BI\\WPF\\OlapChart.WPF\\Samples\\Customization\\Series Customization Demo**

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
