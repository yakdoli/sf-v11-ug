::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Defining a FormulaCell[]{style="FONT-WEIGHT: normal"} {#defining-a-formulacell style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can use FormulaCells for every cell in a grid or for just a few cells. Even if you assign a **CellType** FormulaCell to every cell in a grid, the default behavior is to treat such cells as text box cells unless you start the cell entry with an equal sign. If the cell value starts with an equal sign then, the cell is considered as a formula cell and its contents are treated as such.

 

To make all cells present in a grid as potential formula cells, you will have to set the CellType of the standard **BaseStyle** to a FormulaCell using the following code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                                    |
| []{style="COLOR: black"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                    |
| [// Set up a Formula Cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl1.BaseStylesMap\[[\"Standard\"]{style="COLOR: #a31515"}\].StyleInfo.CellType = [\"FormulaCell\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                          |
| ['Set up a Formula Cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.GridControl1.BaseStylesMap(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Standard\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[). StyleInfo.CellType = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"FormulaCell\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p20} 

[]{#related-topics}
:::
