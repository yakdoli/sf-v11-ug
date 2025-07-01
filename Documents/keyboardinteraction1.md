::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Keyboard Interaction

The QueryContinueDrag event is fired on each key stroke while dragging the object. The DragKey property of the DragDropEventArgs gives the key that is currently pressed. It will be set to none when the user released the key. Also, the drag and drop operation gets cancelled when the Esc (escape) key in the keyboard is pressed.

 

Use Case Scenarios

The user can set the DragMode to Move or Copy and this depends on the key pressed. For example, the DragMode can set to Copy when the control (Ctrl) key is pressed.

 

Adding Keyboard Interaction to an Application

The QueryContinueDrag event handler is used to implement the keyboard interaction for the drag and drop operation. The following lines of code show this:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DragAndDropManager_QueryContinueDrag([object ]{style="COLOR: blue"}sender,[DragDropEventArgs]{style="COLOR: #2b91af"}   ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| [   args)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                        |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                        |
| [  [if]{style="COLOR: blue"} (args.DragKey == [Key]{style="COLOR: #2b91af"}.Ctrl)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                        |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                        |
| [    [if]{style="COLOR: blue"} (file != [null]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                        |
| [     args.DropDescription = [\"Copy To \"]{style="COLOR: #a31515"} + file.Name;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                        |
| [    [DragAndDropManager]{style="COLOR: #2b91af"}.SetDragMode([this]{style="COLOR: blue"}, [DragMode]{style="COLOR: #2b91af"}.Copy);]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                        |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                        |
| [ [else]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [    [if]{style="COLOR: blue"} (file != [null]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                        |
| [     args.DropDescription = [\"Move To \"]{style="COLOR: #a31515"} + file.Name;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                        |
| [    [DragAndDropManager]{style="COLOR: #2b91af"}.SetDragMode([this]{style="COLOR: blue"}, [DragMode]{style="COLOR: #2b91af"}.Move);]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                        |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                        |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#SetCancelOnEscape}The cancel on escape behavior can be disabled by using the static method SetCancelOnEscape() available in DragAndDropManager. The following lines of code show this:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MainPage()]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                    |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                    |
| [  InitializeComponent();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                    |
| [  [DragAndDropManager]{style="COLOR: #2b91af"}.SetCancelOnEscape([this]{style="COLOR: blue"}, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                    |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
