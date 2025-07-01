::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_Disable_Ribbon_Context}Disable Ribbon Context menu

The Ribbon control is shipped with built-in context menu. The following code helps to disable the entire Ribbon Context Menu from the control.

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#[ ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                 |
|                                                                                                                                                                                                                     |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MainPage()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                     |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                     |
| [     InitializeComponent();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                     |
| [     myRibbon.OnRibbonContextMenuOpened += [new]{style="COLOR: blue"} [RoutedEventHandler]{style="COLOR: #2b91af"}(myRibbon_OnRibbonContextMenuOpened);]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                     |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                 |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                 |
|                                                                                                                                                                                                                     |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ myRibbon_OnRibbonContextMenuOpened([object]{style="COLOR: blue"} sender, [RoutedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                     |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                     |
| [     [ContextMenuAdv]{style="COLOR: #2b91af"} adv = sender [as]{style="COLOR: blue"} [ContextMenuAdv]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                     |
| [     adv.Visibility = System.Windows.[Visibility]{style="COLOR: #2b91af"}.Collapsed;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                     |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
