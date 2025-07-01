::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Exporting Grid Grouping Control To Excel {#exporting-grid-grouping-control-to-excel style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **GroupingGridExcelConverter** class provides support for exporting data from a Grouping Grid control into an Excel spreadsheet for verification and/or computation. This control automatically copies the Grid\'s styles, formats, groups, summary rows and expression fields to Excel. The **GroupingGridExcelConverter** control is derived from the **GridExcelConverterBase**. The XlsIO libraries support the conversion of Grid content to Excel.

 

To make use of the GroupingGridExcelConverter class, the following assemblies must be added along with the default assemblies present in the **References** folder of your application: **Syncfusion.XlsIO.Base** and **Syncfusion.GridConverter.Windows**.

 

The content of the Grid Grouping control can be transferred to Excel by using the **GroupingGridToExcel** method in the **GroupingGridExcelConverterControl** class. There are two export options provided by the Grid Grouping control: first option converts the entire content in the grid to Excel, and the second option converts only the visible content in the grid to Excel.

 

The following code example illustrates how to convert the entire Grid content to Excel.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                     |
| [Syncfusion.GroupingGridExcelConverter.[GroupingGridExcelConverterControl]{style="COLOR: #2b91af"} converter = [new]{style="COLOR: blue"} Syncfusion.GroupingGridExcelConverter.[GroupingGridExcelConverterControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                     |
| [converter.GroupingGridToExcel([this]{style="COLOR: blue"}.gridGroupingControl1, [@\"C:\\MyGGC.xls\"]{style="COLOR: #a31515"}, Syncfusion.GridExcelConverter.[ConverterOptions]{style="COLOR: #2b91af"}.Default); ]{style="FONT-FAMILY: 'Courier New'"}                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ converter [As]{style="COLOR: blue"} Syncfusion.GroupingGridExcelConverter.GroupingGridExcelConverterControl = [New]{style="COLOR: blue"} Syncfusion.GroupingGridExcelConverter.GroupingGridExcelConverterControl()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                 |
| [converter.GroupingGridToExcel([Me]{style="COLOR: blue"}.gridGroupingControl1, [\"C:\\MyGGC.xls\"]{style="COLOR: #a31515"}, Syncfusion.GridExcelConverter.ConverterOptions.Default);]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can export the visible, or expanded records or groups alone by using the following code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                         |
| [converter.GroupingGridToExcel([this]{style="COLOR: blue"}.gridGroupingControl1, [@\"C:\\MyGGC.xls\"]{style="COLOR: #a31515"}, Syncfusion.GridExcelConverter.[ConverterOptions]{style="COLOR: #2b91af"}.Visible); ]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                 |
|                                                                                                                                                                                                      |
| [converter.GroupingGridToExcel(this.gridGroupingControl1, [\"C:\\MyGGC.xls\"]{style="COLOR: #a31515"}, Syncfusion.GridExcelConverter.ConverterOptions.Visible);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p33} 

 

[]{#related-topics}
:::
