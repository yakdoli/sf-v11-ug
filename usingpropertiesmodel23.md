::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

The following steps show you how to handle the addition of a symbol palette group through the properties model.

1.   In the **controller**, create an object for the **DiagramPropertiesModel** class. Assign this model class to **view data**. 

 

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                               |
| [DiagramPropertiesModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 11pt"}[ diagramModel = [new]{style="COLOR: blue"} [DiagramPropertiesModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                               |
| [diagramModel.IsPageEditable = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                               |
| [diagramModel.BoundaryConstraintsEnabled=[false]{style="COLOR: blue"};            ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                               |
| **[diagramModel.IsSymbolPaletteEnabled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                               |
| [diagramModel.SymbolPaletteWidth = 151;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                               |
| [diagramModel]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[.DiagramMode = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[DiagramMode]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 11pt"}[.Canvas;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In the **view**, invoke the **Diagram** helper with the **view data key** as the control ID.

 

+-----------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**             |
|                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                 |
|                                                                             |
| ``` {style="LINE-HEIGHT: 115%; BACKGROUND: #f2f2f2"}                        |
| <%{                                                                         |
| ```                                                                         |
|                                                                             |
| ``` {style="LINE-HEIGHT: 115%; BACKGROUND: #f2f2f2"}                        |
|       Html.Syncfusion().Diagram("FlatDiagram")                              |
| ```                                                                         |
|                                                                             |
| [          .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                             |
| ``` {style="LINE-HEIGHT: 115%; BACKGROUND: #f2f2f2"}                        |
|   }                                                                         |
| ```                                                                         |
|                                                                             |
| ``` {style="LINE-HEIGHT: 115%; BACKGROUND: #f2f2f2"}                        |
| %>                                                                          |
| ```                                                                         |
+-----------------------------------------------------------------------------+

 

3.   Build and run the application.

                           

[]{#related-topics}
:::
