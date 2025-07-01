::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b09a9b7e-9ba8-452a-a113-e04e408f97d9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=674cf455-425f-4946-bd1f-1aab39088c3a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How To Programmatically Add a Symbol From the Palette {#how-to-programmatically-add-a-symbol-from-the-palette style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code sample demonstrates how you can programmatically add a symbol from the symbol palette to a diagram.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (paletteGroupView1.Palette.Nodes.Count \> 0)]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                               |
| [       [Node]{style="COLOR: #2b91af"} nc =([Node]{style="COLOR: #2b91af"})paletteGroupView1.Palette.Nodes\[0\].Clone();                ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| [       diagram1.Model.AppendChild(nc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                      |
|                                                                                                                                                                          |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paletteGroupView1.Palette.Nodes.Count \> 0 [Then]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                          |
| [      [Dim]{style="COLOR: blue"} nc [As]{style="COLOR: blue"} Node = DirectCast(paletteGroupView1.Palette.Nodes(0).Clone(), Node) ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                          |
| [      diagram1.Model.AppendChild(nc) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                          |
| [End If ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p91} 

 

[]{#related-topics}
::::
