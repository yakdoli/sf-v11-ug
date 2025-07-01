::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Orientation

 

You can place the contents of the groupbar either vertically or horizontally. This is achieved by using the **Orientation** property. It provides the following options.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Horizontal**: the contents of the GroupBar Item in the GroupBar control are placed horizontally

[·      ]{style="FONT-FAMILY: Symbol"}**Vertical**: the contents of the GroupBar Item in the GroupBar control are placed vertically

 

The following code example illustrates how to set the Orientation property to Horizontal.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[GroupBar]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [x]{style="COLOR: maroon"}[:]{style="COLOR: blue"}[Name]{style="COLOR: red"}[=\"groupbar\"]{style="COLOR: blue"} [Width]{style="COLOR: red"}[=\"250\"]{style="COLOR: blue"} [VisualMode]{style="COLOR: red"}[=\"StackMode\"]{style="COLOR: blue"} [Height]{style="COLOR: red"}[=\"450\"]{style="COLOR: blue"} [Orientation]{style="COLOR: red"}[=\"Vertical\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[GroupBarItem]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [x]{style="COLOR: maroon"}[:]{style="COLOR: blue"}[Name]{style="COLOR: red"}[=\"groupbaritem\"]{style="COLOR: blue"} [IsExpanded]{style="COLOR: red"}[=\"True\"]{style="COLOR: blue"}  [HeaderText]{style="COLOR: red"}[=\"GroupbarItem\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Grid]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[TextBlock]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [Text]{style="COLOR: red"}[=\"TextBlock\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Grid]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [syncfusion]{style="COLOR: maroon"}[:]{style="COLOR: blue"}[GroupBarItem]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[GroupBar]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                            |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [GroupBar groupbar = [new]{style="COLOR: blue"} GroupBar();]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                           |
| [groupbar.VisualMode = VisualMode.StackMode;]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                           |
| [groupbar.Orientation = [Orientation]{style="COLOR: teal"}.Vertical;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                           |
| [LayoutRoot.Children.Add(groupbar);]{style="FONT-FAMILY: 'Courier New'"}                                  |
+-----------------------------------------------------------------------------------------------------------+

 

![](../ImagesExt/image261_634.jpg){border="0"}

 

Figure 718: Orientation = \"Vertical\"

 

![](../ImagesExt/image261_635.jpg){border="0"}

 

Figure 719: Orientation = \"Horizontal\"

[]{#related-topics}
:::
