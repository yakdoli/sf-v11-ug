::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a0b8a1b2-b630-4251-88e6-2b390051286c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=82a97dd7-8079-4f2d-bac9-7e7cf2709a1c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=34399d3a-366c-4184-b6f9-4f2165957a91){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data used by ScheduleControl](ms-xhelp:///?Id=7560a931-6cd5-42dc-a916-846ad36340b9){.d2h_breadcrumbsNormal}
:::

### IScheduleData Interfaces {#ischeduledata-interfaces style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The ScheduleControl gets its data through its **DataSource** property, an **IScheduleDataProvider** object.

So, it is this IScheduleDataProvider interface (and several other associated interfaces) that gives you the ability and facility to provide data to the ScheduleControl.

This section discusses the actual interfaces required to provide data to the ScheduleControl. If you need the access your own custom datastore, then you can create objects that implement these interfaces on which the ScheduleControl relies to provide data from your custom datastore.

 If you just need a local disk file datastore, then using the implementation provided by the classes in the SimpleScheduleDataProvider file that is shipped with the samples, may serve your purpose.

 You also have the option of deriving the ScheduleData base classes to provide custom data to the ScheduleControl. But, implementing the required interfaces directly will give you the most flexibility.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There are five interfaces that you can use to provide data for a ScheduleControl. There are two \'object\' interfaces, **IScheduleAppointment** and **ILookUpObject**. These interfaces are primarily wrappers for a collection of properties.

 **IScheduleAppointment** wraps individual appointment data. **ILookUpObject** wraps the items you can see in droplists.

There are two \'list\' interfaces, **IScheduleAppointmentList** and **ILookUpObjectList**. As their names suggest, these two interfaces are essentially lists of **IScheduleAppointments** and **ILookUpItems** respectively.

The last interface, **IScheduleDataProvider,** is a wrapper that holds multiple ILookUpObjectLists and one IScheduleAppointmentList. It is through this interface that the ScheduleControl interacts with the source of data, and in fact, ScheduleControl.DataSource is an IScheduleDataProvider object.

The IScheduleDataProvider object exposes methods of interacting with the data like retrieving lookup lists and providing appointments for specified time periods. The Essential Schedule source code file **ScheduleAppointment.cs** provides a base class implementation of these interfaces, exposing a partially abstract set of classes (the ScheduleData classes) that you can use to indirectly implement these interfaces.

The **SimpleScheduleDataProvider** classes that were used in the Tutorial are derived from these base classes.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following sections discuss these required data interfaces in more detail.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 12pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}The Appointments Data](ms-xhelp:///?Id=63c75fed-a50d-405f-be4c-da623f6c6142){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}The DropLists](ms-xhelp:///?Id=35a208fb-e9f1-4a05-aef7-de02f2d52d2d){style="TEXT-DECORATION: none"}
::::
