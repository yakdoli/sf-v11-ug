::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Create a Borderless Table? {#how-to-create-a-borderless-table style="tab-stops: 0pt"}

 

You can create a borderless table by making use of the **Style** property of the **PdfLightTable** class. This is achieved by setting the border color of the table to ***Transparent***. The following code example illustrates this.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                            |
|                                                                                                                                                                                                                 |
| [// Creating Border with transparent color.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                                 |
| [PdfPen]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ borderPen = [new]{style="COLOR: blue"} [PdfPen]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Transparent);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                 |
| [borderPen.Width = 1.0f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| [// Assigning the border pen to table cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                                 |
| [PdfCellStyle defStyle = [new]{style="COLOR: blue"} PdfCellStyle();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                                 |
| [defStyle.Font = font;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                 |
| [defStyle.BorderPen = borderPen;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                 |
| [table.Style.DefaultStyle = defStyle; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                             |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                           |
|                                                                                                                                                                                                |
| [\' Creating Border with transparent color.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ borderPen [As]{style="COLOR: blue"} PdfPen = [New]{style="COLOR: blue"} PdfPen(Color.Transparent)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [borderPen.Width = 1.0F]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [\' Assigning the border pen to table cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ defStyle [As]{style="COLOR: blue"} PdfCellStyle = [New]{style="COLOR: blue"} PdfCellStyle()]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                |
| [defStyle.Font = font]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                |
| [defStyle.BorderPen = borderPen]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                |
| [table.Style.DefaultStyle = defStyle]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
