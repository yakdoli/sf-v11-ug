::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Behavior Settings {#behavior-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Display Speed

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **CharDelay** property can be set to change the speed of the ticker control. It accepts the duration in milliseconds. By default it will take the value as **100 milliseconds**. The speed with which it displays decreases with increase in value.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

AutoStart

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The text can be set such that it would display character by character, on page load by enabling the **AutoStart** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Loop and Delay Settings

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The text display can be repeated in cycles by setting the **Loop** property, thereby iteratively displaying the text.

The time interval for which the full text should be displayed before recurring the next loop can be quantified using **LineDelay** property. By default it will take the value as **100 milliseconds**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------- -------------------------------------------------------------------------------------------------------------------
  Property    Description
  AutoStart   Specifies whether the scroll should automatically start when the page gets loaded. Default value is true.
  CharDelay   Specifies the interval between each character. Default value is 100.
  LineDelay   Specifies the time interval before starting to repeat the loop. Default value is 100.
  Loop        Specifies whether to repeat the slides after a complete tour of slides has been exhibited. Default value is true.
  ----------- -------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Programmatically the properties can be set as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                         |
|                                                                                                        |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                               |
|                                                                                                        |
| [ticker1.CharDelay = 100;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                         |
|                                                                                                        |
| [ticker1.AutoStart = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                        |
| [ticker1.Loop = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}      |
|                                                                                                        |
| [ticker1.LineDelay = 200;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                         |
+--------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                         |
|                                                                                                        |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                               |
|                                                                                                        |
| [ticker1.CharDelay = 100;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                         |
|                                                                                                        |
| [ticker1.AutoStart = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                        |
| [ticker1.Loop = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}      |
|                                                                                                        |
| [ticker1.LineDelay = 200;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                         |
+--------------------------------------------------------------------------------------------------------+

[]{#p472} 

[]{#related-topics}
::::
