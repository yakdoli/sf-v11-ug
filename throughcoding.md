::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d93c49c5-0879-4276-900c-d5aab8833134){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3eb106fd-0ab9-43d3-a303-7768914133c5){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=db08ebda-40b3-4965-b3be-d17da194e2f1){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Creating Schedule Control](ms-xhelp:///?Id=42372143-a041-401a-9454-fd42241da3f4){.d2h_breadcrumbsNormal}
:::

### Through Coding {#through-coding style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To create the Schedule control programmatically:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Add a new **Web Form** to your project.

2.   Drag the **Schedule** control from the toolbox onto the web form.

3.   In the .cs file, include the following directives.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                              |
|                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                               |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Web.UI.WebControls.Shared;]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                               |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Web.UI.WebControls.ScheduleControl;]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                               |
|                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Web.UI.WebControls.Shared]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Web.UI.WebControls.ScheduleControl]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

4.   Add any number of resources to the control. Resources can be any names, tangible elements, tasks, and so on. Create instances of the resources and add it to the Schedule control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                             |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [ScheduleWebResource]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ res1 = [new]{style="COLOR: blue"} [ScheduleWebResource]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [Scheduler1.Resources.Add(res1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [ScheduleWebResource]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ res2 = [new]{style="COLOR: blue"} [ScheduleWebResource]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [Scheduler1.Resources.Add(res2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [ScheduleWebResource]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ res3 = [new]{style="COLOR: blue"} [ScheduleWebResource]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [Scheduler1.Resources.Add(res3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ res1 [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.ScheduleControl.ScheduleWebResource = [New]{style="COLOR: blue"} ScheduleWebResource()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                  |
| [Scheduler1.Resources.Add(res1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ res2 [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.ScheduleControl.ScheduleWebResource = [New]{style="COLOR: blue"} ScheduleWebResource()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                  |
| [Scheduler1.Resources.Add(res2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ res3 [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.ScheduleControl.ScheduleWebResource = [New]{style="COLOR: blue"} ScheduleWebResource()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                  |
| [Scheduler1.Resources.Add(res3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

5.   Set the Name and Id properties for the resources.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**Name** property when set will be displayed on the header section of the control denoting the resource. **UniqueID** can be set for individual resources which can be used to associate the resources with the respective appointments.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                       |
|                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                        |
| [res1.UniqueID = [\"1\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                        |
| [res1.Name = [\"Allen\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                        |
| [res1.UniqueID = [\"2\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                        |
| [res1.Name = [\"Brian\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                        |
| [res1.UniqueID = [\"3\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                        |
| [res1.Name = [\"George\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                      |
|                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                       |
| [res1.UniqueID = [\"1\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                       |
| [res1.Name = [\"Allen\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                 |
|                                                                                       |
| [res1.UniqueID = [\"2\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                       |
| [res1.Name = [\"Brian\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                 |
|                                                                                       |
| [res1.UniqueID = [\"3\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                       |
| [res1.Name = [\"George\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

6.   Any number of appointments can be tagged for a single resource, which will be displayed at the intersection of the time and the resource, and occupy that area for the specified time.

7.   Create instances for the appointments and add it to the Schedule control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                   |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                    |
| [ScheduleWebAppointment]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ app1 = [new]{style="COLOR: blue"} [ScheduleWebAppointment]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [Scheduler1.Appointments.Add(app1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                    |
| [ScheduleWebAppointment]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ app2 = [new]{style="COLOR: blue"} [ScheduleWebAppointment]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [Scheduler1.Appointments.Add(app2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                    |
| [ScheduleWebAppointment]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ app3 = [new]{style="COLOR: blue"} [ScheduleWebAppointment]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [Scheduler1.Appointments.Add(app3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ app1 [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.ScheduleControl.ScheduleWebAppointment = [New]{style="COLOR: blue"} ScheduleWebAppointment()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| [Scheduler1.Appointments.Add(app1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ app2 [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.ScheduleControl.ScheduleWebAppointment = [New]{style="COLOR: blue"} ScheduleWebAppointment()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| [Scheduler1.Appointments.Add(app2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ app3 [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.ScheduleControl.ScheduleWebAppointment = [New]{style="COLOR: blue"} ScheduleWebAppointment()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| [Scheduler1.Appointments.Add(app3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

8.   Set the **Owner**, **Subject**, **StartTime** and **EndTime** properties for the appointments.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To view the above properties in detail, see [Assign Appointments to Resources]{.UGHyperlink}.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                             |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                              |
| [app1.Owner = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                              |
| [app1.StartTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: teal"}(2008, 08, 07, 17, 00, 00);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                              |
| [app1.EndTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: teal"}(2008, 08, 07, 18, 00, 00);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                              |
| [app1.Subject = [\"Meeting with Allen\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                              |
| [app1.Owner = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                              |
| [app1.StartTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: teal"}(2008, 08, 07, 10, 00, 00);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                              |
| [app1.EndTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: teal"}(2008, 08, 07, 11, 00, 00);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                              |
| [app1.Subject = [\"Brian coming over\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                              |
| [app1.Owner = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                              |
| [app1.StartTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: teal"}(2008, 08, 07, 13, 00, 00);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                              |
| [app1.EndTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: teal"}(2008, 08, 07, 14, 00, 00);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                              |
| [app1.Subject = [\"Lunch with George\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                              |
|                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                               |
| [app1.Owner = 1]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                               |
| [app1.StartTime = New DateTime(2008, 08, 07, 5, 00, 00)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                               |
| [app1.EndTime = New DateTime(2008, 08, 07, 6, 00, 00)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                               |
| [app1.Subject = \"Meeting with Allen\"]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                               |
| [app1.Owner = 2]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                               |
| [app1.StartTime = New DateTime(2008, 08, 07, 10, 00, 00)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                               |
| [app1.EndTime = New DateTime(2008, 08, 07, 11, 00, 00)]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                               |
| [app1.Subject = \"Brian coming over\"]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                               |
| [app1.Owner = 3]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                               |
| [app1.StartTime = New DateTime(2008, 08, 07, 1, 00, 00)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                               |
| [app1.EndTime = New DateTime(2008, 08, 07, 2, 00, 00)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                               |
| [app1.Subject = \"Lunch with George\"]{style="FONT-FAMILY: 'Courier New'"}                    |
+-----------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

9.   Run the application. The output will be displayed as shown below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image71_16.jpg){border="0"}[]{style="FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[Through Designer]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p17} 

[]{#related-topics}
::::
