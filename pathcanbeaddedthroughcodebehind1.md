::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Path can be added through Code Behind {#path-can-be-added-through-code-behind style="tab-stops: 0pt"}

Run the application, the path will be displayed.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [                [MapPath]{style="COLOR: #2b91af"} path = [new]{style="COLOR: blue"} [MapPath]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                |
| [                path.PathPoints.Add(([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} { X = -68, Y = -24 }));]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                |
| [                path.PathPoints.Add(([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} { X = 98, Y = 40 }));]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                |
| [                path.PathPoints.Add(([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} { X = 34, Y = 62 }));]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                |
| [                path.PathPoints.Add(([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} { X = -101, Y = 59 }));]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                |
| [                path.LabelPoint = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} { X = 98, Y = 40 };]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                |
| [                path.PathLabel = [\"MapPAth\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                |
| [                path.PathLabelPosition = [PathLabelPosition]{style="COLOR: #2b91af"}.OnMiddlePoint;]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                |
| [                path.PathColor = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Black);]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                |
| [                path.PathLabelForeground = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Black);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [                shapeControl.MapPathCollection.Add(path);              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
