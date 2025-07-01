::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Through C# {#through-c style="tab-stops: 0pt"}

To create a GroupBar control in C#, include the following namespace to the directives list.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                            |
|                                                                                                                                                             |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ Syncfusion.Windows.Tools.Controls;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                             |
|                                                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Next, create the GroupBar as follows.

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                   |
| [       ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[     [GroupBar]{style="COLOR: #2b91af"} gBar = [new]{style="COLOR: blue"} [GroupBar]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                      |
|                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                   |
| [            [GroupBarItem]{style="COLOR: #2b91af"} gBarItem1 = [new]{style="COLOR: blue"} [GroupBarItem]{style="COLOR: #2b91af"}() { HeaderText =[\"NewGroupBarItem1\"]{style="COLOR: #a31515"},                                   IsSelected = [true]{style="COLOR: blue"} };]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                                   |
| [        ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                   |
| [            [GroupView]{style="COLOR: #2b91af"} gView = [new]{style="COLOR: blue"} [GroupView]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                   |
| [            [GroupViewItem]{style="COLOR: #2b91af"} gViewItem = [new]{style="COLOR: blue"} [GroupViewItem]{style="COLOR: #2b91af"}() { Text=[\"New GroupViewItem\"]{style="COLOR: #a31515"}};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                  |
|                                                                                                                                                                                                                                                                                                                                   |
| [            gView.Items.Add(gViewItem);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                   |
| [            gBarItem1.Content = gView;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                   |
| [            [GroupBarItem]{style="COLOR: #2b91af"} gBarItem2 = [new]{style="COLOR: blue"} [GroupBarItem]{style="COLOR: #2b91af"}() { HeaderText=[\"NewGroupBarItem2\"]{style="COLOR: #a31515"}};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                   |
| [            [GroupBarItem]{style="COLOR: #2b91af"} gBarItem3 = [new]{style="COLOR: blue"} [GroupBarItem]{style="COLOR: #2b91af"}() { HeaderText=[\"NewGroupBarItem3\"]{style="COLOR: #a31515"}};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                   |
| [            gBar.Items.Add(gBarItem1);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                   |
| [            gBar.Items.Add(gBarItem2);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                   |
| [            gBar.Items.Add(gBarItem3);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

This will generate the following GroupBar control.

![](ImagesExt/image30_497.jpg){border="0"}

Figure 540: GroupBarControl Created with C#

 

 

 

 

 

[]{#p337} 

[]{#related-topics}
:::
