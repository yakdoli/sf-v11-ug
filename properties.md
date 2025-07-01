::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties {#properties style="tab-stops: 0pt"}

 

+-------------------------+----------------------------------------------------------+------------------+---------------------------------------------+------------------------------------------------------------------------------------------+
| Property                | Description                                              | Type of Property | Value it accepts                            | Dependencies                                                                             |
+-------------------------+----------------------------------------------------------+------------------+---------------------------------------------+------------------------------------------------------------------------------------------+
| AllowExpressionFilter   | Specifies if the Expression filter feature is enabled    | bool             | [·      ]{style="FONT-FAMILY: Symbol"}True  | Depends on ShowFilterBar and                                                             |
|                         |                                                          |                  |                                             |                                                                                          |
|                         |                                                          |                  | [·      ]{style="FONT-FAMILY: Symbol"}False | ShowFilterBarTextCell---                                                                 |
|                         |                                                          |                  |                                             |                                                                                          |
|                         |                                                          |                  |                                             | only if both these properties are enabled, the AllowExpressionFilter property is enabled |
+-------------------------+----------------------------------------------------------+------------------+---------------------------------------------+------------------------------------------------------------------------------------------+
| ShowFilterStatusMessage | Specifies if the Filter status message is enabled or not | bool             | [·      ]{style="FONT-FAMILY: Symbol"}True  | Depends on                                                                               |
|                         |                                                          |                  |                                             |                                                                                          |
|                         |                                                          |                  | [·      ]{style="FONT-FAMILY: Symbol"}False | ShowFilterStatusMessage---                                                               |
|                         |                                                          |                  |                                             |                                                                                          |
|                         |                                                          |                  |                                             | only if this property is enabled, ShowFilterStatusMessage is enabled.                    |
+-------------------------+----------------------------------------------------------+------------------+---------------------------------------------+------------------------------------------------------------------------------------------+
| FilterStatusBarWidth    | Specifies the width of the filter status bar             | int              | Any integer value                           | Depends on ShowFilterStatusMessage---                                                    |
|                         |                                                          |                  |                                             |                                                                                          |
|                         |                                                          |                  |                                             | Only if ShowFilterStatusMessage is enabled, FilterStatusBarWidth is enabled              |
+-------------------------+----------------------------------------------------------+------------------+---------------------------------------------+------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
