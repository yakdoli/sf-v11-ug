::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to get a record index given the rowindex {#how-to-get-a-record-index-given-the-rowindex style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This can be done using the following code snippet.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                              |
|                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                        |
|                                                                                                                                             |
| [// Record index is being calculated.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                    |
|                                                                                                                                             |
| [Table table = e.TableCellIdentity.Table;]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                             |
| [Element el = table.DisplayElements\[RowIndex\];]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                             |
| [Record r = el.ParentRecord;]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                             |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ RecordIndex= table.UnsortedRecords.IndexOf(r);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                 |
|                                                                                                                                                                                                      |
| [\' Record index is being calculated.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ table [As]{style="COLOR: blue"} Table = e.TableCellIdentity.Table]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ el [As]{style="COLOR: blue"} Element = table.DisplayElements(RowIndex)]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ r [As]{style="COLOR: blue"} Record = el.ParentRecord]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ RecordIndex [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = table.UnsortedRecords.IndexOf(r)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p699} 

 

[]{#related-topics}
:::
