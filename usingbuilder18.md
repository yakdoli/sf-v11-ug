::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Builder {#using-builder style="tab-stops: 0pt"}

1.   In the **view**, invoke the **Diagram** helper with the control ID and set the **IsPageEditable** property.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}**[ ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                       |
|                                                                                                                                                                                                             |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                      |
|                                                                                                                                                                                                             |
| [      Html.Syncfusion().Diagram([\"FlatDiagram\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                           |
|                                                                                                                                                                                                             |
| [          **.IsPageEditable([true]{style="COLOR: blue"})**]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                           |
|                                                                                                                                                                                                             |
| [          .DiagramMode(DiagramMode.SVG)                 ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                             |
|                                                                                                                                                                                                             |
| [          .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                 |
|                                                                                                                                                                                                             |
| [  }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                  |
|                                                                                                                                                                                                             |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**Note:** If you want to create the diagram in the Canvas mode, change the **DiagramMode** to **Canvas**. By default the diagram is rendered in the SVG mode.

 

2.   Build and run the application.

[]{#related-topics}
:::
