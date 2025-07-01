::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=00cfa5a0-6a7e-41d2-90f7-857f190dd808){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bc3df60d-c596-4dbb-88af-184c25639735){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=82a97dd7-8079-4f2d-bac9-7e7cf2709a1c){.d2h_breadcrumbsNormal}
:::

## Customizing Appearance {#customizing-appearance style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The appearance of any region of the ScheduleControl can be customized by using the **ScheduleControl.Appearance** property.

This  property gains access to the **ScheduleAppearance** object which controls the various appearance attributes of different scheduler regions.

The following table describes the appearance options available in the ScheduleControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| Name                                | Description                                                                                                                                    |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Border                                                                                                                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ClickItemBorderColor                | Gets or sets the border color of a clicked item.                                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| DragColor                           | Gets or sets the color of the item that is dragged.                                                                                            |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SolidBorderColor                    | Gets or sets the color of the solid lines in the calendar.                                                                                     |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Caption                                                                                                                                                                              |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| CaptionBackColor                    | Gets or sets the color of the caption area above the calendar.                                                                                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowCaption                         | Specifies whether the caption panel above the calendar is visible.                                                                             |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowCaptionButtons                  | Specifies whether the navigation buttons are shown on the caption panel.                                                                       |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| DisplayItemFormat                                                                                                                                                                    |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| AllDayItemFormat                    | Gets or sets the display format of an allday item.                                                                                             |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| DateFormat                          | Gets or sets the format string used when formatting any token from DisplayItemFormatStrings that represents a date only value.                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| DateTimeFormat                      | Gets or sets the format string used when formatting any token from DisplayItemFormatStrings that represents the combined date and time values. |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| DayItemFormat                       | Gets or sets the display format of a schedule item displayed in a day or workweek view.                                                        |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| FullWeekHeaderFormat                | Specifies the display format of the header of a day in a week view.                                                                            |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| LongHeaderFormat                    | Specifies the display format of the header in a day view.                                                                                      |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SpanItemFormatLeftText              | Specifies the display format of text displayed on the interior left side of a multiday span.                                                   |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SpanItemFormatMiddleText            | Specifies the display format of text displayed in the middle of a multiday span.                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SpanItemFormatRightText             | Specifies the display format of text displayed on the interior right side of a multiday span.                                                  |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SpanItemFormatTerminalLeftText      | Specifies the display format of text displayed on the open left side of a multiday span.                                                       |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SpanItemFormatTerminalRightText     | Specifies the display format of text displayed on the open right side of a multiday span.                                                      |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| TimeFormat                          | Gets or sets the format string used when formatting any token from DisplayItemFormatStrings that represents a time only value.                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| WeekHeaderFormat                    | Specifies the display format of the header label in a workweek view.                                                                           |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| WeekMonthItemFormat                 | Specifies the display format of a schedule item shown in a week or month view.                                                                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| WorkWeekHeaderFormat                | Determines the display format of the header of a day in a workweek view.                                                                       |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Header                                                                                                                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| AllDayBackColor                     | Gets or sets the back color of the allday row in the calendar.                                                                                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| MonthWeekHeaderBackColor            | Specifies the back color of the header cells in a month or week view.                                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| MonthWeekHeaderForeColor            | Specifies the fore color of the header cells in a month or week view.                                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| WorkWeekHeaderBackColor             | Specifies the back color of header cells in a workweek view.                                                                                   |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| WorkWeekHeaderForeColor             | Specifies the fore color of header cells in a workweek view.                                                                                   |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Navigation Calendar                                                                                                                                                                  |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarArrowColor        | Specifies the color of arrows in the navigation calendar.                                                                                      |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarBackColor         | Specifies the back color of the navigation calendar.                                                                                           |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarDisabledTextColor | Specifies the color of disabled text in the navigation calendar.                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarHeaderColor       | Gets or sets the color of the header in the navigation calendar.                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarSelectionColor    | Gets or sets the selection color in the navigation calendar.                                                                                   |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarStartDayOfWeek    | Specifies the DayOfWeek that is shown in the left-most column of the navigation calendar.                                                      |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarTextColor         | Specifies the text color of the navigation calendar.                                                                                           |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarTodayColor        | Specifies the color of today\'s text in the navigation calendar.                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NavigationCalendarWeekNumberColor   | Specifies the color of week numbers in the navigation calendar.                                                                                |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Prime Time                                                                                                                                                                           |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| NonPrimeTimeCellColor               | Gets or sets the color of non-prime time cells in the calendar.                                                                                |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| PrimeTimeCellColor                  | Gets or sets the color of prime time cells in the calendar.                                                                                    |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| PrimeTimeEnd                        | Specifies the time when the prime time color stops being used in the display.                                                                  |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| PrimeTimeStart                      | Specifies the time when the prime time color starts being used in the display.                                                                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Time Column                                                                                                                                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| Hours24                             | Determines whether the time column is displayed using a 24-hour format.                                                                        |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| MarkColumnColor                     | Gets or sets the color of the thick solid line next to the time column in a day view.                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowTime                            | Indicates whether the time column should appear.                                                                                               |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| TimeBackColor                       | Specifies the back color of the time column.                                                                                                   |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| TimeBigFontSize                     | Determines the size of larger font used in the time column.                                                                                    |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| TimeLittleFontSize                  | Determines the size of smaller font used in the time column.                                                                                   |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| TimeTextColor                       | Specifies the color of text in the time column.                                                                                                |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| Visual Style                                                                                                                                                                         |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| VisualStyle                         | Specifies the visual style for the ScheduleControl.                                                                                            |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| Miscellaneous                       |                                                                                                                                                |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| DayMonthCutOff                      | Gets or sets the maximum number of days that can appear side-by-side in a day style calendar.                                                  |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| DivisionsPerHour                    | Gets or sets the number of time divisions that appear in a day, custom or workweek view.                                                       |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| MonthCalendarStartDayOfWeek         | Gets or sets the DayOfWeek that is shown in the left-most column of the month calendar.                                                        |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| MonthShowFullWeek                   | Specifies whether the month view shows 7 columns or 6 columns with saturday or sunday stacked.                                                 |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ScheduleAppointmentTipFormat        | Defines the text that is displayed for schedule item tips.                                                                                     |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ScheduleAppointmentTipsEnabled      | Determines whether to show item tips.                                                                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| SplitterBackColor                   | Specifies the back color of the two splitters in the ScheduleControl.                                                                          |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| TextColor                           | Specifies the color of basic text shown in the calendar.                                                                                       |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| ThemesEnabled                       | Specifies whether the themes are enabled.                                                                                                      |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
| WeekCalendarStartDayOfWeek          | Specifies the DayOfWeek that is shown in the first column of the week calendar.                                                                |
+-------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

[]{#related-topics}
:::::
