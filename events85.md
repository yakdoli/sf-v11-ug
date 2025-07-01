::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=cf35ed4b-9aed-4b29-af74-c33719fe1a6b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f7d6105a-4133-487d-af87-1bcfb7d92569){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows Phone](ms-xhelp:///?Id=5ea1999c-4eff-4775-b84e-407dc825f555){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=fe4335c8-1cb6-47a4-a6f3-e9bc318bba8d){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[ShapeFileLayer](ms-xhelp:///?Id=eb430cc3-4639-467e-a54d-f223e1266aff){.d2h_breadcrumbsNormal}
:::

### Events {#events style="tab-stops: 0pt"}

 

Table 7: ShapeFileLayer Events

::: {align="center"}
  Event              Description                                   Arguments                                                 Type     Reference links
  ------------------ --------------------------------------------- --------------------------------------------------------- -------- -----------------------------------------------------------------------------------------
  PreviewZoomIn      Triggered before zooming-in the Map           Double Latitude,Double Longitude, and Double ZoomFactor   Event    [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=2bfa12de-acd6-4f09-b2fd-181bd8eed66a)
  PreviewZoomOut     Triggered before zooming-out the Map          Double Latitude,Double Longitude, and Double ZoomFactor   Event    [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=e5a26ec4-1d33-4adb-a141-3faae855f892)
  ZoomedIn           Triggered after Map is zoomed-in              Double Latitude,Double Longitude, and Double ZoomFactor    Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=7c10b224-a4ea-4fc9-9001-14a1ae81e83b)
  ZoomedOut          Triggered after Map is zoomed-out             Double Latitude,Double Longitude, and Double ZoomFactor   Event    [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=7c10b224-a4ea-4fc9-9001-14a1ae81e83b)
  Panning            Triggered while panning the Map               Double Latitude,Double Longitude, and PanMode             Event    [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=8c8e64fd-3f7c-49b7-9da4-ead03a407645)
  Panned             Triggered after panning the Map               Double Latitude,Double Longitude, and PanMode             Event    [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=8c8e64fd-3f7c-49b7-9da4-ead03a407645)
  SelectionChanged   Triggered when Selection changes in the Map   List RemovedItems, and List AddedItems                    Event    [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=b0ff40c1-1de5-47db-a178-653b0a5beaa4)
:::

 

 

 

[]{#related-topics}
:::::
