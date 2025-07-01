::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### AutoSearch support

TreeViewAdv supports AutoSearch as in File explorer. It automatically navigates to the particular TreeViewItemAdv (like in File Explorer) when you press any character and selects that particular TreeViewItem. You can also enable or disable this feature by using **AutoSearchEnabled** property. If TreeViewAdv is binded with business objects, then the search will be based on **DisplayMemberPath** property.

Use Case Scenarios

Using the AutoSearch support feature, you can perform your search in TreeViewAdv as you do in a File explorer.

Enabling AutoSearch support

To enable AutoSearch, you have to set the **AutoSearchEnabled** Property to True.

The following code illustrates this.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[TreeViewAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"treeview1\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AutoSearchEnabled]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"True\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ItemsSource]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"{]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Binding]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Products]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[}\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                         |
|                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                          |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeview1.AutoSearchEnabled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Properties

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

Table 27: AutoSearch Properties Table

  ------------------- ------------------------------------------------------------------------------------------------------------- -------------------- -------------- -----------------
  Property            Description                                                                                                   Type                 Data Type      Reference links
  AutoSearchEnabled   This enables or disables AutoSearch support in TreeViewAdv.                                                   DependencyProperty   False          
  DisplayMemberPath   If TreeViewAdv is binded with business objects,then the search will be based on DisplayMemberPath property.   DependencyProperty   String.Empty    
  ------------------- ------------------------------------------------------------------------------------------------------------- -------------------- -------------- -----------------

 

Sample link

A sample application that illustrates AutoSearch support is distributed along with the Essential Tools Silverlight installation and can be found at:****

**\<sample installation location\>\\Syncfusion\\EssentialStudio\\Version Number\\Silverlight\\Syncfusion.Tools.Silverlight.Samples\\Samples\\TreeView\\TreeView Demo\\TreeViewDemo.xaml**

[]{#related-topics}
:::
