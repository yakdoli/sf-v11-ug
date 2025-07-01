::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### IDictionary  {#idictionary style="tab-stops: 0pt"}

IDictionary supports for binding the Dictionary list to the chart series **BindingPathX** and **BindingPathsY** Values.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Sample Data Source

IDictionary is useful to bind this kind of data source.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: In this sample data, 0, 1, 2, 3 ...6 are the Keys and the CompanyExpenses are the Values.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [            ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[SortedList]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ Expenditure = [new]{style="COLOR: blue"} [SortedList]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(0, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Production\"]{style="COLOR: #a31515"}, y = 20d });]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(1, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Facilities\"]{style="COLOR: #a31515"}, y = 23d });]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(2, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Insurance\"]{style="COLOR: #a31515"}, y = 12d });]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(3, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Licenses\"]{style="COLOR: #a31515"}, y = 3d });]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(4, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Labor\"]{style="COLOR: #a31515"}, y = 28d });]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(5, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Legal\"]{style="COLOR: #a31515"}, y = 2d });]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                       |
| [            expenditure.Add(6, [new]{style="COLOR: blue"} [CompanyExpense]{style="COLOR: #2b91af"}() { x = [\"Taxes\"]{style="COLOR: #a31515"}, y = 10d });]{style="FONT-FAMILY: 'Courier New'"}                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}** 

[            ]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Binding Data Source

Bind the data source, by using the following code.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image81_1.jpg){border="0"}Note: Set BindingPath to Key to bind the key of the dictionary to BindingPathX or BindingPathsY.
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Xaml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ BindingPathX]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Key\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ BindingPathsY]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"y\" ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [DataSource={StaticResource ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[expenditure]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[}\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; COLOR: #15428b"} 

[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} 

+-------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                              |
|                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                               |
| [Series.BindingPathX="Key";]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                               |
| [Series.BindingPathsY ="y";]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+-------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: red"} 

[]{#related-topics}
:::::
