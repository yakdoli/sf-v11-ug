::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#####  Doc Import/Export and Docx Import/Export {#doc-importexport-and-docx-importexport style="tab-stops: 0pt"}

The .doc and .docx import features allow users to import .doc files and .docx files into the RichTextBoxAdv. It renders the content of the document as MS Word would render it. The .doc export and .docx export features actually expose the RichTextBoxAdv's document as a .doc or .docx file. To enable the .doc and .docx import/export feature in an application you should add **Syncfusion.RichTextDocIOParser.Silverlight dll** in the project. This DLL exposes the following methods to make use of the feature.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                        |
| [        RichTextBox.Document = [DocxImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(Stream, FormatType);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                        |
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                        |
| **[      ]{style="FONT-FAMILY: 'Courier New'"}**[DocxExporting]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ConvertToDocument(RichTextBox.Document, Stream, FormatType);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Methods

  ------------------------ --------------------------------------------------- ------------------------------------ ------ -------------
  Method                   Description                                         Parameters                           Type   Return Type
  ConvertToDocumentAdv()   Converts .doc or .docx stream into DocumentAdv.     FormatType and doc or docx stream.   NA     DocumentAdv
  ConvertToDocument()      Returns the rich-text content as a Word document.   NA                                   NA     Void
  ------------------------ --------------------------------------------------- ------------------------------------ ------ -------------

###### 3.32.3.8.2.1         Limitations {#limitations style="tab-stops: 0pt"}

The .doc import/export and .docx import/export features have the following limitations:

1.  Hyperlinks do not work for tables of contents.

[]{#related-topics}
:::
