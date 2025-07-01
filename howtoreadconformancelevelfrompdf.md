::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e0963c3e-d18d-4372-bd50-5a2931d5bd8e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7e200dc1-6700-4816-a5d6-116def36d675){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=ca78a5c9-c63a-4368-878c-fa18338e0b19){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Editing](ms-xhelp:///?Id=143c0997-6cd3-4daa-9060-6be730784dc4){.d2h_breadcrumbsNormal}
:::

### How To Read Conformance Level From PDF? {#how-to-read-conformance-level-from-pdf style="tab-stops: 0pt"}

 

You can read conformance level applied to a PDF file using **PdfLoadedDocument.Conformance** property. This property will return the levels supported by PdfConformanceLevel enum.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: It will return none when the PDF file is not applied with any levels.
:::

 

Following is the code snippet to read conformance level from PDF.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                  |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ loadedDocument = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: #2b91af"}(fileName);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| [PdfConformanceLevel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ appliedConformance = loadedDocument.Conformance;]{style="FONT-FAMILY: 'Courier New'"}                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ loadedDocument [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedDocument(fileName)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ appliedConformance [As]{style="COLOR: blue"} PdfConformanceLevel = loadedDocument.Conformance]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::
