::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Properties Deprecated {#properties-deprecated style="tab-stops: 0pt"}

+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+
| Property                                                      | Alternatives                 | Comments                                                                                                                       |
+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+
| [[NullState]{style="COLOR: #15428b"}]{.MsoSubtleEmphasis}     | IsNull                       | Deprecated as it should have Getter alone.                                                                                     |
+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+
| [[UseNullString]{style="COLOR: #15428b"}]{.MsoSubtleEmphasis} | AllowNull                    | This behavior is incorporated with AllowNull; previously both AllowNull and UseNullString existed. Removed for better clarity. |
+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+
| [[IsNullValue]{style="COLOR: #15428b"}]{.MsoSubtleEmphasis}   | IsNull                       | IsNullValue means the same as NullState and IsNull, and it has been deprecated for better clarity.                             |
+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+
| [[MaxLength]{style="FONT-STYLE: normal"}]{.MsoSubtleEmphasis} | MaxValue,                    |                                                                                                                                |
|                                                               |                              |                                                                                                                                |
|                                                               | NumberDecimalDigits          |                                                                                                                                |
|                                                               |                              |                                                                                                                                |
|                                                               |                              | Max length is removed as there is a conflict. Hence use MaxValue and NumberDecimalDigits as alternatives.                      |
+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+
| EnforceMinMaxDuringValidating                                 | OnValidationFailed.KeepFocus | No need for a separate property                                                                                                |
|                                                               |                              |                                                                                                                                |
|                                                               |                              | as MinMaxValidation already exists                                                                                             |
|                                                               |                              |                                                                                                                                |
|                                                               |                              | The same behavior can be achieved with the alternative.                                                                        |
+---------------------------------------------------------------+------------------------------+--------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
