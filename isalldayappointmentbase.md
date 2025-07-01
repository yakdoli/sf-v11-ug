::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_IsAllDayAppointmentBase}IsAllDayAppointmentBase

This is an explicit method to check whether the Appointment type is AllDayAppointment or not. It will be triggered implicitly by the IsAppointmentBase method.

It takes Appointment object as argument and returns a Boolean value.

It returns true for AllDayAppointment and false for other appointments.

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                          |
| [    \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [language]{style="COLOR: red"}[=\"javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                          |
| [        [function]{style="COLOR: blue"} pageLoad()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                          |
| [         {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                          |
| [             var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ oScheduleobj = Scheduler;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                          |
| [             [var]{style="COLOR: blue"} oStartDate = [new]{style="COLOR: blue"} Date([\"Jan 3, 2011 07:00:00\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                                                                                          |
| [             [var]{style="COLOR: blue"} oEndDate = [new]{style="COLOR: blue"} Date([\"Jan 31, 2011 10:00:00\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                                                                                          |
| [             [var]{style="COLOR: blue"} oAppointments = oScheduleobj.GetAppointments(1, oStartDate, oEndDate);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                          |
| [             [for]{style="COLOR: blue"} ([var]{style="COLOR: blue"} i = 0; i \< oAppointments.length; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                          |
| [             [var]{style="COLOR: blue"} bApp = oScheduleobj.IsAllDayAppointmentBase(oAppointments\[i\].AppointmentEl);                           } ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                                                                                          |
| [     [\</]{style="COLOR: blue"}[script]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
