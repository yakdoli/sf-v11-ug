::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e7a25934-1ee3-49f5-8da4-9f822a65c79e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bf3e9394-b93f-4a17-90c8-d8d9d6847274){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8126789d-b192-4c3c-9e36-f0119f12b8b9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Tree control](ms-xhelp:///?Id=7a35cbd2-7c13-4922-9d18-aeecf6280496){.d2h_breadcrumbsNormal}
:::

### GridTreeNode Objects {#gridtreenode-objects style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **GridTreeControl.InternalGrid.Nodes** collection holds the GridTreeNodes that represents the visible nodes in the Grid Tree control. The GridTreeNode object has the following properties:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| GridTreeNode Property | Description                                                                                                                                                                                              | Type of Property | Value It Accepts     | Property Syntax                |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| ChildNodes            | A collection of **GridTreeNodes** that represent the child nodes for this node.                                                                                                                          | Normal           | List\<GridTreeNode\> | treeGrid.ParentNode.ChildNodes |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| Expanded              | Controls the expand state for the node. Set this property to **true**, to expand this node, or set it to **false**, to collapse this node.                                                               | Normal           | bool                 | gridTreeNode.Expanded          |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| HasChildNodes         | Determines whether this node has child nodes or not.                                                                                                                                                     | Normal           | bool                 | gridTreeNode.HasChildNodes     |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| IsSelected            | Controls whether this node is selected.                                                                                                                                                                  | Normal           | bool                 | gridTreeNode.IsSelected        |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| Item                  | The data item (an object from the underlying bound data) associated with this node.                                                                                                                      | Normal           | Object               | gridTreeNode.Item              |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| Level                 | Indicates tree level for this node.                                                                                                                                                                      | Normal           | int                  | gridTreeNode.Level             |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| NodeHeight            | The height of the grid row associated with this node.                                                                                                                                                    | Normal           | Double               | gridTreeNode.NodeHeight        |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| ParentItem            | The data item (an object from the underlying bound data) associated with the parent node of this node.                                                                                                   | Normal           | Object               | gridTreeNode.ParentItem        |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| ParentNode            | The **GridTreeNode** that is the parent node of this node.                                                                                                                                               | Normal           | GridTreeNode         | gridTreeNode.ParentNode        |
|                       |                                                                                                                                                                                                          |                  |                      |                                |
|                       |                                                                                                                                                                                                          |                  |                      |                                |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
| SelectedColumns       | Holds the column names that are selected for this node. This property is only valid when **GridTreeControl.EnableNodeSelections** is ***false*** and **GridTreeControl.EnableSelections** is ***true***. | Normal           | List\<string\>       | gridTreeNoe.SelectedColumns    |
+-----------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+----------------------+--------------------------------+
:::

[]{#p271} 

[]{#related-topics}
:::::
