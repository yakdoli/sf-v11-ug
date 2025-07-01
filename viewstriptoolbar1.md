::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=07d0aeb2-94db-43b9-9079-2af67189a70e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=fb825d77-863b-4952-a4fb-c0d9c811de97){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=150b7e3e-75c6-4609-ab78-cdde2bca2b16){.d2h_breadcrumbsNormal}
:::

## ViewStrip Toolbar {#viewstrip-toolbar style="tab-stops: 0pt"}

The ViewStrip toolbar provides options to view the day, workweek, week, and month schedule. It also provides options to move the Schedule to 'today's date' and print a schedule.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[·      ]{style="FONT-FAMILY: Symbol"}Day: This view displays the most detailed view of appointments for a single day

[·      ]{style="FONT-FAMILY: Symbol"}Workweek: This view displays the appointments for the working days in a particular week

[·      ]{style="FONT-FAMILY: Symbol"}Week: This view displays the appointments for all the days in a week

[·      ]{style="FONT-FAMILY: Symbol"}Month: This view displays the appointments for the entire month

[·      ]{style="FONT-FAMILY: Symbol"}Today: Displays the present day's appointments

[·      ]{style="FONT-FAMILY: Symbol"}Print: Prints a schedule

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Properties

Table 6: ViewStrip Toolbar - Properties

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| Property                                                                                         | Description                       | Type of the property | Value it accepts                                    | Dependency  |
+==================================================================================================+===================================+======================+=====================================================+=============+
| *[CurrentView]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*      | Used to set the active view type. | Enum                 | [ScheduleViewMode]{style="COLOR: #2b91af"}.Day      | NA          |
|                                                                                                  |                                   |                      |                                                     |             |
|                                                                                                  |                                   |                      | [ScheduleViewMode]{style="COLOR: #2b91af"}.Week     |             |
|                                                                                                  |                                   |                      |                                                     |             |
|                                                                                                  |                                   |                      | [ScheduleViewMode]{style="COLOR: #2b91af"}.WorkWeek |             |
|                                                                                                  |                                   |                      |                                                     |             |
|                                                                                                  |                                   |                      | [ScheduleViewMode]{style="COLOR: #2b91af"}.Month    |             |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| *[ShowDayView]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*      | Used to enable the Day view.      | Boolean              | [True/false]{style="COLOR: #2b91af"}                | NA          |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| *[ShowWeekView]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*     | Used to enable the Week view.     | Boolean              | [True/false]{style="COLOR: #2b91af"}                | NA          |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| *[ShowWorkWeekView]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}* | Used to enable the Workweek view. | Boolean              | [True/false]{style="COLOR: #2b91af"}                | NA          |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| *[ShowMonthView]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*    | Used to enable the Month view.    | Boolean              | [True/false]{style="COLOR: #2b91af"}                | NA          |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| *[ShowTodayView]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*    | Used to enable the Today view.    | Boolean              | [True/false]{style="COLOR: #2b91af"}                | NA          |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
| *[ShowPrint]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*        | Used to enable the Print icon.    | Boolean              | [True/false]{style="COLOR: #2b91af"}                | NA          |
+--------------------------------------------------------------------------------------------------+-----------------------------------+----------------------+-----------------------------------------------------+-------------+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Customizing ViewStrip Toolbar](ms-xhelp:///?Id=fb825d77-863b-4952-a4fb-c0d9c811de97){style="TEXT-DECORATION: none"}
:::::
