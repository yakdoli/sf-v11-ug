::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### UI Command Update Patterns {#ui-command-update-patterns style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The UI Command Update mechanism can be defined as the way in which, an application updates the state of the UI elements (BarItems in this case), as the state of the application changes.

 

Different frameworks support different ways of UI state update mechanism. Each has its own merits and demerits and each one is appropriate in some scenarios and not so in the other.

 

The **XP Menus framework**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}supports multiple patterns of UI Command Update mechanism, which are discussed below.

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Supply-Push Approach**

[]{style="COLOR: #15428b"} 

In this approach, the state of the BarItem is changed as and when the corresponding application state changes. This is what the XP Menus framework expects you to do by default; it will not commence the[ ]{style="COLOR: black"}[UpdateUI]{.UGHyperlink}[ ]{style="COLOR: black"}event under any circumstances.

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Demand-Pull Approach**

**[]{style="COLOR: #15428b"}** 

This approach can be difficult, as it is sometimes cumbersome to keep track of state changes in the application and update the UI state appropriately.

 

So, the framework provides two other alternative ways to update the BarItem states.

[]{style="COLOR: #15428b"} 

Fast Updates

[]{style="COLOR: #15428b"} 

If updating the BarItem states is a trivial operation, use this approach, which is also how MFC does it. In this approach, the **UpdateUI**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}event will be called when the ParentBarItem hosting this BarItem is dropped-down, when the BarItem is hosted in a toolbar and when the application goes into an idle state or when a shortcut corresponding to this item is about to be processed. You can turn on this behavior throughout the menu structure by setting the[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}**BarManager.UpdateUIMFCStyle**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}to **True**[. ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}For XPToolbars and ParentBarItems that are outside the scope of a BarManager, set the **UpdateUIMFCStyle**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}property in those instances explicitly.

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                     |
|                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                           |
|                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.UpdateUIMFCStyle = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                               |
|                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.UpdateUIMFCStyle  = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Slow Updates

[]{style="COLOR: #15428b"} 

If updating the BarItem states is not a trivial operation, then use this approach. In this approach, turn on the[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}**UpdateUIOnAppIdle**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}property of the BarItem whose state has changed one or more times and the framework will then initiate its **UpdateUI**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black"}event the next time the application goes into an idle state.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                |
|                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.barItem1.UpdateUIOnAppIdle = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                   |
|                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                      |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.barItem1.UpdateUIOnAppIdle = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[UpdateUI Event]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
:::
