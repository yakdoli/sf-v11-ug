::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### UploadBox Customization {#uploadbox-customization style="tab-stops: 0pt"}

 

 

 Setting privilege for file upload and download

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The files to be uploaded can set in such a way that you can specify the types of files to be uploaded using the **ExtensionsAllow** property and also set the types of files to be prevented from being uploaded using the **ExtensionsDeny** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------- ---------------------------------------------------------------------------------
  Property          Description
  ExtensionsAllow   Specifies the accepted file types that can be uploaded, delimited by semicolon.
  ExtensionsDeny    Specifies the file types to block from being uploaded, delimited by semicolon.
  ----------------- ---------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                 |
|                                                                                                            |
| [uploadbox1.ExtensionsAllow = [\"txt, htmt\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                            |
| [uploadbox1.ExtensionsDeny = [\"avi, exe\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}   |
+------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                     |
|                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                           |
|                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uploadbox1.ExtensionsAllow = [\"txt, htmt\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uploadbox1.ExtensionsDeny = [\"avi, exe\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The UploadBox allows the users to upload files or images to the desired storage location. The destination folder where the files have to be stored can be specified by setting the pathname of that folder to the **UploadFolder** property.

When file is uploaded and UploadFolder property is not set to any path, then file is written to the application folder. And there is the possibility that file cannot be written due to access restrictions. Hence make sure to specify UploadFolder property to the folder where the files should be uploaded or provide the appropriate \'write permission\' to write to the application folder.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------- ---------------------------------------------------------------------------------------------------------------------------
  Property       Description
  SizeFilter     Specifies the maximum file size allowed to be uploaded, in KB. Default value is 0 which represents unlimited upload size.
  UploadFolder   Specifies the folder to which the files should be uploaded.
  -------------- ---------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The size of the files being uploaded can be restricted to keep the traffic and memory size reasonable. The UploadBox control permits to upload files without any size limitations. Also, you can limit or permit the capacity of the files to be uploaded. For this, the **SizeFilter** property must be set.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                            |
|                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                             |
| [uploadbox1.SizeFilter = 2;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                             |
| [uploadbox1.UploadFolder = [\"C:\\\\Inetpub\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                       |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uploadbox1.SizeFilter = 2]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                       |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uploadbox1.UploadFolder = [\"C:\\\\Inetpub\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Hiding the Submit button

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **Submit** or the **Upload** button can be hidden by disabling the **ShowSubmitButton** property. This allows you to use any ASP.NET button to be used for uploading the files.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------ -----------------------------------------------------------------------------------------------------------
  Property           Description
  ShowSubmitButton   Gets / sets the boolean value, whether to show or hide the default Upload button. Default value is False.
  ------------------ -----------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                  |
|                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                        |
|                                                                                                   |
| [uploadbox1.ShowSubmitButton = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                            |
|                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uploadbox1.ShowSubmitButton = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PostBackOnUpload

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

When an aspx page contains UploadBox without UploadProgress, user can click Upload button or any button for uploading the file. The file needs to be uploaded on PostBack. This property should be used when triggers for UploadBox is used.

 

###### 5.8.2.2.1.1 Customizing the text in UploadProgress {#customizing-the-text-in-uploadprogress style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The progress text  can be customized using the following properties of the UploadProgress control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+---------------------------------------------------+---------------------------------------------------+
| Property              | Description                                                                                           |
+-----------------------+-------------------------------------------------------------------------------------------------------+
| BeforeProgressText    | Text that will be displayed when data starts to upload.                                               |
|                       |                                                                                                       |
|                       | Default value is \'Upload Started\...\'.                                                              |
+-----------------------+-------------------------------------------------------------------------------------------------------+
| ProgressText          | Specifies the format string to set template text when data is uploading.                              |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       | Default value is \'{currentsize}/{totalsize}; {percentage} uploaded as {speed}; {timeleft} left\'.    |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       | Keys that can be used for customizing the progress text are given below.                              |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | Keys                                              | Description                                       |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {currentsize}                                     | Represents number of read bytes.                  |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {totalsize}                                       | Represents number of full size for upload.        |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {percentage}                                      | Represents percent  of completed upload (%).      |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {speed}                                           | Represents upload speed.                          |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {timeleft}                                        | Represents remaining time for upload process.     |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {timeelapsed}                                     | Represents elapsed time for upload process.       |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {timeestimated}                                   | Represents estimating time for upload process.    |
+-----------------------+---------------------------------------------------+---------------------------------------------------+
| AfterProgressText     | Specifies the format string to set template text when uploading process is done.                      |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       | Default value is \'File(s) uploaded: {size} at {speed} took {timetook}\'.                             |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       |                                                                                                       |
|                       | You can use the following keys for displaying progress text when upload process is completed.         |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | Keys                                              | Description                                       |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {size}                                            | Represents number of full size for upload.        |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {speed}                                           | Represents upload speed.                          |
|                       +---------------------------------------------------+---------------------------------------------------+
|                       | {timetook}                                        | Represents elapsed time for upload process.       |
+-----------------------+---------------------------------------------------+---------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[cc1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[UploadBox]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [ID]{style="COLOR: red"}[=\"UploadBox1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [ [\<]{style="COLOR: blue"}[cc1]{style="COLOR: maroon"}[:]{style="COLOR: blue"}[UploadProgress]{style="COLOR: maroon"} [ID]{style="COLOR: red"}[=\"UploadProgress1\"]{style="COLOR: blue"} [Triggers]{style="COLOR: red"}[=\"UploadBox1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} **[BeforeProgressText]{style="COLOR: red"}[=\"0% (in progress)\"]{style="COLOR: blue"}** **[ProgressText]{style="COLOR: red"}[=\"{percentage} (in progress)\"]{style="COLOR: blue"} [AfterProgressText]{style="COLOR: red"}[=\"100% (completed)\"]{style="COLOR: blue"}**[\>\</]{style="COLOR: blue"}[cc1]{style="COLOR: maroon"}[:]{style="COLOR: blue"}[UploadProgress]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::::
