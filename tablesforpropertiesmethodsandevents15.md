::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=190daace-8e73-4ee4-aff2-071257803670){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9a1558fe-dce1-4de1-a941-1c23f155d723){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=11705b50-1209-46fb-bfde-18237d32998e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Bing Maps Integration](ms-xhelp:///?Id=719e6afb-52b0-4439-af4d-af1259c08081){.d2h_breadcrumbsNormal}
:::

### Tables for Properties, Methods, and Events {#tables-for-properties-methods-and-events style="tab-stops: 0pt"}

Properties

  ------------------------------------ ---------------------------------------------------------------------- --------------------------------------------- ----------------------------------
  **Property**                         **Description**                                                        **Type**                                      **Data Type**
  [BingMapKey]{style="COLOR: black"}   [Gets or sets the key for enabling Bing Maps.]{style="COLOR: black"}   [Dependency Property]{style="COLOR: black"}   [string]{style="COLOR: black"}
  [ZoomLevel]{style="COLOR: black"}    [Gets or sets the zoom level.]{style="COLOR: black"}                   [Dependency property]{style="COLOR: black"}   [int]{style="COLOR: black"}
  [MapStyle]{style="COLOR: black"}     [Gets or sets the style of the Bing Maps.]{style="COLOR: black"}       [Dependency property]{style="COLOR: black"}   [MapStyle]{style="COLOR: black"}
  ------------------------------------ ---------------------------------------------------------------------- --------------------------------------------- ----------------------------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Methods

[·    ]{style="LINE-HEIGHT: 115%; FONT-FAMILY: Symbol; COLOR: #4e84c4; FONT-SIZE: 13pt"}[]{style="LINE-HEIGHT: 115%; COLOR: #4e84c4; FONT-SIZE: 13pt"}

[\
]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Verdana','sans-serif'; COLOR: #4e84c4; FONT-SIZE: 13pt"}

  **[Method ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Description ]{style="COLOR: black"}**[]{style="COLOR: black"}       **[Parameters ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Type ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Return Type ]{style="COLOR: black"}**[]{style="COLOR: black"}
  ------------------------------------------------------------- ---------------------------------------------------------------------- ----------------------------------------------------------------- ----------------------------------------------------------- ------------------------------------------------------------------
  Zoom[]{style="COLOR: #c00000"}                                This method can be called to zoom the map.[]{style="COLOR: #c00000"}   Double ZoomLevel[]{style="COLOR: #c00000"}                        None[]{style="COLOR: #c00000"}                              None[]{style="COLOR: #c00000"}
  Pan                                                           This method can be called to pan the map.                              Double XCoordinate, Double YCoordinate                            None                                                        None

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Events

  **[Event ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Description ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Arguments ]{style="COLOR: black"}**[]{style="COLOR: black"}                   **[Type ]{style="COLOR: black"}**[]{style="COLOR: black"}
  ------------------------------------------------------------ ------------------------------------------------------------------ -------------------------------------------------------------------------------- -----------------------------------------------------------
  PreviewZoomIn[]{style="COLOR: #c00000"}                      Triggered before zooming in the map.[]{style="COLOR: #c00000"}     Double Latitude, Double Longitude, Double ZoomFactor[]{style="COLOR: #c00000"}   Routed Event[]{style="COLOR: #c00000"}
  PreviewZoomOut                                               Triggered before zooming out the map.                              Double Latitude, Double Longitude, Double ZoomFactor                             Routed Event
  ZoomedIn                                                     Triggered after the map is zoomed in.                              Double Latitude, Double Longitude, Double ZoomFactor                             Routed Event
  ZoomedOut                                                    Triggered after the map is zoomed out.                             Double Latitude, Double Longitude, Double ZoomFactor                             Routed Event
  Panning                                                      Triggered while panning the map.                                   Double Latitude, Double Longitude, PanMode panMode                               Routed Event
  Panned                                                       Triggered after panning the map.                                   Double Latitude, Double Longitude, PanMode panMode                               Routed Event

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}[]{style="COLOR: #c00000"} 

[]{#related-topics}
::::
