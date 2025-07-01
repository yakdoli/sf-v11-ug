::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=024bc795-1c26-4ee7-bab2-3b65365e357e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6bbf413d-ed79-48c8-a932-79d78eb6f0ee){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How To](ms-xhelp:///?Id=af7cbbbd-bb44-4eac-b709-969d57baee73){.d2h_breadcrumbsNormal}
:::

## Support for Label Readability {#support-for-label-readability style="tab-stops: 0pt"}

 

OLAP Chart provides support to either resize the chart to fit within the view area or enable scroll bar while expanding the labels. This enables you to set the label readable.

 

Use Case Scenarios

You can resize the content, if you want to view the entire content in the view area. While resizing the content, it may become illegible due to size. To avoid this you can enable scrollbar.

 

Properties

Table 32: Property Table

::: {align="center"}
  ----------------------- -------------------------------------------------- ------------- --------------- ---------------------
  **Property**            **Description**                                    **Type**      **Data Type**   **Reference links**
  ForceLabelReadability   Resize the control to fit within the view area.    Server side   Boolean         NA
  ----------------------- -------------------------------------------------- ------------- --------------- ---------------------
:::

[]{style="COLOR: #c00000"} 

Setting Label Readability

You can enable scrollbar or resize the content using the *ForceLabelReadability* property. To enable scrollbar, set this to true. By default this is set to true. To resize the content, set this to false.

 

The following code illustrates how to enable scrollbar:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}                                                                      |
|                                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[.OlapClient1.OlapChart.ForceLabelReadability = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                           |
|                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[.OlapClient1.OlapChart.ForceLabelReadability = [True]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![Description: Description: D:\\Task Doc\\UG\\10.1\\BI\\ForceLabelReadability=true.PNG](ImagesExt/image48_59.png){border="0"}

Figure 55: ScrollBar Enabled

 

The following code illustrates how to resize the content:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}                                                                       |
|                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[.OlapClient1.OlapChart.ForceLabelReadability = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapClient1.OlapChart.ForceLabelReadability = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![Description: Description: D:\\Task Doc\\UG\\10.1\\BI\\ForceLabelReadability=false.PNG](ImagesExt/image48_60.png){border="0"}

Figure 56: Content Resized

 

Sample Link

To view the samples:

7.   Open **Syncfusion Dashboard**.

8.   Click **BI \> ASP.NET**.

9.   Click **Run Samples**.

10.  Navigate to **OlapChart \> Zooming and Scrolling \> Zooming and Scrolling Demo**.

 

 

 

[]{#related-topics}
:::::
