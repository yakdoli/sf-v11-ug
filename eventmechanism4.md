::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2969fb74-0fcb-4be1-a89a-ee90ae8cf666){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=5cdb06d0-b5a4-46bf-8756-7abe84af0530){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Event Mechanism {#event-mechanism style="tab-stops: 0pt"}

[]{#p103}This section describes several events triggered and handled while using Essential Diagram WPF in the following topic:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Events for Nodes and Connections

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Diagram control has several events which respond to several actions performed on nodes and connections.

 

The various events and their descriptions are explained in the following table.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 86: Events Table

::: {align="center"}
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| Event                                                | Description                                                         | Arguments                                                                                  |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeClick                                            | Raised when the node is clicked.\                                   | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeDoubleClick                                      | Raised when the node is clicked twice in succession.\               | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeStartLabelEdit                                   | Raised when the label editing on the node is started.\              | NewLabelValue -- The new label value.                                                      |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | OldLabelValue -- the old label value.                                                      |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | Node - Node on which event is raised.                                                      |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeLabelChanged                                     | Raised when the node\'s label value is changed.\                    | NewLabelValue -- The new label value.                                                      |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | OldLabelValue -- the old label value.                                                      |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | Node - Node on which event is raised.                                                      |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeDragStart                                        | Raised when the node is dragged.\                                   | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeDragEnd                                          | Raised when the drag operation on node is complete.                 | Node -- Node on which event is raised.                                                     |
|                                                      |                                                                     |                                                                                            |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeResizing                                         | Raised when the resize operation is being performed.\               | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeResized                                          | Raised after the node is resized.\                                  | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeRotationChanging                                 | Raised when the node is being rotated.\                             | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeRotationChanged                                  | Raised after the node is rotated.\                                  | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorDoubleClick                                 | Raised when the Connector is clicked twice in succession.\          | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | Head Node -- Head Node of the connector.                                                   |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | Tail Node -- Tail Node of the connector.                                                   |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorStartLabelEdit                              | Raised when the label editing on the Connector is started.\         | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     | Head Node -- Head Node of the connector.                                                   |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | Tail Node -- Tail Node of the connector.                                                   |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | OldLabelValue -- the old label value.                                                      |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorLabelChanged                                | Raised when the connector\'s label value is changed.\               | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     | Head Node -- Head Node of the connector.                                                   |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | Tail Node -- Tail Node of the connector.                                                   |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | OldLabelValue -- the old label value.                                                      |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | NewLabelValue -- The new label value.                                                      |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorDragStart                                   | Raised when either ends of the connector is dragged.\               | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | FixedNodeEnd -- Node on which the connection is fixed.                                     |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | MovableNodeEnd -- The old Node on which the Connector was connected.                       |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorDragEnd                                     | Raised when the drag operation is complete.\                        | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | FixedNodeEnd -- Node on which the connection is fixed.                                     |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | HitNodeEnd -- The new node on which the Connector is getting connected.                    |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeDrop                                             | Raised when a shape from the SymbolPalette is dropped on the page.\ | DroppedNode -- The new node just dropped from SymbolPalette.                               |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | SymbolPaletteItemName -- The name of the SymbolPalette item, which is dropped on the page. |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| HeadNodeChanged                                      | Raised when the headnode of the connector is changed\               | Connector -- The connector whose HeadNode is changed.                                      |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | PreviousNode -- The old Node on which the HeadNode of the Connector was connector.         |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | CurrentNode - The new Node on which the HeadNode of the Connector is connector.            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| TailNodeChanged                                      | Raised when the tailnode of the connector is changed.\              | Connector -- The connector whose HeadNode is changed.                                      |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | PreviousNode -- The old Node on which the TailNode of the Connector was connector.         |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | CurrentNode - The new Node on which the TailNode of the Connector is connector.            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorDrop                                        | Raised when the connector is dropped on the page.\                  | DroppedConnector -- Connector on which the event is raised.                                |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| BeforeConnectionCreate                               | Raised when a new connection is being made.\                        | Connector -- The connector whose HeadNode is changed.                                      |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| AfterConnectionCreate                                | Raised after the connection has been made.\                         | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | FixedNodeEnd -- Node on which the connection is fixed.                                     |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | HitNodeEnd -- The new node on which the Connector is getting connected.                    |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeSelected                                         | Raised when a node is selected.\                                    | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeUnSelected                                       | Raised when a node is not selected.\                                | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeDeleting                                         | Raised before a node is deleted from the model.\                    | DeletedNode -- Node which is going to get deleted.                                         |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeDeleted                                          | Raised when a node is deleted from the model.\                      | DeletedNode -- Node which is deleted.                                                      |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorDeleting                                    | Raised before a line connector is deleted from the model.\          | DeletedLineConnector -- LineConnector which is getting deleted.                            |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| ConnectorDeleted                                     | Raised when a line connector is deleted from the model.\            | DeletedLineConnector -- LineConnector which is deleted.                                    |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| PreviewNodeDrop                                      | Raised before a node is dropped on the page.\                       | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| PreviewConnectorDrop                                 | Raised before a line connector is dropped on the page.\             | Connector -- Connector on which the event is raised.                                       |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
|                                                      |                                                                     |                                                                                            |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
| NodeMoved                                            | Raised when the nudge operation on node is completed.\              | Node -- Node on which event is raised.                                                     |
|                                                      | Event cannot be cancelled.                                          |                                                                                            |
| (event is fired before nudge operation is completed) |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | oldOffset -- The old offset value before nudge operation.                                  |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     |                                                                                            |
|                                                      |                                                                     | newOffset -- The new offset value after performing nudge operation.                        |
+------------------------------------------------------+---------------------------------------------------------------------+--------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The events can be specified using DiagramView object as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}For instance, NodeClick event can be specified in the following way.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [Name]{style="COLOR: red"}[=\"diagramView\"]{style="COLOR: blue"}[ NodeClick]{style="COLOR: red"}[=\"diagramView_NodeClick\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                               |
|                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                         |
|                                                                                                                                                              |
| [diagramView.NodeClick += [new]{style="COLOR: blue"} [NodeEventHandler]{style="COLOR: #2b91af"}(diagramView_NodeClick);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                          |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                    |
|                                                                                                                                                                                                                         |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.NodeClick, [AddressOf]{style="COLOR: blue"} diagramView_NodeClick]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}And then the event handler can be specified in the code behind as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                   |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [//Event Handler]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                  |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView_NodeClick([object]{style="COLOR: blue"} sender, [NodeRoutedEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                  |
| [//user specified code]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                              |
| [\'Event Handler]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                              |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} diagramView_NodeClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [NodeRoutedEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                              |
| [     [\'user specified code]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                              |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}As another example, the **ConnectorDoubleClick** event can be specified in the following way.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [Name]{style="COLOR: red"}[=\"diagramView\"]{style="COLOR: blue"}[ ConnectorDoubleClick]{style="COLOR: red"}[=\"diagramView_ConnectorDoubleClick\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                             |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                            |
| [diagramView.[ConnectorDoubleClick]{style="COLOR: black"} += [new]{style="COLOR: blue"} [ConnChangedEventHandler]{style="COLOR: #2b91af"}(diagramView\_[ConnectorDoubleClick]{style="COLOR: black"});]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.ConnectorDoubleClick, [AddressOf]{style="COLOR: blue"} diagramView_ConnectorDoubleClick]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

And then the event handler can be specified in the code behind as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                              |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [// Event Handler]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView_ConnectorDoubleClick([object]{style="COLOR: blue"} sender, [ConnRoutedEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                             |
| [// user specified code]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                  |
|                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                         |
| [\'Event Handler]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                         |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} diagramView_ConnectorDoubleClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [ConnRoutedEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                         |
| [     [\'user specified code]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                         |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}NodeMoved and NodeDrop events

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                            |
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

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.NodeMoved += New NodeNudgeEventHandler(AddressOf diagramView_NodeMoved)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} diagramView_NodeMoved([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [NodeNudgeEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                             |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramView.NodeDrop += New NodeNudgeEventHandler(AddressOf diagramView_LineMoved)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} diagramView_NodeDrop([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} [NodeNudgeEventArgs]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                                                                                                                             |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::
