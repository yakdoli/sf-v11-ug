::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b7af32d7-3008-49de-b793-95f6e8d36b3c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=41164503-a5a6-481d-83e6-cb97e1e50314){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Common](ms-xhelp:///?Id=2bfe10b6-fac1-4f91-a173-04db314f10c3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=edacfc75-68a5-4518-870d-ce716c583177){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation](ms-xhelp:///?Id=42919f09-7ce5-460d-ab38-60707b419f40){.d2h_breadcrumbsNormal}
:::

### Command Line Install Options {#command-line-install-options style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Syncfusion Essential Studio supports installing the setup through command line. The following steps illustrate this:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Double-click the **Syncfusion Essential Studio Setup** file. The **Syncfusion Essential Studio Unified Installer wizard** opens.

2.   Click **Next**, MSI files will be extracted into the **Temp** folder.

3.   Cancel the wizard.

4.   Run **%temp%.** The **Temp** folder will open. The **EssentialStudio.msi** files will be available in one of the folders.

5.   Copy all the files in the specific folder to a desired location.  Example: D:\\temp

6.   Open the command prompt in administrator mode and pass the following arguments:

 

***msiexec /i \"MSI file path\\EssentialStudio.msi\" TEMPPATH=\"folder path of MSI and cab files\" ADDLOCAL=\"ALL\" PIDKEY=\"product unlock key\" SAMPLEPATH=\"C:\\Syncfusion\\ x.x.x.x \" /qb***

 

Example***: msiexec /i \"D:\\Temp\\EssentialStudio.msi\" TEMPPATH=\"D:\\Temp\" ADDLOCAL=\"ALL\" PIDKEY=\"product unlock key\" SAMPLEPATH=\"C:\\Syncfusion\\x.x.x.x\" /qb***

7.   Setup will be installed.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image67_1.jpg){border="0"}Note: x.x.x.x need to be replaced with the Essential studio version installed in your machine and Product unlock key need to be replaced with the unlock key for that version.
:::

 

[]{#related-topics}
:::::
