::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5ead3d74-7332-45d2-bb41-b27541379baa){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f810832a-54e9-4056-94b0-6bdb1cc84aee){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Spreadsheet](ms-xhelp:///?Id=25812fa4-b4ea-4485-bbfb-30849a783142){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Spreadsheet WPF]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=a207d091-e74e-42c8-a39f-7445378376c7){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Procedures](ms-xhelp:///?Id=0d92aec2-a773-4427-a5d9-10253c87ab9a){.d2h_breadcrumbsNormal}
:::

### Default Deployment Pattern {#default-deployment-pattern style="TEXT-ALIGN: justify; tab-stops: 0pt"}

The steps involved to deploy the Spreadsheet control for WPF from GAC are as follows:

1.   Open **Visual Studio**.

2.   On the **Solution Explorer**, right-click on the **References** folder and select **Add Reference**.

 

![Description: http://help.syncfusion.com/Ug_101/User%20Interface/WPF/Spreadsheet/ImagesExt/image9_6.png](ImagesExt/image17_6.png){border="0"}

Figure 4: Add Reference

 

3.   The **Add Reference** window will open.

 

 

![Description: http://help.syncfusion.com/Ug_101/User%20Interface/WPF/Spreadsheet/ImagesExt/image9_7.png](ImagesExt/image17_7.png){border="0"}

Figure 5:[ Add Reference window]{style="FONT-STYLE: normal"}

*[]{style="FONT-SIZE: 9pt"}* 

4.   Select the **.NET** tab. A list of assemblies available in GAC will be displayed.

5.   Select the following assemblies:

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Core.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Spreadsheet.WPf.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Grid.WPf.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.GridCommon.WPf.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Linq.Base.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Tools.Wpf.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Wpf.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Compression.Base.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.XlsIO.Base.dll

 

6.   Click **OK**.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: For the .NET client profile application you have to add the Syncfusion.Spreadsheet.Wpf.ClientProfile.dll and Syncfusion.XlsIO.ClientProfile.dll instead of Syncfusion.Spreadsheet.WPf.dll and Syncfusion.XlsIO.Base.dll.
:::

 

[]{#related-topics}
:::::
