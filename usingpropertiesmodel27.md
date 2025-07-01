::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

To enable symbol palette customization through the properties model:

 

1.   In the **controller**, create an object for the **DiagramPropertiesModel** class. Assign this model class to **view data**. 

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                   |
| [DiagramPropertiesModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 11pt"}[ model = [new]{style="COLOR: blue"} [DiagramPropertiesModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                       |
|                                                                                                                                                                                                                                                                                                   |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} FlatDiagram()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                   |
| [        {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                   |
|                 model.SymbolPalette.Background = "white";                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.BorderColor = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"black\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}                         |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.ItemMouseOverBorderColor = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"red\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}              |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.SymbolPaletteGroupBackground = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"black\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}        |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.SymbolPaletteGroupBorderColor = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"black\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}       |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.SymbolPaletteGroupForeground = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"white\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}        |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.SymbolPaletteGroupHoverBackground = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"orange\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}  |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.SymbolPaletteGroupHoverBorderColor = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"orange\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"} |
|                                                                                                                                                                                                                                                                                                   |
| [            model.SymbolPalette.SymbolPaletteGroupHoverForeground = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}[\"white\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 11pt"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 11pt"}   |
|                                                                                                                                                                                                                                                                                                   |
| [            model.Width = 900;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                   |
| [            model.Height = 500;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                   |
| [            model.DiagramMode = DiagramMode.Canvas;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                   |
| [            ViewData\[[\"FlatDiagram\"]{style="COLOR: #a31515"}\] = model;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                   |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In the **view**, invoke the **Diagram** helper with the **view data key** as the control ID.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**[ ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                             |
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

 

3.   Build and run the application

[]{#related-topics}
:::
