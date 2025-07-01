::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b46a58d8-9379-4cd4-9d00-32eb8a1029d8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d3e39cc3-3b29-4604-9c25-fcf6a4826385){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=71321e9c-336c-4c1c-a127-be9f135ad4bb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Appearance](ms-xhelp:///?Id=eb9d5ffd-71db-4613-9396-75dd4913dca1){.d2h_breadcrumbsNormal}
:::

### Border and Margins {#border-and-margins style="tab-stops: 0pt"}

 

**Chart Area Border**

 

Borders of the chart area can be customized using the below border properties.

 

::: {align="center"}
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
|                                     |                                                                                                                                          |
|                                     |                                                                                                                                          |
| **ChartArea Property**              | **Description**                                                                                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| BorderColor                         | Indicates the border color of the chart area.                                                                                            |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| BorderStyle                         | Indicates the border style.                                                                                                              |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| BorderWidth                         | Specifies the width of the border.                                                                                                       |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                |
|                                                                                                                                                                                |
| BorderAppearance                                                                                                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| BaseColor                           | Gets or sets the color of the base.                                                                                                      |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| FrameThickness                      | Gets or sets the frame thickness. This property setting will be effective, when SkinStyle is **Frame**.                                  |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| Interior                            | Sets the interior color of the border. This property settings will be effective when SkinStyle is **Sunken**, **Etched** and **Raised**. |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| SkinStyle                           | Specifies the border skin style.                                                                                                         |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.BorderColor = System.Drawing.[Color]{style="COLOR: teal"}.Goldenrod;]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.BorderStyle = System.Windows.Forms.[BorderStyle]{style="COLOR: black"}.FixedSingle;]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.BorderWidth = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.BaseColor = System.Drawing.[Color]{style="COLOR: teal"}.DarkGray;]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                                                                    |
| [//This property setting will be effective, when SkinStyle is \'Frame\'.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.FrameThickness = [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Chart.[ChartThickness]{style="COLOR: teal"}(15F, 30F, 15F, 18F);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                    |
| [//This interior property settings will be effective when SkinStyle is Sunken, Etched and Raised.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                               |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.[Color]{style="COLOR: teal"}.Maroon;]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.[ChartBorderSkinStyle]{style="COLOR: teal"}.Raised;]{style="FONT-FAMILY: 'Courier New'"}                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.ChartArea.BorderColor = System.Drawing.[Color]{style="COLOR: teal"}.Goldenrod]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.ChartArea.BorderWidth = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.DarkGray ]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                                           |
| [\'This property setting will be effective, when SkinStyle is \'Frame\'. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.FrameThickness = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Chart.ChartThickness(15F, 30F, 15F, 18F) ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                           |
| [\'This interior property settings will be effective when SkinStyle is Sunken, Etched and Raised. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Maroon ]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Raised ]{style="FONT-FAMILY: 'Courier New'"}                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Chart Area Shadow

 

The chart area can also be rendered with a shadow. Turn this feature on, by enabling the **ChartAreaShadow** property.

 

::: {align="center"}
+-----------------------------------+--------------------------------------------+
|                                   |                                            |
|                                   |                                            |
| Chart control Property            | Description                                |
+-----------------------------------+--------------------------------------------+
| ChartAreaShadow                   | Indicates whether chart area has a shadow. |
+-----------------------------------+--------------------------------------------+
| ShadowColor                       | Specifies the color of the shadow.         |
+-----------------------------------+--------------------------------------------+
| ShadowWidth                       | Specifies the width of the shadow.         |
+-----------------------------------+--------------------------------------------+
:::

**\
\**

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartAreaShadow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ShadowColor = [new]{style="COLOR: blue"} Syncfusion.Drawing.[BrushInfo]{style="COLOR: teal"}(Syncfusion.Drawing.[GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, System.Drawing.[Color]{style="COLOR: teal"}.AntiqueWhite, System.Drawing.[Color]{style="COLOR: teal"}.Goldenrod);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ShadowWidth = 7;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                        |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.ChartAreaShadow = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.ShadowColor = [New]{style="COLOR: blue"} Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.[GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, System.Drawing.[Color]{style="COLOR: teal"}.AntiqueWhite, System.Drawing.[Color]{style="COLOR: teal"}.Goldenrod)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ShadowWidth = 7]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

![](ImagesExt/image84_318.png){border="0"}

 

Figure 319: ChartAreaShadow = \"True\"

 

Chart Area Margins

 

Margin for the chart area can be controlled using ChartAreaMargins property. It indicates the margin that will be deduced from Chart Area\'s representation rectangle.

 

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------------+
| Chart control Property            | Description                                                                           |
+-----------------------------------+---------------------------------------------------------------------------------------+
| ChartAreaMargins                  | Specifies the amount of pixels between the chart area border and the chart plot area. |
|                                   |                                                                                       |
|                                   |                                                                                       |
|                                   |                                                                                       |
|                                   | Default is **{10, 10, 10, 10}**.                                                      |
+-----------------------------------+---------------------------------------------------------------------------------------+
:::

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartAreaMargins = [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Chart.[ChartMargins]{style="COLOR: teal"}(10, 10, 10, 20);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                            |
|                                                                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.ChartAreaMargins = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 20)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

ChartPlot Area Margins

 

The margins for ChartPlotArea is specified in **ChartPlotAreaMargins** property.

 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **ChartControl Property**         | **Description**                                                                                                                                                                                           |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ChartPlotAreaMargins              | Indicates the margin of the axis labels. This  margin is supported for left, Top, Right and Bottom side of the chart. This property works only if **EdgeLabelsDrawingMode** property is set to **Shift**. |
|                                   |                                                                                                                                                                                                           |
|                                   |                                                                                                                                                                                                           |
|                                   |                                                                                                                                                                                                           |
|                                   | Default is **{10, 10, 10, 10}**.                                                                                                                                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| AdjustPlotAreaMargins             | Gets / sets the mode of drawing the edge labels. Default is **AutoSet**.                                                                                                                                  |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EdgeLabelsDrawingMode             | Gets or sets the edge labels drawing mode.                                                                                                                                                                |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                               |
|                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = Syncfusion.Windows.Forms.Chart.[ChartAxisEdgeLabelsDrawingMode]{style="COLOR: teal"}.Shift;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.AdjustPlotAreaMargins = Syncfusion.Windows.Forms.Chart.[ChartSetMode]{style="COLOR: teal"}.UserSet;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.ChartPlotAreaMargins.Left = 200;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                   |
|                                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = Syncfusion.Windows.Forms.Chart.[ChartAxisEdgeLabelsDrawingMode]{style="COLOR: black"}.Shift]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.AdjustPlotAreaMargins = Syncfusion.Windows.Forms.Chart.[ChartSetMode]{style="COLOR: black"}.UserSet]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartArea.ChartPlotAreaMargins.Left = 200]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Spacing between elements**

 

The spacing between elements in the chart is specified using the **ElementsSpacing** property. For example, the space between the chart right border and legend right border if **LegendPosition** is set to **Right**.

 

::: {align="center"}
  ------------------------ -----------------------------------------------------------------------------
  Chart control Property   Description
  ElementsSpacing          Specifies the spacing between the elements in the chart. Default is **20**.
  ------------------------ -----------------------------------------------------------------------------
:::

 

[]{#p208} 

 

[]{#related-topics}
:::::::::
