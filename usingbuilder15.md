::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps guide in handling the customization of connector labels through Builder.

1.   In the **view**, create an object for the **Connector** class and set the **LabelFontColor**, **LabelBorderColor**, etc., properties.

2.   Invoke the **Diagram** helper with the control ID and set the **Nodes** property.[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[ Line[Connector]{style="COLOR: #2b91af"} line = [new]{style="COLOR: blue"} Line[Connector]{style="COLOR: #2b91af"} ()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                            |
| [                Name = \"line1\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| [                Label = \"Line's Label\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                            |
| [                HeadNode = node1,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| [                TailNode = node2,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| [                LabelBackground = \"#fcb\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                            |
| [                LabelBorderColor = \"#bcf\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                            |
| [                LabelBorderWidth = 1,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                            |
| [                LabelFontColor = \"#aad\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                            |
| [                LabelFontFamily = \"Arial\",]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                            |
| [                LabelFontSize = 12,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                            |
| [                LabelHeight = 30,]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| [                LabelWidth = 100               ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [            };]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                      |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [      Html.Syncfusion().Diagram([\"FlatDiagram\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                          |
|                                                                                                                                                                                                                                                            |
|               .Connectors(conn => conn.Add(line))                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                            |
| [          .Width(900)]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                            |
| [          .Height(500)]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                            |
| [          .DiagramMode(DiagramMode.SVG)          ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [          .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                            |
| [  }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                            |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                      |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**Note:** If you want to create the diagram in the Canvas mode, change the **DiagramMode** to **Canvas**. By default the diagram is rendered in the SVG mode.

 

3.   Build and run the application.

[]{#related-topics}
:::
