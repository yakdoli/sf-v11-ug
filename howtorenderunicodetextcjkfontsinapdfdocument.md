::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Render Unicode Text \[CJK Fonts\] In a PDF Document? {#how-to-render-unicode-text-cjk-fonts-in-a-pdf-document style="tab-stops: 0pt"}

 

 Essential PDF provides support for Unicode languages. You can render unicode text with the help of the **PdfCjkStandardFont** class. Languages like Japanese, Korean, Simplified Chinese, Traditional Chinese, and so on, are classified under CJK Fonts.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [// Apply Cjk font for the chinese text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                        |
| [PdfCjkStandardFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfCjkStandardFont]{style="COLOR: teal"}([PdfCjkFontFamily]{style="COLOR: teal"}.HeiseiKakuGothicW5, 12F, [PdfFontStyle]{style="COLOR: teal"}.Regular);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                        |
| [page.Graphics.DrawString(unicode_text, font, [PdfBrushes]{style="COLOR: teal"}.Black, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(0F, 0F, ([float]{style="COLOR: blue"})(page.Size.Width), ([float]{style="COLOR: blue"})(page.Size.Height)));]{style="FONT-FAMILY: 'Courier New'"}  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                  |
| [\' Apply Cjk font for the chinese text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfCjkStandardFont = [New]{style="COLOR: blue"} PdfCjkStandardFont(PdfCjkFontFamily.HeiseiKakuGothicW5, 12.0F, PdfFontStyle.Regular)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                  |
| [page.Graphics.DrawString(unicode_text, font, PdfBrushes.Black, [New]{style="COLOR: blue"} RectangleF(0.0F, 0.0F, [CSng]{style="COLOR: blue"}(page.Size.Width), [CSng]{style="COLOR: blue"}(page.Size.Height)))]{style="FONT-FAMILY: 'Courier New'"}             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

You can also apply cjk fonts from disk and embed them. The following code example illustrates this.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                            |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                      |
|                                                                                                                                                                           |
| [//Add CJK font to the font collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                           |
| [string font = \"gulim.ttf\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                           |
| [PrivateFontCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ fcol = new [PrivateFontCollection()]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [fcol.AddFontFile(font);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                           |
| [Font]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ f = new [Font]{style="COLOR: teal"}(fcol.Families\[0\], 14);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                           |
| [PdfFont font = new PdfTrueTypeFont(f, true);]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                           |
| [string koreanText = \"korean.txt\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                           |
| [//Read the text from text file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                           |
| [StreamReader reader = new StreamReader(koreanText, Encoding.Unicode);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                           |
| [string text = reader.ReadToEnd();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                           |
| [reader.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                           |
| [page.Graphics.DrawString(text, font, brush,PointF.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                        |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                      |
|                                                                                                                                                                           |
| [//Add CJK font to the font collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                           |
| [string font = \"gulim.ttf\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                           |
| [PrivateFontCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ fcol = new [PrivateFontCollection()]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [fcol.AddFontFile(font);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                           |
| [Font]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ f = new [Font]{style="COLOR: teal"}(fcol.Families\[0\], 14);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                           |
| [PdfFont font = new PdfTrueTypeFont(f, true);]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                           |
| [string koreanText = \"korean.txt\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                           |
| [//Read the text from text file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                           |
| [StreamReader reader = new StreamReader(koreanText, Encoding.Unicode);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                           |
| [string text = reader.ReadToEnd();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                           |
| [reader.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                           |
| [page.Graphics.DrawString(text, font, brush,PointF.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::
