::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=818d870d-7bbd-47f2-ab04-a88a2880ed3c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a0b8a1b2-b630-4251-88e6-2b390051286c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=34399d3a-366c-4184-b6f9-4f2165957a91){.d2h_breadcrumbsNormal}
:::

## Data used by ScheduleControl {#data-used-by-schedulecontrol style="tab-stops: 0pt"}

 

There are generally two types of data required by ScheduleControl. Most of the data is what we described as ***Appointments data***. This data includes the time, subject, body, and so on. of each of the actual appointments.

The second type of data we refer to as the ***DropLists data***. This data consists of the several option lists that go into describing the actual appointment data. For example, each appointment may have a marker associated with it that indicates something of the nature of the appointment like whether it is business, personal, a must-attend, etc. This second type of data is more like schema data, as it suggests the content options of the actual Appointments data.

 

The ScheduleControl does all its data access through interfaces. To support custom data objects, you would have your data objects implement these particular interfaces that are discussed in the following sections. In addition, included in the Essential Schedule library are base classes that implement these required interfaces. So, you can also create data sources for the ScheduleControl by deriving these base classes. The SimpleScheduleDataProvider classes that were used in the Tutorial are derived from these base classes.

 

Base Classes

 

[·      ]{style="FONT-FAMILY: Symbol"}**ScheduleDataProvider Class**: provides an empty implementation of the IscheduleDataProvider.

The implementation is done through virtual methods. You can then derive this class and through its overrides, set up an IScheduleDataProvider. See the SimpleScheduleDataProvider class in the ScheduleSample sample.

 

[·      ]{style="FONT-FAMILY: Symbol"}**ScheduleAppointmentList Class**: provides an implementation of IScheduleAppointmentList and is essentially a wrapper class for an ArrayList that holds ScheduleAppointments

 

[·      ]{style="FONT-FAMILY: Symbol"}**ScheduleAppointment Class**: provides an implementation of IScheduleAppointment and defines the objects that represent appointments in the ScheduleControl.

 

[·      ]{style="FONT-FAMILY: Symbol"}**LookUpObjectList Class**: strongly typed ArrayList that holds list option values that are used in the new appointment form.

 

[·      ]{style="FONT-FAMILY: Symbol"}**LookUpObject Class**: wrapper class for list choices that can have a valueMember, displayMember and colorMember associated with them.

 

 

The lists for the ShowTime and Label options on the Appointment forms use these objects.

 

Interfaces

 

[·      ]{style="FONT-FAMILY: Symbol"}**IScheduleDataProvider Interface:** provides the framework for providing schedule item data to the ScheduleControl.

 

[·      ]{style="FONT-FAMILY: Symbol"}**IScheduleAppointmentList Interface:** serves as a collection of ISchedule objects.

 

[·      ]{style="FONT-FAMILY: Symbol"}**IScheduleAppointment Interface:** defines individual schedule items.

 

[·      ]{style="FONT-FAMILY: Symbol"}**ILookUpObjectList Interface:** serves as a collection of IlookUpObjects.

 

[·      ]{style="FONT-FAMILY: Symbol"}**ILookUpObject Interface:** enables Choice lists within the ScheduleControl, that are used to provide possible schedule item information (like location or a reminder), to have a ValueMember / DisplayMember associated with them, as well as a color that will be used in drop-downs showing these lists.

 Value members are normally the values serialized to data stores.

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}ScheduleData Base Classes](ms-xhelp:///?Id=a0b8a1b2-b630-4251-88e6-2b390051286c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}IScheduleData Interfaces](ms-xhelp:///?Id=9f9cfed4-ecea-471a-950a-bf282d0ac8eb){style="TEXT-DECORATION: none"}
::::
