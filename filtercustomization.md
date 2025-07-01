::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Filter Customization {#filter-customization style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[·      ]{style="FONT-FAMILY: Symbol"}If you want to enable or disable the filter based on some condition, use the **AllowFiltering(bool)** method:

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [ [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\                                                                                                   |
| **       .**Datasource(Model)\                                                                                                                                                                                                                               |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                                                                       |
|        .EnablePaging()\                                                                                                                                                                                                                                      |
|        .EnableSorting()\                                                                                                                                                                                                                                     |
| **       **.Filtering(filter =\>\                                                                                                                                                                                                                            |
|            {\                                                                                                                                                                                                                                                |
|                **filter.AllowFiltering([true]{style="COLOR: blue"});\**                                                                                                                                                                                      |
|            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                              |
| [       [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                              |
| **[ ]{style="FONT-FAMILY: 'Courier New'"}**[\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\ |
| **       .**Datasource(Model)\                                                                                                                                                                                                                               |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                                                                       |
|        .EnablePaging()\                                                                                                                                                                                                                                      |
|        .EnableSorting()\                                                                                                                                                                                                                                     |
| **       **.Filtering(filter =\>\                                                                                                                                                                                                                            |
|            {\                                                                                                                                                                                                                                                |
|                **filter.AllowFiltering([true]{style="COLOR: blue"});\**                                                                                                                                                                                      |
|            }).Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                              |
| [       [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[·      ]{style="FONT-FAMILY: Symbol"}If you want to enable or disable the filter options for individual columns, use the **AllowFilter(bool)** method in column mapping.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                    |
|                                                                                                                                                                                                            |
| [ [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\                                                 |
| **       .**Datasource(Model)\                                                                                                                                                                             |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                     |
|        .EnablePaging()\                                                                                                                                                                                    |
|        .EnableSorting()\                                                                                                                                                                                   |
|        .EnableFiltering()\                                                                                                                                                                                 |
|        .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune)      \                                                                                                                                         |
|        .Column( columns =\> {\                                                                                                                                                                             |
|        columns.Add(p =\> p.OrderID).HeaderText([\"Order ID\"]{style="COLOR: #a31515"}).**AllowFilter**([false]{style="COLOR: blue"});\                                                                     |
|        columns.Add(p =\> p.CustomerID).HeaderText([\"Customer ID\"]{style="COLOR: #a31515"});\                                                                                                             |
|        columns.Add(p =\> p.EmployeeID).HeaderText([\"Employee ID\"]{style="COLOR: #a31515"});                    columns.Add(P =\> P.ShipCountry).HeaderText([\"Ship Country\"]{style="COLOR: #a31515"});\ |
|        columns.Add(p =\> p.OrderDate).HeaderText([\"Order Date\"]{style="COLOR: #a31515"});\                                                                                                               |
|            })\                                                                                                                                                                                             |
|        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                  |
|                                                                                                                                                                                                            |
| [ [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\                                                 |
| **       .**Datasource(Model)\                                                                                                                                                                             |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                     |
|        .EnablePaging()\                                                                                                                                                                                    |
|        .EnableSorting()\                                                                                                                                                                                   |
|        .EnableFiltering()\                                                                                                                                                                                 |
|        .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune)      \                                                                                                                                         |
|        .Column( columns =\> {\                                                                                                                                                                             |
|        columns.Add(p =\> p.OrderID).HeaderText([\"Order ID\"]{style="COLOR: #a31515"}).**AllowFilter**([false]{style="COLOR: blue"});\                                                                     |
|        columns.Add(p =\> p.CustomerID).HeaderText([\"Customer ID\"]{style="COLOR: #a31515"});\                                                                                                             |
|        columns.Add(p =\> p.EmployeeID).HeaderText([\"Employee ID\"]{style="COLOR: #a31515"});                    columns.Add(P =\> P.ShipCountry).HeaderText([\"Ship Country\"]{style="COLOR: #a31515"});\ |
|        columns.Add(p =\> p.OrderDate).HeaderText([\"Order Date\"]{style="COLOR: #a31515"});\                                                                                                               |
|            }).Render();\                                                                                                                                                                                   |
|        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[·      ]{style="FONT-FAMILY: Symbol"}If you want to render the filter menu in a simple drop-down list, use the **FilterDropDownType()** method.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                   |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\ |
| **       .**Datasource(Model)\                                                                                                                                                                                    |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                            |
|        .EnablePaging()\                                                                                                                                                                                           |
|        .EnableSorting()\                                                                                                                                                                                          |
|        .Filtering(filter =\>\                                                                                                                                                                                     |
|            {\                                                                                                                                                                                                     |
|                **filter.FilterDropDownType([FilterDropDownType]{style="COLOR: #2b91af"}.SimpleList);**\                                                                                                           |
|            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                   |
| [       [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                   |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\ |
| **       .**Datasource(Model)\                                                                                                                                                                                    |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                            |
|        .EnablePaging()\                                                                                                                                                                                           |
|        .EnableSorting()\                                                                                                                                                                                          |
|        .Filtering(filter =\>\                                                                                                                                                                                     |
|            {\                                                                                                                                                                                                     |
|                **filter.FilterDropDownType([FilterDropDownType]{style="COLOR: #2b91af"}.SimpleList);**\                                                                                                           |
|            }).Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                   |
| [       [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

There are two ways to specify the initial filters information namely:

[·      ]{style="FONT-FAMILY: Symbol"}Use the **Filtering()** method to add the initial filters.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                    |
|                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                 |
|                                                                                                                                                                                                            |
| [ [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\                                                 |
| **       .**Datasource(Model)\                                                                                                                                                                             |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                     |
|        .EnablePaging()\                                                                                                                                                                                    |
|        .EnableSorting()\                                                                                                                                                                                   |
| **       .Filtering(filter =\>\                                                                                                                                                                            |
|            {\                                                                                                                                                                                              |
|       filter.FilterDescriptors(descriptor =\>\                                                                                                                                                             |
|         {\                                                                                                                                                                                                 |
|         descriptor.Add(c =\> c.EmployeeID).FilterBy([FilterType]{style="COLOR: #2b91af"}.Equals).FilterValue(5);\                                                                                          |
|         });\                                                                                                                                                                                               |
|            })**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [       .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune)      \                                                                                                                                        |
|        .Column( columns =\> {\                                                                                                                                                                             |
|        columns.Add(p =\> p.OrderID).HeaderText([\"Order ID\"]{style="COLOR: #a31515"}).AllowFilter([false]{style="COLOR: blue"});\                                                                         |
|        columns.Add(p =\> p.CustomerID).HeaderText([\"Customer ID\"]{style="COLOR: #a31515"});\                                                                                                             |
|        columns.Add(p =\> p.EmployeeID).HeaderText([\"Employee ID\"]{style="COLOR: #a31515"});                    columns.Add(P =\> P.ShipCountry).HeaderText([\"Ship Country\"]{style="COLOR: #a31515"});\ |
|        columns.Add(p =\> p.OrderDate).HeaderText([\"Order Date\"]{style="COLOR: #a31515"});\                                                                                                               |
|            })\                                                                                                                                                                                             |
|        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                  |
|                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                 |
|                                                                                                                                                                                                            |
| [ [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().Grid\<[Order]{style="COLOR: #2b91af"}\>([\"Grid1\"]{style="COLOR: #a31515"})\                                                 |
| **       .**Datasource(Model)\                                                                                                                                                                             |
|        .Caption([\"Orders\"]{style="COLOR: #a31515"})\                                                                                                                                                     |
|        .EnablePaging()\                                                                                                                                                                                    |
|        .EnableSorting()\                                                                                                                                                                                   |
| **       .Filtering(filter =\>\                                                                                                                                                                            |
|            {\                                                                                                                                                                                              |
|       filter.FilterDescriptors(descriptor =\>\                                                                                                                                                             |
|         {\                                                                                                                                                                                                 |
|         descriptor.Add(c =\> c.EmployeeID).FilterBy([FilterType]{style="COLOR: #2b91af"}.Equals).FilterValue(5);\                                                                                          |
|         });\                                                                                                                                                                                               |
|            })**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [       .AutoFormat([Skins]{style="COLOR: #2b91af"}.Sandune)      \                                                                                                                                        |
|        .Column( columns =\> {\                                                                                                                                                                             |
|        columns.Add(p =\> p.OrderID).HeaderText([\"Order ID\"]{style="COLOR: #a31515"}).AllowFilter([false]{style="COLOR: blue"});\                                                                         |
|        columns.Add(p =\> p.CustomerID).HeaderText([\"Customer ID\"]{style="COLOR: #a31515"});\                                                                                                             |
|        columns.Add(p =\> p.EmployeeID).HeaderText([\"Employee ID\"]{style="COLOR: #a31515"});                    columns.Add(P =\> P.ShipCountry).HeaderText([\"Ship Country\"]{style="COLOR: #a31515"});\ |
|        columns.Add(p =\> p.OrderDate).HeaderText([\"Order Date\"]{style="COLOR: #a31515"});\                                                                                                               |
|            }).Render();\                                                                                                                                                                                   |
|        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}Through **GridPropertiesModel**

a.  Create **GridPropertiesModel** in **Controller Index** action and add the initial filters using the **FilterDescriptors** property.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                   |
| [ [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>();\                                                    |
|  \                                                                                                                                                                                                                                                                |
|             [// Apply intial filters to the grid. ]{style="COLOR: green"}\                                                                                                                                                                                        |
|   gridModel.Filters.FilterDescriptors.Add([new]{style="COLOR: blue"} [FilterDescriptor]{style="COLOR: #2b91af"}() { ColumnName = [\"EmployeeID\"]{style="COLOR: #a31515"}, Operator = Syncfusion.Linq.[FilterType]{style="COLOR: #2b91af"}.Equals, Value = 5 });\ |
|              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

b.  Pass the **GridPropertiesModel** to the view using the **ViewData()** method. Use the grid's ID as the key in **ViewData**.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                   |
| [ [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>();\                                                    |
|  \                                                                                                                                                                                                                                                                |
|             [// Apply intial filters to the grid. ]{style="COLOR: green"}\                                                                                                                                                                                        |
|   gridModel.Filters.FilterDescriptors.Add([new]{style="COLOR: blue"} [FilterDescriptor]{style="COLOR: #2b91af"}() { ColumnName = [\"EmployeeID\"]{style="COLOR: #a31515"}, Operator = Syncfusion.Linq.[FilterType]{style="COLOR: #2b91af"}.Equals, Value = 5 });\ |
|  \                                                                                                                                                                                                                                                                |
|             [//Pass the GridPropertiesModel to grid using GridID. Here FilterGrid is the grid\'s ID.]{style="COLOR: green"}\                                                                                                                                      |
| **            ViewData\[[\"FilterGrid\"]{style="COLOR: #a31515"}\] = gridModel;**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{#related-topics}
:::
