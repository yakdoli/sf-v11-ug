::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4b8071fc-f6f9-4e36-9f3f-452bf4291f3b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=56c90dc7-f5c6-44bc-9ca6-edbeeb709630){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[SymbolPalette](ms-xhelp:///?Id=20dbf28d-6928-4d19-a722-5f6779ab36c2){.d2h_breadcrumbsNormal}
:::

### SymbolPalette Item {#symbolpalette-item style="tab-stops: 0pt"}

SymbolPalette items are contained in the SymbolPalette group. A SymbolPalette item does not restrict users to the type of content that can be added to it. A SymbolPalette item can be a text box, combo box, image, button, and so on.

 

The **Name** property of the SymbolPaletteItem can be used to refer to the custom item being added in the NodeDrop event. The name of the SymbolPaletteItem becomes the name of the node.

 

The following code snippet can be used to add a SymbolPalette item that has an image as its content.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                              |
| [SymbolPaletteGroup]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ group = [new]{style="COLOR: blue"} [SymbolPaletteGroup]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                                              |
| [group.Label = [\"Custom\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                              |
| [SymbolPalette]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.SetFilterIndexes(group, [new]{style="COLOR: blue"} [Int32Collection]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[\] { 0, 6 }));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                              |
| [dc.SymbolPalette.SymbolGroups.Add(group);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                              |
| [SymbolPaletteItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ item = [new]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                              |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ i = [new]{style="COLOR: blue"} [Image]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                                                              |
| [BitmapImage]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ bi3 = [new]{style="COLOR: blue"} [BitmapImage]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                                              |
| [bi3.BeginInit();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                              |
| [bi3.UriSource = [new]{style="COLOR: blue"} [Uri]{style="COLOR: #2b91af"}([\"Custom.png\"]{style="COLOR: #a31515"}, [UriKind]{style="COLOR: #2b91af"}.RelativeOrAbsolute);]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                                                              |
| [bi3.EndInit();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                              |
| [i.Stretch = [Stretch]{style="COLOR: #2b91af"}.Fill;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                              |
| [i.Source = bi3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                              |
| [item.Content = i;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                              |
| [group.Items.Add(item);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                         |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                   |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ group [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [SymbolPaletteGroup]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [group]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Label = \"Custom\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                        |
| [SymbolPalette.SetFilterIndexes(group, [New]{style="COLOR: blue"} Int32Collection(New [Integer]{style="COLOR: blue"}() { 0, 6 }))]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                        |
| [dc.SymbolPalette.SymbolGroups.Add(group)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ item [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Image]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bi3 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [BitmapImage]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                        |
| [bi3.BeginInit()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                        |
| [bi3.UriSource = [New]{style="COLOR: blue"} Uri(\"Custom.png\", UriKind.RelativeOrAbsolute)]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                        |
| [bi3.EndInit()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                        |
| [i.Stretch = Stretch.Fill]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                        |
| [i.Source = bi3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                        |
| [item.Content = i]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [group]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Items.Add(item)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This adds the image content to the newly created SymbolPalette item that belongs to the SymbolPalette group named \"Custom\".

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image82_196.jpg){border="0"}

Figure 191: Custom Group and Item

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Create SymbolPaletteItem](ms-xhelp:///?Id=7bc9c933-b5d6-4e10-ab4b-dd9e81f9cf8e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Define Node, Port, Group definitions in SymbolPalette](ms-xhelp:///?Id=3cc8b344-3be4-42a2-af20-18e1b001d993){style="TEXT-DECORATION: none"}
::::
