::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Setting Default Project Properties {#setting-default-project-properties style="tab-stops: 0pt"}

The following example shows how to set the default project properties.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                        |
| [// Creating a new instance of the Project object]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                   |
|                                                                                                                                                        |
| [Project]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ project = new [Project();]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                        |
| [// Setting Project Default information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                             |
|                                                                                                                                                        |
| [project.DefaultStartTime = [new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(8, 0, 0);]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                        |
| [project.DefaultFinishTime = [new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(17, 0, 0);]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                        |
| [project.DefaultStandardRate = 0f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                        |
| [project.DefaultOvertimeRate = 0f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                        |
| [project.DefaultTaskEVMethod = [EarnedValueMethod]{style="COLOR: #2b91af"}.PercentComplete;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                        |
| [project.DefaultFixedCostAccrual = [DefaultFixedCostAccrual]{style="COLOR: #2b91af"}.Prorated;]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                        |
| [// Saving the Project]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                        |
| [project.Save([\"DefaultProjectProperties.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                    |
|                                                                                                                                                                               |
| [\' Creating an instance of a Project]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                      |
|                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ project [As]{style="COLOR: blue"} Project = [New]{style="COLOR: blue"} Project()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [\' Setting Project information]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                            |
|                                                                                                                                                                               |
| [project.DefaultStartTime = [New]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(8, 0, 0)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                               |
| [project.DefaultFinishTime = [New]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(17, 0, 0)]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                               |
| [project.DefaultStandardRate = 0.0F]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                               |
| [project.DefaultOvertimeRate = 0.0F]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                               |
| [project.DefaultTaskEVMethod = [EarnedValueMethod]{style="COLOR: #2b91af"}.PercentComplete]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                               |
| [project.DefaultFixedCostAccrual = [DefaultFixedCostAccrual]{style="COLOR: #2b91af"}.Prorated]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                               |
| [\' Saving the Project]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                               |
| [project.Save([\"DefaultProjectProperties.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
