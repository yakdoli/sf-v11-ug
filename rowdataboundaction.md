::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### RowDataBound Action {#rowdatabound-action style="tab-stops: 0pt"}

 

Grid formatting can be applied to different grid row elements dynamically at run time. This can be achieved by **RowDataBound** action. It provides the **Htmlattributes** object for a cell on demand.

**RowDataBound** is raised every time a request is made to access the style information for a row. You can do any type of row formatting with this event.

It accepts **GridTableRow\<T\>** as its parameter which can be used to customize the rows of the Grid control.

The following table describes the **GridTableRow\<T\>** properties:

Properties

 

 

::: {align="center"}
+----------------+--------------------------------------------------------+------------------------------+----------------------+--------------------------------------------------+
| Property       | Description                                            | Type of the property         | Value it accepts     | Any other dependencies/sub-properties associated |
+----------------+--------------------------------------------------------+------------------------------+----------------------+--------------------------------------------------+
| Data           | Gets or sets Data for the current row.                 | Generic T                    | Any data             | NA                                               |
+----------------+--------------------------------------------------------+------------------------------+----------------------+--------------------------------------------------+
| HtmlAttributes | Gets or sets the Htmlattributes for customizing cells. | IDictionary\<string,object\> | Any dictionary value | NA                                               |
|                |                                                        |                              |                      |                                                  |
|                |                                                        |                              |                      |                                                  |
+----------------+--------------------------------------------------------+------------------------------+----------------------+--------------------------------------------------+
| IsAlternate    | Indicates whether the record row is alternate.         | Boolean                      | True/False           | NA                                               |
|                |                                                        |                              |                      |                                                  |
|                |                                                        |                              |                      |                                                  |
+----------------+--------------------------------------------------------+------------------------------+----------------------+--------------------------------------------------+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=340f09c7-4731-4ba8-8193-a1169211d0b1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=8f42e228-7bc5-42ef-9018-8f4fde8ce837){style="TEXT-DECORATION: none"}
::::
