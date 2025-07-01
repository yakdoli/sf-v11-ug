::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Find and Replace {#find-and-replace style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Find and Replace feature in Excel enables to navigate between large spreadsheets. It carries out a simultaneous search in Microsoft Excel values, formulas and also comments.

 

XlsIO also has support for finding and replacing contents in a worksheet. It has various options to find the first matching entry, find all the matching entries, and replace the found content with various data and data sources.

 

![](ImagesExt/image47_30.jpg){border="0"}

Figure 57: Find and Replace Dialog Box[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

 

XlsIO has the following common find and replace methods and properties, and their usage. This section describes all the methods listed below.

 

[·      ]{style="FONT-FAMILY: Symbol"}FindFirst

[·      ]{style="FONT-FAMILY: Symbol"}FindAll

[·      ]{style="FONT-FAMILY: Symbol"}FindStringStartswith

[·      ]{style="FONT-FAMILY: Symbol"}FindStringEndswith

[·      ]{style="FONT-FAMILY: Symbol"}Replace

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Following are the possible types of params of the **ExcelFindType** enumerator in the FindFirst and FindAll methods.

 

::: {align="center"}
  -------------------- -------------------------------------------------
  Member Name          Description
  Text                 Represents the Text Finding type.
  Formula              Represents the Formula Finding type.
  FormulaStringValue   Represents the FormulaStringValue Finding type.
  Error                Represents the Error Finding type.
  Number               Represents the Number Finding type.
  FormulaValue         Represents the FormulaValue Finding type.
  -------------------- -------------------------------------------------
:::

**** 

Following are the possible types of params of the **ExcelFindOptions** enumerator in the FindFirst and FindAll methods.

**** 

  ----------------- ----------------------------------------------------------------
  Member Name       Description
  Match Case        Matches case while finding the value.
  MatchEntireCell   Matches the whole word being searched while finding the value.
  ----------------- ----------------------------------------------------------------

 

Find First

 

This method has overloads for searching the first cell with the specified typed value. **The ExcelFindType** enumerator provides options to set the data type of the string (i.e. value and formula value) to be searched, and the **ExcelFindOptions** enumerator provides the options to match the strings associated with the find value.

 

::: {align="center"}
  Methods                                               Description
  ----------------------------------------------------- ------------------------------------------------------------------------------------------------
  FindFirst(Boolean)                                    This method searches for the cell with specified bool value.
  FindFirst (DateTime)                                  This method searches for the cell with specified DateTime value.
  FindFirst (TimeSpan)                                  This method searches for the cell with specified TimeSpan value.
  FindFirst (Double, ExcelFindType)                     This method searches for the cell with specified double value.
  FindFirst (String, ExcelFindType, ExcelFindOptions)   This method searches for the cell with specified string value, again based on the Find options
:::

**** 

**** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                          |
| [//FindFirst with Number]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                          |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindFirst(1000000.00075, [ExcelFindType]{style="COLOR: #2b91af"}.Number);]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                                                                          |
| [                                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [// Gets the cell display text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                          |
| [txtDisplay.Text = result.DisplayText.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [//Find First with Match case]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                          |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindFirst([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchCase);]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [// Gets the cell display text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                          |
| [txtDisplay.Text = result.DisplayText.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [//Find First with MatchEntireCellContent]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                          |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindFirst([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchEntireCellContent);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [// Gets the cell display text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                          |
| [txtDisplay.Text = result.DisplayText.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                          |
| [\'FindFirst with Number]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                                                        |
|                                                                                                                                                                                                                                          |
| [Dim result As Range = sheet.FindFirst(1000000.00075, [ExcelFindType]{style="COLOR: #2b91af"}.Number)]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Gets the cell display text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                                          |
| [txtDisplay.Text = result.DisplayText.ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Find First with Match case]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                                          |
| [Dim result As IRange = sheet.FindFirst([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchCase)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Gets the cell display text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                                          |
| [txtDisplay.Text = result.DisplayText.ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Find First with MatchEntireCellContent]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                                                          |
| [Dim result As IRange = sheet.FindFirst([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchEntireCellContent)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Gets the cell display text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                                          |
| [txtDisplay.Text = result.DisplayText.ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

**FindAll**

This method searches all the cells, and returns all the entries in the sheet that matches the specified data.

 

::: {align="center"}
  --------------------------------------------------- -----------------------------------------------------------------------------------------------------
  Methods                                             Description
  FindAll(Boolean)                                    This method searches for all the cells with specified bool value.
  FindAll(DateTime)                                   This method searches for all the cells with specified DateTime value.
  FindAll(TimeSpan)                                   This method searches for all the cells with specified TimeSpan value.
  FindAll(Double, ExcelFindType)                      This method searches for all the cells with specified double value.
  FindAll (String, ExcelFindType, ExcelFindOptions)   This method searches for all the cells with specified string value, again based on the Find options
  --------------------------------------------------- -----------------------------------------------------------------------------------------------------
:::

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                            |
| [//Find All with Text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                            |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] result =sheet .FindAll ([\"Simple Text\"]{style="COLOR: #a31515"},[ExcelFindType]{style="COLOR: #2b91af"}.Text );]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                            |
| [//Find All with Simple text and Match Case]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                            |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] result = sheet.FindAll([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchCase);]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                            |
| [//Find All with Simple Text and MatchEntireCellContent]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                            |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] result = sheet.FindAll([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchEntireCellContent);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| **[ \[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Find All with Text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                          |
| [Dim result() As IRange =sheet.FindAll ([\"Simple Text\"]{style="COLOR: #a31515"},[ExcelFindType]{style="COLOR: #2b91af"}.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Find All with Simple text and Match Case]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| [Dim result() As IRange = sheet.FindAll([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchCase)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\'Find All with Simple Text and MatchEntireCellContent]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                               |
|                                                                                                                                                                                                                                          |
| [Dim result() As IRange = sheet.FindAll([\"Simple text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [ExcelFindOptions]{style="COLOR: #2b91af"}.MatchEntireCellContent)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

FindStringStartswith

 

This method has overloads to search for the first cell that starts with the specified value. The **ExcelFindType** enumerator provides options to set the data type of the string (i.e. value and formula value) to be searched.\
\

+---------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------+
| Methods                                           | Description                                                                                                           |
+---------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------+
| FindStringStartsWith( String , ExcelFindType)     | These methods search for cells that start with the specified string value for the given find type.                    |
|                                                   |                                                                                                                       |
|                                                   |                                                                                                                       |
+---------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------+
| FindStringStartsWith( String, ExcelFindType,bool) | These methods searchfor cells which start with the specified string value, for the given find type and boolean value. |
+---------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------+

**** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                       |
| [//Starts with Simple Text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                       |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = result = sheet.FindStringStartsWith([\"Sim\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text);]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [//StartsWith the Number with Text format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                       |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindStringStartsWith([\"\$8\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text);]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [//Startswith the Text with MatchCase]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                       |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindStringStartsWith([\"Si\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

\
\

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [\'Starts with Simple Text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} IRange = result = sheet.FindStringStartsWith([\"Sim\"]{style="COLOR: darkred"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text)]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [\'StartsWith the Number with Text format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} IRange = sheet.FindStringStartsWith([\"\$8\"]{style="COLOR: darkred"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text)]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [\'Startswith the Text with MatchCase]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} IRange = sheet.FindStringStartsWith([\"Si\"]{style="COLOR: darkred"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

\
FindStringEndswith

\
This method has overloads to search for cells that have the first cell ending with the specified typed value. **ExcelFindType** enumerator provides options to set the data type of the value and formula value/string to be searched.\
\

  ---------------------------------------------------- -----------------------------------------------------------------------------------------------------------------------
  Methods                                              Description
  FindStringEndsWith ( String, ExcelFindType)          These methods search for the cell which ends with the specified string value, for the given find type.
  FindStringStartsWith ( String, ExcelFindType,bool)   These methods search for the cell which ends with the specified string value, for the given find type and bool value.
  ---------------------------------------------------- -----------------------------------------------------------------------------------------------------------------------

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                      |
| [//Ends with Text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                      |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = result = sheet.FindStringEndsWith([\"Text\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text);]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                      |
| [//EndsWith the Number with Text format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                      |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindStringEndsWith([\"00\"]{style="COLOR: #a31515"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text);]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                      |
| [//Endswith the Text with MatchCase]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                      |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = sheet.FindStringEndsWith([\"Case\"]{style="COLOR: #a31515"},[ExcelFindType]{style="COLOR: #2b91af"}.Text, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

\
\

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                 |
| [\'Starts with Simple Text]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} IRange = result = sheet.FindStringEndsWith([\"]{style="COLOR: darkred"}[Text]{style="COLOR: #a31515"}[ \"]{style="COLOR: darkred"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                 |
| [\'StartsWith the Number with Text format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} IRange = sheet.FindStringEndsWith([\"00\"]{style="COLOR: darkred"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                 |
| [\'Startswith the Text with MatchCase]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} IRange = sheet.FindStringEndsWith([\"Case\"]{style="COLOR: darkred"}, [ExcelFindType]{style="COLOR: #2b91af"}.Text, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Replace

 

This method enables to replace a string, with the data of various data types and data sources, such as data table, data column and array. Following are the overloads for the **Replace** method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------------------------------- --------------------------------------------------
  Methods                                Description
  Replace(String, DateTime)              Replaces specified string by specified value.
  Replace(String, Double)                Replaces specified string by specified value.
  Replace(String, String)                Replaces specified string by specified value.
  Replace(String, DataColumn, Boolean)   Replaces specified string by data column values.
  Replace(String, DataTable, Boolean)    Replaces specified string by data table values.
  Replace(String, Double\[\], Boolean)   Replaces specified string by data from array.
  Replace(String, Int32\[\], Boolean)    Replaces specified string by data from array.
  Replace(String, String\[\], Boolean)   Replaces specified string by data from array.
  -------------------------------------- --------------------------------------------------
:::

 

Following code example illustrates how to replace strings with various data.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                               |
| [// Replacing the Text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                               |
| [sheet.Replace([\"Find and Replace\"]{style="COLOR: #a31515"}, [\"New Find and Replace\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                               |
| [// Replacing a date value by using datetime.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                               |
| [sheet.Replace([\"Datevalue\"]{style="COLOR: #a31515"}, [DateTime]{style="COLOR: #2b91af"}.Now);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                               |
| [// Replace using array value.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                               |
| [sheet.Replace([\"Arrayvalue\"]{style="COLOR: #a31515"}, [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\] { [\"ArrayValue1\"]{style="COLOR: #a31515"}, [\"ArrayValue2\"]{style="COLOR: #a31515"}, [\"ArrayValue3\"]{style="COLOR: #a31515"} }, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                               |
| [// Replacing a data table by calling a function SampleDataTable().]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                               |
| [DataTable]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ table = SampleDataTable();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                               |
| [sheet.Replace([\"DataTable\"]{style="COLOR: #a31515"}, table, [true]{style="COLOR: blue"}); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [\' Replacing the Text.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                      |
| [sheet.Replace([\"Find and Replace\"]{style="COLOR: maroon"}, [\"New Find and Replace\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [\' Replacing a date value by using datetime.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                      |
| [sheet.Replace([\"Datevalue\"]{style="COLOR: maroon"}, DateTime.Now)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [\' Replace using array value.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                      |
| [sheet.Replace([\"Arrayvalue\"]{style="COLOR: maroon"}, [New]{style="COLOR: blue"} [String]{style="COLOR: blue"}() {[\"ArrayValue1\"]{style="COLOR: maroon"}, [\"ArrayValue2\"]{style="COLOR: maroon"}, [\"ArrayValue3\"]{style="COLOR: maroon"}}, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [\' Replacing a data table by calling a function SampleDataTable().]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ table [As]{style="COLOR: blue"} DataTable = SampleDataTable()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                      |
| [sheet.Replace([\"DataTable\"]{style="COLOR: maroon"}, table, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::::::
