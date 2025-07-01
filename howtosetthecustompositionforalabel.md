::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=1ae2f48d-388d-4e50-a068-9ec22f3b08de){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=15be5dcc-a081-4b93-ae1a-9fba7f2579d0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How To Set the Custom Position For a Label {#how-to-set-the-custom-position-for-a-label style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

We can adjust the label position by setting the **Position** property as \'Custom\'. Then, we have to set the Offset values for the X and Y coordinates to specify the label position.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                           |
|                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                      |
|                                                                                                                                                          |
| [// Setting custom position for a label ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                              |
|                                                                                                                                                          |
| [outerRect.Labels.Add([new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.[Label]{style="COLOR: teal"}()); ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [outerRect.Labels\[0\].Text = [\"Rectangle\"]{style="COLOR: maroon"}; ]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                          |
| [outerRect.Labels\[0\].Position = [Position]{style="COLOR: teal"}.Custom; ]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                          |
| [outerRect.Labels\[0\].OffsetX = 50; ]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                          |
| [outerRect.Labels\[0\].OffsetY= 65; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                               |
|                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                              |
|                                                                                                                                  |
| [\' Setting custom position for a label ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                      |
|                                                                                                                                  |
| [outerRect.Labels.Add([New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.Label()) ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                  |
| [outerRect.Labels(0).Text = [\"Rectangle\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                  |
| [outerRect.Labels(0).Position = Position.Custom ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                  |
| [outerRect.Labels(0).OffsetX = 50 ]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                  |
| [outerRect.Labels(0).OffsetY= 65 ]{style="FONT-FAMILY: 'Courier New'"}                                                           |
+----------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p96} 

 

[]{#related-topics}
::::
