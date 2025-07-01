::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding a New Page {#adding-a-new-page style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A new page can be created in the existing pdf document or an existing page can be removed from the pdf document. This section discusses the following:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Creating a page

2.   Removing a page

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Creating a page

 

To add a new page to a PDF document that was created by an anonymous user, do the following:

 

1.   Pass the path of that particular document to the **PdfLoadedDocument** constructor

2.   Call the **doc.Pages.Add** method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This will create an empty page with the default parameters.

 

![](ImagesExt/image22_0.jpg){border="0"} You can also specify the size and margins for the new page.

 

The following code snippet illustrates how to create a new page in the pdf document.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                             |
|                                                                                                                                                                                                  |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ lDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                  |
| [page = lDoc.Pages.Add() [as]{style="COLOR: blue"} [PdfPage]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [g = page.Graphics;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                  |
| [text = [\"Page 2\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                  |
| [g.DrawString(text, font, PdfBrushes.Black, [PointF]{style="COLOR: teal"}.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [filename = OutputPath + [\"AddNewPages.pdf\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                  |
| [lDoc.Save(filename);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                  |
| [lDoc.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                   |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                               |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lDoc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedDocument(filename)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [page = [TryCast]{style="COLOR: blue"}(lDoc.Pages.Add(), PdfPage) ]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| [g = page.Graphics ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                    |
| [text = [\"Page 2\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                    |
| [g.DrawString(text, font, PdfBrushes.Black, PointF.Empty) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| [filename = OutputPath + [\"AddNewPages.pdf\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                    |
| [lDoc.Save(filename) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                    |
| [lDoc.Close() ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image22_2.jpg){border="0"}Note: You can use the page\'s Graphics, but should not use the graphics objects that require the page to layout.
:::

 

A new page is added to the pdf document.

 

Removing a page

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can also remove pages from the existing PDF document by using the following methods of the **PdfLoadedPageCollection** class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Remove

[·      ]{style="FONT-FAMILY: Symbol"}RemoveAt

 

The following code snippet illustrates how to remove an existing page from the pdf document.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                               |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}([\"Sample.pdf\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [// Removes the page by passing the PDF page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                                                |
| [doc.Pages.Remove(doc.Pages\[1\]);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [// Removes the page by specifying the page index]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                                                |
| [doc.Pages.RemoveAt(2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(\"Sample.pdf\")]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                             |
| [\' Removes the page by passing the PDF page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                             |
| [doc.Pages.Remove(doc.Pages(1))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                             |
| [\' Removes the page by specifying the page index]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                                             |
| [doc.Pages.RemoveAt(2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
::::
