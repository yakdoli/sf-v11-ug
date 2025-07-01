::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Pagination {#pagination style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**Pagination** is the capability of the elements to span more than one page (to be shared by more than one page). The base class for all such elements is the **PdfLayoutElement** class. All the primitives that are derived from that class support page layouting in their own way. The following events are raised by this class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------- -----------------------------------------------------------------
  Name              Description
  BeginPageLayout   This event is raised before the element is printed on the page.
  EndPageLayout     This event is raised after the element is printed on the page.
  ----------------- -----------------------------------------------------------------
:::

 

The layouting is accomplished by using the following methods.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                          |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [PdfLayoutResult]{style="COLOR: teal"} Draw( PdfPage page, [PointF]{style="COLOR: teal"} location, PdfLayoutFormat format ); ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}            |
|                                                                                                                                                                                                                                                                          |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [PdfLayoutResult]{style="COLOR: teal"} Draw( PdfPage page, [RectangleF]{style="COLOR: teal"} layoutRectangle, PdfLayoutFormat format ); ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ PdfLayoutResult Draw(PdfPage page, PointF location, PdfLayoutFormat format) ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}           |
|                                                                                                                                                                                                                        |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ PdfLayoutResult Draw(PdfPage page, RectangleF layoutRectangle, PdfLayoutFormat format)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The parameters define the page where the layouting should start, a location or bounds on the page, and layouting settings.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: If, only the location is set, or the width or height is less than or equal to zero, the bounds are calculated, as the remaining space on the page where the location specified is a Left or Top of the bounds.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**PdfLayoutFormat** class specifies basic layouting settings such as type of page break, the bounds on the next page, and so on. The following are the properties of the PdfgLayoutFormat.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------- ---------------------------------------------------------------------------
  Name                Description
  Break               Gets or sets break type of the element.
  Layout              Gets or sets layout type of the element.
  PaginateBounds      Gets or sets the bounds on the next page.
  UsePaginateBounds   Gets a value that indicates whether PaginateBounds should be used or not.
  ------------------- ---------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note:

 
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
***[·    ]{style="FONT-FAMILY: Symbol"}***PdfLayoutFormat contains the PaginateBounds property that specifies the bounds of the element on the pages that follows. If this property is set, the element will use it for laying out the next pages, otherwise the element will be laid out according to the bounds used on the first page (layoutRectangle parameter or calculated as was mentioned above), but with the Y coordinate set to zero (0).

***[·    ]{style="FONT-FAMILY: Symbol"}***Each element may implement its own laying out settings depending on its own structure and specifications.

***[·    ]{style="FONT-FAMILY: Symbol"}***The objects supporting page laying out can be drawn on simple graphics or by using the following methods.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                               |
|                                                                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} Draw( PdfGraphics graphics ); ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                         |
|                                                                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} Draw( PdfGraphics graphics, [PointF]{style="COLOR: teal"} location ); ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                             |
|                                                                                                                                                                                  |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ void Draw(PdfGraphics graphics) ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                 |
|                                                                                                                                                                                  |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ void Draw(PdfGraphics graphics, PointF location)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

After laying out, each element returns a lay out result, depending on the element and the settings. The base result is described by the **PdfLayoutResult** class.

 

The basic information stored in result is the page where the element ends, and the bounds of the element on that page, which might be helpful for further drawing operations on this page.

 

The following are the properties of the PdfLayoutResult class.

 

::: {align="center"}
  -------- ---------------------------------------------------------------------
  Name     Description
  Bounds   Gets the bounds of the element on the last page where it was drawn.
  Page     Gets the last page where the element was drawn.
  -------- ---------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For example, **PdfTextLayoutResult** provides a text that was not laid out and a width of the last laid out line. PdfMetafile as well as graphics primitives also supports multipage layout. Additionally, if it is required to eliminate the splitting of text lines between the pages, the **PdfMetafileLayoutFormat** is used as the input parameter of the **Draw** method. This class contains a property, which allows to enable or disable splitting of text lines.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There are two events provided by the laid out elements: **BeginPageLayout** and **EndPageLayout**. They provide an option to track the current state of the layout, and specify the custom settings for the layout process.[]{#p39}

 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{#related-topics}
:::::::::
