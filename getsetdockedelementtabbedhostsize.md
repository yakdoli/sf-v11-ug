::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Get/Set DockedElementTabbed host size {#getset-dockedelementtabbed-host-size style="tab-stops: 0pt"}

**Get/Set HostSize()** method has direct control over the size of the **DockedElementTabbedHost**,  which  acts as a container for the dockingchild in both Dock and Float state. The container for Dock and Float state, which belongs to the given element, can be obtained as follows.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                              |
|                                                                                                                                                                                                                                               |
| [//To get DockedElementTabbedHost Container for Dock State.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                                                               |
| [DockedElementTabbedHost]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dockHost = **[DockingManager]{style="COLOR: #2b91af"}**.ResolveHost(element, [DockState]{style="COLOR: #2b91af"}.Dock);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [//To get DockedElementTabbedHost Container for float State.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                               |
|                                                                                                                                                                                                                                               |
| [DockedElementTabbedHost]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ floathost = **[DockingManager]{style="COLOR: #2b91af"}**.ResolveHost(element, [DockState]{style="COLOR: #2b91af"}.Float);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Now you can set the size of the host as follows:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                   |
| [//To get DockedElementTabbedHost Container for Dock State.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                                                   |
| [DockedElementTabbedHost]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dockHost = **[DockingManager]{style="COLOR: #2b91af"}**.ResolveHost(element, [DockState]{style="COLOR: #2b91af"}.Dock);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                   |
| [//To set HostSize.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                   |
| **[DockingManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}**[.SetHostSize(dockHost, [new]{style="COLOR: blue"} [Size]{style="COLOR: #2b91af"}(50, 100));]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                   |
| [//To get HostSize.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                   |
| [Size]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ hostsize = **[DockingManager]{style="COLOR: #2b91af"}**.GetHostSize(dockHost);[]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
