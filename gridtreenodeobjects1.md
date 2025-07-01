::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=63cb7aab-c42b-4970-b860-56f828069314){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bda95dd3-cf2d-4c9e-a3fb-90587659b211){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=094c35c7-db8e-4341-9619-16644b2a4e34){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid WPF Controls](ms-xhelp:///?Id=1249c159-5431-465a-b1af-1cf1e5e90ac8){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[GridTree Control](ms-xhelp:///?Id=30c1b843-3324-43d7-aab0-6bd65c0114d8){.d2h_breadcrumbsNormal}
:::

### GridTreeNode Objects {#gridtreenode-objects style="tab-stops: 0pt"}

The GridTreeControl.InternalGrid.Nodes collection holds the GridTreeNodes that represents the visible nodes in the GridTree control. The GridTreeNode object has the following properties:

 

Table 49: GridTreeNode Property

::: {align="center"}
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| GridTreeNode Property | Description                                                                                                                                                                              | Type of Property | Value It Accepts     | Property Syntax                |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| ChildNodes            | A collection of GridTreeNodes that represent the child nodes for this node.                                                                                                              | Normal           | List\<GridTreeNode\> | treeGrid.ParentNode.ChildNodes |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| Expanded              | Controls the expand state for the node. Set this property to true, to expand this node, or set it to false, and to collapse this node.                                                   | Normal           | bool                 | gridTreeNode.Expanded          |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| HasChildNodes         | Determines whether this node has child nodes or not.                                                                                                                                     | Normal           | bool                 | gridTreeNode.HasChildNodes     |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| IsSelected            | Controls whether this node is selected.                                                                                                                                                  | Normal           | bool                 | gridTreeNode.IsSelected        |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| Item                  | The data item (an object from the underlying bound data) associated with this node.                                                                                                      | Normal           | Object               | gridTreeNode.Item              |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| Level                 | Indicates tree level for this node.                                                                                                                                                      | Normal           | int                  | gridTreeNode.Level             |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| NodeHeight            | The height of the grid row associated with this node.                                                                                                                                    | Normal           | Double               | gridTreeNode.NodeHeight        |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| ParentItem            | The data item (an object from the underlying bound data) associated with the parent node of this node.                                                                                   | Normal           | Object               | gridTreeNode.ParentItem        |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| ParentNode            | The GridTreeNode that is the parent node of this node.                                                                                                                                   | Normal           | GridTreeNode         | gridTreeNode.ParentNode        |
|                       |                                                                                                                                                                                          |                  |                      |                                |
|                       |                                                                                                                                                                                          |                  |                      |                                |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| SelectedColumns       | Holds the column names that are selected for this node. This property is only valid when GridTreeControl.EnableNodeSelections is *false* and GridTreeControl.EnableSelections is *true*. | Normal           | List\<string\>       | gridTreeNoe.SelectedColumns    |
+-----------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
:::

 

[]{#p313} 

[]{#related-topics}
:::::
