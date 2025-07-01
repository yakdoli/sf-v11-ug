::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Binding to XML Data {#binding-to-xml-data style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Grid Grouping Control can be bound to data from XML files. To do this, a **DataSet** object is required which provides the necessary methods that will let you read the Xml data into the dataset. After loading the data, you can bind the grouping grid to this dataset by setting the data binding properties, the **DataSource** and the **DataMember** to the dataset and the table name respectively. It is also possible to save the changes back to the Xml file.

 

The following table lists some important methods provided by the dataset that allows you to manipulate Xml data. In this, the XmlSchema represents the type of the data stored in the Xml file.

[]{style="COLOR: black"} 

::: {align="center"}
  ---------------- --------------------------------------------------------------------------------------------------
  Method Name      Description
  ReadXml          Reads the Xml Schema and the data into the dataset using the specified Xml file.
  ReadXmlSchema    Reads the Xml Schema from the specified file into the dataset.
  WriteXml         Writes the current data, and optionally the schema, for the dataset into the specified Xml file.
  WriteXmlSchema   Writes the dataset structure as an Xml schema into the specified file.
  ---------------- --------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates the binding process.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                                        |
|                                                                                                                                                                               |
| [// Create a Data Set.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                               |
| [DataSet]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ XmlData = [new]{style="COLOR: blue"} [DataSet]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [// Populate it with data from an XML file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                |
|                                                                                                                                                                               |
| [XmlData.ReadXml([\"C:\\\\Data\\\\Customers_Orders.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [// Bind the grid to the Data Set.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                               |
| [gridGroupingControl1.DataSource = XmlData;]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                               |
| [gridGroupingControl1.DataMember = XmlData.Tables\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                  |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                |
|                                                                                                                                                                     |
| [\' Create a Data Set.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ XmlData [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DataSet()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [\' Populate it with data from an XML file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                       |
|                                                                                                                                                                     |
| [XmlData.ReadXml([\"C:\\\\Data\\\\Customers_Orders.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [\' Bind the grid to the Data Set.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                     |
| [gridGroupingControl1.DataSource = XmlData]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                     |
| [gridGroupingControl1.DataMember = XmlData.Tables(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p406} 

 

[]{#related-topics}
::::
