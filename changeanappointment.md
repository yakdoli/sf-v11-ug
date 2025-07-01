::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2be3c91a-3abd-4f78-b7e5-b1a606c75103){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=32e5374c-c2e0-4517-8981-1188b830d423){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=150b7e3e-75c6-4609-ab78-cdde2bca2b16){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Appointment](ms-xhelp:///?Id=67db6273-bfee-4b89-ac80-61e76818a9d9){.d2h_breadcrumbsNormal}
:::

### [Change an Appointment]{style="FONT-FAMILY: 'Calibri','sans-serif'"} {#change-an-appointment style="LINE-HEIGHT: 150%; MARGIN-TOP: 0pt; tab-stops: 0pt"}

Essential Schedule provides two ways to change an existing appointment at run time.

1.   Using AppointmentDoubleClick Event

2.   Using Context Menu

The Appointment dialog that opens on double-clicking an appointment or selecting menuitem (Open Appointment) from context menu with existing appointment details, provides options to change the subject, location, start time and end time, and description and so on.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Properties

Table 8: Change an Appointment - Properties

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
+------------------+---------------------------------------------------------+----------------------+---------------------------------------------------+-------------+
| Property         | Description                                             | Type of the property | Value it accepts                                  | Dependency  |
+==================+=========================================================+======================+===================================================+=============+
| AllowEdit        | Used to set enable/disable update appointment.          | Boolean              | [True/False]{style="COLOR: #2b91af"}              | NA          |
|                  |                                                         |                      |                                                   |             |
|                  |                                                         |                      |                                                   |             |
+------------------+---------------------------------------------------------+----------------------+---------------------------------------------------+-------------+
| ContextMenuItems | Used to add context-menu item for updating appointment. | List                 | [List\<ContextMenuItem\>]{style="COLOR: #2b91af"} |             |
|                  |                                                         |                      |                                                   |             |
|                  |                                                         |                      |                                                   |             |
+------------------+---------------------------------------------------------+----------------------+---------------------------------------------------+-------------+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Customizing Change an Existing Appointment](ms-xhelp:///?Id=95034acc-6ce9-4948-8cb7-d18ec8ca7e5c){style="TEXT-DECORATION: none"}
:::::
