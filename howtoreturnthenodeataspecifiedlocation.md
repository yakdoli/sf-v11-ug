::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to return the node at a specified location {#how-to-return-the-node-at-a-specified-location style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

**GetNodeAtPoint** method will get or returns the node at the specified location. There are three overloads for this method. This method can be called inside DragOver event. The parameters are as follows. To return the node at the specified point, **GetNodeAtPointEx** method can be called.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------- -----------------------------------------------------------------------------------------------------------------
  Parameter           Description
  pt                  Indicates the location.
  textbounds          Indicates whether testing will be done using the bounds of text and not the whole bounds of the node.
  textOrImageBounds   Indicates whether testing will be done using the bounds of image and text and not the whole bounds of the node.
  ------------------- -----------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                             |
|                                                                                                                                                                                                      |
| [Point]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ptInTree = treeView.PointToClient([new]{style="COLOR: blue"} [Point]{style="COLOR: teal"}(e.X, e.Y));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                      |
| [//Gets the node point at the specified location]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPoint(ptInTree);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                      |
| [//Gets the node point at the specified location, uses the bounds of text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                         |
|                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPoint(ptInTree, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                      |
| [//Gets the node point at the specified location, uses the bounds of text and bounds of image and text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPoint(ptInTree, [true]{style="COLOR: blue"}, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                      |
| [//Gets the node point at the specified Point]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPointEx(ptInTree);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                            |
|                                                                                                                                                                                                     |
| [Point]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ptInTree = treeView.PointToClient([new]{style="COLOR: blue"} [Point]{style="COLOR: teal"}(e.X, e.Y))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                     |
| [\'Gets the node point at the specified location]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPoint(ptInTree)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                     |
| [\'Gets the node point at the specified location, uses the bounds of text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                        |
|                                                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPoint(ptInTree, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                     |
| [\'Gets the node point at the specified location, uses the bounds of text and bounds of image and text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                           |
|                                                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPoint(ptInTree, [True]{style="COLOR: blue"}, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                     |
| [Gets the node point at the specified Point]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeViewAdv1.GetNodeAtPointEx(ptInTree)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[[Drag and Drop]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Drag_And_Drop)[]{.UGHyperlink}

 

 

[]{#related-topics}
::::
