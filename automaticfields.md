::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Automatic Fields {#automatic-fields style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Automatic Fields are special objects that display information calculated automatically, just before the document is saved.

 

The following are the fields displayed:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Page number

[·      ]{style="FONT-FAMILY: Symbol"}Count of pages

[·      ]{style="FONT-FAMILY: Symbol"}Author of the document

[·      ]{style="FONT-FAMILY: Symbol"}Creation and current date

[·      ]{style="FONT-FAMILY: Symbol"}Other document information

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: These fields are not always evaluated at the moment of constructing the document.
:::

 

To display the correct value of the field, you should specify some important properties, which are listed below.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Font**-Used to display the value of the field. Exception is thrown, if this property is not set.

[·      ]{style="FONT-FAMILY: Symbol"}**Brush**-Used to print the value of the field. Exception is thrown, if this property is not set.

[·      ]{style="FONT-FAMILY: Symbol"}**Bounds**-Specifies the bounds of the field

 

You can also use the **Location** and **Size** properties to define the bounds of the field.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Location**: Represents the location of the field. Default point is (0, 0).

[·      ]{style="FONT-FAMILY: Symbol"}**Size**: Represents the size of the field. If it is not set, the size of the field is automatically calculated to display the value.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: It is not necessary to set the Bounds and Size with Location at the same time. Size and Bounds.Size have the same values.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Numeric fields have an additional **NumberingStyle** property. There are five possible numbering styles supported by the automatic fields. They are as follows.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[·      ]{style="FONT-FAMILY: Symbol"}Arabic (1, 2, 3, 4, \...)

[·      ]{style="FONT-FAMILY: Symbol"}Upper Roman (I, II, III, IV, \...)

[·      ]{style="FONT-FAMILY: Symbol"}Roman (i, ii, iii, iv, \...)

[·      ]{style="FONT-FAMILY: Symbol"}Upper Latin (A, B, C, D, \..., Z, AA, AB, \...)

[·      ]{style="FONT-FAMILY: Symbol"}Latin (a, b, c, d, \..., z, aa, ab, \...)

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Brief descriptions on the various numbering fields are given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**PdfPageNumberField** - Specifies the number of the page on which the field has been drawn

[·      ]{style="FONT-FAMILY: Symbol"}**PdfPageCountField** - Specifies the total number of pages in the document

[·      ]{style="FONT-FAMILY: Symbol"}**PdfSectionPageNumberField** - Specifies the number of pages within a section

[·      ]{style="FONT-FAMILY: Symbol"}**PdfSectionPageCountField** - Specifies the number of sections in a document

[·      ]{style="FONT-FAMILY: Symbol"}**PdfSectionNumberField** - Specifies the number of sections within a document

[·      ]{style="FONT-FAMILY: Symbol"}**PdfCreationDateField** - Specifies the creation date of the document

 

The value is taken from the **DocumentInformation.CreationDate** property.

 

[·      ]{style="FONT-FAMILY: Symbol"}**PdfDateTimeField** - Specifies the current date and time

[·      ]{style="FONT-FAMILY: Symbol"}**PdfDestinationPageNumberField** - Specifies the number of the specified destination page

[·      ]{style="FONT-FAMILY: Symbol"}**PdfCompositeField** - Specifies the value of the field that is composed of any number of other automatic fields

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PdfCreationDateField and PdfDateTimeField have the **DateFormatString** property, which defines the formatting string for the value of the field. This property uses the same formatting rules and specifiers as DateTime type of .NET. For detailed information on formatting specifiers, see [[http://msdn2.microsoft.com/en-us/library/73ctwf33(VS.80).aspx]{.UGHyperlink}](http://msdn2.microsoft.com/en-us/library/73ctwf33(VS.80).aspx).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can draw the Automatic Fields on the **PdfTemplate** and set them as the document template or manually draw them on the necessary pages. The values of the fields will be automatically populated on each copy of the template.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates how to display page numbers.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ document = [new]{style="COLOR: blue"} [PdfDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                 |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = document.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfStandardFont]{style="COLOR: teal"}([PdfFontFamily]{style="COLOR: teal"}.Helvetica, 12f);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [PdfBrush]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ brush = [PdfBrushes]{style="COLOR: teal"}.Black;]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfPageNumberField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pageNumber = [new]{style="COLOR: blue"} [PdfPageNumberField]{style="COLOR: teal"}(font, brush);]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i = 0; i \< 50; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                 |
| [page = document.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                 |
| [pageNumber.Draw(page.Graphics);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                              |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} PdfDocument = [New]{style="COLOR: blue"} PdfDocument()]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = document.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfFont = [New]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Helvetica, 12.0F)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ brush [As]{style="COLOR: blue"} PdfBrush = PdfBrushes.Black]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pageNumber [As]{style="COLOR: blue"} PdfPageNumberField = [New]{style="COLOR: blue"} PdfPageNumberField(font, brush)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 49]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                   |
| [  page = document.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                   |
| [  pageNumber.Draw(page.Graphics)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates how to use a composite field.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ document = [new]{style="COLOR: blue"} [PdfDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                 |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = document.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfStandardFont]{style="COLOR: teal"}([PdfFontFamily]{style="COLOR: teal"}.Helvetica, 12f);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [PdfBrush]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ brush = [PdfBrushes]{style="COLOR: teal"}.Black;]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfCompositeField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ compositeField = [new]{style="COLOR: blue"} [PdfCompositeField]{style="COLOR: teal"}(font, brush);]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i = 0; i \< 50; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                 |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = document.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                 |
| [compositeField.Draw(page.Graphics);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} PdfDocument = [New]{style="COLOR: blue"} PdfDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = document.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfFont = [New]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Helvetica, 12.0F)]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ brush [As]{style="COLOR: blue"} PdfBrush = PdfBrushes.Black]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [compositeField]{style="COLOR: #003300"} [As]{style="COLOR: blue"} [PdfCompositeField]{style="COLOR: #003300"} = [New]{style="COLOR: blue"} [PdfCompositeField]{style="COLOR: #003300"}(font, brush)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                   |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 49]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = document.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                   |
| [  [compositeField]{style="COLOR: #003300"}.Draw(page.Graphics)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                   |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

When an automatic field is used as a component of the composite field, it is not necessary to specify its Font, Brush and Bounds properties. Just call its constructor without parameters.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: You must specify the preceding properties for the composite field.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates how to use automatic fields in templates.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ document = [new]{style="COLOR: blue"} [PdfDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                 |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = document.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfStandardFont]{style="COLOR: teal"}([PdfFontFamily]{style="COLOR: teal"}.Helvetica, 12f);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [PdfBrush]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ brush = [PdfBrushes]{style="COLOR: teal"}.Black;]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfTemplate]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ template = [new]{style="COLOR: blue"} [PdfTemplate]{style="COLOR: teal"}(15, 15);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [PdfDateTimeField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ dateField = [new]{style="COLOR: blue"} [PdfDateTimeField]{style="COLOR: teal"}(font, brush);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                 |
| [dateField.DateFormatString = [\"dd\'/\'MMMM\'/\'yyyy\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [dateField.Draw(template.Graphics);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i = 0; i \< 50; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                 |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ page = document.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                 |
| [page.Graphics.DrawPdfTemplate(template, [new]{style="COLOR: blue"} [Point]{style="COLOR: teal"}(50, 50));]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                               |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} PdfDocument = [New]{style="COLOR: blue"} PdfDocument()]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = document.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfFont = [New]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Helvetica, 12.0F)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ brush [As]{style="COLOR: blue"} PdfBrush = PdfBrushes.Black]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ template [As]{style="COLOR: blue"} PdfTemplate = [New]{style="COLOR: blue"} PdfTemplate(15, 15)]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dateField [As]{style="COLOR: blue"} PdfDateTimeField = [New]{style="COLOR: blue"} PdfDateTimeField(font, brush)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dateField.DateFormatString = [\"dd\'/\'MMMM\'/\'yyyy\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                                            |
|                                                                                                                                                                                                                  |
| [dateField.Draw(template.Graphics)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 49]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ page [As]{style="COLOR: blue"} PdfPage = document.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                  |
| [page.Graphics.DrawPdfTemplate(template, [New]{style="COLOR: blue"} Point(50, 50))]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                  |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
::::::
