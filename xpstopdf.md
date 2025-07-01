::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3e247878-d7ea-4e71-8075-ca4d4378001c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=783848c5-c845-48e8-9ec9-09165c6bd500){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Convertor](ms-xhelp:///?Id=2b6a7d69-810d-44e0-aca8-fc3a5e75a9da){.d2h_breadcrumbsNormal}
:::

### XPS to PDF {#xps-to-pdf style="tab-stops: 0pt"}

An XPS (XML Paper Specification) document, standardized by Ecma International, can be now converted to PDF.

The XPS document format consists of XML structured markup that defines the layout of a document and the visual appearance of each page, along with rendering rules for distributing, archiving, rendering, processing, and printing the documents. Similar to PDF, XPS is also a fixed-layout document format which helps to preserve document fidelity and to achieve device-independent document appearance.

 

XPS documents can be converted to PDF using the **Convert** method of the **XPSToPdfConverter** class.

![](ImagesExt/image22_2.jpg){border="0"}***Note: You need to add the Syncfusion.XPS namespace to work with the XPSToPdfConverter class.***

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                |
|                                                                                                                                                                                                               |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfDocument]{style="COLOR: #2b91af"} Convert([byte\[\]]{style="COLOR: blue"} file);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                               |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfDocument]{style="COLOR: #2b91af"} Convert([string]{style="COLOR: blue"} fileName);]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                               |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfDocument]{style="COLOR: #2b91af"} Convert([Stream]{style="COLOR: blue"} file);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 11pt"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}** |
|                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfDocument Convert([byte\[\]]{style="COLOR: blue"} file)]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfDocument Convert([String]{style="COLOR: blue"} fileName)]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfDocument Convert([Stream]{style="COLOR: blue"} file)]{style="FONT-FAMILY: 'Courier New'"}            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

An XPS document can be converted to PDF using the following code snippet:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                    |
|                                                                                                                                                                                                     |
| [// Create converter class.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                                                     |
| [XPSToPdfConverter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ converter = [new]{style="COLOR: blue"} [XPSToPdfConverter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                     |
| [// Convert the XPS to PDF]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                     |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = converter.Convert(fileName);]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                     |
| [// Save and close the document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                     |
| [document.Save([\"Sample.pdf\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                     |
| [document.Close([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                                 |
| [\' Create converter class.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ converter [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} XPSToPdfConverter()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                 |
| [\' Convert the XPS to PDF]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} PdfDocument = converter.Convert(fileName)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                 |
| [\' Save and close the document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                 |
| [document.Save([\"Sample.pdf\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                 |
| [document.Close([True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Supported Elements

::: {align="center"}
  ---------------------------- ----------------
  Element                      Convert to PDF
  ArcSegment                   Yes
  Canvas                       Yes
  DocumentOutline              No
  DocumentReference            No
  FigureStructure              No
  FixedPageResources           Yes
  Glyphs                       Yes
  Gradient                     Yes
  ImageBrush                   Yes
  Intent                       Yes
  LinkTarget                   Yes
  ListItemStructure            Yes
  ListStructure                Yes
  MatrixTransform              Yes
  NamedElement                 No
  OutlineEntry                 No
  PageContent                  Yes
  PageContentLinkTargets       No
  ParagraphStructure           No
  Path                         Yes
  PolyBezierSegment            Yes
  PolyLineSegment              Yes
  PolyQuadraticBezierSegment   Yes
  ResourceDictionary           Yes
  SectionStructure             No
  SignBy                       No
  SignatureDefinition          No
  SignatureDefinitions         No
  SigningLocation              No
  SolidColorBrush              Yes
  SpotLocation                 No
  Story                        No
  TableStructure               No
  VisualBrush                  No
  ---------------------------- ----------------
:::

 

[]{#related-topics}
:::::
