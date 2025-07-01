::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=66ea63db-0369-4376-b989-e0617739201a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a05949d7-e2f8-42c3-b959-8caca3d27591){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=150b7e3e-75c6-4609-ab78-cdde2bca2b16){.d2h_breadcrumbsNormal}
:::

## Multiple Resources {#multiple-resources style="tab-stops: 0pt"}

Essential Schedule allows you to add multiple resources to the control. You can add appointments to each resource, drag appointments from resource column to the other, perform CRUD operations, set reminders, priority, recurrence, time mode and so on to appointments for each resource.Drag-and-drop can be performed directly on an appointment after it is added to the resource.

Adding multiple resources in the Schedule control allows you to perform a comparative analysis of resources. For example: If you want to track the agenda list for five employees of a company, for the month, you can create five resources in Essential Schedule and create appointments for each one of them as per the agenda. This will provide you a clear view on what the resources are occupied for a month and will let you assign tasks in accordance with the agenda.

You can also set header for resources created. This will help you to view the appointments for each resource with a resource name as the header.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Properties

Table 18: Multiple Resources - Properties

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
+-----------------------+-----------------------------------------------+----------------------+----------------------------------------------------+------------------------+
| Property              | Description                                   | Type of the property | Value it accepts                                   | Dependency             |
+=======================+===============================================+======================+====================================================+========================+
| Resources             | Used to add resource for Schedule             | List                 | [List\<ScheduleResource\>]{style="COLOR: #2b91af"} | ShowResourceHeader,    |
|                       |                                               |                      |                                                    |                        |
|                       |                                               |                      | []{style="COLOR: #2b91af"}                         | AllowMultipleResource  |
|                       |                                               |                      |                                                    |                        |
|                       |                                               |                      |                                                    |                        |
+-----------------------+-----------------------------------------------+----------------------+----------------------------------------------------+------------------------+
| AllowMultipleResource | Used to set enable/disable multiple resources | Boolean              | [True/False]{style="COLOR: #2b91af"}               | ShowResourceHeader,    |
|                       |                                               |                      |                                                    |                        |
|                       |                                               |                      |                                                    | Resources              |
|                       |                                               |                      |                                                    |                        |
|                       |                                               |                      |                                                    |                        |
+-----------------------+-----------------------------------------------+----------------------+----------------------------------------------------+------------------------+
| ShowResourceHeader    | Used to show/hide the resource header.        | Boolean              | [True/False]{style="COLOR: #2b91af"}               | AllowMultipleResource, |
|                       |                                               |                      |                                                    |                        |
|                       |                                               |                      |                                                    | Resources              |
|                       |                                               |                      |                                                    |                        |
|                       |                                               |                      |                                                    |                        |
+-----------------------+-----------------------------------------------+----------------------+----------------------------------------------------+------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Customizing Multiple Resources](ms-xhelp:///?Id=a05949d7-e2f8-42c3-b959-8caca3d27591){style="TEXT-DECORATION: none"}
:::::
