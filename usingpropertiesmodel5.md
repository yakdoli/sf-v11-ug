::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Using Properties Model {#using-properties-model style="PAGE-BREAK-AFTER: auto; tab-stops: 0pt"}

1.   In the **controller**, create an object for the **Node** class and set the **AllowSelect** property.

2.   Create an object for the **DiagramPropertiesModel** class and set the **Nodes** property. Pass this model class to the **view data**.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                             |
| [DiagramPropertiesModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 11pt"}[ model = [new]{style="COLOR: blue"} [DiagramPropertiesModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                                                                                                                                             |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} FlatDiagram()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                           |
|                                                                                                                                                                                                                                             |
| [        {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                             |
| [Node]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 11pt"}[ node = [new]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                       |
|                                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [                Name = \"Node1\",                ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                    |
|                                                                                                                                                                                                                                             |
| [                 **AllowSelect=[true]{style="COLOR: blue"}**]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                         |
|                                                                                                                                                                                                                                             |
| [            };]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [            model.Nodes = [new NodesCollection()]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                               |
|                                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [                node1 ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                               |
|                                                                                                                                                                                                                                             |
| [            };]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                             |
| [            model.Width = [Unit]{style="COLOR: #2b91af"}.Pixel(1100);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                |
|                                                                                                                                                                                                                                             |
| [            model.Height = [Unit]{style="COLOR: #2b91af"}.Pixel(500);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                |
|                                                                                                                                                                                                                                             |
| [            [model.DiagramMode = ]{style="COLOR: black"}[DiagramMode]{style="COLOR: #2b91af"}[.SVG;]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                           |
|                                                                                                                                                                                                                                             |
| [            ViewData\[[\"FlatDiagram\"]{style="COLOR: #a31515"}\] = model;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                           |
|                                                                                                                                                                                                                                             |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                    |
|                                                                                                                                                                                                                                             |
| [        }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**Note:** If you want to create the diagram in the Canvas mode, change the **DiagramMode** to **Canvas**. By default the diagram is rendered in the SVG mode.

 

3.   In the **view**, invoke the **Diagram** helper with the control ID, which is same as the **view data** name.

::: {align="center"}
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [  [\<%]{style="BACKGROUND: yellow"}{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                         |
| [              Html.Syncfusion().Diagram([\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[FlatDiagram\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                                                                                                                                                                         |
| [                  .Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                         |
| [    }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                         |
| [  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

4.   Build and run the application.

 

[]{#related-topics}
::::
