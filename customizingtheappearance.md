::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Customizing the appearance {#customizing-the-appearance style="tab-stops: 0pt"}

You can customize the appearance of the progress bar using Builder, or the properties model, as shown in the code snippets below.\
\

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: The Progress Bar doesn't support the built-in skins as other controls do, since it is designed using the Canvas element in HTML 5.
:::

 

In order for you to get familiar with the properties we use here, refer to the [properties table]{style="FONT-FAMILY: 'Arial','sans-serif'"}.

1.   In **View**, invoke the ProgressBar helper with the control ID as an argument and define the appearance properties of the ProgressBar.

 

+---------------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                                 |
| [\<%]{style="BACKGROUND: yellow; COLOR: black"}[{]{style="COLOR: black"}                                                        |
|                                                                                                                                 |
| [          Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                                 |
| [          .Value(75)]{style="COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [          .ProgressBarBorderColor(]{style="COLOR: black"}[\"Black\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}          |
|                                                                                                                                 |
| [          .ProgressBarColor(]{style="COLOR: black"}[\"green\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                |
|                                                                                                                                 |
| [          .ProgressBarFontFamily(]{style="COLOR: black"}[\"Arial\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}           |
|                                                                                                                                 |
| [          .ProgressBarTextColor(]{style="COLOR: black"}[\"White\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}            |
|                                                                                                                                 |
| [          .ProgressBarTextFontSize(18)]{style="COLOR: black"}                                                                  |
|                                                                                                                                 |
| [          .BackgroundColor(]{style="COLOR: black"}[\"white\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                 |
|                                                                                                                                 |
| [          .BorderColor(]{style="COLOR: black"}[\"black\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                     |
|                                                                                                                                 |
| [          .Height(22)]{style="COLOR: black"}                                                                                   |
|                                                                                                                                 |
| [          .Width(500)]{style="COLOR: black"}                                                                                   |
|                                                                                                                                 |
| [          .Render();]{style="COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [      } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                               |
|                                                                                                                                 |
|                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                                           |
|                                                                                                                                 |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                 |
| [          Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                                 |
| [          .Value(75)]{style="COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [          .ProgressBarBorderColor(]{style="COLOR: black"}[\"Black\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}          |
|                                                                                                                                 |
| [          .ProgressBarColor(]{style="COLOR: black"}[\"green\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                |
|                                                                                                                                 |
| [          .ProgressBarFontFamily(]{style="COLOR: black"}[\"Arial\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}           |
|                                                                                                                                 |
| [          .ProgressBarTextColor(]{style="COLOR: black"}[\"White\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}            |
|                                                                                                                                 |
| [          .ProgressBarTextFontSize(18)]{style="COLOR: black"}                                                                  |
|                                                                                                                                 |
| [          .BackgroundColor(]{style="COLOR: black"}[\"white\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                 |
|                                                                                                                                 |
| [          .BorderColor(]{style="COLOR: black"}[\"black\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                     |
|                                                                                                                                 |
| [          .Height(22)]{style="COLOR: black"}                                                                                   |
|                                                                                                                                 |
| [          .Width(500)]{style="COLOR: black"}                                                                                   |
|                                                                                                                                 |
| [          .Render();]{style="COLOR: black"}                                                                                    |
|                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}   |
|                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

2.   Build and run the application.

 

Using PropertiesModel

1.   In the controller, create an instance of the ProgressBarPropertiesModel

2.   Define the appearance properties and pass the instance through the view-specific data to the view.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                             |
| [public]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ActionResult]{style="COLOR: #2b91af"}[ Index()]{style="COLOR: black"}                                                                                                                                |
|                                                                                                                                                                                                                                                             |
| [        {]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[ model = ]{style="COLOR: black"}[new]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[();]{style="COLOR: black"} |
|                                                                                                                                                                                                                                                             |
| [            model.Value = 75;]{style="COLOR: black"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                             |
| [            model.BackgroundColor = ]{style="COLOR: black"}[\"white\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [            model.BorderColor = ]{style="COLOR: black"}[\"black\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                                        |
|                                                                                                                                                                                                                                                             |
| [            model.ProgressBarBorderColor = ]{style="COLOR: black"}[\"Black\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                             |
|                                                                                                                                                                                                                                                             |
| [            model.ProgressBarColor = ]{style="COLOR: black"}[\"green\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                                   |
|                                                                                                                                                                                                                                                             |
| [            model.ProgressBarFontFamily = ]{style="COLOR: black"}[\"Arial\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                                                                                             |
| [            model.ProgressBarTextColor = ]{style="COLOR: black"}[\"White\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                               |
|                                                                                                                                                                                                                                                             |
| [            model.ProgressBarTextFontSize = 18;]{style="COLOR: black"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            model.Width = 500;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            model.Height = 22;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            ViewData\[]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[\] = model;]{style="COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[return]{style="COLOR: blue"}[ View();]{style="COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [        }]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

3.   In View, invoke the ProgressBar helper with the view data key as the control ID.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                            |
| [    [\<%]{style="BACKGROUND: yellow"}{ Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[).Render(); } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"} |
|                                                                                                                                                                                                            |
|                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                |
|                                                                                                                                                                                                                                |
| [          Html.Syncfusion().ProgressBar(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Progress\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[).Render(); ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                  |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt"} 

4.   Build the output. You will get the following result:

 

![](ImagesExt/image56_186.png){border="0"}

Figure 175: Progress Bar with customized appearance**[]{style="FONT-STYLE: normal"}**

 

[]{#related-topics}
::::
