::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding Serialization/Deserialization[ ]{style="COLOR: #c00000"}to an Application {#adding-serializationdeserialization-to-an-application style="tab-stops: 0pt"}

**Serializing**

There are three methods of serialization/deserialization available in the GridTree control.

[·      ]{style="FONT-FAMILY: Symbol"}XML string

[·      ]{style="FONT-FAMILY: Symbol"}XML file

[·      ]{style="FONT-FAMILY: Symbol"}XML stream

 

 **API Usage**

 

**Serializing as an XML String**

The following code illustrates how to serialize the GridTree control as an XML string.

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [string]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f2f2f2; COLOR: blue"}[ result=]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f2f2f2; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f2f2f2; COLOR: blue"}[.treeGrid.InternalGrid.SerializeAsString();]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f2f2f2; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Serializing as an XML File**

The following code illustrates how to serialize the GridTree control as an XML file.

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                            |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeGrid.InternalGrid.Serialize(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"newChanges.xml\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Serializing as an XML Stream**

The following code illustrates how to serialize the GridTree control as an XML stream.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [TextWriter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sw=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[StreamWriter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"newChanges.xml\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.treeGrid.InternalGrid.SerializeToStream(sw);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Deserializing**

There are three methods to deserializing forms:

[·      ]{style="FONT-FAMILY: Symbol"}XML string

[·      ]{style="FONT-FAMILY: Symbol"}XML file

[·      ]{style="FONT-FAMILY: Symbol"}XML stream

 

**API Usage**

 

**Deserialize from XML String**

The following code illustrates how to deserialize from an XML string*.*

+-------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                              |
|                                                                               |
| ``` {style="BACKGROUND: #f2f2f2"}                                             |
|  //the result should be an XML string saved during the serialization process. |
| ```                                                                           |
|                                                                               |
| ``` {style="BACKGROUND: #f2f2f2"}                                             |
| this.treeGrid.InternalGrid.DeserializeFromString(result);                     |
| ```                                                                           |
+-------------------------------------------------------------------------------+

 

**Deserialize from XML File**

The following code illustrates how to deserialize an XML file.

+------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                             |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| //newChanges.xml file should be the XML file saved during the serialization  |
| ```                                                                          |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| process.                                                                     |
| ```                                                                          |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| this.treeGrid.InternalGrid.Deserialize("newChanges.xml");                    |
| ```                                                                          |
+------------------------------------------------------------------------------+

 

**Deserialize from XML Stream**

The following code illustrates how to deserialize an XML stream.

+------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                             |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| //newChanges.txt file should be the text file saved during the serialization |
| ```                                                                          |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| process.                                                                     |
| ```                                                                          |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| TextReader sr = new StreamReader("newChanges.txt");                          |
| ```                                                                          |
|                                                                              |
| ``` {style="BACKGROUND: #f2f2f2"}                                            |
| this.treeGrid.InternalGrid.DeserializeFromStream(sr);                        |
| ```                                                                          |
+------------------------------------------------------------------------------+

[]{#related-topics}
:::
