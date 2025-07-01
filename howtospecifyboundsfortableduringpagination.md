::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to specify bounds for Table during pagination? {#how-to-specify-bounds-for-table-during-pagination style="tab-stops: 0pt"}

 

When PdfLightTable or PdfGrid is paginated, by default it will occupy the entire client area of the PdfPage. But, it is possible to specify bounds for the additional pages using PaginateBounds property of PdfLightTableLayoutFormat or PdfGridLayoutFormat class.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                   |
|                                                                                                                                                  |
|                                                                                                                                                  |
|                                                                                                                                                  |
| [format.PaginateBounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(50, 50, 500, 300);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                    |
|                                                                                                                       |
|                                                                                                                       |
|                                                                                                                       |
| [format.PaginateBounds = [New]{style="COLOR: blue"} RectangleF(50, 50, 500, 300)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
