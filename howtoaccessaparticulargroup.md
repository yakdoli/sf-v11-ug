::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to access a particular group {#how-to-access-a-particular-group style="tab-stops: 0pt"}

 

To access a particular group and the records categorized under it, use the following code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[Accessing a particular group and the categorized records under it]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                   |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.TableDescriptor.GroupedColumns.Add([\"Col1\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                               |
| [// Using category]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.iterate([this]{style="COLOR: blue"}.gridGroupingControl1.Table.TopLevelGroup.Groups\[[\"row6 col1\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                               |
| [//Or using index]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [//this.iterate(this.gridGroupingControl1.Table.TopLevelGroup.Groups\[6\]);]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} iterate(Group g)]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                               |
| [      System.Diagnostics.Trace.WriteLine([\"GroupLevel = \"]{style="COLOR: maroon"}+g.GroupLevel);]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                               |
| [      System.Diagnostics.Trace.WriteLine(g.Info);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                               |
| [      [foreach]{style="COLOR: blue"}(Record r [in]{style="COLOR: blue"} g.Records)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                               |
| [      {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [            System.Diagnostics.Trace.WriteLine(r.Info);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [      }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [      [foreach]{style="COLOR: blue"}(Group gr [in]{style="COLOR: blue"} g.Groups)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                               |
| [      {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [            iterate(gr);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                               |
| [      }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                     |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                               |
|                                                                                                                                                                                                    |
| [\'Accessing a particular group and the categorized records under it  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                                                    |
| [    [Me]{style="COLOR: blue"}.gridGroupingControl1.TableDescriptor.GroupedColumns.Add([\"Col1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                    |
| [\' Using category]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                    |
| [    [Me]{style="COLOR: blue"}.iterate([Me]{style="COLOR: blue"}.gridGroupingControl1.Table.TopLevelGroup.Groups([\"row6 col1\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                    |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} iterate([ByVal]{style="COLOR: blue"} g [As]{style="COLOR: blue"} Group)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [    System.Diagnostics.Trace.WriteLine([\"GroupLevel = \"]{style="COLOR: maroon"} + g.GroupLevel.toString())]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                    |
| [    System.Diagnostics.Trace.WriteLine(g.Info)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                    |
| [    [For]{style="COLOR: blue"} [Each]{style="COLOR: blue"} r [As]{style="COLOR: blue"} Record [In]{style="COLOR: blue"} g.Records]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                    |
| [        System.Diagnostics.Trace.WriteLine(r.Info)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                    |
| [    [Next]{style="COLOR: blue"} r]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                    |
| [    [For]{style="COLOR: blue"} [Each]{style="COLOR: blue"} gr [As]{style="COLOR: blue"} Group [In]{style="COLOR: blue"} g.Groups]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                    |
| [        iterate(gr)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                    |
| [    [Next]{style="COLOR: blue"} gr]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                    |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p710} 

 

[]{#related-topics}
:::
