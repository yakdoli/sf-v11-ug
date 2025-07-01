::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Images {#images style="tab-stops: 0pt"}

 

Essential PDF supports both raster and vector images. It supports the following image formats:

 

[·      ]{style="FONT-FAMILY: Symbol"}Bmp

[·      ]{style="FONT-FAMILY: Symbol"}Jpeg

[·      ]{style="FONT-FAMILY: Symbol"}Gif

[·      ]{style="FONT-FAMILY: Symbol"}Png

[·      ]{style="FONT-FAMILY: Symbol"}Tif

[·      ]{style="FONT-FAMILY: Symbol"}Wmf

[·      ]{style="FONT-FAMILY: Symbol"}Emf and

[·      ]{style="FONT-FAMILY: Symbol"}Emf+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Images are supported through the **PdfImage** class, which is an abstract base class that provides the common functionality for **PdfBitmap** and **PdfMetafile** classes. There are static methods in PdfImage providing the capability to create a PdfImage instance from different sources.

 

PdfImage as well as graphics elements support layouting multiple pages (see [[Pagination]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}](ms-xhelp:///?Id=916beb29-6918-444b-850f-bc07109db4a3)).

 

Base Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Height**-Specifies image height in pixels

[·      ]{style="FONT-FAMILY: Symbol"}**Width**-Specifies image width in pixels

[·      ]{style="FONT-FAMILY: Symbol"}**HorizontalResolution**-Specifies horizontal image resolution, which is also known as DpiX

[·      ]{style="FONT-FAMILY: Symbol"}**VerticalResolution**-Specifies vertical image resolution, also known as DpiY

[·      ]{style="FONT-FAMILY: Symbol"}**PhysicalDimension**-Specifies image dimension in points

[·      ]{style="FONT-FAMILY: Symbol; COLOR: black"}**Quality**-Gets or sets the quality[]{style="COLOR: black"}

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image22_2.jpg){border="0"}Note: Image quality is 100 by default, which increases the resultant file size and quality. Reducing the quality will reduce the file size.
:::

 

Bitmaps

 

**PdfBitmap** class provides functionality of raster images described above. Masks and alpha channels are supported. There are two different kinds of masks: color mask, which is implemented by the **PdfColorMask** class, and image mask, which is implemented by the **PdfImageMask** class. Masks are set by using the **Mask** property of the PdfBitmap object.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The active frame is chosen if the image is a multiframe image (Gif, Tif). The **FrameCount** and **ActiveFrame** properties enable to control the active frame.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Metafiles

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

All three types of windows metafiles are supported by Essential PDF through the **PdfMetafile** class. Additionally, **Rich Text Format** (RTF) is supported through the PdfMetafile class. PdfMetafile supports multipage layout as well as graphic elements. Additionally, it supports splitting of text lines through the page breaks, if the text line is shared by pages. **PdfMetafileLayoutFormat** should be used when the **Draw** method is called for handling this feature.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

While rendering a large meta file with images and text in a PDF document, which has page breaks, you will notice that the images and text are not split across the page breaks. This is achieved by disabling the **SplitTextLines** and **SplitImages** properties of the **PdfMetafileLayoutFormat** class as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                        |
| [PdfMetafileLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfMetafileLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [format.SplitTextLines = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                        |
| [format.SplitImages = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfMetafileLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [format.SplitTextLines = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                    |
| [format.SplitImages = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following are the public properties of the PdfMetafileLayoutFormat class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------- ---------------------------------------------------------------------------------------------------
  Name                Description
  Break               Gets or sets break type of the element.
  Layout              Gets or sets layout type of the element.
  PaginateBounds      Gets or sets the bounds on the next page.
  SplitImages         Gets or sets the value indicating whether the images should be split between the pages or not.
  SplitTextLines      Gets or sets the value indicating whether the text line should be split between the pages or not.
  UsePaginateBounds   Gets a value that indicates whether PaginateBounds should be used or not.
  ------------------- ---------------------------------------------------------------------------------------------------
:::

 

Color Spaces

 

Images retain their original color space. The supported color spaces are as follows.

 

[·      ]{style="FONT-FAMILY: Symbol"}**RGB** - Images with 24-bit color space

[·      ]{style="FONT-FAMILY: Symbol"}**CMYK** - Images with 48-bit color space

[·      ]{style="FONT-FAMILY: Symbol"}**Grayscale** - Images with 8-bit color space

[·      ]{style="FONT-FAMILY: Symbol"}**Indexed** - Images with 8-bit indexed color space

 

Transparency

 

Transparency of PdfBitmap images are provided by the abstract PdfMask base class.

 

PdfImageMask

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Using grayscale or monochrome images in PdfImageMask enables to create transparent images depending on the pixel format.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Soft Mask

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A soft mask specifies a transparency level for each pixel of the image. You can create these masks from a grayscale image. The level of gray indicates the level of transparency.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Hard Mask

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A hard mask classifies pixels based on their transparency. You can create these masks from a monochrome image.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: Image masks should be of the same width and height as the base image.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PdfColorMask

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This mask enables masking colors (making them transparent) by specifying the range of colors. All colors that exist between the start color and the end color will be transparent.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: According to PDF References, it is recommended not to use JPEG images with color key masking.
:::

 

 

 

[]{#related-topics}
:::::::
