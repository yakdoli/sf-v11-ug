::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Add StyleManager to an Application {#add-stylemanager-to-an-application style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

Add the **StyleManager** extension method in the [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[head]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} element of the view pages (in most cases, it is reasonable to call it within the Site.Master page).[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[head]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}     |
|                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                            |
| [...]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                            |
| [...\                                                                                                                                                                                                                                                                      |
| [\</]{style="COLOR: blue"}[head]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                    |
|                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[head]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                  |
|                                                                                                                                                                                                                                                                                                         |
| [   [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                         |
| [        .Register(stylesheets =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                         |
| [             ]{style="FONT-FAMILY: 'Courier New'"}[stylesheets]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Add([ComponentType]{style="COLOR: #2b91af"}.]{style="FONT-FAMILY: 'Courier New'"}[Schedule]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                         |
| [            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [\                                                                                                                                                                                                                                                                                                      |
| [\</]{style="COLOR: blue"}[head]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Use the **Register()** method to register the Syncfusion component's CSS resources.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                  |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                  |
|                                                                                                                                                     |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\ |
|         .Register(styleSheet =\> \                                                                                                                  |
|             {\                                                                                                                                      |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                      |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                     |
| [                . . .\                                                                                                                             |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}            |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [   [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                    |
|                                                                                                                                                                                                            |
| [        .Register(stylesheets =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                       |
|                                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                           |
|                                                                                                                                                                                                            |
| [             ]{style="FONT-FAMILY: 'Courier New'"}[stylesheets]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                        |
|                                                                                                                                                                                                            |
| [            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

The code above registers the default Office2007Blue theme for added components. All the CSS resources are combined and minified before being sent to the browser.

 

Customization

Various customization options have been provided. They are:

 

[·      ]{style="FONT-FAMILY: Symbol"}Minify

[·      ]{style="FONT-FAMILY: Symbol"}Combine

[·      ]{style="FONT-FAMILY: Symbol"}Register

[·      ]{style="FONT-FAMILY: Symbol"}Theme

[·      ]{style="FONT-FAMILY: Symbol"}Add CSS files

 

Minify

 

To enable or disable the minify feature, use the **Minify()** method. Minify is enabled by default.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                       |
|                                                                                                                                                                                                                                                                                 |
| [         **.Minify([false]{style="COLOR: blue"})**]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                 |
| [        .Register(styleSheet =\> \                                                                                                                                                                                                                                             |
|             {\                                                                                                                                                                                                                                                                  |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                  |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                 |
| [                . . .\                                                                                                                                                                                                                                                         |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                    |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                    |
| [        ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[.Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}**[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                                    |
| [        .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                    |
| [            {                                           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                    |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                                                                    |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                    |
| [                . . .\                                                                                                                                                                                                                                                                                                            |
| ]{style="FONT-FAMILY: 'Courier New'"}[            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[}).Render();  [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                          |
|                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Please refer to the HTTP requests and the time details from the images below.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

**Before:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_9.jpg](ImagesExt/image58_10.jpg){border="0"}

Figure 5: Minify Disabled.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

**After:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_10.jpg](ImagesExt/image58_11.jpg){border="0"}

Figure 6: Minify Enabled

The preceding images show the size of the resource files before and after the minfication process. Before the minification process a 19-KB file is downloaded in the browser (Figure 5), whereas after minification a 14.5-KB file is downloaded in the browser (Figure 6). 4.5 KB size reduced in the minification process sample above.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Combine

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

To enable or disable the combine file feature, use the **Combine()** method. Combine is enabled by default.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                     |
|                                                                                                                                                                                                                                                                               |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable ordisable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                               |
| **[         .Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}**[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                          |
|                                                                                                                                                                                                                                                                               |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                                                          |
|             {\                                                                                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [                . . .\                                                                                                                                                                                                                                                       |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                     |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                           |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                |
|                                                                                                                                                                                                                                                                                           |
| [          ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}             |
|                                                                                                                                                                                                                                                                                           |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**[.Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}**[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                           |
| [          .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                            |
|                                                                                                                                                                                                                                                                                           |
| [            {                                           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                           |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                           |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                           |
| [                . . .\                                                                                                                                                                                                                                                                   |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                                           |
| [}]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Please refer to the HTTP requests and the time details from the following images:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

**Before:**

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_11.jpg](ImagesExt/image58_12.jpg){border="0"}

[Figure]{#_Ref311798756} 7: Combine Disabled[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

**After:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_12.jpg](ImagesExt/image58_13.jpg){border="0"}

[Figure]{#_Ref311798767} 8: Combine Enabled

 

The images above show the downloading time before and after the resource files go through the combine process. Before the combine process, the browser takes 257 ms to download the CSS resources (Figure 7, whereas after the combine process it takes only 63 ms to download the resources (Figure 8). 194 ms of download time is reduced in the combine process sample above.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Register

Two overloads are available for the **Register()** method.

 

[1.    ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}Adding **StyleManager** to an application uses the first overload where the component name can be specified as a string separated by commas.

 

To add controls in a single line, use the **Register()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                                                                                                                                        |
|                                                                                                                                                                                                                                                  |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                                                              |
|                **.Register([\"Grid,Menu,Toolbar"]{style="COLOR: #a31515"})**[//Specify the component names   separated by a comma.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                  |
| [               [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                         |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                   |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                                                               |
|                **.Register([\"Grid,Menu,Toolbar\"]{style="COLOR: #a31515"})**[//Specify the component names   separated by a comma.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                   |
| [.Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"} 

[2.    ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}The second overload uses the [ComponentType]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}to register the controls.[ ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                        |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                    |
|                ]{style="FONT-FAMILY: 'Courier New'"}**[.Register]{style="FONT-FAMILY: 'Courier New'"}**[(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                        |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                        |
| [                stylesheets.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);                              ]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                        |
| [            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                        |
| [     [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**[ ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                  |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                 |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                     |
| [ [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                     |
| [        **.Register**(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                     |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                     |
| [                stylesheets.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);                               ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                     |
| [            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                     |
| [.Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

To avoid child control register, use the **DisableChildRegister()** method.

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

**For example:** A grid with paging and sorting features doesn't require sub-controls like Menu or Dialog (these sub-controls are used in the filtering feature). In order to avoid these child registers, use **DisableChildRegister()** as follows:

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable or disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                           |
|                                                                                                                                                                                                                                                                                |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify theme.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                                                           |
|             {\                                                                                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid)**.DisableChildRegister()**;\                                                                                                                                                                      |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [                . . .\                                                                                                                                                                                                                                                        |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [          ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                                                                                                               |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[.Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                                                                                                                                                               |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[.Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify theme.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                |
|                                                                                                                                                                                                                                                                               |
| [          .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                |
|                                                                                                                                                                                                                                                                               |
| [            {                                           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                               |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid)**.DisableChildRegister()**;\                                                                                                                                                                    |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [                . . .\                                                                                                                                                                                                                                                       |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                |
|                                                                                                                                                                                                                                                                               |
| [}]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

To enable or disable the sub-component registrations based on some condition, use the **AllowChildRegister()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                            |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                            |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                            |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                            |
| [         .Register(styleSheet =\> \                                                                                                                                                       |
|             {\                                                                                                                                                                             |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid)**.AllowChildRegister([true]{style="COLOR: blue"});**                 . . .]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [              . . .           \                                                                                                                                                           |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [          ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                                                                                                               |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[.Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                                                                                                                                                               |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[.Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify theme.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                |
|                                                                                                                                                                                                                                                                               |
| [          .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                |
|                                                                                                                                                                                                                                                                               |
| [            {                                           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                               |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid)**.AllowChildRegister([true]{style="COLOR: blue"});\**                                                                                                                                           |
| \                                                                                                                                                                                                                                                                             |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [                . . .\                                                                                                                                                                                                                                                       |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                               |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Theme

To register the CSS stylesheets for all controls, use the **Theme()** method. Office2007Blue is the default theme.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable or disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                           |
|                                                                                                                                                                                                                                                                                |
| [         **.Theme([Skins]{style="COLOR: #2b91af"}.Almond)**[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                 |
|                                                                                                                                                                                                                                                                                |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                                                           |
|             {\                                                                                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                 |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [                . . .\                                                                                                                                                                                                                                                        |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [          ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[.Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                                                                                                                                                                                                                                |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[.Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                             |
|                                                                                                                                                                                                                                                                                |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**[.Theme([Skins]{style="COLOR: #2b91af"}.Almond)]{style="FONT-FAMILY: 'Courier New'"}**[ // Specify theme.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                |
| [          .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                 |
|                                                                                                                                                                                                                                                                                |
| [            {                                           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid**;**\                                                                                                                                                                                             |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [                . . .\                                                                                                                                                                                                                                                        |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

To configure individual themes for every control use the **Theme()** method inside **Register()**.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                      |
|             {\                                                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid)**.Theme([Skins]{style="COLOR: #2b91af"}.Blend)**;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                     |
|                                                                                                                                                                                                                                           |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                      |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                         |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                 |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                   |
|                                                                                                                                                                                                      |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()          ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                      |
| [          .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                       |
|                                                                                                                                                                                                      |
| [            {                                           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                          |
|                                                                                                                                                                                                      |
| [                styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid)**.Theme([Skins]{style="COLOR: #2b91af"}.Blend)**;\                                                                     |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                      |
| [                . . .\                                                                                                                                                                              |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                      |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

In the code above, the Blend theme registers for the grid and the Office2007Blue theme registers all the other components.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

 

To avoid theme overrides by external **Theme()** methods, use the **DontOverride()** method. []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                     |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                     |
|                                                                                                                                                                                        |
| [  ]{style="FONT-FAMILY: Consolas"}[\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\ |
|       .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components]{style="COLOR: green"}.     ]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                        |
| [      .Register(styleSheet =\> \                                                                                                                                                      |
|       {\                                                                                                                                                                               |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid).Theme([Skins]{style="COLOR: #2b91af"}.Blend**).DontOverride();**\                                                 |
|         . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                        |
| [        . . .\                                                                                                                                                                        |
|       })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[\
\
]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager() ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                            |
|                                                                                                                                                                                                                        |
| [       .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components]{style="COLOR: green"}.    ]{style="FONT-FAMILY: 'Courier New'"}[         ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                        |
| [        .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                           |
|                                                                                                                                                                                                                        |
| [        {                                         ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                  |
|                                                                                                                                                                                                                        |
| [          styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid).Theme([Skins]{style="COLOR: #2b91af"}.Blend**). DontOverride();**\                                                                             |
|           . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [          . . .\                                                                                                                                                                                                      |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                        |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

In general, the external **Theme()** method overrides all the internal component themes registered. The **DontOverride()** method preserves the theme registered in the **Register()** method.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image58_6.jpg){border="0"}Note: The Theme () method will register the CSS style sheets for the specified theme in the the HEAD section of the HTML. Using this method, we cannot apply themes for the controls (cannot add CSS classes). If we don't use StyleManager then the CSS style sheet for default theme or specified theme will be registered just before the control rendering starts. The StyleManager is introduced to improve the performance using its minify and combine features.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Add CSS Files

To add the application CSS files to StyleManager, use the **Add()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                  |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                              |
|         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify theme to all components.]{style="COLOR: green"}\                                                               |
|         .Register(styleSheet =\> \                                                                                                                                               |
|             {\                                                                                                                                                                   |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid).Theme([Skins]{style="COLOR: #2b91af"}.Blend).DontOverride();                \                       |
|                 **styleSheet.Add([\"\~/Content/Site.css\"]{style="COLOR: #a31515"});**]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                  |
| **[                . . .]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                                  |
| **[                . . .]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                                  |
| **[          \                                                                                                                                                                   |
| ]{style="FONT-FAMILY: 'Courier New'"}**[            })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[  [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager() ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                            |
|                                                                                                                                                                                                                        |
| [       .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components]{style="COLOR: green"}.    ]{style="FONT-FAMILY: 'Courier New'"}[         ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                        |
| [        .Register(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[styleSheet]{style="FONT-FAMILY: 'Courier New'"}[ =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                           |
|                                                                                                                                                                                                                        |
| [        {                                         ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                  |
|                                                                                                                                                                                                                        |
| [          styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid).Theme([Skins]{style="COLOR: #2b91af"}.Blend**).** DontOverride();]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                                        |
| [          **styleSheet.Add([\"\~/Content/Site.css\"]{style="COLOR: #a31515"});**]{style="FONT-FAMILY: 'Courier New'"}[\                                                                                               |
|           . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [          . . .\                                                                                                                                                                                                      |
| ]{style="FONT-FAMILY: 'Courier New'"}[            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                        |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
::::
