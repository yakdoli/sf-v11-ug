::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to hide the header?

You can hide the header for customization purposes. Set the HeaderVisibility property to "Collapse", to hide the header.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **XAML**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ TransitionEffect]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Slide\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ Width]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"300\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ Height]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"280\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ ]{style="FONT-FAMILY: Consolas; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [                                        ]{style="FONT-FAMILY: Consolas; COLOR: black"}[ HeaderVisibility]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Collapsed\"\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [        ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------+
| **C#**                                                                            |
|                                                                                   |
| ``` {style="BACKGROUND: white"}                                                   |
|                                                                                   |
| ```                                                                               |
|                                                                                   |
| ``` {style="BACKGROUND: white"}                                                   |
|             TabNavigationControl tabNavControl = new TabNavigationControl();      |
| ```                                                                               |
|                                                                                   |
| ``` {style="BACKGROUND: white"}                                                   |
|             tabNavControl.HeaderVisibility = System.Windows.Visibility.Collapsed; |
| ```                                                                               |
|                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                        |
+-----------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: blue"} 

+--------------------------------------------------------------------------------------------------------------------------------------------+
| **VB**                                                                                                                                     |
|                                                                                                                                            |
| ``` {style="BACKGROUND: white"}                                                                                                            |
|                                                                                                                                            |
| ```                                                                                                                                        |
|                                                                                                                                            |
| [Dim tabNavControl As New TabNavigationControl()]{style="FONT-FAMILY: 'Courier New'; COLOR: #2e2e2e; FONT-SIZE: 9pt"}                      |
|                                                                                                                                            |
| [tabNavControl.HeaderVisibility = System.Windows.Visibility.Collapsed]{style="FONT-FAMILY: 'Courier New'; COLOR: #2e2e2e; FONT-SIZE: 9pt"} |
|                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: blue"} 

``` {style="BACKGROUND: white"}
 
```

``` {style="BACKGROUND: white"}
 
```

![Description: cid:image001.png@01CC2C8E.3451B550](cid:image001.png@01CC2C8E.3451B550){#_x0000_i1405 border="0" width="336" height="303"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}

Figure 848: Header Hidden

[]{#related-topics}
:::
