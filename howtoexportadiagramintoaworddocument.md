::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=eae21f58-4d7c-4b8f-a2ff-d8fd8c499fcc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=fa8f4616-7800-446b-a2dd-5f69626422a1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How To Export a Diagram Into a Word Document {#how-to-export-a-diagram-into-a-word-document style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To export a diagram into a Word document, follow the below given steps.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Save the diagram in any one of the standard image formats such as bitmaps, enhanced metafiles, SVG format files, and so forth.

 

2.   Export the saved images to the Word document using Essential DocIO.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image87_1.jpg){border="0"}Note: To export the saved images to the Word document, you need to have Essential DocIO installed in your system.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [System.Drawing.[Image]{style="COLOR: teal"} diagramimage = [new]{style="COLOR: blue"} [Bitmap]{style="COLOR: teal"}(1, 1, PixelFormat.Format24bppRgb);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [Graphics]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ grfx = [Graphics]{style="COLOR: teal"}.FromImage(diagramimage);]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                              |
| [IntPtr]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ hdc = grfx.GetHdc();]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                              |
| [Metafile emf = [new]{style="COLOR: blue"} Metafile(hdc, EmfType.EmfOnly);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                              |
| [Graphics]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ emfgrfx = [Graphics]{style="COLOR: teal"}.FromImage(emf); ]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram1.View.ExportDiagramToGraphics(emfgrfx,[true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                              |
| [grfx.ReleaseHdc(hdc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                              |
| [grfx.Dispose();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                              |
| [emfgrfx.Dispose();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                              |
| [diagramimage.Dispose();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                              |
| [WordDocument document = [new]{style="COLOR: blue"} WordDocument();]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [//Adding a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                              |
| [IWSection section = document.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [//Adding a paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                              |
| [IWParagraph paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                              |
| [WPicture mImage = (WPicture)paragraph.AppendPicture(emf);]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                              |
| [document.Save([\"Sample.doc\"]{style="COLOR: maroon"}, Syncfusion.DocIO.FormatType.Doc); ]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                              |
| [System.Diagnostics.[Process]{style="COLOR: teal"}.Start([\"Sample.doc\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                             |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramimage [As]{style="COLOR: blue"} System.Drawing.Image = [New]{style="COLOR: blue"} Bitmap(1, 1, PixelFormat.Format24bppRgb)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ grfx [As]{style="COLOR: blue"} Graphics = Graphics.FromImage(diagramimage)]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ hdc [As]{style="COLOR: blue"} IntPtr = grfx.GetHdc()]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ emf [As]{style="COLOR: blue"} Metafile = [New]{style="COLOR: blue"} Metafile(hdc, EmfType.EmfOnly)]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ emfgrfx [As]{style="COLOR: blue"} Graphics = Graphics.FromImage(emf)]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram1.View.ExportDiagramToGraphics(emfgrfx,[True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                |
| [grfx.ReleaseHdc(hdc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| [grfx.Dispose()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [emfgrfx.Dispose()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                |
| [diagramimage.Dispose()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} WordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [\'Adding a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} IWSection = document.AddSection()]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [\'Adding a paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                       |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paragraph [As]{style="COLOR: blue"} IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ mImage [As]{style="COLOR: blue"} WPicture = [CType]{style="COLOR: blue"}(paragraph.AppendPicture(emf), WPicture)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                                |
| [document.Save([\"Sample.doc\"]{style="COLOR: maroon"}, Syncfusion.DocIO.FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                |
| [System.Diagnostics.Process.Start([\"Sample.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p84} 

 

[]{#related-topics}
:::::
