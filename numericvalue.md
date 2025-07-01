::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Numeric Value {#numeric-value style="tab-stops: 0pt"}

 

Rolling Gauge can be restricted to display only the numeric values.

 

 

::: {align="center"}
+-------------+----------------------------------------------------------------------------------------+-------------------------------+-------------------------------+------------------------------------------------------+
| Property    | Description                                                                            | Type of Property              | Value It Accepts              | Any other dependencies/Sub properties associated     |
+-------------+----------------------------------------------------------------------------------------+-------------------------------+-------------------------------+------------------------------------------------------+
| IsNumeric   | Sets to accept only the numeric values.                                                | [bool]{style="COLOR: blue"}   | [True]{style="COLOR: blue"}   | NA                                                   |
|             |                                                                                        |                               |                               |                                                      |
|             |                                                                                        |                               | []{style="COLOR: blue"}       |                                                      |
|             |                                                                                        |                               |                               |                                                      |
|             |                                                                                        |                               | [false]{style="COLOR: blue"}  |                                                      |
+-------------+----------------------------------------------------------------------------------------+-------------------------------+-------------------------------+------------------------------------------------------+
| MaxValue    | If IsNumeric is set to true then the MaxValue Property acts as MaximunRange for Value. | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"} | Dependency Property(dependent on IsNumeric property) |
+-------------+----------------------------------------------------------------------------------------+-------------------------------+-------------------------------+------------------------------------------------------+
| MinValue    | If IsNumeric is set to true then the MinValue Property acts as MinimumRange for Value. | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"} | Dependency Property(dependent on IsNumeric property) |
+-------------+----------------------------------------------------------------------------------------+-------------------------------+-------------------------------+------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through View Customization](ms-xhelp:///?Id=8fc48c24-4ab5-4a93-adf3-f366cd748b39){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through RollingGaugeModel](ms-xhelp:///?Id=3e3fbbae-513f-4b1d-839e-944086a56990){style="TEXT-DECORATION: none"}
::::
