::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### FancyToolTip {#fancytooltip style="tab-stops: 0pt"}

 

Defines the styles for a fancy tooltip. These styles include font, marker style, symbol shape, back color and other related styles.

 

::: {align="center"}
+-------------------------------------+-------------------------------------------------------------------+
| Details                                                                                                 |
+-------------------------------------+-------------------------------------------------------------------+
| **Possible Values**                 | Specifies symbol, symbol styles for the ToolTip.                  |
+-------------------------------------+-------------------------------------------------------------------+
| **Default Value    **               | [·      ]{style="FONT-FAMILY: Symbol"}**Visible** - False         |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Angle**  - 15             |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Alignment** - Left        |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**ForeColor** - Color.Black |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**BackColor** - Color.Info  |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**SymbolColor** - Color.Red |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Font** - Arial, 8 pt      |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Symbol Size** - (10,10)   |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Symbol** - Circle         |
|                                     |                                                                   |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Style** - SmoothRectangle |
+-------------------------------------+-------------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                                |
+-------------------------------------+-------------------------------------------------------------------+
| **Applies to Chart Element**        | All series                                                        |
+-------------------------------------+-------------------------------------------------------------------+
| **Applies to Chart Types**          | All Chart Types                                                   |
+-------------------------------------+-------------------------------------------------------------------+
:::

 

Here is some sample code.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                         |
|                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].FancyToolTip.Angle = 180;]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].FancyToolTip.Style = [MarkerStyle]{style="COLOR: teal"}.SmoothRectangle;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].FancyToolTip.Symbol = [ChartSymbolShape]{style="COLOR: teal"}.Hexagon;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].FancyToolTip.Visible = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                     |
|                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).FancyToolTip.Angle = 180]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).FancyToolTip.Style = MarkerStyle.SmoothRectangle]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).FancyToolTip.Symbol = ChartSymbolShape.Hexagon]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                        |
| [Me.]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[chartControl1.Series(0).FancyToolTip.Visible =[ True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_129.jpg){border="0"}

 

Figure 128: StackingBar Chart with FancyToolTip

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

See Also

 

[Chart Types]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p102} 

[]{#related-topics}
::::
