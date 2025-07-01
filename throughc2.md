::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Through C# {#through-c style="tab-stops: 0pt"}

To create the MenuAdv control through C#, include the following namespace to the directives list.

 

+---------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                          |
|                                                                                                                           |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Shared;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------+

 

 Next, create the MenuAdv as follows.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                             |
| [MenuAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ mAdv = [new]{style="COLOR: blue"} [MenuAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [     [MenuItemAdv]{style="COLOR: #2b91af"} product = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Products\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [     [MenuItemAdv]{style="COLOR: #2b91af"} bi = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Business Intelligence\"]{style="COLOR: #a31515"} };            ]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                                             |
| [     ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                             |
| [       [MenuItemAdv]{style="COLOR: #2b91af"} ui = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"User Interface\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [          [MenuItemAdv]{style="COLOR: #2b91af"} wpf = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"WPF\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                             |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"} tools = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Tools\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"} chart = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Chart\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"} grid = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Grid\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"} diagram = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Diagram\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"}  gauge= [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Gauge\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"} schedule = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Schedule\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                                             |
| [            [MenuItemAdv]{style="COLOR: #2b91af"} edit = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Edit\"]{style="COLOR: #a31515"} };                         ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                             |
| [  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(tools);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(chart);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(grid);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(diagram);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(gauge);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(schedule);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                             |
| [            wpf.Items.Add(edit);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [          [MenuItemAdv]{style="COLOR: #2b91af"} sl = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Silverlight\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                                             |
| [          ui.Items.Add(wpf);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                             |
| [          ui.Items.Add(sl);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [        [MenuItemAdv]{style="COLOR: #2b91af"} reporting = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}() { Header = [\"Reporting\"]{style="COLOR: #a31515"} };]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                             |
| [        product.Items.Add(bi);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [        product.Items.Add(ui);                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [        product.Items.Add(reporting);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [   mAdv.Items.Add(product);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
