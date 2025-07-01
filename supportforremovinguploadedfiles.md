::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Support for removing uploaded files {#support-for-removing-uploaded-files style="tab-stops: 0pt"}

This feature allows you to remove the files that have been uploaded.

**Action Method implemented**

+--------------+---------------------------------------------------------------------------------------------------+----------------------+----------------------+----------------+
| **Name**     | **Description**                                                                                   | **Type of property** | **Value it accepts** | **Dependency** |
+--------------+---------------------------------------------------------------------------------------------------+----------------------+----------------------+----------------+
| RemoveAction | This is the action method that is used to remove the files that have been uploaded to the server. | ActionMethod         | Controller           | NA             |
|              |                                                                                                   |                      |                      |                |
|              |                                                                                                   |                      | Action               |                |
+--------------+---------------------------------------------------------------------------------------------------+----------------------+----------------------+----------------+

[[[]{style="TEXT-DECORATION: none"}]{style="COLOR: blue"}]{.underline} 

You can remove files that have been uploaded by making use of the following code snippets:

Using Builder

The following steps guide you in configuring the **[RemoveAction ]{style="BACKGROUND: white; COLOR: black"}**through Builder.

1.   In **View**, [invoke the UploadBox helper with the ]{style="BACKGROUND: white; COLOR: black"}UploadBox**[ id]{style="BACKGROUND: white; COLOR: black"}**[ as the first argument followed by the **RemoveAction** in the AsyncUpload.]{style="BACKGROUND: white; COLOR: black"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Html.Syncfusion().UploadBox([\"upload\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                 |
| [    .AllowMultipleFiles([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                 |
| [    .AsyncUpload(]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                 |
| [        a =\> ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                 |
| [            a.SaveAction([\"Save\"]{style="COLOR: #a31515"},[\"uploadbox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                                                 |
| **[                .RemoveAction([\"Remove\"]{style="COLOR: #a31515"}, [\"uploadbox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                          |
|                                                                                                                                                                                                                                                                 |
| [            .AutoUpload([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                 |
| [              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                 |
| [         )]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                 |
| [    .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune)[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                      |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[Html.Syncfusion().UploadBox([\"upload\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| [    .AllowMultipleFiles([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                      |
| [    .AsyncUpload(]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                      |
| [        a =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                      |
| [            a.SaveAction([\"Save\"]{style="COLOR: #a31515"}, [\"UploadBox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                      |
| **[            .RemoveAction([\"Remove\"]{style="COLOR: #a31515"}, [\"UploadBox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                   |
|                                                                                                                                                                      |
| [            .AutoUpload([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                      |
| [         )]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                      |
| [    .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

2.   In the controller, define the ActionMethod. This is the code snippet for Action Method:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                              |
| [   [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Remove([string]{style="COLOR: blue"}\[\] fileNames)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                              |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                              |
| [            [foreach]{style="COLOR: blue"} ([var]{style="COLOR: blue"} fullName [in]{style="COLOR: blue"} fileNames)]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                              |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                              |
| [                [var]{style="COLOR: blue"} fileName = [Path]{style="COLOR: #2b91af"}.GetFileName(fullName);]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                              |
| [                [var]{style="COLOR: blue"} physicalPath = [Path]{style="COLOR: #2b91af"}.Combine(Server.MapPath([\"\~/App_Data\"]{style="COLOR: #a31515"}), fileName);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| [                [if]{style="COLOR: blue"} (System.IO.[File]{style="COLOR: #2b91af"}.Exists(physicalPath))]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                              |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                              |
| [                    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                              |
| [                    [System.IO.File.Delete(physicalPath);]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                              |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                              |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                              |
| [            [// Return an empty string to signify success]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                              |
| [            [return]{style="COLOR: blue"} Content([\"\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                              |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

**[Using Properties Model]{style="COLOR: black"}**

[The following steps will guide you in setting RemoveAction, through the Properties model:]{style="COLOR: black"}

1.   In the **Controller**, create an instance of UploadBoxModel, define the **RemoveAction** method and pass the instance through view-specific data to View as given below:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                           |
| [    [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                           |
| [            [UploadBoxModel]{style="COLOR: #2b91af"} model = [new]{style="COLOR: blue"} [UploadBoxModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [            [AsyncUpload]{style="COLOR: #2b91af"} async = [new]{style="COLOR: blue"} [AsyncUpload]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                           |
| [            async.AutoUpload = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                           |
| [            async.SaveAction = [\"Home/Save\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                           |
| [            async.RemoveAction = [\"Home/Remove\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                           |
| [            model.AsyncUpload = async;]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [            [return]{style="COLOR: blue"} View(model);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

2.   [In **View**, invoke the UploadBox helper with the UploadBox id as the first argument followed by the view data of the **UploadBoxModel** class.]{style="BACKGROUND: white; COLOR: black"}

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [    [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"} Html.Syncfusion().UploadBox([\"uploadbox\"]{style="COLOR: #a31515"}, ([UploadBoxModel]{style="COLOR: #2b91af"})Model) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                    |
| [     [@(]{style="BACKGROUND: yellow"} [new]{style="COLOR: blue"} [HtmlString]{style="COLOR: #2b91af"}(Html.Syncfusion().UploadBox([\"upload\"]{style="COLOR: #a31515"},([UploadBoxModel]{style="COLOR: #2b91af"})Model).ToString())[)]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
|                                                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

[]{#related-topics}
:::
