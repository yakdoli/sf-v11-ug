::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6e4a6714-10bc-45a7-9514-564d1b11f574){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=5d98d3bf-1bbc-4660-b7fd-f16a34be542e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=ca78a5c9-c63a-4368-878c-fa18338e0b19){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Grid](ms-xhelp:///?Id=be34385c-c628-43a9-a593-a68c54896ad9){.d2h_breadcrumbsNormal}
:::

### How to make background images centered, stretched and fitted within the PDF Grid? {#how-to-make-background-images-centered-stretched-and-fitted-within-the-pdf-grid style="LINE-HEIGHT: 115%; TEXT-INDENT: -36pt; MARGIN: 10pt 0pt 0pt 36pt; tab-stops: 36.0pt"}

 

Background image positioning such as stretch, center and fit within the PDF Grid can be done by setting the property "ImagePosition" to PdfGridImagePosition.Stretch, PdfGridImagePosition.Centre and PdfGridImagePosition.Fit respectively.

 

+----------------------------------------------------------------------------------------------------------+
| [grid.Rows(1).Cells(0).ImagePosition = PdfGridImagePosition.Stretch]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                          |
| [grid.Rows(1).Cells(1).ImagePosition = PdfGridImagePosition.Centre]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                          |
| [grid.Rows(1).Cells(2).ImagePosition = PdfGridImagePosition.Fit]{style="FONT-FAMILY: 'Courier New'"}     |
+----------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #e36c0a"}** 

For more information on positioning background images, refer to the section Background Image Positioning in [PdfGrid Cell](ms-xhelp:///?Id=c58dadd4-cc40-4bce-a45e-582e90f95bde).

 

[]{#related-topics}
::::
