::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Animation {#animation style="tab-stops: 0pt"}

 

Rolling Gauge can be animated in both Clockwise and Anticlockwise directions.

 

 

::: {align="center"}
+----------------+------------------------------------------+-----------------------------+---------------------------------------------------+--------------------------------------------------+
| Property       | Description                              | Type of Property            | Value It Accepts                                  | Any other dependencies/Sub properties associated |
+----------------+------------------------------------------+-----------------------------+---------------------------------------------------+--------------------------------------------------+
| AnimationDelay | Sets the rotation delay of the Segments. | [int]{style="COLOR: blue"}  | [int]{style="COLOR: blue"}                        | [NA]{style="COLOR: #548dd4"}                     |
+----------------+------------------------------------------+-----------------------------+---------------------------------------------------+--------------------------------------------------+
| Direction      | Sets the direction of Rolling.           | [enum]{style="COLOR: blue"} | [Direction]{style="COLOR: #2b91af"}.AntiClockwise | [NA]{style="COLOR: #548dd4"}                     |
|                |                                          |                             |                                                   |                                                  |
|                |                                          |                             |                                                   |                                                  |
|                |                                          |                             |                                                   |                                                  |
|                |                                          |                             | [Direction]{style="COLOR: #2b91af"}.Clockwise     |                                                  |
+----------------+------------------------------------------+-----------------------------+---------------------------------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

 

::: {align="center"}
+-----------------+------------------------------------+------------------------------+---------------------------------------------------------------------------------------------+
| Name            | Parameters                         | Return Type                  | Description[]{style="COLOR: black"}                                                         |
+-----------------+------------------------------------+------------------------------+---------------------------------------------------------------------------------------------+
| SetValue        | [GaugeValue]{style="COLOR: black"} | [None]{style="COLOR: black"} | Sets the value dynamically.                                                                 |
|                 |                                    |                              |                                                                                             |
|                 |                                    |                              | [It can be called while changing the value of the gauge dynamically.]{style="COLOR: black"} |
|                 |                                    |                              |                                                                                             |
|                 |                                    |                              | []{style="COLOR: black"}                                                                    |
+-----------------+------------------------------------+------------------------------+---------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}ClockwiseRolling:](ms-xhelp:///?Id=6d4b2d60-3a65-488e-8484-34794b09405b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}AntiClockwiseRolling](ms-xhelp:///?Id=768f0612-b58a-4e57-bb97-5b0b37674c28){style="TEXT-DECORATION: none"}
:::::
