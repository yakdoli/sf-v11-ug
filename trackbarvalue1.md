::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### TrackBar Value {#trackbar-value style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The TrackBarEx control slides between the minimum and maximum values, which are specified in **Minimum** and **Maximum** properties. The properties with description are listed in the below table.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  -------------- -----------------------------------------------------------------------------------
  Property       Description
  Minimum        Specifies the minimum value of the trackbar. Default is 10.
  Maximum        Specifies the maximum value of the trackbar. Default is 20.
  Value          Specifies the value of the trackbar position. i.e, slider position. Default is 5.
  SmallChange    Specifies the small change of Trackbar value. Default is 1.
  LargeChange    Specifies the large change of Trackbar value. Default is 5.
  TimeInterval   Specifies the interval for the timer. Default is 100.
  -------------- -----------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                 |
|                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.Minimum = 10;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.Maximum = 25;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.Value = 5;]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.SmallChange = 5;]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.LargeChange = 15;]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.TimerInterval = 50;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                               |
|                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                              |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.Minimum = 10]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.Maximum = 30]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.Value = 5]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.SmallChange = 5]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.LargeChange = 15]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.trackBarEx1.TimerInterval = 50]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Following are the methods for the TrackBarEx control which gives the respective results based on SmallChange and LargeChange properties.[]{#p1194}

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------------- ----------------------------------------------------------------------------
  Methods         Description
  LargeIncrease   Increases the value by large change specified in **LargeChange** property.
  LargeDecrease   Decreases the value by large change specified in **LargeChange** property.
  SmallDecrease   Decreases the value by small change specified in **SmallChange** property.
  SmallIncrease   Increases the value by small change specified in **SmallChange** property.
  --------------- ----------------------------------------------------------------------------
:::

 

[]{#related-topics}
:::::
