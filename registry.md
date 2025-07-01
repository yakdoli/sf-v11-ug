::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Registry {#registry style="tab-stops: 0pt"}

 

You can save or load the States of the DockingManager elements from the registry. To save or load the states to or from the system registry respectively, use the following code.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                 |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                  |
| [//Save state in System Registry.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}   |
|                                                                                                                                                                  |
| [BinaryFormatter formatter1 = [new]{style="COLOR: blue"} BinaryFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                               |
|                                                                                                                                                                  |
| [DocManager1.SaveDockState(formatter1);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                   |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                         |
|                                                                                                                                                                  |
| [//Load state from System Registry.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                  |
| [BinaryFormatter formatter1 = [new]{style="COLOR: blue"} BinaryFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                               |
|                                                                                                                                                                  |
| [DocManager1.LoadDockState(formatter1);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::
