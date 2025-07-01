::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7560a931-6cd5-42dc-a916-846ad36340b9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9f9cfed4-ecea-471a-950a-bf282d0ac8eb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=34399d3a-366c-4184-b6f9-4f2165957a91){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data used by ScheduleControl](ms-xhelp:///?Id=7560a931-6cd5-42dc-a916-846ad36340b9){.d2h_breadcrumbsNormal}
:::

### ScheduleData Base Classes[]{style="FONT-WEIGHT: normal"} {#scheduledata-base-classes style="tab-stops: 0pt"}

 

The **ScheduleControl** gets its data through its DataSource property, an IScheduleDataProvider object. So, it is this IScheduleDataProvider interface (and several other associated interfaces) that gives you the ability and facility to provide data to the ScheduleControl. To simplify this process of providing data, Essential Schedule also exposes these interfaces as base classes that include some pre-determine droplist settings that allow you to use the ScheduleControl with less coding work. But, you do have the option of working directly through the interfaces to construct your own data provider for the ScheduleControl.

 

The **Essential Schedule** library contains several base classes that implement the various data interfaces required by the ScheduleControl. These base classes use virtual methods which, you can override to provide a concrete data implementation. The classes in the SimpleScheduleDataProvider file that is shipped with the samples and used in the Tutorial section of this User Guide are derived from the ScheduleData base classes. Check out the shipped sample that uses the SimpleScheduleDataProvider as a data source for ScheduleControl.

 

The following sections discuss these ScheduleData base classes in more detail.

 

[]{style="FONT-SIZE: 3pt"} 

[]{style="FONT-SIZE: 3pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}The Appointments Data](ms-xhelp:///?Id=04b120ed-d2c5-4e25-af23-17294f88902f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}The DropLists](ms-xhelp:///?Id=1eeb128e-1461-4b5a-a1b0-9164e83e1f49){style="TEXT-DECORATION: none"}
::::
