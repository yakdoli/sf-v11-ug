::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Drag--and-Drop

Drag-and-Drop enables you to drag the TileViewItems in the TileViewControl in a normal state. Once the TileViewItem is dragged, the other items in the TileViewControl moves to the corresponding positions in accordance to the dragging item. This can be enabled and disabled by using the **AllowItemsRepositioning** property.

 

Adding Dragging Items to an Application

The Dragging items can be added to an application by using either XAML or C# code.

 

Adding through XAML

The following code example illustrates how to add the Dragging Items to an application through XAML.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[TileViewControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"tileViewCntrl\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: red"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [                            AllowItemRepositioning]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"True\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Adding through C#

The following code example illustrates how to add the Dragging Items to an application through C#.

 

+-------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                          |
|                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                |
|                                                                                                                                           |
| [tileViewCntrl.AllowItemRepositioning = true;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[   ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                           |
| [           ]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------+

 

Properties

Table 32: MinimizedItemTemplate / MaximizedItemTemplate Properties Table

  ------------------------ ------------------------------------------------------ -------------------- ----------- -----------------
  Property                 Description                                            Type                 Data Type   Reference links
  AllowItemRepositioning   Enables or disables the TileViewItems from dragging.   DependencyProperty   True        
  ------------------------ ------------------------------------------------------ -------------------- ----------- -----------------

 

Events

Table 33:  EVENT Table

  Event                           Description                                                                    Arguments   Type   Reference links
  ------------------------------- ------------------------------------------------------------------------------ ----------- ------ -----------------
  AllowItemRepositioningChanged   The event gets fired when the dragging items feature is enabled or disabled.                      

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

To view samples:

 

1.   Select Start -\> Programs -\> Syncfusion -\> Essential Studio x.x.xx -\> Dashboard.

2.   Select   Run Locally Installed Samples in Silverlight Button.

3.   Now expand the DragAndDropManagerDemo tree-view item in the Sample Browser.

4.   Choose any one of the samples listed under it to launch.

 

[]{#related-topics}
:::
