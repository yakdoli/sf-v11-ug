::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=37f7bd39-4ad8-46d2-8ea8-858ad2c8e241){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=66409224-cbeb-4cdc-bb9c-dd89c16fbefd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=64869483-f57f-4838-b322-b1a3d1ce8e40){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Events](ms-xhelp:///?Id=286f64ee-e427-4525-8973-f420a02e732b){.d2h_breadcrumbsNormal}
:::

### Client-side Events {#client-side-events style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The below given properties specify the various client-side function calls that are generated on clicking, dragging, dropping, and resizing appointments and cells in the Schedule control. The client-side event is implemented in the JavaScript file. This file is sent to the client browser when a web application that uses the web control is run. This enables web applications based on DeveloperExpress web controls to work more efficiently, using a combination of server-side and client-side processing.

 

The client-side events of the Schedule control are given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------------------ ---------------------------------------------------------------------------------------
  Appointment Property                 Description
  ClientSideOnAppointmentClick         Specifies the client-side function to call when an appointment is clicked.
  ClientSideOnAllDayAppointmentClick   Specifies the client-side function to call when an \"allday\" appointment is clicked.
  ClientSideOnAppointmentDragging      Specifies the client-side function to call on appointment drag.
  ClientSideOnAppointmentDragStart     Specifies the client-side function to call on appointment drag start.
  ClientSideOnAppointmentDrop          Specifies the client-side function to call on appointment drop.
  ClientSideOnAppointmentResizing      Specifies the client-side function to call on appointment resize.
  ClientSideOnAppointmentResizeStart   Specifies the client-side function to call on appointment resize start.
  ClientSideOnAppointmentResizeEnd     Specifies the client-side function to call on appointment resize end.
  ClientSideOnScheduleClick            Specifies the client-side function to call when a Schedule cell is clicked.
  ------------------------------------ ---------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

ClientSideOnScheduleClick Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

This is a client-side event that is handled on a Schedule Cell click.

 

The event handler receives an argument of type[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"}**ScheduleAppointmentEventArgs**[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"}containing data related to this event. The following ScheduleAppointmentEventArgs member provides information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------- --------------------------------------
  Member         Description
  ResourceData   Returns ID and Name of the resource.
  -------------- --------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image71_1.png){border="0"}Note: The AutoPostBackOnScheduleClick property should be set to True.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Schedule1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClientSideOnScheduleClick]{style="COLOR: red"}[=\"Schedule1_ClientScheduleClick(this)\"]{style="COLOR: blue"} [AutoPostBackOnScheduleClick]{style="COLOR: red"} [=\"true\"]{style="COLOR: blue"}[\....]{style="COLOR: red"}]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [language]{style="COLOR: red"} [=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Schedule1_ClientScheduleClick(oData)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'Textbox1\']{style="COLOR: #a31515"}).value=oData.CellData.ResourceData.ID;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'TextBox2\']{style="COLOR: #a31515"}).value=oData.CellData.ResourceData.Name;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

ClientSideOnAppointmentClick Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This is a client-side event that is handled when a Schedule appointment is clicked.

 

The event handler receives an argument of type **ScheduleAppointmentEventArgs** containing data related to this event. The following ScheduleAppointmentEventArgs members provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------+
| Member                            | Description                                                                    |
+-----------------------------------+--------------------------------------------------------------------------------+
| AppointmentData                   | *AllDay*: returns True if the appointment is \"allday\", otherwise False       |
|                                   |                                                                                |
|                                   | *EndTime*: returns the End Time of the appointment                             |
|                                   |                                                                                |
|                                   | *ID*: returns the Id of the appointment                                        |
|                                   |                                                                                |
|                                   | *StartTime*: returns the Start Time of the appointment                         |
|                                   |                                                                                |
|                                   | *Subject*: returns Subject of the appointment                                  |
|                                   |                                                                                |
|                                   | *Location*: returns the Location Value of the appointment                      |
+-----------------------------------+--------------------------------------------------------------------------------+
| Resource Data                     | *ID*: returns the Resource ID or Owner of the appointment                      |
|                                   |                                                                                |
|                                   | *Name*: returns the Name of the resource in which the appointment is available |
+-----------------------------------+--------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image71_1.png){border="0"}Note: The AutoPostBackOnAppointmentClick property should be set to True.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Schedule1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClientSideOnAppointmentClick]{style="COLOR: red"} [=\"Schedule_OnAppointmentclick(this)\"]{style="COLOR: blue"} [AutoPostBackOnAppointmentClick]{style="COLOR: red"} [=\"true\"]{style="COLOR: blue"}[\....]{style="COLOR: red"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [language]{style="COLOR: red"} [=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Schedule_OnAppointmentclick(oData)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'Subject\']{style="COLOR: #a31515"}).value=oData.AppointmentData.Subject;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'StarTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.StartTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'EndTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.EndTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'AllDay\']{style="COLOR: #a31515"}).value=oData.AppointmentData.AllDay;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'UniqueID\']{style="COLOR: #a31515"}).value=oData.AppointmentData.ID;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

ClientSideOnAllDayAppointmentClick Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This is a client-side event that is handled when an \"AllDay\" appointment is clicked.

The event handler receives an argument of type **ScheduleAppointmentEventArgs** containing data related to this event. The following ScheduleAppointmentEventArgs members provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------+
| Member                            | Description                                                                    |
+-----------------------------------+--------------------------------------------------------------------------------+
| AppointmentData                   | *AllDay*: returns True if the appointment is \"allday\", otherwise False       |
|                                   |                                                                                |
|                                   | *EndTime*: returns the End Time of the appointment                             |
|                                   |                                                                                |
|                                   | *ID*: returns the Id of the appointment                                        |
|                                   |                                                                                |
|                                   | *StartTime*: returns the Start Time of the appointment                         |
|                                   |                                                                                |
|                                   | *Subject*: returns Subject of the appointment                                  |
|                                   |                                                                                |
|                                   | *Location*: returns the Location Value of the appointment                      |
+-----------------------------------+--------------------------------------------------------------------------------+
| Resource Data                     | *ID*: returns the Resource ID or Owner of the appointment                      |
|                                   |                                                                                |
|                                   | *Name*: returns the Name of the resource in which the appointment is available |
+-----------------------------------+--------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Schedule1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"}  [ClientSideOnAllDayAppointmentClick]{style="COLOR: red"} [=\"Schedule_OnAppointmentclick(this)\"]{style="COLOR: blue"}   [AutoPostBackOnAppointmentClick]{style="COLOR: red"} [=\"true\"]{style="COLOR: blue"}[\....]{style="COLOR: red"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [language]{style="COLOR: red"} [=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Schedule_OnAppointmentclick(oData)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'Subject\']{style="COLOR: #a31515"}).value=oData.AppointmentData.Subject;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'StarTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.StartTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'EndTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.EndTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'AllDay\']{style="COLOR: #a31515"}).value=oData.AppointmentData.AllDay;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'UniqueID\']{style="COLOR: #a31515"}).value=oData.AppointmentData.ID;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

ClientSideOnAppointmentDragging Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This is a client-side event that is handled on appointment drag.

 

The event handler receives an argument of type **ScheduleAppointmentEventArgs** containing data related to this event. The following ScheduleAppointmentEventArgs members provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------+
| Member                            | Description                                                                    |
+-----------------------------------+--------------------------------------------------------------------------------+
| AppointmentData                   | *AllDay*: returns True if the appointment is \"allday\", otherwise False       |
|                                   |                                                                                |
|                                   | *EndTime*: returns the End Time of the appointment                             |
|                                   |                                                                                |
|                                   | *ID*: returns the Id of the appointment                                        |
|                                   |                                                                                |
|                                   | *StartTime*: returns the Start Time of the appointment                         |
|                                   |                                                                                |
|                                   | *Subject*: returns Subject of the appointment                                  |
|                                   |                                                                                |
|                                   | *Location*: returns the Location Value of the appointment                      |
+-----------------------------------+--------------------------------------------------------------------------------+
| Resource Data                     | *ID*: returns the Resource ID or Owner of the appointment                      |
|                                   |                                                                                |
|                                   | *Name*: returns the Name of the resource in which the appointment is available |
+-----------------------------------+--------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Schedule1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClientSideOnAppointmentDragging]{style="COLOR: red"} [=\"OnAppointmentDragging(this)\"]{style="COLOR: blue"}   [AutoPostBackOnAppointmentClick]{style="COLOR: red"} [=\"true\"]{style="COLOR: blue"}[\....]{style="COLOR: red"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [language]{style="COLOR: red"} [=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ OnAppointmentDragging(oData)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'Subject\']{style="COLOR: #a31515"}).value=oData.AppointmentData.Subject;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'StarTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.StartTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'EndTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.EndTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'AllDay\']{style="COLOR: #a31515"}).value=oData.AppointmentData.AllDay;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'UniqueID\']{style="COLOR: #a31515"}).value=oData.AppointmentData.ID;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

ClientSideOnAppointmentDragStart Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This is a client-side event that is handled on appointment drag start.

 

The event handler receives an argument of type **ScheduleAppointmentEventArgs** containing data related to this event. The following ScheduleAppointmentEventArgs members provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------+
| Member                            | Description                                                                    |
+-----------------------------------+--------------------------------------------------------------------------------+
| AppointmentData                   | *AllDay*: returns True if the appointment is \"allday\", otherwise False       |
|                                   |                                                                                |
|                                   | *EndTime*: returns the End Time of the appointment                             |
|                                   |                                                                                |
|                                   | *ID*: returns the Id of the appointment                                        |
|                                   |                                                                                |
|                                   | *StartTime*: returns the Start Time of the appointment                         |
|                                   |                                                                                |
|                                   | *Subject*: returns Subject of the appointment                                  |
|                                   |                                                                                |
|                                   | *Location*: returns the Location Value of the appointment                      |
+-----------------------------------+--------------------------------------------------------------------------------+
| Resource Data                     | *ID*: returns the Resource ID or Owner of the appointment                      |
|                                   |                                                                                |
|                                   | *Name*: returns the Name of the resource in which the appointment is available |
+-----------------------------------+--------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Schedule1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClientSideOnAppointmentDragging]{style="COLOR: red"} [=\"OnAppointmentDragging(this)\"]{style="COLOR: blue"}   [AutoPostBackOnAppointmentClick]{style="COLOR: red"} [=\"true\"]{style="COLOR: blue"}[\....]{style="COLOR: red"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [language]{style="COLOR: red"} [=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ OnAppointmentDragging(oData)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'Subject\']{style="COLOR: #a31515"}).value=oData.AppointmentData.Subject;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'StarTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.StartTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'EndTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.EndTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'AllDay\']{style="COLOR: #a31515"}).value=oData.AppointmentData.AllDay;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'UniqueID\']{style="COLOR: #a31515"}).value=oData.AppointmentData.ID;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

ClientSideOnAppointmentResizing Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This is a client-side event that is handled on appointment resize.

The event handler receives an argument of type **ScheduleAppointmentEventArgs** containing data related to this event. The following ScheduleAppointmentEventArgs members provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------+
| Member                            | Description                                                                      |
+-----------------------------------+----------------------------------------------------------------------------------+
| AppointmentData                   | *AllDay*: returns True if the appointment is \"allday\", otherwise False         |
|                                   |                                                                                  |
|                                   | *EndTime*: returns the End Time of the appointment                               |
|                                   |                                                                                  |
|                                   | *ID*: returns the Id of the appointment                                          |
|                                   |                                                                                  |
|                                   | *StartTime*: returns the Start Time of the appointment                           |
|                                   |                                                                                  |
|                                   | *Subject*: returns Subject of the appointment                                    |
|                                   |                                                                                  |
|                                   | *Location*: returns the Location Value of the appointment                        |
+-----------------------------------+----------------------------------------------------------------------------------+
| Resource Data                     | *ID* -- returns the Resource ID or Owner of the appointment                      |
|                                   |                                                                                  |
|                                   | *Name* -- Returns the Name of the resource in which the appointment is available |
+-----------------------------------+----------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Schedule1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\" ]{style="COLOR: blue"}[ClientSideOnAppointmentDragging]{style="COLOR: red"} [=\"OnAppointmentDragging(this)\"]{style="COLOR: blue"}   [AutoPostBackOnAppointmentClick]{style="COLOR: red"} [=\"true\"]{style="COLOR: blue"}[\....]{style="COLOR: red"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [language]{style="COLOR: red"} [=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"]{style="COLOR: blue"} [\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ OnAppointmentDragging(oData)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'Subject\']{style="COLOR: #a31515"}).value=oData.AppointmentData.Subject;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'StarTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.StartTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'EndTime\']{style="COLOR: #a31515"}).value=oData.AppointmentData.EndTime;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'AllDay\']{style="COLOR: #a31515"}).value=oData.AppointmentData.AllDay;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [document.getElementById([\'UniqueID\']{style="COLOR: #a31515"}).value=oData.AppointmentData.ID;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::::::::::::
