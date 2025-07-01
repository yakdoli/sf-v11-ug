::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Text Box {#text-box style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A **Text Box** cell type displays text and images that can be edited in place.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates how to set the cell type to TextBox.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                  |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                            |
|                                                                                                                                                 |
| [gridControl1\[rowIndex,colIndex\].Text = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}           |
|                                                                                                                                                 |
| [gridControl1\[rowIndex,colIndex\].CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}       |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                          |
|                                                                                                                                                 |
| [// Text box with image - assumes ImageList set the same Static sample code.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"} |
|                                                                                                                                                 |
| [gridControl1\[rowIndex,colIndex + 1\].Text = [\"TextBox/Image\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                 |
| [gridControl1\[rowIndex,colIndex\].CellType = [\"TextBox\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}       |
|                                                                                                                                                 |
| [gridControl1\[rowIndex,colIndex + 1\].ImageIndex = 1;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                              |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                            |
|                                                                                                                                                 |
| [gridControl1(rowIndex, colIndex).Text = [\"TextBox\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}             |
|                                                                                                                                                 |
| [gridControl1(rowIndex, colIndex).CellType = [\"TextBox\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}         |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}                                                                          |
|                                                                                                                                                 |
| [\' Text box with image - assumes ImageList set the same Static sample code.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"} |
|                                                                                                                                                 |
| [gridControl1(rowIndex, colIndex + 1).Text = [\"TextBox/Image\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}   |
|                                                                                                                                                 |
| [gridControl1(rowIndex, colIndex).CellType = [\"TextBox\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}         |
|                                                                                                                                                 |
| [gridControl1(rowIndex, colIndex + 1).ImageIndex = 1]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image91_97.jpg){border="0"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

*[Figure ]{style="FONT-SIZE: 9pt"}[91]{style="FONT-SIZE: 9pt"}[: Text Box Cells]{style="FONT-SIZE: 9pt"}*

 

[]{#p67} 

 

[]{#related-topics}
:::
