::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Retrieving Week Day Properties {#retrieving-week-day-properties style="tab-stops: 0pt"}

The following code snippets illustrate how to retrieve the Week day properties of a project.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [// Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = Syncfusion.ProjIO.[ProjectReader]{style="COLOR: #2b91af"}.Open([\"Sample Project.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [// Retrieving Week day properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Weeks starts on: \"]{style="COLOR: #a31515"} + project.WeekStartDay);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No. of working days per month: \"]{style="COLOR: #a31515"} + project.DaysPerMonth);]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No.of minutes per day: \"]{style="COLOR: #a31515"} + project.MinutesPerDay);]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                                 |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No. of minutes per week: \"]{style="COLOR: #a31515"} + project.MinutesPerWeek);]{style="FONT-FAMILY: 'Courier New'"}                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                              |
|                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                               |
| [\' Opening the project file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                               |
|                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = ProjectReader.Open([\"Sample Project.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [\' Retrieving Week day properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Weeks starts on: \"]{style="COLOR: #a31515"} + project.WeekStartDay)]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No. of working days per month: \"]{style="COLOR: #a31515"} + project.DaysPerMonth)]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No.of minutes per day: \"]{style="COLOR: #a31515"} + project.MinutesPerDay)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"No. of minutes per week: \"]{style="COLOR: #a31515"} + project.MinutesPerWeek)]{style="FONT-FAMILY: 'Courier New'"}               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
