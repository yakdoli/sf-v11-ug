::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Serialization in GridDataControl {#serialization-in-griddatacontrol style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

GridDataControl state can be serialized in XML format.

All the properties that are exposed in GridDataTableProperties can be serilized.

Serializing

There are two methods to serialize forms:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}XML string

[·      ]{style="FONT-FAMILY: Symbol"}XML file

 

API Usage

Serializing as an XML String

The following code illustrates how to serialize as an XML string.

*[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}* 

+------------------------------------------------------------------------------------------------+
| [\[**C#\]**]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                 |
|                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                |
| [string result = this.dataGrid.Model.SerializeAsString();]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Serializing as an XML File

The following code illustrates how to serialize as an XML file.

*[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}* 

+--------------------------------------------------------------------------------------+
| [\[**C#\]**]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black"}         |
|                                                                                      |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                   |
|                                                                                      |
| [this.dataGrid.Model.Serialize(\"sample.xml\");]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------+

***[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}*** 

De-serializing

There are two methods to serialize forms:

[·      ]{style="FONT-FAMILY: Symbol"}XML string

[·      ]{style="FONT-FAMILY: Symbol"}XML file

 

API Usage

De-serialize from XML String

The following code illustrates how to de-serialize from XML string.

*[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}* 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                            |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [this.dataGrid.Model.DeserializeFromString (content); // the content should be an XML string saved during the serialization process.]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

*[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}* 

 De-serialize from XML File

The following code illustrates how to de-serialize from an XML file.

*[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}* 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                            |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [this.dataGrid.Model.Deserialize (\"sample.xml\"); // sample.xml file should be the XML file saved during the serialization process.]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p262} 

 

[]{#related-topics}
:::
