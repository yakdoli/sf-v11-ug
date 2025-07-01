::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Events {#events style="tab-stops: 0pt"}

 

 

Server side Events

 

A brief overview of the server side events of Treeview are listed below.

 

::: {align="center"}
  ------------------- ----------------------------------------------------------
  Server-Side Event   Description
  NodeCheckChanged    The event that fires on checking the checkbox of a node.
  NodeCollapsed       The event that fires on node collapse.
  NodeDropped         The event that fires on node drop.
  NodeExpanded        The event that fires on node expand.
  NodeRenamed         The event that fires when the node text has been edited.
  NodeSelected        The event that fires upon node selection.
  ------------------- ----------------------------------------------------------
:::

 

Refer [Server side Events]{.UGHyperlink} for more details.

 

Client side Events

 

The brief overview of the client side actions supported in TreeView are listed below.

 

::: {align="center"}
  ------------------------------ ----------------------------------------------------------------------------------------
  Property                       Description
  ClientSideOnContextMenu        Specifies the client side function to call when right clicking on a node.
  ClientSideOnNodeCheckChanged   Specifies the client side function to call when the status of the checkbox is changed.
  ClientSideOnNodeCollapse       Specifies the client side function to call on node collapse.
  ClientSideOnNodeDragStart      Specifies the client side function to call on drag start.
  ClientSideOnNodeDrop           Specifies the client side function to call when the node is dropped.
  ClientSideOnNodeExpand         Specifies the client side function to call on node expand.
  ClientSideOnNodeMove           Specifies the client side function to call when the node is moved.
  ClientSideOnNodeRename         Specifies the client side function to call on node rename.
  ClientSideOnNodeSelect         Specifies the client side function to call on node select.
  ------------------------------ ----------------------------------------------------------------------------------------
:::

 

Refer [Client side Events]{.UGHyperlink} for more details.

 

ExpandMode property

 

The ExpandMode property in the Designer dialog, which can be set for every node in TreeView, raises the client or the server side events according to the value set to the property during node expand.

 

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                                           |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------+
| ExpandMode                        | This mode has three types:                                                                                                            |
|                                   |                                                                                                                                       |
|                                   |                                                                                                                                       |
|                                   |                                                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ClientSide                                                                                      |
|                                   |                                                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ServerSide                                                                                      |
|                                   |                                                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ServerSideCallback                                                                              |
|                                   |                                                                                                                                       |
|                                   |                                                                                                                                       |
|                                   |                                                                                                                                       |
|                                   | If ExpandMode = ExpandMode.ServerSide, postback occurs and the NodeExpanded event will get fired. By default it is set to ClientSide. |
|                                   |                                                                                                                                       |
|                                   |                                                                                                                                       |
|                                   |                                                                                                                                       |
|                                   | If ExpandMode=ExpandMode.ServerSideCallback, callback occurs and allows to dynamically add nodes on demand.                           |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------------------+
:::

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: This should be set appropriately for NodeExpanded sever-side event and ClientSideOnNodeExpand client event.
:::

 

AutoPostBack properties

 

These properties must be set to True to fire the respective server side events. This will perform a postback and refresh the page when the events are fired. These should be set to false to trigger the client side events.

 

::: {align="center"}
  -------------------------------- -----------------------------------------------------------------------------------------------
  Property                         Description
  AutoPostBackOnNodeCheckChanged   Specifies whether to postback the page, when the checkbox is clicked. Default value is False.
  AutoPostBackOnNodeCollapse       Specifies whether to postback the page, when the node is collapsed. Default value is False.
  AutoPostBackOnNodeDrop           Specifies whether to postback the page, when the node is dropped. Default value is False.
  AutoPostBackOnNodeExpand         Specifies whether to postback the page, when the node is expanded. Default value is False.
  AutoPostBackOnNodeRename         Specifies whether to postback the page, when the node is renamed. Default value is False.
  AutoPostBackOnNodeSelect         Specifies whether to postback the page, when the node is selected. Default value is False.
  StatusBarText                    Specifies the text to be displayed on the status bar of the browser during callback.
  -------------------------------- -----------------------------------------------------------------------------------------------
:::

 

The following properties can be set for individual tree nodes of the control and thereby control the behavior of the nodes as required.

 

::: {align="center"}
  ---------------------------- -------------------------------------------------------------------------------------------------
  Item Property                Description
  AutoPostBackOnCheckChanged   Specifies whether to postback the page, when the checkbox is clicked. Default value is Inherit.
  AutoPostBackOnNodeDrop       Specifies whether to postback the page, when the node is dropped. Default value is Inherit.
  AutoPostBackOnNodeSelect     Specifies whether to postback the page, when the node is selected. Default value is Inherit.
  ---------------------------- -------------------------------------------------------------------------------------------------
:::

[]{#p301} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server-Side Events](ms-xhelp:///?Id=b2f6ee0f-1bc4-4f7f-9fd5-f861c8505967){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Client-Side Events](ms-xhelp:///?Id=cf34982d-1899-4147-b7b5-764a8f34d0de){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}AJAX support](ms-xhelp:///?Id=65a2ca7a-9e7a-4641-b8c2-cfa087a415ff){style="TEXT-DECORATION: none"}
:::::::::
