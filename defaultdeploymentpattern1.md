::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3c9a8b3b-17ec-4acf-a6b4-928ff39305e5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=897b7e42-48f0-420b-9b94-0ce283d1a266){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=2c744c01-8051-42d3-a016-a4101609f8c5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Requirements](ms-xhelp:///?Id=680d4842-2c33-4ecc-8dd2-8b301a825935){.d2h_breadcrumbsNormal}
:::

### Default Deployment Pattern {#default-deployment-pattern style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Our installation installs our assemblies in the GAC in your development machine. So, when you drag the grid control onto your form, the assembly references in your application will be setup such that the Syncfusion assemblies will have to be manually deployed in the GAC or in the application bin folder in your target machine.

 

On dragging the grid control, one or more of the following Register tags will be added to the ASPX.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Grid.Grouping.Web, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                       |
| [    Namespace]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Grid.Grouping\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [TagPrefix]{style="COLOR: red"}[=\"syncfusion\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Shared.Web, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                                                                                                                                                                       |
| [    [Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Tools\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"syncfusion\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Shared.Base, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                                                                                                                       |
| [    [Namespace]{style="COLOR: red"}[=\"Syncfusion.Styles\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"cc1\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Grid.Windows, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                                                                                                                                                       |
| [    [Namespace]{style="COLOR: red"}[=\"Syncfusion.Windows.Forms.Grid\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"cc2\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Grouping.Base, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                                                                                                                                                       |
| [    [Namespace]{style="COLOR: red"}[=\"Syncfusion.Grouping\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"cc3\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image71_1.png){border="0"}Note: X.X.X.X in the above code corresponds to the correct version number of the Essential Studio version that you are currently using.

![](ImagesExt/image71_1.png){border="0"}Note: The TagPrefix for Shared.Web and Grid.Grouping.Web assemblies are changed to \"syncfusion\".
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Multiple register tags are added because the types referenced by the grid are defined in more than one assembly.

 

And your app\'s web.config file will include references to a list of Syncfusion assemblies that you will be linking to, as follows:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Web.Config\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[configuration]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                           |
|                                                                                                                                                                                                                                                                         |
| [         [\<]{style="COLOR: blue"}[system.web]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                         |
| [         [\<]{style="COLOR: blue"}[compilation]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [            [\<]{style="COLOR: blue"}[assemblies]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [              [\<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"} [assembly]{style="COLOR: red"}[=\"Syncfusion.Grid.Grouping.Web, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3D67ED1F87D44C89\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                         |
| [              [\<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"} [assembly]{style="COLOR: red"}[=\"Syncfusion.Grid.Windows, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3D67ED1F87D44C89\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                                                                         |
| [              [\<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"} [assembly]{style="COLOR: red"}[=\"Syncfusion.Grouping.Base, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3D67ED1F87D44C89\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                                                                         |
| [              [\<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"} [assembly]{style="COLOR: red"}[=\"Syncfusion.Shared.Base, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3D67ED1F87D44C89\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                                         |
| [              [\<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"} [assembly]{style="COLOR: red"}[=\"Syncfusion.Shared.Web, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3D67ED1F87D44C89\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                                                                                         |
| [              [\<]{style="COLOR: blue"}[add]{style="COLOR: #a31515"} [assembly]{style="COLOR: red"}[=\"Syncfusion.Core, Version=X.X.X.X, Culture=neutral, PublicKeyToken=632609B4D040F6B4\"/\>]{style="COLOR: blue"}      ]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                                                                                         |
| [            [\</]{style="COLOR: blue"}[assemblies]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                                         |
| [         [\</]{style="COLOR: blue"}[compilation]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                                                         |
| [        \...                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                         |
| [        [\</]{style="COLOR: blue"}[system.web]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                         |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[configuration]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image71_1.png){border="0"}Note: X.X.X.X in the above code corresponds to the correct version number of the Essential Studio version that you are currently using.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Also, no assemblies will be copied over to your application\'s bin folder.

 

Now, when it\'s time to deploy your application, there is an additional step you need to perform. You have to ensure that the above referenced assemblies (in your web.config files) are either present in the GAC or in the application\'s bin folder in the deployed server.

 

The above referenced assemblies can be found in our installation usually in the following path:

\"C:\\Program Files\\Syncfusion\\Essential Studio\\***Version Number***\\PrecompiledAssemblies\\2.0\".

[]{#p11} 

[]{#related-topics}
::::::
