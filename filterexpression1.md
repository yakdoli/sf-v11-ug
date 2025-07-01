::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Filter Expression {#filter-expression style="tab-stops: 0pt"}

This class encapsulates the information needed to define a filter. It contains the following properties.

+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 |                             |                |
| Property Name | Description                                                                         | Type            | Value it Accepts            | Reference link |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 |                             |                |
+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+
| CaseSensitive | Gets or sets whether the expression should be treated in a case sensitive manner.   | bool            | True or False               | \-             |
+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+
| Error         | Gets the last error that was logged during the compilation and calculation phases.  | ExpressionError | CannotCompareDifferentTypes | \-             |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 | ExceptionRaised             |                |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 | MismatchedParentheses       |                |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 | MissingRightQuote           |                |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 | None                        |                |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 | NotAValidFormula            |                |
|               |                                                                                     |                 |                             |                |
|               |                                                                                     |                 | UnknownOperator             |                |
+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+
| ErrorString   | Gets a descriptive string for the last error raised.                                | string          | \-                          | \-             |
+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+
| Expression    | Gets or sets the well-formed logical expression that defines this FilterExpression. | string          | \-                          | \-             |
+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+
| Name          | Gets or sets the name of this FilterExpression.                                     | string          | \-                          | \-             |
+---------------+-------------------------------------------------------------------------------------+-----------------+-----------------------------+----------------+

[]{#related-topics}
:::
