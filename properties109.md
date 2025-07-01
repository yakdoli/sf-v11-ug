::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties {#properties style="tab-stops: 0pt"}

+-------------+-----------------------------------------------+--------------------+------------------------------------------------------------+------------------------------------------------------------------------------+
| Property    | Description                                   | Type of property   | Value it accepts                                           | Dependencies                                                                 |
+-------------+-----------------------------------------------+--------------------+------------------------------------------------------------+------------------------------------------------------------------------------+
| EditMode    | Specifies the Edit Mode                       | GridEditMode(Enum) | [·      ]{style="FONT-FAMILY: Symbol"}ExternalForm         | Depends on AllowEditing---\                                                  |
|             |                                               |                    |                                                            | \                                                                            |
|             |                                               |                    | [·      ]{style="FONT-FAMILY: Symbol"}ExternalFormTemplate |                                                                              |
|             |                                               |                    |                                                            | If AllowEditing is set to **True**, the EditMode property is enabled.        |
+-------------+-----------------------------------------------+--------------------+------------------------------------------------------------+------------------------------------------------------------------------------+
| Position    | Specifies position of the external form       | Enum               | [·      ]{style="FONT-FAMILY: Symbol"}Position.TopRight,   | Depends on **ExternalForm**---                                               |
|             |                                               |                    |                                                            |                                                                              |
|             |                                               |                    | [·      ]{style="FONT-FAMILY: Symbol"}Position.BottomLeft, |                                                                              |
|             |                                               |                    |                                                            |                                                                              |
|             |                                               |                    | [·      ]{style="FONT-FAMILY: Symbol"}Position.Custom      | If GridEditMode is External Form, position of the external form is posibile. |
+-------------+-----------------------------------------------+--------------------+------------------------------------------------------------+------------------------------------------------------------------------------+
| TargetID    | Specifies the target ID of External Edit Form | String             | Any String                                                 | ExternalForm                                                                 |
+-------------+-----------------------------------------------+--------------------+------------------------------------------------------------+------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
