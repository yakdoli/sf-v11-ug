::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e7b4f267-a55a-4dff-9f7f-45ea32df6ecb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2864f107-70a9-4ef2-ad41-2aab9746eb9b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Section](ms-xhelp:///?Id=e7b4f267-a55a-4dff-9f7f-45ea32df6ecb){.d2h_breadcrumbsNormal}
:::

### Cloning and Merging {#cloning-and-merging style="tab-stops: 0pt"}

 

DocIO has an ability to clone the whole Word document or a part of it.

*[]{style="COLOR: red"}* 

Use the **Clone** method for \"deep\" document cloning. This method returns the new object of the WordDocument class along with the content of the cloned document which invoked the Clone method. You can use the Clone method to clone any document entity.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: If source and destination documents have styles with the same names, then the styles of the imported document will be renamed after importing.
:::

 

The following example illustrates how to merge two documents by using the Clone method.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                              |
| []{style="COLOR: black"}                                                                                                                                                                     |
|                                                                                                                                                                                              |
| [// Create the first document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                              |
| [IWordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                              |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section = doc.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                              |
| [IWTextRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ text1 = section.AddParagraph().AppendText( [\"First document ]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                              |
| [section\...[\" );]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                              |
| [text1.CharacterFormat.TextColor = [Color]{style="COLOR: teal"}.Red;]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                              |
| [section.AddParagraph().AppendText( [\"Some Text\...\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                              |
| [section.AddParagraph().AppendText( [\"New Paragraph\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                              |
| [section.AddParagraph().AppendText( [\"Third Paragraph\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [// Create the second document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                           |
|                                                                                                                                                                                              |
| [IWordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc2 = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                              |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section2 = doc2.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                              |
| [IWTextRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ text2 = section2.AddParagraph().AppendText( [\"Second document ]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [section\...[\" );]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                              |
| [text2.CharacterFormat.TextColor = [Color]{style="COLOR: teal"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                              |
| [section2.AddParagraph().AppendText( [\"Some Text\...\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                              |
| [section2.AddParagraph().AppendText( [\"New Paragraph More Text\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                              |
| [section2.AddParagraph().AppendText( [\"Third Paragraph More Text\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [// Merge the second document with the first.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                              |
| [doc.Sections.Add( section2.Clone() );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                                         |
| []{style="COLOR: black"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                         |
| [\' Create the first document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} IWordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} IWSection = doc.AddSection()]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ text1 [As]{style="COLOR: blue"} IWTextRange = section.AddParagraph().AppendText([\"First document section\...\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                         |
| [text1.CharacterFormat.TextColor = Color.Red]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                         |
| [section.AddParagraph().AppendText([\"Some Text\...\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [section.AddParagraph().AppendText([\"New Paragraph\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [section.AddParagraph().AppendText([\"Third Paragraph\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [\' Create the second document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc2 [As]{style="COLOR: blue"} IWordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section2 [As]{style="COLOR: blue"} IWSection = doc2.AddSection()]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ text2 [As]{style="COLOR: blue"} IWTextRange = section2.AddParagraph().AppendText([\"Second document section\...\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                         |
| [text2.CharacterFormat.TextColor = Color.Blue]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                         |
| [section2.AddParagraph().AppendText([\"Some Text\...\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [section2.AddParagraph().AppendText([\"New Paragraph More Text\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                         |
| [section2.AddParagraph().AppendText([\"Third Paragraph More Text\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [\' Merge the second document with the first.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                                         |
| [doc.Sections.Add(section2.Clone())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#_Headers_and_Footers} 

**Import Contents**

Import content functionality is used to copy/merge the contents from one document to another. Compatibility options of the source document will not be imported to the destination document.

Use the **ImportContent(WordDocument doc)** method to import contents and styles from the source document to the destination document.

Use the **ImportContent(WordDocument doc, bool importStyles)** method to import contents from the source document to the destination document by specifying whether to import styles which have the same name between the source and destination document.

[·      ]{style="FONT-FAMILY: Symbol"}[If **importStyles** is true, all the contents and styles of the source document will be imported to the destination document. In cases where a style in the source document has the same name as a style in the destination document, "Guid" is added as a suffix to the name of the imported style in order to preserve unique style name.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"}[If **importStyles** is false, all the contents will be imported, but only the styles that are not present in the destination document will be preserved. In cases where a style with the same name exists in the destination document, the destination style is applied to the imported contents.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

![Description: Description: http://help.syncfusion.com/ug_101/Reporting/DocIO/ASP.NET/ImagesExt/image9_1.png](ImagesExt/image24_34.png){border="0"}Note: If source and destination documents have styles with the same names, then Guid is added as a suffix to the name of the imported styles in the destination document.

 

Use the **ImportContent(WordDocument doc, ImportOptions importOptions)** method to import contents from the source document to the destination document with various import options similar to MS Word copy and paste options. Below are the import options supported by Essential DocIO.

[·      ]{style="FONT-FAMILY: Symbol"}**[KeepSourceFormatting]{style="FONT-FAMILY: 'Arial','sans-serif'"}**[---Imports all the contents of the source document to the destination document and preserves the entire source document formatting of the content as direct formatting. Header and footer contents will be imported similar to the **UseDestinationStyles** option.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"}**[MergeFormatting---]{style="FONT-FAMILY: 'Arial','sans-serif'"}**[Imports all the contents of the source document to the destination document and applies the formatting of surrounding content in destination document. Merges the formatting of the contents surrounding it by preserving some of the source formatting (such as bold, italic, underline, etc.). Header and footer contents will be imported similar to the **UseDestinationStyles** option.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"}**[KeepTextOnly]{style="FONT-FAMILY: 'Arial','sans-serif'"}**[---Imports only the text from the source document to the destination document (tables, textboxes, pictures, headers, footers, etc., will be removed), similar to content copied from a text file (.txt).]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"}**[UseDestinationStyles]{style="FONT-FAMILY: 'Arial','sans-serif'"}**[---Imports all the content of the source document to the destination document and applies the styles present in the destination document, or imports the source style to the destination document if no style with same name in destination document.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

 

The following example illustrates how to import contents from one document to another with various import options.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                 |
|                                                                                                                                                |
| [// Open the destination word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                |
| [WordDocument destination = new WordDocument(\"Destination.doc\");]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                |
| [// Open the source word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                                |
| [WordDocument source = new WordDocument(\"Source.doc\");]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                |
| [// Imports the contents with import option keep source formatting.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                         |
|                                                                                                                                                |
| [destination.ImportContent(source, [ImportOptions]{style="COLOR: #2b91af"}.KeepSourceFormatting);]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                |
| [// Save the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                      |
|                                                                                                                                                |
| [destination.Save(\"Sample.doc\", FormatType.Doc);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 11pt"}                             |
+------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                           |
| [\' Open the destination word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ destination [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument([\"Destination.doc\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| [\' Open the source word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument([\"Source.doc\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [\' Imports the contents with import option keep source formatting.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                                                           |
| [destination.ImportContent(source, ImportOptions.KeepSourceFormatting)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [\' Save the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                           |
| [destination.Save([\"Sample.doc\"]{style="COLOR: #a31515"}, FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}**                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

[]{#related-topics}
:::::
