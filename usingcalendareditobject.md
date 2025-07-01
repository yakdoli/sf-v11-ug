::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5d60b7f7-e1cb-4246-94a1-af8b82e03fbd){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c27e20a1-d25e-400d-9e93-4a7587afb8f0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Tools WPF Controls](ms-xhelp:///?Id=2ea58a12-9426-4a63-96b4-89eb80232c2c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[CalendarEdit](ms-xhelp:///?Id=5d3ec42c-5002-4b8d-8fc2-6c8c0aa19ede){.d2h_breadcrumbsNormal}
:::

### Using CalendarEdit Object {#using-calendaredit-object style="tab-stops: 0pt"}

You can get the object of the CalendarEdit control by using the **Calendar** property. If you want to see the content after calling the methods, you can store the date in one variable to display or use a MessageBox. The description of each calendar option and sample code is described below.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image30_5.jpg){border="0"}Note: In the below sample code examples, calendarEdit is used as the instance of the CalendarEdit control.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   AddDays

 

Returns the system datetime, that is, the specified number of days away from the specified system datetime. Use MessageBox to see the content of date after this method is called.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [calendarEdit.Calendar.AddDays(calendarEdit.Date, 5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                               |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddDays(calendarEdit.Date, 5);.ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   AddHours

 

Returns the system datetime, that is, the specified number of hours away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [calendarEdit.Calendar.AddHours(calendarEdit.Date, 2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                               |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddHours(calendarEdit.Date, 2).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

3.   AddMonths

 

Returns the system datetime, that is, the specified number of months away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                            |
|                                                                                                                                                                                |
| [calendarEdit.Calendar.AddMonths(calendarEdit.Date, 3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddMonths(calendarEdit.Date, 3).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

4.   AddMilliseconds

 

Returns the system datetime, that is, the specified number of milliseconds away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                    |
|                                                                                                                                                                                        |
| [calendarEdit.Calendar.AddMilliseconds(calendarEdit.Date, 200);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                        |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddMilliseconds(calendarEdit.Date, 200).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

5.   AddMinutes

 

Returns the system datetime, that is, the specified number of milliseconds away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                             |
|                                                                                                                                                                                 |
| [calendarEdit.Calendar.AddMinutes(calendarEdit.Date, 5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                 |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddMinutes(calendarEdit.Date, 5).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

6.   AddSeconds

 

Returns the system datetime, that is, specified number of seconds away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                   |
|                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                              |
|                                                                                                                                                                                  |
| [calendarEdit.Calendar.AddSeconds(calendarEdit.Date, 30);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                  |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddSeconds(calendarEdit.Date, 30).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

7.   AddWeeks

 

Returns the system datetime, that is, specified number of weeks away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [calendarEdit.Calendar.AddWeeks(calendarEdit.Date, 2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                               |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddWeeks(calendarEdit.Date, 2).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

8.   AddYears

 

Returns the system datetime, that is, the specified number of years away from the specified system datetime. Use Message Box to see the content of date after this method is called.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [calendarEdit.Calendar.AddYears(calendarEdit.Date, 1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                               |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.AddYears(calendarEdit.Date, 1).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

9.   GetDayOfMonth

 

Returns the day of the month, in the specified System datetime. You can use a Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                             |
|                                                                                                                                                                                 |
| [calendarEdit.Calendar.GetDayOfMonth(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                 |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetDayOfMonth(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

10.            GetDayOfWeek

 

Returns the day of the week, in the specified System datetime. You can use a Message Box to see the content of date after this method is called.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                            |
|                                                                                                                                                                                |
| [calendarEdit.Calendar.GetDayOfWeek(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetDayOfWeek(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

11.            GetDayOfYear

 

Returns the day of the year, in the specified System datetime. You can use a Message Box to see the content of date after this method is called.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                            |
|                                                                                                                                                                                |
| [calendarEdit.Calendar.GetDayOfYear(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetDayOfYear(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

12.            GetDayOfYear

 

Returns the number of days, in the specified month and year of the current era. You can use a Message Box to see the content of date after this method is called.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                    |
|                                                                                                                                                                        |
| [calendarEdit.Calendar.GetDaysInMonth(2009, 2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                        |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetDaysInMonth(2009, 2).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

13.            GetDaysInYear

 

Returns the number of days, in the specified year of the current era. You can use a Message Box to see the content of date after this method is called.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                     |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                |
|                                                                                                                                                                    |
| [calendarEdit.Calendar.GetDaysInYear(2009);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                    |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetDaysInYear(2009).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

14.            GetEra

 

Returns the era, in the specified date time. You can use a Message Box to see the content of date after this method is called.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                           |
|                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                      |
|                                                                                                                                                                          |
| [calendarEdit.Calendar.GetEra(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                          |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetEra(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

15.            GetHour

 

Returns the hour, in the specified date time. You can use a Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                            |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                       |
|                                                                                                                                                                           |
| [calendarEdit.Calendar.GetHour(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                           |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetHour(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

16.            GetLeapMonth

 

Returns the leap month, in the specified year. You can use a Message Box to see the content of date after this method is called.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                    |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                               |
|                                                                                                                                                                   |
| [calendarEdit.Calendar.GetLeapMonth(2009);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                   |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetLeapMonth(2009).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

17.            GetMilliseconds

 

Returns the milliseconds, in the specified date time. You can use a Message Box to see the content of date after this method is called.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                    |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                               |
|                                                                                                                                                                                   |
| [calendarEdit.Calendar.GetMilliSeconds(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                   |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetMilliseconds(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

18.            GetMinute

 

[Returns the minute, in the specified datetime. You can use a Message Box to see the content of date after this method is called.]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                              |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                         |
|                                                                                                                                                                             |
| [calendarEdit.Calendar.GetMinute(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                             |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetMinute(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

19.            GetMonth

 

Returns the month, in the specified datetime. You can use a Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                             |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                        |
|                                                                                                                                                                            |
| [calendarEdit.Calendar.GetMonth(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                            |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetMonth(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

20.            GetMonthsInYear

 

Returns the month in the specified year in the current era. You can use a Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                  |
|                                                                                                                                                                      |
| [calendarEdit.Calendar.GetMonthsInYear(2009);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                      |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetMonthsInYear(2009).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

21.            GetSecond

 

Returns the seconds, in the specified date time. You can use a Message Box to see the content of date after this method is called.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                              |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                         |
|                                                                                                                                                                             |
| [calendarEdit.Calendar.GetSecond(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                             |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetSecond(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

22.            GetWeekOfYear

 

Returns the week of the year that includes the date in the specified date time. You can use a Message Box to see the content of date after this method is called.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                       |
| [calendarEdit.Calendar.GetWeekOfYear(calendarEdit.Date, System.Globalization.[CalendarWeekRule]{style="COLOR: #2b91af"}.FirstDay, [DayOfWeek]{style="COLOR: #2b91af"}.Friday);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                                                                                       |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetWeekOfYear(calendarEdit.Date, System.Globalization.[CalendarWeekRule]{style="COLOR: #2b91af"}.FirstDay, [DayOfWeek]{style="COLOR: #2b91af"}.Friday).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

23.            GetYear

 

Returns the week of the year that includes the date in the specified date time. You can use a Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                            |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                       |
|                                                                                                                                                                           |
| [calendarEdit.Calendar.GetYear(calendarEdit.Date);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                           |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.GetYear(calendarEdit.Date).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

24.            IsLeapDay

 

Determines whether the specified date in the current era is a leap day. You can use a Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                  |
|                                                                                                                                                                      |
| [calendarEdit.Calendar.IsLeapDay(2009, 2, 2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                      |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.IsLeapDay(2009, 2, 2).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

25.            IsLeapMonth

 

Determines whether the specified month, in the specified year, in the current era, is a leap month. You can use a Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                 |
|                                                                                                                                                                     |
| [calendarEdit.Calendar.IsLeapMonth(2009, 3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                     |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.IsLeapMonth(2009, 3).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

26.            IsLeapYear

 

Determines whether the specified year, in the current era, is a leap year. You can use a Message Box to see the content of date after this method is called.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                  |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                             |
|                                                                                                                                                                 |
| [calendarEdit.Calendar.IsLeapYear(2009);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                 |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.IsLeapYear(2009).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

27.            MaxSupportedDateTime

 

Gets the latest date and time, supported by the calendar object. You can use a Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                 |
|                                                                                                                                                                     |
| [calendarEdit.Calendar.MaxSupportedDateTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                     |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.MaxSupportedDateTime.ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

28.            MinSupportedDateTime

 

Gets the earliest date and time, supported by the calendar object. You can use a Message Box to see the content of date after this method is called.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                 |
|                                                                                                                                                                     |
| [calendarEdit.Calendar.MinSupportedDateTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                     |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.MinSupportedDateTime.ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

29.            TwoDigitYearMax

 

Gets or sets the last year of a 100-year range that can be represented as a 2 digit year. You can use a Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                 |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                            |
|                                                                                                                                                                |
| [calendarEdit.Calendar.TwoDigitYearMax;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.TwoDigitYearMax.ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

30.            ToDateTime

 

Returns the datetime that is set to the specified date and time in the current era. You can use a Message Box to see the content of date after this method is called.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                  |
|                                                                                                                                                                                      |
| [calendarEdit.Calendar.ToDateTime(2009, 4, 5, 2, 30, 5, 200);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                      |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.ToDateTime(2009, 4, 5, 2, 30, 5, 200).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

31.            ToFourDigitYear

 

Convert specified year to a 4 digit year. You can use a Message Box to see the content of date after this method is called.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                  |
|                                                                                                                                                                      |
| [calendarEdit.Calendar.ToFourDigitYear(2009);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                      |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Show(calendarEdit.Calendar.ToFourDigitYear(2009).ToString());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p59} 

[]{#related-topics}
:::::
