::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to set margins for the PDF pages? {#how-to-set-margins-for-the-pdf-pages style="tab-stops: 0pt"}

 

Margins can be set on all sides or on a particular side of the page using the **PageSettings.Margins** property. Following are the options of this property:

 

[·      ]{style="FONT-FAMILY: Symbol"}***All***-Sets margins size on all the sides

[·      ]{style="FONT-FAMILY: Symbol"}***Bottom***-Sets the bottom margin size

[·      ]{style="FONT-FAMILY: Symbol"}***Left***-Sets the left margin size

[·      ]{style="FONT-FAMILY: Symbol"}***Top***-Sets the top margin size

[·      ]{style="FONT-FAMILY: Symbol"}***Right***-Sets the right margin size

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                     |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                               |
|                                                                                                                                                    |
| [//Adds a section to the document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                               |
|                                                                                                                                                    |
| [PdfSection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ section = doc.Sections.Add();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                               |
|                                                                                                                                                    |
| [//Adds a page to the section]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                   |
|                                                                                                                                                    |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ page= section.Pages.Add();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}       |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [//Sets Margin to the page ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                    |
| [section.PageSettings.Margins.All = 0;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                              |
| [\'Adds a section to the document ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfSection = doc.Sections.Add()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                              |
| [\'Adds a page to the section ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
| [PdfPage = section.Pages.Add()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                              |
| [\'Sets Margin to the page ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                              |
| [section.PageSettings.Margins.All = 0]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
