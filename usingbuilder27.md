::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

To enable symbol palette customization through Builder.

1.   In the **view**, [invoke the **Diagram** helper with ]{style="BACKGROUND: white; COLOR: black"}the[ **control ID** as the first argument.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**       |
|                                                                       |
|     <%{                                                               |
|                                                                       |
|           Html.Syncfusion().Diagram("SymbolPalette").SymbolPalette(   |
|                                                                       |
|             gr => gr.Background("white")                              |
|                                                                       |
|                     .BorderColor("black")                             |
|                                                                       |
|                     .ItemMouseOverBorderColor("red")                  |
|                                                                       |
|                     .SymbolPaletteGroupBackground("black")            |
|                                                                       |
|                     .SymbolPaletteGroupBorderColor("black")           |
|                                                                       |
|                     .SymbolPaletteGroupForeground("white")            |
|                                                                       |
|                     .SymbolPaletteGroupHoverBackground("orange")      |
|                                                                       |
|                     .SymbolPaletteGroupHoverBorderColor("orange")     |
|                                                                       |
|                     .SymbolPaletteGroupHoverForeground("white"))      |
|                                                                       |
|               .DiagramMode(DiagramMode.Canvas)                        |
|                                                                       |
|               .Render();                                              |
|                                                                       |
|       }                                                               |
|                                                                       |
|     %>                                                                |
|                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}               |
+-----------------------------------------------------------------------+

 

2.   Build and run the application.

 

[]{#related-topics}
:::
