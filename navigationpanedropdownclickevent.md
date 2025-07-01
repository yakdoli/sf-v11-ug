::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### NavigationPaneDropDownClick Event {#navigationpanedropdownclick-event style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

It occurs when the user clicks on the GroupBar control\'s Navigation Pane DropDown button. This event is applicable for the Stacked GroupBar i.e. the **StackedMode** property of the GroupBar should be set to True. The event handler receives an argument of type NavigationPaneDropDownClickEventArgs containing data related to this event.

 

The following event property is associated with the **NavigationPaneDropDownClickEventArgs**.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------------------- ----------------------------------------------------------------------------------------
  Member                Description
  ContextMenuProvider   Returns the menu provider object used by the GroupBar for creating it\'s context menu.
  --------------------- ----------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} groupBar1_NavigationPaneDropDownClick([object]{style="COLOR: blue"} sender, [NavigationPaneDropDownClickEventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                         |
| [  // NavigationPaneDropDownClick Event has a property called ContextMenuProvider which returns the object   ]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                      |
|                                                                                                                                                                                                                                                                         |
| [// used for creating the context menu.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                         |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\" NavigationPaneDropDownClick Event is raised \"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                                         |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"ContextMenuProvider :\"]{style="COLOR: maroon"} + e.ContextMenuProvider.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} groupBar1_NavigationPaneDropDownClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} NavigationPaneDropDownClickEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                               |
| [// NavigationPaneDropDownClick Event has a property called ContextMenuProvider which returns the object   ]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                               |
| [// used for creating the context menu.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                               |
| [Console.Write([\" NavigationPaneDropDownClick Event is raised \"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                               |
| [Console.Write([\"ContextMenuProvider :\"]{style="COLOR: maroon"} + e.ContextMenuProvider.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                               |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#p624} 

 

[]{#related-topics}
::::
