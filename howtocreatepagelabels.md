::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Create Page Labels? {#how-to-create-page-labels style="tab-stops: 0pt"}

 

You will be able to find a Pages tab in Adobe Reader which contains small page images. Also you will be able to find text underneath each image. You can edit that text by using the **PdfPageLabel** class. This class allows specifying the prefix, numbering style, and starting number for a page group, which is a section. You can create and initialize an instance of this class and assign it to the **Section** property.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                            |
|                                                                                                                                                                                 |
| [// Create a new document class object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                      |
|                                                                                                                                                                                 |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [PdfDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                 |
| [// Create few sections with few pages in each.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                 |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i = 0; i \< 3; ++i)]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                 |
| [PdfSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section = doc.Sections.Add();]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                 |
| [PdfPageLabel]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ label = [new]{style="COLOR: blue"} [PdfPageLabel]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [label.Prefix = [\"Sec\"]{style="COLOR: maroon"} + i + [\"-\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                 |
| [section.PageLabel = label;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                 |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page;]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                 |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} j = 0; j \< 10; ++j)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                 |
| [page = section.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                 |
| [doc.Save(filename);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                        |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                    |
|                                                                                                                                                                                         |
| [\' Create a new document class object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                              |
|                                                                                                                                                                                         |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} PdfDocument = [New]{style="COLOR: blue"} PdfDocument()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [\' Create few sections with few pages in each.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                      |
|                                                                                                                                                                                         |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 2]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} PdfSection = doc.Sections.Add()]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ label [As]{style="COLOR: blue"} PdfPageLabel = [New]{style="COLOR: blue"} PdfPageLabel()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                         |
| [      label.Prefix = [\"Sec\"]{style="COLOR: maroon"} & i & [\"-\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                         |
| [      section.PageLabel = label]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                         |
| [      [For]{style="COLOR: blue"} j [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 9]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                         |
| [               page = section.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                         |
| [      [Next]{style="COLOR: blue"} j]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                         |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| [doc.Save(filename)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p115} 

 

[]{#related-topics}
:::
