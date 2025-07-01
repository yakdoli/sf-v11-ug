::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c350b40d-795b-45b2-a7a1-bab193ba293e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=5249a1ca-418c-407c-b934-4f5afab7f4f9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How To Programmatically Link Two Symbols {#how-to-programmatically-link-two-symbols style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **Syncfusion.Windows.Forms.Diagram.LinkCmd** command class can be used to programmatically link symbols.

 

The following code sample shows how to create a link between two symbols, symbol1 and symbol2.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                            |
|                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                       |
|                                                                                                                                                           |
| [// Create a LinkCmd object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                           |
|                                                                                                                                                           |
| [LinkCmd linkcommand = [new]{style="COLOR: blue"} LinkCmd();]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                           |
| [linkcommand.Link = [new]{style="COLOR: blue"} [Link]{style="COLOR: teal"}([Link]{style="COLOR: teal"}.Shapes.Line);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                           |
| [// Set up the Source and Target ports for the Link.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                   |
|                                                                                                                                                           |
| [linkcommand.SourcePort = symbol1.CenterPort;]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                           |
| [linkcommand.TargetPort = symbol2.CenterPort;]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                           |
| [// Execute the command to connect the two symbols.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                    |
|                                                                                                                                                           |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram.Controller.ExecuteCommand(linkcommand);]{style="FONT-FAMILY: 'Courier New'"}             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                     |
|                                                                                                                                                                         |
| ['Create a LinkCmd object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ linkcommand [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} LinkCmd()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [linkcommand.Link = [New]{style="COLOR: blue"} Link(Link.Shapes.Line)]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                         |
| ['Set up the Source and Target ports for the Link.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                   |
|                                                                                                                                                                         |
| [linkcommand.SourcePort = symbol1.CenterPort]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                         |
| [linkcommand.TargetPort = symbol2.CenterPort]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                         |
| ['Execute the command to connect the two symbols.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                    |
|                                                                                                                                                                         |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.diagram.Controller.ExecuteCommand(linkcommand)]{style="FONT-FAMILY: 'Courier New'"}                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p92} 

 

[]{#related-topics}
::::
