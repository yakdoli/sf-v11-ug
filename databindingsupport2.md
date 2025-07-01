::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Data Binding Support {#data-binding-support style="tab-stops: 0pt"}

The Data Binding feature has generated common DataModel based on the user bind underlying objects. You can use this DataModel to perform sorting and grouping operations. This can be done by using the **DataModel.View** property of ChartSeries control.  You can also bind **ObservableCollection, List, IList, CollectionViewSource, DataTable, LINQ** **results, ITypedList**, **IBindingList, BindingList** and XML data into the Chart.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The View is internally generated automatically based on the object collection bind on the **DataSource** property of ChartSeries.  You can also bind the external collection view objects into the Chart. The external collection view, SortDescription and GroupDescription are internally listened by Chart DataModel and the internal View.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This Data Binding engine improves the performance of chart with effectively handling the chart data.  The following are some of the useful tips to improve the chart performance.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Instead of using built-in IsSortData and IsIndexed feature, you can sort the underlying business object in application level and then initialize it to **DataSource** property of ChartSeries control.

[·      ]{style="FONT-FAMILY: Symbol"}Use **BeginInit** and **EndInit** method when you add, delete and replace multiple objects at a same time in ChartSeries control.  It helps to improve the performance.

[·      ]{style="FONT-FAMILY: Symbol"}Disable Auto Range and Interval feature. You can manually initialize the Range and Interval to ChartAxis to get better performance.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Use Case Scenarios

In Stock market, data gets updated in a timely manner.  Initial data can be bind to chart and later you can update the underlying object.  Based on that new stock information added in your underlying object, the DataModel and the Chart Visual can refresh automatically.

 

Adding Data Binding to an Application

You can bind chart data into the **DataSource** property of ChartSeries control.  The View is generated internally for the user bound data and the chart can render in visual.  The **BindingPathX** and **BindingPathsY** properties are used to initialize the property name of the binded data.  This property values is used as coordinate values for X and Y direction in the ChartAxis control.

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ DataSource]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"{]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[StaticResource]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ data]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[}\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ BindingPathX]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"ProductID\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ BindingPathsY]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Price\" /\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[.]{style="COLOR: #c00000"}

[]{style="COLOR: #c00000"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                  |
| [            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[ProductDetails]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ data = [this]{style="COLOR: blue"}.Resources\[[\"data\"]{style="COLOR: #a31515"}\] [as]{style="COLOR: blue"} [ProductDetails]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                  |
| [            [//Initialize the business object into the ChartSeries.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                  |
| [            series.DataSource = data;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                  |
| [            series.BindingPathX = [\"ProductID\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                  |
| [            series.BindingPathsY = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\] { [\"Price\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                  |
| [            [//To add the SortDescription in DataModel View.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                  |
| [            [SortDescription]{style="COLOR: #2b91af"} desc = [new]{style="COLOR: blue"} [SortDescription]{style="COLOR: #2b91af"}([\"Price\"]{style="COLOR: #a31515"}, [ListSortDirection]{style="COLOR: #2b91af"}.Descending);]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                                                                                                                                  |
| [            chart.Areas\[0\].Series\[0\].DataModel.View.SortDescriptions.Add(desc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[.]{style="COLOR: #c00000"}

Table 7: DataModel Table

::: {align="center"}
  ----------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------ ---------------- -----------------
  Property    Description                                                                                                                                                         Type   Data Type        Reference links
  DataModel   This DataModel has internally initialized based on the user bind data on DataSource property of ChartSeries control.  It generates View for user bind DataSource.   CLR.   ChartDataModel   NA
  ----------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------ ---------------- -----------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Table 2: ChartDataModel Table

::: {align="center"}
  ---------- ------------------------------------------------------------------------------------------------------------------------------------------------------------ ------ -------------------- -----------------
  Property   Description                                                                                                                                                  Type   Data Type            Reference links
  View       This property helps to add SortDescription and GroupDescription features.  This property initializes the common view for all Collection objects initially.   CLR.   ICollectionViewAdv   NA
  ---------- ------------------------------------------------------------------------------------------------------------------------------------------------------------ ------ -------------------- -----------------
:::

 

[]{#related-topics}
:::::
