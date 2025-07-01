::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=384b973d-ab56-4556-82b4-932d68da9895){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=23aa91ce-0990-42fe-9d30-afabdb6fe47e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ProjIO](ms-xhelp:///?Id=b95f675f-3e97-4b4b-93b9-e4daba965feb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How To](ms-xhelp:///?Id=93ab5e9a-d912-414d-9c94-7fa3be4fd3fe){.d2h_breadcrumbsNormal}
:::

## How to retrieve tasks from a project? {#how-to-retrieve-tasks-from-a-project style="tab-stops: 0pt"}

The tasks present in a project can be retrieved using the **GetTaskByUID** method.

The following code snippet illustrates retrieving tasks using this method:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                      |
| [// Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                      |
|                                                                                                                                                                                                                      |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = [ProjectReader]{style="COLOR: #2b91af"}.Open([@\"D:\\ProjectWithTasks.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [// Retrieving a task by UID]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                      |
|                                                                                                                                                                                                                      |
| [Task]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ task = project.GetTaskByUID(2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [// Viewing retrieved task information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                            |
|                                                                                                                                                                                                                      |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Task Name: \"]{style="COLOR: #a31515"} + task.Name);]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                      |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Task Start Date: \"]{style="COLOR: #a31515"} + task.Start);]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                                      |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Task Finish Date: \"]{style="COLOR: #a31515"} + task.Finish);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                      |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No. of Sub Tasks: \"]{style="COLOR: #a31515"} + task.Children.Count);]{style="FONT-FAMILY: 'Courier New'"}                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                |
|                                                                                                                                                                                                                 |
| [\' Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = ProjectReader.Open([\"ProjectWithTasks.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                 |
| [\' Retrieving a task by UID]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ task [As]{style="COLOR: blue"} Task = project.GetTaskByUID(2)]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                 |
| [\' Viewing retrieved task information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Task Name: \"]{style="COLOR: #a31515"} + task.Name)]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Task Start Date: \"]{style="COLOR: #a31515"} + task.Start)]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Task Finish Date: \"]{style="COLOR: #a31515"} + task.Finish)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No. of Sub Tasks: \"]{style="COLOR: #a31515"} + task.Children.Count)]{style="FONT-FAMILY: 'Courier New'"}                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**[5.5 How to retrieve resources from a project?]{style="COLOR: #4e84c4; FONT-SIZE: 16pt"}**

The resources present in a project can be retrieved using the **GetResourceByUID** method.

The following code snippet illustrates how to retrieve tasks using this method:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                     |
| [// Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                     |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = [ProjectReader]{style="COLOR: #2b91af"}.Open([\"ProjectWithResources.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [// Retrieving a resource by UID]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                     |
| [Resource]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ resource = project.GetResourceByUID(1);]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [// Viewing retrieved resource information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Resource Name: \"]{style="COLOR: #a31515"} + resource.Name);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Type: \"]{style="COLOR: #a31515"} + resource.Type);]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Work: \"]{style="COLOR: #a31515"} + resource.Work);]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Remaining Work: \"]{style="COLOR: #a31515"} + resource.RemainingWork);]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Resource Calendar ID: \"]{style="COLOR: #a31515"} + resource.CalendarUID);]{style="FONT-FAMILY: 'Courier New'"}                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                     |
| [\' Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = ProjectReader.Open([\"ProjectWithResources.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                     |
| [\' Retrieving a resource by UID]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ resource [As]{style="COLOR: blue"} Resource = project.GetResourceByUID(1)]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [\' Viewing retrieved resource information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Resource Name: \"]{style="COLOR: #a31515"} + resource.Name)]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Type: \"]{style="COLOR: #a31515"} + resource.Type)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Work: \"]{style="COLOR: #a31515"} + resource.Work)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Remaining Work: \"]{style="COLOR: #a31515"} + resource.RemainingWork)]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                     |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Resource Calendar ID: \"]{style="COLOR: #a31515"} + resource.CalendarUID)]{style="FONT-FAMILY: 'Courier New'"}                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**[5.6 How to retrieve resource assignments from a project?]{style="COLOR: #4e84c4; FONT-SIZE: 16pt"}**

The resource assignments present in a project can be retrieved using the **GetAssignmentByUID** method.

The following code snippet shows how to use this method:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                              |
| [// Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                              |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = [ProjectReader]{style="COLOR: #2b91af"}.Open([\"SampleProject.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [// Retrieving an assignment by UID]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                              |
| [Assignment]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ assignment = project.GetAssignmentByUID(1);]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [//Viewing retrived assignment information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Resource: \"]{style="COLOR: #a31515"} + assignment.Resource.Name);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Assigned to: \"]{style="COLOR: #a31515"} + assignment.Task.Name);]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Booking Type: \"]{style="COLOR: #a31515"} + assignment.BookingType);]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Cost: \$\"]{style="COLOR: #a31515"} + assignment.Cost);]{style="FONT-FAMILY: 'Courier New'"}                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                              |
| [\' Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = ProjectReader.Open([\"SampleProject.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                              |
| [\' Retrieving a resource by UID]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ assignment [As]{style="COLOR: blue"} Assignment = project.GetAssignmentByUID(1)]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [\' Viewing retrieved assignment information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Resource: \"]{style="COLOR: #a31515"} + assignment.Resource.Name)]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Assigned to: \"]{style="COLOR: #a31515"} + assignment.Task.Name)]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Booking Type: \"]{style="COLOR: #a31515"} + assignment.BookingType)]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                              |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Cost: \$\"]{style="COLOR: #a31515"} + assignment.Cost)]{style="FONT-FAMILY: 'Courier New'"}                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
