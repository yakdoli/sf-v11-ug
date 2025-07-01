::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=21024986-514e-44a9-b1bf-a07647954726){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=26403260-a215-429c-b4fd-11920daa9b1f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=11705b50-1209-46fb-bfde-18237d32998e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[ShapeFileLayer](ms-xhelp:///?Id=042235f6-103b-4399-b456-e0bef81b391a){.d2h_breadcrumbsNormal}
:::

### Events {#events style="tab-stops: 0pt"}

Table 7: ShapeFileLayer Events

::: {align="center"}
  ------------------ --------------------------------------------- --------------------------------------------------------- -------------- -----------------------------------------------------------------------------------------
  Event              Description                                   Arguments                                                 Type           Reference links
  PreviewZoomIn      Triggered before Zooming the Map              Double Latitude,Double Longitude,and  Double ZoomFactor   Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=137e357f-58c1-463b-9fb1-c42a058a7844)
  PreviewZoomOut     Triggered before Zooming out the Map          Double Latitude,Double Longitude, and Double ZoomFactor   Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=50180c40-a655-47f3-a386-a9f35120a8b4)
  ZoomedIn           Triggered after Map ZoomedIn                  Double Latitude,Double Longitude, Double ZoomFactor       Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=9eef4133-7da3-4c17-a048-f5288af76744)
  ZoomedOut          Triggered after Map ZoomedOut                 Double Latitude,Double Longitude, Double ZoomFactor       Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=30e03545-af78-4c8c-aadd-9753e3037808)
  Panning            Triggered while Panning the Map               Double Latitude,Double Longitude,and  PanMode panMode     Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=d3769453-b97e-4075-9d61-3bc8790af194)
  Panned             Triggered after Panned the Map                Double Latitude,Double Longitude,and  PanMode panMode     Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=21b8eb08-0823-4f8b-9761-34ee211ba346)
  SelectionChanged   Triggered when Selection changed in the Map   List RemovedItems, List AddedItems                        Routed Event   [[Event Mechanism]{.UGHyperlink}](ms-xhelp:///?Id=50180c40-a655-47f3-a386-a9f35120a8b4)
  ------------------ --------------------------------------------- --------------------------------------------------------- -------------- -----------------------------------------------------------------------------------------
:::

 

[]{#related-topics}
:::::
