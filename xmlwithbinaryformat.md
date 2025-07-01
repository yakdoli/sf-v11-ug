::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### XML with Binary Format {#xml-with-binary-format style="tab-stops: 0pt"}

 

The DockingManager enables you to save or load the states of the elements on an XML file in binary format. To save the state in XML using binary format, use the following code.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                              |
| [//Save state in XML using Binary Format.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}       |
|                                                                                                                                                                              |
| [BinaryFormatter formatter1 = [new]{style="COLOR: blue"} BinaryFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                           |
|                                                                                                                                                                              |
| [DocManager1.SaveDockState(formatter1, StorageFormat.Xml, [@\"C:\\docking_xml.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}        |
|                                                                                                                                                                              |
| [//Load state saved in XML using Binary Format.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                              |
| [BinaryFormatter formatter1 = [new]{style="COLOR: blue"} BinaryFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                           |
|                                                                                                                                                                              |
| [DocManager1.LoadDockState(formatter1, StorageFormat.Xml, [@\"c:\\docking_xml.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::
