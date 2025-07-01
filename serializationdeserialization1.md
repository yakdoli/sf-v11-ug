::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Serialization/Deserialization {#serializationdeserialization style="tab-stops: 0pt"}

Using this feature, you can save the current state of PivotGrid as an XML file format and restore the same at any time.

The following properties of PivotGrid control can be serialized.

 

::: {align="center"}
  ---------------------------- ----------------------------------------------
  Property Name                Type
  AllowResizeColumns           bool
  AllowResizeRows              bool
  AllowSelection               bool
  AutoSizeColumnCount          int
  AutoSizeOption               GridAutoSizeOption
  AutoSizeRowCount             int
  DeferLayoutUpdate            bool
  Filters                      ObservableCollection\<FilterExpression\>
  FreezeHeaders                bool
  IsDynamicData                bool
  PivotCalculations            ObservableCollection\<PivotComputationInfo\>
  PivotColumns                 ObservableCollection\<PivotItem\>
  PivotFields                  ObservableCollection\<PivotItem\>
  PivotRows                    ObservableCollection\<PivotItem\>
  ShowCalculationsAsColumns    bool
  ShowFieldList                bool
  ShowGrandTotals              bool
  ShowGroupingBar              bool
  GroupingBar.AllowFiltering   bool
  GroupingBar.AllowSorting     bool
  ---------------------------- ----------------------------------------------
:::

 

On Serialization, the expand and the collapse state of PivotGrid cells are maintained. So while de-serializing, the item source specified for the Grid should be as same as that when used in Serialization. This can be ignored by setting **IgnoreExpandCollapseOnSerialization** property of PivotGrid control to False.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}**  

Use Case Scenarios

Serialization can be implemented for applications which need to save its data and structure after the application is closed. Serialization supports to save the structure and data of PivotGridControl to an XML file and it can be loaded at any time.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}**  

Adding Serialization/Deserialization

Serialization/Deserialization can be achieved using the following code snippet,

[]{style="COLOR: #c00000"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"} [ Serialize the PivotGrid into XML file format.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Serialize();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"} [ De serialize the PivotGrid from the saved XML file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Deserialize();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"} [ Serialize the PivotGrid into XML file format and saves it in the specified location.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Serialize([@\"C:/PivotGrid.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"} [ De serialize the PivotGrid from the specified XML file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Deserialize([@\"C:/PivotGrid.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9pt"}                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                    |
| [\' Serialize the PivotGrid into XML file format.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Serialize()]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| [\' De serialize the PivotGrid from the saved XML file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Deserialize()]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                    |
| [\' Serialize the PivotGrid into XML file format and saves it in the specified location.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Serialize(\"C:/PivotGrid.xml\")]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| [\' De serialize the PivotGrid from the specified XML file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.pivotGrid1.Deserialize(\"C:/PivotGrid.xml\")]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                |
|                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}**  

 

 

Methods

::: {align="center"}
  ------------------------------ -------------------------------------------------------------------------------------- ----------------- ------ -------------
  Method                         Description                                                                            Parameters        Type   Return Type
  Serialize()                    Serializes the PivotGrid into XML file format using the save file dialog               \-                void   void
  Deserialize()                  Deserializes the PivotGrid from the saved XML file using the open file dialog          \-                void   void
  Serilize(string fileName)      Serializes the PivotGrid into XML file format and saves it in the specified location   string fileName   void   void
  Deserialize(string filename)   Deserializes the PivotGrid from the specified XML file                                 string fileName   void   void
  ------------------------------ -------------------------------------------------------------------------------------- ----------------- ------ -------------
:::

 

![Description: Description: C:\\Users\\dwarageshmb\\Desktop\\2011 Vol 1 Docs\\Serialization.png](ImagesExt/image42_32.jpg){border="0"}

Figure 30: Serialized XML file

Sample Link

To access a Conditional Formatting sample:

5.   Open the Syncfusion Dashboard.

6.   Click Business Intelligence.

7.   Click the **WPF** drop-down list, and select **Explore Samples**.

8.   Navigate to **PivotAnalysis.WPF** -\> **Samples** -\> **Serialization** -\> **SerializationDemo**.

9.  

[]{#related-topics}
:::::
