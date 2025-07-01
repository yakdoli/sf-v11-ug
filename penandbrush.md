::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Pen and Brush {#pen-and-brush style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Pen and Brush are two types of virtual graphics tools that are used to create objects, for example, ***rectangle***, ***ellipse*** or ***text***. Pen controls stroking operations (drawing borders and lines), while the brush controls filling operations (non-stroking).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Brush

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There are four types of brushes. They are as follows. These brushes control the filling of the interior region of a shape.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}solid

[·      ]{style="FONT-FAMILY: Symbol"}tiling

[·      ]{style="FONT-FAMILY: Symbol"}linear gradient

[·      ]{style="FONT-FAMILY: Symbol"}radial gradient.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1\. PdfSolidBrush

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This type of brush fills a shape with a single color. You may set the color while constructing the brush. The following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                 |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                |
| [PdfBrush]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ brush = [new]{style="COLOR: blue"} [PdfSolidBrush]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Black);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ brush [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfBrush = [New]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfSolidBrush(Color.Black)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

2\. PdfTilingBrush

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This is one of the complex brushes available in Essential PDF. It enables you to fill the shape\'s interior with a repetitive pattern. To create your own pattern, use the **Graphics** property to obtain the **PdfGraphics** class instance, which allows drawing many graphics primitives.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

3\. PdfLinearGradientBrush

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This brush is very similar to the .NET LinearGradientBrush. It has similar properties to specify blend colors and positions. Also, it requires the start and end position relative to the current origin to calculate gradient parameters and colors. Optionally, you may specify a rectangle, and a LinearGradientMode (which determines the orientation) or angle from the x-axis.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

4\. PdfRadialGradientBrush

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This brush is similar to the above brush, the only exception being the gradient effect. Here the gradient is not linear, it\'s radial. This means, there are two circles with different center points and radii.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Pen

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A pen controls drawing lines and shape borders. You may specify the width, different dash patterns and color of the pen. Optionally, you may create a pen from a brush which allows you to use gradients in drawing lines and curves. However, you should be careful with the coordinates of the brush.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**PdfPen** class defines these settings for drawing. The following are the properties of this class.

[         ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------+
| Name                              | Description                                                                          |
+===================================+======================================================================================+
| Brush                             | Gets or sets the brush, which specifies the pen behavior.                            |
+-----------------------------------+--------------------------------------------------------------------------------------+
| Color                             | Gets or sets the color of the pen.                                                   |
+-----------------------------------+--------------------------------------------------------------------------------------+
| DashOffset                        | Gets or sets the dash offset of the pen.                                             |
+-----------------------------------+--------------------------------------------------------------------------------------+
| DashPattern                       | Gets or sets the dash pattern of the pen. The following dash patterns are available: |
|                                   |                                                                                      |
|                                   | Dash                                                                                 |
|                                   |                                                                                      |
|                                   | DashDot                                                                              |
|                                   |                                                                                      |
|                                   | DashDotDot                                                                           |
|                                   |                                                                                      |
|                                   | Dot                                                                                  |
|                                   |                                                                                      |
|                                   | Solid                                                                                |
|                                   |                                                                                      |
|                                   | Custom                                                                               |
+-----------------------------------+--------------------------------------------------------------------------------------+
| DashStyle                         | Gets or sets the dash style of the pen.                                              |
+-----------------------------------+--------------------------------------------------------------------------------------+
| LineCap                           | Gets or sets the line cap of the pen.                                                |
+-----------------------------------+--------------------------------------------------------------------------------------+
| LineJoin                          | Gets or sets the line join style of the pen.                                         |
+-----------------------------------+--------------------------------------------------------------------------------------+
| MiterLimit                        | Gets or sets the miter limit.                                                        |
+-----------------------------------+--------------------------------------------------------------------------------------+
| Width                             | Gets or sets the width of the pen.                                                   |
+-----------------------------------+--------------------------------------------------------------------------------------+
:::

 

The following code example illustrates how to define a pen.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                |
|                                                                                                                                                                                                     |
| [PdfPen]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pen = [new]{style="COLOR: blue"} [PdfPen]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Black);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pen [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfPen = [New]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfPen(Color.Black)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PdfPens and PdfBrushes

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

If you do not want to create pens and brushes on your own, you can use static classes that provide you with static immutable pens and brushes. Each property is named after the color of the pen or brush that it returns.

 

 

[]{#related-topics}
::::
