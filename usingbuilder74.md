::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps explain the handling of client-side events of the DatePicker control using Builder:

1.  [In the **view**, invoke the **DatePicker** handler with the control ID as the first argument followed by the event handler methods with the desired handler as an argument.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                         |
|                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [{=Html.MobSyncfusion().DatePicker([\"DatePicker\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [         .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.Spinach)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                 |
| [         .Mode([Mode]{style="COLOR: #2b91af"}.Advanced)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                 |
| [         .CalStartDay(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                 |
| [         .OnDatePickerLoad([\"OnDatePickerLoad\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                 |
| [         .OnDateSelected([\"OnDateSelected\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                 |
| [         .OnMonthChanged([\"OnMonthChanged\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                 |
| [         \-\-\-\-\-\-\-\-\-\-\--]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                 |
| [}[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [ Html.MobSyncfusion().DatePicker([\"DatePicker\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [         .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.Spinach)]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                |
| [         .Mode([Mode]{style="COLOR: #2b91af"}.Advanced)]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                |
| [         .CalStartDay(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                |
| [         .OnDatePickerLoad([\"OnDatePickerLoad\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                |
| [         .OnDateSelected([\"OnDateSelected\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                |
| [         .OnMonthChanged([\"OnMonthChanged\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                |
| [         \-\-\-\-\-\-\-\-\-\-\--]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                |
| [         .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

2.  [  In the **JavaScript**, define the handlers as given below:]{style="FONT-FAMILY: 'Arial','sans-serif'"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [ [type]{style="COLOR: red"} [=\"text/javascript\"\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| [          [function]{style="COLOR: blue"} OnDatePickerLoad(event, dpModel) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                    |
| [              [//event - event Object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [              [//dpModel -DatePicker Model Object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                    |
| [          }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                    |
| [          [function]{style="COLOR: blue"} OnDateSelected(event, data) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                    |
| [              [//event - event Object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [              [//data  - selected date]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                    |
| [          }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                    |
| [          [function]{style="COLOR: blue"} OnMonthChanged(event, data) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                    |
| [              [//event - event Object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [              [//data  - changed date value]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                    |
| [          }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                    |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} []{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

3.  [Build and run the application. You can observe the callback methods triggered when the corresponding events are raised.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[]{#related-topics}
:::
