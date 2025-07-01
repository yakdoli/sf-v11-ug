::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=acdc025e-645c-4f53-ab6c-d726bbf3e589){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1a9325c8-ac83-4671-8a7a-9795567a7a0a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Editing](ms-xhelp:///?Id=acdc025e-645c-4f53-ab6c-d726bbf3e589){.d2h_breadcrumbsNormal}
:::

### Load Document {#load-document style="tab-stops: 0pt"}

[]{#p81} 

An existing PDF document can be loaded and customized. To open an existing PDF document for further manipulations, use the **PdfLoadedDocument** class. Its constructor allows you to specify the file name, stream or byte array as the source of the document data and the password for the encrypted documents.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                 |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename);]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(memoryStream);]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(byte);]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename,password);]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(memoryStream,password);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(byte,password);]{style="FONT-FAMILY: 'Courier New'"}         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                                     |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(filename)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(memoryStream)]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(byte)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(filename,password)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(memoryStream,password)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(byte,password)]{style="FONT-FAMILY: 'Courier New'"}         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: You must add the Syncfusion.Pdf.Parsing namespace to work with the loaded documents.
:::

 

In the loaded document, you can do the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Access the bookmarks

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}Add a new page[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}Add an Attachment[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}Load dynamic fields[]{style="FONT-SIZE: 12pt"}

 

 Go the above individual links for detailed information.

 

Public Members

 

[The following table lists the public members of the PdfLoadedDocument class.]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

Methods

[]{style="FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------------- --------------------------------------------------------------------------------------------------------------------------------
  Name                 Description
  AddFields            Adds the fields connected to the page.
  Append               Appends the specified loaded document to this one.
  Clone                Creates a shallow copy of the current document.
  Close                Releases the document stream.
  CreateBookmarkRoot   Creates the bookmark root.
  CreateForm           Creates a new form.
  Dispose              Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
  DisposeOnClose       Adds an object to a collection of the objects that will be disposed during document closing. (Inherited from PdfDocumentBase.)
  ImportPage           Overloaded.
  ImportPageRange      Imports a page range from a loaded document. (Inherited from PdfDocumentBase.)
  OnDocumentSaved      Raises DocumentSaved event. (Inherited from PdfDocumentBase.)
  Save                 Saves the document.
  Split                Splits a PDF file to many PDF files; each of them consists of one page from the source file.
  -------------------- --------------------------------------------------------------------------------------------------------------------------------
:::

 

Properties

 

::: {align="center"}
  --------------------- ---------------------------------------------------------------------------------------------------------------------------
  Name                  Description
  Bookmarks             Gets the bookmarks.
  Compression           Gets or sets the desired level of stream compression.
  Conformance           Gets the conformance level applied in the PDF.
  DocumentInformation   Gets or sets document\'s information and properties.
  FileStructure         Gets or sets the internal structure of the PDF file.
  Form                  Gets the loaded form.
  Pages                 Gets the pages.
  Security              Gets the security parameters of the document.
  ViewerPreferences     Gets or sets a viewer preferences object, controlling the way the document is to be presented on the screen, or in print.
  --------------------- ---------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Cloning a document

 

You can clone a PDF document in order to copy the document without saving it. This can be done by using the **PdfLoadedDocument.Clone** method.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}([\"sample.pdf\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = lDoc.Clone() [as]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                               |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldoc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedDocument(sample.pdf)]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} PdfLoadedDocument = [TryCast]{style="COLOR: blue"}(lDoc.Clone(), PdfLoadedDocument)]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Bookmark](ms-xhelp:///?Id=ec9079fb-8519-415d-81a6-1b6bf90c5b58){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding a New Page](ms-xhelp:///?Id=fb373ca1-8596-4391-baca-ae953ae8e29c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding an Attachment](ms-xhelp:///?Id=8bb2621b-e073-4735-ad48-8ae388fa9882){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Dynamic Fields](ms-xhelp:///?Id=c3d3b0b8-19d0-4972-bfe6-60c64f92c16f){style="TEXT-DECORATION: none"}
:::::::
