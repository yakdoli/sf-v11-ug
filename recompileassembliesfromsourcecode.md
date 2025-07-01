::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7ffcd1cb-11ca-4253-8e04-d26824c48821){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2ea58a12-9426-4a63-96b4-89eb80232c2c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=29f9b298-efa8-48aa-a27e-f0fa56e02bb3){.d2h_breadcrumbsNormal}
:::

## Recompile Assemblies from Source Code {#recompile-assemblies-from-source-code style="tab-stops: 0pt"}

The Source code can be recompiled using the following steps:

 

**Recompile Syncfusion.Tools.WPF Source code to get Syncfusion.Tools.WPF.dll**

1.   Open AssemblyInfo.cs file and change UltimateResourceFallbackLocation as MainAssembly \[assembly: NeutralResourcesLanguage (\"en-US\", UltimateResourceFallbackLocation. MainAssembly)\]

2.   Edit the Syncfusion.Tools.WPF.csproj file in Notepad.

3.   Comment out the line with \<UICulture\>en-US\</UICulture\> as \<!\--\<UICulture\>en-US\</UICulture\>\--\> and save the csproj file.

4.   Then open your Syncfusion.Tools.WPF solution file and rebuild the solution.

5.   The recompiled assemblies will be created in bin/Debug folder.

**[]{style="LINE-HEIGHT: 150%; FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Recompile Syncfusion.Tools.WPF Source code to get Syncfusion.Tools.WPF.resources.dll

1.   Open AssemblyInfo.cs file and change UltimateResourceFallbackLocation as Satellite

2.   \[assembly: NeutralResourcesLanguage(\"en-US\", UltimateResourceFallbackLocation.Satellite)\]

3.   Edit the Syncfusion.Tools.WPF.csproj file in Notepad.

4.   UnComment out the line with \<!\--\<UICulture\>en-US\</UICulture\>\--\> as \<UICulture\>en-US\</UICulture\> and save the csproj file.

5.   Then open your Syncfusion.Tools.WPF solution file and rebuild the solution.

6.   The recompiled assemblies will be created in bin/Debug/en-US folder.

[]{#related-topics}
::::
