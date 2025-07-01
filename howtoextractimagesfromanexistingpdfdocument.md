::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7182aa8f-6cb1-4a11-9f0f-5569669219d2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=25792921-bcb8-4949-bc0c-10c4ff8f7848){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=ca78a5c9-c63a-4368-878c-fa18338e0b19){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Convertor](ms-xhelp:///?Id=395e5d31-8695-49b6-bef4-c3600d030283){.d2h_breadcrumbsNormal}
:::

### How To Extract Images From an Existing PDF Document? {#how-to-extract-images-from-an-existing-pdf-document style="tab-stops: 0pt"}

 

You can extract images from an existing PDF document page by page, using the **ExtractImages** method of the **PdfLoadedPage** class.

The following code example illustrates how to extract images from a document.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Load an existing PDF]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                               |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}([\"Sample.pdf\"]{style="COLOR: #993300"});]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [// Loading Page collections]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                                               |
| [PdfLoadedPageCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ loadedPages = ldoc.Pages;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [// Extract Image from PDF document pages]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                  |
|                                                                                                                                                                                                                                               |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([PdfLoadedPage]{style="COLOR: teal"} lpage [in]{style="COLOR: blue"} loadedPages)]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| [  [Image]{style="COLOR: teal"}\[\] img = lpage.ExtractImages();                   ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                               |
| [  [foreach]{style="COLOR: blue"} ([Image]{style="COLOR: teal"} img1 [in]{style="COLOR: blue"} img)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                                               |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                               |
| [     img1.Save([\"Image\"]{style="COLOR: maroon"} + [Guid]{style="COLOR: teal"}.NewGuid().ToString() + [\".png\"]{style="COLOR: maroon"}, [ImageFormat]{style="COLOR: teal"}.Png);                     ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                               |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                           |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [\' Load an existing PDF]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(\"Sample.pdf\")]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [\' Loading Page collections]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ loadedPages [As]{style="COLOR: blue"} PdfLoadedPageCollection = ldoc.Pages]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [\' Extract Image from PDF document pages]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                              |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} lpage [As]{style="COLOR: blue"} PdfLoadedPage [In]{style="COLOR: blue"} loadedPages]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| [  [Dim]{style="COLOR: blue"} img [As]{style="COLOR: blue"} Image() = lpage.ExtractImages()]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                              |
| [  [For]{style="COLOR: blue"} [Each]{style="COLOR: blue"} img1 [As]{style="COLOR: blue"} Image [In]{style="COLOR: blue"} img]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                              |
| [       img1.Save(\"Image\" & Guid.NewGuid().ToString() & \".png\", ImageFormat.Png)]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                              |
| [  [Next]{style="COLOR: blue"} img1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                              |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lpage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p140} 

[]{#related-topics}
::::
