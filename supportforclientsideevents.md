::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Support for client-side events {#support-for-client-side-events style="tab-stops: 0pt"}

Refer to the [Client-side events table]{style="FONT-FAMILY: 'Arial','sans-serif'"} to understand the basics of the events used in this Control.

You can handle client-side events using the following two ways-

 

Using Builder

The following steps guide in handling client side events through Builder:

1.   In **View**, [invoke the UploadBox helper with the **UploadBox id** as the first argument followed by the **Client side events**.]{style="BACKGROUND: white; COLOR: black"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: black; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                 |
| [  [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"} Html.Syncfusion().UploadBox(\"upload\")]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [                             .AsyncUpload]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                 |
| [                             (]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                 |
| [                                 s =\> s.AutoUpload(true)]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                 |
| [                                     .SaveAction(\"Save\", \"UploadBox\")]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                 |
| [                                     .RemoveAction(\"Remove\",\"UploadBox\")]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                 |
| [                             )]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                 |
| [                    .ClientSideOnLoad(\"onLoad\") ]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                 |
| [                    .ClientSideOnCancel(\"onCancel\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                 |
| [                    .ClientSideOnComplete(\"onComplete\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                 |
| [                    .ClientSideOnError(\"onError\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                 |
| [                    .ClientSideOnRemove(\"onRemove\") ]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                 |
| [                    .ClientSideOnSelect(\"onSelect\") ]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                 |
| [                    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                 |
| [                    .ClientSideOnUpload(\"onUpload\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                 |
| [                                                    .AutoFormat(Skins.Sandune).ExtensionsAllow(\".zip,.png,.JPEG,.jpeg,.PNG\") ]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                 |
| [        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                    |
| [   [\@{]{style="BACKGROUND: yellow"}  Html.Syncfusion().UploadBox([\"upload\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                    |
| [                             .AsyncUpload]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| [                             (]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                    |
| [                                 s =\> s.AutoUpload([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                                    |
| [                                     .SaveAction([\"Save\"]{style="COLOR: #a31515"}, [\"UploadBox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                    |
| [                                     .RemoveAction([\"Remove\"]{style="COLOR: #a31515"}, [\"UploadBox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                                    |
| [                             )]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                    |
| [                             .ClientSideOnLoad([\"onLoad\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                    |
| [                    .ClientSideOnCancel([\"onCancel\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                    |
| [                    .ClientSideOnComplete([\"onComplete\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                    |
| [                    .ClientSideOnError([\"onError\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                    |
| [                    .ClientSideOnRemove([\"onRemove\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                                    |
| [                    .ClientSideOnSelect([\"onSelect\"]{style="COLOR: #a31515"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [                                .ClientSideOnUpload([\"onUpload\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                    |
| [                                                    .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune).ExtensionsAllow([\".zip,.png,.JPEG,.jpeg,.PNG\"]{style="COLOR: #a31515"}).Render();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| [        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

2.   [In Javascript, use the methods to enable and disable an item ]{style="BACKGROUND: white; COLOR: black"}as[ follows:]{style="BACKGROUND: white; COLOR: black"}

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                            |
| [  [function]{style="COLOR: blue"} onLoad(evt) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                            |
| [         ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [          [//ClientSideOnLoad event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onCancel(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| [            [//ClientSideOnCancel event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| [         ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onComplete(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} file = evt.files;]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                            |
| [            [//ClientSideOnComplete event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(file).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| **[        [function]{style="COLOR: blue"} onError(evt, control) {]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                                                                            |
| **[            [// You can handle the Extension violation in the On Error event]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}**                          |
|                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                 |
|                                                                                                                                                                            |
| **[            [//On Error event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                                            |
| **[            [if]{style="COLOR: blue"} (evt.action == [\"ExtensionsDeny\"]{style="COLOR: maroon"}) {]{style="FONT-FAMILY: 'Courier New'"}**                              |
|                                                                                                                                                                            |
| **[                alert([\"Denied Extension are \"]{style="COLOR: maroon"} + control.get_ExtensionsDeny());]{style="FONT-FAMILY: 'Courier New'"}**                        |
|                                                                                                                                                                            |
| **[            }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                            |
| **[            [else]{style="COLOR: blue"} [if]{style="COLOR: blue"} (evt.action == [\"ExtensionsAllow\"]{style="COLOR: maroon"}) {]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                                            |
| **[                alert([\"Allowed Extension are \"]{style="COLOR: maroon"} + control.get_ExtensionsAllow());]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                                                                                                                            |
| **[            }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                            |
| **[            [else]{style="COLOR: blue"} [if]{style="COLOR: blue"} (evt.action == [\"Error\"]{style="COLOR: maroon"}) {]{style="FONT-FAMILY: 'Courier New'"}**           |
|                                                                                                                                                                            |
| **[                [var]{style="COLOR: blue"} file = evt.files;]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                                                                            |
| **[                [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}**                                            |
|                                                                                                                                                                            |
| **[                \$(file).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                                            |
| **[                    filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}**            |
|                                                                                                                                                                            |
| **[                });]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                 |
|                                                                                                                                                                            |
| **[            }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                            |
| **[           ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                            |
| **[        }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onRemove(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| [            [//ClientSideOnRemove event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onSelect(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| [            [//ClientSideOnSelect event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onUpload(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [//ClientSideOnUpload event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: black; FONT-SIZE: 12pt"} 

Using Properties Model

[The following steps guide in handling client side events through the Properties model.]{style="COLOR: black"}

1.   [In Controller, create an object for the **UploadBoxModel** class and set the **ClientSide Events**. Assign this model class to view data.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [     [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                           |
| [            [UploadBoxModel]{style="COLOR: #2b91af"} model = [new]{style="COLOR: blue"} [UploadBoxModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [            model.ClientSideOnCancel = [\"onLoad\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                           |
| [            \...\...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                           |
| [            [return]{style="COLOR: blue"} View(model);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[2.   [In **View**, invoke the UploadBox helper with the UploadBox id as the first argument followed by the view data of the **UploadBoxModel** class.]{style="BACKGROUND: white"}]{style="COLOR: black"}

[]{style="COLOR: black"} 

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

3.   [In **Javascript**, define the function to handle the specified events.]{style="BACKGROUND: white; COLOR: black"}

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                            |
| [  [function]{style="COLOR: blue"} onLoad(evt) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                            |
| [         ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [          [//ClientSideOnLoad event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onCancel(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| [            [//ClientSideOnCancel event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| [         ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onComplete(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} file = evt.files;]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                            |
| [            [//ClientSideOnComplete event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(file).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| **[        [function]{style="COLOR: blue"} onError(evt, control) {]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                                                                            |
| **[            [// You can handle the Extension violation in the On Error event]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}**                          |
|                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                 |
|                                                                                                                                                                            |
| **[            [//On Error event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                                            |
| **[            [if]{style="COLOR: blue"} (evt.action == [\"ExtensionsDeny\"]{style="COLOR: maroon"}) {]{style="FONT-FAMILY: 'Courier New'"}**                              |
|                                                                                                                                                                            |
| **[                alert([\"Denied Extension are \"]{style="COLOR: maroon"} + control.get_ExtensionsDeny());]{style="FONT-FAMILY: 'Courier New'"}**                        |
|                                                                                                                                                                            |
| **[            }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                            |
| **[            [else]{style="COLOR: blue"} [if]{style="COLOR: blue"} (evt.action == [\"ExtensionsAllow\"]{style="COLOR: maroon"}) {]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                                            |
| **[                alert([\"Allowed Extension are \"]{style="COLOR: maroon"} + control.get_ExtensionsAllow());]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                                                                                                                            |
| **[            }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                            |
| **[            [else]{style="COLOR: blue"} [if]{style="COLOR: blue"} (evt.action == [\"Error\"]{style="COLOR: maroon"}) {]{style="FONT-FAMILY: 'Courier New'"}**           |
|                                                                                                                                                                            |
| **[                [var]{style="COLOR: blue"} file = evt.files;]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                                                                            |
| **[                [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}**                                            |
|                                                                                                                                                                            |
| **[                \$(file).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                                            |
| **[                    filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}**            |
|                                                                                                                                                                            |
| **[                });]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                 |
|                                                                                                                                                                            |
| **[            }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                            |
| **[           ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                            |
| **[        }]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onRemove(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| [            [//ClientSideOnRemove event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onSelect(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| [            [//ClientSideOnSelect event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [        [function]{style="COLOR: blue"} onUpload(evt) {]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [            [//ClientSideOnUpload event triggered]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                            |
| [            [var]{style="COLOR: blue"} filenames = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                            |
| [            \$(evt).each([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                            |
| [                filenames = filenames + [\"\\nName:\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.name;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                            |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                            |
| [          ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
