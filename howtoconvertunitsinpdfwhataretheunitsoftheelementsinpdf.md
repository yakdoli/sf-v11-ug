::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2482d4b8-42e0-4c7e-886a-edb967b4a9bc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=597f0bc5-fcf9-4616-902d-fde7981cce07){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=ca78a5c9-c63a-4368-878c-fa18338e0b19){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Editing](ms-xhelp:///?Id=143c0997-6cd3-4daa-9060-6be730784dc4){.d2h_breadcrumbsNormal}
:::

### How To Convert Units In PDF / What Are the Units Of the Elements In PDF? {#how-to-convert-units-in-pdf-what-are-the-units-of-the-elements-in-pdf style="tab-stops: 0pt"}

 

Essential PDF measure unit of the elements are \"points\". A point is equal to 1/72 of an \"inch\". Points are represented in terms of float values. **PdfUnitConvertor** enables to convert different measure units.

The following code example illustrates how to convert pixels to points.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [//Converts inches to points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                                           |
| [float]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ height = con.ConvertUnits(800, [PdfGraphicsUnit]{style="COLOR: teal"}.Inch, [PdfGraphicsUnit]{style="COLOR: teal"}.Point);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| [float]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ width = con.ConvertUnits(500, [PdfGraphicsUnit]{style="COLOR: teal"}.Inch, [PdfGraphicsUnit]{style="COLOR: teal"}.Point);]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                           |
| [SizeF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pageSize = [new]{style="COLOR: blue"} [SizeF]{style="COLOR: teal"}(width, height);]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                                           |
| [doc.PageSettings.Size = pageSize;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                             |
|                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                  |
| [\'Converts inches to points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                  |
|                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ height [As]{style="COLOR: blue"} [Single]{style="COLOR: blue"} = con.ConvertUnits(800, PdfGraphicsUnit.Inch, PdfGraphicsUnit.Point)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ width [As]{style="COLOR: blue"} [Single]{style="COLOR: blue"} = con.ConvertUnits(500, PdfGraphicsUnit.Inch, PdfGraphicsUnit.Point)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pageSize [As]{style="COLOR: blue"} SizeF = [New]{style="COLOR: blue"} SizeF(width, height)]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                  |
| [doc.PageSettings.Size = pageSize]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
