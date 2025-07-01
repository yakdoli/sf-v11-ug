::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Client-side events {#client-side-events style="tab-stops: 0pt"}

 

  --------------------------------- --------------------------------------------------------------------------------------------- ------------ -----------------
  Name                              Description                                                                                   Arguments    Reference Links
  ClientSideOnCreate                This event is triggered when progressbar is created.                                          event,args   NA
  ClientSideOnChange                This event is triggered when the value of the progressbar changes.                            event,args   NA
  ClientSideOnComplete              This event is triggered when the value of the progressbar reaches the maximum value of 100.   event,args   NA
  ClientSideOnCustomTextRendering   This event is triggered when the custom value is added with the progressbar value.            event,args   NA
  --------------------------------- --------------------------------------------------------------------------------------------- ------------ -----------------

 

You can handle client-side events using the following two ways-

 

**[Using Builder]{style="COLOR: black"}**

The following steps guide in handling client side events through Builder:

1.   In **View**, [invoke the ProgressBar helper with the **ProgressBar** **id** as the first argument ]{style="BACKGROUND: white; COLOR: black"}followed[ by the **Client side events**.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                    |
| [\<%]{style="BACKGROUND: yellow; COLOR: black"}[{]{style="COLOR: black"}                                                           |
|                                                                                                                                    |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}        |
|                                                                                                                                    |
| [      .Height(22)]{style="COLOR: black"}                                                                                          |
|                                                                                                                                    |
| [      .Width(700)]{style="COLOR: black"}                                                                                          |
|                                                                                                                                    |
| [      .Value(50)]{style="COLOR: black"}                                                                                           |
|                                                                                                                                    |
| [      .AllowCustomText(]{style="COLOR: black"}[true]{style="COLOR: blue"}[)]{style="COLOR: black"}                                |
|                                                                                                                                    |
| [      .Orientation(]{style="COLOR: black"}[ProgressBarOrientation]{style="COLOR: #2b91af"}[.Horizontal)]{style="COLOR: black"}    |
|                                                                                                                                    |
| [      .Minimum(10)]{style="COLOR: black"}                                                                                         |
|                                                                                                                                    |
| [      .Maximum(100)]{style="COLOR: black"}                                                                                        |
|                                                                                                                                    |
| [      .ClientSideOnChange(]{style="COLOR: black"}[\"onChange\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                  |
|                                                                                                                                    |
| [      .ClientSideOnCreate(]{style="COLOR: black"}[\"onCreate\"]{style="COLOR: #a31515"}[) ]{style="COLOR: black"}                 |
|                                                                                                                                    |
| [      .ClientSideOnComplete(]{style="COLOR: black"}[\"onComplete\"]{style="COLOR: #a31515"}[)      ]{style="COLOR: black"}        |
|                                                                                                                                    |
| [      .ClientSideOnCustomTextRendering(]{style="COLOR: black"}[\"onCustomText\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                                    |
| [      .Render() ;]{style="COLOR: black"}                                                                                          |
|                                                                                                                                    |
| [  } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------+
| [ ]{style="FONT-SIZE: 12pt"}[\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                  |
|                                                                                                                                    |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                       |
|                                                                                                                                    |
| [\@{]{style="BACKGROUND: yellow; COLOR: black"}[   ]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 12pt"}   |
|                                                                                                                                    |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}        |
|                                                                                                                                    |
| [      .Height(22)]{style="COLOR: black"}                                                                                          |
|                                                                                                                                    |
| [      .Width(700)]{style="COLOR: black"}                                                                                          |
|                                                                                                                                    |
| [      .Value(50)]{style="COLOR: black"}                                                                                           |
|                                                                                                                                    |
| [      .AllowCustomText(]{style="COLOR: black"}[true]{style="COLOR: blue"}[)]{style="COLOR: black"}                                |
|                                                                                                                                    |
| [      .Orientation(]{style="COLOR: black"}[ProgressBarOrientation]{style="COLOR: #2b91af"}[.Horizontal)]{style="COLOR: black"}    |
|                                                                                                                                    |
| [      .Minimum(10)]{style="COLOR: black"}                                                                                         |
|                                                                                                                                    |
| [      .Maximum(100)]{style="COLOR: black"}                                                                                        |
|                                                                                                                                    |
| [      .ClientSideOnChange(]{style="COLOR: black"}[\"onChange\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}                  |
|                                                                                                                                    |
| [      .ClientSideOnCreate(]{style="COLOR: black"}[\"onCreate\"]{style="COLOR: #a31515"}[) ]{style="COLOR: black"}                 |
|                                                                                                                                    |
| [      .ClientSideOnComplete(]{style="COLOR: black"}[\"onComplete\"]{style="COLOR: #a31515"}[)      ]{style="COLOR: black"}        |
|                                                                                                                                    |
| [      .ClientSideOnCustomTextRendering(]{style="COLOR: black"}[\"onCustomText\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                                    |
| [      .Render() ;]{style="COLOR: black"}                                                                                          |
|                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}      |
|                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

[2.   [In Javascript, use the methods to enable and disable an item as follows:]{style="BACKGROUND: white"}]{style="COLOR: black"}

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                          |
| [\<[script]{style="COLOR: maroon"} [type]{style="COLOR: red"}=\"text/javascript\"\>]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onComplete(sender, args)]{style="COLOR: black"}                                                                                                         |
|                                                                                                                                                                                          |
| [ {]{style="COLOR: black"}                                                                                                                                                               |
|                                                                                                                                                                                          |
| [            //args:]{style="COLOR: darkgreen"}                                                                                                                                          |
|                                                                                                                                                                                          |
|             [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}                                                                                               |
|                                                                                                                                                                                          |
|             [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}[]{style="COLOR: black"}                                                                      |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onCreate(sender, args)]{style="COLOR: black"}                                                                                                           |
|                                                                                                                                                                                          |
| [ {]{style="COLOR: black"}                                                                                                                                                               |
|                                                                                                                                                                                          |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                          |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                          |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onChange(sender, args) ]{style="COLOR: black"}                                                                                                          |
|                                                                                                                                                                                          |
| [{]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                          |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                          |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onCustomText(sender, args)]{style="COLOR: black"}                                                                                                       |
|                                                                                                                                                                                          |
| [ {]{style="COLOR: black"}                                                                                                                                                               |
|                                                                                                                                                                                          |
| [ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[  //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                          |
| [              [//  \_Value                - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                          |
| [             [// \_ProgressBar        -Details of the ProgressBar   ]{style="COLOR: darkgreen"}[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                          |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[        [//  \_Context              -Context of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [    ]{style="COLOR: black"}       [//  \_Width =  width of the ]{style="COLOR: #3b4a1e"}[ProgressBar]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                              |
|                                                                                                                                                                                          |
| [           //  \_OffsetX = OffsetX of the ]{style="COLOR: #3b4a1e"}[ProgressBar text]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                              |
|                                                                                                                                                                                          |
| [           //  \_OffsetY = OffsetY of the ]{style="COLOR: #3b4a1e"}[ProgressBar text]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                              |
|                                                                                                                                                                                          |
| [             //  \_Height = height of the ]{style="COLOR: #3b4a1e"}[ProgressBar]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                                   |
|                                                                                                                                                                                          |
| [            // \_Radius = radius of the ]{style="COLOR: #3b4a1e"}[ProgressBar]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                                     |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| \</[script\>]{style="COLOR: maroon"}                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Using Properties Model

The following steps guide in handling client side events through the Properties model.

1.   [In ]{style="BACKGROUND: white; COLOR: black"}Controller[, create an object for the **ProgressBarModel** class and set the **ClientSide Events**. Assign this model class to view data.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

::: {align="center"}
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                             |
| [public]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ActionResult]{style="COLOR: #2b91af"}[ Index()]{style="COLOR: black"}                                                                                                                                |
|                                                                                                                                                                                                                                                             |
| [        {]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[ model = ]{style="COLOR: black"}[new]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[();]{style="COLOR: black"} |
|                                                                                                                                                                                                                                                             |
| [            model.Height = 22;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            model.Width = 700;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            model.Value = 50;]{style="COLOR: black"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                             |
| [            model.AllowCustomText = ]{style="COLOR: black"}[true]{style="COLOR: blue"}[;]{style="COLOR: black"}                                                                                                                                            |
|                                                                                                                                                                                                                                                             |
| [            model.Orientation = ]{style="COLOR: black"}[ProgressBarOrientation]{style="COLOR: #2b91af"}[.Horizontal;]{style="COLOR: black"}                                                                                                                |
|                                                                                                                                                                                                                                                             |
| [            model.Minimum = 10;]{style="COLOR: black"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            model.Maximum = 100;]{style="COLOR: black"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [            model.ClientSideOnChange = ]{style="COLOR: black"}[\"onChange\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                                                                                             |
| [            model.ClientSideOnCreate = ]{style="COLOR: black"}[\"onCreate\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                                                                                             |
| [            model.ClientSideOnComplete = ]{style="COLOR: black"}[\"onComplete\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                                          |
|                                                                                                                                                                                                                                                             |
| [            model.ClientSideOnCustomTextRendering = ]{style="COLOR: black"}[\"onCustomText\"]{style="COLOR: #a31515"}[;]{style="COLOR: black"}                                                                                                             |
|                                                                                                                                                                                                                                                             |
| [            ViewData\[]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[\] = model;]{style="COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[return]{style="COLOR: blue"}[ View();]{style="COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [        }]{style="COLOR: black"}                                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: black"} 

[2.   ]{style="COLOR: black"}In View, invoke the ProgressBar helper with the view data key as the control ID[.]{style="BACKGROUND: white; COLOR: black"}[]{style="COLOR: black"}

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                 |
| [\<%]{style="BACKGROUND: yellow; COLOR: black"}[{]{style="COLOR: black"}                                                        |
|                                                                                                                                 |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}     |
|                                                                                                                                 |
| [      .Render();]{style="COLOR: black"}                                                                                        |
|                                                                                                                                 |
| [  } [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

::: {align="center"}
+----------------------------------------------------------------------------------------------------------------------------------+
| [ ]{style="FONT-SIZE: 12pt"}[\[Razor\]]{style="BACKGROUND: yellow; COLOR: black"}                                                |
|                                                                                                                                  |
| []{style="BACKGROUND: yellow; COLOR: black"}                                                                                     |
|                                                                                                                                  |
| [\@{]{style="BACKGROUND: yellow; COLOR: black"}[   ]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 12pt"} |
|                                                                                                                                  |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"}      |
|                                                                                                                                  |
| [      .Render();]{style="COLOR: black"}                                                                                         |
|                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}    |
+----------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: black"} 

[3.   ]{style="COLOR: black"}In **[Javascript]{style="BACKGROUND: white; COLOR: black"}**[, define the function to handle the specified events:]{style="BACKGROUND: white; COLOR: black"}[]{style="COLOR: black"}

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                          |
| [\<[script]{style="COLOR: maroon"} [type]{style="COLOR: red"}=\"text/javascript\"\>]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onComplete(sender, args)]{style="COLOR: black"}                                                                                                         |
|                                                                                                                                                                                          |
| [ {]{style="COLOR: black"}                                                                                                                                                               |
|                                                                                                                                                                                          |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                          |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                          |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onCreate(sender, args)]{style="COLOR: black"}                                                                                                           |
|                                                                                                                                                                                          |
| [ {]{style="COLOR: black"}                                                                                                                                                               |
|                                                                                                                                                                                          |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                          |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                          |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onChange(sender, args) ]{style="COLOR: black"}                                                                                                          |
|                                                                                                                                                                                          |
| [{]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [            //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                          |
| [            [//  \_Value             - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                          |
| [            [// \_ProgressBar        -Details of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [function]{style="COLOR: blue"}[ onCustomText(sender, args)]{style="COLOR: black"}                                                                                                       |
|                                                                                                                                                                                          |
| [ {]{style="COLOR: black"}                                                                                                                                                               |
|                                                                                                                                                                                          |
| [ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[  //args:]{style="FONT-FAMILY: 'Courier New'; COLOR: darkgreen"}[]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                          |
| [              [//  \_Value                - Value of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                          |
| [             [// \_ProgressBar        -Details of the ProgressBar   ]{style="COLOR: darkgreen"}[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                          |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[        [//  \_Context              -Context of the ProgressBar]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                          |
| [    ]{style="COLOR: black"}       [//  \_Width =  width of the ]{style="COLOR: #3b4a1e"}[ProgressBar]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                              |
|                                                                                                                                                                                          |
| [           //  \_OffsetX = OffsetX of the ]{style="COLOR: #3b4a1e"}[ProgressBar text]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                              |
|                                                                                                                                                                                          |
| [           //  \_OffsetY = OffsetY of the ]{style="COLOR: #3b4a1e"}[ProgressBar text]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                              |
|                                                                                                                                                                                          |
| [             //  \_Height = height of the ]{style="COLOR: #3b4a1e"}[ProgressBar]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                                   |
|                                                                                                                                                                                          |
| [            // \_Radius = radius of the ]{style="COLOR: #3b4a1e"}[ProgressBar]{style="COLOR: darkgreen"}[;]{style="COLOR: #3b4a1e"}                                                     |
|                                                                                                                                                                                          |
| [}]{style="COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                          |
| [\</[script\>]{style="COLOR: maroon"}[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: black; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::::
