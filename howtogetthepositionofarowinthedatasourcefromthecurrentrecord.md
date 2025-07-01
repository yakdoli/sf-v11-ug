::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to Get the Position of a Row in the DataSource from the Current Record {#how-to-get-the-position-of-a-row-in-the-datasource-from-the-current-record style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

From the row index, you can get the element displayed at that row. If it is a record row, then the element\'s parent record\'s unsorted position will give the underlying **DataRow** position.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: #4a5c8c; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                               |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [Table table = e.TableControl.Table;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                      |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [// Get the current display element.\                                                                                                                                                                        |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Element el = table.DisplayElements\[e.rowIndex\];]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                     |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [// Get the current record.\                                                                                                                                                                                 |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Record r = el.ParentRecord;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                           |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [// Find its row position.\                                                                                                                                                                                  |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dataRowPos = table.UnsortedRecords.IndexOf(r);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [// Retrieve the corresponding data row from the datasource.\                                                                                                                                                |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[CustomersDataRow row = dataSoure.Rows\[dataRowPos\];]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                  |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                                              |
| [// Access the CutomerId value of the current record.\                                                                                                                                                       |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ id = row.CustomerId;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ table ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Table]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ = e.TableControl.Table ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                      |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                               |
| [\' Get the current display element.\                                                                                                                                                                                                                                                                                         |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ el ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Element = table.DisplayElements(e.rowIndex)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}        |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                               |
| [\' Get the current record.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\                                                                                                                                                                                                                                              |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ r ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Record = el.ParentRecord ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                           |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                               |
| [\' Find its row position.\                                                                                                                                                                                                                                                                                                   |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dataRowPos ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Integer]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ = table.UnsortedRecords.IndexOf(r)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                               |
| [\' Retrieve the corresponding data row from the datasource.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ row ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ CustomersDataRow = dataSoure.Rows(dataRowPos)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}     |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                               |
| [\' Access the CutomerId value of the current record.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\                                                                                                                                                                                                                    |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ id ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As String]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ = row.CustomerId]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p706} 

 

[]{#related-topics}
:::
