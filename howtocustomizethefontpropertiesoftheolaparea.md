::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to customize the font properties of the OlapArea? {#how-to-customize-the-font-properties-of-the-olaparea style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Typically, the primary axis and the secondary axis font settings will override the font properties applied to their content in the OlapArea. To set the font properties such as Foreground, FontFamily, FontSize, and FontWeight consider using the font properties available in the primary and the secondary axis.

 

###### 1.6.1.1.5.1 FontStyle {#fontstyle style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                              |
|                                                                                                                         |
|                                                                                                                         |
|                                                                                                                         |
| [       this]{style="COLOR: blue"}.olapchart1.Series\[0\].Area.FontStyle = [FontStyles]{style="COLOR: #2b91af"}.Italic; |
|                                                                                                                         |
|                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-----------------------------------------------------------------------------------------+
| **\[VB\]**                                                                              |
|                                                                                         |
|                                                                                         |
|                                                                                         |
| [      Me]{style="COLOR: blue"}.olapchart1.Series(0).Area.FontStyle = FontStyles.Italic |
|                                                                                         |
|                                                                                         |
+-----------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

See also:

How to customize PrimaryAxis font properties?

How to customize SecondaryAxis font properties?

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
