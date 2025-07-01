::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Orientation {#orientation style="tab-stops: 0pt"}

You can set the orientation of the Progress bar, using the following code that implements the properties from the [properties table]{style="FONT-FAMILY: 'Arial','sans-serif'"}.

Using Builder

1.   In **View**, invoke the ProgressBar helper with the control ID as an argument, followed by the Orientation method, with the desired orientation as an argument.

 

+-------------------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                  |
|                                                                                                                                     |
| [ [\<%]{style="BACKGROUND: yellow"}{]{style="COLOR: black"}                                                                         |
|                                                                                                                                     |
| [          Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}     |
|                                                                                                                                     |
| [            .Orientation(]{style="COLOR: black"}[ProgressBarOrientation]{style="COLOR: #2b91af"}[.Vertical)]{style="COLOR: black"} |
|                                                                                                                                     |
| [            .Width(250)]{style="COLOR: black"}                                                                                     |
|                                                                                                                                     |
| [            .Render();]{style="COLOR: black"}                                                                                      |
|                                                                                                                                     |
| [      } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                                   |
|                                                                                                                                     |
|                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                                           |
|                                                                                                                                 |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                 |
| [       Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}    |
|                                                                                                                                 |
| [       .Orientation(]{style="COLOR: black"}[ProgressBarOrientation]{style="COLOR: #2b91af"}[.Vertical)]{style="COLOR: black"}  |
|                                                                                                                                 |
| [       .Width(250)]{style="COLOR: black"}                                                                                      |
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

1.   In the controller, create an instance of the **ProgressBarPropertiesModel.**

2.   Define the Orientation property and pass the instance through the view-specific data to the view.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[Controller\]**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                             |
| []{style="COLOR: blue"}                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [public]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ActionResult]{style="COLOR: #2b91af"}[ Index()]{style="COLOR: black"}                                                                                                                                |
|                                                                                                                                                                                                                                                             |
| [        {]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[ model = ]{style="COLOR: black"}[new]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[();]{style="COLOR: black"} |
|                                                                                                                                                                                                                                                             |
| [            model.Orientation = ]{style="COLOR: black"}[ProgressBarOrientation]{style="COLOR: #2b91af"}[.Vertical;]{style="COLOR: black"}                                                                                                                  |
|                                                                                                                                                                                                                                                             |
| [            model.Width = 250;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            ViewData\[]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[\] = model;]{style="COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[return]{style="COLOR: blue"}[ View();]{style="COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [        }]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-SIZE: 12pt"}                                                                                                                                                                                                                                 |
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

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                             |
|                                                                                                                                                                                                                             |
| [       Html.Syncfusion().ProgressBar(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Progress\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[).Render(); ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                               |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

4.   Build and run the application, the output will be as follows:

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image56_184.png){border="0"}

Figure 173: ProgressBar with a vertical orientation**[]{style="FONT-STYLE: normal"}**

 

[]{#related-topics}
:::
