::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Apply Skin for Hierarchy Navigator Control {#apply-skin-for-hierarchy-navigator-control style="tab-stops: 0pt"}

Add the following DLLs to apply corresponding theme for the Hierarchy Navigator control. SkinStorage class is used to apply different visual style for a control, which is available in Syncfusion.Shared.WPF project.

1.   Create a HierarchyNavigator instance either in XAML or code behind.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[HierarchyNavigator]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ x]{style="FONT-FAMILY: Consolas; COLOR: red"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Name]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"hierarchyNavigator\"/\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

Or

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                           |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                                                    |
|                                                                                                                                                                                                      |
| [HierarchyNavigator]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ hierarchyNavigator = [new]{style="COLOR: blue"} [HierarchyNavigator]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Apply Visual Style in code behind by calling the static method SetVisualStyle in SkinStorage class in Syncfusion.Shared.WPF. Here, Control name and Visual Style has to be passed in that static method arguments. The following image shows an example of Windows 7 (Default):

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **C#**[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                           |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                                 |
|                                                                                                                                                                                   |
| [SkinStorage]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[.SetVisualStyle([this]{style="COLOR: blue"}, [\"Default\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

***[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}*** 

[]{#related-topics}
:::
