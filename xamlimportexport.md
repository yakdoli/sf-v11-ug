::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#####  XAML Import/Export {#xaml-importexport style="tab-stops: 0pt"}

The XAML import feature allows users to import a .xaml file into the RichTextBoxAdv. It renders the XAML elements as XamlReader and displays the text in the format of RichTextBoxAdv's content model. The XAML export feature actually exposes the RichTextBoxAdv's document as a .xaml file. The following methods clearly show this use case.

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                    |
| [RichTextBox.Document=[XAMLImporting]{style="COLOR: #2b91af"}.ConvertToDocumentAdv(xamlStream)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                    |
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| **[         ]{style="FONT-FAMILY: 'Courier New'"}**[string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ xaml = [XAMLExporting]{style="COLOR: #2b91af"}.ConvertToXAML(RichTextBox.Document, xamlstream);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

Methods

  ------------------------ ------------------------------------------- ------------ ------ -------------
  Method                   Description                                 Parameters   Type   Return Type
  ConvertToDocumentAdv()   It converts XAML stream into DocumentAdv.   NA           NA     DocumentAdv
  ConvertToXaml()          It returns the RichText content as XAML.    NA           NA     Void
  ------------------------ ------------------------------------------- ------------ ------ -------------

[]{#related-topics}
:::
