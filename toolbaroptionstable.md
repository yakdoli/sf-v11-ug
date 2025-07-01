::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ToolbarOptions Table {#toolbaroptions-table style="tab-stops: 0pt"}

 

The following table gives the properties of the **ToolbarOptions** class.

 

::: {align="center"}
+---------------------------------------------------------+---------------------------------------------------------------------------------+----------------------------------------------------------------------+-------------------------+--------------------------------------------------+
| Property                                                | Description                                                                     | Type of property                                                     | Value it accepts        | Any other dependencies/sub-properties associated |
+=========================================================+=================================================================================+======================================================================+=========================+==================================================+
| ItemType                                                | Gets or sets the item type of the toolbar                                       | [Enum]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} | GridToolBarItems.AddNew |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      | GridToolBarItems.Delete |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      | GridToolBarItems.Cancel |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      | GridToolBarItems.Edit   |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      | GridToolBarItems.Update |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      | GridToolBarItems.Custom |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      | GridToolBarItems.Export |                                                  |
+---------------------------------------------------------+---------------------------------------------------------------------------------+----------------------------------------------------------------------+-------------------------+--------------------------------------------------+
| Caption                                                 | Gets or sets the caption for the toolbar item.                                  | string                                                               | string                  |                                                  |
+---------------------------------------------------------+---------------------------------------------------------------------------------+----------------------------------------------------------------------+-------------------------+--------------------------------------------------+
| Title                                                   | Gets or sets the title for the toolbar item.                                    | string                                                               | string                  |                                                  |
+---------------------------------------------------------+---------------------------------------------------------------------------------+----------------------------------------------------------------------+-------------------------+--------------------------------------------------+
| [CssClass]{style="FONT-FAMILY: 'Calibri','sans-serif'"} | Gets or sets the Custom Css class for applying the custom style for that item   | string                                                               | string                  |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
|                                                         |                                                                                 |                                                                      |                         |                                                  |
+---------------------------------------------------------+---------------------------------------------------------------------------------+----------------------------------------------------------------------+-------------------------+--------------------------------------------------+
| Mapper                                                  | Gets or sets the mapper for the toolbar item when the ItemType is set to Export | List\<ToolbarOptions\>                                               | Any toolbar items       |  ItemType                                        |
+---------------------------------------------------------+---------------------------------------------------------------------------------+----------------------------------------------------------------------+-------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
::::
