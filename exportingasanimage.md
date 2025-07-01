::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=fc8b57c0-4bf0-4d76-8813-0505d80a96b7){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=90f9e7c4-bbe6-4a7e-80c9-9ef96634cca9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=100687ce-82f2-4424-9d16-0949ea76cf15){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Exporting](ms-xhelp:///?Id=7807ddfa-c63b-48f5-92a7-ab2d219a35c5){.d2h_breadcrumbsNormal}
:::

### Exporting as an Image {#exporting-as-an-image style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The chart image can easily be exported as an image file in several different formats.

 

Programmatically

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                    |
|                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                   |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"} fileName;]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                   |
| [fileName = [Application]{style="COLOR: teal"}.StartupPath + [\"\\\\chartexport\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                   |
| [fileName = fileName + [\".gif\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                               |
|                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.SaveImage(fileName);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                              |
|                                                                                                                                                   |
| [// Launches the file. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                        |
|                                                                                                                                                   |
| [System.Diagnostics.Process.Start(exportFileName);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                |
|                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                          |
|                                                                                                                                                                   |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fileName [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                   |
| [fileName = Application.StartupPath + [\"\\chartexport\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                   |
| [fileName = fileName + [\".gif\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                               |
|                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.SaveImage(fileName)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                    |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                              |
|                                                                                                                                                                   |
| [\' Launches the file. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                   |
| [System.Diagnostics.Process.Start(exportFileName)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Based on the filename extension the chart has built-in support to save the image in the following formats.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------------------------------- --------------------------------
  File Extension                         File Type
  .bmp                                   BMP
  .jpg                                   JPEG
  .jpeg                                  JPEG
  .gif                                   GIF
  .tiff                                  TIFF
  .Wmf                                   WMF
  .emf                                   EMF
  .svg                                   SVG (Scalable Vector Graphics)
  .eps                                   Post Script
  -------------------------------------- --------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

If the specified extension is none of the above, then the chart is exported as a bitmap.

 

During runtime, chart control can be saved as a file using the [Chart Toolbar]{style="COLOR: black"}[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}save option.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Sample

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}** 

A sample demonstrating the above functionality is available in our installation at the following location:

Web Forms: \"My Documents\\Syncfusion\\EssentialStudio\\***Version Number***\\Web\\chart.web\\Samples\\3.5\\Exporting\\ChartExportData\"

[]{#p254} 

 

[]{#related-topics}
:::::
