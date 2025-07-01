::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Get TreeViewItem Path

TreeViewAdv provides support to get the path of TreeViewItem using the following methods.

GetPath(TreeViewItemAdv Arg1, char Arg2)

GetPath(TreeViewItemAdv Arg1,char Arg2, string Arg3)

+-------------+-------------------------------------------------------------------------------------+----------------------------------------------------------------------------------+-----------------------------------------------------------------------------------+-----------------+
| Method      | Description                                                                         | Overloads                                                                        | Return Type                                                                       | Reference links |
+-------------+-------------------------------------------------------------------------------------+----------------------------------------------------------------------------------+-----------------------------------------------------------------------------------+-----------------+
| GetPath()   | Gets the path of a particular TreeViewItem.                                         |  (+2) Overloads                                                                  | String (Path of the TreeViewItemAdv if it exists in that particular TreeViewAdv.) |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Argument 1: (TreeViewItemAdv)                                                    |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Indicates the path from the root node of the TreeViewItem that will be returned. |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Argument 2:                                                                      |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | (Char) Denotes the PathSeparator.                                                |                                                                                   |                 |
+-------------+-------------------------------------------------------------------------------------+----------------------------------------------------------------------------------+-----------------------------------------------------------------------------------+-----------------+
| GetPath()   | Gets the path of a particular TreeViewItem when it is binded with business objects. | (+2) Overloads                                                                   | String (Path of the TreeViewItemAdv if it exists in that particular TreeViewAdv.) |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Argument 1: (TreeViewItemAdv)                                                    |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Indicates the path from the root node of the TreeViewItem that will be returned. |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Argument 2:                                                                      |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | (Char) Denotes the PathSeparator.                                                |                                                                                   |                 |
|             |                                                                                     |                                                                                  |                                                                                   |                 |
|             |                                                                                     | Argument 3: (string) Parses the business object to get the item path.            |                                                                                   |                 |
+=============+=====================================================================================+==================================================================================+===================================================================================+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
