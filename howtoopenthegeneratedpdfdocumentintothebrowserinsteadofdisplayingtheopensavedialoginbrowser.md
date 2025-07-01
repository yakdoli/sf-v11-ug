::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to open the generated PDF document into the browser instead of displaying the Open/Save dialog in browser? {#how-to-open-the-generated-pdf-document-into-the-browser-instead-of-displaying-the-opensave-dialog-in-browser style="tab-stops: 0pt"}

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

You can open the PDF document directly in the browser with the help of the Response object.

Follow the below steps to generate the PDF document inline:

1.   Save the PDF document as Stream object.

2.   Write the stream in the Response object.

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                |
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                |
| [ //Save the PDFDocument as a Stream.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                |
| [        [MemoryStream]{style="COLOR: #2b91af"} stream = [new]{style="COLOR: blue"} [MemoryStream]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [        doc.Save(stream);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [        [//Stream the output to the browser.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                |
| [        Response.ContentType = [\"application/pdf\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [        Response.AddHeader([\"content-disposition\"]{style="COLOR: #a31515"}, [\"inline; filename=MyPDF.PDF\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [        Response.AddHeader([\"content-length\"]{style="COLOR: #a31515"}, stream.Length.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [        Response.BinaryWrite(stream.ToArray());]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [        Response.End();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[VB\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}                                                                                     |
|                                                                                                                                                                               |
| [  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[      [Save the PDFDocument as a Stream.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                               |
| [        [Dim]{style="COLOR: blue"} stream [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} MemoryStream()]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [        doc.Save(stream)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [        [\'Stream the output to the browser.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                               |
| [        Response.ContentType = [\"application/pdf\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                                                                        |
|                                                                                                                                                                               |
| [        Response.AddHeader([\"content-disposition\"]{style="COLOR: #a31515"}, [\"inline; filename=MyPDF.PDF\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [        Response.AddHeader([\"content-length\"]{style="COLOR: #a31515"}, stream.Length.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [        Response.BinaryWrite(stream.ToArray())]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [  Response.End()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
