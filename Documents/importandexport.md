::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Import and Export

 

This feature lets you to use more than three file formats namely .doc, .docx, .html, .xaml, .txt inside the RichTextBoxAdv. Any one format allows making use of other formats.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Html Import/Export

Html Import allows the user to import .html file into the RichTextBoxAdv. It just renders the HtmlTags like the browser and displays the text in the format of RichTextBoxAdv's content model.  Html Export feature actually exposes the RichTextBoxAdv's document as the .html file. The following methods clearly show this usage

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                        |
| [      [DocumentAdv]{style="COLOR: #2b91af"} doucment = [HTMLImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(stream);]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                        |
| [      [DocumentAdv]{style="COLOR: #2b91af"} document = [HTMLImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(htmlstring);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                    |
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                 |
|                                                                                                                                                                                                    |
| [       string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ html = [HTMLExporting]{style="COLOR: #2b91af"}.ConvertToHtml(RichTextBox.Document, stream);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Methods

Table 78: Method/s Table

::: {align="center"}
+------------------------+---------------------------------------------+---------------------+-----------+-------------+-----------------+
| Method                 | Description                                 | Parameters          | Type      | Return Type | Reference links |
+------------------------+---------------------------------------------+---------------------+-----------+-------------+-----------------+
| ConvertToDocumentAdv() | It converts htmlstream into DocumentAdv.    | (Stream stream)     | NA        | DocumentAdv | NA              |
|                        |                                             |                     |           |             |                 |
|                        |                                             | (string htmlstring) |           |             |                 |
+------------------------+---------------------------------------------+---------------------+-----------+-------------+-----------------+
| ConvertToHtml()        | It converts the DocumentAdv to html string. | NA                  | NA        | String      | NA              |
+========================+=============================================+=====================+===========+=============+=================+
:::

 

Limitations

HTML Import/Export has the following limitations:

1.   Script support has not been provided

2.   It does not provide support for tables

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Doc Import/Export and Docx Import/Export

Doc and Docx Import allows user to import .doc file and .docx file into the RichTextBoxAdv. It just renders the content of the document as  MS Word renders.Doc Export and Docx Export feature actually exposes the RichTextBoxAdv's document as .doc file and .docx. To enable Doc and Docx Import/Export in the application you should add Syncfusion.RichTextDocIOParser.Silverlight dll in the project. This dll exposes the following methods to make use of the feature.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| [        RichTextBox.Document = [DocxImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(Stream, FormatType);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| **[      ]{style="FONT-FAMILY: 'Courier New'"}**[DocxExporting]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ConvertToDocument(RichTextBox.Document, Stream, FormatType);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Methods

Table 79: Method/s Table

::: {align="center"}
  Method                   Description                                         Parameters                           Type   Return Type   Reference links
  ------------------------ --------------------------------------------------- ------------------------------------ ------ ------------- -----------------
  ConvertToDocumentAdv()   It converts doc or docx stream into DocumentAdv.    FormatType and doc or docx stream.   NA     DocumentAdv   NA
  ConvertToDocument()      It returns the RichText content as Word document.   NA                                   NA     Void          NA
:::

 

Limitations

Doc Import/Export and Docx Import/Export has the following limitations:

3.   It does not provide support for Tables

4.   Hyperlink does not work for Table of Contents

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Xaml Import/Export

Xaml Import allows the user to import .xaml file into the RichTextBoxAdv. It just renders the XamlElements as XamlReader and displays the text in the format of RichTextBoxAdv's content model.  Xaml Export feature actually exposes the RichTextBoxAdv's document as an .xaml file. The following methods clearly show this usage:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                    |
| [RichTextBox.Document=[XAMLImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(xamlStream)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                    |
| **[         ]{style="FONT-FAMILY: 'Courier New'"}**[string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ xaml = [XAMLExporting]{style="COLOR: #2b91af"}.ConvertToXAML(RichTextBox.Document, xamlstream);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Methods

Table 80: Method/s Table

  Method                   Description                                 Parameters   Type   Return Type   Reference links
  ------------------------ ------------------------------------------- ------------ ------ ------------- -----------------
  ConvertToDocumentAdv()   It converts xaml stream into DocumentAdv.   NA           NA     DocumentAdv   NA
  ConvertToXaml()          It returns the RichText content as Xaml.    NA           NA     Void          NA

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text Import/Export

 

Text Import allows the user to import .txt file into the RichTextBoxAdv. It just renders the text   in notepad format and displays the text in the format of RichTextBoxAdv's content model.  Text Export feature actually exposes the RichTextBoxAdv's document as the .txt file. The following methods clearly show this usage:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                     |
| **[      ]{style="FONT-FAMILY: 'Courier New'"}**[RichTextBox.Document = [TextImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(textstream);]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: #c00000"}**                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                     |
| **[\[ C# \]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                     |
| **[      ]{style="FONT-FAMILY: 'Courier New'"}**[string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ txtstring= [TextExporting]{style="COLOR: #2b91af"}.ConvertToText(RichTextBox.Document, textStream);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: #c00000"}**                                                                                                                                                                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Methods

Table 81: Method/s Table

+------------------------+---------------------------------------------------+------------+-----------+-------------+-----------------+
| Method                 | Description                                       | Parameters | Type      | Return Type | Reference links |
+------------------------+---------------------------------------------------+------------+-----------+-------------+-----------------+
| ConvertToDocumentAdv() | It converts text stream into DocumentAdv.         | NA         | NA        | DocumentAdv | NA              |
+------------------------+---------------------------------------------------+------------+-----------+-------------+-----------------+
| ConvertText()          | It returns the RichText content as the Text file. | NA         | NA        | String      | NA              |
|                        |                                                   |            |           |             |                 |
|                        |                                                   |            |           |             |                 |
+========================+===================================================+============+===========+=============+=================+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{#related-topics}
:::::
