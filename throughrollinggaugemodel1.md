::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Through RollingGaugeModel {#through-rollinggaugemodel style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 1:

View:

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Add the below code in the aspx file. Here you are adding the text box for updating the gauge value dynamically in its keyup event.

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[\--Rendering the rolling gauge\--]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                                                                               |
| [     [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().RollingGauge([\"Gauge\"]{style="COLOR: #a31515"}, [\"GaugeModel\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [    [\<%]{style="BACKGROUND: yellow"}[\--Adding the text box for updating the gauge value in its keyup event\--]{style="COLOR: darkgreen"}[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                                                               |
| [    [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.TextBox([\"]{style="COLOR: #a31515"}[Value]{style="COLOR: maroon"}[\"]{style="COLOR: #a31515"}, [\"Gauge\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                    |
| [@\*]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[\--Rendering the rolling gauge\--]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[\*@]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                                                                                    |
| [@]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[Html.Syncfusion().RollingGauge([\"Gauge\"]{style="COLOR: #a31515"}, [\"GaugeModel\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                    |
| [  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                    |
| [    [@\*]{style="BACKGROUND: yellow"}[\--Adding the text box for updating the gauge value in its keyup event\--]{style="COLOR: darkgreen"}[\*@]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                                                                                    |
| [    [@]{style="BACKGROUND: yellow"}Html.TextBox([\"]{style="COLOR: #a31515"}[Value]{style="COLOR: maroon"}[\"]{style="COLOR: #a31515"}, [\"Gauge\"]{style="COLOR: #a31515"})[]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Step 2:

 

Controller:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Add the below script in the same aspx file.

 

In the below code, you are binding **UpdateGaugeValue** function with the keyup event of the textbox. In the **UpdateGaugeValue()** function, you are calling the RollingGauge clientside **SetValue** method to update the gauge value dynamically.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: blue"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"} |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [        \$(document).ready([function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [        [//Binding the function for changing the gauge value dynamically with the keyup event.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                  |
|                                                                                                                                                                                                                                                           |
| [            \$([\"#Value\"]{style="COLOR: maroon"}).bind([\"keyup\"]{style="COLOR: maroon"}, UpdateGaugeValue);]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                            |
|                                                                                                                                                                                                                                                           |
| [        });]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [        [//Function to handle the keyup event of textbox.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                       |
|                                                                                                                                                                                                                                                           |
| [        [function]{style="COLOR: blue"} UpdateGaugeValue() {]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [            [//Gets the current value of the textbox.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [            [var]{style="COLOR: blue"} val = \$([\"#Value\"]{style="COLOR: maroon"}).val();]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                |
|                                                                                                                                                                                                                                                           |
| [            [//Gets the gauge object.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [            [var]{style="COLOR: blue"} RollingGaugeObj = \$find([\'Gauge\']{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                       |
|                                                                                                                                                                                                                                                           |
| [            [//Calling the SetValue function to update the rolling gauge value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                 |
|                                                                                                                                                                                                                                                           |
| [            RollingGaugeObj.SetValue(val);]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [            ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                           |
| [    [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 3:

Controller:

 

Add the code below in the controller. The **Value** property is used to set the value for the Rolling Gauge.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                     |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                     |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                     |
| [           [RollingGaugeModel]{style="COLOR: #2b91af"} roll_Gauge = [new]{style="COLOR: blue"} [RollingGaugeModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                     |
| [            [//Setting the value for the rolling gauge.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                     |
| [            roll_Gauge.Value = [\"Gauge\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                     |
| [            roll_Gauge.Height = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                     |
| [            roll_Gauge.GaugeSkins = [GaugeSkins]{style="COLOR: #2b91af"}.VS2010;]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                     |
| [            roll_Gauge.SegmentCount = 5;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                     |
| [            ViewData\[[\"GaugeModel\"]{style="COLOR: #a31515"}\] = roll_Gauge;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                     |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                     |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Step 4:

Run the code to achieve the below output.

 

![Description: C:\\Users\\krishnarajd\\Desktop\\roll_value.png](ImagesExt/image57_122.jpg){border="0"}

Figure 148: Dynamic Updation of Value

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![Description: C:\\Documents and Settings\\jananit\\Desktop\\Dataicon.jpg](ImagesExt/image57_9.jpg){border="0"} Note: Change the value in the textbox, to update the rolling gauge value.
:::

[]{#related-topics}
::::
