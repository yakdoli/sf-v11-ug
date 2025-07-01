::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d3de6782-3d2e-4b48-a8d4-2c054fae2625){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3c51da15-c47b-4b58-b584-760e95f27b75){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}
:::

## Editing {#editing style="tab-stops: 0pt"}

Essential Diagram offers add, edit, and delete operations for node and line details in a diagram page. This can be achieved by specifying the mapper for save actions in the diagram.[]{style="COLOR: #c00000"}

 

Use Case Scenarios

This feature enables the user to add, update, and delete the data from the diagram page.[]{style="COLOR: #c00000"}

 

Properties

  ----------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------- -------------------------------------------------------------------------------
  **Property**                                                                        **Description**                                                                                                                                                       **Type**                                                                        **Data Type**
  [[SaveMapper]{style="COLOR: black"}]{.apple-style-span}[]{style="COLOR: #c00000"}   [[Gets the function name to save the diagram with added, updated, and deleted nodes and lines.]{style="COLOR: black"}]{.apple-style-span}[]{style="COLOR: #c00000"}   [[Server]{style="COLOR: black"}]{.apple-style-span}[]{style="COLOR: #c00000"}   [[String]{style="COLOR: black"}]{.apple-style-span}[]{style="COLOR: #c00000"}
  ----------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------- -------------------------------------------------------------------------------

 

 

Methods

  **[Method ]{style="LINE-HEIGHT: 115%; COLOR: black"}**[]{style="LINE-HEIGHT: 115%; COLOR: black"}   **[Description ]{style="LINE-HEIGHT: 115%; COLOR: black"}**[]{style="LINE-HEIGHT: 115%; COLOR: black"}   **[Parameters ]{style="LINE-HEIGHT: 115%; COLOR: black"}**[]{style="LINE-HEIGHT: 115%; COLOR: black"}   **[Type ]{style="LINE-HEIGHT: 115%; COLOR: black"}**[]{style="LINE-HEIGHT: 115%; COLOR: black"}   **[Return Type ]{style="LINE-HEIGHT: 115%; COLOR: black"}**[]{style="LINE-HEIGHT: 115%; COLOR: black"}
  --------------------------------------------------------------------------------------------------- -------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------
  addNode[]{style="COLOR: #c00000"}                                                                   Add a node in a diagram.[]{style="COLOR: #c00000"}                                                       Name, text, shape, width, height[]{style="COLOR: #c00000"}                                              Client[]{style="COLOR: #c00000"}                                                                  NA[]{style="COLOR: #c00000"}
  addLine                                                                                             Add a line in a diagram.                                                                                 Name, text, type, linewidth, and line color                                                             Client                                                                                            NA
  save                                                                                                Save the diagram with added, edited, and deleted nodes collection.                                       NA                                                                                                      Client                                                                                            NA

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

[To view the samples:]{style="BACKGROUND: white"}

1.   [Open the Essential Diagram sample browser form the Dashboard. (Refer to the ]{style="BACKGROUND: white"}**[Samples and Locations]{style="BACKGROUND: white"}**[ section).]{style="BACKGROUND: white"}

2.   [Go to the **Editing** tab, and click **CRUD Demo**.]{style="BACKGROUND: white"}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Editing Diagram Page](ms-xhelp:///?Id=3c51da15-c47b-4b58-b584-760e95f27b75){style="TEXT-DECORATION: none"}
::::
