::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Retrieving Default Project Properties {#retrieving-default-project-properties style="tab-stops: 0pt"}

The following example illustrates how to retrieve default project properties.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                              |
|                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                               |
| [// Calling Open method of ProjectReader to get the Project object]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                         |
|                                                                                                                                                                                                               |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = [ProjectReader]{style="COLOR: #2b91af"}.Open([\"Sample Project.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [// Retrieving Project Default information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Default Start Time: \"]{style="COLOR: #a31515"} + project.DefaultStartTime);]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Default Finish Time: \"]{style="COLOR: #a31515"} + project.DefaultFinishTime);]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Default Standard Rate: \"]{style="COLOR: #a31515"} + project.DefaultStandardRate);]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Default Overtime Rate: \"]{style="COLOR: #a31515"} + project.DefaultOvertimeRate);]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Default Task EV Method: \"]{style="COLOR: #a31515"} + project.DefaultTaskEVMethod);]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                               |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.WriteLine([\"Default Cost Accrual: \"]{style="COLOR: #a31515"} + project.DefaultFixedCostAccrual);]{style="FONT-FAMILY: 'Courier New'"}        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                              |
|                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                               |
| [\' Creating an instance of Project]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = ProjectReader.Open([\"Sample Project.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [\' Retriving Project information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                               |
| [Console.WriteLine([\"Default Start Time: \"]{style="COLOR: #a31515"} & project.DefaultStartTime.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [Console.WriteLine([\"Default Finish Time: \"]{style="COLOR: #a31515"} & project.DefaultFinishTime.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [Console.WriteLine([\"Default Standard Rate: \"]{style="COLOR: #a31515"} & project.DefaultStandardRate)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                               |
| [Console.WriteLine([\"Default Overtime Rate: \"]{style="COLOR: #a31515"} & project.DefaultOvertimeRate)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                               |
| [Console.WriteLine([\"Default Task EV Method: \"]{style="COLOR: #a31515"} & project.DefaultTaskEVMethod)]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                               |
| [Console.WriteLine([\"Default Cost Accrual: \"]{style="COLOR: #a31515"} & project.DefaultFixedCostAccrual)]{style="FONT-FAMILY: 'Courier New'"}                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
