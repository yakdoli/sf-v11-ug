::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### NodeEditorValidated Event {#nodeeditorvalidated-event style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

This event is raised after the newly entered text in the Node editor gets stored.

 

**Event Data**

 

The event handler receives an argument of type TreeNodeAdvEditEventArgs containing data related to this event. The following TreeNodeAdvEditEventArgs properties provide information specific to this event.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------- ---------------------------------------------------------
  Members   Description
  Label     Returns the label for the node.
  Node      Returns the TreeNodeAdv that is currently being edited.
  --------- ---------------------------------------------------------
:::

[]{#p999}[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} treeViewAdv1\_[NodeEditorValidated]{style="COLOR: black"}([object]{style="COLOR: blue"} sender, Syncfusion.Windows.Forms.Tools.[TreeNodeAdvEditEventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                |
| [//This prints the label for the node in the output window at run time.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"Label :\"]{style="COLOR: maroon"} + e.Label.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                |
| [//This prints the treenodeadv associated with the event in the output window at run time.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"TreeNodeAdv :\"]{style="COLOR: maroon"} + e.Node.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Private Sub ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[treeViewAdv1\_[NodeEditorValidated(]{style="COLOR: black"}[ByVal]{style="COLOR: blue"}[ sender]{style="COLOR: black"}[ As Object]{style="COLOR: blue"}[, ]{style="COLOR: black"}[ByVal]{style="COLOR: blue"}[ e ]{style="COLOR: black"}[As]{style="COLOR: blue"}[ Syncfusion.Windows.Forms.Tools.]{style="COLOR: black"}[TreeNodeAdvEditEventArgs]{style="COLOR: teal"}[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [  \']{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[This prints the treenodeadv action associated with the event in the output window at run time.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[.Write([\"Label :\"]{style="COLOR: maroon"} + e.Action.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\'This prints the treenodeadv associated with the event in the output window at run time.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[.Write([\"TreeNodeAdv :\"]{style="COLOR: maroon"} + e.Node.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [End Sub]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

[]{#related-topics}
::::
