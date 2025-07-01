::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7869fe15-d246-40a9-a6ef-f9542a73ad3a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=086a7390-1eda-4645-acf3-897d4aa29feb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=ab523ca4-cfb2-4736-9bef-ec20b3268450){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[ShapeFileLayer](ms-xhelp:///?Id=84918a16-f7ae-4b4b-ba81-cbaad8b096c7){.d2h_breadcrumbsNormal}
:::

### Events {#events style="tab-stops: 0pt"}

 

Table 7: ShapeFileLayer Events

::: {align="center"}
  Event              Description                                   Arguments                                                 Type     Reference links
  ------------------ --------------------------------------------- --------------------------------------------------------- -------- ---------------------------------
  PreviewZoomIn      Triggered before zooming-in the Map           Double Latitude,Double Longitude, and Double ZoomFactor   Event    [Event Mechanism]{.UGHyperlink}
  PreviewZoomOut     Triggered before zooming-out the Map          Double Latitude,Double Longitude, and Double ZoomFactor   Event    [Event Mechanism]{.UGHyperlink}
  ZoomedIn           Triggered after Map is zoomed-in              Double Latitude,Double Longitude, and Double ZoomFactor    Event   [Event Mechanism]{.UGHyperlink}
  ZoomedOut          Triggered after Map is zoomed-out             Double Latitude,Double Longitude, and Double ZoomFactor   Event    [Event Mechanism]{.UGHyperlink}
  Panning            Triggered while panning the Map               Double Latitude,Double Longitude, and PanMode             Event    [Event Mechanism]{.UGHyperlink}
  Panned             Triggered after panning the Map               Double Latitude,Double Longitude, and PanMode             Event    [Event Mechanism]{.UGHyperlink}
  SelectionChanged   Triggered when Selection changes in the Map   List RemovedItems, and List AddedItems                    Event    [Event Mechanism]{.UGHyperlink}
:::

 

 

 

[]{#related-topics}
:::::
