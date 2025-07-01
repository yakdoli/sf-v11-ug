::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Transition effects

 

Transition Effect property is used to set the effect for the Tab navigation control. The Transition effect is an enum that contains five values namely:

 

[·      ]{style="FONT-FAMILY: Symbol"}Slide -- The item/page navigates with slide effect

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: Consolas"}**                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ TransitionEffect]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Slide\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[  ]{style="FONT-FAMILY: Consolas; COLOR: black"}                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [                                        ]{style="FONT-FAMILY: Consolas; COLOR: black"}[ ItemsSource]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"{]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Binding]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ MyCollection]{style="FONT-FAMILY: Consolas; COLOR: red"}[}\"\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [        ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: #a31515"} 

[·      ]{style="FONT-FAMILY: Symbol"}Fade -- During navigation, the previous item fades out and the new item appears with variation in opacity

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [  ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [ ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ TransitionEffect]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Fade\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[  ]{style="FONT-FAMILY: Consolas; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [                                        ]{style="FONT-FAMILY: Consolas; COLOR: black"}[ ItemsSource]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"{]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Binding]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ MyCollection]{style="FONT-FAMILY: Consolas; COLOR: red"}[}\"\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [        ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}News Flash -- The new item enters with a rotation effect during navigation

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
| <syncfusion:TabNavigationControl TransitionEffect="NewsFlash"                  |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Zoom -- The new item appears with a zooming effect

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|   <syncfusion:TabNavigationControl TransitionEffect="Zoom"                     |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Flip -- The new item appears with a page turn effect

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ TransitionEffect]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Flip\"]{style="FONT-FAMILY: Consolas; COLOR: blue"}[  ]{style="FONT-FAMILY: Consolas; COLOR: black"}                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [                                        ]{style="FONT-FAMILY: Consolas; COLOR: black"}[ ItemsSource]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"{]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Binding]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ MyCollection]{style="FONT-FAMILY: Consolas; COLOR: red"}[}\"\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: Consolas; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [        ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[TabNavigationControl]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas; COLOR: black"}                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Blur -- The new item appears with blur effect

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|  <syncfusion:TabNavigationControl TransitionEffect="Blur"                      |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Push -- The new item descends from the top

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|  <syncfusion:TabNavigationControl TransitionEffect="Push"                      |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}PushIn -- The new item ascends from the bottom

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|  <syncfusion:TabNavigationControl TransitionEffect="PushIn"                    |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Wipe -- The old item gets washed out and the new slide appears.

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|  <syncfusion:TabNavigationControl TransitionEffect="Wipe"                      |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Uncover -- The old item gets uncovered and the new content appears.

 

+--------------------------------------------------------------------------------+
| **[XAML]{style="FONT-FAMILY: Consolas"}**                                      |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|  <syncfusion:TabNavigationControl TransitionEffect="Uncover"                   |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                          ItemsSource="{Binding MyCollection}"> |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|                                                                                |
| ```                                                                            |
|                                                                                |
| ``` {style="BACKGROUND: white"}                                                |
|         </syncfusion:TabNavigationControl>                                     |
| ```                                                                            |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
+--------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
