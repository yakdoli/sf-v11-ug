::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### PrepareViewStyleInfo Event {#prepareviewstyleinfo-event style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **PrepareViewStyleInfo** event is raised to allow custom formatting of a cell by changing its style object just before it is drawn. This allows formatting based on the current view state, e.g. current cell context, focused control, and so on.

 

For example, if you want draw the current row with a bold text, you can use the PrepareViewStyleInfo to accomplish this task. The idea is to change the style to bold font for any cell in the current one. Given below are the steps that you can follow in order to implement this functionality.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Add a handler for **CurrentCellDeactivated** to refresh the old row to remove its bold font.

[·      ]{style="FONT-FAMILY: Symbol"}Add a handler for **CurrentCellActivated** to refresh the new current row to add its bold font.

[·      ]{style="FONT-FAMILY: Symbol"}Add a handler for **PrepareViewStyleInfo** to conditionally change the bold style of the font if the requested cell is on the current row.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To see a full working sample, check the HighlightCurrent sample that ships with Essential Grid. Notice that the work is done just by making the grid refresh (redraw) a row. During this refresh, the PrepareViewStyleInfo is selected and the style is modified to be bold if the row is current. This means that no bold style information is saved anywhere. The **GridStyleInfo** object is just temporarily modified immediately before it is used in the drawing.

 

[]{#p339} 

 

[]{#related-topics}
:::
