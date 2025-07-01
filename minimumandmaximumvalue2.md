::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Minimum and Maximum Value {#minimum-and-maximum-value style="tab-stops: 0pt"}

The TimePicker control allows you to set both minimum and maximum time interval values:

 

**Properties**

+-----------------------+-----------------------+---------------------------------------------------------------------+
| **Name**              | **Type**              | **Description**                                                     |
+-----------------------+-----------------------+---------------------------------------------------------------------+
| MinValue              | DateTime              | Gets/sets the minimum time that can be selected in the time picker. |
|                       |                       |                                                                     |
|                       | Default: Today        |                                                                     |
+-----------------------+-----------------------+---------------------------------------------------------------------+
| MaxValue              | DateTime              | Gets/sets the maximum time that can be selected in the time picker. |
|                       |                       |                                                                     |
|                       | Default: Today        |                                                                     |
+-----------------------+-----------------------+---------------------------------------------------------------------+

 

You can set the **MinValue** and **MaxValue** properties of the TimePicker control in two ways:

 

**[Using Builder]{style="COLOR: black"}**

[The following steps guide you in configuring the **MinValue** and **MaxValue** properties through Builder.]{style="COLOR: black"}

[1.   In the **view**, invoke the **TimePicker** helper with the time picker ID as the first argument and enable the **MinValue** and **MaxValue** methods with the desired option as an argument.]{style="COLOR: black"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().TimePicker([\"TimePicker\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Value([\"10:10:10\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                                                                       |
| [.Format([\"HH:mm:ss\"]{style="COLOR: #a31515"}).**MinValue**([\"05:00:00\"]{style="COLOR: #a31515"}).**MaxValue**([\"20:00:00\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                       |
| [.AutoFormat([Skins]{style="COLOR: #4bacc6"}.Midnight)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                       |
| [ [ %\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                       |
| [   ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [@(]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[Html.Syncfusion().TimePicker([\"TimePicker\"]{style="COLOR: #a31515"}).Value([\"10:10:10\"]{style="COLOR: #a31515"}).Format([\"HH:mm:ss\"]{style="COLOR: #a31515"}).**MinValue**([\"05:00:00\"]{style="COLOR: #a31515"}).**MaxValue**([\"20:00:00\"]{style="COLOR: #a31515"}).AutoFormat([Skins]{style="COLOR: #4bacc6"}.Midnight)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[ [)]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [   ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[2.   Run the application.]{style="COLOR: black"}

**[]{style="COLOR: black"}** 

**[Using Properties Model]{style="COLOR: black"}**

[The following steps will guide you in setting the **MinValue** and **MaxValue** properties through the properties model.]{style="COLOR: black"}

[1.  In the **controller**, create an instance of **TimePickerModel**, define the **MinVlaue** and **MaxValue** properties, and pass the instance through **view-specific data** to the **view** as given below.]{style="COLOR: black"}

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                           |
| [            [TimePickerModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [TimePickerModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                           |
| [            myModel**.**Value **=**]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[new]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [DateTime]{style="COLOR: #2b91af"}(2012,01,01,10,10,10);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                           |
| [              myModel.Format= [\"HH:mm:ss\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                           |
| [              myModel.AutoFormat=[Skins]{style="COLOR: #4bacc6"}.Midnight;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                           |
|                         [myModel.MinValue= [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2012,01,01,05,00,00);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                           |
|                         [myModel.MaxValue= [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2012,01,01,20,00,00);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                           |
| [            ViewData\[[\"myTimePickerModel\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                           |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[2.   In the **view**, invoke the **TimePicker** helper with the time picker ID as the first argument and the view data key as the second argument. ]{style="COLOR: black"}

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().TimePicker([\"TimePicker\"]{style="COLOR: #a31515"},[\"myTimePickerModel\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[![Description: http://help.syncfusion.com/ug_92/User%20Interface/ASP.NET%20MVC/Tools/ImagesExt/image9_5.png](ImagesExt/image56_233.png){border="0"}]{style="COLOR: black; FONT-SIZE: 9pt"}**[Note: The second argument of the above TimePicker helper should match the view data key from the controller to fetch the properties.]{style="COLOR: black; FONT-SIZE: 9pt"}***

[3.   Run the application.]{style="COLOR: black"}

 

![](ImagesExt/image56_309.png){border="0"}

                                Figure 284: Min and Max Value Properties Applied to a TmePicker

[]{#related-topics}
:::
