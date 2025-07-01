::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d8afbcf3-69db-40ff-b539-56993985dda5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=635cffee-e6f7-485d-852e-f76a60e9fc88){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}
:::

## Exporting {#exporting style="tab-stops: 0pt"}

Essential Chart has built-in support for exporting the Chart control into various image formats. Also, by using the complementary products such as Essential XlsIO, DocIO, and PDF you can export the chart image into Excel, Word documents, and PDF documents.

 

[E]{#line157}asy Exporting:

To export to the required format, it is enough to call the appropriate function.

 

Methods:

 

::: {align="center"}
  Name               Parameters                                                                                                    Return Type   Description[]{style="COLOR: black"}
  ------------------ ------------------------------------------------------------------------------------------------------------- ------------- --------------------------------------------------------------
  ExportToImage      (string filename, ChartImageFormat ImageFormat)                                                               None          This function is used to export the chart as an image.
  ExportToDocument   (string filename, ChartImageFormat ImageFormat, bool IsSaveImagetoDisk, Syncfusion.DocIO.FormatType format)   None          This function is used to export the chart as a document.
  ExportToExcel      (string filename, ChartImageFormat ImageFormat, bool IsSaveImagetoDisk)                                       None          This function is used to export the chart in an Excel sheet.
  ExportToPDF        (string filename, ChartImageFormat ImageFormat, bool IsSaveImagetoDisk)                                       None          This function is used to export the chart in a PDF document.
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Exporting to an Image](ms-xhelp:///?Id=635cffee-e6f7-485d-852e-f76a60e9fc88){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Export to a Document](ms-xhelp:///?Id=0facd854-efe1-4d02-b6b3-08f26ca010c1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Export to an Excel](ms-xhelp:///?Id=9f29a784-8d69-408d-a405-b3bb82173539){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Export to a PDF](ms-xhelp:///?Id=2d1e83a2-3e86-40a0-ac22-f9c90c14187b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Builder](ms-xhelp:///?Id=27d240c2-a9a8-4b74-8996-af68ae2b31bf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ChartModel](ms-xhelp:///?Id=015a4fc7-7223-44cb-9eeb-ea2c031dbc29){style="TEXT-DECORATION: none"}
:::::
