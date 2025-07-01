::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#####  HTML Import/Export {#html-importexport style="tab-stops: 0pt"}

The HTML import feature allows the user to import an .html file into the RichTextBoxAdv. It renders the HTML tags like a browser and displays the text in the format of RichTextBoxAdv's content model. The HTML export feature actually exposes the RichTextBoxAdv's document as an .html file. The following methods clearly show this use case.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                        |
| [      [DocumentAdv]{style="COLOR: #2b91af"} doucment = [HTMLImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(stream);]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                        |
| [      [DocumentAdv]{style="COLOR: #2b91af"} document = [HTMLImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(htmlstring);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                  |
|                                                                                                                                                                                                    |
| [       string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ html = [HTMLExporting]{style="COLOR: #2b91af"}.ConvertToHtml(RichTextBox.Document, stream);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

Methods

+------------------------+---------------------------------------------+---------------------+-------------+-------------+
| Method                 | Description                                 | Parameters          | Type        | Return Type |
+------------------------+---------------------------------------------+---------------------+-------------+-------------+
| ConvertToDocumentAdv() | Converts htmlstream into DocumentAdv.       | (Stream stream)     | NA          | DocumentAdv |
|                        |                                             |                     |             |             |
|                        |                                             | (string htmlstring) |             |             |
+------------------------+---------------------------------------------+---------------------+-------------+-------------+
| ConvertToHtml()        | Converts the DocumentAdv to an HTML string. | NA                  | NA          | String      |
+------------------------+---------------------------------------------+---------------------+-------------+-------------+

###### 3.32.3.8.1.1         Limitations {#limitations style="tab-stops: 0pt"}

The HTML import/export feature has the following limitations:

1.   Script support has not been provided.

2.   It does not provide support for tables.

[]{#related-topics}
:::
