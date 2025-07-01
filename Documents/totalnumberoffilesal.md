::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_Total_Number_of}Total Number of Files Allowed[]{#p180}

 

1.   Create a new folder in Web project (for eg: UploadedFiles).

2.   Add the HttpHandler file (for eg: FileUploadUrlspecifier.ashx).

 

Following are the codes should be added into the ProcessRequest() of this handler file.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                           |
|                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                          |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uploadfilepath = httpcontext.Server.MapPath([\"\~/UploadedFiles\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                          |
| [HttpHandlerHelperClass]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ fileUpload = [new]{style="COLOR: blue"} [HttpHandlerHelperClass]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                          |
| [fileUpload.HandleRequest(httpcontext, uploadfilepath);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](../ImagesExt/image261_3.jpg){border="0"}Note: Here UploadedFiles is the folder where all the uploaded files are saved.
:::

[]{#related-topics}
::::
