::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### State Persistence {#state-persistence style="tab-stops: 0pt"}

This topic illustrates loading and saving the dock state in various places. It also gives information about resetting and deleting the states.

 

Load and Save in Registry

In the Document Container, you can save and load dock states into the Registry using the **SaveDockState** and **LoadDockState** methods. Refer to the following code snippet for setting these methods.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                   |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| [// Code to Save State:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                       |
|                                                                                                                                                                                                                                  |
| [BinaryFormatter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ formatter1 = [new]{style="COLOR: blue"} [BinaryFormatter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                  |
| [DocContainer.SaveDockState(formatter1);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                    |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| [// Code to Load State:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                       |
|                                                                                                                                                                                                                                  |
| [BinaryFormatter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ formatter1 = [new]{style="COLOR: blue"} [BinaryFormatter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                  |
| [DocContainer.LoadDockState(formatter1);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Load and Save in Isolated Storage

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In the Document Container you can Load/Save/Reset the dock state in the Isolated Storage. To Load, Save and Reset, use the following code snippet.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                      |
|                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                     |
| [// Code to Save:]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                |
|                                                                                     |
| [DocContainer.SaveDockState();]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                     |
| [// Code to Load:]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                |
|                                                                                     |
| [DocContainer.LoadDockState();]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                     |
| [// Code to Reset:]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}               |
|                                                                                     |
| [DocContainer.DeleteInternalIsolatedStorage();]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Load and Save in XML

 

You can save and load the data for the Document Container in XML also. To Load and Save data in XML use the following code snippet. This is done by using both Binary Formatter as well as Soap Formatter as follows.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                                |
| [ [// Code to Save in XML using Binary Formatter:]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                  |
|                                                                                                                                                                                                                                                |
| [BinaryFormatter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ formatter1 = [new]{style="COLOR: blue"} [BinaryFormatter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}               |
|                                                                                                                                                                                                                                                |
| [DocContainer.SaveDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Xml, [@\"d:\\docum_xml.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                   |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                |
| [// Code save in XML using SOAP formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                  |
|                                                                                                                                                                                                                                                |
| [SoapFormatter formatter1 = [new]{style="COLOR: blue"} SoapFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                   |
|                                                                                                                                                                                                                                                |
| [DocContainer.SaveDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Xml, [@\"d:\\docum_xml.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                   |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                |
| [// Code to Load XML using Binary formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                |
|                                                                                                                                                                                                                                                |
| [BinaryFormatter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ formatter1 = [new]{style="COLOR: blue"} [BinaryFormatter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}               |
|                                                                                                                                                                                                                                                |
| [DocContainer.LoadDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Xml, [@\"d:\\docum_xml.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                   |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                |
| [// Code to Load XML using Soap Formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                  |
|                                                                                                                                                                                                                                                |
| [SoapFormatter formatter1 = [new]{style="COLOR: blue"} SoapFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                   |
|                                                                                                                                                                                                                                                |
| [DocContainer.LoadDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Xml, [@\"]{style="COLOR: #a31515"}[d:\\docum_xml.xml]{style="COLOR: black"}[\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Load and Save in Bin

 

Document Container enables the user to save and load the data in BIN. Refer to the following code snippet for saving or loading data in BIN. This is achieved by using Binary Formatter and Soap Formatter as well.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                   |
|                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                         |
|                                                                                                                                                                                                                                  |
| [// Code to Save Using Binary Formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                      |
|                                                                                                                                                                                                                                  |
| [BinaryFormatter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ formatter1 = [new]{style="COLOR: blue"} [BinaryFormatter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                  |
| [DocContainer.SaveDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Binary, [@\"d:\\docum_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                  |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| [// Code to Save Using Soap Formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                        |
|                                                                                                                                                                                                                                  |
| [SoapFormatter formatter1 = [new]{style="COLOR: blue"} SoapFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                     |
|                                                                                                                                                                                                                                  |
| [DocContainer.SaveDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Binary, [@\"d:\\docum_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                  |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| [// Code to Load using Binary Formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                      |
|                                                                                                                                                                                                                                  |
| [BinaryFormatter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ formatter1 = [new]{style="COLOR: blue"} [BinaryFormatter]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                  |
| [DocContainer.LoadDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Binary, [@\"d:\\docum_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                  |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| [// Code to Load using Soap Formatter:]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                        |
|                                                                                                                                                                                                                                  |
| [SoapFormatter formatter1 = [new]{style="COLOR: blue"} SoapFormatter();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                     |
|                                                                                                                                                                                                                                  |
| [DocContainer.LoadDockState(formatter1, [StorageFormat]{style="COLOR: #2b91af"}.Binary, [@\"d:\\docum_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Reset the states in Document Container

 

You can easily reset the states in Document Container by using the **ResetState** method as in the below code snippet.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                         |
|                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                               |
|                                                                                                                                                                                                                                        |
| [DocumentContainer]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ DocContainer = [new]{style="COLOR: blue"} [DocumentContainer]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                        |
| [// Reset the states]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                |
|                                                                                                                                                                                                                                        |
| [DocContainer.ResetState();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Delete the State

 

You can delete all the states you have created in the Document Container by using the **DeleteDockState** property. Refer to the below code example.

 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                        |
|                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                |
|                                                                                                                                       |
| [DocContainer.DeleteDockState([@\"d:\\docum_xml.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                       |
| [DocContainer.DeleteDockState([@\"d:\\docum_bin.bin\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                       |
| [DocContainer.DeleteDockState();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
