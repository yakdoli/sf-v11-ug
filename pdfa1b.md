::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### PDF/A-1b {#pdfa-1b style="tab-stops: 0pt"}

 

PDF/A

 

The PDF/A formats specified in the ISO 19005 standards, strive to provide a mechanism for representing electronic documents. These documents are represented in a manner that preserves their visual appearance over time, independent of the tools and systems used for creating, storing or rendering the files. A key element to this reproducibility is the requirement for PDF/A documents to be 100 percent self-contained.

 

All of the information necessary for displaying the document in the same manner every time is embedded in the file. This includes all visible content like text, raster images, vector graphics, fonts, color information and much more. The standard is based on PDF 1.4, and imposes some restrictions regarding the use of color, fonts, annotations, and other elements.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There are two flavors of PDF/A-1:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ISO 19005-1 Level B conformance (PDF/A-1b)** ensures that the visual appearance of a document is preservable over the long term. PDF/A-1b ensures that the document will look the same, when it is processed sometime in the future.

[·      ]{style="FONT-FAMILY: Symbol"}**ISO 19005-1 Level A conformance (PDF/A-1a)**: It is based on level B, but adds crucial properties from »Tagged PDF« It requires structure information and reliable text semantics in order to preserve the document\'s logical structure and natural reading order. PDF/A-1a not only ensures that the document will look the same when it is used in the future, but also ensures that its contents can be reliably interpreted and accessed by physically impaired users.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image22_2.jpg){border="0"}Note: PDF/A-1a and PDF/A-1b differ primarily with respect to text extraction.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PDF/A-1b

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Creating PDF/A-1b document is very simple. You must set PdfConformanceLevel to ***PdfA1B*** while creating an instance to the PDF document. PDF/A standard imposes some restrictions regarding the usage of color, fonts, annotations, and other elements. These restrictions are listed as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}The use of JavaScript is forbidden

[·      ]{style="FONT-FAMILY: Symbol"}Attaching any file to PDF document is forbidden

[·      ]{style="FONT-FAMILY: Symbol"}Hyperlink to a Non-PDF file is forbidden

[·      ]{style="FONT-FAMILY: Symbol"}Security features are forbidden

[·      ]{style="FONT-FAMILY: Symbol"}The use of Form Fields are forbidden

[·      ]{style="FONT-FAMILY: Symbol"}Text Containing HTML Tags is forbidden

[·      ]{style="FONT-FAMILY: Symbol"}Supports the use of TrueType fonts only; Does not support Type1 font

[·      ]{style="FONT-FAMILY: Symbol"}Supports the use of RGB color; Does not support CMYK color

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Validating PDF/A1-b

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Adobe Acrobat Preflight tool is used to verify the compliance of a PDF document with the PDF/A standard.

 

You can verify the compliance of a PDF file by using the Preflight tool. Using the menu options select Advanced -\> Preflight -\> PDF/A compliance -\> Verify compliance with PDF/A-1b.

 

The following code example illustrates how to create PDF/A-1b compliant output.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [//Create a new document with PDF/A standard.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                       |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [PdfDocument]{style="COLOR: teal"}([PdfConformanceLevel]{style="COLOR: teal"}.Pdf_A1B);]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                       |
| [//Add a page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                       |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = doc.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                       |
| [//Create Pdf graphics for the page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [PdfGraphics]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ g = page.Graphics;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                       |
| [//Create a solid brush]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                       |
| [PdfBrush]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ brush = [new]{style="COLOR: blue"} [PdfSolidBrush]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Black);]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                                       |
| [float]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fontSize = 20f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                       |
| [Font]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ f = [new]{style="COLOR: blue"} [Font]{style="COLOR: teal"}([\"Helvetica\"]{style="COLOR: maroon"}, fontSize, [FontStyle]{style="COLOR: teal"}.Regular);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                       |
| [//Set the font]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                       |
| [PdfFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfTrueTypeFont]{style="COLOR: teal"}(f, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                       |
| [//Draw the text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                       |
| [g.DrawString([\"Hello world!\"]{style="COLOR: maroon"}, font, brush, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(20, 20));]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                       |
| [doc.Save([\"Sample.pdf\");]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [\'Create a new document with PDF/A standard.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} PdfDocument = [New]{style="COLOR: blue"} PdfDocument(PdfConformanceLevel.Pdf_A1B)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [\'Add a page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = doc.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [\'Create Pdf graphics for the page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ g [As]{style="COLOR: blue"} PdfGraphics = page.Graphics]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [\'Create a solid brush]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                       |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ brush [As]{style="COLOR: blue"} PdfBrush = [New]{style="COLOR: blue"} PdfSolidBrush(Color.Black)]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fontSize [As]{style="COLOR: blue"} [Single]{style="COLOR: blue"} = 20f]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ f [As]{style="COLOR: blue"} Font = [New]{style="COLOR: blue"} Font(\"Helvetica\", fontSize, FontStyle.Regular)]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [\'Set the font]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfFont = [New]{style="COLOR: blue"} PdfTrueTypeFont(f, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [\'Draw the text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                  |
| [g.DrawString(\"Hello world!\", font, brush, [New]{style="COLOR: blue"} PointF(20, 20))]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                  |
| [doc.Save(\"Sample.pdf\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
::::
