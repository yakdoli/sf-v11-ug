::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=596386ac-13fe-4d62-9ecf-e5c6dc5bdca4){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1a9433af-7b10-4c00-a9cb-dceeb1757425){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=6e49680f-da51-4b1f-9043-47e40b9c0684){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Exporting](ms-xhelp:///?Id=4aa387a2-02f4-434b-8f14-4a27c3724757){.d2h_breadcrumbsNormal}
:::

### Word Export {#word-export style="tab-stops: 0pt"}

BI Grid for Silverlight can be exported as a Word document using Essential DocIO.

 

Call Export method

The GridWordExport class provides support for exporting data from OLAP Grid to a Word document for verification. The following dll should be added, along with the default dlls in the reference folder:

 

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.OlapGridConverter.Silverlight

[]{style="COLOR: #c00000"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                        |
| [//// Export to Word Document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                        |
| [SaveFileDialog]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ saveFileDialog  = [new]{style="COLOR: blue"} [SaveFileDialog]{style="COLOR: #2b91af"} { DefaultExt = [\".doc\"]{style="COLOR: #a31515"}, Filter = [\"(\*.doc)\|\*.doc\"]{style="COLOR: #a31515"} };\             |
| [if]{style="COLOR: blue"} (saveFileDialog.ShowDialog() == [true]{style="COLOR: blue"})\                                                                                                                                                                                                |
| {\                                                                                                                                                                                                                                                                                     |
|     [Stream]{style="COLOR: #2b91af"} stream = saveFileDialog.OpenFile();\                                                                                                                                                                                                              |
|     [GridWordExport]{style="COLOR: #2b91af"} gridWordExport = [new]{style="COLOR: blue"} [GridWordExport]{style="COLOR: #2b91af"}([this]{style="COLOR: blue"}.olapGrid.OlapDataManager.PivotEngine, [this]{style="COLOR: blue"}.olapGrid.Layout);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                        |
| [    gridWordExport.Export(stream, [this]{style="COLOR: blue"}.olapGrid.GridStyleInfo);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                        |
| [    stream.Close();\                                                                                                                                                                                                                                                                  |
| }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                  |
| [' Export to Word.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ saveFileDialog [As New ]{style="COLOR: blue"}SaveFileDialog() With { \_]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                                  |
| [        Key .DefaultExt = ]{style="FONT-FAMILY: 'Courier New'"}[\".doc\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[, \_]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                  |
| [        Key .Filter = ]{style="FONT-FAMILY: 'Courier New'"}[\"(\*.doc)\|\*.doc\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'"}[\_]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                  |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ saveFileDialog.ShowDialog() = [True]{style="COLOR: blue"} [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                                  |
| [        [Dim]{style="COLOR: blue"} stream [As ]{style="COLOR: blue"}Stream = saveFileDialog.OpenFile()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                                  |
| [        [Dim]{style="COLOR: blue"} gridWordExport  [As New ]{style="COLOR: blue"}GridWordExport([Me]{style="COLOR: blue"}.olapGrid.OlapDataManager.PivotEngine, [Me]{style="COLOR: blue"}.olapGrid.Layout)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                  |
| [        gridWordExport.Export(stream, [Me]{style="COLOR: blue"}.olapGrid.GridStyleInfo);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                                                  |
| [        stream.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                  |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

 

[]{#related-topics}
::::
