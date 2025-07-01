::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to set style properties of a nested table {#how-to-set-style-properties-of-a-nested-table style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This can be done using the below code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [// 1. Changing the backcolor of all the record field cells in the child table.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                              |
|                                                                                                                                                                                                                                 |
| [                        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [// Get the child table descriptor for a particular relation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [GridTableDescriptor child_tabledescriptor = [this]{style="COLOR: blue"}.gridGroupingControl1.TableDescriptor.Relations\[[\"MyChildTable\"]{style="COLOR: maroon"}\].ChildTableDescriptor;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [// Set the style properties   ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                                 |
| [child_tabledescriptor.Columns\[[\"childID\"]{style="COLOR: maroon"}\].Appearance.AnyRecordFieldCell.BackColor = Color.Pink;]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [// 2. Changing the cell property of all the record field cells in the child table.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [// Get the child table descriptor for a particular relation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [GridTableDescriptor child_tabledescriptor = [this]{style="COLOR: blue"}.gridGroupingControl1.TableDescriptor.Relations\[[\"MyChildTable\"]{style="COLOR: maroon"}\].ChildTableDescriptor;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [// Set the style properties   ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                                 |
| [child_tableDescriptor.Columns\[[\"childID\"]{style="COLOR: maroon"}\].Appearance.AnyRecordFieldCell.CellType=[\"ComboBox\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                       |
| [\' 1. Changing the backcolor of all the record field cells in the child table.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                       |
| [\' Get the child table descriptor for a particular relation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ child_tabledescriptor [As]{style="COLOR: blue"} GridTableDescriptor = [Me]{style="COLOR: blue"}.gridGroupingControl1.TableDescriptor.Relations([\"ComSal\"]{style="COLOR: maroon"}).ChildTableDescriptor]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                       |
| [\' Set the style properties              ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                       |
| [child_tabledescriptor.Columns([\"Des\"]{style="COLOR: maroon"}).Appearance.AnyRecordFieldCell.BackColor = Color.Pink]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                       |
| [\' 2. Changing the cell property of all the record field cells in the child table.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                       |
| [\' Get the child table descriptor for a particular relation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ child_tabledescriptor [As]{style="COLOR: blue"} GridTableDescriptor = [Me]{style="COLOR: blue"}.gridGroupingControl1.TableDescriptor.Relations([\"ComSal\"]{style="COLOR: maroon"}).ChildTableDescriptor]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                       |
| [\' Set the style properties   ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                       |
| [child_tabledescriptor.Columns([\"Des\"]{style="COLOR: maroon"}).Appearance.AnyRecordFieldCell.CellType=[\"ComboBox\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p663} 

[]{#related-topics}
:::
