::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to Allocate Equal Size for Each of the Columns in all the Tables {#how-to-allocate-equal-size-for-each-of-the-columns-in-all-the-tables style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The parent/child table columns width can be set equally in proportion to the grid control\'s client width, by dynamically setting the columns width in the TableModel.QueryColWidth event handler. When it deals with a nested table, the QueryColWidth event of the entire nested table must be handled to set the respective nested table columns width.

 

In the QueryColWidth event handler, the available width for the columns can be calculated as follows,

 

availableArea = groupingGrid.ClientSize.Width - gridModel.ColWidths.GetTotal(0, girdModel.Cols.HeaderCount) - indentColsTotalWidth;

 

and the proportional columns width can be calculated as follows,

 

Size = (int) availableArea / (grid.TableDescriptor.VisibleColumns.Count);

 

[]{#p678} 

 

[]{#related-topics}
:::
