::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=bfd1a7d7-ad71-48f2-81f3-be489206548a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=db08ebda-40b3-4965-b3be-d17da194e2f1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=2c744c01-8051-42d3-a016-a4101609f8c5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Requirements](ms-xhelp:///?Id=680d4842-2c33-4ecc-8dd2-8b301a825935){.d2h_breadcrumbsNormal}
:::

### Alternate Super Fast Deployment Pattern {#alternate-super-fast-deployment-pattern style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Alternatively, you can delete the Syncfusion assembly GAC entries in the your development machine. Then, when you drag the Syncfusion controls on to your form in the designer, the referenced assemblies will be copied over to the bin folder, and the following entries will be added to your aspx.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}                                                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Grid.Grouping.Web\"]{style="COLOR: blue"} [Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Grid.Grouping\" ]{style="COLOR: blue"}[TagPrefix]{style="COLOR: red"}[=\"syncfusion\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Shared.Web\"]{style="COLOR: blue"} [Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.Tools\" ]{style="COLOR: blue"}[TagPrefix]{style="COLOR: red"}[=\"syncfusion\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Shared.Base\"]{style="COLOR: blue"} [Namespace]{style="COLOR: red"}[=\"Syncfusion.Styles\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"cc1\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Grid.Windows\"]{style="COLOR: blue"} [Namespace]{style="COLOR: red"}[=\"Syncfusion.Windows.Forms.Grid\" ]{style="COLOR: blue"}[TagPrefix]{style="COLOR: red"}[=\"cc2\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #ffee62"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: #a31515"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Grouping.Base\"]{style="COLOR: blue"} [Namespace]{style="COLOR: red"}[=\"Syncfusion.Grouping\" ]{style="COLOR: blue"}[TagPrefix]{style="COLOR: red"}[=\"cc3\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: #ffee62"}]{style="FONT-FAMILY: 'Courier New'"}                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

With this setup, you can deploy your application as is using the VS .NET deployment tools as the necessary dlls are already copied over to the bin folder.

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Data Files

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

If you have XML, .mdb or other data files, ensure that they have sufficient security permissions. The **Authenticated Users** should have access to the files and the directory to give the ASP.NET code enough permission to open the file at runtime.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Supporting Netscape / FireFox / Mozilla

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Ensure that the machine.config\'s (of the deployed system) \<browsercaps\> section includes appropriate entries for Mozilla, and so on. The default entries deem these browsers as **downlevel** and hence will not render Syncfusion and your controls properly.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Deploying in Medium Trust or Partial Trust Scenarios

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There are two such scenarios in which Syncfusion assemblies might be deployed.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Syncfusion Assemblies in the GAC (Global Assembly Cache) and Application running in medium trust.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This means the Syncfusion assemblies are running in full trust. This scenario is fully supported and there are no additional steps necessary.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   Syncfusion Assemblies in the application bin folder and Application running in medium trust.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This means both the Syncfusion assemblies and the application code are running in partial trust. In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This will also mean some features might not be available. See control\'s documentation for more info.

[]{#related-topics}
::::
