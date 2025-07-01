::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to edit header in PdfGrid? {#how-to-edit-header-in-pdfgrid style="tab-stops: 0pt"}

 

When data source is set to PdfGrid, captions from source will automatically add as header. This header can be edited to display any custom text.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Editing text will affect only the PdfGrid and will not reflect in data source.
:::

The following is the code snippet:

 

+--------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                           |
|                                                                                                                          |
|                                                                                                                          |
|                                                                                                                          |
| [// Edit cell value in header.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                        |
|                                                                                                                          |
| [pdfGrid.Headers\[0\].Cells\[0\].Value = [\"Employee ID\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                  |
|                                                                                                                     |
|                                                                                                                     |
|                                                                                                                     |
| [\' Edit cell value in header.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                   |
|                                                                                                                     |
| [pdfGrid.Headers(0).Cells(0).Value = [\"Employee ID\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
