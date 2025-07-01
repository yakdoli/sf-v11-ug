::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Insert Tables {#insert-tables style="tab-stops: 0pt"}

Table support for the RichTextBoxAdv control has been implemented as in MS Word. This is used to insert tables with user-defined rows and columns, and it also allows the user to insert multiple tables for every cell.

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|  **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                               |
| [     ]{style="COLOR: blue"}                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                               |
| [               \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[TableAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\ |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                        ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[TableRowAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                     |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                            ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[TableCellAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                                ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ParagraphAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                            |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                                    ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[SpanAdv]{style="COLOR: #a31515"}[ Text]{style="COLOR: red"}[=\"Table support\"/\>]{style="COLOR: blue"}\                                               |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                                ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ParagraphAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                           |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                            ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[TableCellAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                               |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                        ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[TableRowAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                                    |
| \                                                                                                                                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                               |
| [  [                    ]{style="COLOR: #a31515"}[\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[TableAdv]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                                   |
| **[          ]{style="FONT-FAMILY: 'Courier New'"}**[TableAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ table = [new]{style="COLOR: blue"} [TableAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| [          [TableRowAdv]{style="COLOR: #2b91af"} row = [new]{style="COLOR: blue"} [TableRowAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                   |
| [          [TableCellAdv]{style="COLOR: #2b91af"} cell = [new]{style="COLOR: blue"} [TableCellAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [          [ParagraphAdv]{style="COLOR: #2b91af"} paragraph = [new]{style="COLOR: blue"} [ParagraphAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                                   |
| [          [SpanAdv]{style="COLOR: #2b91af"} span = [new]{style="COLOR: blue"} [SpanAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                                                   |
| [          span.Text = [\"Table support\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                   |
| [          paragraph.Inlines.Add(span);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                   |
| [          cell.Blocks.Add(paragraph);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [          row.Cells.Add(cell);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [          table.Rows.Add(row);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| **[      ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Editing Support](ms-xhelp:///?Id=f06fd67e-5853-44f3-b8ef-b5259926ae3d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Selection Support](ms-xhelp:///?Id=60814102-c48f-4507-b156-45565a51520d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Insert n\*n Tables](ms-xhelp:///?Id=0fc86bc7-e102-47f4-8889-a944a7980a92){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Insert n\*n Columns](ms-xhelp:///?Id=1a6b0a4c-d857-4f0d-8875-5dbb5d2468b0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Insert n\*n Rows](ms-xhelp:///?Id=584b3afa-8d6c-47e4-8bbc-2aed4a7ed16d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Delete Table](ms-xhelp:///?Id=a8b3da59-066e-4a61-99a9-e6af0b74bbed){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Delete n\*n Rows](ms-xhelp:///?Id=df953d32-dcf7-4350-b3fe-fa50d06ead65){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Delete n\*n Columns](ms-xhelp:///?Id=fb0e9764-549e-4e7c-a9f3-08aa2a27e5d3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Merging](ms-xhelp:///?Id=669c93f2-7b26-4528-8820-778c64b1bf72){style="TEXT-DECORATION: none"}
:::
