::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Selected Hierarchy Navigator Item Changed {#selected-hierarchy-navigator-item-changed style="tab-stops: 0pt"}

 

Users can handle selected item changed by using the methods Command (ICommand) property or HierarchyNavigatorSelectedItemChanged event in Hierarchy Navigator control.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[HierarchyNavigator]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ HierarchyNavigatorSelectedItemChanged]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"HierarchyNavigatorSelectedItemChanged\" /\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Cambria','serif'; COLOR: #4f81bd"}** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                                 |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                            |
| [HierarchyNavigator]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ hierarchyNavigator = [new]{style="COLOR: blue"} [HierarchyNavigator]{style="COLOR: #2b91af"}();\                                                                      |
| hierarchyNavigator.HierarchyNavigatorSelectedItemChanged += [new]{style="COLOR: blue"} [HierarchyNavigatorSelectedItemChangedEventHandler]{style="COLOR: #2b91af"}(HierarchyNavigatorSelectedItemChanged);]{style="FONT-FAMILY: Consolas"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Cambria','serif'; COLOR: #4f81bd"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                         |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                  |
|                                                                                                                                                                                                 |
| [private]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ [void]{style="COLOR: blue"} HierarchyNavigatorSelectedItemChanged([object]{style="COLOR: blue"} sender, ]{style="FONT-FAMILY: Consolas"} |
|                                                                                                                                                                                                 |
| [HierarchyNavigatorSelectedItemChangedEventArgs]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ e)]{style="FONT-FAMILY: Consolas"}                                                             |
|                                                                                                                                                                                                 |
| [{\                                                                                                                                                                                             |
| [     //Occurs when Selected Item Changed]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas"}                                                                                                |
|                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: Consolas"}                                                                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Passing the argument "HierarchyNavigator item" in a method called SelectNavigationItem can change the selected item.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                           |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                                                    |
|                                                                                                                                                                                                      |
| [HierarchyNavigator]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ hierarchyNavigator = [new]{style="COLOR: blue"} [HierarchyNavigator]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas"} |
|                                                                                                                                                                                                      |
| [hierarchyNavigator.SelectNavigationItem(hierarchyitem);]{style="FONT-FAMILY: Consolas"}                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
