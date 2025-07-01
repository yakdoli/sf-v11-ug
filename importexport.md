::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=714d5f07-6cc2-4405-bef2-4de6d7ff28e4){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e6c87978-9418-4a4c-9e9a-cbb5c397d187){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Schedule Control](ms-xhelp:///?Id=641660d5-c458-4c5d-9615-332d1a8eb458){.d2h_breadcrumbsNormal}
:::

## Import / Export {#import-export style="tab-stops: 0pt"}

This section deals with the import and export option in Schedule Silverlight:

[·      ]{style="FONT-FAMILY: Symbol"}The schedule control allows users to export or import appointments and events as an **.ics** files.  Appointments and events scheduled with the control can be exported as an **.ics** file and opened or imported in other schedulers such as Microsoft Outlook, Google Calendar, or any other scheduler supporting .**ics** files. 

[·      ]{style="FONT-FAMILY: Symbol"}Similarly, files exported from other schedulers can also be imported into Essential Schedule.

The code given below demonstrates the import and export of **.ics** files.

 

Code for implementing Importing and Exporting

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                        |
| [Schedule]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ schedule = [new]{style="COLOR: blue"} [Schedule]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas"} |
|                                                                                                                                                                        |
| [schedule.ExportICS();]{style="FONT-FAMILY: Consolas"}[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                        |
| [schedule.ImportICS();]{style="FONT-FAMILY: Consolas"}[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Export as ICS](ms-xhelp:///?Id=e6c87978-9418-4a4c-9e9a-cbb5c397d187){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Import as ICS](ms-xhelp:///?Id=b6c0c11e-ad8e-45d2-9602-9fa0bfe24c35){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting as CSV](ms-xhelp:///?Id=51a6aec8-caa7-461d-8bc0-8eacf3963c4d){style="TEXT-DECORATION: none"}
::::
