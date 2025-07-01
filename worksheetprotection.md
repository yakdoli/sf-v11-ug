::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Worksheet Protection {#worksheet-protection style="tab-stops: 0pt"}

**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}** 

When you share an Excel file, so that others can collaborate on the data, you can prevent any user from making changes to specific worksheet or workbook elements, by protecting certain parts of the file.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Excel allows to protect a worksheet, and provides an option to specify the elements, users will be allowed to change, when you protect a worksheet. You can do this, by opening the **Tools** menu, and then clicking **Protection** option.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

WorkSheet Protection XlsIO

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

XlsIO provides support for protecting and unprotecting elements in worksheets by using the **Protect** method of **IWorksheet**. By**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}**[u]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}sing the **ExcelSheetProtection** enumerator, you can set the elements that need protection.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Following code example illustrates how to protect a worksheet with a password. It also restricts formatting columns in the worksheet.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                 |
|                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                  |
| [// Protecting the Worksheet by using a Password.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                             |
|                                                                                                                                                                  |
| [sheet.Protect([\"syncfusion\"]{style="COLOR: #a31515"}, [ExcelSheetProtection]{style="COLOR: #2b91af"}.FormattingColumns);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                |
|                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                          |
|                                                                                                                                     |
| [\' Protecting the Worksheet by using a Password.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                |
|                                                                                                                                     |
| [sheet.Protect([\"syncfusion\"]{style="COLOR: maroon"},ExcelSheetProtection.FormattingColumns)]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can also unprotect the worksheet by using the **Unprotect** method of XlsIO. It allows the user to remove the restriction added to worksheet elements.

 

Following code example illustrates how to remove worksheet protection.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                   |
| [// Unprotecting (unlocking) the Worksheet using the Password.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                   |
| [sheet.Unprotect([\"syncfusion\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                  |
+-------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                              |
|                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                   |
| [\' Unprotecting (unlocking) the Worksheet using the Password.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                   |
| [sheet.Unprotect([\"syncfusion\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                    |
+-------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Chart Sheet Protection

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential XlsIO now provides support to protect or unprotect a chart sheet.

 

a\) Protecting a Chart Sheet

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

XlsIO provides options to protect chart sheets by using the **Protect** method. This method allows you to protect selected elements in a worksheet, so that they cannot be modified.

 

By using the **ExcelSheetProtection** enumeration, you can set the elements that need protection.

 

Following sample code illustrates protection of chart sheet (with password).

 

[·      ]{style="FONT-FAMILY: Symbol"}This default call will protect the chart for Contents and Objects.

[·      ]{style="FONT-FAMILY: Symbol"}You can also choose protection by using the overload.

 

The code mentioned below will choose default enumerations \"Contents\" and \"Objects\". The password chosen in the code snippet below is \"syncfusion\".

 

+------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                               |
|                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                |
| [// Protect chart sheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                |
| [chart.Protect([\"syncfusion\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                          |
|                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                               |
| [\' Protect chart sheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                   |
|                                                                                               |
| [chart.Protect([\"syncfusion\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------+

 

The protection can also be performed by using the enumerations in the code as shown below.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                        |
| [// Protect chart sheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                            |
|                                                                                                                                                        |
| [chart.Protect([\"syncfusion\"]{style="COLOR: #a31515"}, [ExcelSheetProtection]{style="COLOR: #2b91af"}.Content);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                        |
|                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                             |
| [\' Protect chart sheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                 |
|                                                                                                                             |
| [chart.Protect([\"syncfusion\"]{style="COLOR: #a31515"}, ExcelSheetProtection.Content)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------+

 

The chart sheet is protected. The content in the sheet cannot be edited.

 

b\) Removing protection of a Chart Sheet

 

You can remove the protection of a protected chart sheet by using the **Unprotect** method. Following code sample illustrates this.

 

+--------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                 |
|                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                  |
| [// Unprotect chart sheet]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                     |
|                                                                                                  |
| [chart.Unprotect([\"syncfusion\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                            |
|                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                 |
| [\' Unprotect chart sheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                   |
|                                                                                                 |
| [chart.Unprotect([\"syncfusion\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------+

 

The protection of the chart sheet is removed.

 

[]{#related-topics}
:::
