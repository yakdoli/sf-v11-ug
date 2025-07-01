::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### [ ]{style="COLOR: black"}Aligning the Layout on a Specified Location {#aligning-the-layout-on-a-specified-location style="tab-stops: 0pt"}

[To align the ordered nodes in a particular position, call the *TableLayout's* *RefreshLayout* (Point PivotPoint) method and specify the particular point as a parameter. The layout will be positioned in the specified pivot point. ]{style="COLOR: black"}

[The following code illustrates this:]{style="COLOR: black"}****

**** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                         |
|                                                                                                                                                                                                         |
|                                                                                                                                                                                                         |
| [       // Assigning selected node to the OrderedNodes.]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                              |
|                                                                                                                                                                                                         |
| [          diagramModel.OrderedNodes= diagramView.SelectionList.OfType\<[IShape]{style="COLOR: #2b91af"}\>().ToList(); ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                               |
|                                                                                                                                                                                                         |
| [          [TableLayout]{style="COLOR: #2b91af"} table = [new]{style="COLOR: blue"} [TableLayout]{style="COLOR: #2b91af"}(diagramModel, diagramView);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                         |
| [          table.RefreshLayout(300,400);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                              |
|                                                                                                                                                                                                         |
|                                                                                                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                   |
|                                                                                                                                                                                  |
| [         [\' Assigning selected node to the OrderedNodes.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                  |
| [diagramModel.OrderedNodes= diagramView.SelectionList.OfType([Of]{style="COLOR: blue"} IShape)().ToList()]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                  |
| [              [Dim]{style="COLOR: blue"} table [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} TableLayout(diagramModel, diagramView)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                  |
| [              table.RefreshLayout(300,400)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
