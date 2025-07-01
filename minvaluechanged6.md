::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### MinValueChanged {#minvaluechanged style="tab-stops: 0pt"}

 

MinValueChanged -- The event occurs when the MinValue property of the IntegerTextBox is changed. When the MinValue is changed the Value and the MaxValue properties are formatted.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| **[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9.5pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[IntegerTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9.5pt"}[ [ MinValueChanged]{style="COLOR: red"}[=\"IntegerTextBox_MinValueChanged\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b; FONT-SIZE: 9pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9.5pt"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                                                 |
| **[IntegerTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ integerTextBox = [new]{style="COLOR: blue"} [IntegerTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**      |
|                                                                                                                                                                                                                                                 |
| **[integerTextBox.MinValueChanged+=[new]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**                                                                                                                         |
|                                                                                                                                                                                                                                                 |
| **[                           [PropertyChangedCallback]{style="COLOR: #2b91af"}(IntegerTextBox_MinValueChanged);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b; FONT-SIZE: 9pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

You can handle the MinValueChanged event as follows:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                   |
| **[private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[ [void]{style="COLOR: blue"} IntegerTextBox_MinValueChanged([DependencyObject]{style="COLOR: #2b91af"} d, [DependencyPropertyChangedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}** |
|                                                                                                                                                                                                                                                                                                                   |
| **[        {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                   |
| **[            [//Insert code to do some operations when the MinValue changed]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                   |
| **[        }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b; FONT-SIZE: 9pt"}                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
