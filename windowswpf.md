::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=505d05fd-b830-4da5-bc6a-8b17f1a05b16){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=fbf579ad-7ac1-44a9-bab3-2093df3dfdd0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grouping](ms-xhelp:///?Id=37faf36d-c8f0-4c7d-90e1-39deecb620a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=ec457399-6b46-4e42-8580-a2e2d7df3233){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deploying Essential Grouping](ms-xhelp:///?Id=505d05fd-b830-4da5-bc6a-8b17f1a05b16){.d2h_breadcrumbsNormal}
:::

### Windows / WPF {#windows-wpf style="tab-stops: 0pt"}

 

Now, you have created a Windows / WPF application (refer [[Creating Platform Application]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}](ms-xhelp:///?Id=4020f60c-48c4-4fb2-b37e-9ea7babdc123)). This section will guide you to deploy Essential Grouping in a Windows/WPF applications.

 

Deploying Essential Grouping in a Windows / WPF Application

 

[The following steps will guide you to deploy Essential Grouping:]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

1.   In order to deploy an application that uses the Syncfusion assemblies, the referenced Syncfusion assemblies should reside in the application folder where the exe exists, in the target machine.\
\

2.   In order to do that, go to the **References** folder in the **Solution Explorer**. Select all the Syncfusion assemblies, right-click and go to **Properties.** Change the **Copy Local** property of the Syncfusion assemblies to ***true*** and compile the project.\
\

3.   Check whether the licenses.licx file listed in the project has its **Build Action** property to be ***Embedded Resource***.\
\

4.   Now you may see that the Syncfusion assemblies referenced in the project are copied to the output directory along with the application executable (***bin/debug/***).\
\

5.   Deploy the exe along with the Syncfusion assemblies in that location to the target machine. Be sure that these Syncfusion assemblies reside in the same location as the application exe in the target machine.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image25_1.jpg){border="0"}Note: For Windows Forms applications, placing these referenced Syncfusion assemblies in the GAC alone, in the target machine, will also work.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Dlls needed for deployment

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Core.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Grouping.Base.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Grouping.Windows.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Base.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Windows.dll

 

Essential Grouping is now deployed in your Windows / WPF applications.

 

[]{#related-topics}
:::::
