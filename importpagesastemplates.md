::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Import Pages As Templates {#import-pages-as-templates style="tab-stops: 0pt"}

 

You can create a booklet or just place few pages onto a single one by converting the pages into a PdfTemplate object. This template can be scaled, rotated, placed at different coordinates, and so on. It enables you to customize the page representation as per your need.

 

The following code example illustrates how to import a page as a template.

 

+-----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                        |
|                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                         |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = doc1.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                         |
| [PdfGraphics]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ g = page.Graphics;]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                         |
| [PdfPageBase]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ lpage = doc2.Pages\[0\];]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                         |
| [PdfTemplate]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ template = lpage.CreateTemplate();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                         |
| [g.DrawPdfTemplate(template, [PointF]{style="COLOR: teal"}.Empty, page.GetClientSize());]{style="FONT-FAMILY: 'Courier New'"}           |
+-----------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument([\"../../Data/sample.pdf\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = doc1.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ g [As]{style="COLOR: blue"} PdfGraphics = page.Graphics]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lpage [As]{style="COLOR: blue"} PdfPageBase = doc2.Pages(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ template [As]{style="COLOR: blue"} PdfTemplate = lpage.CreateTemplate()]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                 |
| [g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
