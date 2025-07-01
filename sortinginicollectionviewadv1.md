::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Sorting in ICollectionViewAdv {#sorting-in-icollectionviewadv style="tab-stops: 0pt"}

Adding SortDescriptions to the ICollectionView would sort the internal data.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ orders = northwind.Orders;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ queryableCollectionView = [new]{style="COLOR: blue"} [QueryableCollectionView]{style="COLOR: #2b91af"}(orders);]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                                                                         |
| [queryableCollectionView.SortDescriptions.Add([new]{style="COLOR: blue"} System.ComponentModel.[SortDescription]{style="COLOR: #2b91af"}([\"CustomerID\"]{style="COLOR: #a31515"}, System.ComponentModel.[ListSortDirection]{style="COLOR: #2b91af"}.Descending));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                         |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([var]{style="COLOR: blue"} record [in]{style="COLOR: blue"} queryableCollectionView.Records)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [    var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ order = ([Orders]{style="COLOR: #2b91af"})record.Data;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine([\"OrderID - {0} / CustomerID - {1}\"]{style="COLOR: #a31515"}, order.OrderID, order.CustomerID);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Cambria','serif'; COLOR: #4f81bd; FONT-SIZE: 13pt"}** 

Sorting with Grouping

 

The TopLevelGroup works in conjunction with the sort descriptions present in the ICollectionView. It would automatically sort the groups and its bottom level group (records).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ orders = northwind.Orders;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ queryableCollectionView = [new]{style="COLOR: blue"} [QueryableCollectionView]{style="COLOR: #2b91af"}(orders);]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                                                                         |
| [queryableCollectionView.SortDescriptions.Add([new]{style="COLOR: blue"} System.ComponentModel.[SortDescription]{style="COLOR: #2b91af"}([\"CustomerID\"]{style="COLOR: #a31515"}, System.ComponentModel.[ListSortDirection]{style="COLOR: #2b91af"}.Descending));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                         |
| [queryableCollectionView.GroupDescriptions.Add([new]{style="COLOR: blue"} [PropertyGroupDescription]{style="COLOR: #2b91af"}([\"ShipCountry\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                                                                                         |
| [queryableCollectionView.GroupDescriptions.Add([new]{style="COLOR: blue"} [PropertyGroupDescription]{style="COLOR: #2b91af"}([\"ShipCity\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                         |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([var]{style="COLOR: blue"} nodeEntry [in]{style="COLOR: blue"} queryableCollectionView.TopLevelGroup)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [    Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine(nodeEntry);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([var]{style="COLOR: blue"} record [in]{style="COLOR: blue"} queryableCollectionView.Records)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [    var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ order = ([Orders]{style="COLOR: #2b91af"})record.Data;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [    Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"OrderID - {0} / CustomerID - {1}\"]{style="COLOR: #a31515"}, order.OrderID, order.CustomerID);]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image28_3.jpg){border="0"}]{style="FONT-FAMILY: 'Times New Roman','serif'"}Note: When applying sorting with grouping, both the ICollectionViewAdv.TopLevelGroup and the ICollectionViewAdv.Records will be in sync.

 

 
:::

[]{#related-topics}
::::
