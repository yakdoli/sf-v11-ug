::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Attachments {#attachments style="tab-stops: 0pt"}

 

PDF document can contain any number of attached files. They are displayed on the Attachments navigation panel. All the data of the attached file is embedded into the document. To add a new attachment to the document, you can use the **PdfAttachment** class.

 

The following code example illustrates how to add an attachment to the document.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                   |
| [PdfAttachment]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ attachment = [new]{style="COLOR: blue"} [PdfAttachment]{style="COLOR: teal"}([@\"..\\..\\Images\\jpg\\logo.jpg\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                   |
| [attachment.ModificationDate = [DateTime]{style="COLOR: teal"}.Now;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                   |
| [attachment.Description = [\"Syncfusion Logo\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                   |
| [attachment.MimeType = [\"application/jpeg\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                   |
| [document.Attachments.Add(attachment);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ attachment [As]{style="COLOR: blue"} PdfAttachment = [New]{style="COLOR: blue"} PdfAttachment([\"..\\..\\Images\\jpg\\logo.jpg\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [attachment.ModificationDate = DateTime.Now ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                        |
| [attachment.Description = [\"Syncfusion Logo\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                        |
| [attachment.MimeType = [\"application/jpeg\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                                        |
| [document.Attachments.Add( attachment )]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Be sure to add the attachment to the attachment collection of the document. You can specify some additional parameters such as CreationDate, ModificationDate, MimeType or Description for the attachment.

 

It is possible to create attachments from data contained in a stream or data array. In this case, the file name passed to the constructor will determine the title of the attachment displayed on the attachments panel.

 

The following code example illustrates how to attach stream data to the PDF document.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (FileStream fileStream = [new]{style="COLOR: blue"} FileStream([@\"..\\..\\Images\\jpg\\image.jpg\"]{style="COLOR: maroon"}, FileMode.Open))]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                |
| [PdfAttachment]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ streamAttachment = [new]{style="COLOR: blue"} [PdfAttachment]{style="COLOR: teal"}([\"mouse.jpg\"]{style="COLOR: maroon"}, fileStream);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                |
| [streamAttachment.MimeType = [\"application/jpeg\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                |
| [document.Attachments.Add(streamAttachment);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fileStream [As]{style="COLOR: blue"} IO.FileStream = [New]{style="COLOR: blue"} IO.FileStream([\"..\\..\\Images\\jpg\\image.jpg\"]{style="COLOR: maroon"}, FileMode.Open)]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ streamAttachment [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfAttachment = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfAttachment([\"mouse.jpg\"]{style="COLOR: maroon"}, fileStream)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                            |
| [streamAttachment.MimeType = [\"application/jpeg\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                            |
| [document.Attachments.Add(streamAttachment)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ disp [As]{style="COLOR: blue"} IDisposable = fileStream]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                            |
| [disp.Dispose()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
