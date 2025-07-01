::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=015a4fc7-7223-44cb-9eeb-ea2c031dbc29){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ef9953ef-4c51-4cd7-9031-a15680b4e9a7){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}
:::

## Printing {#printing style="tab-stops: 0pt"}

Essential Chart supports the printing feature. This can be done by using the ServerSide properties and the client-side methods.

The printing functionality can be enabled in the server-side by using the **PrintButtonVisible** property.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Properties:

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
+----------------------+----------------------------------------------------------+-----------------------------+------------------------------+--------------------------------------------------+
| Property             | Description                                              | Property Type               | Value it Accepts             | Any Other Dependencies/Sub-properties Associated |
+----------------------+----------------------------------------------------------+-----------------------------+------------------------------+--------------------------------------------------+
| PrintButtonVisible   | Used to set the visibility of the Print button.          | [bool]{style="COLOR: blue"} | [True ]{style="COLOR: blue"} | [NA]{style="COLOR: #558ed5"}                     |
|                      |                                                          |                             |                              |                                                  |
|                      |                                                          |                             | []{style="COLOR: blue"}      |                                                  |
|                      |                                                          |                             |                              |                                                  |
|                      |                                                          |                             | [False]{style="COLOR: blue"} |                                                  |
+----------------------+----------------------------------------------------------+-----------------------------+------------------------------+--------------------------------------------------+
| PrintButtonDraggable | Used to enable the dragging feature of the Print button. | [bool]{style="COLOR: blue"} | [True ]{style="COLOR: blue"} | [NA]{style="COLOR: #558ed5"}                     |
|                      |                                                          |                             |                              |                                                  |
|                      |                                                          |                             | []{style="COLOR: blue"}      |                                                  |
|                      |                                                          |                             |                              |                                                  |
|                      |                                                          |                             | [False]{style="COLOR: blue"} |                                                  |
|                      |                                                          |                             |                              |                                                  |
|                      |                                                          |                             | []{style="COLOR: blue"}      |                                                  |
+----------------------+----------------------------------------------------------+-----------------------------+------------------------------+--------------------------------------------------+
:::

 

The printing functionality can be enabled in the client-side by using the **PrintingImage** function.

 

Client-side Methods

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {align="center"}
  --------------- -------------------------------------------------------- -------------------------------------------------------- -----------------------------------------------------------------------
  Name            Parameters                                               Return Type                                              Description[]{style="COLOR: black"}
  PrintingImage   [None]{style="COLOR: black"}[]{style="COLOR: #558ed5"}   [None]{style="COLOR: black"}[]{style="COLOR: #1f497d"}   [This property is used for printing the chart.]{style="COLOR: black"}
  --------------- -------------------------------------------------------- -------------------------------------------------------- -----------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The printing feature can be enabled in a chart through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Builder](ms-xhelp:///?Id=ef9953ef-4c51-4cd7-9031-a15680b4e9a7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ChartModel](ms-xhelp:///?Id=962d155f-9a5d-4583-8d60-3ab53bc5effe){style="TEXT-DECORATION: none"}
::::::
