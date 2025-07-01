::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to hide the tab strip ellipses at the top of the control?

You can hide the tab strip ellipses at the top of the control, for customization purposes. To do so, set the TabStripButtonVisibility property to "Collapse".

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **XAML**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [ ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ TransitionEffect]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Slide\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ Width]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"300\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ Height]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"280\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ ]{style="FONT-FAMILY: Consolas; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                                        ]{style="FONT-FAMILY: Consolas; COLOR: black"}[ TabStripButtonVisibility]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Collapsed\"\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [        ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------+
| **[C#]{style="FONT-FAMILY: Consolas"}**                                                   |
|                                                                                           |
| ``` {style="BACKGROUND: white"}                                                           |
|                                                                                           |
| ```                                                                                       |
|                                                                                           |
| ``` {style="BACKGROUND: white"}                                                           |
|             TabNavigationControl tabNavControl = new TabNavigationControl();              |
| ```                                                                                       |
|                                                                                           |
| ``` {style="BACKGROUND: white"}                                                           |
|             tabNavControl.TabStripButtonVisibility = System.Windows.Visibility.Collapsed; |
| ```                                                                                       |
|                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                |
+-------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: blue"} 

 

 

+----------------------------------------------------------------------------------------------------------------------------------------------------+
| **VB**                                                                                                                                             |
|                                                                                                                                                    |
| [Dim tabNavControl As New TabNavigationControl()]{style="FONT-FAMILY: 'Courier New'; COLOR: #2e2e2e; FONT-SIZE: 9pt"}                              |
|                                                                                                                                                    |
| [tabNavControl.TabStripButtonVisibility = System.Windows.Visibility.Collapsed]{style="FONT-FAMILY: 'Courier New'; COLOR: #2e2e2e; FONT-SIZE: 9pt"} |
|                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------+

 

![Description: cid:image003.png@01CC2C8D.F8A51100](cid:image003.png@01CC2C8D.F8A51100){#_x0000_i1407 border="0" width="357" height="307"}

Figure 846: Tab Strip Ellipses hidden

[]{#related-topics}
:::
