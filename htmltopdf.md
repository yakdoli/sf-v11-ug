::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2b6a7d69-810d-44e0-aca8-fc3a5e75a9da){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=de808365-7990-4374-b1dc-4e29044baeb6){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Convertor](ms-xhelp:///?Id=2b6a7d69-810d-44e0-aca8-fc3a5e75a9da){.d2h_breadcrumbsNormal}
:::

### HTML To PDF {#html-to-pdf style="tab-stops: 0pt"}

 

WebPages and HTML pages can be imported to PDF using the *HtmlConverter*. The HTMLConverter converts the HTML web page to a *Bitmap* or *Metafile* image using *MSHTML*.

 

![](ImagesExt/image22_0.jpg){border="0"} MSHTML is a rendering library that is used to render HTML documents. The MSHTML library is like an engine that is used to drive the Internet Explorer.

 

Essential PDF renders the converted image into the PDF. You can convert a web page to PDF, either as Bitmap or Metafile types.

 

[·      ]{style="FONT-FAMILY: Symbol"}Rendering web pages as Bitmap provides reasonable performance

[·      ]{style="FONT-FAMILY: Symbol"}Rendering web pages as Metafile provides high resolution

 

This section covers the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Converting Methods

[·      ]{style="FONT-FAMILY: Symbol"}HTMLConvertor Options

 

Converting Methods

 

HTML documents can be converted to PDF through the following methods:

 

[·      ]{style="FONT-FAMILY: Symbol"}ConvertToImage

[·      ]{style="FONT-FAMILY: Symbol"}FromString

[]{style="COLOR: #15428b"} 

1\. ConvertToImage

 

The *ConvertToImage* method converts the URL into an image. It recognizes tables, images, lists, and so on. The URL parameter can be a HTTP or HTTPS address such as \"http://www.server.com/path/file.html\", or a local physical path such as \"c:\\path\\file.html\".

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: If you want to open a dynamically generated document such as .asp or aspx file, you need to invoke it through HTTP even if this file is local to your own script.
:::

[]{style="COLOR: #15428b"} 

The overloaded **ConvertToImage** method enables to convert a HTML page to an image with *AspectRatio*, to maintain the ratio of the image dimension. This prevents text truncation at the corners.

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                    |
|                                                                                                                                                                                               |
| []{style="COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                               |
| [Image]{style="COLOR: teal"} img = html.ConvertToImage([\"http://www.google.com\"]{style="COLOR: maroon"}, ImageType.Metafile, ([int]{style="COLOR: blue"})width, -1, AspectRatio.KeepWidth); |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                                                                                                                                              |
|                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                             |
| [Dim]{style="COLOR: blue"} img [As]{style="COLOR: blue"} Image = html.ConvertToImage([\"http://www.google.com\"]{style="COLOR: maroon"}, ImageType.Metafile, [CInt]{style="COLOR: blue"}(width), -1, AspectRatio.KeepWidth) |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #15428b"}** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: HTML To PDF conversion allows text selection and search within the generated document. However, in machines where IE9 is installed, the document would contain Bitmap image of the converted page / file there by restricting text selection and search. But this behavior can be changed for certain webpages by changing the registry value. For more details, refer the [[Frequently Asked Questions section]{.UGHyperlink}](ms-xhelp:///?Id=e2e8498d-8840-46fe-bd89-31be1be37514)[.]{.UGHyperlink}
:::

**[]{style="COLOR: #15428b"}** 

Authentication

[]{style="COLOR: #15428b"} 

You can use the *ConvertToImage* method to access the authenticated web pages, by passing its user credential values as arguments. The following code example illustrates this:

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| [Image]{style="COLOR: teal"} img = html.ConvertToImage([\"http://www.google.com\"]{style="COLOR: maroon"}, ImageType.Metafile, ([int]{style="COLOR: blue"})width, -1, AspectRatio.KeepWidth,\"UserName\", \"Password\"); |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                         |
| [Dim]{style="COLOR: blue"} img [As]{style="COLOR: blue"} Image = html.ConvertToImage([\"http://www.google.com\"]{style="COLOR: maroon"}, ImageType.Metafile, [CInt]{style="COLOR: blue"}(width), -1, AspectRatio.KeepWidth, \"UserName\", \"Password\") |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

2\. FromString

 

*FromString* method renders HTML from the string to the image. The following code example illustrates this:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                            |
| [public]{style="COLOR: blue"} [Image]{style="COLOR: teal"} FromString( [string]{style="COLOR: blue"} html, ImageType type );                                                                                               |
|                                                                                                                                                                                                                            |
| [public]{style="COLOR: blue"} [Image]{style="COLOR: teal"} FromString( [string]{style="COLOR: blue"} html, ImageType type, [int]{style="COLOR: blue"} width );                                                             |
|                                                                                                                                                                                                                            |
| [public]{style="COLOR: blue"} [Image]{style="COLOR: teal"} FromString( [string]{style="COLOR: blue"} html, ImageType type, [int]{style="COLOR: blue"} width, [int]{style="COLOR: blue"} height );                          |
|                                                                                                                                                                                                                            |
| [public]{style="COLOR: blue"} [Image]{style="COLOR: teal"} FromString( [string]{style="COLOR: blue"} html, ImageType type, [int]{style="COLOR: blue"} width, [int]{style="COLOR: blue"} height, AspectRatio aspectRatio ); |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="COLOR: black"}**                                                                                                                                                                   |
|                                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                                 |
|                                                                                                                                                                                                          |
| [Public]{style="COLOR: blue"} Image FromString([String]{style="COLOR: blue"} html, ImageType type)                                                                                                       |
|                                                                                                                                                                                                          |
| [Public]{style="COLOR: blue"} Image FromString([String]{style="COLOR: blue"} html, ImageType type, [Integer]{style="COLOR: blue"} width)                                                                 |
|                                                                                                                                                                                                          |
| [Public]{style="COLOR: blue"} Image FromString([String]{style="COLOR: blue"} html, ImageType type, [Integer]{style="COLOR: blue"} width, [Integer]{style="COLOR: blue"} height)                          |
|                                                                                                                                                                                                          |
| [Public]{style="COLOR: blue"} Image FromString([String]{style="COLOR: blue"} html, ImageType type, [Integer]{style="COLOR: blue"} width, [Integer]{style="COLOR: blue"} height, AspectRatio aspectRatio) |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Sample code:

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| [//initialze the html converter]{style="COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [HtmlConverter]{style="COLOR: #2b91af"} converter = [new]{style="COLOR: blue"} [HtmlConverter]{style="COLOR: #2b91af"}();                                                                                      |
|                                                                                                                                                                                                                |
| [//convert html to pdf]{style="COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                |
| [Image]{style="COLOR: #2b91af"} result  = converter.FromString(html, [ImageType]{style="COLOR: #2b91af"}.Metafile, ([int]{style="COLOR: blue"})imgWidth, -1, [AspectRatio]{style="COLOR: #2b91af"}.KeepWidth); |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
| [//Render the image in the Pdf document]{style="COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                |
| [PdfImage]{style="COLOR: #2b91af"} pdfImage=[PdfImage]{style="COLOR: #2b91af"}.FromImage(result);                                                                                                              |
|                                                                                                                                                                                                                |
| pdfImage.Draw(pdfPage,[PointF]{style="COLOR: #2b91af"}.Empty,format);                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
| [\'Initialize the HTML Converter]{style="COLOR: green"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                      |
|  [Dim]{style="COLOR: blue"} converter [As New]{style="COLOR: blue"} HtmlConverter                                                                                                                                                    |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
| [\'Convert the HTML file to Image]{style="COLOR: green"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                      |
| [Dim]{style="COLOR: blue"} result [As]{style="COLOR: blue"} Image = converter.FromString(htmlFilePath, ImageType.Metafile,        [CType]{style="COLOR: blue"}(imgWidth, [Integer]{style="COLOR: blue"}), -1, AspectRatio.KeepWidth) |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
| [\'Render the image in the Pdf document]{style="COLOR: green"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                      |
| [Dim]{style="COLOR: blue"} pdfImage [As]{style="COLOR: blue"} PdfImage = pdfImage.FromImage(result)[]{style="COLOR: green"}                                                                                                          |
|                                                                                                                                                                                                                                      |
| pdfImage.Draw(pdfPage, PointF.Empty, format)                                                                                                                                                                                         |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: Both ConvertToImage() and FromString() methods are used to convert the HTML pages whose height is less than 32767 pixels as image and the options like  EnableHyperlinks, EnableJavascript  and AutoDetectPageBreak has no effect.
:::

 

[]{style="COLOR: #15428b"} 

![](ImagesExt/image22_74.jpg){border="0"}

*Figure* *63: HTML to PDF Conversion Through FromString Method*

[]{style="COLOR: #15428b"} 

HtmlConverter Options

 

HtmlConverter provides the following options to control HtmlToPDF conversions.

 

[·      ]{style="FONT-FAMILY: Symbol"}EnableJavaScript

[·      ]{style="FONT-FAMILY: Symbol"}AutoDetectPageBreak

[·      ]{style="FONT-FAMILY: Symbol"}Enable Hyperlinks

[]{style="COLOR: #15428b"} 

EnableJavaScript

 

You can control the JavaScript by using the *EnableJavaScript* property of the HtmlConverter class library. By default this property are set to *False.* So the JavaScript code is disabled during conversion. Set[ ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}the *EnableJavaScript* property to True to activate the JavaScript code during conversion.

 

The following code example illustrates this:

 

+----------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                     |
|                                                                                                                |
|                                                                                                                |
|                                                                                                                |
| [HtmlConverter]{style="COLOR: teal"} html = [new]{style="COLOR: blue"} [HtmlConverter]{style="COLOR: teal"}(); |
|                                                                                                                |
| []{style="COLOR: green"}                                                                                       |
|                                                                                                                |
| [//Activating JavaScript]{style="COLOR: green"}                                                                |
|                                                                                                                |
| html.EnableJavaScript = [true]{style="COLOR: blue"};                                                           |
+----------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c"} 

+----------------------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                                       |
|                                                                                                                      |
|                                                                                                                      |
|                                                                                                                      |
| [Dim]{style="COLOR: blue"} html [As]{style="COLOR: blue"} HtmlConverter = [New]{style="COLOR: blue"} HtmlConverter() |
|                                                                                                                      |
| []{style="COLOR: green"}                                                                                             |
|                                                                                                                      |
| [\'Activating JavaScript]{style="COLOR: green"}                                                                      |
|                                                                                                                      |
| html.EnableJavaScript = [True]{style="COLOR: blue"}                                                                  |
+----------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: If JavaScript code is not executed by setting the EnableJavaScript property, it means the Internet Security Settings on the server does not allow the JavaScript execution.
:::

[]{style="COLOR: #15428b"} 

Enable Hyperlink

 

Essential PDF supports enabling/ disabling live hyperlinks in PDF while converting web pages to PDF. The following code example illustrates this:

 

+-----------------------------------------------------------------------+
| **\[C#\]**                                                            |
|                                                                       |
| []{style="COLOR: green"}                                              |
|                                                                       |
| HtmlConverter html = [new]{style="COLOR: blue"} HtmlConverter();      |
|                                                                       |
| []{style="COLOR: green"}                                              |
|                                                                       |
| [// Enabling Hyperlink]{style="COLOR: green"}                         |
|                                                                       |
| html.EnableHyperlinks = [true]{style="COLOR: blue"};                  |
+-----------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                       |
|                                                                                                      |
|                                                                                                      |
|                                                                                                      |
| [Dim]{style="COLOR: blue"} html [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} HtmlConverter() |
|                                                                                                      |
| []{style="COLOR: green"}                                                                             |
|                                                                                                      |
| [\'Enabling Hyperlink]{style="COLOR: green"}                                                         |
|                                                                                                      |
| html.EnableHyperlinks = [True]{style="COLOR: blue"}                                                  |
+------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #15428b"}** 

AutoDetectPageBreak

[]{style="COLOR: #15428b"} 

The *HtmlConverter* supports custom page breaks with standard CSS styles like *page-break-before:always* and *page-break-after:always* that can be applied to any HTML object. You can enable custom page breaks by setting the *AutoDetectPageBreak* property to *True*.

 

The following code example illustrates this:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                                 |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [HtmlConverter]{style="COLOR: teal"} html = [new]{style="COLOR: blue"} [HtmlConverter]{style="COLOR: teal"}();                                                                                             |
|                                                                                                                                                                                                            |
| []{style="COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                            |
| [// Activate the Page Break]{style="COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                            |
| html.AutoDetectPageBreak = [true]{style="COLOR: blue"};                                                                                                                                                    |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [// Convert the Html file as an image]{style="COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                            |
| [HtmlToPdfResult]{style="COLOR: teal"} result = html.Convert(txtUrl.Text, [ImageType]{style="COLOR: teal"}.Metafile, ([int]{style="COLOR: blue"})width, -1, [AspectRatio]{style="COLOR: teal"}.KeepWidth); |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [// Specify the quality of the metafile]{style="COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                            |
| [PdfMetafile]{style="COLOR: teal"} mf = new [PdfMetafile]{style="COLOR: teal"}(result.RenderedImage as [Metafile]{style="COLOR: teal"});                                                                   |
|                                                                                                                                                                                                            |
| mf.Quality = 100;                                                                                                                                                                                          |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [PdfMetafileLayoutFormat]{style="COLOR: teal"} format = [new]{style="COLOR: blue"} [PdfMetafileLayoutFormat]{style="COLOR: teal"}();                                                                       |
|                                                                                                                                                                                                            |
| format.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitPage;                                                                                                                                          |
|                                                                                                                                                                                                            |
| format.Layout = [PdfLayoutType]{style="COLOR: teal"}.Paginate;                                                                                                                                             |
|                                                                                                                                                                                                            |
| []{style="COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                            |
| [//Render the image in PDF document]{style="COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                            |
| mf.Draw(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: #2b91af"}(0, 0), format);                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                                                                                                                  |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [Dim]{style="COLOR: blue"} html [As]{style="COLOR: blue"} HtmlConverter = [New]{style="COLOR: blue"} HtmlConverter()                                                                            |
|                                                                                                                                                                                                 |
| []{style="COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                 |
| [\' Activate the Page Break]{style="COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                 |
| html.AutoDetectPageBreak = [True]{style="COLOR: blue"}                                                                                                                                          |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [\' Convert the Html file as an image]{style="COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                 |
| [Dim]{style="COLOR: blue"} result [As]{style="COLOR: blue"} HtmlToPdfResult = html.Convert(txtUrl.Text, ImageType.Metafile, [CInt]{style="COLOR: blue"}(Fix(width)), -1, AspectRatio.KeepWidth) |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [\' Specify the quality of the metafile]{style="COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                 |
| [Dim]{style="COLOR: blue"} mf [As ]{style="COLOR: blue"}PdfMetafile = [New]{style="COLOR: blue"} PdfMetafile([TryCast]{style="COLOR: blue"}(result.RenderedImage, Metafile))                    |
|                                                                                                                                                                                                 |
| mf.Quality = 100                                                                                                                                                                                |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [Dim]{style="COLOR: blue"} format [As]{style="COLOR: blue"} PdfMetafileLayoutFormat = [New]{style="COLOR: blue"} PdfMetafileLayoutFormat()                                                      |
|                                                                                                                                                                                                 |
| format.Break = PdfLayoutBreakType.FitPage                                                                                                                                                       |
|                                                                                                                                                                                                 |
| format.Layout = PdfLayoutType.Paginate                                                                                                                                                          |
|                                                                                                                                                                                                 |
| []{style="COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                 |
| [\' Render the image in PDF document]{style="COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                 |
| mf.Draw(page, [New]{style="COLOR: blue"} PointF(0, 0), format)                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[]{style="LAYOUT-GRID-MODE: line"}*** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note:[ ]{style="COLOR: black"}The custom page breaks is supported only when converting MetaFile to PDF. They are not supported when converting Bitmap to PDF.
:::

**[]{style="COLOR: #15428b"}** 

Rendering HTML page without Splitting

 

To avoid the images and text split across the page breaks, while rendering a large meta file with images and text in a PDF document, disable the *SplitTextLines* and *SplitImages* properties of the *PdfMetafileLayoutFormat* class. The following code illustrates this:

 

+--------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                           |
|                                                                                                                                      |
| []{style="COLOR: green"}                                                                                                             |
|                                                                                                                                      |
| [PdfMetafileLayoutFormat]{style="COLOR: teal"} format = [new]{style="COLOR: blue"} [PdfMetafileLayoutFormat]{style="COLOR: teal"}(); |
|                                                                                                                                      |
| format.SplitTextLines = [false]{style="COLOR: blue"};                                                                                |
|                                                                                                                                      |
| format.SplitImages = [false]{style="COLOR: blue"};                                                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                                                   |
|                                                                                                                  |
|                                                                                                                  |
|                                                                                                                  |
| [Dim]{style="COLOR: blue"} format [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfMetafileLayoutFormat() |
|                                                                                                                  |
| format.SplitTextLines = [False]{style="COLOR: blue"}                                                             |
|                                                                                                                  |
| format.SplitImages = [False]{style="COLOR: blue"}                                                                |
+------------------------------------------------------------------------------------------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}HTML to PDF Conversion using Gecko Rendering Engine](ms-xhelp:///?Id=5f0fd759-321f-4580-9341-f9938713f7f9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Tagged PDF](ms-xhelp:///?Id=87e57024-c582-41a7-8814-42b95097fdbc){style="TEXT-DECORATION: none"}
:::::::::
