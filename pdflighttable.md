::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::::::::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### PdfLightTable {#pdflighttable style="tab-stops: 0pt"}

 

The PdfLightTable class represents simple tables that are used for publishing structured data from arrays, data tables or data columns. There are no real cells or rows, and all the data is taken from the data source (DataSource property).

Using PdfLightTable, any type of table can be created using its event handlers. PdfLightTable in Silverlight supports IEnumerable and TableDirect data sources and not arrays, data tables or data columns. This section explains how to draw PdfLightTable elements using Essential PDF. It includes the following topics:

 

###### []{#_Properties,_Methods_and_1}4.1.2.3.1.1 Properties, Methods and Events {#properties-methods-and-events style="tab-stops: 0pt"}

 

Properties

 

::: {align="center"}
  -------------------------- ---------------------------------------------------------------------------------------------- -----------------------------
  Name                       Description                                                                                    Data Type
  AllowRowBreakAcrossPages   Gets or sets a value indicating the row break is to be made or not                             Boolean
  Columns                    Gets the columns                                                                               PdfColumnCollection
  DataMember                 Gets or sets the data member                                                                   String
  DataSource                 Gets or sets the data source                                                                   Object
  DataSourceType             Gets or sets the data source type of the PdfLightTable                                         PdfLightTableDataSourceType
  IgnoreSorting              Gets or sets a value indicating whether PdfLightTable should ignore sorting in the DataTable   Boolean
  Rows                       Gets the rows                                                                                  PdfRowCollection
  Style                      Gets or sets the properties                                                                    PdfLightTableStyle
  -------------------------- ---------------------------------------------------------------------------------------------- -----------------------------
:::

 

Methods

 

::: {align="center"}
+-----------------+---------------------+---------------------------------------------------------------------------------+---------------------------+
| Method          | Description         | Parameters                                                                      | Return Type               |
+-----------------+---------------------+---------------------------------------------------------------------------------+---------------------------+
| Draw            | Draws PdfLightTable | Overloads:                                                                      | Void                      |
|                 |                     |                                                                                 |                           |
|                 |                     | (PdfGraphics graphics)                                                          |                           |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, PointF location)                                                 | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, RectangleF bounds)                                               | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfGraphics graphics, PointF location)                                         | Void                      |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfGraphics graphics, RectangleF bounds)                                       | Void                      |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, float x, float y)                                                | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, PointF location, PdfLightTableLayoutFormat format)               | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, PointF location, PdfLayoutFormat format)                         | PdfLayoutResult           |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, RectangleF bounds, PdfLightTableLayoutFormat format)             | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, PointF location, PdfLayoutFormat format)                         | PdfLayoutResult           |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfGraphics graphics, float x, float y)                                        | void                      |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfGraphics graphics, PointF location, float width)                            | void                      |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, float x, float y, float width)                                   | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | PdfPage page, float x, float y, PdfLightTableLayoutFormat format)               | PdfLightTableLayoutResult |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, float x, float y, PdfLayoutFormat format)                        | PdfLayoutResult           |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfGraphics graphics, float x, float y, float width)                           | void                      |
|                 |                     +---------------------------------------------------------------------------------+---------------------------+
|                 |                     | (PdfPage page, float x, float y, float width, PdfLightTableLayoutFormat format) | PdfLightTableLayoutResult |
+=================+=====================+=================================================================================+===========================+
:::

 

Events

 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------+
| Name                              | Description                                                     |
+-----------------------------------+-----------------------------------------------------------------+
| BeginCellLayout                   | This event is raised on starting cell layout.                   |
+-----------------------------------+-----------------------------------------------------------------+
| BeginPageLayout                   | This event is raised before the element is printed on the page. |
|                                   |                                                                 |
|                                   | (Inherited from PdfLayoutElement.)                              |
+-----------------------------------+-----------------------------------------------------------------+
| BeginRowLayout                    | This event is raised on starting row layout.                    |
+-----------------------------------+-----------------------------------------------------------------+
| EndCellLayout                     | This event is raised on having finished cell layout.            |
+-----------------------------------+-----------------------------------------------------------------+
| EndPageLayout                     | This event is raised after the element is printed on the page.  |
|                                   |                                                                 |
|                                   | (Inherited from PdfLayoutElement.)                              |
+-----------------------------------+-----------------------------------------------------------------+
| EndRowLayout                      | This event is raised on finishing row layout.                   |
+-----------------------------------+-----------------------------------------------------------------+
| QueryColumnCount                  | This event is raised when the column number is requested.       |
+-----------------------------------+-----------------------------------------------------------------+
| QueryNextRow                      | This event is raised when the next row data is requested.       |
+-----------------------------------+-----------------------------------------------------------------+
| QueryRowCount                     | This event is raised when the row number is requested.          |
+-----------------------------------+-----------------------------------------------------------------+
:::

 

###### []{#_PDFLightTable_Creation}4.1.2.3.1.2 PdfLightTable Creation {#pdflighttable-creation style="tab-stops: 0pt"}

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: You should add the Syncfusion.Pdf.Tables namespace to work with PdfLightTable.
:::

 

You may create a PdfLightTable simply by specifying a new operator with the proper constructor. After assigning the data source, it can be drawn using one of the overloads of Draw method as follows:

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                                 |
| [// Creating a PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                |
|                                                                                                                                                                                                 |
| [PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfLightTable = [new]{style="COLOR: blue"} [PdfLightTable]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                 |
| [// Assigning data source.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                 |
| [pdfLightTable.DataSource = dataSource;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                 |
| [// Drawing PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                 |
| [pdfLightTable.Draw(graphics);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                 |
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                              |
|                                                                                                                                                                                                 |
| [\' Creating a PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLightTable()]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                 |
| [\' Assigning data source.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                 |
| [pdfLightTable.DataSource = dataSource]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                 |
| [\' Drawing PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                 |
| [pdfLightTable.Draw(graphics)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Different types of data can be set to PdfLightTable. Also, the draw method facilitates overloads that would help you to layout the PdfLightTable as required. The topics that discuss them are:

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Data ]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Layout]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}

 

Ignore Sorting

 

If there is a DataTable assigned as a data source, you may specify whether you need sorted or unsorted data. If this property is set to True, the DataTable sorting will be ignored.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Sorting is disabled, by default. This is because sorted data takes more time.
:::

 

AllowRowBreakAcrossPages

 

This property allows changing the row split behavior across pages. By default, this Boolean property is set to True, which allows splitting the row across pages when the row cannot accommodate within the bounds of the page. If set to false, the entire row will be shifted to the next page.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: If the row height is greater than the page height, it will be forcibly split across pages ignoring this property.
:::

 

[]{#_Data}4.1.2.3.1.2.1      Data

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can initialize the data to the PdfLightTable with the help of the DataSource property. This is achieved through:

[·      ]{style="FONT-FAMILY: Symbol"}External DataSource: By assigning the External data source

[·      ]{style="FONT-FAMILY: Symbol"}Table Direct : By adding columns and rows to the PdfLightTable

[·      ]{style="FONT-FAMILY: Symbol"}Event Handlers : By adding columns and rows by using the event handlers

 

4.1.2.3.1.2.1.1    External DataSource

 

Data source is an object that might be an array (two-dimensional, one-dimensional or nested), a DataTable, DataColumn, DataView or DataSet. To draw an external data source, you must set DataSourceType property to PdfLightTableDataSourceType.External.

The following code example illustrates how to assign external data source to PdfLightTable:

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                          |
|                                                                                                                                                                         |
|                                                                                                                                                                         |
|                                                                                                                                                                         |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.DataSourceType = [PdfLightTableDataSourceType]{style="COLOR: teal"}.External;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.DataSource = dataTable;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                     |
|                                                                                                                                                                        |
|                                                                                                                                                                        |
|                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.DataSourceType = [PdfLightTableDataSourceType]{style="COLOR: teal"}.External]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.DataSource = dataTable]{style="FONT-FAMILY: 'Courier New'"}                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note:  External data source is the default data source.

 
:::

4.1.2.3.1.2.1.2    [Table Direct]{style="FONT-STYLE: normal"}

 

You can directly add rows and columns to PdfLightTable. To achieve this, set DataSourceType property to PdfLightTableDataSourceType .TableDirect. The following code example illustrates this:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
| [PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pdfLightTable = [new]{style="COLOR: blue"} [PdfLightTable]{style="COLOR: teal"}();  ]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                           |
| [         ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
| [// Setting the DataSourceType as Direct]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                           |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.DataSourceType = [PdfLightTableDataSourceType]{style="COLOR: teal"}.TableDirect;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
| [// Creating Columns]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                           |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Columns.Add([new]{style="COLOR: blue"} [PdfColumn]{style="COLOR: teal"}([\"Roll Number\"]{style="COLOR: maroon"}));]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                                                           |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Columns.Add([new]{style="COLOR: blue"} [PdfColumn]{style="COLOR: teal"}([\"Name\"]{style="COLOR: maroon"}));]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                                                                           |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Columns.Add([new]{style="COLOR: blue"} [PdfColumn]{style="COLOR: teal"}([\"Class\"]{style="COLOR: maroon"}));]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
| [// Adding Rows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                           |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Rows.Add([new]{style="COLOR: blue"} [object]{style="COLOR: blue"}\[\] {[\"111\"]{style="COLOR: maroon"},[\"Maxim\"]{style="COLOR: maroon"},[\"III\"]{style="COLOR: maroon"} });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                           |
| [// Drawing the PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                           |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Draw(page, [PointF]{style="COLOR: teal"}.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable[ As]{style="COLOR: blue"} PdfLightTable = [New]{style="COLOR: blue"} PdfLightTable()]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
| [\' Setting the DataSourceType as Direct]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.DataSourceType = PdfLightTableDataSourceType.TableDirect]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
| [\' Creating Columns]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Columns.Add([New]{style="COLOR: blue"} PdfColumn(\"Roll Number\"))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Columns.Add([New]{style="COLOR: blue"} PdfColumn(\"Name\"))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Columns.Add([New]{style="COLOR: blue"} PdfColumn(\"Class\"))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
| [\' Adding Rows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Rows.Add([New]{style="COLOR: blue"} [Object]{style="COLOR: blue"}() {\"[111]{style="COLOR: maroon"}\",\"[Maxim]{style="COLOR: maroon"}\",\"[III]{style="COLOR: maroon"}\" })]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
| [\' Drawing the PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                        |
| [pdfLightTable]{style="FONT-FAMILY: 'Courier New'"}[.Draw(page, PointF.Empty)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

4.1.2.3.1.2.1.2.1   [IEnumerable ]{.Heading9Char}[]{style="COLOR: red"}

[]{style="COLOR: red"} 

PdfLightTable in Silverlight platform can take input from IEnumerable objects.The following is the code snippet:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                        |
| [//Creating PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                        |
| [PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfLightTable = [new]{style="COLOR: blue"} [PdfLightTable]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                        |
| [//Creating IEnumerable source.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                        |
| [Dictionary]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\<[string]{style="COLOR: blue"}, [string]{style="COLOR: blue"}\> dictionary = [new]{style="COLOR: blue"} [Dictionary]{style="COLOR: #2b91af"}\<[string]{style="COLOR: blue"}, [string]{style="COLOR: blue"}\>();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                        |
| [dictionary.Add([\"AAA\"]{style="COLOR: #a31515"}, [\"111\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                        |
| [dictionary.Add([\"BBB\"]{style="COLOR: #a31515"}, [\"112\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                        |
| [dictionary.Add([\"CCC\"]{style="COLOR: #a31515"}, [\"113\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                        |
| [pdfLightTable.DataSource = dictionary;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                        |
| [//Draw.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                        |
| [pdfLightTable.Draw(page, [PointF]{style="COLOR: #2b91af"}.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                   |
| [\'Creating PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLightTable()]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [\'Creating IEnumerable source.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dictionary [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} Dictionary([Of]{style="COLOR: blue"} [String]{style="COLOR: blue"}, [String]{style="COLOR: blue"})()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                   |
| [dictionary]{style="FONT-FAMILY: 'Courier New'"}[.Add([\"AAA\"]{style="COLOR: darkred"}, [\"111\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                                   |
| [dictionary]{style="FONT-FAMILY: 'Courier New'"}[.Add([\"BBB\"]{style="COLOR: darkred"}, [\"112\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                                   |
| [dictionary]{style="FONT-FAMILY: 'Courier New'"}[.Add([\"CCC\"]{style="COLOR: darkred"}, [\"113\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [pdfLightTable.DataSource = dictionary]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [\'Drawing the PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                                   |
| [pdfLightTable.Draw(page, PointF.Empty)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

4.1.2.3.1.2.1.3    Event Handlers

 

Data to PdfLightTable can also be set using the following three events:

[·      ]{style="FONT-FAMILY: Symbol"}QueryColumnCount -- Sets the number of columns.

[·      ]{style="FONT-FAMILY: Symbol"}QueryRowCount -- Sets the number of rows.

[·      ]{style="FONT-FAMILY: Symbol"}QueryNextRow -- Sets data to the PdfLightTable.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: These events will act only when the DataSource property is not set.
:::

 

The following code snippet illustrates this:

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                               |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"}\[\]\[\] datastring = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[2\]\[\];]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Giving it some column arrays]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                                               |
| [datastring\[0\] = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\] { [\"111\"]{style="COLOR: #a31515"}, [\"Maxim\"]{style="COLOR: #a31515"}, [\"100\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                                               |
| [datastring\[1\] = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\] { [\"222\"]{style="COLOR: #a31515"}, [\"Calvin\"]{style="COLOR: #a31515"}, [\"95\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Creating PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                               |
| [PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pdfLightTable = [new]{style="COLOR: blue"} [PdfLightTable]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [pdfLightTable.QueryColumnCount += [new]{style="COLOR: blue"} [QueryColumnCountEventHandler]{style="COLOR: #2b91af"}(pdfLightTable_QueryColumnCount);]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                               |
| [pdfLightTable.QueryNextRow += [new]{style="COLOR: blue"} [QueryNextRowEventHandler]{style="COLOR: #2b91af"}(pdfLightTable_QueryNextRow);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                               |
| [pdfLightTable.QueryRowCount += [new]{style="COLOR: blue"} [QueryRowCountEventHandler]{style="COLOR: #2b91af"}(pdfLightTable_QueryRowCount);]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Drawing the PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                               |
| [pdfLightTable.Draw(page, [PointF]{style="COLOR: #2b91af"}.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Getting the number of columns]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable_QueryColumnCount([object]{style="COLOR: blue"} sender, [QueryColumnCountEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| [    args.ColumnCount = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Getting the number of rows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                                               |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable_QueryRowCount([object]{style="COLOR: blue"} sender, [QueryRowCountEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| [    args.RowCount = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [// Getting the row data]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                               |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable_QueryNextRow([object]{style="COLOR: blue"} sender, [QueryNextRowEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                               |
| [    [if]{style="COLOR: blue"} (args.RowIndex \< datastring.Length)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                               |
| [        args.RowData = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\] { datastring\[args.RowIndex\]\[0\],           datastring\[args.RowIndex\]\[1\], datastring\[args.RowIndex\]\[2\] };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ datastring(1)() [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' Giving it some column arrays]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ datastring(0) = [New]{style="COLOR: blue"} [String]{style="COLOR: blue"}() { [\"111\"]{style="COLOR: darkred"}, [\"Maxim\"]{style="COLOR: darkred"}, [\"100\"]{style="COLOR: darkred"} }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ datastring(1) = [New]{style="COLOR: blue"} [String]{style="COLOR: blue"}() { [\"222\"]{style="COLOR: darkred"}, [\"Calvin\"]{style="COLOR: darkred"}, [\"95\"]{style="COLOR: darkred"} }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' Creating PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLightTable()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [pdfLightTable.QueryColumnCount += [New]{style="COLOR: blue"} QueryColumnCountEventHandler([AddressOf]{style="COLOR: blue"} pdfLightTable_QueryColumnCount)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [pdfLightTable.QueryNextRow += [New]{style="COLOR: blue"} QueryNextRowEventHandler([AddressOf]{style="COLOR: blue"} pdfLightTable_QueryNextRow)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [pdfLightTable.QueryRowCount += [New]{style="COLOR: blue"} QueryRowCountEventHandler([AddressOf]{style="COLOR: blue"} pdfLightTable_QueryRowCount)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' Drawing the PdfLightTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [pdfLightTable.Draw(page, PointF.Empty)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' Getting the number of columns]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[Sub ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[pdfLightTable_QueryColumnCount([Object]{style="COLOR: blue"} sender, QueryColumnCountEventArgs args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [      args.ColumnCount = 3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[Sub]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' Getting the number of rows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[Sub ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[pdfLightTable_QueryRowCount([Object]{style="COLOR: blue"} sender, QueryRowCountEventArgs args)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [      args.RowCount = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[Sub]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' Getting row data]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[Sub]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[ pdfLightTable_QueryNextRow([Object]{style="COLOR: blue"} sender, QueryNextRowEventArgs args)]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [      [If]{style="COLOR: blue"} args.RowIndex \< datastring.Length [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [            args.RowData = [New]{style="COLOR: blue"} [String]{style="COLOR: blue"}() { datastring(args.RowIndex)(0), datastring(args.RowIndex)(1), datastring(args.RowIndex)(2) }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [      [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[Sub]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#_Table_Layout}4.1.2.3.1.2.2      Layout

 

PdfLightTableLayoutFormat

 

Layouting PdfLightTable can be done using the PdfLightTableLayoutFormat class. Overloads accepting pages can accept standard formats as other layouting elements. However, they treat the PdfLayoutBreakType.FitElement value of Format.Break property as one, for a single row and not for the entire PdfLightTable.

 

 Properties

 

::: {align="center"}
  ------------------ -------------------------------------------------------------- --------------------
  Name               Description                                                    Data Type
  Break              Gets or sets the break type                                    PdfLayoutBreakType
  EndColumnIndex     Gets or sets the end column index                              Integer
  Layout             Gets or sets the layout type                                   PdfLayoutType
  PaginateBounds     Gets or sets the PdfLightTable bounds for the following page   RectangleF
  StartColumnIndex   Gets or sets the start column index                            Integer
  ------------------ -------------------------------------------------------------- --------------------
:::

 

Also, you may select a range of column using the PdfLightTableLayoutFormat properties, StartColumnIndex and EndColumnIndex. You should pass an instance of this class to one of the Draw overloads, instead of the PdfLayoutFormat class instance.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                             |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [PdfLightTableLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfLightTableLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| [format.StartColumnIndex = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                            |
| [format.EndColumnIndex = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [// Draws the PdfLightTable from the first to the fourth column]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                                                            |
| [pdfLightTable.Draw(page, [PointF]{style="COLOR: teal"}.Empty, format);]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} [PdfLightTableLayoutFormat]{style="COLOR: teal"} = [New]{style="COLOR: blue"} [PdfLightTableLayoutFormat]{style="COLOR: teal"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                |
| [format.StartColumnIndex = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                |
| [format.EndColumnIndex = 3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [\'Drawing the PdfLightTable from the first to the fourth column]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                |
| [pdfLightTable.Draw(page, PointF.Empty, format)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The PdfLayoutType class is used to specify the type of pagination. The Paginate LayoutType draws the PdfLightTable on the (immediate) following pages, if the element exceeds the page. The OnePage layout draws the element only on one page. The following code example illustrates this:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                             |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [PdfLightTableLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfLightTableLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| [format.Layout = [PdfLayoutType]{style="COLOR: teal"}.Paginate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                            |
| [format.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitElement;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                            |
| [format.StartColumnIndex = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                            |
| [format.EndColumnIndex = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
| [// Drawing the PdfLightTable with the layout format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                                            |
| [pdfLightTable.Draw(page, [PointF]{style="COLOR: teal"}.Empty, format);]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                               |
|                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} PdfLightTableLayoutFormat = [New]{style="COLOR: blue"} PdfLightTableLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| [format.Layout = PdfLayoutType.Paginate]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                  |
| [format.Break = PdfLayoutBreakType.FitElement]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                  |
| [format.StartColumnIndex = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                  |
| [format.EndColumnIndex = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                  |
| [\' Drawing the PdfLightTable with the layout format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                                                                                  |
| [pdfLightTable.Draw(page, PointF.Empty, format)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

PdfLightTableLayoutResult

 

You can get the layout settings for the drawn PdfLightTable with the help of PdfLightTableLayoutResult class. Also, you can get the bounds and the last page where the PdfLightTable is drawn using the Bounds and Page properties. This is mainly used to write some text or any other element below the large table that shows the number of pages.

 

Properties

 

::: {align="center"}
  -------------- ----------------------------------------------------- ------------
  Name           Description                                           Data Type
  Bounds         Gets the bounds in the last page where it was drawn   RectangleF
  LastRowIndex   Gets the index of the last row                        Integer
  Page           Gets the last page where PdfLightTable was drawn      PdfPage
  -------------- ----------------------------------------------------- ------------
:::

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                     |
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [// Drawing the PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                    |
| [PdfLightTableLayoutResult]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ result = pdfLightTable.Draw(page, [PointF]{style="COLOR: teal"}.Empty, format);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [// Returning the rectangle value for the last page.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                            |
|                                                                                                                                                                                                    |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.WriteLine(result.Bounds.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                          |
|                                                                                                                                                                                                          |
|                                                                                                                                                                                                          |
| [\' Drawing the PdfLightTable.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} PdfLightTableLayoutResult = pdfLightTable.Draw(page, PointF.Empty, format)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                          |
|                                                                                                                                                                                                          |
|                                                                                                                                                                                                          |
| [\' Returning the rectangle value for the last page.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                          |
| [Console.WriteLine(result.Bounds.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

###### []{#_PDFLightTable_Formatting}4.1.2.3.1.3 PdfLightTable Formatting {#pdflighttable-formatting style="tab-stops: 0pt"}

This section talks about the most direct and indirect formatting options (through events) that are possible with PdfLightTable. The PdfLightTableStyle class, accessed through Style property of PdfLightTable instance has a number of properties that allow formatting the entire PdfLightTable or parts of it. Border and few other properties are discussed below. Header, Cell, Row and Column are discussed in the following links:

[·      ]{style="FONT-FAMILY: Symbol"}Header

[·      ]{style="FONT-FAMILY: Symbol"}Row

[·      ]{style="FONT-FAMILY: Symbol"}Column

[·      ]{style="FONT-FAMILY: Symbol"}Cell

 

Border

 

Border for the entire PdfLightTable can be set using the BorderPen property. Also, border styles applied to individual cells might override this value. You can specify the [PdfPen](ms-xhelp:///?Id=455c65fb-c88c-4109-9207-b7e2de24ad33) to be used to draw border with any color.

+-------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                              |
|                                                                                                             |
|                                                                                                             |
|                                                                                                             |
| [pdfLightTable.Style.BorderPen = [PdfPens]{style="COLOR: teal"}.Khaki;]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                  |
|                                                                                     |
|                                                                                     |
|                                                                                     |
| [pdfLightTable.Style.BorderPen = PdfPens.Khaki]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------+

 

BorderOverlapStyle

 

This property decides whether the cell border overlaps with neighboring cells or if it should be drawn inside cell.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: This property applies for all cells in the PdfLightTable. You need to be careful when using overlapping borders, because they may produce bad results if they are not of the same width and color.

 
:::

+--------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                       |
|                                                                                                                                      |
|                                                                                                                                      |
|                                                                                                                                      |
| [pdfLightTable.Style.BorderOverlapStyle = [PdfBorderOverlapStyle]{style="COLOR: teal"}.Overlap;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+--------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                           |
|                                                                                                              |
|                                                                                                              |
|                                                                                                              |
| [pdfLightTable.Style.BorderOverlapStyle = PdfBorderOverlapStyle.Overlap]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------+

 

Padding and Spacing

 

You can also specify the cell spacing (distance between cells) and cell padding (distance between cell text and border) for all cells.

 

+-----------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                      |
|                                                                                                     |
|                                                                                                     |
|                                                                                                     |
| [pdfLightTable[.Style.CellPadding = 4;]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                     |
| [pdfLightTable[.Style.CellSpacing = 10;]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                 |
|                                                                                                    |
|                                                                                                    |
|                                                                                                    |
| [pdfLightTable[.Style.CellPadding = 4]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                    |
| [pdfLightTable[.Style.CellSpacing = 10]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------+

 

[]{#_Header_1}4.1.2.3.1.3.1      Header

 

Header is a set of rows that repeat on each page and has its own style. Rows for the header might be taken either from column captions or from ordinary rows. In the latter case, the rows are treated as headers and do not appear in the body of the PdfLightTable.

+---------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                  |
|                                                                                                                                 |
|                                                                                                                                 |
|                                                                                                                                 |
| [// Header from column captions]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                              |
|                                                                                                                                 |
| [pdfLightTable.Style.ShowHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                 |
| [pdfLightTable.Style.HeaderSource = [PdfHeaderSource]{style="COLOR: teal"}.ColumnCaptions;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                 |
| [pdfLightTable.Style.RepeateHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                 |
| [pdfLightTable.Style.HeaderStyle = headerStyle;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                 |
|                                                                                                                                 |
|                                                                                                                                 |
| [// Header from rows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                         |
|                                                                                                                                 |
| [pdfLightTable.Style.ShowHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                 |
| [pdfLightTable.Style.HeaderSource = [PdfHeaderSource]{style="COLOR: teal"}.Rows;]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                 |
| [pdfLightTable.Style.RepeatHeader = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                 |
| [pdfLightTable.Style.HeaderRowCount = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                 |
| [pdfLightTable.Style.HeaderStyle = headerStyle;]{style="FONT-FAMILY: 'Courier New'"}                                            |
+---------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                      |
|                                                                                                         |
|                                                                                                         |
|                                                                                                         |
| [\' Header from column captions]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                      |
|                                                                                                         |
| [pdfLightTable.Style.ShowHeader = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                         |
| [pdfLightTable.Style.HeaderSource = PdfHeaderSource.ColumnCaptions]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                         |
| [pdfLightTable.Style.RepeatHeader = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                         |
| [pdfLightTable.Style.HeaderStyle = headerStyle]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                         |
|                                                                                                         |
|                                                                                                         |
| [\' Header from rows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                 |
|                                                                                                         |
| [pdfLightTable.Style.ShowHeader = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                         |
| [pdfLightTable.Style.HeaderSource = PdfHeaderSource.Rows]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                         |
| [pdfLightTable.Style.RepeatHeader = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                         |
| [pdfLightTable.Style.HeaderRowCount = 3]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                         |
| [pdfLightTable.Style.HeaderStyle = headerStyle]{style="FONT-FAMILY: 'Courier New'"}                     |
+---------------------------------------------------------------------------------------------------------+

 

The headerStyle is an instance of [PdfCellStyle]() that can be set to header row.

 

4.1.2.3.1.3.2      Row

 

The values of existing row, entered with DataSourceType as PdfLightTableDataSourceType.TableDirect can be edited using the Values property. The following is the code:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                   |
| [pdfLightTable.Rows\[1\].Values = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\] { [\"333\"]{style="COLOR: #a31515"}, [\"John\"]{style="COLOR: #a31515"}, [\"234\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                              |
| [pdfLightTable.Rows(1).Values = [New]{style="COLOR: blue"} [String]{style="COLOR: blue"}() { [\"333\"]{style="COLOR: darkred"}, [\"John\"]{style="COLOR: darkred"}, [\"234\"]{style="COLOR: darkred"} }]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The minimum height of a row in PdfLightTable can be set using [BeginRowLayout]() and [EndRowLayout]() events.

 

[]{#_Column_1}4.1.2.3.1.3.3      Column

 

::: {align="center"}
  -------------- ----------------------------------------------- -----------------
  Name           Description                                     Data Type
  ColumnName     Gets or sets the column name                    String
  StringFormat   Gets of sets the string format for the column   PdfStringFormat
  Width          Gets of sets the width of the column            float
  -------------- ----------------------------------------------- -----------------
:::

 

ColumnName

 

By default, PdfLightTable displays the column text as the DataSource column name. You can change the column text with the help of the ColumnName property. The following code snippet illustrates this:

 

+--------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                           |
|                                                                                                                          |
|                                                                                                                          |
|                                                                                                                          |
| [// Specifying Column name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                          |
| [pdfLightTable.Columns\[2\].ColumnName = [\"Student Name\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                           |
|                                                                                              |
|                                                                                              |
|                                                                                              |
| [\' Specifying Column name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                |
|                                                                                              |
| [pdfLightTable.Columns(2).ColumnName = \"Student Name\"]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------+

 

StringFormat

 

The format of the data for a single column can be changed using the StringFormat property.Check String Formatting in [DrawingText](ms-xhelp:///?Id=942935a6-44ea-42da-abb5-dc0e88f91997)  for more details.

 

Width

 

By default, all the columns in a PdfLightTable have equal width, and the columns automatically fill the entire width of the PdfLightTable. If the width of any of the column(s) is increased or decreased, the width of other columns changes appropriately.

To customize initial column widths, you can invoke the Width property for each column of the PdfLightTable. The following code snippet illustrates this:

 

+---------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                        |
|                                                                                       |
|                                                                                       |
|                                                                                       |
| [// Setting width for third column]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                       |
| [pdfLightTable.Columns\[2\].Width = 10;]{style="FONT-FAMILY: 'Courier New'"}          |
+---------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                    |
|                                                                                       |
|                                                                                       |
|                                                                                       |
| [\' Setting width for third column]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                       |
| [pdfLightTable.Columns(2).Width = 10]{style="FONT-FAMILY: 'Courier New'"}             |
+---------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: The unit of the Width property is always points. You can set the PDF units only as points. Also, you can use the [[PdfUnitConvertor]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 9pt"}](ms-xhelp:///?Id=7c49f7ec-c075-4124-bbe7-e86233755f5f) class to convert the other units to points.
:::

 

Column Span

You can set column span in PdfLightTable using BeginRowLayout event. Check the following link for more details.

[How To Implement Column Span In PdfLightTable?](ms-xhelp:///?Id=1f251964-7e42-4f16-ba2d-2d7b6533048e) []{style="COLOR: red"}

[]{style="COLOR: red"} 

[]{#_Cell_1}[4.1.2.3.1.3.4      Cell]{.Heading7Char}

 

You can specify the default cell style by using the DefaultStyle property. The style for the header cells is set by using the HeaderStyle property.

Also, you can specify an alternate style by using the AlternateStyle property. This property is used to customize the appearance of the odd row cells.

 

Properties

 

::: {align="center"}
  ----------------- ----------------------------------------------------------------- -----------------
  Name              Description                                                       Data Type
  BackgroundBrush   Gets or sets the brush with which, the background will be drawn   PdfBrush
  Border            Gets or sets the pen with which, the border will be drawn         PdfPen
  Font              Gets or sets the font                                             PdfFont
  StringFormat      Gets or sets the string format of the text                        PdfStringFormat
  TextBrush         Gets or sets the brush, which will be used to draw font           PdfBrush
  TextPen           Gets or sets the pen, which will be used to draw text outlines    PdfPen
  ----------------- ----------------------------------------------------------------- -----------------
:::

 

The Style property enables you to specify the font along with its appearance (brush, pen and string format), and border along with the background of cells. Although there are fixed properties for styles, you can specify different styles using [BeginCellLayout]() and [EndCellLayou]()t events.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [PdfCellStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ altStyle = [new]{style="COLOR: blue"} [PdfCellStyle]{style="COLOR: teal"}(font, [PdfBrushes]{style="COLOR: teal"}.White, [PdfPens]{style="COLOR: teal"}.Green);]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                          |
| [altStyle.BackgroundBrush = [PdfBrushes]{style="COLOR: teal"}.DarkGray;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [PdfCellStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ headerStyle = [new]{style="COLOR: blue"} [PdfCellStyle]{style="COLOR: teal"}(font, [PdfBrushes]{style="COLOR: teal"}.White, [PdfPens]{style="COLOR: teal"}.Brown);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                          |
| [headerStyle.BackgroundBrush = [PdfBrushes]{style="COLOR: teal"}.Red;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [pdfLightTable.Style.AlternateStyle = altStyle;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                          |
| [pdfLightTable.Style.HeaderStyle = headerStyle;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ altStyle [As]{style="COLOR: blue"} Syncfusion.Pdf.Tables.PdfCellStyle = [New]{style="COLOR: blue"}Syncfusion.Pdf.Tables.PdfCellStyle(Font, PdfBrushes.White, PdfPens.Green)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                             |
| [altStyle.BackgroundBrush = PdfBrushes.DarkGray]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ headerStyle [As]{style="COLOR: blue"} Syncfusion.Pdf.Tables.PdfCellStyle = [New]{style="COLOR: blue"}Syncfusion.Pdf.Tables.PdfCellStyle(Font, PdfBrushes.White, PdfPens.Brown)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                             |
| [headerStyle.BackgroundBrush = PdfBrushes.Red]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                             |
| [pdfLightTable.Style.AlternateStyle = altStyle]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                             |
| [pdfLightTable.Style.HeaderStyle = headerStyle]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

###### []{#_PDFLightTable_Customization}4.1.2.3.1.4 PdfLightTable Customization {#pdflighttable-customization style="tab-stops: 0pt"}

 

PdfLightTable offers a set of events that help to change the look and feel in the PDF. The following are the list of events and links that discuss them:

 

[]{#_BeginPageLayout}4.1.2.3.1.4.1      BeginPageLayout

 

This event is raised before layout starts on a page. The arguments of this event are as follows.

[·      ]{style="FONT-FAMILY: Symbol"}Page (read-only): Page on which layout should be performed

[·      ]{style="FONT-FAMILY: Symbol"}Bounds: Size of the PdfLightTable part, which should be laid out on the page

[·      ]{style="FONT-FAMILY: Symbol"}Cancel: Enables to cancel layout

 

[]{#_EndPageLayout_(sub_section}[]{#_EndPageLayout}4.1.2.3.1.4.2      EndPageLayout

 

This event is raised when layout on a page finishes. The arguments of this event are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}Result (read-only): Layout result for the current page

[·      ]{style="FONT-FAMILY: Symbol"}NextPage: Page on which layout should continue

 

[]{#_BeginRowLayout_(sub_section}[]{#_BeginRowLayout}[4.1.2.3.1.4.3      BeginRowLayout ]{.Heading8Char}

 

This event is raised when row layout starts. The arguments of this event are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}RowIndex (read-only): Index of the row (zero based)

[·      ]{style="FONT-FAMILY: Symbol"}[CellStyle]() : Style of the cells within the row

[·      ]{style="FONT-FAMILY: Symbol"}[ColumnSpanMap]() : Array of integers specifying column span

[·      ]{style="FONT-FAMILY: Symbol"}Cancel: Enables to cancel layout

[·      ]{style="FONT-FAMILY: Symbol"}IgnoreColumnFormat: Gets or sets a value indicating whether column string format should be ignored.

[·      ]{style="FONT-FAMILY: Symbol"}Skip: Enables to skip the entire row

[·      ]{style="FONT-FAMILY: Symbol"}MinimalHeight: Enables to specify the minimal row height, which is used to preserve space for images

 

The following code example illustrates how to set the row height.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                       |
| [//Subscribing the event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                                       |
| [pdfLightTable.BeginRowLayout += [new]{style="COLOR: blue"} [BeginRowLayoutEventHandler]{style="COLOR: teal"}(pdfLightTable_BeginRowLayout);]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                       |
| [//Setting row height for the second row]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                                       |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable_BeginRowLayout([object]{style="COLOR: blue"} sender, [BeginRowLayoutEventArgs]{style="COLOR: teal"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                       |
| [  [if]{style="COLOR: blue"} (args.RowIndex == 1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                       |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                       |
| [     args.MinimalHeight = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                       |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                           |
| [\'Subscribing the event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable.BeginRowLayout += [New]{style="COLOR: blue"}BeginRowLayoutEventHandler(pdfLightTable_BeginRowLayout)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                           |
| [\'Setting rowheight for the second row]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} pdfLightTable_BeginRowLayout([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} args [As]{style="COLOR: blue"}BeginRowLayoutEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                           |
| [  [If]{style="COLOR: blue"} args.RowIndex = 1 [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                           |
| [       args.MinimalHeight = 25]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                           |
| [  [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#_EndRowLayout}4.1.2.3.1.4.4      EndRowLayout

 

This event is raised when row layout finishes. The arguments of this event are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}RowIndex (read-only): Index of the row (zero based)

[·      ]{style="FONT-FAMILY: Symbol"}Cancel: Enables to cancel layout

[·      ]{style="FONT-FAMILY: Symbol"}LayoutCompleted (read-only):  Gets a value indicating whether the row was drawn completely.

[·      ]{style="FONT-FAMILY: Symbol"}Bounds (read-only): Bounds of the row on the page

 

[]{#_BeginCellLayout}4.1.2.3.1.4.5      BeginCellLayout

 

This event is raised when cell layout starts. The arguments of this event are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}RowIndex (read-only): Index of the current row

[·      ]{style="FONT-FAMILY: Symbol"}CellIndex (read-only): Index of the current cell within the row

[·      ]{style="FONT-FAMILY: Symbol"}Value (read-only): Text value of the cell

[·      ]{style="FONT-FAMILY: Symbol"}Bounds (read-only): Bounds of the cell

[·      ]{style="FONT-FAMILY: Symbol"}[Graphics](ms-xhelp:///?Id=7b280c30-c027-487a-8667-d06eb360eade) : Graphics on which the cell should be drawn

[·      ]{style="FONT-FAMILY: Symbol"}Skip: Indicates if the cell should be skipped

 

The following code example illustrates how to draw the graphics elements inside the cell.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                     |
|                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                    |
| [ [//Subscribing the event]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                    |
| [pdfLightTable.BeginCellLayout += [new ]{style="COLOR: blue"}[BeginCellLayoutEventHandler]{style="COLOR: teal"}(pdfLightTable_BeginCellLayout);]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                    |
| [// Drawing ellipse inside the cell]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                             |
|                                                                                                                                                                                                                    |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable_BeginCellLayout([object]{style="COLOR: blue"} sender, [BeginCellLayoutEventArgs]{style="COLOR: teal"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                    |
| [args)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [  [if]{style="COLOR: blue"} (args.RowIndex == 0 && args.CellIndex == 2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                    |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                    |
| [      args.Graphics.DrawEllipse([PdfBrushes]{style="COLOR: teal"}.Red, args.Bounds);]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                    |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                              |
| [\'Subscribing the event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                              |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfLightTable.BeginCellLayout += [New ]{style="COLOR: blue"}BeginCellLayoutEventHandler(pdfLightTable_BeginCellLayout)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                              |
| [\' Drawing ellipse inside the cell]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                              |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} pdfLightTable_BeginCellLayout([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} args [As ]{style="COLOR: blue"}BeginCellLayoutEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                              |
| [  [If]{style="COLOR: blue"} args.RowIndex = 0 [AndAlso]{style="COLOR: blue"} args.CellIndex = 2 [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                              |
| [     args.Graphics.DrawEllipse(PdfBrushes.Red, args.Bounds)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                              |
| [  [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                              |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#_EndCellLayout}4.1.2.3.1.4.6      EndCellLayout

 

This event is raised when cell layout finishes. The arguments of this event are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}RowIndex (read-only): Index of the current row

[·      ]{style="FONT-FAMILY: Symbol"}CellIndex (read-only): Index of the current cell within the row

[·      ]{style="FONT-FAMILY: Symbol"}Value (read-only): Text value of the cell

[·      ]{style="FONT-FAMILY: Symbol"}Bounds (read-only): Bounds of the cell

[·      ]{style="FONT-FAMILY: Symbol"}[Graphics](ms-xhelp:///?Id=7b280c30-c027-487a-8667-d06eb360eade): Graphics on which the cell should be drawn

 

[]{#related-topics}
:::::::::::::::::
