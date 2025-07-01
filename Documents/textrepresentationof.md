::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#GetText}Text Representation of a Given File

The GetText() function returns the text format of the given input file.

 

Use Case Scenarios

The method GetText() is very useful when the user wants to view the content of the text file just by dropping it into the display panel,. This method returns the string and contains the text in the given file. It will be displayed easily in the display panel.

 

Adding Text Representation of a Given File to an Application

The following code shows the use of GetText() method:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                              |
|                                                                                                                                                                                                               |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DragAndDropManager_Drop([object]{style="COLOR: blue"} sender, [DragDropEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                               |
| [ if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (args.PayLoad [is]{style="COLOR: blue"} [File]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                               |
| [  {             ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [   [File]{style="COLOR: #2b91af"} file = args.PayLoad [as]{style="COLOR: blue"} [File]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                               |
| [   [Panel]{style="COLOR: #2b91af"} panel = args.DropTarget [as]{style="COLOR: blue"} [Panel]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                               |
| [   [string]{style="COLOR: blue"} text = [DragAndDropManager]{style="COLOR: #2b91af"}.GetText(file.Path);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                               |
| [   [RichTextBox]{style="COLOR: #2b91af"} textBox = GetTextBox(text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                               |
| [   panel.Children.Add(textBox); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                               |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                               |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
