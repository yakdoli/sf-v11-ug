::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Gauge Customization {#gauge-customization style="tab-stops: 0pt"}

 

The first, second and center frame colors can be set using its **FirstFrameFillColor**, **SecondFrameFillColor** and **CenterFrameFillColor** properties. The foreground color of the digital gauge can be set using its **Foreground** property.

 

Frame Types

The Frame type of the digital gauge can be customized using its **FrameType** property. There are four types of frames available for digital gauge. They are:

 

Rectangle

Digital Gauge with default template will be displayed as a Rectangle.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\d_rec.png](ImagesExt/image57_109.png){border="0"}

Figure 127: Rectangular Frame**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

[                                            ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

CroppedRectangle

 Digital Gauge with CroppedRectangle.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\d_crop.png](ImagesExt/image57_110.png){border="0"}

Figure 128: Cropped Rectangular Frame**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

 

BoltedRectangle

Digital Gauge frame with BoltedRectangle.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\d_bolt.png](ImagesExt/image57_111.png){border="0"}

Figure 129: BoltedRectangular Frame**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

[                                       ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

RoundedRectangleWithInnerTopGradient

 Digital Gauge frame with inner top gradient.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\d_inner.png](ImagesExt/image57_112.png){border="0"}

Figure 130: RoundedRectangular Frame with WithInnerGradient

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

::: {align="center"}
Property
:::
::::

Description

Type of Property

Value It Accepts

Any other dependencies/Sub properties associated

FirstFrameFillColor

Sets the background of the first frame.

System.Windows.Media.[Brushes]{style="COLOR: #2b91af"}

Refer to the below Link for  Value for the Brushes class

[[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx)

NA

SecondFrameFillColor

Sets the background of the second frame.

System.Windows.Media.[Brushes]{style="COLOR: #2b91af"}

Refer to the below Link for  Value for the Brushes class

[[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx)

NA

CenterFrameFillColor

Sets the background of the center frame.

System.Windows.Media.[Brushes]{style="COLOR: #2b91af"}

Refer to the below Link for  Value for the Brushes class

[[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx)

NA

Foreground

Sets the foreground color for the Digital Gauge values.

System.Windows.Media.[Brushes]{style="COLOR: #2b91af"}

Refer to the below Link for  Value for the Brushes class

[[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx)

NA

FrameType

Sets the frame type of the Digital Gauge.

 

[enum]{style="COLOR: blue"}

[DigitalGaugeFrameType]{style="COLOR: #2b91af"}.BoltedRectangle

 

[DigitalGaugeFrameType]{style="COLOR: #2b91af"}.CroppedRectangle

 

[DigitalGaugeFrameType]{style="COLOR: #2b91af"}.Rectangle

 

[DigitalGaugeFrameType]{style="COLOR: #2b91af"}.RoundedRectangleWithInnerGradient

 

DimmedBrush

Sets the brush used for drawing the dim segments.

System.Windows.Media.[Brushes]{style="COLOR: #2b91af"}

 

Refer to the below Link for  Value for the Brushes class

[[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx)

NA

Height

Sets the height of the Digital Gauge.

 

[double]{style="COLOR: blue"}

[double]{style="COLOR: blue"}

NA

FirstFrameThickness

Sets the first frame thickness of the Gauge.

System.Windows.[Thickness]{style="COLOR: #2b91af"}

[System.Windows.[Thickness]{style="COLOR: #2b91af"}]{style="FONT-SIZE: 11pt"}[]{style="FONT-SIZE: 11pt"}

NA

SecondFrameThickness

Sets the second frame thickness of the Gauge.

System.Windows.[Thickness]{style="COLOR: #2b91af"}

[System.Windows.[Thickness]{style="COLOR: #2b91af"}]{style="FONT-SIZE: 11pt"}[]{style="FONT-SIZE: 11pt"}

NA

Width

Sets the width  of the Gauge.

[double]{style="COLOR: blue"}

[double]{style="COLOR: blue; FONT-SIZE: 11pt"}[]{style="FONT-SIZE: 11pt"}

NA

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

###### 5.3.3.1.2.1 Through View Customization {#through-view-customization style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 1:

View:

The first, second and center frame colors can be set using its **FirstFrameFillColor**, **SecondFrameFillColor** and **CenterFrameFillColor** properties. The Foreground color of the digital gauge can be set using its **Foreground** property. The color of the dimmed brushes can be set using its **DimmedBrush** property. The Height and Width of the Digital Gauge can be controlled using its **Height** and **Width** properties.  The Width of the first and second frame can be customized by its **FirstFrameThickness** and **SecondFrameThickness** properties.

 

Add the below code in your aspx file.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                     |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().DigitalGauge([\"Gauge\"]{style="COLOR: #a31515"}, gauge=\>]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                     |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                     |
| [        gauge]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [            [//Setting first, second and center frame colors.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                     |
| [            .FirstFrameFillColor([Brushes]{style="COLOR: #2b91af"}.LightGray)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [            .SecondFrameFillColor([Brushes]{style="COLOR: #2b91af"}.DarkGray)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [            .CenterFrameFillColor([Brushes]{style="COLOR: #2b91af"}.Gray)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                     |
| [            [//Setting height and width of the gauge.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                     |
| [            .Height(105)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                     |
| [            .Width(450)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                     |
| [            [//Setting first and second frame thickness.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                     |
| [            .FirstFrameThickness([new]{style="COLOR: blue"} System.Windows.[Thickness]{style="COLOR: #2b91af"}(8))]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                     |
| [            .SecondFrameThickness([new]{style="COLOR: blue"} System.Windows.[Thickness]{style="COLOR: #2b91af"}(6))]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                     |
| [            [//Sets the color for the bright segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [            .Foreground([Brushes]{style="COLOR: #2b91af"}.Red)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                     |
| [            [//Sets the color for the dimmed segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [            .DimmedBrush([Brushes]{style="COLOR: #2b91af"}.LightGray)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                                     |
| [            .Value([\"10000\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                     |
| [            [//Setting the frame type for the Digital Gauge.    ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                                     |
| [            .FrameType([DigitalGaugeFrameType]{style="COLOR: #2b91af"}.CroppedRectangle);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                     |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                     |
| [                  })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                     |
| [                 [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                        |
| [  [@]{style="BACKGROUND: yellow"}Html.Syncfusion().DigitalGauge([\"Gauge\"]{style="COLOR: #a31515"}, gauge=\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}       |
|                                                                                                                                                                        |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                           |
|                                                                                                                                                                        |
| [        gauge]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                       |
|                                                                                                                                                                        |
| [            [//Setting first, second and center frame colors.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                |
|                                                                                                                                                                        |
| [            .FirstFrameFillColor([Brushes]{style="COLOR: #2b91af"}.LightGray)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                       |
|                                                                                                                                                                        |
| [            .SecondFrameFillColor([Brushes]{style="COLOR: #2b91af"}.DarkGray)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                       |
|                                                                                                                                                                        |
| [            .CenterFrameFillColor([Brushes]{style="COLOR: #2b91af"}.Gray)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                           |
|                                                                                                                                                                        |
| [            [//Setting height and width of the gauge.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                        |
|                                                                                                                                                                        |
| [            .Height(105)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                            |
|                                                                                                                                                                        |
| [            .Width(450)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                             |
|                                                                                                                                                                        |
| [            [//Setting first and second frame thickness.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                     |
|                                                                                                                                                                        |
| [            .FirstFrameThickness([new]{style="COLOR: blue"} System.Windows.[Thickness]{style="COLOR: #2b91af"}(8))]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}  |
|                                                                                                                                                                        |
| [            .SecondFrameThickness([new]{style="COLOR: blue"} System.Windows.[Thickness]{style="COLOR: #2b91af"}(6))]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                        |
| [            [//Sets the color for the bright segments.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                       |
|                                                                                                                                                                        |
| [            .Foreground([Brushes]{style="COLOR: #2b91af"}.Red)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                      |
|                                                                                                                                                                        |
| [            [//Sets the color for the dimmed segments.]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                       |
|                                                                                                                                                                        |
| [            .DimmedBrush([Brushes]{style="COLOR: #2b91af"}.LightGray)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                               |
|                                                                                                                                                                        |
| [            .Value([\"10000\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                             |
|                                                                                                                                                                        |
| [            [//Setting the frame type for the Digital Gauge.    ]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                             |
|                                                                                                                                                                        |
| [            .FrameType([DigitalGaugeFrameType]{style="COLOR: #2b91af"}.CroppedRectangle);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                           |
|                                                                                                                                                                        |
| [            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                        |
|                                                                                                                                                                        |
| [                  })]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 2:

Controller:

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Add the below code in your controller.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                          |
| [      [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                          |
| [        {          ]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                          |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                          |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
+--------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 3:

Run the code. You will get the following output.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\last.png](ImagesExt/image57_113.png){border="0"}

Figure 131: Gauge customization**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

[                                     ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

###### 5.3.3.1.2.2 Through DigitalGaugeModel {#through-digitalgaugemodel style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 1:

View:

 

Add the below code in your aspx file.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[\--Rendering the Digital Gauge\--]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                           |
| [     [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().DigitalGauge([\"Gauge\"]{style="COLOR: #a31515"}, [\"GaugeModel\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}        |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                        |
| [@\*]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[\--Rendering the Digital Gauge\--]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[\*@]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                                        |
| [     ]{style="FONT-FAMILY: 'Courier New'"}[@]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[Html.Syncfusion().DigitalGauge([\"Gauge\"]{style="COLOR: #a31515"}, [\"GaugeModel\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 2:

Controller:

 

Add the below code in your controller. The first, second and center Frame colors can be set using its **FirstFrameFillColor, SecondFrameFillColor** and **CenterFrameFillColor** properties. The foreground color of the digital gauge can be set using its **Foreground** property. The color of the dimmed brushes can be set using its **DimmedBrush** property.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                   |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                   |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                   |
| [            [DigitalGaugeModel]{style="COLOR: #2b91af"} d_Gauge = [new]{style="COLOR: blue"} [DigitalGaugeModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [            [//Setting height and width of the gauge.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                   |
| [            d_Gauge.Height = 105;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                   |
| [            d_Gauge.Width = 450;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                   |
| [            [//Setting first and second frame thickness.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                   |
| [            d_Gauge.FirstFrameThickness = [new]{style="COLOR: blue"} System.Windows.[Thickness]{style="COLOR: #2b91af"}(8);]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                   |
| [            d_Gauge.SecondFrameThickness = [new]{style="COLOR: blue"} System.Windows.[Thickness]{style="COLOR: #2b91af"}(6);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                   |
| [            [//Setting the frame type of the digital gauge.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                   |
| [            d_Gauge.FrameType = [DigitalGaugeFrameType]{style="COLOR: #2b91af"}.CroppedRectangle;]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                   |
| [            [//Setting first, second and center frame colors.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                   |
| [            d_Gauge.FirstFrameFillColor = [Brushes]{style="COLOR: #2b91af"}.LightGray;]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                   |
| [            d_Gauge.SecondFrameFillColor = [Brushes]{style="COLOR: #2b91af"}.DarkGray;]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                   |
| [            d_Gauge.CenterFrameFillColor = [Brushes]{style="COLOR: #2b91af"}.Gray;]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                   |
| [            [//Sets the color for the bright segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                   |
| [            d_Gauge.Foreground = [Brushes]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                   |
| [            d_Gauge.Value = [\"10000\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                   |
| [            [//Sets the color for the dimmed segments.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                   |
| [            d_Gauge.DimmedBrush = [Brushes]{style="COLOR: #2b91af"}.LightGray;]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                   |
| [            [//Passing the gauge model to the view.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                   |
| [            ViewData\[[\"GaugeModel\"]{style="COLOR: #a31515"}\] = d_Gauge;]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                   |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 3:

Run the code. You will get the following output.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\krishnarajd\\Desktop\\last.png](ImagesExt/image57_113.png){border="0"}

Figure 132: Gauge customization**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

[                                         ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{#related-topics}
