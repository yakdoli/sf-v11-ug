::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Drawing Text {#drawing-text style="tab-stops: 0pt"}

 

This section elaborates on various procedures for drawing the text in a PDF document.

 

The following are the procedures used:

 

[·      ]{style="FONT-FAMILY: Symbol"}Using DrawString

[·      ]{style="FONT-FAMILY: Symbol"}Paginating the text area

[·      ]{style="FONT-FAMILY: Symbol"}String Formatting and

[·      ]{style="FONT-FAMILY: Symbol"}RTF Support

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Using DrawString

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**PdfGraphics** class contains plenty of **DrawString** methods. It draws the specified text string at the specified location with the specified size, brush and font. The format of the methods is similar to the **System.Drawing.Graphics.DrawString** methods.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                    |
| [public ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DrawString( [string]{style="COLOR: blue"} s, [PdfFont]{style="COLOR: #2b91af"} font, [PdfBrush]{style="COLOR: #2b91af"} brush, [PointF]{style="COLOR: #2b91af"} point );]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                                                                                                                    |
| [public ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DrawString( [string]{style="COLOR: blue"} s, [PdfFont]{style="COLOR: #2b91af"} font, [PdfBrush]{style="COLOR: #2b91af"} brush, [PointF]{style="COLOR: #2b91af"} point, [PdfStringFormat]{style="COLOR: #2b91af"} format );]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                                                                                                                                    |
| [public ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DrawString( [string]{style="COLOR: blue"} s, [PdfFont]{style="COLOR: #2b91af"} font, [PdfBrush]{style="COLOR: #2b91af"} brush, [float]{style="COLOR: blue"} x, [float]{style="COLOR: blue"} y );]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                                                                                                                                    |
| [public ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DrawString( [string]{style="COLOR: blue"} s, [PdfFont]{style="COLOR: #2b91af"} font, [PdfBrush]{style="COLOR: #2b91af"} brush, [float]{style="COLOR: blue"} x, [float]{style="COLOR: blue"} y, [PdfStringFormat]{style="COLOR: #2b91af"} format );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                    |
| [public ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DrawString( [string]{style="COLOR: blue"} s, [PdfFont]{style="COLOR: #2b91af"} font, [PdfPen]{style="COLOR: #2b91af"} pen, [PointF]{style="COLOR: #2b91af"} point );]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                          |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ lDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename);]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                                          |
| [page = lDoc.Pages.Add() [as]{style="COLOR: blue"} [PdfPage]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                          |
| [PdfGraphics]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ g = page.Graphics;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                          |
| [PdfFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfStandardFont]{style="COLOR: teal"}([PdfFontFamily]{style="COLOR: teal"}.Helvetica, 14, [PdfFontStyle]{style="COLOR: teal"}.Bold);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                          |
| [g.DrawString([\"Polygon\"]{style="COLOR: maroon"}, font, [PdfBrushes]{style="COLOR: teal"}.DarkBlue, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(50, 0));]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                          |
| [lDoc.Save(filename);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                          |
| [lDoc.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lDoc [As]{style="COLOR: blue"} Syncfusion.Pdf.Parsing.PdfLoadedDocument = [New]{style="COLOR: blue"} Syncfusion.Pdf.Parsing.PdfLoadedDocument(filename)]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                                                                  |
| [page = [TryCast]{style="COLOR: blue"}(lDoc.Pages.Add(), PdfPage)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ g [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfGraphics = page.Graphics]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfFont = [New]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                  |
| [g.DrawString([\"Polygon\"]{style="COLOR: maroon"}, font, PdfBrushes.DarkBlue, [New]{style="COLOR: blue"} PointF(50, 0))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [lDoc.Save(filename)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                  |
| [lDoc.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2\. Paginating the text Area

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**PdfTextElement** class represents the text area with the ability to span several pages. The **Layout** property of the **PDFLayoutFormat** class enables to break the text into multiple pages. Unicode text is also supported by this method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Create a text element with large amount of text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                   |
|                                                                                                                                                                                                                                           |
| [PdfTextElement]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ element = [new]{style="COLOR: blue"} [PdfTextElement]{style="COLOR: teal"}(text, font);]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Set the properties for the text element.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                                                           |
| [element.Brush = [new]{style="COLOR: blue"} [PdfSolidBrush]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Black);]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Set the string format. This can be used for setting unicode text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                                                           |
| [element.StringFormat = format;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Set the layout format properties to make the text flow through multiple pages.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                                                                           |
| [PdfLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ layoutFormat = [new]{style="COLOR: blue"} [PdfLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                                           |
| [layoutFormat.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitPage;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                           |
| [layoutFormat.Layout = [PdfLayoutType]{style="COLOR: teal"}.Paginate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Set the bounds.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [RectangleF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}([PointF]{style="COLOR: teal"}.Empty, page.Graphics.ClientSize);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Draw the text element.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                                           |
| [element.Draw(page, bounds, layoutFormat);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                       |
| [\' Create a text element with large amount of text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ element [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfTextElement = [New]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfTextElement(Text, Font)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [\' Set the properties for the text element.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                       |
| [element.Brush = [New]{style="COLOR: blue"} PdfSolidBrush(Color.Black)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [\' Set the string format. This can be used for setting unicode text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                                                       |
| [element.StringFormat = format]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [\' Set the layout format properties to make the text flow through multiple pages.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ layoutFormat [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfLayoutFormat = [New]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                       |
| [layoutFormat.Break = PdfLayoutBreakType.FitPage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                       |
| [layoutFormat.Layout = PdfLayoutType.Paginate]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [\' Set the bounds.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bounds [As]{style="COLOR: blue"} RectangleF = [New]{style="COLOR: blue"} RectangleF(PointF.Empty, page.Graphics.ClientSize)]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [\' Draw the text element.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                       |
| [element.Draw(page, bounds, layoutFormat)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

3\. String Formatting

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For dedicated presentation of text in a PDF document, use a PdfStringFormat object. **PdfStringFormat** class provides support for the following features:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}CharacterSpacing, WordSpacing and LineSpacing

[·      ]{style="FONT-FAMILY: Symbol"}Right-To-Left languages such as Arabic, Hebrew, Urdu, and so on

[·      ]{style="FONT-FAMILY: Symbol"}Center, Left, Right and Justify text alignments

[·      ]{style="FONT-FAMILY: Symbol"}Subscript and superscript modes

[·      ]{style="FONT-FAMILY: Symbol"}ParagraphIndent customization

[·      ]{style="FONT-FAMILY: Symbol"}WordWrapType style

[·      ]{style="FONT-FAMILY: Symbol"}MeasureTrailingSpaces

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

4\. RTF Support

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **Rich Text Format (RTF)** specification is a method of encoding formatted text and graphics such as bold characters and typefaces, document formatting and structures, for easy transfer between applications. Essential PDF supports drawing RTF text into a PDF document by using the **FromRtf** method in the **PdfImage** class.

[]{style="COLOR: black"} 

You can draw RTF text by converting it into a bitmap or metafile image. Converting RTF text into a bitmap file, provides improved performance, while converting RTF text into a metafile image, provides high resolution and searchable text.

 

The following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                       |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfImage]{style="COLOR: #2b91af"} FromRtf( [string]{style="COLOR: blue"} rtf, [float]{style="COLOR: blue"} width, [PdfImageType]{style="COLOR: #2b91af"} type )]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                                                                                                       |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfImage]{style="COLOR: #2b91af"} FromRtf( [string]{style="COLOR: blue"} rtf, [float]{style="COLOR: blue"} width, [float]{style="COLOR: blue"} height, [PdfImageType]{style="COLOR: #2b91af"} type )]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                   |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfImage FromRtf([String]{style="COLOR: blue"} rtf, [single]{style="COLOR: blue"} width, PdfImageType type)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                                                   |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfImage FromRtf([String]{style="COLOR: blue"} rtf, [single]{style="COLOR: blue"} width, [single]{style="COLOR: blue"} height, PdfImageType type)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

For More Information Refer:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[[Draw Rich Text]{.UGHyperlink}](ms-xhelp:///?Id=a32971d7-f5e0-40b7-abaf-b939b025d5fe)[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

 

 

[]{#related-topics}
:::
