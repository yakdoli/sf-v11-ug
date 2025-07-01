::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Return Animation

The Return Animation feature gives more visual effect to the drag and drop operation. On cancelling the drag operation, the dragged object returns to its original position with the animation.

 

Use Case Scenarios

The Return Animation feature is helpful to know what happens after dropping the object. The Return Animation clearly shows that the drop target did not accept the dragged object.

 

Adding Return Animation to the Application

The Return Animation feature is enabled in DragAndDropManager by default. It can be disabled by []{#SetEnableReturnAnimation}the SetEnableReturnAnimatin() function. This is shown in the following code snippet.

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                       |
|                                                                                                                                                                                                  |
|                                                                                                                                                                                                  |
|                                                                                                                                                                                                  |
| [   [public]{style="COLOR: blue"} ListBoxDragAndDropDemo()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                     |
|                                                                                                                                                                                                  |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                  |
| [            InitializeComponent();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                            |
|                                                                                                                                                                                                  |
| [            [DragAndDropManager]{style="COLOR: #2b91af"}.SetEnableReturnAnimation([this]{style="COLOR: blue"}, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                  |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                  |
| [              ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
