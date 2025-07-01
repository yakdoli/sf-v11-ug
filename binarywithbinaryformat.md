::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Binary with Binary format {#binary-with-binary-format style="tab-stops: 0pt"}

 

DockingManager also supports saving and loading the states of its elements in a binary file with binary format. To save or load using binary file with binary format, use the following code.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                     |
|                                                                                                                                                                                      |
| [//Save state in Binary file using Binary Format.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}       |
|                                                                                                                                                                                      |
| [BinaryFormatter formatter1 = [new]{style="COLOR: blue"} BinaryFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                   |
|                                                                                                                                                                                      |
| [DocManager1.SaveDockState(formatter1, StorageFormat.Binary, [@\"c:\\docking_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}             |
|                                                                                                                                                                                      |
| [//Load state saved in Binary file using Binary Format.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                      |
| [BinaryFormatter formatter1 = [new]{style="COLOR: blue"} BinaryFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                   |
|                                                                                                                                                                                      |
| [DocManager1.LoadDockState(formatter1, StorageFormat.Xml, [@\"c:\\docking_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::
