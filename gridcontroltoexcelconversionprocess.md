::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### GridControl to Excel Conversion Process {#gridcontrol-to-excel-conversion-process style="tab-stops: 0pt"}

The conversion of Grid to Excel is done cell by cell. Each cell is converted with respect to its style, including its format and background color. This is done by using the **GridCellToExcel()** method of the **GridExcelConverterControl** class.

###### 3.1.6.1.1.1 Currency Cell Conversion {#currency-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.1.1      If format specified

The cell is checked whether it is a Currency cell type by using the CellType property. If it is a Currency Cell type then the CellValue will be converted into Double and saved in Range's Number property. NumberFormatInformation is extracted from the NumberFormatInfoObject and the number is converted to string by using the extracted format. FormatString is created and saved in Range's NumberFormat property.

The following is a sample code to set the format of the Currency cell:

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl1\[row,col\].Format = [\"C\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                           |
|                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl1(row,col).Format = [\"C\"]{style="COLOR: darkred"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.1.6.1.1.1.2      If format not specified

The cell is checked whether it is a Currency cell type by using the CellType property. If the CellType is not given then it switches to the default CellType and the CellValue is stored in Range's "Value2" property, where the value2 is converted into the given CellValueType(Except Date Time and Currency). Hence, in this case the CellValue will be converted to General format.

###### 3.1.6.1.1.2 Number Cell Conversion {#number-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.2.1      If format specified

The cell is checked whether it is a Number cell type by using the CellType property. If it is a Number Cell type then the cell value is assigned to Range's Value2 property. Since the format is specified, the Value2's value is converted to its respective type and set to Number format.

The following is a sample code to set the format of Currency cell:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl1\[row,col\].Format = [\"N\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                           |
|                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl1(row,col).Format = [\"N\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.1.6.1.1.2.2      If format not specified

The cell is checked whether it is a Number cell type by using the CellType property. If it is not a Number Cell type, then the format is skipped for all cell types and finally the CellValue is assigned to Range's Value2 property. Since the format is not specified, the Value2 value is converted to its respective type and set to General Format.

###### 3.1.6.1.1.3 Image Cell Conversion {#image-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.3.1      If CellType specified

The cell is checked whether it is an Image cell type by using the CellType property. If it is an Image Cell type then the CellValue is converted to a bitmap and this bitmap is inserted into the sheet specifying the row and column.

3.1.6.1.1.3.2      If CellType not specified

Not Applicable

###### 3.1.6.1.1.4 ComboBox and RichText Cell Conversion {#combobox-and-richtext-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.4.1      If CellType specified

The cell is checked whether it is a ComboBox or RichText cell type by using the CellType property. If it is a ComboBox or RichText cell type then the FormattedText is stored in the Range's Text property.

3.1.6.1.1.4.2      If CellType not specified

Not Applicable

###### 3.1.6.1.1.5 ProgressBar Cell Conversion {#progressbar-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.5.1      If CellType specified

The cell is checked whether it is a ProgressBar cell type using CellType property. If it is a ProgressBar cell type then the ProgressBar text style is checked whether it should be in percentage style. If the style is in percentage  then the percentage value is calculated and saved to Range's Number property. The Range's NumberFormat is saved as "0%". If there is no style specified, the ProgressValue is directly saved to Range's Number.

3.1.6.1.1.5.2      If CellType not specified

Not Applicable

###### 3.1.6.1.1.6 DateTime Cell Conversion {#datetime-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.6.1      If format specified

The cell is checked whether it is a DateTime cell type using the CellType property. If it is a DateTime cell type, the format is skipped for all cell types and finally the CellValue is assigned to Range's DateTime property. Since the format is specified, the DateTime value is converted to DateTime type and the format is set to the DateTime format in Range's Format.

3.1.6.1.1.6.2      If format not specified

The cell is checked whether it is a DateTime cell type using the CellType property. If it is not a DateTime cell type, the format is skipped for all cell types and finally the CellValue is assigned to Range's DateTime property. Since the format is not specified, the DateTime value is converted to DateTime type and set to General Format.

###### 3.1.6.1.1.7 Formula Cell Conversion {#formula-cell-conversion style="tab-stops: 0pt"}

3.1.6.1.1.7.1      If Format specified

The cell is checked whether it is a Formula cell type using the CellType property. If it is a Formula cell type then the GridCell's Text string is stored to Range's Formula property. The values in Excel cells can be formatted by specifying the format in Formula cell types.

3.1.6.1.1.7.2      If Format not specified

If no formula is specified for the cell then the formula is set to Excel sheet's range Formula property with its default format.

 

[]{#related-topics}
:::
