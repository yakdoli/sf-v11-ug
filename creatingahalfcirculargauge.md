::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Creating a Half Circular Gauge {#creating-a-half-circular-gauge style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Half Circular Gauge can be created by setting the CircularGaugeModel class's Frame**Type** property to HalfCircle.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
+-------------------------------+----------------------------------------------------+-------------------------------+----------------------------------------------------------------------------------+--------------------------------------------------+
| Property                      | Description                                        | Type of Property              | Value It Accepts                                                                 | Any other dependencies/Sub properties associated |
+-------------------------------+----------------------------------------------------+-------------------------------+----------------------------------------------------------------------------------+--------------------------------------------------+
| HalfCircleInnerRadius         | Sets the Radius of the inner half circle.          | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"}                                                    | Dependency(when FrameType is set to HalfCircle)  |
+-------------------------------+----------------------------------------------------+-------------------------------+----------------------------------------------------------------------------------+--------------------------------------------------+
| HalfCircleInnerSweepDirection | Sets the sweep direction of the inner half circle. | [enum]{style="COLOR: blue"}   | [SweepDirection]{style="COLOR: #2b91af"}.Clockwise                               | Dependency(when FrameType is set to HalfCircle)  |
|                               |                                                    |                               |                                                                                  |                                                  |
|                               |                                                    |                               |                                                                                  |                                                  |
|                               |                                                    |                               |                                                                                  |                                                  |
|                               |                                                    |                               | [SweepDirection]{style="COLOR: #2b91af"}.Counterclockwise                        |                                                  |
+-------------------------------+----------------------------------------------------+-------------------------------+----------------------------------------------------------------------------------+--------------------------------------------------+
| HalfCircleSweepDirection      | Sets the sweep direction of the half circle.       | [enum]{style="COLOR: blue"}   | [SweepDirection]{style="COLOR: #2b91af"}.Clockwise                               | Dependency(when FrameType is set to HalfCircle)  |
|                               |                                                    |                               |                                                                                  |                                                  |
|                               |                                                    |                               | [SweepDirection]{style="COLOR: #2b91af"}.Counterclockwise[]{style="COLOR: blue"} |                                                  |
+-------------------------------+----------------------------------------------------+-------------------------------+----------------------------------------------------------------------------------+--------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through View Customization](ms-xhelp:///?Id=c867ac62-bf5d-4784-9a23-f22c4299cc03){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through CircularGaugeModel](ms-xhelp:///?Id=a642ed34-0822-4d90-b80e-25f6f2161d73){style="TEXT-DECORATION: none"}
::::
