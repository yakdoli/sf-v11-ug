::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to view the hidden Items in a GroupView programmatically {#how-to-view-the-hidden-items-in-a-groupview-programmatically style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

 

GroupView\'s **BringItemIntoView** method can be used to scroll down to a hidden item and bring that item into view.

 

The following code snippet illustrates this.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                  |
|                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                            |
|                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupView1.SelectedItem = 20; ]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                 |
| [// This will scroll to Item 20. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupView1.BringItemIntoView(20);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                           |
|                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                         |
|                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupView1.SelectedItem = 20]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                              |
| [\' This will scroll to Item 20. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                         |
|                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupView1.BringItemIntoView(20)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#p663} 

 

[]{#related-topics}
:::
