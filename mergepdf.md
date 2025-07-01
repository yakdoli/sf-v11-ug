::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c0508cb3-03fd-4aea-b826-e8dabdb20065){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=923a5db9-fc7d-487b-8ee2-c6a0b4ad7a85){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Editing](ms-xhelp:///?Id=acdc025e-645c-4f53-ab6c-d726bbf3e589){.d2h_breadcrumbsNormal}
:::

### Merge PDF {#merge-pdf style="tab-stops: 0pt"}

 

Merging feature in the Essential PDF enables appending all documents to the target document. While merging, all bookmarks and attachments will be copied, additionally to **ImportPageRange** behavior.

 

There are various overloads of the **Merge** method that allow specifying different parameters. Some important parameters are: 

 

[·      ]{style="FONT-FAMILY: Symbol"}Array of strings

[·      ]{style="FONT-FAMILY: Symbol"}Array of PdfDocumentBase instances

 

If the target document is null (in overload that accepts PdfDocumentBase class as a target), a new instance will be created.

 

You can also merge the documents in the following ways:

 

[·      ]{style="FONT-FAMILY: Symbol"}Append all the documents one after the another by using the **Append** method.

[·      ]{style="FONT-FAMILY: Symbol"}Import the pages from different documents by using the **ImportPageRange** or **ImportPage** method.

[·      ]{style="FONT-FAMILY: Symbol"}Use **Insert** method to insert the pages one by one.

 

For more details, see [[Merge PDF]{.UGHyperlink}]().

 

[]{#related-topics}
::::
