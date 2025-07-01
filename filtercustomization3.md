::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Filter Customization {#filter-customization style="tab-stops: 0pt"}

 

[·      ]{style="FONT-FAMILY: Symbol"}To enable or disable the filtering options for individual columns, use the **AllowFilter(bool)** method in column mapping.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"FilteringGrid\"]{style="COLOR: #a31515"},[\"GridModel\"]{style="COLOR: #a31515"}, columns =\> {\ |
|             columns.Add(p =\> p.OrderID).HeaderText([\"Order ID\"]{style="COLOR: #a31515"}).AllowFilter([false]{style="COLOR: blue"});\                                                                                                                                         |
|             columns.Add(p =\> p.CustomerID).HeaderText([\"Customer ID\"]{style="COLOR: #a31515"});\                                                                                                                                                                             |
|             columns.Add(p =\> p.EmployeeID).HeaderText([\"Employee ID\"]{style="COLOR: #a31515"});\                                                                                                                                                                             |
|             columns.Add(P =\> P.ShipCountry).HeaderText([\"Ship Country\"]{style="COLOR: #a31515"});\                                                                                                                                                                           |
|             columns.Add(p =\> p.OrderDate).HeaderText([\"Order Date\"]{style="COLOR: #a31515"}).Format([\"{0:dd-MM-yyyy}\"]{style="COLOR: #a31515"});\                                                                                                                          |
|      })[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

::: {align="center"}
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [   ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [@(]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[new]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [HtmlString]{style="COLOR: #2b91af"}(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"FilteringGrid\"]{style="COLOR: #a31515"},[\"GridModel\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [ columns =\> {\                                                                                                                                                                                                                                                                                                                                                                                                          |
|             columns.Add(p =\> p.OrderID).HeaderText([\"Order ID\"]{style="COLOR: #a31515"}).AllowFilter([false]{style="COLOR: blue"});\                                                                                                                                                                                                                                                                                   |
|             columns.Add(p =\> p.CustomerID).HeaderText([\"Customer ID\"]{style="COLOR: #a31515"});\                                                                                                                                                                                                                                                                                                                       |
|             columns.Add(p =\> p.EmployeeID).HeaderText([\"Employee ID\"]{style="COLOR: #a31515"});\                                                                                                                                                                                                                                                                                                                       |
|             columns.Add(P =\> P.ShipCountry).HeaderText([\"Ship Country\"]{style="COLOR: #a31515"});\                                                                                                                                                                                                                                                                                                                     |
|             columns.Add(p =\> p.OrderDate).HeaderText([\"Order Date\"]{style="COLOR: #a31515"}).Format([\"{0:dd-MM-yyyy}\"]{style="COLOR: #a31515"});\                                                                                                                                                                                                                                                                    |
|      })]{style="FONT-FAMILY: 'Courier New'"}[.ToString())[)]{style="BACKGROUND: yellow"}    ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[    ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}To render the filter menu in a simple drop-down list, use the **FilterDropDownType** property.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                 |
|                                                                                                                                                                                                                    |
| [      // Create the GridPropertiesModel.]{style="FONT-FAMILY: Consolas; COLOR: green"}[\                                                                                                                          |
|       [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>();\ |
|           \                                                                                                                                                                                                        |
|       [// Specify the drop-down type.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas"}                                                                                                                       |
|                                                                                                                                                                                                                    |
| [       gridModel.Filters.FilterDropDownType = [FilterDropDownType]{style="COLOR: #2b91af"}.SimpleList;]{style="FONT-FAMILY: Consolas"}                                                                            |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}To render the grid with the initial filtering, add filter conditions using the **FilterDescriptors** property.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                 |
|                                                                                                                                                                                                                    |
| [      ]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 12pt"}[// Create the GridPropertiesModel.]{style="FONT-FAMILY: Consolas; COLOR: green"}[\                                                          |
|       [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>();\ |
|           \                                                                                                                                                                                                        |
|       [// Specify the drop-down type.]{style="COLOR: green"}\                                                                                                                                                      |
|       gridModel.Filters.FilterDropDownType = [FilterDropDownType]{style="COLOR: #2b91af"}.SimpleList;]{style="FONT-FAMILY: Consolas"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}To render the grid with initial filtering, add the filter conditions using the **FilterDescriptors** property.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                     |
| [ public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Filtering1()\                                                                                                                                                                    |
|  {\                                                                                                                                                                                                                                                                                 |
|      [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>()\                                                                    |
|      {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                     |
| **[        ]{style="FONT-FAMILY: 'Courier New'"}**[ActionMode = ActionMode.JSON,]{style="FONT-FAMILY: 'Courier New'"}[\                                                                                                                                                             |
|         Caption = [\"Orders\"]{style="COLOR: #a31515"},\                                                                                                                                                                                                                            |
|         AllowFiltering = [true]{style="COLOR: blue"},\                                                                                                                                                                                                                              |
|         AutoFormat = [Skins]{style="COLOR: #2b91af"}.Sandune\                                                                                                                                                                                                                       |
|       };]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                     |
| [      [// Apply intial filters to the grid. ]{style="COLOR: green"}\                                                                                                                                                                                                               |
|      **gridModel.Filters.FilterDescriptors.Add([new]{style="COLOR: blue"} [FilterDescriptor]{style="COLOR: #2b91af"}() { ColumnName = [\"EmployeeID\"]{style="COLOR: #a31515"}, Operator = Syncfusion.Linq.[FilterType]{style="COLOR: #2b91af"}.Equals, Value = 5 });**           \ |
|  \                                                                                                                                                                                                                                                                                  |
|         ViewData\[[\"GridModel\"]{style="COLOR: #a31515"}\] = gridModel;\                                                                                                                                                                                                           |
|         [return]{style="COLOR: blue"} View();\                                                                                                                                                                                                                                      |
|   }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Tables for properties, methods, and events

Properties

*[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 9pt"}* 

::: {align="center"}
+--------------------------------------+-----------------------------------------------+-----------------+--------------------------------------+
| Property                             | Description                                   | Type            | Data type                            |
+--------------------------------------+-----------------------------------------------+-----------------+--------------------------------------+
| ActionMode[]{style="COLOR: #c00000"} | Gets or sets the **ActionMode** for the grid. | Server-side     | ActionMode[]{style="COLOR: #c00000"} |
|                                      |                                               |                 |                                      |
|                                      | \                                             |                 |                                      |
|                                      | **Possible Values:**                          |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | ActionMode.JSON                               |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | ActionMode.Server                             |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | **Default value:**                            |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | ActionMode.Server                             |                 |                                      |
+--------------------------------------+-----------------------------------------------+-----------------+--------------------------------------+
:::

*[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 9pt"}* 

Methods

*[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 9pt"}* 

::: {align="center"}
+-------------+-----------------------------------+----------------------+-------------+-------------+
| Method      | Description                       | Parameters           | Type        | Return type |
+-------------+-----------------------------------+----------------------+-------------+-------------+
| ActionMode  | Gets the ActionMode for the Grid. | (ActionMode mode)    | Server-side | Void        |
|             |                                   |                      |             |             |
|             |                                   | **Possible Values:** |             |             |
|             |                                   |                      |             |             |
|             |                                   | ActionMode.JSON      |             |             |
|             |                                   |                      |             |             |
|             |                                   | ActionMode.Server    |             |             |
|             |                                   |                      |             |             |
|             |                                   |                      |             |             |
|             |                                   |                      |             |             |
|             |                                   | **Default value:**   |             |             |
|             |                                   |                      |             |             |
|             |                                   | ActionMode.Server    |             |             |
+=============+===================================+======================+=============+=============+
:::

[]{#related-topics}
::::::
