::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ColorsMode {#colorsmode style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Gets / sets ColorsMode of the boxes in the financial chart types.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-------------------------------------+-----------------------------------------------------------------------------------+
| Details                                                                                                                 |
+-------------------------------------+-----------------------------------------------------------------------------------+
| Possible Values                     | DarkLight -Draws series data points as a darklight colorsmode.                    |
|                                     |                                                                                   |
|                                     | Fixed - Draws series data points as a Fixed colorsmode.                           |
|                                     |                                                                                   |
|                                     | Mixed - Draws series data points as a Mixed colorsmode[.]{style="FONT-SIZE: 8pt"} |
+-------------------------------------+-----------------------------------------------------------------------------------+
| Default Value                       | Fixed                                                                             |
+-------------------------------------+-----------------------------------------------------------------------------------+
| 2D / 3D Limitations                 | None                                                                              |
+-------------------------------------+-----------------------------------------------------------------------------------+
| Applies to Chart Element            | All series                                                                        |
+-------------------------------------+-----------------------------------------------------------------------------------+
| Applies to Chart Types              | Renko Chart (Financial Chart)                                                     |
+-------------------------------------+-----------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Here is some sample code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                              |
|                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [// Setting ColorsMode for series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].ConfigItems.FinancialItem.ColorsMode = [ChartFinancialColorMode]{style="COLOR: teal"}.DarkLight;]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                      |
| [\' Setting ColorsMode for series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                      |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).ConfigItems.FinancialItem.ColorsMode = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartFinancialColorMode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.DarkLight]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_111.jpg){border="0"}

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Figure 106: Renko Chart with \"DarkLight\" ColorsMode

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

![](ImagesExt/image64_112.jpg){border="0"}

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Figure 107: Renko Chart with \"Mixed\" ColorsMode

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[[Renko Chart]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[]{.UGHyperlink}

[]{#p87} 

[]{#related-topics}
::::
