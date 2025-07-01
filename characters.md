::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Characters {#characters style="tab-stops: 0pt"}

 

Digital Gauge can display either numbers or characters,or both by using the **Value** property. The default value is **String.Empty**. The number of characters that the Digital Gauge should display is set by using **CharacterCount** property.

Digital gauge provides two character type segments:

[·      ]{style="FONT-FAMILY: Symbol"}Seven-Segment Display-A seven segment display is composed of seven elements which can be combined to produce simplified representations to aid readability for numerals and certain letters.

[·      ]{style="FONT-FAMILY: Symbol"}Fourteen-Segment Display-A fourteen-segment display is a type of display based on 14 segments that can be turned on or off to produce letters and numerals.

 

The character type can be set using the Digital Gauge's **CharacterType** property. It accepts values: SegementSeven and SegmentFourteen. The default value is SegmentFourteen.

 

+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| Property         | Description                                                                            | Type of Property              | Value It Accepts                                                          | Any other dependencies/Sub properties associated |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| CharacterCount   | Sets the count of characters.                                                          | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"}                                             | NA                                               |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| CharacterHeight  | Sets the height of characters.                                                         | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"}                                             | NA                                               |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| CharacterSpacing | Sets the distance between characters.                                                  | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"}                                             | NA                                               |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| CharacterType    | Sets the value indicating whether character should contain seven or fourteen segments. | [enum]{style="COLOR: blue"}   | [CharacterType]{style="COLOR: #2b91af"}.SegmentFourteen                   | NA                                               |
|                  |                                                                                        |                               |                                                                           |                                                  |
|                  |                                                                                        |                               |                                                                           |                                                  |
|                  |                                                                                        |                               |                                                                           |                                                  |
|                  |                                                                                        |                               | [CharacterType]{style="COLOR: #2b91af"}.SegmentSeven                      |                                                  |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| SkewAngleX       | Sets the angle to skew the characters along the X-axis.                                | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue"}                                             | NA                                               |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| SkewAngleY       | Sets the angle to skew the characters along the Y-axis.                                | [double]{style="COLOR: blue"} | [double]{style="COLOR: blue; FONT-SIZE: 11pt"}[]{style="FONT-SIZE: 11pt"} | NA                                               |
+------------------+----------------------------------------------------------------------------------------+-------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through View Customization](ms-xhelp:///?Id=287fb93d-dfa6-480e-aa2b-5d34944d13e7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through DigitalGaugeModel](ms-xhelp:///?Id=70b7170e-da2a-4333-af8a-387c17066d1c){style="TEXT-DECORATION: none"}
:::
