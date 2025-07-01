::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Through View Customization {#through-view-customization style="tab-stops: 0pt"}

 

Step 1:

View:

 

The segments of the rolling gauge can be customized using its **SegmentBorderWidth**, **SpaceBetWeenSegment**,etc. If you set these properties, it will be applied for all segments. But if we want to customize the particular segments, then this can be done using the **Segments** mapper by setting its **CharacterIndex** property.

 

In the below code, CharacterIndex is specified as 2. Then the third segment will be customized. The specified segments has their own properties to customize it. 

 

 You can customize the background and border color for the specified segments using the **BackgroundColor** and **BorderColor** properties.  The font color, font family and font size can be customized using its **FontColor**, **FontSize** and **FontFamily** properties. The value for the specified segment can be given by using its **Value** property.

 

Add the below code in your aspx file.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().RollingGauge([\"Gauge\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                            |
| [            .Height(50)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                            |
| [            .Width(300)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                            |
| [            .FontFamily([new]{style="COLOR: blue"} System.Drawing.[FontFamily]{style="COLOR: #2b91af"}([\"Calibri\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                            |
| [              [//Setting the segment count.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                            |
| [            **.SegmentCount(5)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [            [//Setting the space between each segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                            |
| [            **.SpaceBetWeenSegment(2)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                            |
| [              [//Setting the border width for the segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                            |
| [            **.SegmentBorderWidth(1)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                            |
| [            .BorderWidth(10)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| [            .Value([\"Gauge\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                            |
| [             .Direction([Direction]{style="COLOR: #2b91af"}.Clockwise)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                            |
| [            .UnitPosition([UnitPosition]{style="COLOR: #2b91af"}.End)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                            |
| [            .MaxValue(10000)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| [            .MinValue(100)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                            |
| [            .AnimationDelay(500)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [            .FontSize(30)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                            |
| [            .GaugeSkins([GaugeSkins]{style="COLOR: #2b91af"}.VS2010)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                            |
| [              [//Customizing the particular segments by specifying the index values.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                                            |
| [              **.Segments(seg=\>**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                            |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                            |
| [                  seg.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                            |
| [                    [//Setting the character index.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                            |
| [                **.CharacterIndex(2)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                            |
| [                    [//Setting border and background color for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                            |
| [                .BackgroundColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.LightBlue)]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                            |
| [                  .BorderColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.Pink)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                            |
| [                    [//Setting the font color for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                            |
| [                .FontColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.White)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                            |
| [                    [//Setting the border width for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                            |
| [                .BorderWidth(3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                            |
| [                    [//Setting the font size for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                            |
| [                .FontSize(20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                            |
| [                    [//Setting the value for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                            |
| [                  .Value([\'u\']{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                            |
| [            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                            |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| [    [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                      |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().RollingGauge([\"Gauge\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                      |
| [            .Height(50)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                      |
| [            .Width(300)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                      |
| [            .FontFamily([new]{style="COLOR: blue"} System.Drawing.[FontFamily]{style="COLOR: #2b91af"}([\"Calibri\"]{style="COLOR: #a31515"}))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                      |
| [              [//Setting the segment count.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                      |
| [            **.SegmentCount(5)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                      |
| [            [//Setting the space between each segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                      |
| [            **.SpaceBetWeenSegment(2)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                      |
| [              [//Setting the border width for the segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                      |
| [            **.SegmentBorderWidth(1)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                      |
| [            .BorderWidth(10)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                      |
| [            .Value([\"Gauge\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                      |
| [             .Direction([Direction]{style="COLOR: #2b91af"}.Clockwise)]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                      |
| [            .UnitPosition([UnitPosition]{style="COLOR: #2b91af"}.End)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                      |
| [            .MaxValue(10000)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                      |
| [            .MinValue(100)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                      |
| [            .AnimationDelay(500)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                      |
| [            .FontSize(30)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                      |
| [            .GaugeSkins([GaugeSkins]{style="COLOR: #2b91af"}.VS2010)]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                      |
| [              [//Customizing the particular segments by specifying the index value.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                      |
| [              **.Segments(seg=\>**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                      |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                      |
| [                  seg.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                      |
| [                    [//Setting the character index.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                      |
| [                **.CharacterIndex(2)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                      |
| [                    [//Setting border and background color for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                      |
| [                .BackgroundColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.LightBlue)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                      |
| [                  .BorderColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.Pink)]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                      |
| [                    [//Setting the font color for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                      |
| [                .FontColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.White)]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                      |
| [                    [//Setting the border width for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                      |
| [                .BorderWidth(3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                      |
| [                    [//Setting the font size for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                      |
| [                .FontSize(20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                      |
| [                    [//Setting the value for the segment specified by the CharacterIndex property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                      |
| [                  .Value([\'u\']{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                      |
| [            }).Render();            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                      |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Controller:

Step 2:

 

Add the below code in your controller.

 

+----------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                            |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                            |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                            |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
+----------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Step 3:

Run the code. You will get the below output.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\seg_cust.png](ImagesExt/image57_129.jpg){border="0"}

Figure 159: Rolling Gauge-Segment Customization**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

[                                                          ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[]{#related-topics}
:::
