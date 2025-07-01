::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Binary with SOAP Format {#binary-with-soap-format style="tab-stops: 0pt"}

 

You can save or load the states of the docking elements from a binary file in SOAP format. To save or load the states of the elements from or to the binary file with SOAP format, use the following code.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                   |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray; FONT-SIZE: 9.5pt"}[Save state in Binary file using SOAP Format]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                   |
| [SOAPFormatter formatter1 = [new]{style="COLOR: blue"} SOAPFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                    |
|                                                                                                                                                                                                                                                   |
| [DocManager1.SaveDockState(formatter1, StorageFormat.Binary, [@\"c:\\docking_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                          |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                   |
| [//Load state saved in Binary file using SOAP Format]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                 |
|                                                                                                                                                                                                                                                   |
| [SOAPFormatter formatter1 = [new]{style="COLOR: blue"} SOAPFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                    |
|                                                                                                                                                                                                                                                   |
| [DocManager1.LoadDockState(formatter1, StorageFormat.Xml, [@\"c:\\docking_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::
