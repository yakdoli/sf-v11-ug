::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Set Graphic Units? {#how-to-set-graphic-units style="tab-stops: 0pt"}

 

Essential PDF sets the size of an element in terms of points \[1/72 inch\]. It has a utility class, **PdfUnitConvertor**, which enables to convert different measure units and use them for resizing pages.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                               |
| [// Setting Page size after converting units to points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[ ]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                               |
| [PdfUnitConvertor]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ con = [new]{style="COLOR: blue"} [PdfUnitConvertor]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                               |
| [doc.PageSettings.Width = con.ConvertUnits(100f, [PdfGraphicsUnit]{style="COLOR: #2b91af"}.Millimeter, [PdfGraphicsUnit]{style="COLOR: #2b91af"}.Point);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                     |
|                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                               |
|                                                                                                                                                          |
| [\' Setting Page size after converting units to points ]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                               |
|                                                                                                                                                          |
| [Dim con As New [PdfUnitConvertor]{style="COLOR: teal"}()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                           |
|                                                                                                                                                          |
| [doc.PageSettings.Width = con.ConvertUnits(100F, PdfGraphicsUnit.Millimeter, PdfGraphicsUnit.Point)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: The width or height property of the document is always represented by using Points \[1/72 inch\]. However, the helper method enables you to set page sizes in the desired unit.
:::

 

 

 

[]{#related-topics}
::::
