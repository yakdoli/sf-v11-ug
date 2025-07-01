::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Get the Drop Position

 

[]{#MouseEventArgs}The MouseEventArgs property in DragDropEventArgs contains the GetPosition() function. It will give the position of the mouse on dropping the object.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                               |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DragAndDropManager_Drop([object]{style="COLOR: blue"} sender, [DragDropEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [ {            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                               |
| [  [Image]{style="COLOR: #2b91af"} img = args.PayLoad [as]{style="COLOR: blue"} [Image]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                               |
| [  [Point]{style="COLOR: #2b91af"} mousepoint = args.MouseEventArgs.GetPosition(sender [as]{style="COLOR: blue"} [UIElement]{style="COLOR: #2b91af"});]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                               |
| [  if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[(img != [null]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                               |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                               |
| [       [Canvas]{style="COLOR: #2b91af"}.SetLeft(img, mousepoint.X);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                               |
| [       [Canvas]{style="COLOR: #2b91af"}.SetTop(img, mousepoint.Y);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                               |
| [      }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                               |
| [  }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
