::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=199a9ea2-bf1f-4d0a-ad16-4b23fc1e9fac){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0805e396-dbf2-432a-8c85-ab30e3bf5765){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=78ef7522-5b71-46fb-998a-6bdab307bf83){.d2h_breadcrumbsNormal}
:::

## Deployment Procedures {#deployment-procedures style="tab-stops: 0pt"}

[]{#_CreateNewReport(_)}[]{#_RemoveReport}[]{#_RemoveReport(_)}[]{#_SaveReport}[]{#_SaveReport(_)}[]{#_GetReportStream(_)} 

Deployment Requirements

 

1.   [[Click here]{.UGHyperlink}](ms-xhelp:///?Id=788d01aa-89ec-4754-a503-8a173504d70c) to refer to the list of software and hardware requirements for deploying the control in your system.

2.   The following dlls need to be referenced in your application for using *Essential OLAP Chart Web*.

 

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Core

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.DocIO.Base

[]{#_About_OLAP}[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.XlsIO.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Pdf.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Chart.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Chart.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Olap.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.OlapChart.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.OlapShared.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Tools.Web

 

Default Deployment Pattern

 

On installing Essential Studio, the Syncfusion assemblies would be automatically placed in the GAC. So, when you drag and drop the OLAP Chart control into a web form, the related assemblies would be automatically added and referred (if and only if they are present in GAC).

On drag and drop, add the following register tag to the ASPX page.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: maroon"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.OlapChart.Web, Version=x.x.x.x, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\" ]{style="COLOR: blue"}[Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Chart.Olap\"]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [TagPrefix]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"syncfusion\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image48_1.jpg){border="0"}]{style="COLOR: black"}[Note:]{style="COLOR: black"}[ ]{style="COLOR: black"}x.x.x.x in the above code snippet refers to the current version of the Essential Studio running in your system.
:::

 

The application's web.config file would include reference to a list of Syncfusion assemblies related to the control.

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[web.config\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[compilation]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[debug]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[true]{style="COLOR: blue"}\"[\>]{style="COLOR: blue"}\                                                                       |
| [          \<]{style="COLOR: blue"}[assemblies]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                                     |
| [                  \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Shared.Web, Version=x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Olap.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Tools.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.OlapChart.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [        \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[add]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assembly]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[Syncfusion.OlapShared.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Pdf.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Chart.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.DocIO.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.XlsIO.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Chart.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Shared.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                                                                                      |
| [        \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Core, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [PublicKeyToken=632609B4D040F6B4]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [          \</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assemblies]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[compilation]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image48_1.jpg){border="0"}Note: x.x.x.x in the above code snippet refers to the current version of the Essential Studio running in your system.
:::

At the time of deploying the application, there is an additional step you need to do. You have to ensure that the above referenced assemblies (in your web.config files) are either present in the GAC or in the application\'s bin folder.

 

The above referenced assemblies can be found in our installation usually in the following path: \"C:\\Program Files\\Syncfusion\\Essential Studio\\\<Version Number\>\\Assemblies\\\".

 

Fast Deployment Pattern

 

Alternatively, you can delete the Syncfusion assembly GAC entries in your development machine. Then, when you drag and drop the Syncfusion control on to your form in the designer, the referenced assembliesare copied over to the application's bin folder and the following entries are added to your ASPX page:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: maroon"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.OlapChart.Web, Version=x.x.x.x, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\" ]{style="COLOR: blue"}[Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Chart.Olap\"]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [TagPrefix]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"syncfusion\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 9pt"}                                                                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[]{style="COLOR: black"}*** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image48_1.jpg){border="0"}Note: x.x.x.x in the above code snippet refers to the current version of the Essential Studio running in your system.
:::

[]{#related-topics}
:::::::
