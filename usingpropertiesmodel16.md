::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

The following steps guide in handling multiple selection through the properties model.

1.   In the **controller**, create an object for the **DiagramPropertiesModel** class. Assign this model class to the **view data**. 

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                       |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                     |
|                                                                                                                                                                                                             |
| ``` {style="PAGE-BREAK-BEFORE: always; MARGIN-BOTTOM: 6pt; BACKGROUND: #f2f2f2"}                                                                                                                            |
| DiagramPropertiesModel model = new DiagramPropertiesModel()                                                                                                                                                 |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="PAGE-BREAK-BEFORE: always; MARGIN-BOTTOM: 6pt; BACKGROUND: #f2f2f2"}                                                                                                                            |
|             {                                                                                                                                                                                               |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="PAGE-BREAK-BEFORE: always; MARGIN-BOTTOM: 6pt; BACKGROUND: #f2f2f2"}                                                                                                                            |
|                 Width = 900,                                                                                                                                                                                |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                           |
|                 Height = 500,                                                                                                                                                                               |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2; tab-stops: 109.65pt"}                                                                                                                                                      |
|                 DiagramMode = DiagramMode.SVG,                                                                                                                                                              |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                           |
|                 AllowMultipleSelect = true                                                                                                                                                                  |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                           |
|             };                                                                                                                                                                                              |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                                                                           |
|             ViewData["FlatDiagram"] = model;                                                                                                                                                                |
| ```                                                                                                                                                                                                         |
|                                                                                                                                                                                                             |
| [            ]{style="COLOR: black; FONT-SIZE: 11pt"}[return]{style="COLOR: blue; FONT-SIZE: 11pt"}[ View();]{style="COLOR: black; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**Note:** If you want to create the diagram in the Canvas mode, change the **DiagramMode** to **Canvas**. By default the diagram is rendered in the SVG mode.

 

2.   In the **view**, invoke the **Diagram** helper with the **view data key** as the control ID.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                              |
|                                                                                                                                                     |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                   |
| <%{                                                                                                                                                 |
| ```                                                                                                                                                 |
|                                                                                                                                                     |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                   |
|       Html.Syncfusion().Diagram("FlatDiagram")                                                                                                      |
| ```                                                                                                                                                 |
|                                                                                                                                                     |
| [          .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                         |
|                                                                                                                                                     |
| ``` {style="BACKGROUND: #f2f2f2"}                                                                                                                   |
|   }                                                                                                                                                 |
| ```                                                                                                                                                 |
|                                                                                                                                                     |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black; FONT-SIZE: 11pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Build and run the application.

 

[]{#related-topics}
:::
