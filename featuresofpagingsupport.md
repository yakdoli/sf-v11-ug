::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Features of Paging Support {#features-of-paging-support style="tab-stops: 0pt"}

OnDemandPaging

The GridDataControl supports paging on demand by specifying queries in order to get the paged records from a database. The records are displayed only when it is required. This sample retrieves fifty records from a database and displays them. By this type we can fetch the data from the data source for the current page. No need to fetch whole data from the datasource. We can get high performance for millions of records.

 

Xaml

+------------------------------------------------------------------------------------+
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|    <sync:DataPagerExt x:Name="dataPager" Grid.Row="1" HorizontalAlignment="Center" |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  Width="720"  VerticalAlignment="Top" DisplayMode="FirstLastPreviousNextNumeric"   |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  AutoEllipsis="True"  PageSize="40"                                                |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|                       >                                                            |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  </sync:DataPagerExt>                                                              |
| ```                                                                                |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
+------------------------------------------------------------------------------------+

 

C#

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [            pager.PageCount = 400;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [            pager.IsPagingOnDemand = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [            pager.OnDemandDataSourceLoad += ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[GridDataOnDemandPageLoadingEventHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[(pager_OnDemandDataSourceLoad);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pager_OnDemandDataSourceLoad(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[object]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sender, ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[GridDataOnDemandPageLoadingEventArgs]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ e)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [        {]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.ItemsSource = Get_Data(e.PagedRows, e.PagedRows + e.MaximumRows);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [        }]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

ViewLevelPaging

ViewLevel Sorting, grouping and filtering is provided.

Xaml

+------------------------------------------------------------------------------------+
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|    <sync:DataPagerExt x:Name="dataPager" Grid.Row="1" HorizontalAlignment="Center" |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  Width="720"  VerticalAlignment="Top" DisplayMode="FirstLastPreviousNextNumeric"   |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  AutoEllipsis="True"  PageSize="40"                                                |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|                       >                                                            |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  </sync:DataPagerExt>                                                              |
| ```                                                                                |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
+------------------------------------------------------------------------------------+

 

C#

+-------------------------------------------------------------------------------------------------------------------------------------------------------+
| [                            [var]{style="COLOR: blue"} item = [new]{style="COLOR: blue"} NorthwindOrders(1000);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                       |
| [            [var]{style="COLOR: blue"} itemlist = [new]{style="COLOR: blue"} PagedCollectionView(item);]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                       |
| [            pager.Source = itemlist;]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                       |
| [            grid.ItemsSource = itemlist;]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                       |
| [            grid.EnablePaging = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                       |
| [            grid.IsViewLevelPaging = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------+

 

SourceLevelPaging

Sorting, grouping and filtering are provided at the Source level.

Xaml

+------------------------------------------------------------------------------------+
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|    <sync:DataPagerExt x:Name="dataPager" Grid.Row="1" HorizontalAlignment="Center" |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  Width="720"  VerticalAlignment="Top" DisplayMode="FirstLastPreviousNextNumeric"   |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  AutoEllipsis="True"  PageSize="40"                                                |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|                       >                                                            |
| ```                                                                                |
|                                                                                    |
| ``` {style="BACKGROUND: #f0f0f0"}                                                  |
|  </sync:DataPagerExt>                                                              |
| ```                                                                                |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
+------------------------------------------------------------------------------------+

 

C#

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [            var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ item = [new]{style="COLOR: blue"} NorthwindOrders(1000);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                   |
| [            [var]{style="COLOR: blue"} itemlist = [new]{style="COLOR: blue"} PagedCollectionView(item);]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                   |
| [            pager.Source = itemlist;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                   |
| [            grid.ItemsSource = itemlist;]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                   |
| [            grid.EnablePaging = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                   |
| [            grid.IsViewLevelPaging = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::
