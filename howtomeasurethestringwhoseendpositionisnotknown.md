::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Measure the String Whose End Position Is Not Known? {#how-to-measure-the-string-whose-end-position-is-not-known style="tab-stops: 0pt"}

 

PdfFont provides the **MeasureString** method which determines the rectangle that a string should occupy on a PDF page. This information is used for relative positioning of several paragraphs of text.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                   |
|                                                                                                                                                                        |
| [// Create a font.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                        |
| [PdfStandardFont font = [new]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Symbol, 12, PdfFontStyle.Bold);]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Measure the size of the text based on string format and font.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                   |
|                                                                                                                                                                        |
| [SizeF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textSize = pdfFont.MeasureString(text, rect.Size, format);]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                        |
| [// Draw the rectangle for the size of the text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                    |
|                                                                                                                                                                        |
| [page.Graphics.DrawRectangle(PdfPens.Red, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(rect.Location, textSize));]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                       |
| [\' Create a font.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfStandardFont = [New]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Symbol, 12, PdfFontStyle.Bold)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [\' Measure the size of the text based on string format and font. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textSize [As]{style="COLOR: blue"} SizeF = pdfFont.MeasureString(text, rect.Size, format)]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [\' Draw the rectangle for the size of the text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                   |
|                                                                                                                                                                                                                                       |
| [page.Graphics.DrawRectangle(PdfPens.Red, [New]{style="COLOR: blue"} RectangleF(rect.Location, textSize))]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p129} 

 

[]{#related-topics}
:::
