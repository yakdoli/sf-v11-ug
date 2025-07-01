::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Through Code {#through-code style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The Grid List control sample that ships with Essential Grid does not use the designer. It creates an ArrayList of objects that serves as a data source for the Grid List control. Each state object has a LongName, ShortName and **ImageIndex** properties that can be displayed in the list control. Here are some code samples that illustrate the assignments of the major properties.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For the complete implementation details, refer to the sample in the below installation path.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

***\<Install Location\>\\Syncfusion\\EssentialStudio\\\[Version Number\]\\Windows\\Grid.Windows\\Samples\\2.0\\Grid List Control***

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                    |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                              |
|                                                                                                                   |
| [// Set to arraylist of states.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                |
|                                                                                                                   |
| [gridListBox1.DataSource = USStates;]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                   |
| [// ImageList-the images displayed in the list.      ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}          |
|                                                                                                                   |
| [gridListBox1.ImageList = imageList;]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                   |
| [// Displays multiple columns.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                 |
|                                                                                                                   |
| [gridListBox1.MultiColumn = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                   |
| [gridListBox1.ShowColumnHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                   |
| [gridListBox1.SelectionMode = [SelectionMode]{style="COLOR: #2b91af"}.One;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                   |
| [// Makes the last column wide enough to fill the client area.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                   |
| [gridListBox1.FillLastColumn = [true]{style="COLOR: blue"}; ]{style="FONT-FAMILY: 'Courier New'"}                 |
+-------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                         |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [\' Set to arraylist of states.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                            |
| [gridListBox1.DataSource = USStates        ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                             |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [\' ImageList-the images displayed in the list.       ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                            |
| [gridListBox1.ImageList = ImageList           ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                          |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [\' Displays multiple columns.       ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                            |
| [gridListBox1.MultiColumn = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[                ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                            |
| [gridListBox1.ShowColumnHeader = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                |
|                                                                                                                                                                                                            |
| [gridListBox1.SelectionMode = SelectionMode.One]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                         |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [\' Makes last column.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                            |
| [gridListBox1.FillLastColumn = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[             ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p520} 

 

[]{#related-topics}
:::
