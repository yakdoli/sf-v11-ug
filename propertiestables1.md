::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties Tables[]{style="FONT-WEIGHT: normal"} {#properties-tables style="tab-stops: 0pt"}

 

::: {align="center"}
+------------------------------------+--------------------------+--------------+-----------------------------+-------------------------------------------------------------------+
| **Property**                       | **Description**          | **Type**     | **Value it Accepts**        | **Dependencies**                                                  |
+------------------------------------+--------------------------+--------------+-----------------------------+-------------------------------------------------------------------+
| EditMode[]{style="COLOR: #c00000"} | Specifies the edit mode. | GridEditMode | Normal                      | Depends on AllowEditing---                                        |
|                                    |                          |              |                             |                                                                   |
|                                    |                          | (Enum)       | []{style="COLOR: #c00000"}  | If AllowEditing is set to True, the EditMode property is enabled. |
+------------------------------------+--------------------------+--------------+-----------------------------+-------------------------------------------------------------------+
:::

** Commands properties:**

::: {align="center"}
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| **Property** | **Description**                                   | **Type**           | **Value it Accepts** | **Dependencies**                                                  |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| Command      | Specifies the grid command types.                 | CommandTypes       | AddNew               | Depends on AllowEditing---                                        |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | Edit                 | If AllowEditing is set to True, the EditMode property is enabled. |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | Update               |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | Delete               |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | Cancel               |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | Custom               |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| Text         | Specifies the text of the grid commands.          | NA                 | String               | Depends on AllowEditing---                                        |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      | If AllowEditing is set to True, the EditMode property is enabled. |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| ImageUrl     | Specifies the image for grid commands.            | NA                 | Image String         | Depends on AllowEditing---                                        |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      | If AllowEditing is set to True, the EditMode property is enabled. |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| ItemType     | Specifies the UnBoundItemTypes of grid commands.  | UnBoundItemTypes   | Hyperlink            | Depends on AllowEditing---                                        |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | Button               | If AllowEditing is set to True, the EditMode property is enabled. |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| ItemOption   | Specifies the UnBoundItemOptions of grid commands | UnboundItemOptions | TextOnly             | Depends on AllowEditing---                                        |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      | If AllowEditing is set to True, the EditMode property is enabled. |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | ImageOnly            |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    | ImagePlusText        |                                                                   |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
| UnBound      | Specifies the column of grid commands             | Boolean            | True or False        | NA                                                                |
|              |                                                   |                    |                      |                                                                   |
|              |                                                   |                    |                      |                                                                   |
+--------------+---------------------------------------------------+--------------------+----------------------+-------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
:::::
