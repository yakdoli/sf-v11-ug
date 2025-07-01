::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Graphics Customization Settings {#graphics-customization-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following properties can be used to set the composition quality, interpolation mode and smoothing mode for images added to the Edit Control. The rendering hint can also be set for text added to the Edit Control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------------+
| Edit Control Property             | Description                                                                           |
+-----------------------------------+---------------------------------------------------------------------------------------+
| GraphicsCompositingQuality        | Specifies image composition quality. The options provided are as follows:             |
|                                   |                                                                                       |
|                                   | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}  |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Invalid                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Default                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighSpeed                                       |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighQuality                                     |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}GammaCorrected                                  |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}AssumeLinear                                    |
+-----------------------------------+---------------------------------------------------------------------------------------+
| GraphicsInterpolationMode         | Specifies the interpolation mode. The options provided are as follows:                |
|                                   |                                                                                       |
|                                   | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}  |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Invalid                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Default                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Low                                             |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}High                                            |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Bilinear                                        |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Bicubic                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NearestNeighbor                                 |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighQualityBilinear                             |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighQualityBicubic                              |
+-----------------------------------+---------------------------------------------------------------------------------------+
| GraphicsSmoothingMode             | Specifies the smoothing mode. The options provided are as follows:                    |
|                                   |                                                                                       |
|                                   | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}  |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Invalid                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Default                                         |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighSpeed                                       |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}HighQuality                                     |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                            |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}AntiAlias                                       |
+-----------------------------------+---------------------------------------------------------------------------------------+
| GraphicsTextRenderingHint         | Specifies the text hinting mode. The options provided are as follows:                 |
|                                   |                                                                                       |
|                                   | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}  |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SystemDefault                                   |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SingleBitPerPixelGridFit                        |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SingleBitPerPixel                               |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}AntiAliasGridFit                                |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}AntiAlias                                       |
|                                   |                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ClearTypeGridFit                                |
+-----------------------------------+---------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.[CompositingQuality]{style="COLOR: teal"}.HighQuality;]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.[InterpolationMode]{style="COLOR: teal"}.HighQualityBilinear;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.[SmoothingMode]{style="COLOR: teal"}.HighSpeed;]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.[TextRenderingHint]{style="COLOR: teal"}.SingleBitPerPixelGridFit;]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                    |
|                                                                                                                                                                                                         |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                         |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                         |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                         |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHInteger.SingleBitPerPixelGridFit]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p98} 

[]{#related-topics}
::::
