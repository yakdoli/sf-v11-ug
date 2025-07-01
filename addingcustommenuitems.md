::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=11eea7d9-f3db-46ac-ad7c-d5bdb6bf48c3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0d657654-c6c2-4ef3-bc78-bbc0848ef83c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Schedule Control](ms-xhelp:///?Id=641660d5-c458-4c5d-9615-332d1a8eb458){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Context Menu](ms-xhelp:///?Id=53511a45-3d47-426c-a7f1-17609cee059f){.d2h_breadcrumbsNormal}
:::

### Adding Custom Menu Items {#adding-custom-menu-items style="LINE-HEIGHT: 150%; tab-stops: 0pt"}

Add the Custom Context Menu Items for the Schedule Control using the following properties directly under the schedule control and define the Menu Items for the particular Context Menu. Each part of the schedule control has the options for adding the custom menu items.

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuTimeSlotItems** : Custom Menu Items Collection for Day View Time Slot items control Context Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuTimeLineItems** : Custom Menu Items Collection for Day View Time Line Hour Control Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuDaysHeaderItems:** Custom Menu Items Collection for Day View Header Control Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuAppointmentItems:** Custom Menu Items Collection for Day View Appointment Items Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuAllDayAppointmentItems:** Custom Menu Items Collection for Day View All Day Appointment  Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuMonthViewItems:** Custom Menu Items Collection for Month View Items Control Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuMonthViewAppointmentItems:** Custom Menu Items Collection for Month View Appointment Items Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuHorizontalViewItems:** Custom Menu Items Collection for Horizontal View Items Control Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuHorizontalViewAppointmentItems:** Custom Menu Items Collection for Horizontal View Appointment Items Context  Menu

[·      ]{style="FONT-FAMILY: Symbol"}**ContextMenuHorizontalViewTimeLineItems:** Custom Menu Items Collection for Horizontal View Time Line Control Context  Menu

The following code illustrates the adding of custom Menu Items for the Context Menu Days View Time Slot Items. Like this, you can add the custom menu items for each part of the control using the above mentioned properties.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Schedule]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"schedule\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ContextMenuType]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Custom\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [           \<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[schedule]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Schedule.ContextMenuTimeSlotItems]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[              ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[]{style="FONT-FAMILY: Consolas"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [                ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[shared]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ContextMenuItemAdv]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ Header]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Cut\"/\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [                ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\<]{style="FONT-FAMILY: Consolas; COLOR: blue"}[shared]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ContextMenuItemAdv]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[ Header]{style="FONT-FAMILY: Consolas; COLOR: red"}[=\"Copy\"/\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: Consolas"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [            ]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[schedule]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Schedule.ContextMenuTimeSlotItems]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\</]{style="FONT-FAMILY: Consolas; COLOR: blue"}[schedule]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[:]{style="FONT-FAMILY: Consolas; COLOR: blue"}[Schedule]{style="FONT-FAMILY: Consolas; COLOR: #a31515"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#_Import_/_Export} 

[]{#related-topics}
::::
