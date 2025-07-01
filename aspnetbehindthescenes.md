::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=23f678d1-c4de-4fae-adc7-97c1be2b7e35){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4443d53f-761a-4f2d-9b58-b8283964ee9d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Common](ms-xhelp:///?Id=2bfe10b6-fac1-4f91-a173-04db314f10c3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=edacfc75-68a5-4518-870d-ce716c583177){.d2h_breadcrumbsNormal}
:::

## ASP.NET: Behind the Scenes {#asp.net-behind-the-scenes style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This Section discusses the details on how the ASP.NET samples are set up on your machine to run against **Internet Information Services (IIS)** and how the associated scripts and images are picked up during run-time.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Clicking the **View ASP.NET Samples** link in the dashboard opens the ASP.NET Sample Browser. If the machine is not installed with IIS, samples will open from the *FileSystem*. If the machine is IIS installed and working, Syncfusion samples will be configured in IIS as shown below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image67_56.jpg){border="0"}

Figure 52: internet Information Services

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There will be three sets of Virtual Directories created. The directory, **sfsamplebrowser** is the one that points to the ASP.NET Sample Browser; **sfwebsamples** helps to locate the web samples and each sample will have its virtual directories based on the framework supported. The **xml**, **.mdb**, or other data files used in the samples are located in the **Common**\\**Data** folder (C:\\Documents and Settings\\USER NAME\\My Documents\\Syncfusion\\EssentialStudio\\x.x.x.x\\Common\\Data is the default location).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Samples that are using **.mdf** files will be referring to the database from a common external server i.e, samples.syncfusion.com.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

![](ImagesExt/image67_57.jpg){border="0"}

Figure 53:  Permissions for Authenticated Users for the Data Folder

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

 

 

 

 

[]{#related-topics}
::::
