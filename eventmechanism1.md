::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=66e49b64-da64-4d5a-bdc0-f3393e3d0410){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f42a58ff-f8c9-4042-a1df-b5ffc5a5f983){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}
:::

## Event Mechanism {#event-mechanism style="tab-stops: 0pt"}

This section describes the events that are triggered and handled when using Essential Diagram Silverlight.[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

Events for Nodes and Connections

DiagramControl has events, which respond to actions performed on nodes and connections.[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

Event Table

The events that are triggered and handled when using Essential Diagram Silverlight are described in the following tabulation:

Table 17: Events Table

::: {align="center"}
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| Event                                                     | Description                                                   | Arguments                                                                               | Type            |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeClick[]{style="COLOR: #c00000"}                       | Raised when the Node is clicked.\                             | Node - The Node on which the event is raised.[]{style="COLOR: #c00000"}                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.[]{style="COLOR: #c00000"}     |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeDoubleClick                                           | Raised when the Node is double-clicked.\                      | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeStartLabelEdit                                        | Raised when the label editing for the Node has started.\      | NewLabelValue - The new label value.                                                    | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | OldLabelValue - The old label value.                                                    |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | Node - The Node on which the event is raised.                                           |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeLabelChanged                                          | Raised when the Node\'s label value is changed.\              | NewLabelValue - The new label value.                                                    | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | OldLabelValue - The old label value.                                                    |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | Node - The Node on which the event is raised.                                           |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeDragStart                                             | Raised when the Node is dragged.\                             | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeDragEnd                                               | Raised when the drag operation on the Node is completed.      | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           |                                                               |                                                                                         |                 |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeResizing                                              | Raised when the resize operation is being performed.\         | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeResized                                               | Raised after the Node is resized.\                            | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeRotationChanging                                      | Raised when the Node is being rotated.\                       | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeRotationChanged                                       | Raised after the Node is rotated.\                            | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorDoubleClick                                      | Raised when the Connector is double-clicked.\                 | Connector - The Connector on which the event is raised.                                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | HeadNode - The HeadNode of the Connector.                                               |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | TailNode - The TailNode of the Connector.                                               |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorStartLabelEdit                                   | Raised when the label editing for the Connector has started.\ | Connector - The Connector on which the event is raised.                                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               | HeadNode - The HeadNode of the Connector.                                               |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | TailNode - The TailNode of the Connector.                                               |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | OldLabelValue - The old label value.                                                    |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorLabelChanged                                     | Raised when the Connector\'s label value is changed.\         | Connector - The Connector on which the event is raised.                                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               | HeadNode - The HeadNode of the Connector.                                               |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | TailNode - The TailNode of the Connector.                                               |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | OldLabelValue - The old label value.                                                    |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | NewLabelValue - The new label value.                                                    |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorDragStart                                        | Raised when either end of the Connector is dragged.\          | Connector - The Connector on which the event is raised.                                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | FixedNodeEnd - The Node on which the Connector is fixed.                                |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | MovableNodeEnd - The old Node on which the Connector was connected.                     |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorDragEnd                                          | Raised when the drag operation is completed.\                 | Connector - The Connector on which the event is raised.                                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | FixedNodeEnd - The Node on which the Connector is fixed.                                |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | HitNodeEnd - The new Node on which the Connector is getting connected.                  |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeDrop                                                  | Raised when a shape from SymbolPalette is dropped on a page.\ | DroppedNode - The new Node that is dropped from SymbolPalette.                          | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | SymbolPaletteItemName - The name of the SymbolPalette item, which is dropped on a page. |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| HeadNodeChanged                                           | Raised when the HeadNode of the Connector is changed.\        | Connector - The Connector for which the HeadNode is changed.                            | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | PreviousNode - The old Node on which the HeadNode of the Connector was connected.       |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | CurrentNode - The new Node on which the HeadNode of the Connector is connected.         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| TailNodeChanged                                           | Raised when the TailNode of the Connector is changed.\        | Connector - The Connector for which the HeadNode is changed.                            | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | PreviousNode - The old Node on which the TailNode of the Connector was connected.       |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | CurrentNode - The new Node on which the TailNode of the Connector is connected.         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorDrop                                             | Raised when the Connector is dropped on a page.\              | DroppedConnector - The Connector on which the event is raised.                          | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| BeforeConnectionCreate                                    | Raised when a new connection is being made.\                  | Connector - The Connector for which the HeadNode is changed.                            | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| AfterConnectionCreate                                     | Raised after the connection is made.\                         | Connector - The Connector on which the event is raised.                                 | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | FixedNodeEnd - The Node on which the Connector is fixed.                                |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | HitNodeEnd - The new Node on which the Connector is getting connected.                  |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeSelected                                              | Raised when a Node is selected.\                              | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeUnSelected                                            | Raised when a Node is not selected.\                          | Node - The Node on which the event is raised.                                           | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeDeleting                                              | Raised before a Node is deleted from the model.\              | DeletedNode - The Node, which is going to be deleted.                                   | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeDeleted                                               | Raised when a Node is deleted from the model.\                | DeletedNode - The Node, which is deleted.                                               | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorDeleting                                         | Raised before a LineConnector is deleted from the model.\     | DeletedLineConnector - The LineConnector, which is being deleted.                       | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| ConnectorDeleted                                          | Raised when a LineConnector is deleted from the model.\       | DeletedLineConnector - The LineConnector, which is deleted.                             | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| PreviewNodeDrop                                           | Raised before a Node is dropped on a page.\                   | Node -- The Node on which the event is raised.                                          | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| PreviewConnectorDrop                                      | Raised before a Connector is dropped on a page.\              | Connector -- The Connector on which the event is raised.                                | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
+-----------------------------------------------------------+---------------------------------------------------------------+-----------------------------------------------------------------------------------------+-----------------+
| NodeMoved                                                 | Raised when the nudge operation on the Node is completed.\    | Node -- The Node on which the event is raised.                                          | RoutedEvent     |
|                                                           | This event cannot be cancelled.                               |                                                                                         |                 |
| (Event is fired before the nudge operation is completed.) |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | oldOffset -- The old offset value before the nudge operation.                           |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               |                                                                                         |                 |
|                                                           |                                                               | newOffset -- The new offset value after performing the nudge operation.                 |                 |
+===========================================================+===============================================================+=========================================================================================+=================+
:::

 

Examples: 

The events that are triggered and handled while using Essential Diagram for Silverlight can be specified by using the DiagramView object, as shown in the following examples:

 The NodeClick event can be specified, as shown in the following code snippets.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [Name]{style="COLOR: red"}[=\"diagramView\"]{style="COLOR: blue"}[ NodeClick]{style="COLOR: red"}[=\"diagramView_NodeClick\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                              |
| [diagramView.NodeClick += [new]{style="COLOR: blue"} [NodeEventHandler]{style="COLOR: #2b91af"}(diagramView_NodeClick);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                         |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.NodeClick, [AddressOf]{style="COLOR: blue"} diagramView_NodeClick]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Then, the event handler can be specified in code behind, as shown in the following code snippet.[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                  |
| [// The event handler.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                  |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView_NodeClick([object]{style="COLOR: blue"} sender, [NodeRoutedEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                  |
| [// User specified code.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                      |
| [\'The event handler.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                      |
| [    [Private]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} diagramView_NodeClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [NodeRoutedEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                      |
| [        [\'User specified code.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                      |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

The ConnectorDoubleClick event can be specified, as shown in the following code snippets.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [Name]{style="COLOR: red"}[=\"diagramView\"]{style="COLOR: blue"}[ ConnectorDoubleClick]{style="COLOR: red"}[=\"diagramView_ConnectorDoubleClick\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                            |
| [diagramView.[ConnectorDoubleClick]{style="COLOR: black"} += [new]{style="COLOR: blue"} [ConnChangedEventHandler]{style="COLOR: #2b91af"}(diagramView\_[ConnectorDoubleClick]{style="COLOR: black"});]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                               |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.ConnectorDoubleClick, [AddressOf]{style="COLOR: blue"} diagramView_ConnectorDoubleClick]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Then, the event handler can be specified in code behind, as shown in the following code snippet.[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                             |
| [// The event handler.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                             |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView_ConnectorDoubleClick([object]{style="COLOR: blue"} sender, [ConnRoutedEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                             |
| [// User specified code.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                 |
| [\'The event handler.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                 |
| [    [Private]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} diagramView_ConnectorDoubleClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [ConnRoutedEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                 |
| [        [\'User specified code.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                 |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The NodeMoved and NodeDrop events can be specified, as shown in the following code snippet.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                 |
| [diagramView.NodeMoved += [new]{style="COLOR: blue"} [NodeNudgeEventHandler]{style="COLOR: #2b91af"}(diagramView_NodeMoved);]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                                 |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView_NodeMoved([object]{style="COLOR: blue"} sender, [NodeNudgeEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| [diagramView.NodeDrop += [new]{style="COLOR: blue"} [NodeNudgeEventHandler]{style="COLOR: #2b91af"}(diagramView_LineMoved);]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                 |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView_NodeDrop([object]{style="COLOR: blue"} sender, [NodeNudgeEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                     |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.NodeMoved += New NodeNudgeEventHandler(AddressOf diagramView_NodeMoved)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                     |
| [    [Private]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} diagramView_NodeMoved([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [NodeNudgeEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                     |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                     |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.NodeDrop += New NodeNudgeEventHandler(AddressOf diagramView_LineMoved)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                     |
| [    [Private]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} diagramView_NodeDrop([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [NodeNudgeEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                                                                                                     |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

Sample Link

To view a sample:

1.   Open the Diagram Sample Browser from the dashboard. (Refer to the [Samples and Location]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #1f497d; FONT-SIZE: 9pt"} chapter.)

2.   Navigate to **Product Showcase** -\> **Features Demo**.

[]{#related-topics}
:::::
