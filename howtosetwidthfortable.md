::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to set width for Table? {#how-to-set-width-for-table style="tab-stops: 0pt"}

 

By default, both PdfLightTable and PdfGrid classes automatically calculate width if one is not specified during Draw. However, it is possible to specify width using one of the overloads in Draw method. The following is the code snippet.

 

+-----------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                        |
|                                                                                                                       |
|                                                                                                                       |
|                                                                                                                       |
| [// Draw PdfLightTable specified width.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                            |
|                                                                                                                       |
| [pdfLightTable.Draw(pdfGraphics, [PointF]{style="COLOR: #2b91af"}.Empty, width);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                       |
| [pdfLightTable.Draw(pdfGraphics, xPos, yPos, width);]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                       |
| [pdfLightTable.Draw(pdfPage, xPos, yPos, width);]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                       |
| [pdfLightTable.Draw(pdfPage, xPos, yPos, width, pdfLightTableLayoutFormat);]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                       |
| [// Draw PdfGrid with specified width.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                             |
|                                                                                                                       |
| [pdfGrid.Draw(pdfGraphics, [PointF]{style="COLOR: #2b91af"}.Empty, width);]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                       |
| [pdfGrid.Draw(pdfGraphics, xPos, yPos, width);]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                       |
| [pdfGrid.Draw(pdfPage, xPos, yPos, width);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                       |
| [pdfGrid.Draw(pdfPage, xPos, yPos, width, pdfGridLayoutFormat);]{style="FONT-FAMILY: 'Courier New'"}                  |
+-----------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                               |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
| [\' Draw PdfLightTable specified width.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                  |
| [pdfLightTable.Draw(pdfGraphics, PointF.Empty, width)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                  |
| [pdfLightTable.Draw(pdfGraphics, xPos, yPos, width)]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                  |
| [pdfLightTable.Draw(pdfPage, xPos, yPos, width)]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                  |
| [pdfLightTable.Draw(pdfPage, xPos, yPos, width, pdfLightTableLayoutFormat)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
|  [\' Draw PdfGrid with specified width.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                  |
| [pdfGrid.Draw(pdfGraphics, PointF.Empty, width)]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                  |
| [pdfGrid.Draw(pdfGraphics, xPos, yPos, width)]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                  |
| [pdfGrid.Draw(pdfPage, xPos, yPos, width)]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                  |
| [pdfGrid.Draw(pdfPage, xPos, yPos, width, pdfGridLayoutFormat)]{style="FONT-FAMILY: 'Courier New'"}                              |
+----------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
