::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### UploadBox Client-Side Events {#uploadbox-client-side-events style="tab-stops: 0pt"}

 

Most of the time, it is not possible to know the size of a file before it is uploaded, so that the upload can be stopped if the file size too large. By using the ClientSideOnUploading event of UploadBox, you can perform Business Logic as the upload begins, so there is no need to wait until a file is uploaded to the server to find out its size---thereby saving time and bytes.

Although it is not possible to retrieve the size of a file before the upload process starts, once it does begin, the ClientSideOnUploading event will be triggered. You may then use the GetTotalFileSize() client method to retrieve the size of the file before it is completely uploaded to the server.

This event can be used whenever there is a need to perform business logic before a file is completely uploaded to the server.

First, add UploadBox and a UploadProgress to the page and add the ClientSideOnUploading event to the UploadBox, as seen in the following code snippet.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[UploadBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"UploadBox1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClientObjectId]{style="COLOR: red"}[=\"upbox\"]{style="COLOR: blue"} [UploadFolder]{style="COLOR: red"}[=\"Upload\"]{style="COLOR: blue"} [PostbackOnUpload]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"}  ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [                        [ShowSubmitButton]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"}  [ClientSideOnUploading]{style="COLOR: red"}[=\"checkSize()\"]{style="COLOR: blue"}  [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [                        [\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[UploadProgress]{style="COLOR: #a31515"} [ID]{style="COLOR: red"}[=\"prog\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClosePopup]{style="COLOR: red"}[=\"false\"]{style="COLOR: blue"} [Triggers]{style="COLOR: red"}[=\"UploadBox1\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[                 []{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} 

In the method invoked by the ClientSideOnUploading event (here it is checkSize() ), check to see whether the file size is greater than a specified size restriction, as measured in bytes, by using the GetTotalFileSize() method of UploadBox. If the file size is greater than the specified size, the upload can be cancelled.

 

+-------------------------------------------------------------------------------------------------------------------+
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ checkSize() {]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                   |
| [            [var]{style="COLOR: blue"} size = upbox.GetTotalFileSize();]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                   |
| [            [if]{style="COLOR: blue"} (size \> 36450000) {]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                   |
| [                upbox.CancelUploadFile();]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                   |
| [                [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                   |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
+-------------------------------------------------------------------------------------------------------------------+

 

In the code snippet above, any file greater than 34.7 MB will be filtered and the upload will be cancelled.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Property Detail

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+-----------------------+-------------------------------------------------------+------------------+-----------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+
| Property              | Description                                           | Type of property | Value it accepts                              | Property syntax                                                                                                                                      |
|                       |                                                       |                  |                                               |                                                                                                                                                      |
|                       |                                                       |                  |                                               |                                                                                                                                                      |
+-----------------------+-------------------------------------------------------+------------------+-----------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+
| ClientSideOnUploading | A client-side method triggered when an upload begins. | Client-side      | Name of the client-side method to be invoked. |                                                                                                                                                      |
|                       |                                                       |                  |                                               |                                                                                                                                                      |
|                       |                                                       |                  |                                               |   -------------------------------------------------------------------------------------------------------------------------------------------------- |
|                       |                                                       |                  |                                               |   [ClientSideOnUploading]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"anyClientMethod()\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}   |
|                       |                                                       |                  |                                               |   -------------------------------------------------------------------------------------------------------------------------------------------------- |
+-----------------------+-------------------------------------------------------+------------------+-----------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Methods

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

  --------------------- -------------------------- ---------------------------- ---------------------------------------------------------------------------------------- ---------------------------------------------------------------- ---------------------------------------------------------------
  Name of the method    Parameters of the method   Return type                  When is it called?                                                                       Purpose of the method                                            What is the result after the control returns from the method?
  GetTotalFileSize();   NIL                        FileSize in bytes notation   This method can be called after the upload has started and the upload progress begins.   This method is used to retrieve the size of the uploaded file.   The size of a file selected for upload will be retrieved.
  --------------------- -------------------------- ---------------------------- ---------------------------------------------------------------------------------------- ---------------------------------------------------------------- ---------------------------------------------------------------

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[]{#p569}[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{#related-topics}
:::
