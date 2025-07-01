::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Add the Tables One After Another? {#how-to-add-the-tables-one-after-another style="tab-stops: 0pt"}

 

You can draw the table relative to the position of the previous table by using the **PdfLayoutResult** class. This class stores the boundary values of the table that is drawn. By using the boundary values, you can set the starting position of the table relative to the height of the previous table. The following code example illustrates this.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                  |
|                                                                                                                                                                                                       |
| [// Drawing first table.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                       |
| [PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ table = [new]{style="COLOR: blue"} [PdfLightTable]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                       |
| [table.DataSource = dt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                       |
| [table.Style.ShowHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                       |
| [PdfLayoutResult]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ result = table.Draw(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(0, 20));]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [// Calculating Second table position. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                                       |
| [RectangleF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ bounds = result.Bounds;]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                       |
| [PointF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ location = [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(bounds.Left, bounds.Bottom + 30);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [// Drawing the second table.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                                                       |
| [table.Draw(page, location);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                        |
|                                                                                                                                                                                                             |
| [ [\' Drawing first table.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ table [As]{style="COLOR: blue"} PdfLightTable = [New]{style="COLOR: blue"} PdfLightTable()]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                             |
| [table.DataSource = dt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                             |
| [table.Style.ShowHeader = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} PdfLayoutResult = table.Draw(page, [New]{style="COLOR: blue"} PointF(0, 20))]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [\' Calculating Second table position.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bounds [As]{style="COLOR: blue"} RectangleF = result.Bounds]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ location [As]{style="COLOR: blue"} PointF = [New]{style="COLOR: blue"} PointF(bounds.Left, bounds.Bottom + 30)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [ [\' Drawing the second table.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                             |
| [table.Draw(page, location)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
