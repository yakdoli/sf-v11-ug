::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Setting Week Day Properties {#setting-week-day-properties style="tab-stops: 0pt"}

The following code snippet illustrates how to set the Week day properties of a project.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                        |
| [// Creating a new Project instance]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                 |
|                                                                                                                                                        |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = new [Project();]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                        |
| [// Setting week day properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                        |
| [project.WeekStartDay = [WeekStartDay]{style="COLOR: #2b91af"}.Monday;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                        |
| [project.DaysPerMonth = 24;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                        |
| [project.MinutesPerDay = 480;]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                        |
| [project.MinutesPerWeek = 2880;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                        |
| [//Saving the project]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                        |
| [project.Save([\"WeekDayProperties.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                    |
|                                                                                                                                                                               |
| [\' Creating a new Project instance]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = [New]{style="COLOR: blue"} Project()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [\' Setting Week day properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                            |
|                                                                                                                                                                               |
| [project.WeekStartDay = WeekStartDay.Monday]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                               |
| [project.DaysPerMonth = 24]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                               |
| [project.MinutesPerDay = 480]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                               |
| [project.MinutesPerWeek = 2880]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [\' Saving the Project]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                               |
| [project.Save([\"WeekDayProperties.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
