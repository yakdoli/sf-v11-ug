::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Tables {#tables style="tab-stops: 0pt"}

Tables are useful for presenting a large quantity of information clearly and concisely. In PDF, tables are drawn as a series of rectangles with text and image correctly positioned within them. Using Essential PDF, it is drawn with the help of PdfBrush, PdfPen and other PdfGraphics elements. Essential PDF also offers two classes to achieve them without any hassle. They are:

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[PdfLightTable ]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[PdfGrid]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

 

PdfLightTable

It allows the creation of table with inputs from DataTable, arrays or any other entity class. It allows you to perform simple formatting using events.  As this class allows minimal customization options, rendering will be faster than PDF Grid and is recommended to draw a simple table. Check the following comparison table for more details.

 

PdfGrid

It is based on cell model that offers rich API for formatting and layout options. It can take input from DataTable, arrays or any other entity class. Formatting can be done to all levels of PdfGrid. More features like Nested Table, Row and Column Spanning are also supported. It offers full control over the appearance and is recommended to draw complex table structures. Check the following comparison table for more details.

 

Comparison between PdfLightTable and PdfGrid

  --------------- --------------- ---------
  Platforms       PdfLightTable   PdfGrid
  Windows Forms   Yes             Yes
  WPF             Yes             Yes
  ASP.NET         Yes             Yes
  ASP.NET MVC     Yes             Yes
  Silverlight     Yes             Yes
  --------------- --------------- ---------

 

+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Features                | PdfLightTable                                                                                | PdfGrid                        |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
|                                                                                                                                                         |
|                                                                                                                                                         |
| Formatting                                                                                                                                              |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Row                     | No direct API, possible through events                                                       | Yes                            |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Column                  | Yes (StringFormat)                                                                           | Yes (StringFormat)             |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Cell                    | No direct API for single cell formatting, possible through events                            | Yes                            |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
|                                                                                                                                                         |
|                                                                                                                                                         |
| Others                                                                                                                                                  |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Row span                | No                                                                                           | Yes                            |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Column span             | No direct API, possible through events                                                       | Yes                            |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Nested Grid             | Possible through events                                                                      | Yes                            |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+
| Layout Events           | BeginCellLayout, BeginPageLayout, BeginRowLayout, EndCellLayout, EndPageLayout, EndRowLayout | BeginPageLayout, EndPageLayout |
+-------------------------+----------------------------------------------------------------------------------------------+--------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}PdfLightTable](ms-xhelp:///?Id=556cead6-bb87-49b1-b05f-54fc84a45446){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PdfGrid](ms-xhelp:///?Id=c58dadd4-cc40-4bce-a45e-582e90f95bde){style="TEXT-DECORATION: none"}
:::
