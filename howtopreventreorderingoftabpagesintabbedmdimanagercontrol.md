::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to prevent reordering of Tab Pages in TabbedMDIManager Control {#how-to-prevent-reordering-of-tab-pages-in-tabbedmdimanager-control style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

The reordering of tab pages can be prevented by implementing the below code snippet. For this derive a class from TabbedMDIManager and override the **MDITabPanel** property and set the **UserMoveTabs** property of MDITabPanel to True.

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                            |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                      |
|                                                                                                           |
| [// Derive a class from TabbedMDIManager. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}             |
|                                                                                                           |
| [// Override MDITabPanel property. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                           |
| [// Set MDITabPanel\'s UserMoveTabs property to False.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                           |
| [tabPanel.UserMoveTabs = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}               |
+-----------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                        |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                       |
|                                                                                                           |
| [\' Derive a class from TabbedMDIManager. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}             |
|                                                                                                           |
| [\' Override MDITabPanel property. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                           |
| [\' Set MDITabPanel\'s UserMoveTabs property to False.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                           |
| [tabPanel.UserMoveTabs = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                |
+-----------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p937} 

[]{#related-topics}
:::
