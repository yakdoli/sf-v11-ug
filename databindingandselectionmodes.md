::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Data binding and Selection Modes {#data-binding-and-selection-modes style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Data Binding

 

Data binding is used in Web pages that contain interactive components such as forms, calculators, tutorials, and games. Pages are displayed incrementally so that portions of a page can be used even before the entire page has finished downloading. Data binding helps in populating the Grid List control with large amounts of data. This can be achieved by using DataSource property which allows the system to acquire data from the Data Source Object (DSO).

 

The following code example illustrates data binding for Grid List control by using DataSource property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                          |
|                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                         |
| [ArrayList]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ array = [new]{style="COLOR: blue"} [ArrayList]{style="COLOR: #2b91af"}();        ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [array.Add([new]{style="COLOR: blue"} MyClass(001,[\"John David\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                         |
| [array.Add([new]{style="COLOR: blue"} MyClass(002,[\"Tom\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                         |
| [array.Add([new]{style="COLOR: blue"} MyClass(003,[\"Bretney\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                         |
| [array.Add([new]{style="COLOR: blue"} MyClass(004,[\"Jessy\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                         |
| [array.Add([new]{style="COLOR: blue"} MyClass(005,[\"Bruch\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                         |
| [array.Add([new]{style="COLOR: blue"} MyClass(006,[\"Johny\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridlistControl1.DataSource = array;]{style="FONT-FAMILY: 'Courier New'"}                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                              |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                             |
|                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ array [As]{style="COLOR: blue"} ArrayList = [New]{style="COLOR: blue"} ArrayList()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [array.Add([New]{style="COLOR: blue"} \[MyClass\](1, [\"John David\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                 |
| [array.Add([New]{style="COLOR: blue"} \[MyClass\](2, [\"Tom\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                 |
| [array.Add([New]{style="COLOR: blue"} \[MyClass\](3, [\"Bretney\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                 |
| [array.Add([New]{style="COLOR: blue"} \[MyClass\](4, [\"Jessy\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                 |
| [array.Add([New]{style="COLOR: blue"} \[MyClass\](5, [\"Bruch\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                 |
| [array.Add([New]{style="COLOR: blue"} \[MyClass\](6, [\"Johny\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridlistControl1.DataSource = array]{style="FONT-FAMILY: 'Courier New'"}                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Selection Modes

 

The selection behavior for Grid List control can be specified by using SelectionMode property. There are 3 types of selection behaviors:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**One**--Allows the user to select only one item.

[·      ]{style="FONT-FAMILY: Symbol"}**MultiSimple**--Allows the user to select multiple items.

[·      ]{style="FONT-FAMILY: Symbol"}**MultiExtended**--Allows the user to select multiple items using SHIFT, CTRL, and

[·      ]{style="FONT-FAMILY: Symbol"}  arrow keys etc.          

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example illustrates setting of various selection behaviors for the Grid List control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridListControl1.SelectionMode = [SelectionMode]{style="COLOR: #2b91af"}.One;]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridListControl1.SelectionMode = [SelectionMode]{style="COLOR: #2b91af"}.MultiSimple;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridListControl1.SelectionMode = [SelectionMode]{style="COLOR: #2b91af"}.MultiExtended;]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridListControl1.SelectionMode = [SelectionMode.One]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridListControl1.SelectionMode = [SelectionMode.MultiSimple]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridListControl1.SelectionMode = [SelectionMode.MultiExtended]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p522} 

 

[]{#related-topics}
:::
