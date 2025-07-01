::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### QueryCellInfo Action {#querycellinfo-action style="tab-stops: 0pt"}

Grid formatting can be applied to different grid cell elements dynamically at run time. This can be achieved by proper handling of **QueryCellInfo** action. It provides the **Htmlattributes** object for a cell on demand.

**QueryCellInfo** is raised every time a request is made to access the style information for a cell. You can do any type of formatting cells with this event.

It accepts **GridTableCell\<T\>** as its parameter, which can be used to customize the cells of the grid control. For instance, you can apply styles for a given cellType by using the **TableCellType** property on the instances of **GridTableCell\<T\>**.

The following table describes the **GridTableCell\<T\>** properties:

 

Properties

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

::: {align="center"}
+----------------+--------------------------------------------------------+------------------------------+------------------------------------------------+--------------------------------------------------+
| Property       | Description                                            | Type of property             | Value it accepts                               | Any other dependencies/sub-properties associated |
+================+========================================================+==============================+================================================+==================================================+
| Data           | Gets or sets data value of querycell.                  | Generic T                    | Any data                                       | NA                                               |
+----------------+--------------------------------------------------------+------------------------------+------------------------------------------------+--------------------------------------------------+
| Column         | Gets or sets the column type of the querycell.         | GridColumn\<T\>              | Any GridColumn\<T\>                            | NA                                               |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              |                                                |                                                  |
+----------------+--------------------------------------------------------+------------------------------+------------------------------------------------+--------------------------------------------------+
| HtmlAttributes | Gets or sets the Htmlattributes for customizing cells. | IDictionary\<string,object\> |                                                | NA                                               |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              |                                                |                                                  |
+----------------+--------------------------------------------------------+------------------------------+------------------------------------------------+--------------------------------------------------+
| Text           | Gets or sets the value renders in cell.                | object                       | Any object                                     | NA                                               |
+----------------+--------------------------------------------------------+------------------------------+------------------------------------------------+--------------------------------------------------+
| TableCellType  | Gets or sets the table cell type of the querycell.     | Enum                         | GridTableCellType.GroupCaptionCell             | NA                                               |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.GroupHeaderIndentCell        |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.SummaryFieldCell             |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.IndentCell                   |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.TopLeftHeaderCell            |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.RowHeaderCell                |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.ColumnHeaderCell             |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.RecordPlusMinusCell          |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.RecordFieldCell              |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.AlternateRecordFieldCell     |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.AlternateRecordRowHeaderCell |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.EmptyCell                    |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              | GridTableCellType.CaptionCell                  |                                                  |
|                |                                                        |                              |                                                |                                                  |
|                |                                                        |                              |                                                |                                                  |
+----------------+--------------------------------------------------------+------------------------------+------------------------------------------------+--------------------------------------------------+
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=fcca5819-3714-4e76-ad37-4e0e8198288e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=648e36dc-7faf-4c8d-8c37-41679f6149f3){style="TEXT-DECORATION: none"}
::::
