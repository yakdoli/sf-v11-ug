::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps guide in handling the customization of node labels through Builder.

1.   In the **view**, create an object for the **Node** class and set the **LabelFontColor, LabelBorderColor,** etc. properties.

2.   Invoke the **Diagram** helper with the control ID and set the **Nodes** property.[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                  |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[ [Node]{style="COLOR: #2b91af"} node = [new]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [                Name = Node1,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [                Label = Node1,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [                LabelBackground = \"#fcb\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                      |
|                                                                                                                                                                                                                                         |
| [                LabelBorderColor = \"#bcf\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [                LabelBorderWidth = 1,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                            |
|                                                                                                                                                                                                                                         |
| [                LabelFontColor = \"#aad\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                       |
|                                                                                                                                                                                                                                         |
| [                LabelFontFamily = \"Arial\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [                LabelFontSize = 12,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                              |
|                                                                                                                                                                                                                                         |
| [                LabelHeight = 30,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                |
|                                                                                                                                                                                                                                         |
| [                LabelWidth = 100,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                |
|                                                                                                                                                                                                                                         |
| [                LabelHorizontalAlignment = [Horizontal]{style="COLOR: #2b91af"}.Center,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                          |
|                                                                                                                                                                                                                                         |
| [                LabelVerticalAlignment = [Vertical]{style="COLOR: #2b91af"}.Middle,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                              |
|                                                                                                                                                                                                                                         |
| [                LabelFontColor = [\"red\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                              |
|                                                                                                                                                                                                                                         |
| [                LabelFontSize = 16,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                              |
|                                                                                                                                                                                                                                         |
| [                LabelFontFamily = [\"Times New Roman]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                    |
|                                                                                                                                                                                                                                         |
| [            };]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                         |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                   |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                  |
|                                                                                                                                                                                                                                         |
| [      Html.Syncfusion().Diagram([\"FlatDiagram\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                       |
|                                                                                                                                                                                                                                         |
|               .Nodes(nodes => nodes.Add(node))                                                                                                                                                                                          |
|                                                                                                                                                                                                                                         |
| [          .Width(900)]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                                                                                                                                              |
|                                                                                                                                                                                                                                         |
| [          .Height(500)]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                                                                                                                                             |
|                                                                                                                                                                                                                                         |
| [          .DiagramMode(DiagramMode.SVG)          ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [          .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                             |
|                                                                                                                                                                                                                                         |
| [  }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                         |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                   |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

3.   Build and run the application.

 

[]{#related-topics}
:::
