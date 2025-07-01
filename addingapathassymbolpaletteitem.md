::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding a path as SymbolPaletteItem {#adding-a-path-as-symbolpaletteitem style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To give a path as **SymbolPaletteItem** you can either create a **PathGeometry** in code behind or set the Data property of the path to **PathData** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

a)   The following code illustrates the adding of the path as **SymbolPaletteItem** using mini language geometry.

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                   |
| [// Adding Group in SymbolPalette]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                   |
| [SymbolPaletteGroup]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ group = [new]{style="COLOR: blue"} [SymbolPaletteGroup]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [            group.HeaderName = [\"Shapes\"]{style="COLOR: #a31515"};            diagramControl.SymbolPalette.SymbolGroups.Add(group);]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                   |
| [//Adding a SymbolPaletteItem]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                   |
| [SymbolPaletteItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ item1 = [new]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                   |
| [            item1.Width = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                   |
| [            item1.Height = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                   |
| [            item1.Name = [\"item1\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                   |
| [//Initialising Path]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                   |
| [            [Path]{style="COLOR: #2b91af"} path1 = [new]{style="COLOR: blue"} [Path]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                   |
| [            path1.Height = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                   |
| [            path1.Width = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                   |
| [            path1.Fill = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Blue);]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                   |
| [            path1.Stretch = [Stretch]{style="COLOR: #2b91af"}.Fill;]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                   |
| [            path1.Stroke = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Red);]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                   |
| [            path1.StrokeThickness = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                   |
| [            path1.Margin = [new]{style="COLOR: blue"} [Thickness]{style="COLOR: #2b91af"}(3);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                   |
| [//setting the path geometry to PathData]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                                   |
| [            item1.PathData = [\"M200,239L200,200 240,239 280,202 320,238 281,279 240,244 198,279z\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                   |
| [//setting path as content of SymbolPaletteItem]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                                                   |
| [            item1.Content = path1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                   |
| [            group.Items.Add(item1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                               |
| [\'Adding Group in SymbolPalette]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                               |
| [ [Dim]{style="COLOR: blue"} group [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [SymbolPaletteGroup]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                               |
| [                  [group]{style="COLOR: blue"}.HeaderName = \"Shapes\"]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                               |
| [                  diagramControl.SymbolPalette.SymbolGroups.Add(group)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                               |
| [    [\'Adding a SymbolPaletteItem]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                               |
| [    [Dim]{style="COLOR: blue"} item1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| [                  item1.Width = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                               |
| [                  item1.Height = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                               |
| [                  item1.Name = \"item1\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                               |
| [    [\'Initialising Path]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                               |
| [    [Dim]{style="COLOR: blue"} path1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Path]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                               |
| [                  path1.Height = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                               |
| [                  path1.Width = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                               |
| [                  path1.Fill = [New]{style="COLOR: blue"} SolidColorBrush(Colors.Blue)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                               |
| [                  path1.Stretch = Stretch.Fill]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                               |
| [                  path1.Stroke = [New]{style="COLOR: blue"} SolidColorBrush(Colors.Red)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                               |
| [                  path1.StrokeThickness = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                               |
| [                  path1.Margin = [New]{style="COLOR: blue"} Thickness(3)]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                               |
| [    [\'setting the path geometry to PathData]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                               |
| [                  item1.PathData = \"M200,239L200,200 240,239 280,202 320,238 281,279 240,244 198,279z\"]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                               |
| [    [\'setting path as content of SymbolPaletteItem]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                               |
| [                  item1.Content = path1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                               |
| [                  [group]{style="COLOR: blue"}.Items.Add(item1)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

b)   The following code illustrates the adding of path using Path Geometry.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                   |
| [// Adding Group in SymbolPalette]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                   |
| [SymbolPaletteGroup]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ group = [new]{style="COLOR: blue"} [SymbolPaletteGroup]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [            group.HeaderName = [\"Shapes\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                   |
| [            diagramControl.SymbolPalette.SymbolGroups.Add(group);]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                   |
| [//Adding a SymbolPaletteItem]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                  |
|                                                                                                                                                                                                   |
| [            [SymbolPaletteItem]{style="COLOR: #2b91af"} item = [new]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                   |
| [            item.Width = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                   |
| [            item.Height = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                   |
| [            item.Name = [\"item\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [//Initialising a Path]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                   |
| [            [Path]{style="COLOR: #2b91af"} path = [new]{style="COLOR: blue"} [Path]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                   |
| [//Initialising a PathGeometry]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                   |
| [            [PathGeometry]{style="COLOR: #2b91af"} geo = [new]{style="COLOR: blue"} [PathGeometry]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                   |
| [            [PathFigure]{style="COLOR: #2b91af"} pathfig = [new]{style="COLOR: blue"} [PathFigure]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                   |
| [            pathfig.StartPoint = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(0, 0);]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                   |
| [//Adding line segments to path figure]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                         |
|                                                                                                                                                                                                   |
| [            [LineSegment]{style="COLOR: #2b91af"} line = [new]{style="COLOR: blue"} [LineSegment]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                   |
| [            line.Point = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(-3, -7);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                   |
| [            pathfig.Segments.Add(line);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                   |
| [            line = [new]{style="COLOR: blue"} [LineSegment]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                   |
| [            line.Point = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(-3, -15);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                   |
| [            pathfig.Segments.Add(line);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                   |
| [            line = [new]{style="COLOR: blue"} [LineSegment]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                   |
| [            line.Point = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(3, -15);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                   |
| [            pathfig.Segments.Add(line);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                   |
| [            line = [new]{style="COLOR: blue"} [LineSegment]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                   |
| [            line.Point = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(3, -7);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                   |
| [            pathfig.Segments.Add(line);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                   |
| [            pathfig.IsClosed = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [            geo.Figures.Add(pathfig);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                   |
| [            path.Data = geo;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                   |
| [            path.Height = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                   |
| [            path.Width = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                   |
| [            path.Fill = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Red);]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                   |
| [            path.Stretch = [Stretch]{style="COLOR: #2b91af"}.Fill;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                   |
| [            path.Stroke = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Blue);]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                   |
| [            path.StrokeThickness = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                   |
| [            path.Margin = [new]{style="COLOR: blue"} [Thickness]{style="COLOR: #2b91af"}(3);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                   |
| [//setting path as the content of SymbolPaletteItem]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                            |
|                                                                                                                                                                                                   |
| [            item.Content = path;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                   |
| [            group.Items.Add(item);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                |
| [   \'Adding Group in SymbolPalette]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                |
| [    [Dim]{style="COLOR: blue"} group [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [SymbolPaletteGroup]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [                  [group]{style="COLOR: blue"}.HeaderName = \"Shapes\"]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                |
| [                  diagramControl.SymbolPalette.SymbolGroups.Add(group)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                |
| [    [\'Adding a SymbolPaletteItem]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                |
| [    [Dim]{style="COLOR: blue"} item [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                |
| [                  item.Width = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                |
| [                  item.Height = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                |
| [                  item.Name = \"item\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                |
| [    [\'Initialising a Path]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                |
| [    [Dim]{style="COLOR: blue"} path [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Path]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                |
| [    [\'Initialising a PathGeometry]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                |
| [    [Dim]{style="COLOR: blue"} geo [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [PathGeometry]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                |
| [    [Dim]{style="COLOR: blue"} pathfig [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [PathFigure]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                |
| [                  pathfig.StartPoint = [New]{style="COLOR: blue"} Point(0, 0)]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                |
| [    [\'Adding line segments to path figure]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| [    [Dim]{style="COLOR: blue"} line [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [LineSegment]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                |
| [                  line.Point = [New]{style="COLOR: blue"} Point(-3, -7)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                |
| [                  pathfig.Segments.Add(line)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                |
| [                  line = [New]{style="COLOR: blue"} LineSegment()]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| [                  line.Point = [New]{style="COLOR: blue"} Point(-3, -15)]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                |
| [                  pathfig.Segments.Add(line)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                |
| [                  line = [New]{style="COLOR: blue"} LineSegment()]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| [                  line.Point = [New]{style="COLOR: blue"} Point(3, -15)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                |
| [                  pathfig.Segments.Add(line)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                |
| [                  line = [New]{style="COLOR: blue"} LineSegment()]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                |
| [                  line.Point = [New]{style="COLOR: blue"} Point(3, -7)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                |
| [                  pathfig.Segments.Add(line)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                |
| [                  pathfig.IsClosed = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                |
| [                  geo.Figures.Add(pathfig)]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                |
| [                  path.Data = geo]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                |
| [                  path.Height = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                |
| [                  path.Width = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                |
| [                  path.Fill = [New]{style="COLOR: blue"} SolidColorBrush(Colors.Red)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                |
| [                  path.Stretch = Stretch.Fill]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                |
| [                  path.Stroke = [New]{style="COLOR: blue"} SolidColorBrush(Colors.Blue)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                |
| [                  path.StrokeThickness = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                |
| [                  path.Margin = [New]{style="COLOR: blue"} Thickness(3)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                |
| [    [\'setting path as the content of SymbolPaletteItem]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                |
| [                  item.Content = path]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                |
| [                  [group]{style="COLOR: blue"}.Items.Add(item)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[]{#p97} 

[]{#related-topics}
:::
