::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Behavior Settings {#behavior-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The behavior of the jQueryUISlider is controlled by using the following properties.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Animate                           | Slides the handle smoothly when the user clicks the outside handle on the bar. The default value is false. |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Max                               | Sets the maximum value for the slider. The default value is 0.                                             |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Min                               | Sets the minimum value for the slider. The default value is 100.                                           |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Value                             | Sets the initial value of the slider.                                                                      |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Values                            | Sets the initial values for the range slider.                                                              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Step                              | Sets the step value for the slider. The default value is 1.                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Orientation                       | Sets the orientation of the slider. The options included are as follows.                                   |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Auto                                                                 |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Horizontal                                                           |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Vertical                                                             |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Range                             | Sets the range of the slider. The options included are as follows.                                         |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Min                                                                  |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Max                                                                  |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NoRange                                                              |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Range                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[jQueryUISlider]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"jQueryUISlider1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [Animate]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"} [Max]{style="COLOR: red"}[=\"1000\"]{style="COLOR: blue"} [Min]{style="COLOR: red"}[=\"0\"]{style="COLOR: blue"} [Step]{style="COLOR: red"}[=\"100\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"500\"]{style="COLOR: blue"} [Orientation]{style="COLOR: red"}[=\"Horizontal\"]{style="COLOR: blue"} [Range]{style="COLOR: red"}[=\"Min\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+---------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                  |
|                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                               |
|                                                                                                   |
| [jQueryUISlider1.Animate = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                   |
| [jQueryUISlider1.Max = 1000;]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                   |
| [jQueryUISlider1.Min = 0;]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                   |
| [jQueryUISlider1.Step = 100;]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                   |
| [jQueryUISlider1.Value = 500;]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                   |
| [jQueryUISlider1.Orientation = SliderOrientation.Horizontal;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                   |
| [jQueryUISlider1.Range = SliderRange.Min;]{style="FONT-FAMILY: 'Courier New'"}                    |
+---------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                               |
|                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                            |
|                                                                                                |
| [jQueryUISlider1.Animate=[True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                |
| [jQueryUISlider1.Max=1000]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                |
| [jQueryUISlider1.Min=0]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                |
| [jQueryUISlider1.Step=100]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                |
| [jQueryUISlider1.Value=500]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                |
| [jQueryUISlider1.Orientation=SliderOrientation.Horizontal]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                |
| [jQueryUISlider1.Range=SliderRange.Min]{style="FONT-FAMILY: 'Courier New'"}                    |
+------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                          |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                       |
|                                                                                                                                                                           |
| [jQueryUISlider1.Range = SliderRange.Range;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                           |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] arr = [new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[2\]{30,70};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [jQueryUISlider1.Values=arr;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                    |
|                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [jQueryUISlider1.Range = SliderRange.Range]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ arr [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}() = [New]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}(2) {30, 70}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                     |
| [jQueryUISlider1.Values = arr]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
