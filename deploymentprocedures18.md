::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=75e777fb-8905-4e8e-9ca4-c594bc164dba){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d67227c0-bba2-4943-acc1-d5c64f70f90b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=3f607c27-8f3d-4a5b-8a95-5631fb6094a3){.d2h_breadcrumbsNormal}
:::

## Deployment Procedures {#deployment-procedures style="tab-stops: 0pt"}

[]{#_CreateNewReport(_)}[]{#_RemoveReport}[]{#_RemoveReport(_)}[]{#_SaveReport}[]{#_SaveReport(_)}[]{#_GetReportStream(_)}Deployment Requirements

 

1.   [[Click here]{style="COLOR: windowtext"}](ms-xhelp:///?Id=23fd32f7-f474-4b3e-801c-a1f9f282bdbb) to refer the list of the software and hardware requirements for deploying the control in your system.

2.   The following dlls are required to be referenced in your application to use the Essential OLAP Client Web.

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Core

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.DocIO.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.XlsIO.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Linq.Base

[]{#_About_OLAP}[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Chart.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Chart.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Olap.Base

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.OlapChart.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.OlapGrid.Web

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.OlapSampleUtils

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Tools.Web

 

Default deployment pattern

 

On installing Essential Studio, the Syncfusion assemblies would be automatically placed in the GAC. So, when you drag and drop the OLAP Client control into a web form, the related assemblies would be automatically added and referred (if and only if they are present in GAC).

On drag and drop, the following register tag would be added to the ASPX page.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: maroon"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.OlapClient.Web, Version=x.x.x.x, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\" ]{style="COLOR: blue"}[Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Client.Olap\"]{style="COLOR: blue"}  [TagPrefix]{style="COLOR: red"}[=\"cc1\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}
  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image45_1.jpg){border="0"}Note: x.x.x.x in the above code snippet refers to the current version of the Essential Studio running in your system.
:::

The application's web.config file would include reference to a list of Syncfusion assemblies related to the control.

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[web.config\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[compilation]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[debug]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[true]{style="COLOR: blue"}\"[\>]{style="COLOR: blue"}\ |
| [          \<]{style="COLOR: blue"}[assemblies]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                               |
| [                  \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Shared.Web, Version=x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Olap.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Tools.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.OlapChart.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.OlapGrid.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Chart.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.DocIO.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.XlsIO.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Chart.Web, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Linq.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Shared.Base, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=3D67ED1F87D44C89]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}\                                                                                                                                                                                                                                |
| [      \<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"}[ ]{style="COLOR: blue"}[assembly]{style="COLOR: red"}[=]{style="COLOR: blue"}\"[Syncfusion.Core, Version= x.x.x.x, Culture=neutral, ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                 |
| [PublicKeyToken=632609B4D040F6B4]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                 |
| [          \</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assemblies]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[compilation]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image45_1.jpg){border="0"}Note: x.x.x.x in the above code snippet refers to the current version of the Essential Studio running in your system.
:::

Now when it\'s time to deploy your application, there is an additional step you need to perform. You have to ensure that the above referenced assemblies (in your web.config files) are either present in the GAC or in the application\'s bin folder.

 

The above referenced assemblies can be found in our installation usually in the following path: \"C:\\Program Files\\Syncfusion\\Essential Studio\\\<Version Number\>\\Assemblies\\\".

 

Fast deployment pattern

 

Alternatively, you can delete the Syncfusion assembly GAC entries in your development machine. Then, when you drag and drop the Syncfusion control on to your form in the designer, the referenced assemblies will be copied over to the application's bin folder and the following entries will be added to your ASPX page:

  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: maroon"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.OlapClient.Web, Version=x.x.x.x, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\" ]{style="COLOR: blue"}[Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Client.Olap\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"cc1\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 9pt"}
  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image45_1.jpg){border="0"}Note: x.x.x.x in the above code snippet refers to the current version of the Essential Studio running in your system.
:::

[]{#related-topics}
:::::::
