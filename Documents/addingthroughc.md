::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding through C#

The following code example illustrates how to add the TileViewControl to an Application through C#.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                        |
| [            TileViewControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ Tile = [new]{style="COLOR: blue"} [TileViewControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [            Tile.Width = 500;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                        |
| [            Tile.Height = 400;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                        |
| [            [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} i = 1; i \<= 4; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                        |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                        |
| [                [TileViewItem]{style="COLOR: #2b91af"} item1 = [new]{style="COLOR: blue"} [TileViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                        |
| [                item1.Name = [\"item\"]{style="COLOR: #a31515"} + i;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                        |
| [                item1.Header = [\"Item \"]{style="COLOR: #a31515"} + i;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                        |
| [                item1.Content = [\"Content \"]{style="COLOR: #a31515"} + i;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                        |
| [                Tile.Items.Add(item1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                        |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                        |
| [            [this]{style="COLOR: blue"}.LayoutRoot.Children.Add(Tile);]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                        |
|                                                                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

![](../ImagesExt/image261_758.jpg){border="0"}

Figure 852: TileViewControl Sample application

 

[]{#related-topics}
:::
