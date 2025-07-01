::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6a591bd5-4338-46c3-8a8b-c4c1a9a7b8ac){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b77167f0-c9f6-492c-b031-4cd167c6a400){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=77f772a1-15ea-48e9-bd56-21bc587bb944){.d2h_breadcrumbsNormal}
:::

## Automatic Layout {#automatic-layout style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential Diagram Silverlight allows the user to specify automatic layouts for the nodes. The following layout types are available:

[·      ]{style="FONT-FAMILY: Symbol"}Directed-Tree layout

[·      ]{style="FONT-FAMILY: Symbol"}Hierarchical-Tree layout

[·      ]{style="FONT-FAMILY: Symbol"}Radial-Tree layout and

[·      ]{style="FONT-FAMILY: Symbol"}Table layout

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Properties

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| Property                    | Description                                                                                                                                                                                                                                    | Type of the property | Value it accepts          | Any other dependencies/ sub properties associated |
+=============================+================================================================================================================================================================================================================================================+======================+===========================+===================================================+
| VerticalSpacing             | Gets or sets the Vertical spacing between nodes.                                                                                                                                                                                               | CLR Property         | Double                    | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| HorizontalSpacing           | Gets or sets the Horizontal spacing between nodes.                                                                                                                                                                                             | CLR Property         | Double                    | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| SpaceBetweenSubTrees        | Gets or sets the space between sub trees.                                                                                                                                                                                                      | CLR Property         | Double                    | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| Orientation                 | Gets or sets the orientation.                                                                                                                                                                                                                  | CLR Property         |                           | No                                                |
|                             |                                                                                                                                                                                                                                                |                      |                           |                                                   |
|                             |                                                                                                                                                                                                                                                |                      | TreeOrientation.LeftRight |                                                   |
|                             |                                                                                                                                                                                                                                                |                      |                           |                                                   |
|                             |                                                                                                                                                                                                                                                |                      | TreeOrientation.RightLeft |                                                   |
|                             |                                                                                                                                                                                                                                                |                      |                           |                                                   |
|                             |                                                                                                                                                                                                                                                |                      | TreeOrientation.TopBottom |                                                   |
|                             |                                                                                                                                                                                                                                                |                      |                           |                                                   |
|                             |                                                                                                                                                                                                                                                |                      | TreeOrientation.BottomTop |                                                   |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| EnableCycleDetection        | Gets or sets a value indicating whether Cycle detection is enabled or not.                                                                                                                                                                     | DependencyProperty   | Boolean                   | No                                                |
|                             |                                                                                                                                                                                                                                                |                      |                           |                                                   |
|                             |                                                                                                                                                                                                                                                |                      | true/ false               |                                                   |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| TableExpandMode             | Gets or sets the table expand mode.                                                                                                                                                                                                            | DependencyProperty   | ExpandMode.Horizontal     | No                                                |
|                             |                                                                                                                                                                                                                                                |                      |                           |                                                   |
|                             |                                                                                                                                                                                                                                                |                      | ExpandMode.Vertical       |                                                   |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| RowCount                    | Gets or sets the Row Count for the table layout.                                                                                                                                                                                               | DependencyProperty   | int                       | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| ColumnCount                 | Gets or sets the Column Count for the table layout.                                                                                                                                                                                            | DependencyProperty   | int                       | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| EnableLayoutWithVariedSizes | Gets or sets a value indicating whether to enable the varied size algorithm. In case the Model consists of nodes of different sizes, this property can be set to true. This will align the differently sized nodes with respect to the center. | DependencyProperty   | Boolean (true/ false)     | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+
| Bounds                      | Gets or sets the bounds value which specifies the position of the root node in case of a tree layout.                                                                                                                                          | CLR Property         | Thickness                 | No                                                |
+-----------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+---------------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Directed-Tree Layout

The Directed-Tree Layout automatically arranges nodes in a tree-like structure. This enables the user to position nodes in a tree-like fashion without specifying the coordinate location for each node. However, it is necessary to specify a layout root for the tree layout. The Directed-Tree layout will position the nodes based on the layout root.

Hierarchical-Tree Layout

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

The Hierarchical Tree Layout arranges nodes in a tree-like structure, where the nodes in hierarchical layout may have multiple parents. As a result, there is no need to specify the layout root.

[]{style="FONT-FAMILY: 'Cambria','serif'; COLOR: black; FONT-SIZE: 14pt"} 

Radial-Tree Layout

The Radial-Tree Layout Manager arranges nodes in a circular layout and positions the root-node at the center of the graph and child-nodes in a circular fashion around the root. Sub-trees formed by the branching of the child-node are located radially around the child-node. **[]{style="COLOR: #15428b"}**

Table Layout

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

Table layout is a layout manager that arranges the nodes in rows and column basis. The number of nodes in each row and column can be specified and the layout will take place accordingly.

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Directed Tree Layout](ms-xhelp:///?Id=b77167f0-c9f6-492c-b031-4cd167c6a400){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Hierarchical Tree Layout](ms-xhelp:///?Id=6035dfd0-175d-4234-8a63-cb15da611830){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Radial Tree Layout](ms-xhelp:///?Id=b9ebbda6-d1ff-4646-843d-81af08497258){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Table Layout](ms-xhelp:///?Id=88301836-2b20-4b6d-b8ee-a1ade8fd0b3f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}BowTie Layout](ms-xhelp:///?Id=9496ba6b-d77e-4183-962b-f7589bbdda12){style="TEXT-DECORATION: none"}
::::
