::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=9208a652-2221-4cff-9fd1-e090206e20ec){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=274a2e62-432c-48b9-997a-263cf5eb077e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=f0af2fff-6f00-4ca4-85a6-54e41ac5dc96){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[UploadBox Control](ms-xhelp:///?Id=56a5504f-c3b3-4d0d-8de1-b408a3625520){.d2h_breadcrumbsNormal}
:::

### Adding UploadBox control to MVC Tools {#adding-uploadbox-control-to-mvc-tools style="LINE-HEIGHT: 115%; TEXT-INDENT: -36pt; MARGIN: 10pt 0pt 0pt 45pt; tab-stops: 45.0pt"}

 

[In the]{style="COLOR: black"}[ ]{style="COLOR: black"}[Getting Started]{style="COLOR: windowtext"}[ ]{style="COLOR: black"}[section, we discussed how to]{style="COLOR: black"}[ ]{style="COLOR: black"}[create an MVC application]{style="COLOR: windowtext"}[ ]{style="COLOR: black"}[and]{style="COLOR: black"}[ ]{style="COLOR: black"}[add Tools package to the application]{style="COLOR: windowtext"}[. This section guides you to add the Upload Box to an application.]{style="COLOR: black"}

1.   In **View**, invoke the UploadBox helper with the UploadBox id as the first argument followed by the UploadBox's properties and client-side events.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Html.Syncfusion().UploadBox([\"upload\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| [    .AllowMultipleFiles([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                           |
| [    .AsyncUpload(]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                           |
| [        a =\> ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [            a.SaveAction([\"Save\"]{style="COLOR: #a31515"},[\"uploadbox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                           |
| [                .RemoveAction([\"Remove\"]{style="COLOR: #a31515"}, [\"uploadbox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                           |
| [            .AutoUpload([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                           |
| [              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [         )]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                           |
| [    .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune)[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

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
| [            .RemoveAction([\"Remove\"]{style="COLOR: #a31515"}, [\"UploadBox\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                       |
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

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                 |
| [  [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Save([IEnumerable]{style="COLOR: #2b91af"}\<[HttpPostedFileBase]{style="COLOR: #2b91af"}\> upload)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                 |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
| [            [// \"upload\" gets the attached file documents in the page]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                 |
| [            [foreach]{style="COLOR: blue"} ([var]{style="COLOR: blue"} file [in]{style="COLOR: blue"} upload)]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                 |
| [                [// \"file.FileName\" will get the name of the file uploaded. Some browsers send file names with full path ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                 |
| [                [var]{style="COLOR: blue"} fileName = [Path]{style="COLOR: #2b91af"}.GetFileName(file.FileName);]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                 |
| [                [var]{style="COLOR: blue"} destinationPath = [Path]{style="COLOR: #2b91af"}.Combine(Server.MapPath([\"\~/App_Data\"]{style="COLOR: #a31515"}), fileName);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                 |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| [                file.SaveAs(destinationPath);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                 |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                 |
| [                [// Return an empty string to signify success]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                 |
| [            [return]{style="COLOR: blue"} Content([\"\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| [     [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Remove([string]{style="COLOR: blue"}\[\] fileNames)]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                                 |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
| [            [foreach]{style="COLOR: blue"} ([var]{style="COLOR: blue"} fullName [in]{style="COLOR: blue"} fileNames)]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                 |
| [                [var]{style="COLOR: blue"} fileName = [Path]{style="COLOR: #2b91af"}.GetFileName(fullName);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                 |
| [                [var]{style="COLOR: blue"} physicalPath = [Path]{style="COLOR: #2b91af"}.Combine(Server.MapPath([\"\~/App_Data\"]{style="COLOR: #a31515"}), fileName);]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                 |
| [                [if]{style="COLOR: blue"} (System.IO.[File]{style="COLOR: #2b91af"}.Exists(physicalPath))]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                 |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                 |
| [                    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                 |
| [                    System.IO.[File]{style="COLOR: #2b91af"}.Delete(physicalPath);]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                 |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                 |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                 |
| [            [// Return an empty string to signify success]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                 |
| [            [return]{style="COLOR: blue"} Content([\"\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

[2.   Run the application.]{style="COLOR: black"}

[3.   The output will depend on the properties and methods that you use, as shown in the following screenshots:]{style="COLOR: black"}

![Description: Description: C:\\Users\\rubyp\\Documents\\UG\\MVC UGs\\Tools\\File upload control screenshots and codes\\IMG_11082011_060551.png](ImagesExt/image56_358.png){border="0"}

Figure 332: Asynchronous Upload control with the Sandune Skin

 

 

 

[]{#related-topics}
::::
