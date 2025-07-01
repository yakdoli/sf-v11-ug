::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Picture Box {#picture-box style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The Picture Box cell type can be embedded into a cell by calculating the size of the picture, and extending the width and height of the cell accordingly. The **PictureBoxStyleProperties** class provides the style where it holds the information of the picture that has to be added.

 

The following code examples illustrate how to set the cell type to PictureBox.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Using C#

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                            |
|                                                                                                                                                                                                 |
| [RegisterCellModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.GridCellType(gridControl1, [CustomCellTypes]{style="COLOR: #2b91af"}.PictureBox);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [PictureBoxStyleProperties]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sp;]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                 |
| [style = gridControl1\[2, 2\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                 |
| [style.CellType = [CustomCellTypes]{style="COLOR: #2b91af"}.PictureBox.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                 |
| [sp = [new]{style="COLOR: blue"} [PictureBoxStyleProperties]{style="COLOR: #2b91af"}(style);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                 |
| [sp.Image = GetImage([\"one.jpg\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   Using VB.NET

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                  |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                |
|                                                                                                                                                     |
| [RegisterCellModel.GridCellType([Me]{style="COLOR: blue"}.gridControl1, CustomCellTypes.PictureBox)]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sp [As]{style="COLOR: blue"} PictureBoxStyleProperties]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                     |
| [style = gridControl1(2, 2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                     |
| [style.CellType = CustomCellTypes.PictureBox.ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                     |
| [sp = [New]{style="COLOR: blue"} PictureBoxStyleProperties(style)]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                     |
| [sp.Image = GetImage([\"one.jpg\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[![](ImagesExt/image91_118.jpg){border="0"}]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

*[Figure ]{style="FONT-SIZE: 9pt"}[112]{style="FONT-SIZE: 9pt"}[: Picture Box Cell]{style="FONT-SIZE: 9pt"}*

 

[]{#p101} 

 

[]{#related-topics}
:::
