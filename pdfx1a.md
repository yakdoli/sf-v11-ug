::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### PDF/X-1a {#pdfx-1a style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PDF/X is a subset of the Adobe Portable Document Format (PDF) specification, which exhibits best practices in graphic arts file exchange. PDF/X-1a restricts the content in a PDF document that does not directly serve the purpose of high-quality print production output, such as annotations, Java Actions, and embedded multimedia.

 

PDF/X-1a also eliminates the most common errors in file preparation. Sending the document as a PDF/X-1a file, will guarantee that font errors do not occur. This is because a file declared as complying with the PDF/X-1a standard meets the following requirements:

 

[·      ]{style="FONT-FAMILY: Symbol"}All fonts and images must be embedded

[·      ]{style="FONT-FAMILY: Symbol"}All elements must be encoded as CMYK

 

In addition,

 

[·      ]{style="FONT-FAMILY: Symbol"}MediaBox and TrimBox or ArtBox must be defined; BleedBox is optional

[·      ]{style="FONT-FAMILY: Symbol"}The output intent must be specified either by stating a Characterized Printing Condition or identifying an ICC output profile

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Advantages of PDF/X-1a

 

By using a PDF/X-1a workflow,

 

[·      ]{style="FONT-FAMILY: Symbol"}Print-ready files will reproduce as you intended.

[·      ]{style="FONT-FAMILY: Symbol"}You will save time and money.

[·      ]{style="FONT-FAMILY: Symbol"}Reduces additional time and money

 

The following code snippet illustrates how to create a pdf document complying the above standard.

 

+----------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                   |
|                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                             |
|                                                                                                                                  |
| [//Create the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                       |
|                                                                                                                                  |
| [PdfDocument doc = [new]{style="COLOR: blue"} PdfDocument(PdfConformanceLevel.Pdf_X1A2001);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                  |
| [//Set the color space. Should be CMYK.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                       |
|                                                                                                                                  |
| [doc.ColorSpace = PdfColorSpace.CMYK;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                  |
| [//Save and close the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                               |
|                                                                                                                                  |
| [doc.Save([\"sample.pdf\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                         |
+----------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                               |
|                                                                                                                                                                                                    |
| [\'Create the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfDocument(PdfConformanceLevel.Pdf_X1A2001)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                    |
| [\'Set the color space. Should be CMYK.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                         |
|                                                                                                                                                                                                    |
| [doc.ColorSpace = PdfColorSpace.CMYK]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                    |
| [\'Save and close the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                    |
| [doc.Save([\"sample.pdf\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
