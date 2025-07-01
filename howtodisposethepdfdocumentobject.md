::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Dispose The Pdf document Object? {#how-to-dispose-the-pdf-document-object style="tab-stops: 0pt"}

 

You can dispose the Pdf object by using the **Close** method. Note that without closing this object, it is not possible to use the same document again for any other manipulation.

 

**Close** method releases the commonly used memory. Its overload with its parameter set to true \[Close(true)\], releases the entire document stream, enabling it to be reused.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                      |
|                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                |
|                                                                                                                     |
| [// Release the common resources.        ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                        |
|                                                                                                                     |
| [pdfDoc.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                     |
| [// (or)]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                         |
|                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                |
|                                                                                                                     |
| [// Releases document stream. This releases the entire document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                     |
| [PdfDoc.Close([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                    |
+---------------------------------------------------------------------------------------------------------------------+

[                     ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                            |
|                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                               |
| [\' Release the common resources.  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}[      ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                              |
|                                                                                                                                                                                                                               |
| [pdfDoc.Close()]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                            |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [\' (or)]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [\' Releases document stream. This releases the entire document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                           |
|                                                                                                                                                                                                                               |
| [PdfDoc.Close(]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[)]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
