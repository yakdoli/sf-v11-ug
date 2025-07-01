::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Setting Watermark {#setting-watermark style="tab-stops: 0pt"}

 

You can set the Watermark for the IntegerTextBox by using the **WatermarkText** property. To enable Watermark, you have to set the **WatermarkTextIsVisible** property to true.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

Note: WatermarkText is visible only when the value is null.

 
:::

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="COLOR: black"}[]{style="COLOR: black; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[]{style="COLOR: blue; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[\<]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[syncfusion]{style="COLOR: #a31515; FONT-SIZE: 9.5pt"}[:]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[IntegerTextBox]{style="COLOR: #a31515; FONT-SIZE: 9.5pt"}[ x]{style="COLOR: red; FONT-SIZE: 9.5pt"}[:]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[Name]{style="COLOR: red; FONT-SIZE: 9.5pt"}[=\"integerTextBox\"]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[ Height]{style="COLOR: red; FONT-SIZE: 9.5pt"}[=\"25\"]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[ Width]{style="COLOR: red; FONT-SIZE: 9.5pt"}[=\"100\"]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[ ]{style="COLOR: red; FONT-SIZE: 9.5pt"}** |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[                                   Value]{style="COLOR: red; FONT-SIZE: 9.5pt"}[=\"{]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[x]{style="COLOR: #a31515; FONT-SIZE: 9.5pt"}[:]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[Null]{style="COLOR: #a31515; FONT-SIZE: 9.5pt"}[}\"]{style="COLOR: blue; FONT-SIZE: 9.5pt"}[]{style="FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[                                  [ MinValue]{style="COLOR: red"}[=\"-999\"]{style="COLOR: blue"}[ MaxValue]{style="COLOR: red"}[=\"999\"]{style="COLOR: blue"}[ UseNullOption]{style="COLOR: red"}[=\"True\"]{style="COLOR: blue"}]{style="FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[                                  [ WatermarkText]{style="COLOR: red"}[=\"Type Here\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}]{style="FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[                                   WatermarkTextIsVisible]{style="COLOR: red; FONT-SIZE: 9.5pt"}[=\"True\"/\>]{style="COLOR: blue; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------+
| **[C#]{style="COLOR: black"}[]{style="COLOR: black; FONT-SIZE: 9.5pt"}**                                |
|                                                                                                         |
| **[]{style="FONT-SIZE: 9.5pt"}**                                                                        |
|                                                                                                         |
| **[]{style="FONT-SIZE: 9.5pt"}**                                                                        |
|                                                                                                         |
| **[integerTextBox.UseNullOption = [true]{style="COLOR: blue"};]{style="FONT-SIZE: 9.5pt"}**             |
|                                                                                                         |
| **[integerTextBox.WatermarkText = [\"Type Here\"]{style="COLOR: #a31515"};]{style="FONT-SIZE: 9.5pt"}** |
|                                                                                                         |
| **[integerTextBox.WatermarkTextIsVisible = [true]{style="COLOR: blue"};]{style="FONT-SIZE: 9.5pt"}**    |
|                                                                                                         |
| **[integerTextBox.Value = [null]{style="COLOR: blue"};]{style="FONT-SIZE: 9.5pt"}**                     |
+---------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image30_226.png){border="0"}

Figure 617: IntegerTextBox with MaskedText

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[[WatermarkTemplate]{.UGHyperlink}](ms-xhelp:///?Id=a7967f1f-f6da-4b09-ac65-84ba40aa705d)[]{.UGHyperlink}

[[NullValue Support]{.UGHyperlink}](ms-xhelp:///?Id=137e357f-58c1-463b-9fb1-c42a058a7844)[]{.UGHyperlink}

 

[]{#related-topics}
::::
