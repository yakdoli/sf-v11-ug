::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to drag and drop a node from TreeViewAdv to XPTaskBar? {#how-to-drag-and-drop-a-node-from-treeviewadv-to-xptaskbar style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

This can be achieved by handling the **ItemDrag** event of TreeViewAdv and **DragDrop** event of the XPTaskBar.

 

The following code snippet illustrates this.

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} treeViewAdv1_ItemDrag([object]{style="COLOR: blue"} sender, System.Windows.Forms.[ItemDragEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                              |
| [    [TreeViewAdv]{style="COLOR: #2b91af"} treeViewAdv = ([TreeViewAdv]{style="COLOR: #2b91af"})sender;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                              |
| [    [TreeNodeAdv]{style="COLOR: #2b91af"}\[\] nodes = ([TreeNodeAdv]{style="COLOR: #2b91af"}\[\])e.Item;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                              |
| [    [TreeNodeAdv]{style="COLOR: #2b91af"} node = nodes\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                              |
| [    [this]{style="COLOR: blue"}.treeViewAdv1.DoDragDrop(node.Text, [DragDropEffects]{style="COLOR: #2b91af"}.All);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} xPTaskBar1_DragOver([object]{style="COLOR: blue"} sender, System.Windows.Forms.[DragEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    e.Effect = [DragDropEffects]{style="COLOR: #2b91af"}.All;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} xPTaskBar1_DragDrop([object]{style="COLOR: blue"} sender, System.Windows.Forms.[DragEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    [if]{style="COLOR: blue"} (e.Data.GetDataPresent([DataFormats]{style="COLOR: #2b91af"}.StringFormat))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                              |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                              |
| [        [string]{style="COLOR: blue"} str = System.[Convert]{style="COLOR: #2b91af"}.ToString(e.Data.GetData([DataFormats]{style="COLOR: #2b91af"}.StringFormat));]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                                                              |
| [        [Point]{style="COLOR: #2b91af"} pt = xpTaskBarBox3.PointToClient([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(e.X, e.Y));]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                                              |
| [        Syncfusion.Windows.Forms.Tools.[XPTaskBarItem]{style="COLOR: #2b91af"} taskItem = xpTaskBarBox3.HitTest(pt);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                                              |
| [        taskItem.Text = str;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                              |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                              |
| [} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#p700} 

[]{#related-topics}
:::
