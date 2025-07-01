::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Reducing size of Excel 2007 & Excel 2010 files {#reducing-size-of-excel-2007-excel-2010-files style="tab-stops: 0pt"}

 

The default compression technique, using which Essential XlsIO compresses files uses .NET compression. A new compression technique has been implemented that will considerably reduce the size of the compressed XLSX files.

 

**Use Case Scenarios**

The reduced size of the compressed file will result in reduced data transfer between applications.

 

**How Compression level can be set**

The Compression level can be set at IApplication interface. This will set the level for all the workbooks created using the same instance of Excel Engine.

[]{style="COLOR: #c00000"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                    |
|                                                                                                                                                                                                                                     |
| [ExcelEngine]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ excelEngine = [new]{style="COLOR: blue"} [ExcelEngine]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                                                                                                     |
| [IApplication]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ application = excelEngine.Excel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                     |
| [application.DefaultVersion = [ExcelVersion]{style="COLOR: #2b91af"}.Excel2007; [// or ExcelVersion = ExcelVersion.Excel2010;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                                     |
| [application.CompressionLevel = Syncfusion.Compression.[CompressionLevel]{style="COLOR: #2b91af"}.Best;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                     |
| [workbook.SaveAs(fileName);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                     |
| [workbook.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                     |
| [excelEngine.Dispose();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #c00000"}                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ excelEngine [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [ExcelEngine]{style="COLOR: black"}()]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ application [As]{style="COLOR: blue"} [IApplication ]{style="COLOR: black"}[= excelEngine.Excel]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                     |
| [application.DefaultVersion = ExcelVersion]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[.Excel2007 [\' or ExcelVersion = ExcelVersion.Excel2010]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                     |
| [application.CompressionLevel = Syncfusion.Compression.[CompressionLevel]{style="COLOR: black"}.Best]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [workbook.SaveAs(fileName)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                     |
| [workbook.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [excelEngine.Dispose()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #c00000"}                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Following are the list of enumerations available:

 

::: {align="center"}
  Enum            Description
  --------------- ------------------------------------------------------------------
  NoCompression   File will not be compressed.
  BestSpeed       Fast compression with more size than normal compression.
  BelowNormal     Compression speed and size will be between Normal and BestSpeed.
  Normal          Both size and speed will be Normal.
  AboveNormal     Takes more time to compress, with reduced file size.
  Best            Slow compression, file size reduced to the best level.
:::

 

[]{#p28}**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}** 

[]{#related-topics}
::::
