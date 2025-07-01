::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Performing OCR for a Complete PDF Document {#performing-ocr-for-a-complete-pdf-document style="tab-stops: 0pt"}

The following code example illustrates how to perform OCR for a complete PDF document.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                        |
| [//Initialize the OCR processor]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                     |
|                                                                                                                                                                                                                                        |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([OCRProcessor]{style="COLOR: #2b91af"} processor = [new]{style="COLOR: blue"} [OCRProcessor]{style="COLOR: #2b91af"}(ocrBinariesPath))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                        |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                        |
| [//Load a PDF document ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                                        |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ lDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: #2b91af"}(fileName);]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                                        |
| [//Set OCR language to process]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                        |
| [processor.Settings.Language = [Languages]{style="COLOR: #2b91af"}.English;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                        |
| [//Process OCR by providing the PDF document, data dictionary and language]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                                                                                                        |
| [processor.PerformOCR(lDoc, tessDataPath);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
| [//Save the OCR processed PDF document in a disk]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                                                        |
| [lDoc.Save([\"Sample.pdf\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                        |
| [lDoc.Close([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                        |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                           |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [\'Initialize the OCR processor]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                            |
| [ [Using]{style="COLOR: blue"} processor [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [OCRProcessor]{style="COLOR: #2b91af"}(ocrBinariesPath)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [\'Load a PDF document ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                            |
| [ [Dim]{style="COLOR: blue"} lDoc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: #2b91af"}(fileName)]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                            |
| [\'Set OCR language to process ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                            |
| [ processor.Settings.Language = [Languages]{style="COLOR: #2b91af"}.English]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                            |
| [\'Process OCR by providing the PDF document, data dictionary, and  language]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                            |
| [ processor.PerformOCR(lDoc, tessDataPath)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                            |
| [\'Save the OCR processed PDF document in a disk]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                            |
| [ lDoc.Save([\"Sample.pdf\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                            |
| [ lDoc.Close([True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                            |
| [ [End]{style="COLOR: blue"} [Using]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
