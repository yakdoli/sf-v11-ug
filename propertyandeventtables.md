::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Property and Event Tables {#property-and-event-tables style="tab-stops: 0pt"}

 

Properties

+-------------+-----------------------------------------------------------------------------------+---------------------+------------------------------------------------------------+----------------------------------------+
| Property    | Description                                                                       | Type of Property    | Value it Accepts                                           | Dependencies                           |
+-------------+-----------------------------------------------------------------------------------+---------------------+------------------------------------------------------------+----------------------------------------+
| ItemType    | Gets or sets the type of content to be added as a symbol into the symbol palette. | Dependency property | Enum:                                                      | No (This is not supported in SVG Mode) |
|             |                                                                                   |                     |                                                            |                                        |
|             |                                                                                   |                     | [·      ]{style="FONT-FAMILY: Symbol"}ItemType.Content     |                                        |
|             |                                                                                   |                     |                                                            |                                        |
|             |                                                                                   |                     | [·      ]{style="FONT-FAMILY: Symbol"}ItemType.CustomShape |                                        |
|             |                                                                                   |                     |                                                            |                                        |
|             |                                                                                   |                     |                                                            |                                        |
+-------------+-----------------------------------------------------------------------------------+---------------------+------------------------------------------------------------+----------------------------------------+

 

 

Events

  Event                            Description                                                              Arguments                                       Type
  -------------------------------- ------------------------------------------------------------------------ ----------------------------------------------- -------------------
  ClientSideOnCustomShapeDrawing   Raised when the custom shape is added. This event cannot be cancelled.   Node---The node on which the event is raised.   Client-side event

 

 

[]{#related-topics}
:::
