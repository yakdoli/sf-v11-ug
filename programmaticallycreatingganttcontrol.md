::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=814f306d-cf40-4397-9b6f-aef6398b5bb7){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c0ff09b7-9526-47d6-b84b-64918d7ed1da){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Gantt]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=35f72cf8-9b12-4131-ab30-00a5a199c143){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Adding GanttControl to an Application](ms-xhelp:///?Id=814f306d-cf40-4397-9b6f-aef6398b5bb7){.d2h_breadcrumbsNormal}
:::

### Programmatically Creating Gantt Control {#programmatically-creating-gantt-control style="tab-stops: 0pt"}

 

The following are the steps to create **GanttContro** programmatically:

[]{style="FONT-SIZE: 11pt"} 

1.   Adding GanttControl

You can add Gantt control to the application using the following code:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [ \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Sync]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[GanttControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Gantt\" /\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                          |
|                                                                                                                                                           |
| [ //Initializing Gantt]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\                                                                               |
| [ GanttControl]{style="COLOR: #2b91af"} Gantt = [new]{style="COLOR: blue"} [GanttControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------+

 

When the code runs, an empty gantt with in-built TaskDetails collection will be displayed.

 

2.   Binding Data to GanttControl

Create a collection of tasks and bind it to the newly created GanttControl as given in the following code:

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Sync:GanttControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ItemsSource]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"{Binding GanttItemSource}\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[x:Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Gantt\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                          |
|                                                                                                                                                           |
| [ //Initializing Gantt]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\                                                                               |
| [ GanttControl]{style="COLOR: #2b91af"} Gantt = [new]{style="COLOR: blue"} [GanttControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                           |
| [ [ViewModel]{style="COLOR: #2b91af"} model=  [new]{style="COLOR: blue"} [ViewModel]{style="COLOR: #2b91af"}();\                                          |
|  Gantt.ItemsSource = model.GanttItemSource;]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                               |
|                                                                                                                                                                                                                                |
| [GanttItemSource]{style="FONT-FAMILY: 'Courier New'"}[ = [new]{style="COLOR: blue"} [ObservableCollection]{style="COLOR: #2b91af"}\<[TaskDetails]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                                                |
| [GanttItemSource = ]{style="FONT-FAMILY: 'Courier New'"}[GetDataSourceStartToStart();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                |
| [ObservableCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\<[TaskDetails]{style="COLOR: #2b91af"}\> GetDataSourceStartToStart()\                                                                              |
| {\                                                                                                                                                                                                                             |
| [ObservableCollection]{style="COLOR: #2b91af"}\<[TaskDetails]{style="COLOR: #2b91af"}\> task = [ObservableCollection]{style="COLOR: #2b91af"}\<[TaskDetails]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| [\                                                                                                                                                                                                                             |
| task.Add([new]{style="COLOR: blue"} [TaskDetails]{style="COLOR: #2b91af"} { TaskId = 1, TaskName = [\"Scope\"]{style="COLOR: #a31515"}, ]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                                |
| [                    StartDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 3), ]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                |
| [                    FinishDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 14),  Progress = 40d });\                                                                                             |
| task\[0\].Child.Add([new]{style="COLOR: blue"} [TaskDetails]{style="COLOR: #2b91af"} { TaskId = 2, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                |
| [                    TaskName = [\"Determine project office scope\"]{style="COLOR: #a31515"}, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                |
| [                    StartDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 3), ]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                |
| [                    FinishDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 5), ]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [                    Progress = 20d });\                                                                                                                                                                                       |
| task\[0\].Child.Add([new]{style="COLOR: blue"} [TaskDetails]{style="COLOR: #2b91af"} { TaskId = 3, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                |
| [                    TaskName = [\"Justify Project Offfice via business model\"]{style="COLOR: #a31515"}, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                                |
| [                    StartDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 6), ]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                |
| [                    FinishDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 7), ]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [                    Duration = [new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(1, 0, 0, 0), ]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                |
| [                    Progress = 20d });\                                                                                                                                                                                       |
| task\[0\].Child.Add([new]{style="COLOR: blue"} [TaskDetails]{style="COLOR: #2b91af"} { TaskId = 4, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                |
| [                    TaskName = [\"Secure executive sponsorship\"]{style="COLOR: #a31515"}, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                |
| [                    StartDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 10), ]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [                    FinishDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 14), ]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                |
| [                    Duration = [new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(1, 0, 0, 0), ]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                |
| [                    Progress = 20d });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                |
| [task\[0\].Child.Add([new]{style="COLOR: blue"} [TaskDetails]{style="COLOR: #2b91af"} { TaskId = 5, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                                |
| [                    TaskName = [\"Secure complete\"]{style="COLOR: #a31515"}, ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                |
| [                    StartDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 14), ]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [                    FinishDate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2011, 1, 14), ]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                |
| [                    Duration = [new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(1, 0, 0, 0), ]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                |
| [                    Progress = 20d });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                |
| [return ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[task;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                |
| [}\                                                                                                                                                                                                                            |
| \                                                                                                                                                                                                                              |
| ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
