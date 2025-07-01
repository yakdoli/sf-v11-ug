::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Clear StatePersistance Entries {#clear-statepersistance-entries style="tab-stops: 0pt"}

 

In **StatePersistence** of **DockingManager** we have five ways to store the state. Similarly, we have ways to clear those entries as given below

 

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                  |
|                                                                                                                                                   |
| [//Deletes the Registry Entries.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                               |
|                                                                                                                                                   |
| **[DockingManager]{style="FONT-FAMILY: 'Courier New'"}**[.DeleteDockState();]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                   |
| [//Deletes the persistance file in Isolatedstorage location.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                   |
|                                                                                                                                                   |
| **[DockingManager]{style="FONT-FAMILY: 'Courier New'"}**[.DeleteInternalIsolatedStorage();]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                   |
| [//Deletes the specified state file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                           |
|                                                                                                                                                   |
| **[DockingManager]{style="FONT-FAMILY: 'Courier New'"}**[.DeleteDockState(filename);[]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

 

Refer Also

[[State Persistence in DockingManager]{.UGHyperlink}](ms-xhelp:///?Id=a61c5b27-730a-4df4-890a-fe72ccbbadd8)[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[]{#related-topics}
:::
