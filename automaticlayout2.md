::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2122a355-5147-49b4-88a6-22abcd6853f0){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c37538af-02be-40ac-bc8d-eef94f6fd0ed){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Creating a Diagram](ms-xhelp:///?Id=e0b230dc-c754-4d57-8e86-d18830e36ce4){.d2h_breadcrumbsNormal}
:::

### Automatic Layout {#automatic-layout style="tab-stops: 0pt"}

Essential Diagram WPF allows you to specify automatic layouts the nodes. Following layout types are available:

[·      ]{style="FONT-FAMILY: Symbol"}Directed-Tree layout

[·      ]{style="FONT-FAMILY: Symbol"}Hierarchical-Tree layout

[·      ]{style="FONT-FAMILY: Symbol"}Radial-Tree layout

[·      ]{style="FONT-FAMILY: Symbol"}Table layout

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 4: Property Table**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}**

+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| Property                    | Description                                                                                                                                                                                                                                        | Type of the property                   | Value it accepts          |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| VerticalSpacing             | Gets or sets the Vertical spacing between nodes.                                                                                                                                                                                                   | CLR property                           | Double                    |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| HorizontalSpacing           | Gets or sets the Horizontal spacing between nodes.                                                                                                                                                                                                 | CLR property                           | Double                    |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| SpaceBetweenSubTrees        | Gets or sets the space between sub trees.                                                                                                                                                                                                          | CLR property                           | Double                    |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| Orientation                 | Gets or sets the orientation.                                                                                                                                                                                                                      | CLR property                           | TreeOrientation.LeftRight |
|                             |                                                                                                                                                                                                                                                    |                                        |                           |
|                             |                                                                                                                                                                                                                                                    |                                        | TreeOrientation.RightLeft |
|                             |                                                                                                                                                                                                                                                    |                                        |                           |
|                             |                                                                                                                                                                                                                                                    |                                        | TreeOrientation.TopBottom |
|                             |                                                                                                                                                                                                                                                    |                                        |                           |
|                             |                                                                                                                                                                                                                                                    |                                        | TreeOrientation.BottomTop |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| EnableCycleDetection        | Gets or sets a value indicating whether Cycle detection is enabled or not.                                                                                                                                                                         | DependencyProperty                     | Boolean                   |
|                             |                                                                                                                                                                                                                                                    |                                        |                           |
|                             |                                                                                                                                                                                                                                                    |                                        | true/ false               |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| TableExpandMode             | Gets or sets the table expand mode.                                                                                                                                                                                                                | DependencyProperty                     | ExpandMode.Horizontal     |
|                             |                                                                                                                                                                                                                                                    |                                        |                           |
|                             |                                                                                                                                                                                                                                                    |                                        | ExpandMode.Vertical       |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| RowCount                    | Gets or sets the Row Count for the table layout.                                                                                                                                                                                                   | DependencyProperty                     | int                       |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| ColumnCount                 | Gets or sets the Column Count for the table layout.                                                                                                                                                                                                | DependencyProperty                     | int                       |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| EnableLayoutWithVariedSizes | Gets or sets a value indicating whether to enable the varied size algorithm. In case the Model consists of the nodes of different sizes, this property can be set to true. This will align the differently sized nodes with respect to the center. | DependencyProperty                     | Boolean (true/ false)     |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| Bounds                      | Gets or sets the bounds value which specifies the position of the root node in case of tree layout.                                                                                                                                                | CLR [property]{style="COLOR: #1f497d"} | Thickness                 |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+
| BowtieSubTreePlacement      | Gets or sets a value from the BowtieSubTreePlacement.                                                                                                                                                                                              | Attached Dependency property           | BowtieSubTreePlacement    |
+-----------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+---------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Directed-Tree Layout

The Directed-Tree Layout automatically arranges nodes in a tree-like structure. This enables you to position nodes in a tree-like fashion without specifying the coordinate location for each node. However, it is necessary to specify a layout root for the tree layout. The Directed-Tree layout will position the nodes based on the layout root.

 

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

[![](button.gif){border="0" align="absMiddle"}Directed -- Tree Layout](ms-xhelp:///?Id=cc0dd756-ace7-44f3-a090-bc97eec0bad8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Hierarchical -- Tree Layout](ms-xhelp:///?Id=795cd234-a742-472c-9b8a-c33c01fad6a5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Radial -- Tree Layout](ms-xhelp:///?Id=92d40d9b-4590-4792-8f6c-6317814b8604){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Table Layout](ms-xhelp:///?Id=cbc6a9f5-e2d2-4208-bf3e-ef4a2e013f06){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}BowTie Layout](ms-xhelp:///?Id=15dfe101-8ce5-4ce2-93fb-66ebc19fc891){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Table Layout for Selected Nodes](ms-xhelp:///?Id=39233bee-1f12-4938-b405-81d5426d68e5){style="TEXT-DECORATION: none"}
::::
