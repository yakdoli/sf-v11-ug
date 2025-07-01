::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps guide in handling multiple selection through Builder.

1.   In the **view**, [invoke the **Diagram** helper with the control ID as the first argument.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                                                                                           |
| <%{                                                                                                                                                                                                                                                                                                                         |
| ```                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                                                                                           |
|       Html.Syncfusion().Diagram("FlatDiagram")                                                                                                                                                                                                                                                                              |
| ```                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                                                                                           |
|           .Width(Unit.Pixel(900))                                                                                                                                                                                                                                                                                           |
| ```                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                                                                                           |
|           .Height(Unit.Pixel(500))                                                                                                                                                                                                                                                                                          |
| ```                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                             |
| [          **.AllowMultipleSelect (**]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}**[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 11pt"}[)]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[         ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}** |
|                                                                                                                                                                                                                                                                                                                             |
| [          .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                                                                                                                                           |
|   }                                                                                                                                                                                                                                                                                                                         |
| ```                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                             |
| [%\>]{style="BACKGROUND: yellow; COLOR: black; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**Note:** If you want to create the diagram in the Canvas mode, change the **DiagramMode** to **Canvas**. By default the diagram is rendered in the SVG mode.

 

2.   Build and run the application.

 

[]{#related-topics}
:::
