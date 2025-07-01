::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Adding Table Layout for selected Nodes {#adding-table-layout-for-selected-nodes style="tab-stops: 0pt"}

[To apply a table layout to the selected nodes, assign the selected nodes to the *OrderNodes* property of the *DiagramModel*. You can also assign your own collection of IShape to the *OrderNodes* property. Then create an instance of the *TableLayout* and call the *RefreshLayout* method for this instance.]{style="BACKGROUND: white"}

[The following code illustrates this: ]{style="BACKGROUND: white; COLOR: black"}

[]{style="BACKGROUND: white; COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                         |
|                                                                                                                                                                                                         |
|                                                                                                                                                                                                         |
| [       // Assigning selected node to the OrderedNodes property.]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                     |
|                                                                                                                                                                                                         |
| [          diagramModel.OrderedNodes= diagramView.SelectionList.OfType\<[IShape]{style="COLOR: #2b91af"}\>().ToList(); ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                               |
|                                                                                                                                                                                                         |
| [       // Create an instance of TableLayout and refresh it.]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                         |
|                                                                                                                                                                                                         |
| [          [TableLayout]{style="COLOR: #2b91af"} table = [new]{style="COLOR: blue"} [TableLayout]{style="COLOR: #2b91af"}(diagramModel, diagramView);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                         |
| [          table.RefreshLayout();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                     |
|                                                                                                                                                                                                         |
|                                                                                                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="BACKGROUND: white; COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                   |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
| [         [\'Assigning selected node to the OrderedNodes property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                  |
| [              diagramModel.OrderedNodes= diagramView.SelectionList.OfType([Of]{style="COLOR: blue"} IShape)().ToList()]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                  |
| [         [\'Create an instance of TableLayout and refresh it.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                  |
| [              [Dim]{style="COLOR: blue"} table [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} TableLayout(diagramModel, diagramView)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                  |
| [              table.RefreshLayout()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="BACKGROUND: white; COLOR: black"} 

[When the code runs, the table layout will be applied to the specified node collection.  ]{style="BACKGROUND: white"}

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image82_8.jpg){border="0"}]{style="BACKGROUND: white"}[Note: If ]{style="BACKGROUND: white"}[the OrderNodes property ]{style="BACKGROUND: white; COLOR: black"}[ is set to null, then the table layout will be applied to the entire diagram.]{style="BACKGROUND: white"}
:::

 

![Description: C:\\Users\\labuser\\Desktop\\selection.PNG](ImagesExt/image82_29.png){border="0"}

Figure 24: Table Layout Applied for Specified Nodes

[]{#related-topics}
::::
