::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=35097f8c-b65d-4390-8e43-496f7fc33c6d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ebcdf503-4674-4c5d-85fd-f285c184528e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=150b7e3e-75c6-4609-ab78-cdde2bca2b16){.d2h_breadcrumbsNormal}
:::

## Client-Side Events {#client-side-events style="tab-stops: 0pt"}

Schedule control enables client side events to handle the following:

[·      ]{style="FONT-FAMILY: Symbol"}Appointment selection

[·      ]{style="FONT-FAMILY: Symbol"}Cell double-click

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #454545"} 

To enable client side scripting, you should set the EnableClientSideEvents as true.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #454545"}** 

Appointment Selection

A user can raise the **AppointmentSelection** event by selecting an appointment.

The event argument consists of the appointment details with the appointment ID.  The user specified appointment selection method receives the appointment details and displays it in the Customized Appointment Window.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #454545"} 

Cell Double-click

A user can raise the **OnCellDoubleClick** event by double-clicking the cells.

When this event is raised, the event arguments consist of the  cell details such as date, start time, end time, and resource. The user specified method receives the cell details and uses it to create a new appointment by using the Customized Appointment Window.

If a user does not specify any method for appointment selection and cell double-click, then the Schedule's default appointment window will be displayed.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #454545"} 

Properties

Table 20: Cell Double-click Properties

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
  Property                 Description                                      Type of the Property   Value it Accepts                       Dependency
  ------------------------ ------------------------------------------------ ---------------------- -------------------------------------- ------------
  EnableClientSideEvents   Used to set enable/disable client-side events.   Boolean                [True/False]{style="COLOR: #2b91af"}   NA
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Events

The client-side events of the Schedule control are given below.

 

Table 21:Cell Double-click Events

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {align="center"}
+----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------+
| Name                             | Description                                                                                                                               | Arguments                                                  |
+==================================+===========================================================================================================================================+============================================================+
| ClientSideOnAppointmentSelection | Specifies the client-side function to call when an appointment is selected.                                                               | Instance, Args(                                            |
|                                  |                                                                                                                                           |                                                            |
|                                  |                                                                                                                                           | ID: returns the Appointment ID                             |
|                                  |                                                                                                                                           |                                                            |
|                                  | The event handler receives an argument of type args containing data related to this event.                                                |                                                            |
|                                  |                                                                                                                                           |                                                            |
|                                  |                                                                                                                                           | CurrentItem: returns the selected appointment's details)   |
|                                  |                                                                                                                                           |                                                            |
|                                  | If the user does not specify any function for this event, the default appointment window is loaded with the selected appointment details. |                                                            |
|                                  |                                                                                                                                           |                                                            |
|                                  |                                                                                                                                           |                                                            |
+----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------+
| ClientSideOnCellDoubleClick      | Specifies the client-side function to call when a Schedule cell is double clicked.                                                        | Instance, Args(                                            |
|                                  |                                                                                                                                           |                                                            |
|                                  |                                                                                                                                           | SelectedDate: returns the selected cell's date.            |
|                                  |                                                                                                                                           |                                                            |
|                                  | The event handler receives an argument of type args containing data related to this event.                                                | SelectedStartTime: returns the selected cell's start time. |
|                                  |                                                                                                                                           |                                                            |
|                                  |                                                                                                                                           | SelectedEndTime: returns the selected cell's end time.     |
|                                  |                                                                                                                                           |                                                            |
|                                  | If the user does not specify any function for this event, the default appointment window is loaded with the selected cell details.        | SelectedResourceId: returns the selected cell's owner id.) |
+----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Customizing Client-Side Events](ms-xhelp:///?Id=ebcdf503-4674-4c5d-85fd-f285c184528e){style="TEXT-DECORATION: none"}
::::::
