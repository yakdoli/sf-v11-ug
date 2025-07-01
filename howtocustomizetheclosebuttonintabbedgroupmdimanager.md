::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to customize the close button in TabbedGroupMDIManager {#how-to-customize-the-close-button-in-tabbedgroupmdimanager style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

This can be achieved by deriving **TabbedGroupMDIManager** class and overriding **GetCloseButtonBounds** method as follows.

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [class]{style="COLOR: blue"} [CustomTabbedMDI]{style="COLOR: #2b91af"} : [TabbedGroupedMDIManager]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                            |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                            |
| [    [public]{style="COLOR: blue"} CustomTabbedMDI() { }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [    [protected]{style="COLOR: blue"} [override]{style="COLOR: blue"} [MDITabPanel]{style="COLOR: #2b91af"} CreateMDITabPanel()]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                            |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                            |
| [        [return]{style="COLOR: blue"} [new]{style="COLOR: blue"} [CustomMDITabPanel]{style="COLOR: #2b91af"}([this]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                            |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                            |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                            |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [class]{style="COLOR: blue"} [CustomMDITabPanel]{style="COLOR: #2b91af"} : [MDITabPanel]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                            |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                            |
| [    [public]{style="COLOR: blue"} CustomMDITabPanel([TabbedMDIManager]{style="COLOR: #2b91af"} tm)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                            |
| [        : [base]{style="COLOR: blue"}(tm)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                            |
| [    { }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                            |
| [    [protected]{style="COLOR: blue"} [override]{style="COLOR: blue"} [Rectangle]{style="COLOR: #2b91af"} GetCloseButtonBounds()]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                            |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                            |
| [        [Rectangle]{style="COLOR: #2b91af"} rect = [base]{style="COLOR: blue"}.GetCloseButtonBounds();]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                            |
| [        rect.Width = 20; rect.Height = 20;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                            |
| [        [return]{style="COLOR: blue"} rect;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                            |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                            |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                      |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                           |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Class]{style="COLOR: blue"} CustomTabbedMDI : [Inherits]{style="COLOR: blue"} TabbedGroupedMDIManager]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                           |
| [    [Public]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} [New]{style="COLOR: blue"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                           |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                       |
|                                                                                                                                                                                                           |
| [    [Protected]{style="COLOR: blue"} [Overrides]{style="COLOR: blue"} [Function]{style="COLOR: blue"} CreateMDITabPanel() [As]{style="COLOR: blue"} MDITabPanel]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                           |
| [        [Return]{style="COLOR: blue"} [New]{style="COLOR: blue"} CustomMDITabPanel([Me]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                           |
| [    [End]{style="COLOR: blue"} [Function]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Class]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                           |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Class]{style="COLOR: blue"} CustomMDITabPanel : [Inherits]{style="COLOR: blue"} MDITabPanel]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                           |
| [    [Public]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} [New]{style="COLOR: blue"}([ByVal]{style="COLOR: blue"} tm [As]{style="COLOR: blue"} TabbedMDIManager)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| [        [MyBase]{style="COLOR: blue"}.New(tm)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                           |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                           |
| [    [Protected]{style="COLOR: blue"} [Overrides]{style="COLOR: blue"} [Function]{style="COLOR: blue"} GetCloseButtonBounds() [As]{style="COLOR: blue"} Rectangle]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                           |
| [        [Dim]{style="COLOR: blue"} rect [As]{style="COLOR: blue"} Rectangle = [MyBase]{style="COLOR: blue"}.GetCloseButtonBounds()]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                           |
| [        rect.Width = 20]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                           |
| [        rect.Height = 20]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                           |
| [        [Return]{style="COLOR: blue"} rect]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                           |
| [    [End]{style="COLOR: blue"} [Function]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Class]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p940} 

[]{#related-topics}
:::
