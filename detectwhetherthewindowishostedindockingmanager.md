::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Detect whether the window is hosted in DockingManager {#detect-whether-the-window-is-hosted-in-dockingmanager style="tab-stops: 0pt"}

 

There two ways to detect whether a **FrameworkElement** is hosted **in DockingManager** or not. They are: 

1.   Getting **DockingManager** instance for a **FrameworkElement** and checking whether it is null or not.

2.   Detecting whether the **FrameworkElement** is present in the Children collection of DockingManager.

 

The two ways are shown below:

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                     |
|                                                                                                                                                                                                      |
| [//Getting **DockingManager** Instance.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                           |
|                                                                                                                                                                                                      |
| **[DockingManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}**[ manager=**[DockingManager]{style="COLOR: #2b91af"}**.Get**DockingManager**(element1);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                      |
| [//Checking whether element1 is in children collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                                                      |
| **[DockingManager]{style="FONT-FAMILY: 'Courier New'"}**[.Children.Contains(element1);[]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
