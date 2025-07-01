::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Slide Scroll Settings {#slide-scroll-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Some fundamental properties we can use in rotation types like **ContentScroll**, **SmoothScroll** and **SlideShow** to potentiate the effects on visual aspects are as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Display start and looping functionalities

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The slides can automatically be started to move through the control, at runtime, by setting the **AutoStart** property. When this property is disabled, then the slides will not rotate until it\'s initiated.

 

The entire set of slides can be repeated, in cycle, by setting the **Loop** property. This repeats the slides without pausing after the first time.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------- -------------------------------------------------------------------------------------------------------------------
  Property    Description
  AutoStart   Specifies whether the scroll should automatically start when the page gets loaded. Default value is true.
  Loop        Specifies whether to repeat the slides after a complete tour of slides has been exhibited. Default value is true.
  ----------- -------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Scroll Behavior

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The scroll effects can be controlled by setting scroll behavior properties.

The direction in which the scroll slide has to proceed can be set through **ScrollDirection** properties that allows the scroll to slide in one of the four directions.

The speed of the scroll can be customized using the **SmoothScrollSpeed** property.

The **ScrollInterval** property allows you to set the duration that you prefer after which the next slide should appear.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                                                                                                                   |
|                                   |                                                                                                                                                                                                   |
| Property                          | Description                                                                                                                                                                                       |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ScrollDirection                   | Specifies the direction of scrolling. The options included are as follows:                                                                                                                        |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Up                                                                                                                                                          |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Down                                                                                                                                                        |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Left                                                                                                                                                        |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Right                                                                                                                                                       |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ScrollInterval                    | Specifies the interval speed of scrolling. For ContentScroll and SmoothScroll, this property should be greater than 0 to scroll the contents. The time interval can be specified in milliseconds. |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SmoothScrollSpeed                 | Specifies the speed of the smooth scroll effect. The options included are as follows:                                                                                                             |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Slow                                                                                                                                                        |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Medium                                                                                                                                                      |
|                                   |                                                                                                                                                                                                   |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Fast                                                                                                                                                        |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Slide pause options

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A slide can be paused on mouse hover by setting the **PauseOnMouseOver** property, which stalls that slide until the mouse is moved away from it.

When a slide is displayed, it could be held back for a certain time frame, before the next slide is displayed, by setting the **SlidePause** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                                                     |
|                                   |                                                                                                                                     |
| Property                          | Description                                                                                                                         |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
| SlidePause                        | Specifies the \'Time Span\' the slide is held before exhibiting the next slide. The time interval can be specified in milliseconds. |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
| PauseOnMouseOver                  | Specifies whether to pause the scroll when the mouse is sustained over the slide.                                                   |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ClientObjectID

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The client object id can be used to access the control only on client side. **ClientObjectId** can effectively be used to refer the control\'s objects when used with Master pages and Callback controls. This client id can be effectively used in such scenarios instead of the default id with which the control have to be denoted, thereby eliminating any such ambiguity with the references.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------------- ------------------------------------------------------------------------
  Property         Description
  ClientObjectID   Specifies the user defined id for accessing the object on client side.
  ---------------- ------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Programmatically the ClientObjectID can be set as follows.

[  ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

+-------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                        |
|                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                     |
|                                                                                                                         |
| [rotator1.ClientObjectID = [\"Custom ID\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+-------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                  |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                               |
|                                                                                                                                                                                                   |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ rotator1.ClientObjectID = [\"Custom ID\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p461} 

[]{#related-topics}
:::::::
