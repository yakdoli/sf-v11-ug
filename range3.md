::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Range {#range style="tab-stops: 0pt"}

This feature allows you to set the minimum, maximum and the increment values of the ProgressBar.

The Minimum value specifies the value at which the progress bar shows the process to have started.

The Maximum value specifies the value at which the progress bar shows the process to have completed.

The Step value specifies the value at which the progress bar shows the next step of the process to have started---it is an increment value.

For more details, refer to the [properties table]{style="FONT-FAMILY: 'Arial','sans-serif'"}.

You can implement the range of the progress bar in the following ways:

Using Builder

1.   In **View**, invoke the ProgressBar helper with the control ID as an argument, followed by the range method, with the desired value as an argument.

 

+---------------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                                 |
| [  [\<%]{style="BACKGROUND: yellow"}{]{style="COLOR: black"}                                                                    |
|                                                                                                                                 |
| [          Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                                 |
| [           .Maximum(100)]{style="COLOR: black"}                                                                                |
|                                                                                                                                 |
| [           .Minimum(10)]{style="COLOR: black"}                                                                                 |
|                                                                                                                                 |
| [           .Value(15)]{style="COLOR: black"}                                                                                   |
|                                                                                                                                 |
| [           .StepValue(0)]{style="COLOR: black"}                                                                                |
|                                                                                                                                 |
| [           .Render();]{style="COLOR: black"}                                                                                   |
|                                                                                                                                 |
| [      } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                               |
|                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                                           |
|                                                                                                                                 |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                 |
| [       Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}    |
|                                                                                                                                 |
| [       .Maximum(100)]{style="COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [       .Minimum(10)]{style="COLOR: black"}                                                                                     |
|                                                                                                                                 |
| [       .Value(15)]{style="COLOR: black"}                                                                                       |
|                                                                                                                                 |
| [       .StepValue(0)]{style="COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [       .Render();]{style="COLOR: black"}                                                                                       |
|                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}   |
|                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

2.   Build and run the application.

 

Using PropertiesModel

1.   In the controller, create an instance of the ProgressBarPropertiesModel

2.   Define the Range property and pass the instance through the view-specific data to the view.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [ ]{style="COLOR: black"}[public]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ActionResult]{style="COLOR: #2b91af"}[ Index()]{style="COLOR: black"}                                                                                                       |
|                                                                                                                                                                                                                                                             |
| [        {]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[ model = ]{style="COLOR: black"}[new]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[();]{style="COLOR: black"} |
|                                                                                                                                                                                                                                                             |
| [            model.Minimum = 10;]{style="COLOR: black"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            model.Maximum = 100;]{style="COLOR: black"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [            model.Value = 15;]{style="COLOR: black"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                             |
| [            model.StepValue = 0;]{style="COLOR: black"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [            ViewData\[]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[\] = model;]{style="COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[return]{style="COLOR: blue"}[ View();]{style="COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [        }]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

3.   In View, invoke the ProgressBar helper with the view data key as the control ID

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                            |
| [    [\<%]{style="BACKGROUND: yellow"}{ Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[).Render(); } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"} |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                              |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                              |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                              |
|                                                                                                                                                                                                                                                                              |
| [               ]{style="COLOR: black; FONT-SIZE: 12pt"}[Html.Syncfusion().ProgressBar(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Progress\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[).Render(); ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                |
|                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

4.   Build and run the application, the output will be as follows:

 

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image56_183.png){border="0"}

Figure 172: ProgressBar with range set

 

**[]{style="FONT-STYLE: normal"}** 

[]{#related-topics}
:::
