::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to add Expression columns {#how-to-add-expression-columns style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Expression fields allows you to add a column that holds calculated values based on other fields in the same record. These expression columns can be used in grouping and sorting. This also can be employed as summary fields for summary rows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                        |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                  |
|                                                                                                                                                                       |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  Syncfusion.Grouping;]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                       |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  Syncfusion.Windows.Forms.Grid;]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                       |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  Syncfusion.Windows.Forms.Grid.Grouping;]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [// Declare an ExpressionFieldDescriptor]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                           |
|                                                                                                                                                                       |
| [ExpressionFieldDescriptor expression1 = [new]{style="COLOR: blue"} ExpressionFieldDescriptor();]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                       |
| [expression1.Name = [\"Sum of all columns\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [// Simple expression to add the values in the columns ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                            |
|                                                                                                                                                                       |
| [// For all the valid Expression syntax, refer the ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                |
|                                                                                                                                                                       |
| [// EssentialGrid UserGuide \--\> Essential Grid Tutorials \-\--\> ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                |
|                                                                                                                                                                       |
| [//Adding Expression Fields \-\--\> Valid Expression Syntax ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                       |
|                                                                                                                                                                       |
| [expression1.Expression = [\"\[Col0\] + \[Col1\] + \[Col2\] + \[Col3\]\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                       |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                       |
| [//Add the Expression column to the grid]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                           |
|                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.TableDescriptor.ExpressionFields.Add(expression1);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"}                                                                                                                                    |
|                                                                                                                                                                                           |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Grouping]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                           |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Grid]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                           |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Grid.Grouping]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\' Declare an ExpressionFieldDescriptor]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ expression1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} ExpressionFieldDescriptor()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [expression1.Name = [\"Sum of all columns\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                     |
|                                                                                                                                                                                           |
| [\' Simple expression to add the values in the columns ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                |
|                                                                                                                                                                                           |
| [\' For all the valid Expression syntax, refer the ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                    |
|                                                                                                                                                                                           |
| [\' EssentialGrid UserGuide \--\> Essential Grid Tutorials \-\--\> ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                    |
|                                                                                                                                                                                           |
| [\' Adding Expression Fields \-\--\> Valid Expression Syntax ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                                           |
| [expression1.Expression = [\"\[Col0\] + \[Col1\] + \[Col2\] + \[Col3\]\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                     |
|                                                                                                                                                                                           |
| [\'Add the Expression column to the grid]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.TableDescriptor.ExpressionFields.Add(expression1)]{style="FONT-FAMILY: 'Courier New'"}                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p687} 

 

[]{#related-topics}
:::
