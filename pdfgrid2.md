::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::::::::::::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### PdfGrid {#pdfgrid style="tab-stops: 0pt"}

 

[]{#p45}PdfGrid class, based on cell model, helps to draw tables of complex structures. Data from DataTables, arrays or other entity classes can be given as input. In Silverlight platform, IEnumerable data objects can be set as data source. Formatting can be done at all levels and it provides direct API for this. It also supports row, column spanning and drawing of nested tables. This section explains how a table can be drawn using PdfGrid. It includes the following sections:

 

###### []{#_Properties,_Methods_and}4.1.2.3.2.1 Properties, Methods and Events {#properties-methods-and-events style="tab-stops: 0pt"}

 

Properties

 

::: {align="center"}
  -------------------------- ------------------------------------------------------------------ -------------------------
  Name                       Description                                                        Data Type
  AllowRowBreakAcrossPages   Gets or sets whether to split or move rows that overflow a page.   Boolean
  Columns                    Gets the columns.                                                  PdfGridColumnCollection
  DataMember                 Gets or sets the data member.                                      String
  DataSource                 Gets or sets the data source.                                      Object
  Headers                    Gets the headers.                                                  PdfGridHeaderCollection
  RepeatHeader               Gets or set a value indicating whether to repeat header            Boolean
  Rows                       Gets the rows.                                                     PdfGridRowCollection
  Style                      Gets or sets the style.                                            PdfGridStyle
  -------------------------- ------------------------------------------------------------------ -------------------------
:::

 

Methods

 

::: {align="center"}
+-----------------+-----------------+---------------------------------------------------------------------------+---------------------+
| Method          | Description     | Parameters                                                                | Return Type         |
+-----------------+-----------------+---------------------------------------------------------------------------+---------------------+
| Draw            | Draws PdfGrid   | Overloads:                                                                | Void                |
|                 |                 |                                                                           |                     |
|                 |                 | (PdfGraphics graphics)                                                    |                     |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, PointF location)                                           | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, RectangleF bounds)                                         | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfGraphics graphics, PointF location)                                   | Void                |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfGraphics graphics, RectangleF bounds)                                 | Void                |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, float x, float y)                                          | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, PointF location, PdfGridLayoutFormat format)               | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, PointF location, PdfLayoutFormat format)                   | PdfLayoutResult     |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, RectangleF bounds, PdfGridLayoutFormat format)             | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, PointF location, PdfLayoutFormat format)                   | PdfLayoutResult     |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfGraphics graphics, float x, float y)                                  | void                |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfGraphics graphics, PointF location, float width)                      | void                |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, float x, float y, float width)                             | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | PdfPage page, float x, float y, PdfGridLayoutFormat format)               | PdfGridLayoutResult |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, float x, float y, PdfLayoutFormat format)                  | PdfLayoutResult     |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfGraphics graphics, float x, float y, float width)                     | void                |
|                 |                 +---------------------------------------------------------------------------+---------------------+
|                 |                 | (PdfPage page, float x, float y, float width, PdfGridLayoutFormat format) | PdfGridLayoutResult |
+=================+=================+===========================================================================+=====================+
:::

 

Events

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------+
| Name                              | Description                                                            |
+-----------------------------------+------------------------------------------------------------------------+
| BeginPageLayout                   | This event is raised before the element should is printed on the page. |
|                                   |                                                                        |
|                                   | (Inherited from PdfLayoutElement.)                                     |
+-----------------------------------+------------------------------------------------------------------------+
| EndPageLayout                     | This event is raised after the element is printed on the page.         |
|                                   |                                                                        |
|                                   | (Inherited from PdfLayoutElement.)                                     |
+-----------------------------------+------------------------------------------------------------------------+
:::

 

###### []{#_PdfGrid_Creation}4.1.2.3.2.2 PdfGrid Creation {#pdfgrid-creation style="tab-stops: 0pt"}

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: You must add Syncfusion.Pdf.Grid namespace to work with PdfGrid.
:::

You can create a PdfGrid by simply specifying the new operator with a proper constructor. After assigning data source it can be drawn using one of the overloads of Draw method.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [// Create a PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                               |
| [PdfGrid]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGrid = [new]{style="COLOR: blue"} [PdfGrid]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [// Assign data source.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                               |
| [pdfGrid.DataSource = dataSource;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [// Draw PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                                               |
| [pdfGrid.Draw(graphics);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                  |
|                                                                                                                                                                     |
|                                                                                                                                                                     |
|                                                                                                                                                                     |
| [\' Create a PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGrid [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGrid()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [\' Assign data source.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                     |
| [pdfGrid.DataSource = dataSource]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [\' Draw PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                     |
| [pdfGrid.Draw(graphics)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Data to PdfGrid can be entered manually or taken from an external data source. Also, the draw method helps to control the layout of the PdfGrid and returns information to user after drawing completes. The following topics discuss them.

[·      ]{style="FONT-FAMILY: Symbol"}Data

[·      ]{style="FONT-FAMILY: Symbol"}Layout

 

AllowRowBreakAcrossPages

 

This property allows changing the row split behavior across pages. By default, this Boolean property is set to True, which allows splitting the row across pages when the row cannot accommodate within the bounds of the page. If set to false, the entire row will be shifted to the next page.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: If the row height is greater than the page height, the row will be split or cut based on the True and False value of this property.
:::

 

[]{#_Data_1}4.1.2.3.2.2.1      Data

 

External Data Source

 

You can bind data to a PdfGrid by associating it with an external data source. You can set the external data source by using the DataSource property. The following code example illustrates this.

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
| [DataTable]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dt = [new]{style="COLOR: blue"} [DataTable]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                              |
| [dt.Columns.Add([\"ID\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                              |
| [dt.Columns.Add([\"Name\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
| [dt.Rows.Add([new]{style="COLOR: blue"} [object]{style="COLOR: blue"}\[\] { [\"E01\"]{style="COLOR: #a31515"}, [\"Clay\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                              |
| [dt.Rows.Add([new]{style="COLOR: blue"} [object]{style="COLOR: blue"}\[\] { [\"E02\"]{style="COLOR: #a31515"}, [\"Thomas\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
| [// Create a PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                     |
|                                                                                                                                                                                              |
| [PdfGrid]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGrid = [new]{style="COLOR: blue"} [PdfGrid]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
|                                                                                                                                                                                              |
| [// dt is an object that can be an array (two-dimensional, one-dimensional or nested), a DataTable, DataColumn, DataView or DataSet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}      |
|                                                                                                                                                                                              |
| [pdfGrid.DataSource = dt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dt [As]{style="COLOR: blue"} DataTable = [New]{style="COLOR: blue"} DataTable()]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                           |
| [dt.Columns.Add([\"ID\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                           |
| [dt.Columns.Add([\"Name\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [dt.Rows.Add([New]{style="COLOR: blue"} [Object]{style="COLOR: blue"}() { [\"E01\"]{style="COLOR: #a31515"}, [\"Clay\"]{style="COLOR: #a31515"}})]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                           |
| [dt.Rows.Add([New]{style="COLOR: blue"} [Object]{style="COLOR: blue"}() { [\"E02\"]{style="COLOR: #a31515"}, [\"Thomas\"]{style="COLOR: #a31515"} })]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [\' Create a PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGrid [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGrid()]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [\' dt is an object that can be an array (two-dimensional, one-dimensional or nested), a DataTable, DataColumn, DataView or DataSet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}   |
|                                                                                                                                                                                           |
| [pdfGrid.DataSource = dt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Direct Rows and Columns

 

Alternatively, you can bind data to a PdfGrid without setting any data source. This is achieved using the PdfGridRow and PdfGridColumn classes. The following code example illustrates this.

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfPage = pdfDocument.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [// Create a new PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                               |
| [PdfGrid]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGrid = [new]{style="COLOR: blue"} [PdfGrid]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [// Add three columns.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                               |
| [pdfGrid.Columns.Add(3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [// Add header.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                               |
| [pdfGrid.Headers.Add(1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                               |
| [PdfGridRow]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGridHeader = pdfGrid.Headers\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                               |
| [pdfGridHeader.Cells\[0\].Value = [\"Employee ID\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                               |
| [pdfGridHeader.Cells\[1\].Value = [\"Employee Name\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                               |
| [pdfGridHeader.Cells\[2\].Value = [\"Salary\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [// Add rows.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                               |
| [PdfGridRow]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGridRow = pdfGrid.Rows.Add();]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                               |
| [pdfGridRow.Cells\[0\].Value = [\"E01\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                               |
| [pdfGridRow.Cells\[1\].Value = [\"Clay\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                               |
| [pdfGridRow.Cells\[2\].Value = [\"\$10,000\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [// Draw the PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                               |
| [pdfGrid.Draw(pdfPage, [PointF]{style="COLOR: #2b91af"}.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                   |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfPage [As]{style="COLOR: blue"} PdfPage = pdfDocument.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| [\' Create a new PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGrid [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGrid()]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| [\' Add three columns.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                            |
|                                                                                                                                                                      |
| [pdfGrid.Columns.Add(3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| [\' Add header.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                      |
| [pdfGrid.Headers.Add(1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGridHeader [As]{style="COLOR: blue"} PdfGridRow = pdfGrid.Headers(0)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| [pdfGridHeader.Cells(0).Value = [\"Employee ID\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                      |
| [pdfGridHeader.Cells(1).Value = [\"Employee Name\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                      |
| [pdfGridHeader.Cells(2).Value = [\"Salary\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| [\' Add rows.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGridRow [As]{style="COLOR: blue"} PdfGridRow = pdfGrid.Rows.Add()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                      |
| [pdfGridRow.Cells(0).Value = [\"E01\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                      |
| [pdfGridRow.Cells(1).Value = [\"Clay\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                      |
| [pdfGridRow.Cells(2).Value = [\"\$10,000\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| [\' Draw the PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                      |
| [pdfGrid.Draw(pdfPage, PointF.Empty)]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#_Layout}4.1.2.3.2.2.2      Layout

 

This section speaks about layouting options and the two events associated with PdfGrid.

 

PdfGridLayoutFormat

 

Layouting PdfGrid can be done using the PdfGridLayoutFormat class. Overloads accepting pages can accept standard formats as other layouting elements. However, they treat the PdfLayoutBreakType.FitElement value of Format.Break property as one, for a single row and not for the entire PdfGrid.

 

Properties

 

::: {align="center"}
  ---------------- -------------------------------------------------------- --------------------
  Name             Description                                              Data Type
  Break            Gets or sets the break type                              PdfLayoutBreakType
  Layout           Gets or sets the layout type                             PdfLayoutType
  PaginateBounds   Gets or sets the PdfGrid bounds for the following page   RectangleF
  ---------------- -------------------------------------------------------- --------------------
:::

 

The PdfLayoutType class is used to specify the type of pagination. The Paginate LayoutType draws the PdfGrid to the next following pages, if the element exceeds the page. The OnePage layout draws the element only on one page. The following code example illustrates this.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                     |
|                                                                                                                                                                                                     |
|                                                                                                                                                                                                     |
| [PdfGridTableLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfGridLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| [format.Layout = [PdfLayoutType]{style="COLOR: teal"}.Paginate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                     |
| [format.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitElement;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                     |
|                                                                                                                                                                                                     |
|                                                                                                                                                                                                     |
| [// Draws the PdfGrid with the layout format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                                     |
| [pdfGrid.Draw(pdfPage, [PointF]{style="COLOR: teal"}.Empty, format);]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                                      |
|                                                                                                                                                                                                      |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} PdfGridLayoutFormat = [New]{style="COLOR: blue"} PdfGridLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                      |
| [format.Layout = PdfLayoutType.Paginate]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                      |
| [format.Break = PdfLayoutBreakType.FitElement]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                      |
|                                                                                                                                                                                                      |
|                                                                                                                                                                                                      |
| [\' Draws the PdfGrid with the layout format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                                      |
| [pdfGrid.Draw(pdfPage, PointF.Empty, format)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

PdfGridLayoutResult

 

You can get the layout settings for the drawn PdfGrid with the help of PdfGridLayoutResult class. Also, you can get the bounds and the last page where the PdfGrid was drawn using the Bounds and Page properties. This is mainly used to write some text or any other element below the large table that shows number of pages.

 

Properties

 

::: {align="center"}
  -------- ----------------------------------------------------- ------------
  Name     Description                                           Data Type
  Bounds   Gets the bounds in the last page where it was drawn   RectangleF
  Page     Gets the last page where PdfLightTable was drawn      PdfPage
  -------- ----------------------------------------------------- ------------
:::

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [// Draws the PdfGrid]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                           |
| [PdfGridLayoutResult]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ result = pdfGrid.Draw(pdfPage, [PointF]{style="COLOR: teal"}.Empty, format);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [// Returns the rectangle value for the last page.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                           |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.WriteLine(result.Bounds.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                              |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [\' Draws the PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} PdfGridLayoutResult = pdfGrid.Draw(pdfPage, PointF.Empty, format)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [\' Returns the rectangle value for the last page.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                                                 |
| [Console.WriteLine(result.Bounds.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Events

 

The following events are associated with PdfGrid. The functionalities of these events are common for both PdfGrid and PdfLightTable.

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[BeginPageLayout]{.UGHyperlink}](ms-xhelp:///?Id=556cead6-bb87-49b1-b05f-54fc84a45446)[  ]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[[[EndPageLayout  ]{style="COLOR: blue"}]{.underline}](ms-xhelp:///?Id=556cead6-bb87-49b1-b05f-54fc84a45446)]{.UGHyperlink}

 

###### []{#_PdfGrid_Formatting}[[4.1.2.3.2.3  PdfGrid Formatting]{style="FONT-WEIGHT: normal"}]{.Heading6Char} {#pdfgrid-formatting style="tab-stops: 0pt"}

 

This section explains the most direct options available to format PdfGrid. The PdfGridStyle class, accessible through Style property of PdfGrid provides options to format entire PdfGrid or parts of it. Formatting applicable for entire PdfGrid using PdfGridStyle class is discussed in this section. Header, Row, Column and Cell are discussed in the following links:

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Header ]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Row ]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Column ]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Cell]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: If the style properties are applied to both PdfGridCell and PdfGridRow, PdfGridCell takes over the precedence. Following is an example for the exact order of precedence.
:::

 

PdfBrush backgroundBrush = Cell.BackgroundBrush ?? Row.Style.BackgroundBrush ?? Row.Grid.Style.BackgroundBrush

 

Properties

 

::: {align="center"}
  ------------------------- ----------------------------------------------------------------------- ---------------------------
  Name                      Description                                                             Data Type
  AllowHorizontalOverflow   Gets or sets a value indicating whether to allow horizontal overflow.   Boolean
  BackgroundBrush           Gets or sets background brush.                                          PdfBrush
  BorderOverlapStyle        Gets or sets border overlap style.                                      PdfBorderOverlapStyle
  CellPadding               Gets or sets cell padding.                                              PdfPaddings
  CellSpacing               Gets or sets cell spacing.                                              Float
  Font                      Gets or sets the font.                                                  PdfFont
  HorizontalOverflowType    Gets or sets the type of horizontal overflow.                           PdfHorizontalOverflowType
  TextBrush                 Gets or sets the text brush.                                            PdfBrush
  TextPen                   Gets or sets the text pen.                                              PdfPen
  ------------------------- ----------------------------------------------------------------------- ---------------------------
:::

 

AllowHorizontalOverflow

 

If set to True, the columns exceeding the current page width would be wrapped and drawn in the next or last page. The default value is false. It should be used along with HorizontalOverflowType property. The default value of HorizontalOverflowType is PdfHorizontalOverflowType.LastPage.

 

+--------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                             |
|                                                                                                                                            |
|                                                                                                                                            |
|                                                                                                                                            |
| [pdfGrid.Style.AllowHorizontalOverflow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                            |
| [pdfGrid.Style.HorizontalOverflowType = [PdfHorizontalOverflowType]{style="COLOR: #2b91af"}.NextPage;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                        |
|                                                                                                                                           |
|                                                                                                                                           |
|                                                                                                                                           |
| [pdfGrid.Style.AllowHorizontalOverflow = T[rue]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                           |
| [pdfGrid.Style.HorizontalOverflowType = [PdfHorizontalOverflowType]{style="COLOR: #2b91af"}.NextPage]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------+

 

BorderOverlapStyle

 

This property decides if the cell border should overlap with neighboring cells or to draw the interior of cell.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: This property applies for all cells in the PdfGrid. Be careful while using overlapping borders, because they may produce bad results if they are not of the same width and color.
:::

 

+-----------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                    |
|                                                                                                                                   |
|                                                                                                                                   |
|                                                                                                                                   |
| [pdfGrid.Style.BorderOverlapStyle = [PdfBorderOverlapStyle]{style="COLOR: #2b91af"}.Overlap;]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                               |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
| [pdfGrid.Style.BorderOverlapStyle = [PdfBorderOverlapStyle]{style="COLOR: #2b91af"}.Overlap]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------+

 

CellPadding

 

The distance between text and border inside a cell otherwise known as CellPadding, can be set to all cells in the PdfGrid. The PdfPaddings class allows setting padding to individual or all sides.

 

+-------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                          |
|                                                                                                                         |
|                                                                                                                         |
|                                                                                                                         |
| [// Padding will be applied for all four sides of cells in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                                                                         |
| [pdfGrid.Style.CellPadding.All = 0.3f;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                         |
| [// Padding will be applied only at the top of all cells in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                         |
| [pdfGrid.Style.CellPadding.Top = 0.3f;]{style="FONT-FAMILY: 'Courier New'"}                                             |
+-------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                                |
|                                                                                                                                                                |
|                                                                                                                                                                |
| [\' Padding will be applied for all four sides of cells in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                |
| [pdfGrid.Style.CellPadding.All = 0.3f]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Padding will be applied only at the top for all cells in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| [pdfGrid.Style.CellPadding.Top = 0.3f]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

CellSpacing

 

The distance between the cells otherwise known as CellSpacing, can be set to all cells in PdfGrid using CellSpacing property.

 

+-------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**          |
|                                                                         |
|                                                                         |
|                                                                         |
| [pdfGrid.Style.CellSpacing = 0.5f;]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------+

 

+------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**     |
|                                                                        |
|                                                                        |
|                                                                        |
| [pdfGrid.Style.CellSpacing = 0.5f]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------+

 

[]{#_Header}4.1.2.3.2.3.1      Header

 

Header is a set of rows that can be optionally repeated on each page and has its own style. You can add header as follows:

[·      ]{style="FONT-FAMILY: Symbol"}Directly from column captions.

[·      ]{style="FONT-FAMILY: Symbol"}By using Add method of the PdfGridHeaderCollection class.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: When you bind data source to PdfGrid, column captions will be automatically added to header collection. It can be removed at any time using Clear method of PdfGridHeaderCollection.
:::

 

The following code example illustrates how to add headers to PdfGrid by using the Add method.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                            |
|                                                                                                                                                            |
|                                                                                                                                                            |
| [// Add a new header to PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                        |
|                                                                                                                                                            |
| [pdfGrid.Headers.Add(1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                            |
|                                                                                                                                                            |
|                                                                                                                                                            |
| [// Get the first header row.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                           |
|                                                                                                                                                            |
| [PdfGridCellCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ collection = pdfGrid.Headers\[0\].Cells;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                            |
|                                                                                                                                                            |
|                                                                                                                                                            |
| [// Set the header names.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                            |
| [collection\[0\].Value = [\"Header1\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                            |
| [collection\[1\].Value = [\"Header2\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                            |
| [collection\[2\].Value = [\"Header3\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                            |
| [collection\[3\].Value = [\"Header4\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [\' Add a new header to PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                                    |
| [pdfGrid.Headers.Add(1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [\' Get the first header row.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ collection [As]{style="COLOR: blue"} PdfGridCellCollection = pdfGrid.Headers(0).Cells]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [\' Set the header names.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                    |
| [collection(0).Value = [\"Header1\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                    |
| [collection(1).Value = [\"Header2\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                    |
| [collection(2).Value = [\"Header3\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                    |
| [collection(3).Value = [\"Header4\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

RepeatHeader

 

Header can be set to repeat on each page where PdfGrid is paginated.  RepeatHeader property should be set to true to achieve this.

 

+-------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                            |
|                                                                                           |
|                                                                                           |
|                                                                                           |
| [pdfGrid.RepeatHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                       |
|                                                                                          |
|                                                                                          |
|                                                                                          |
| [pdfGrid.RepeatHeader = T[rue]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------+

 

Style

 

You can specify the header style for the PdfGrid by using the PdfGridRowStyle or PdfGridCellStyle classes. The style applied at the collection will be applied to all rows in the header. Following code example illustrates how to specify the header style.

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                |
|                                                                               |
|                                                                               |
|                                                                               |
| [// Applying header style.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                               |
| [pdfGrid.Headers.ApplyStyle(style);]{style="FONT-FAMILY: 'Courier New'"}      |
+-------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**            |
|                                                                               |
|                                                                               |
|                                                                               |
| [\' Applying header style.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                               |
| [pdfGrid.Headers.ApplyStyle(style)]{style="FONT-FAMILY: 'Courier New'"}       |
+-------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Styles for each PdfGridRow in Header can be individually applied using PdfGridRowStyle class.
:::

Refer to the following topics for more details:

[[PdfGridRowStyle]{.UGHyperlink}]()[ ]{.UGHyperlink}

[[PdfGridCellStyle]{.UGHyperlink}]()[ ]{.UGHyperlink}

 

[]{#_Row}4.1.2.3.2.3.2      Row

 

Height

 

The Height property of the PdfGridRow class is used to specify the row height for the PdfGrid rows. The following code example illustrates how to set this property.

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                         |
|                                                                                                                                        |
|                                                                                                                                        |
|                                                                                                                                        |
| [// Access the row in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                      |
|                                                                                                                                        |
| [PdfGridRow]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGridRow = pdfGrid.Rows\[0\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                        |
|                                                                                                                                        |
|                                                                                                                                        |
| [// Set the height for a row.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                       |
|                                                                                                                                        |
| [pdfGridRow.Height = 20;]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                                |
|                                                                                                                                                                |
|                                                                                                                                                                |
| [\' Access the row in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGridRow [As]{style="COLOR: blue"} PdfGridRow = pdfGrid.Rows(0)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
|                                                                                                                                                                |
|                                                                                                                                                                |
| [\' Set the height for a row.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                |
| [pdfGridRow.Height = 20]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: The unit of the Height property is always points. You can set the PDF units only as points. Also, you can use the [[PdfUnitConvertor]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 9pt"}](ms-xhelp:///?Id=7c49f7ec-c075-4124-bbe7-e86233755f5f) class to convert the other units to points.
:::

 

Row Span

 

PdfGrid enables you to merge cells within a row. You can specify the number of cells to be merged using the RowSpan property of PdfGridCell class. The following code example illustrates this.

 

+-----------------------------------------------------------------------------------------+
| [ ]{style="COLOR: black"}**[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** |
|                                                                                         |
|                                                                                         |
|                                                                                         |
| [// Merging row cells.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}               |
|                                                                                         |
| [pdfGridRow.Cells\[0\].RowSpan = 2;]{style="FONT-FAMILY: 'Courier New'"}                |
+-----------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**        |
|                                                                           |
|                                                                           |
|                                                                           |
| [\' Merging row cells.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                           |
| [pdfGridRow.Cells(0).RowSpan = 2]{style="FONT-FAMILY: 'Courier New'"}     |
+---------------------------------------------------------------------------+

[]{style="COLOR: black"} 

Style

 

The PdfGridRowStyle class, accessed through Style property of PdfGridRow class is used to specify the row style for the PdfGrid rows.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: If the style properties are applied to both PdfGridCell and PdfGridRow, PdfGridCell takes over the precedence. Following is an example for the exact order of precedence.
:::

 

PdfBrush backgroundBrush = Cell.BackgroundBrush ?? Row.Style.BackgroundBrush ?? Row.Grid.Style.BackgroundBrush

The following code example illustrates how to specify the row style for the PdfGrid rows:

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
| [// Create an instance of PdfGridRowStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                                                                       |
| [PdfGridRowStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGridRowStyle = [new]{style="COLOR: blue"} [PdfGridRowStyle]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                       |
| [pdfGridRowStyle.BackgroundBrush = [PdfBrushes]{style="COLOR: #2b91af"}.LightYellow;]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                       |
| [pdfGridRowStyle.Font = [new]{style="COLOR: blue"} [PdfStandardFont]{style="COLOR: #2b91af"}([PdfFontFamily]{style="COLOR: #2b91af"}.Courier, 10);]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                       |
| [pdfGridRowStyle.TextBrush = [PdfBrushes]{style="COLOR: #2b91af"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                       |
| [pdfGridRowStyle.TextPen = [PdfPens]{style="COLOR: #2b91af"}.Pink;]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [// Set style for the PdfGridRow.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                       |
| [pdfGrid.Rows\[0\].Style = pdfGridRowStyle;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                     |
|                                                                                                                                                                                     |
|                                                                                                                                                                                     |
| [\' Create an instance of PdfGridRowStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGridRowStyle [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGridRowStyle()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [pdfGridRowStyle.BackgroundBrush = PdfBrushes.LightYellow]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                     |
| [pdfGridRowStyle.Font = [New]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Courier, 10)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                     |
| [pdfGridRowStyle.TextBrush = PdfBrushes.Blue]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                     |
| [pdfGridRowStyle.TextPen = PdfPens.Pink]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                     |
| [\' Set style for the PdfGridRow.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                     |
| [pdfGrid.Rows(0).Style = pdfGridRowStyle]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

You may also apply PdfGridCellStyle to a PdfGridRow using the ApplyStyle property. The following code snippet illustrates this:

 

+---------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                        |
|                                                                                       |
|                                                                                       |
|                                                                                       |
| [// Set style for the PdfGridRow.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                                       |
| [pdfGrid.Rows\[0\].ApplyStyle(pdfGridCellStyle);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                   |
|                                                                                      |
|                                                                                      |
|                                                                                      |
| [// Set style for the PdfGridRow.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                      |
| [pdfGrid.Rows(0).ApplyStyle(pdfGridCellStyle)]{style="FONT-FAMILY: 'Courier New'"}   |
+--------------------------------------------------------------------------------------+

 

All rows in the PdfGrid can be set with same style using the ApplyStyle method of PdfGridRowCollection. This style can be a PdfGridRowStyle or PdfGridCellStyle. The following is the code snippet:

 

+-------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                            |
|                                                                                           |
|                                                                                           |
|                                                                                           |
| [// Set style for all rows in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                           |
| [pdfGrid.Rows.ApplyStyle(style);]{style="FONT-FAMILY: 'Courier New'"}                     |
+-------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                        |
|                                                                                           |
|                                                                                           |
|                                                                                           |
| [// Set style for all rows in PdfGrid.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                           |
| [pdfGrid.Rows.ApplyStyle(style)]{style="FONT-FAMILY: 'Courier New'"}                      |
+-------------------------------------------------------------------------------------------+

 

Refer to the following topic for more details:

[[PdfGridCellStyle]{style="FONT-FAMILY: 'Arial','sans-serif'"}]()[]{style="COLOR: red"}

 

[]{#_Column}4.1.2.3.2.3.3      Column

 

Width

 

By default, all the columns in PdfGrid have equal width, and the columns automatically fill the entire width of the PdfGrid. If the width of the PdfGrid is increased or decreased, the column width also changes appropriately.

You can specify the width for a particular column by using the Width property. The following code example illustrates how to set the width.

 

+------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                     |
|                                                                                    |
|                                                                                    |
|                                                                                    |
| [// Set Width for first column.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                    |
| [pdfGrid.Columns\[0\].Width = 20f;]{style="FONT-FAMILY: 'Courier New'"}            |
+------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                 |
|                                                                                    |
|                                                                                    |
|                                                                                    |
| [\' Set Width for first column.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                    |
| [pdfGrid.Columns(0).Width = 20f]{style="FONT-FAMILY: 'Courier New'"}               |
+------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: The unit of the Width property is always points. You can set the PDF units only as points. Also, you can use the [[PdfUnitConvertor class]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 9pt"}](ms-xhelp:///?Id=7c49f7ec-c075-4124-bbe7-e86233755f5f) to convert the other units to points.
:::

 

Column Span

 

PdfGrid enables you to merge cells within a column. You can specify the number of cells to be merged by using the ColumnSpan property PdfGridCell class. The following code example illustrates this.

 

+------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                     |
|                                                                                    |
|                                                                                    |
|                                                                                    |
| [// Merging column cells.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}       |
|                                                                                    |
| [pdfGrid.Rows\[0\].Cells\[0\].ColumnSpan = 2;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**            |
|                                                                               |
|                                                                               |
|                                                                               |
| [\' Merging column cells.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                               |
| [pdfGrid.Rows(0).Cells(0).ColumnSpan = 2]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

Format

 

You can specify the content format for the PdfGrid columns by using the Format property. Check String Formatting in [DrawingText](ms-xhelp:///?Id=942935a6-44ea-42da-abb5-dc0e88f91997) for more details.

 

[]{#_Cell}4.1.2.3.2.3.4      Cell

 

Properties

 

::: {align="center"}
  ------------------------------------------------------------------------------------------------------------------- ---------------------------------------------------------------- ----------------------
  Name                                                                                                                Description                                                      Data Type
  [[ColumnSpan]{style="FONT-FAMILY: 'Arial','sans-serif'"}]()                                                         Gets or set the column span.                                     Integer
  Height                                                                                                              Gets the height.                                                 Float
  ImagePosition                                                                                                       Gets or sets the image alignment type of the background image.   PdfGridImagePosition
  [[RowSpan]{style="FONT-FAMILY: 'Arial','sans-serif'"}]()                                                            Gets or sets the row span                                        Integer
  [[StringFormat]{style="FONT-FAMILY: 'Arial','sans-serif'"}](ms-xhelp:///?Id=942935a6-44ea-42da-abb5-dc0e88f91997)   Gets or sets the string format.                                  PdfStringFormat
  Style                                                                                                               Gets or sets the cell style.                                     PdfGridCellStyle
  Value                                                                                                               Gets or sets the value.                                          Object
  Width                                                                                                               Gets the width.                                                  float
  ------------------------------------------------------------------------------------------------------------------- ---------------------------------------------------------------- ----------------------
:::

 

Cell Size

 

The width and height cannot be modified for a single cell, but for the entire column or row. Please check [PdfGridColumn]() and [PdfGridRow]() for more details.

 

Value

 

You can specify the value for an individual cell using the Value property. Also, you can specify another PdfGrid as the cell value to make a nested table. The following code snippet illustrates this.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [// Set the value to the specific cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                                    |
| [parentPdfGrid.Rows\[0\].Cells\[0\].Value = [\"Nested Table\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                    |
| [parentPdfGrid.Rows\[0\].Cells\[1\].RowSpan = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                    |
| [parentPdfGrid.Rows\[0\].Cells\[1\].ColumnSpan = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [PdfGrid]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ childPdfGrid = [new]{style="COLOR: blue"} [PdfGrid]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [childPdfGrid.Columns.Add(5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                    |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i = 0; i \< 5; i++)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                    |
| [PdfGridRow]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ row = childPdfGrid.Rows.Add();]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                    |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} j = 0; j \< 5; j++)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                    |
| [row.Cells\[j\].Value = [String]{style="COLOR: #2b91af"}.Format([\"Cell \[{0} {1}\]\"]{style="COLOR: #a31515"}, j, i);]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [// Set the value as another PdfGrid in a cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                                    |
| [parentGrid.Rows\[0\].Cells\[1\].Value = childPdfGrid;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                                         |
|                                                                                                                                                                                         |
|                                                                                                                                                                                         |
| [\' Set the value to the specific cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                         |
| [parentPdfGrid.Rows(0).Cells(0).Value = [\"Nested Table\"]{style="COLOR: darkred"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                         |
| [parentPdfGrid.Rows(0).Cells(1).RowSpan = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                         |
| [parentPdfGrid.Rows(0).Cells(1).ColumnSpan = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ childPdfGrid [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGrid()]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                         |
| [childPdfGrid.Columns.Add(5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                         |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 4]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ row [As]{style="COLOR: blue"} PdfGridRow = childPdfGrid.Rows.Add()]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                         |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ j [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} 4]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [row.Cells(j).Value = [String]{style="COLOR: blue"}.Format([\"Cell \[{0} {1}\]\"]{style="COLOR: darkred"}, j, i)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                         |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ j]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                         |
| [\' Set the value as another PdfGrid in a cell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                         |
| [parentGrid.Rows(0).Cells(1).Value = childPdfGrid]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

Style

 

PdfGrid provides various options to customize the cell content, text color, background color, and so on. The following properties can be used for this purpose.

 

Properties

 

::: {align="center"}
  ----------------- --------------------------------------------- -----------------
  Name              Description                                   Data Type
  BackgroundBrush   Gets or sets background brush for the cell.   PdfBrush
  BackgroundImage   Gets or sets background image for the cell.   PdfImage
  Borders           Gets or sets the borders                      PdfBorders
  Font              Gets or sets the font.                        PdfFont
  StringFormat      Gets or sets the string format                PdfStringFormat
  TextBrush         Gets or sets the text brush.                  PdfBrush
  TextPen           Gets or sets the text pen.                    PdfPen
  ----------------- --------------------------------------------- -----------------
:::

 

The following code example illustrates how to customize the cell content.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                           |
|                                                                                                                                                                                                          |
|                                                                                                                                                                                                          |
|                                                                                                                                                                                                          |
| [//Specify the style for the PdfGridCell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                          |
| [PdfGridCellStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGridCellStyle = [new]{style="COLOR: blue"} [PdfGridCellStyle]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                          |
| [pdfGridCellStyle.BackgroundImage = [new]{style="COLOR: blue"} [PdfBitmap]{style="COLOR: #2b91af"}([\"pdf_button.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                          |
| [pdfGridCellStyle.TextPen = [PdfPens]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                          |
| [pdfGridCellStyle.Borders.All = [PdfPens]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                          |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                          |
| [PdfGridCell]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfGridCell = pdfGrid.Rows\[0\].Cells\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                          |
| [// Apply style]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                       |
|                                                                                                                                                                                                          |
| [pdfGridCell.Style = pdfGridCellStyle;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                          |
| [// Set image position for the background image in the style.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                                                          |
| [pdfGridCell.ImagePosition = [PdfGridImagePosition]{style="COLOR: #2b91af"}.Fit;]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                    |
|                                                                                                                                                                                       |
|                                                                                                                                                                                       |
|                                                                                                                                                                                       |
| [\'Specify the style for the PdfGridCell.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGridCellStyle [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGridCellStyle()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                       |
| [pdfGridCellStyle.BackgroundImage = [New]{style="COLOR: blue"} PdfBitmap([\"pdf_button.png\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                       |
| [pdfGridCellStyle.TextPen = PdfPens.Red]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                       |
| [pdfGridCellStyle.Borders.All = PdfPens.Red]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfGridCell [As]{style="COLOR: blue"} PdfGridCell = pdfGrid.Rows(0).Cells(0)]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                       |
| [\' Apply style]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                       |
| [pdfGridCell.Style = pdfGridCellStyle]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                       |
| [\' Set image position for the background image in the style.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                       |
| [pdfGridCell.ImagePosition = PdfGridImagePosition.Fit]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

For more details on PdfGridImagePosition, check the following FAQ:

[[PdfGridCell background image]{.UGHyperlink}](ms-xhelp:///?Id=be34385c-c628-43a9-a593-a68c54896ad9)[ ]{.UGHyperlink}

 

[]{#related-topics}
::::::::::::::::::::
