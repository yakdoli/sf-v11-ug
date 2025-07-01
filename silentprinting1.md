::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Silent Printing {#silent-printing style="tab-stops: 0pt"}

PrintDocument property of PdfViewerControl returns System.Windows.Documents.FixedDocument that helps to complete print using PrintDialog. The following are the code snippets.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                     |
|                                                                                                                                                                                      |
| [PrintDialog]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dialog = [new]{style="COLOR: blue"} [PrintDialog]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                      |
| [dialog.PageRangeSelection = [PageRangeSelection]{style="COLOR: #2b91af"}.AllPages;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                      |
| [            dialog.PrintDocument(pdfViewerControl1.PrintDocument.DocumentPaginator, [\"PDF\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                   |
|                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dialog [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PrintDialog()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [dialog.PageRangeSelection = PageRangeSelection.AllPages]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                        |
| [      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                        |
| [dialog.PrintDocument(pdfViewerControl1.PrintDocument.DocumentPaginator, [\"PDF\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

[]{#related-topics}
:::
