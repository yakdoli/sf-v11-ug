::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=492dc901-02ab-4599-828f-06b69c5a477b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e1afe5c4-944d-4fba-b010-d0d1bbe99914){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=71321e9c-336c-4c1c-a127-be9f135ad4bb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Appearance](ms-xhelp:///?Id=eb9d5ffd-71db-4613-9396-75dd4913dca1){.d2h_breadcrumbsNormal}
:::

### Foreground Settings {#foreground-settings style="tab-stops: 0pt"}

 

Chart Title

 

The ChartControl provides properties to customize and align the text within the control. Below are the text properties.

 

Using the **ChartControl.Text** property, users can provide the title that appears at the top of the chart. **TextPosition** and **TextAlignment** further lets you control the relative positioning of this title.

 

Here are some properties that affect the title text in the chart.

 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------+
| Chart control Property            | Description                                                                              |
+-----------------------------------+------------------------------------------------------------------------------------------+
| Text                              | Specifies the title for the chart.                                                       |
+-----------------------------------+------------------------------------------------------------------------------------------+
| TextPosition                      | Specifies the position of the chart. Possible values are,                                |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Top (**default setting**)                          |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Bottom                                             |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Left                                               |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Right                                              |
+-----------------------------------+------------------------------------------------------------------------------------------+
| TextAlignment                     | Specifies the alignment of the title with respect to the chart borders. Possible values: |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Near                                               |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Center (**default setting**)                       |
|                                   |                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Far                                                |
+-----------------------------------+------------------------------------------------------------------------------------------+
| Font                              | Indicates the font style of the title.                                                   |
+-----------------------------------+------------------------------------------------------------------------------------------+
| ForeColor                         | Indicates the foreground color of the title.                                             |
+-----------------------------------+------------------------------------------------------------------------------------------+
:::

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Text = [\"Illustrates Foreground Settings\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Font = [new]{style="COLOR: blue"} System.Drawing.[Font]{style="COLOR: teal"}([\"Arial\"]{style="COLOR: maroon"}, 11.25F, System.Drawing.[FontStyle]{style="COLOR: teal"}.Bold);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ForeColor = System.Drawing.[Color]{style="COLOR: teal"}.Bisque;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.TextPosition = [ChartTextPosition]{style="COLOR: teal"}.Top;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.Text = [\"Illustrates Foreground Settings\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Font = [New]{style="COLOR: blue"} System.Drawing.[Font]{style="COLOR: teal"}([\"Arial\"]{style="COLOR: maroon"}, 11.25F, System.Drawing.[FontStyle]{style="COLOR: teal"}.Bold)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ForeColor = System.Drawing.[Color]{style="COLOR: teal"}.Bisque]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.TextPosition = [ChartTextPosition]{style="COLOR: teal"}.Top]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

![](ImagesExt/image84_319.jpg){border="0"}

 

Figure 320: Illustrates changes affecting the Title Text

 

General Text Related settings

 

The following text related properties affect all the text rendered in the chart.

 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Chart control Property**        | **Description**                                                                                                                                                                                                                                                                |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TextRenderingHint                 | Specifies the way the text is drawn. Possible values:                                                                                                                                                                                                                          |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**AntiAlias** - each character is drawn using its anti-aliased glyph bitmap without hinting.                                                                                                                                             |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**AntiAliasGridFit** - each character is drawn using its anti-aliased glyph bitmap with hinting.                                                                                                                                         |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**ClearTypeGridFit** - each character is drawn using its glyph clear type bitmap with hinting.                                                                                                                                           |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**SingleBitPerPixel** - each character is drawn using its glyph bitmap.                                                                                                                                                                  |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**SingleBitPerPixelGridFit** - each character is drawn using its glyph bitmap.                                                                                                                                                           |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**SystemDefault** - each character is drawn using its glyph bitmap with the system default rendering hint. The text will be drawn using whatever the font-smoothing settings the user had selected for the system. (**default setting**) |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SmoothingMode                     | Specifies how chart elements should be rendered. Possible values:                                                                                                                                                                                                              |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}AntiAlias                                                                                                                                                                                                                                |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighQuality                                                                                                                                                                                                                              |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighSpeed                                                                                                                                                                                                                                |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Invalid                                                                                                                                                                                                                                  |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                                                                                                                                                                                                     |
|                                   |                                                                                                                                                                                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Default(**default** **setting**)                                                                                                                                                                                                         |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

See Also

 

[Axis Label Text Formatting, Appearance and Positioning]{.UGHyperlink}, (for info on changing axis label text settings)

[Customizing Label Text]{.UGHyperlink}[, ]{.UGHyperlink}[Intersecting Labels]{.UGHyperlink}[, ]{.UGHyperlink}[Grouping Labels]{.UGHyperlink}[, ]{style="COLOR: black"}(for info on changing axis label text settings)

[Series Customization/Font]{.UGHyperlink}[, ]{style="COLOR: black"}(for info on changing series text settings)

[Chart Legend]{.UGHyperlink}[ ]{.UGHyperlink}(for info on changing legend text settings)

 

[]{#p209} 

[]{#related-topics}
::::::
