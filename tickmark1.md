::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### TickMark {#tickmark style="tab-stops: 0pt"}

 

This feature allows you to display the tick mark for the slider control.

+--------------------+---------------------------------------------+------------------+---------------------------------------------------------------------------------------------+----------------+
| Name               | Description                                 | Type of property | Value it accepts                                                                            | Dependency     |
+--------------------+---------------------------------------------+------------------+---------------------------------------------------------------------------------------------+----------------+
| EnableTickMark     | Used to enable the Tick Mark                | Bool             | True/false                                                                                  | NA             |
+--------------------+---------------------------------------------+------------------+---------------------------------------------------------------------------------------------+----------------+
| SliderTickPosition | Used to set the position for the TickMark   | Enum             | [TickPosition]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}.BottomRight | EnableTickMark |
|                    |                                             |                  |                                                                                             |                |
|                    |                                             |                  | [TickPosition]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}.Centre      |                |
|                    |                                             |                  |                                                                                             |                |
|                    |                                             |                  | [TickPosition]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}.TopLeft     |                |
+--------------------+---------------------------------------------+------------------+---------------------------------------------------------------------------------------------+----------------+
| TickFrequency      | Used to set the interval for the tick marks | Int              | 0 to int MaxValue                                                                           | EnableTickMark |
+--------------------+---------------------------------------------+------------------+---------------------------------------------------------------------------------------------+----------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=1f8ffef8-0939-4d5e-a71a-5d3a306b4ac5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using Properties Model](ms-xhelp:///?Id=085f3c76-262c-442f-8617-1b8260bc4fb5){style="TEXT-DECORATION: none"}
:::
