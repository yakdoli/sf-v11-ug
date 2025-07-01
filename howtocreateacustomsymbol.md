::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=684f6a39-251e-4b41-b783-5f94812df646){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1a0a22ee-2e5b-4b20-a927-25030878ec8c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How To Create a Custom Symbol {#how-to-create-a-custom-symbol style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code sample demonstrates how you can create a custom symbol and use it in Essential Diagram.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Create the custom symbol.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                            |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                       |
|                                                                                                                                                                                                           |
| [// Custom Symbol (MySymbol.cs)]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [class]{style="COLOR: blue"} [MySymbol]{style="COLOR: teal"} : [Symbol]{style="COLOR: teal"}]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                           |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                           |
| [    [private]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.[Rectangle]{style="COLOR: teal"} outerRect = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                           |
| [    [private]{style="COLOR: blue"} [Ellipse]{style="COLOR: teal"} innerEllipse = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                           |
| [    [public]{style="COLOR: blue"} MySymbol()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                           |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                           |
| [       // Add child nodes to the symbol programmatically.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                                           |
| [       [// Add an outer rectangle.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.outerRect = [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.[Rectangle]{style="COLOR: teal"}(0, 0, 120, 80);]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.outerRect.Name = [\"Rectangle\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.outerRect.FillStyle.Color = [Color]{style="COLOR: teal"}.Khaki;]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.AppendChild(outerRect);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                           |
| [        [// Add an inner ellipse.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.innerEllipse = [new]{style="COLOR: blue"} [Ellipse]{style="COLOR: teal"}(10, 10, 100, 60);]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.innerEllipse.Name = [\"Ellipse\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                           |
| [        [this]{style="COLOR: blue"}.AppendChild(innerEllipse);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                           |
| [        [// Add Label.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                           |
| [        [Label]{style="COLOR: teal"} lbl = [this]{style="COLOR: blue"}.AddLabel([\"My Symbol\"]{style="COLOR: maroon"}, [BoxPosition]{style="COLOR: teal"}.Center);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| [        lbl.BackgroundStyle.Color = [Color]{style="COLOR: teal"}.Transparent;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                           |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                           |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                               |
|                                                                                                                                                                                                                   |
| [\' Custom Symbol (MySymbol.vb)]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                                   |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Class]{style="COLOR: blue"} MySymbol]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                   |
| [        [Inherits]{style="COLOR: blue"} Symbol]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                   |
| [        [Private]{style="COLOR: blue"} outerRect [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.Rectangle = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                   |
| [        [Private]{style="COLOR: blue"} innerEllipse [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.Ellipse = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                               |
|                                                                                                                                                                                                                   |
| [        [Public]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} [New]{style="COLOR: blue"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [            [\' Add child nodes to the symbol programmatically.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                   |
| [            [\' Add an outer rectangle.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.outerRect = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 120, 80)]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.outerRect.Name = [\"Rectangle\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.outerRect.FillStyle.Color = Color.Khaki]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.AppendChild(outerRect)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [            [\' Add an inner ellipse.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.innerEllipse = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Diagram.Ellipse(10, 10, 100, 60)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.innerEllipse.Name = [\"Ellipse\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                   |
| [            [Me]{style="COLOR: blue"}.AppendChild(innerEllipse)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [            [\' Add Label.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                   |
| [            [Dim]{style="COLOR: blue"} lbl [As]{style="COLOR: blue"} Label = [Me]{style="COLOR: blue"}.AddLabel([\"My Symbol\"]{style="COLOR: maroon"}, BoxPosition.Center)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| [            lbl.BackgroundStyle.Color = Color.Transparent]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                   |
| [        [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} [\' New]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                   |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Class]{style="COLOR: blue"} [\' MySymbol]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   Use the symbol in the form.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                    |
| [// Register InsertTool for MySymbol.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram1.Controller.RegisterTool([new]{style="COLOR: blue"} InsertSymbolTool([\"InsertMySymbol\"]{style="COLOR: maroon"}, [typeof]{style="COLOR: blue"}(MySymbol)));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| [// Activate InsertTool for MySymbol.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram1.ActivateTool([\"InsertMySymbol\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                  |
| [\' Register InsertTool for MySymbol.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram1.Controller.RegisterTool([New]{style="COLOR: blue"} InsertSymbolTool([\"InsertMySymbol\"]{style="COLOR: maroon"}, [GetType]{style="COLOR: blue"}(MySymbol)))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                  |
| [\' Activate InsertTool for MySymbol.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram1.ActivateTool([\"InsertMySymbol\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p78} 

 

[]{#related-topics}
::::
