::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Graphics {#graphics style="tab-stops: 0pt"}

[]{#p34} 

Primitives

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The general class **PdfGraphics** enables to draw a wide range of primitives like lines, curves, paths and text. For each such operation there is a set of methods called **Draw\<primitive\>()** (e.g. DrawLine). Each set of methods accepts parameters specific to each primitive type (for example: pen, brush, boundaries, etc). If pen is used, the primitive is drawn, and if brush is used, the primitive is filled. You can also use Null value instead of pen or brush.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following are the public members exposed by the PdfGraphics class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Methods

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------------------- -----------------------------------------------------------------------------------------------------
  Name                          Description
  CheckCorrectLayoutRectangle   Creates laid
  ClipTranslateMargins          Sets the drawing area and translates the origin
  DrawArc                       Draws an arc
  DrawBezier                    Draws a Bezier curve
  DrawEllipse                   Draws an ellipse
  DrawImage                     Inserts an image
  DrawLine                      Draws a line
  DrawPath                      Draws a path
  DrawPdfTemplate               Draws a PDF template
  DrawPie                       Draws a Pie
  DrawPolygon                   Draws a Polygon shape
  DrawRectangle                 Draws a rectangle shape
  DrawString                    Draws the text
  DrawStringLayoutResult        Draws a layout result
  GetBezierArcPoints            Gets the Bezier points for arc constructing
  GetLineBounds                 Returns bounds of the line info
  GetTextVerticalAlignShift     Calculates shift value if the text is vertically aligned
  InitializeCoordinates         Initializes coordinate system
  MultiplyTransform             Multiplies the world transformation of the Graphics and specifies the Matrix
  PutComment                    Puts a comment line
  Reset                         Clears instances
  Restore                       Restores the state of the Graphics to the state represented by a GraphicsState or to the last state
  RotateTransform               Rotates coordinate system in counterclockwise direction
  Save                          Saves the current state of the Graphics and identifies the saved state with a GraphicsState
  ScaleTransform                Scales coordinates by specified coordinates
  SetBBox                       Sets the BBox entry of the graphics dictionary
  SetClip                       Modifying the current clipping path by intersecting it with the current path
  SetLayer                      Sets the layer for the graphics
  SetTransparency               Sets transparency
  SkewTransform                 Skews coordinate system axes
  TranslateTransform            Translates coordinates by specified coordinates
  ----------------------------- -----------------------------------------------------------------------------------------------------
:::

 

Properties

 

::: {align="center"}
  ----------------- ----------------------------------------------------------------------------------------------------
  Name              Description
  AutomaticFields   Gets the automatic fields
  ClientSize        Gets a SizeF structure that binds the region of the Graphics reduced by margins and page templates
  ColorSpace        Gets or sets the current color space
  Layer             Gets the layer for the graphics, if exists
  Matrix            Gets the matrix reflecting current transformation
  Page              Gets the page for this graphics, if exists
  Size              Gets the size of the canvas
  StreamWriter      Gets the stream writer
  ----------------- ----------------------------------------------------------------------------------------------------
:::

 

Units, Size and Co-ordinate System

 

The co-ordinate system is either Top or Left. Origin is translated depending on the margins and page templates. The measure units are points (1/72 inch). The **PdfUnitConvertor** class enables to convert different measure units.

 

**Size** property of PdfGraphics returns the size of the canvas. Also, **ClientSize** property returns a client area of the canvas, which might be smaller. Any output of the client area will not be visible.

 

Graphics State and Co-ordinate System Manipulation

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Also, PdfGraphics class allows manipulating with graphics state (save, restore) and coordinate system (rotate, translate, etc). **Save** and **Restore** methods can be used for manipulating with graphics state, while TranslateTransform, RotateTransform, etc., can be used for co-ordinates manipulating. Also, clip regions can be set using the **SetClip** method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You may save the current graphics state, translate the origin, rotate and draw some primitives, restore the graphics state and continue drawing with the restored coordinate system.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Transparency

 

You may specify transparency for pen operations (for example: drawing lines), brush operations (for example: filling shapes), and for both of them simultaneously.

 

Also, you may specify the method of the resulting color calculation. Transparency is set by using the **SetTransparency** method of PdfGraphics. It includes the following blend modes:

 

[·      ]{style="FONT-FAMILY: Symbol"}Normal

[·      ]{style="FONT-FAMILY: Symbol"}Multiply

[·      ]{style="FONT-FAMILY: Symbol"}Screen

[·      ]{style="FONT-FAMILY: Symbol"}Overlay

[·      ]{style="FONT-FAMILY: Symbol"}Darken

[·      ]{style="FONT-FAMILY: Symbol"}Lighten

[·      ]{style="FONT-FAMILY: Symbol"}ColorDodge

[·      ]{style="FONT-FAMILY: Symbol"}ColorBurn

[·      ]{style="FONT-FAMILY: Symbol"}HardLight

[·      ]{style="FONT-FAMILY: Symbol"}SoftLight

[·      ]{style="FONT-FAMILY: Symbol"}Difference

[·      ]{style="FONT-FAMILY: Symbol"}Exclusion

 

Text Output

 

There are plenty of **DrawString** methods in PdfGraphics that allow text printing. The format of the methods are similar to the System.Drawing.Graphics.DrawString methods.

 

**PdfPen** as well as **PdfBrush** are used to print the text. You can use either object, or even both pen and brush for the text output. PdfPen sets the text boundaries while PdfBrush fills the internal area of the text.

 

If the coordinates are used for the text output only, it will be printed despite the graphics boundaries. New lines symbols split the text by lines only. If the bound (RectangleF structure) of the text is set, the text will be laid out to fit the boundaries. If the width of the boundaries is set to 0 or less, the text will not be limited horizontally. If the height of the boundaries is set to 0 or less, the text will be limited by the boundaries of the PdfGraphics.

 

Text Output Settings

 

To apply different settings to text output, **PdfStringFormat** class is used. It contains variety of properties that allow to set different text output settings.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note:[ ]{style="COLOR: black; FONT-SIZE: 8pt"}You must add the Syncfusion.Pdf.Graphics namespace to work with Graphics and graphic elements.

 

 
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Graphic Elements](ms-xhelp:///?Id=75233569-daf7-4a27-8920-92a4c0f639c1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ColorSpace](ms-xhelp:///?Id=9bd28903-1064-414b-99d0-3389f720d78c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Images](ms-xhelp:///?Id=f7a0f82d-40b7-47cd-9ef1-6263c19227f5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Barcode](ms-xhelp:///?Id=35ae760b-d9d2-4a3f-a181-e8501cf74a7d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pagination](ms-xhelp:///?Id=1150b310-de8e-4fe5-814b-0aeb0f49d9d5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Page Templates](ms-xhelp:///?Id=30034916-cbea-406c-b79c-a32ea4c00a3c){style="TEXT-DECORATION: none"}
::::::
