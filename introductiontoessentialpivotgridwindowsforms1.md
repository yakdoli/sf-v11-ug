::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c7d802e0-0b0d-4895-bf8f-dc4671cfd9bd){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=70fc97ce-d415-4268-9d6a-b3f8e2ae8891){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Windows](ms-xhelp:///?Id=af2b5ead-c104-4cdd-b5e2-2b2aee61afe3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pivot Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Overview](ms-xhelp:///?Id=c7d802e0-0b0d-4895-bf8f-dc4671cfd9bd){.d2h_breadcrumbsNormal}
:::

## Introduction to Essential PivotGrid Windows Forms {#introduction-to-essential-pivotgrid-windows-forms style="tab-stops: 0pt"}

Essential PivotGrid for Windows Forms is a powerful cell-oriented, extensible grid control. It simulates the pivot table feature of Excel. The PivotGrid, as the name implies, pivots data to organize the data in a cross-tabulated form. The major advantage with a pivot grid is that you can extract the desired information from a large list within seconds. Along with presenting the data, a pivot grid also enables you to summarize and group data.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![Description: C:\\Users\\dwarageshmb\\Desktop\\Doc Images\\PivotGrid WPF\\1.png](ImagesExt/image112_0.jpg)

Figure 1: PivotGrid Control

Key Features

Important features of the PivotGrid control are listed below:

 

[·      ]{style="FONT-FAMILY: Symbol"}Multilevel drill up/down capability---row drill-down, column drill-down, multilevel row/column drill-down

[·      ]{style="FONT-FAMILY: Symbol"}Data-binding support

[·      ]{style="FONT-FAMILY: Symbol"}Auto Calculation of total summary

[·      ]{style="FONT-FAMILY: Symbol"}Filters

[·      ]{style="FONT-FAMILY: Symbol"}Grouping support

[·      ]{style="FONT-FAMILY: Symbol"}Sorting

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

User Guide Organization

[]{#_Introduction_to_Essential}This product comes with numerous samples as well as an extensive documentation to guide you. This User Guide provides detailed information on the features and functionalities of the PivotGrid control. It is organized into the following sections:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Overview** - This section gives a brief introduction to our product and its key features.

[·      ]{style="FONT-FAMILY: Symbol"}**Deployment** - This section elaborates on the install location of the samples, license, and so on.

[·      ]{style="FONT-FAMILY: Symbol"}**Getting Started** - This section guides you on getting started with a BI application, PivotGrid control, and so on.

[·      ]{style="FONT-FAMILY: Symbol"}**Concepts and Features** - This section includes features of the PivotGrid control, which are illustrated with use-case scenarios, code examples, and screenshots.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Document Conventions

The following conventions will help you quickly identify the important sections of information while using the content.

Table 1: Conventions Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

::: {align="center"}
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------------------------------------------+
| Convention             | Icon                                                                                                                                                                                                                                                        | Description                                                                |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------------------------------------------+
| Note                   | ::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"} | Represents important information.                                          |
|                        | ![](ImagesExt/image112_1.jpg)Note:                                                                                                                                                                                                                          |                                                                            |
|                        | :::                                                                                                                                                                                                                                                         |                                                                            |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------------------------------------------+
| Example                | **Example**                                                                                                                                                                                                                                                 | Represents an example.                                                     |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------------------------------------------+
| Tip                    | ![Description: C:\\Users\\Hari\\Pictures\\OlapClient\\Tip.png](ImagesExt/image112_2.png)                                                                                                                                                                    | Represents useful hints that will help you in using the controls/features. |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------------------------------------------+
| Additional Information | ![Description: C:\\Users\\Hari\\Pictures\\OlapClient\\Information.png](ImagesExt/image112_3.png)                                                                                                                                                            | Represents additional information on the topic.                            |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------------------------------------------+
:::

[]{#related-topics}
:::::
