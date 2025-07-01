::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=401bbf00-368e-4c94-9d34-f27b40127d01){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c0508cb3-03fd-4aea-b826-e8dabdb20065){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Editing](ms-xhelp:///?Id=acdc025e-645c-4f53-ab6c-d726bbf3e589){.d2h_breadcrumbsNormal}
:::

### Import Pages {#import-pages style="tab-stops: 0pt"}

 

Pages from other document can be imported to the existing document using the **ImportPage** method. The following code example illustrates this method.

 

+--------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                   |
|                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                             |
|                                                                                                  |
| [doc.ImportPage(ldDoc, page);]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                  |
| [doc.ImportPage(ldDoc, pageIndex);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                  |
| [doc.ImportPageRange(ldDoc, startPageIndex, endPageIndex); ]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                             |
|                                                                                                                                  |
| [doc.ImportPage(ldDoc, page)]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                  |
| [doc.ImportPage(ldDoc, pageIndex)]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                  |
| [doc.ImportPageRange(ldDoc, startPageIndex, endPageIndex)]{style="FONT-FAMILY: 'Courier New'"}                                   |
+----------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image22_2.jpg){border="0"}Note: The first two methods in the above code are just shortcuts to the last one, which is a powerful tool appending not just pages, but annotations and forms as well.
:::

 

The parameters included are as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ldDoc**: Loaded PDF document

[·      ]{style="FONT-FAMILY: Symbol"}**Page**: Page that should be appended (not a page itself, but its valid representation)

[·      ]{style="FONT-FAMILY: Symbol"}**PageIndex**: Index of the page

[·      ]{style="FONT-FAMILY: Symbol"}**StartPageIndex, endPageIndex**: Indices specifying the page range

 

The following code snippets illustrate how to import a page to the existing document.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                 |
|                                                                                                                                                                                                      |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}( filename ); ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                      |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ startIndex = 0; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                      |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ endIndex = ldDoc.Pages.Count - 1; ]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                      |
| [newDoc.ImportPageRange( ldDoc, startIndex, endIndex ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                      |
| [newDoc.Save( newFilename ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                      |
| [newDoc.Close(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                      |
| [ldDoc.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                        |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                    |
|                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(filename)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ startIndex [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ endIndex [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = ldDoc.Pages.Count - 1]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                         |
| [NewDoc.ImportPageRange(ldDoc, startIndex, endIndex) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                         |
| [NewDoc.Save(NewFilename) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                         |
| [NewDoc.Close() ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                         |
| [ldDoc.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Implementation Note

 

The importing is done by converting the page content to the PdfTemplate object, which means that the new page will not inherit the possibly complex layer structure, so you will see just one default layer. Obviously, you will be able to place something beneath that layer. However you will not be able to manipulate the \"old\" layers, because they won\'t exist.

 

This conversion is performed in order to avoid an incomplete page, harming further user output.

 

Restrictions

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}All pages are appended to the host document to make easier bookmarks (outlines) merging. Bookmarks are organized as a complex tree, as it is hard to calculate where the new items should be placed.

[·      ]{style="FONT-FAMILY: Symbol"}Outlines (Bookmarks) will be copied to the target document along with the pages. The library will try to rebuild the bookmark tree with those bookmarks that have the destination pointing to any of the imported pages.

[·      ]{style="FONT-FAMILY: Symbol"}The outline tree might look a bit weird if just part of it was copied, as it is hard to recreate the tree with part of the bookmarks.

[·      ]{style="FONT-FAMILY: Symbol"}Some of the contents are usually imported from the original document to the final document during saving process. Hence, the original document has to be closed only after the final document is saved.

 

 

 

[]{#related-topics}
:::::
