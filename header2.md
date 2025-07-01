::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Header {#header style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **Header** cell type displays static text similar to the static **CellType**. But the Header cell type, in addition, has a button-like border that can have a depressed state.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates how to set the cell type to Header.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                               |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                         |
|                                                                                                                                              |
| [// Set Cell Type as \"Header\".]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                              |
| [gridControl1\[rowIndex,colIndex\].Text = [\"HeaderText\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                              |
| [// Set Formatting properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                            |
|                                                                                                                                              |
| [gridControl1\[rowIndex,colIndex\].CellType = [\"Header\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                              |
| [gridControl1\[rowIndex,colIndex\].BackColor = [Color]{style="COLOR: #2b91af"}.FromArgb(208, 208, 208);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                     |
|                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                   |
|                                                                                                                        |
| [\' Set Cell Type as \"Header\".]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                    |
|                                                                                                                        |
| [gridControl1(rowIndex, colIndex).Text = [\"HeaderText\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                 |
|                                                                                                                        |
| [\' Set Formatting properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                      |
|                                                                                                                        |
| [gridControl1(rowIndex, colIndex).CellType = [\"Header\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                        |
| [gridControl1(rowIndex, colIndex).BackColor = Color.FromArgb(208, 208, 208)]{style="FONT-FAMILY: 'Courier New'"}       |
+------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image91_88.jpg){border="0"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

*[Figure ]{style="FONT-SIZE: 9pt"}[82]{style="FONT-SIZE: 9pt"}[: Header Cells]{style="FONT-SIZE: 9pt"}*

 

[]{#p58} 

 

[]{#related-topics}
:::
