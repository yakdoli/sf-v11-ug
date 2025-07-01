::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### TextBox {#textbox style="tab-stops: 0pt"}

 

**WTextBox** class represents a text box in the Word document.

 

TextBox is a shape. DocIO text box (WTextBox) has two properties which are as follows.

 

[·      ]{style="FONT-FAMILY: Symbol"}**TextBoxFormat** -- defines formatting of the text box (position, alignment, border colors, and so on)

[·      ]{style="FONT-FAMILY: Symbol"}**TextBoxBody** -- defines the text for the text box

 

**TextBoxFormat** property returns the object of the WTextBoxFormat type. For more details, see [WTextBoxFormat]{style="COLOR: black"}. TextBoxBody property returns the object of the WTextBody type.

 

You can use the **AppendTextBox** function of the WParagraph class to append a text box to a paragraph.

 

Class Hierarchy

 

ParagraphItem

            \|

            WTextBox

 

Public Constructor

 

::: {align="center"}
  ----------------------------------- -----------------------------------------------------
  Name                                Description
  WTextBox.WTextBox (IWordDocument)   Initializes a new instance of the WTextBox class.  
  ----------------------------------- -----------------------------------------------------
:::

 

Public Properties

 

::: {align="center"}
  ---------------- -------------------------------------
  Name             Description
  ChildEntities    Gets the child entities.  
  EntityType       Gets the type of the entity.  
  OwnerParagraph   Gets owner paragraph.  
  TextBoxBody      Get or sets TextBody value.  
  TextBoxFormat    Gets or sets TextBoxFormat value.  
  ---------------- -------------------------------------
:::

 

The following example illustrates how to use the WTextBox and TextBoxFormat classes.

*[]{style="COLOR: red"}* 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| []{style="COLOR: black"}                                                                                                                                                       |
|                                                                                                                                                                                |
| [IWordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section = doc.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                |
| [section.PageSetup.DifferentFirstPage = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                |
| [section.PageSetup.DifferentOddAndEvenPages = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [// Main doc text boxes]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                |
| [paragraph.AppendText([\"Testing textboxes\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [// 1st text box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                |
| [IWTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ mainTextbox = paragraph.AppendTextBox(150, 110);]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                |
| [mainTextbox.TextBoxBody.AddParagraph().AppendText([\"Textbox text 1\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                |
| [mainTextbox.TextBoxFormat.FillColor = System.Drawing.[Color]{style="COLOR: teal"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                |
| [mainTextbox.TextBoxFormat.LineDashing = [LineDashing]{style="COLOR: teal"}.LongDashDotDotGEL;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                |
| [mainTextbox.TextBoxFormat.LineWidth = 4.0f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [// 2nd text box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                |
| [IWTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ mainTextbox1 = paragraph.AppendTextBox(150, 100);]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.VerticalPosition = 500;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxBody.AddParagraph().AppendText([\"Another textbox\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.FillColor = System.Drawing.[Color]{style="COLOR: teal"}.Yellow;]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.LineDashing = [LineDashing]{style="COLOR: teal"}.DashGEL;]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.LineWidth = 3.75f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.TextWrappingStyle = [TextWrappingStyle]{style="COLOR: teal"}.Through;]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.TextWrappingType = [TextWrappingType]{style="COLOR: teal"}.Both;]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.HorizontalAlignment = [ShapeHorizontalAlignment]{style="COLOR: teal"}.Center;]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                |
| [mainTextbox1.TextBoxFormat.VerticalAlignment = [ShapeVerticalAlignment]{style="COLOR: teal"}.Bottom;]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [// Header/footer text boxes]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                                |
| [paragraph = [new]{style="COLOR: blue"} [WParagraph]{style="COLOR: teal"}(doc);]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                |
| [paragraph.AppendText([\"Hello textboxes\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                |
| [IWTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textbox = paragraph.AppendTextBox(20, 50);]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                |
| [textbox.TextBoxBody.AddParagraph().AppendText([\"Header textbox\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                |
| [textbox.TextBoxFormat.FillColor = System.Drawing.[Color]{style="COLOR: teal"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                |
| [textbox.TextBoxFormat.LineDashing = [LineDashing]{style="COLOR: teal"}.LongDashDotDotGEL;]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                |
| [textbox.TextBoxFormat.LineWidth = 4.0f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [IWTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textbox1 = paragraph.AppendTextBox(250, 50);]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                |
| [textbox1.TextBoxBody.AddParagraph().AppendText([\"Header textbox 2\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                |
| [textbox1.TextBoxFormat.FillColor = System.Drawing.[Color]{style="COLOR: teal"}.Tomato;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                |
| [textbox1.TextBoxFormat.VerticalPosition = 250;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                |
| [textbox1.TextBoxFormat.LineStyle = [TextBoxLineStyle]{style="COLOR: teal"}.Triple;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                |
| [textbox1.TextBoxFormat.LineDashing = [LineDashing]{style="COLOR: teal"}.LongDashGEL;]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                |
| [textbox1.TextBoxFormat.LineWidth = 6.0f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                |
| [textbox1.TextBoxFormat.NoLine = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [section.HeadersFooters.FirstPageHeader.Paragraphs.Add(paragraph);]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [paragraph = [new]{style="COLOR: blue"} [WParagraph]{style="COLOR: teal"}(doc);]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                |
| [paragraph.AppendText([\"Hello footer textbox\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                |
| [IWTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textbox2 = paragraph.AppendTextBox(120, 100);]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.VerticalPosition = 5;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                |
| [textbox2.TextBoxBody.AddParagraph().AppendText([\"Footer textbox\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.FillColor = System.Drawing.[Color]{style="COLOR: teal"}.Yellow;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.LineDashing = [LineDashing]{style="COLOR: teal"}.DashGEL;]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.LineWidth = 3.75f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.TextWrappingStyle = [TextWrappingStyle]{style="COLOR: teal"}.Square;]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.HorizontalAlignment = [ShapeHorizontalAlignment]{style="COLOR: teal"}.Left;]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                |
| [textbox2.TextBoxFormat.VerticalAlignment = [ShapeVerticalAlignment]{style="COLOR: teal"}.Bottom;]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                |
| [section.HeadersFooters.FirstPageFooter.Paragraphs.Add(paragraph);]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [doc.Save([\"TextBoxes.doc\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                   |
|                                                                                                                                                                                      |
| []{style="COLOR: black"}                                                                                                                                                             |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} IWordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} IWSection = doc.AddSection()]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paragraph [As]{style="COLOR: blue"} IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                      |
| [section.PageSetup.DifferentFirstPage = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                      |
| [section.PageSetup.DifferentOddAndEvenPages = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                  |
|                                                                                                                                                                                      |
| [\' Main doc text boxes]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                           |
|                                                                                                                                                                                      |
| [paragraph.AppendText([\"Testing textboxes\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [\' 1st text box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ mainTextbox [As]{style="COLOR: blue"} IWTextBox = paragraph.AppendTextBox(150, 110)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                      |
| [mainTextbox.TextBoxBody.AddParagraph().AppendText([\"Textbox text 1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                      |
| [mainTextbox.TextBoxFormat.FillColor = System.Drawing.Color.Blue]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                      |
| [mainTextbox.TextBoxFormat.LineDashing = LineDashing.LongDashDotDotGEL]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                      |
| [mainTextbox.TextBoxFormat.LineWidth = 4.0f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [\' 2nd text box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ mainTextbox1 [As]{style="COLOR: blue"} IWTextBox = paragraph.AppendTextBox(150, 100)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.VerticalPosition = 500]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxBody.AddParagraph().AppendText([\"Another textbox\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.FillColor = System.Drawing.Color.Yellow]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.LineDashing = LineDashing.DashGEL]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.LineWidth = 3.75f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.TextWrappingStyle = TextWrappingStyle.Through]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.TextWrappingType = TextWrappingType.Both]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.HorizontalAlignment = ShapeHorizontalAlignment.Center]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                      |
| [mainTextbox1.TextBoxFormat.VerticalAlignment = ShapeVerticalAlignment.Bottom]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [\' Header/footer text boxes]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                      |
| [paragraph = [New]{style="COLOR: blue"} WParagraph(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                      |
| [paragraph.AppendText([\"Hello textboxes\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textbox [As]{style="COLOR: blue"} IWTextBox = paragraph.AppendTextBox(20, 50)]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                      |
| [textbox.TextBoxBody.AddParagraph().AppendText([\"Header textbox\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                      |
| [textbox.TextBoxFormat.FillColor = System.Drawing.Color.Blue]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                      |
| [textbox.TextBoxFormat.LineDashing = LineDashing.LongDashDotDotGEL]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                      |
| [textbox.TextBoxFormat.LineWidth = 4.0f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textbox1 [As]{style="COLOR: blue"} IWTextBox = paragraph.AppendTextBox(250, 50)]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                      |
| [textbox1.TextBoxBody.AddParagraph().AppendText([\"Header textbox 2\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                      |
| [textbox1.TextBoxFormat.FillColor = System.Drawing.Color.Tomato]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                      |
| [textbox1.TextBoxFormat.VerticalPosition = 250]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                      |
| [textbox1.TextBoxFormat.LineStyle = TextBoxLineStyle.Triple]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                      |
| [textbox1.TextBoxFormat.LineDashing = LineDashing.LongDashGEL]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                      |
| [textbox1.TextBoxFormat.LineWidth = 6.0f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                      |
| [textbox1.TextBoxFormat.NoLine = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                  |
|                                                                                                                                                                                      |
| [section.HeadersFooters.FirstPageHeader.Paragraphs.Add(paragraph)]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [paragraph = [New]{style="COLOR: blue"} WParagraph(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                      |
| [paragraph.AppendText([\"Hello footer textbox\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textbox2 [As]{style="COLOR: blue"} IWTextBox = paragraph.AppendTextBox(120, 100)]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.VerticalPosition = 5]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                      |
| [textbox2.TextBoxBody.AddParagraph().AppendText([\"Footer textbox\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.FillColor = System.Drawing.Color.Yellow]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.LineDashing = LineDashing.DashGEL]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.LineWidth = 3.75f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.TextWrappingStyle = TextWrappingStyle.Square]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.HorizontalAlignment = ShapeHorizontalAlignment.Left]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                      |
| [textbox2.TextBoxFormat.VerticalAlignment = ShapeVerticalAlignment.Bottom]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                      |
| [section.HeadersFooters.FirstPageFooter.Paragraphs.Add(paragraph)]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [doc.Save([\"TextBoxes.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::::
