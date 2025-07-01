::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Add StyleManager to an Application {#add-stylemanager-to-an-application style="tab-stops: 0pt"}

 

Add the **StyleManager extension** method in the HEAD tag of the View pages (in most cases, It is reasonable to call it within the Site.Master page).[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[aspx**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                                                              |
|                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[head]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'"}    |
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

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                                                                                                                              |
|                                                                                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[head]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                                           |
| [   [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                           |
| [        .Register(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                           |
| [             ]{style="FONT-FAMILY: 'Courier New'"}[stylesheets]{style="FONT-FAMILY: 'Courier New'"}[.Add([ComponentType]{style="COLOR: #2b91af"}.]{style="FONT-FAMILY: 'Courier New'"}[Menu]{style="FONT-FAMILY: 'Courier New'"}[);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                           |
| [            }).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                   |
|                                                                                                                                                                                                                                                                           |
| [\                                                                                                                                                                                                                                                                        |
| [\</]{style="COLOR: blue"}[head]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Use **Register()** method to register the Syncfusion components CSS resources.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[View\[aspx]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}** |
|                                                                                                                                                                                                                                                                              |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                                                                                          |
|         .Register(styleSheet =\> \                                                                                                                                                                                                                                           |
|             {\                                                                                                                                                                                                                                                               |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                               |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                          |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                               |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                            |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**        |
|                                                                                                                                                     |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\ |
|         .Register(styleSheet =\> \                                                                                                                  |
|             {                \                                                                                                                      |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                      |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                   |
|             }).Render();  [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}    |
|                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

The above code registers the default Office2007Blue theme for added components. All the CSS resources are combined and minified before sending to browser.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

 

Customization

Various customization options have been provided. They are:

[·      ]{style="FONT-FAMILY: Symbol"}Minify

[·      ]{style="FONT-FAMILY: Symbol"}Combine

[·      ]{style="FONT-FAMILY: Symbol"}Register

[·      ]{style="FONT-FAMILY: Symbol"}Theme

[·      ]{style="FONT-FAMILY: Symbol"}Add CSS Files

 

Minify

To enable or disable Minify feature, use **Minify()** method. Minify is Enabled by default.[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}**[ **View\[aspx**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                   |
|                                                                                                                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                       |
|                                                                                                                                                                                                                                                                                 |
| [         **.Minify([false]{style="COLOR: blue"})**]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                 |
| [        .Register(styleSheet =\> \                                                                                                                                                                                                                                             |
|             {\                                                                                                                                                                                                                                                                  |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                  |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                             |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                                  |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                               |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                       |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                                                                                                                                   |
|                                                                                                                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                      |
|                                                                                                                                                                                                                                                                                |
| [        **.Minify([false]{style="COLOR: blue"})**]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable/disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                |
| [        .Register(styleSheet =\> \                                                                                                                                                                                                                                            |
|             {\                                                                                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                              |
|             }).Render();  [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Please refer HTTP Requests and the time details from the below images.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Before:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_9.jpg](ImagesExt/image56_8.jpg){border="0"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 3: Minify Disabled.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

After:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_10.jpg](ImagesExt/image56_9.jpg){border="0"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 4: Minify Enabled.

The above images show the size of the resource files before and after the Minfication process. Before the Minification process 19KB file is downloaded in browser (Figure 1), whereas after minification, 14.5KB files downloaded in browser(Figure 2). 4.5KB size reduced in the above minification process sample.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

 

Combine

 To enable or disable Combine file feature, use **Combine()** method. Combine is Enabled by default.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                               |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                     |
|                                                                                                                                                                                                                                                                               |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable ordisable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                               |
| **[          .Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}**[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                         |
|                                                                                                                                                                                                                                                                               |
| [        .Register(styleSheet =\> \                                                                                                                                                                                                                                           |
|             {\                                                                                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                           |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.AutoCompleteTextBox);\                                                                                                                                                                                 |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                                                                                                                                  |
|                                                                                                                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                     |
|                                                                                                                                                                                                                                                                               |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable ordisable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                               |
| **[         .Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}**[// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                          |
|                                                                                                                                                                                                                                                                               |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                                                          |
|             {\                                                                                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Grid);\                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                           |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.AutoCompleteTextBox);\                                                                                                                                                                                 |
|             })  .Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                               |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Please refer HTTP Requests and the time details from the below images:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

Before:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_11.jpg](ImagesExt/image56_10.jpg){border="0"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 5: Combine Disabled

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

After:

 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_12.jpg](ImagesExt/image56_11.jpg){border="0"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 6: Combine Enabled

 

The above images show the downloading time before and after the Combine process of the resource files. Before the Combine process, browser takes 257ms to download the css resources (Figure 1), where as after Combine it takes only 63ms to the download resources (Figure 2). 194ms time is reduced in the above Combine process sample.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

 

Register

Two overloads are available for **Register**() method. Adding StyleManager to an application uses the one where the component name can be specified as String separated by a comma.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

1.   To add controls in a single line, use **Register()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                  |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                                                              |
| **    .Register([\"Grid,Menu,Toolbar,Accordion\"]{style="COLOR: #a31515"})**[//Specify the component names   separated by a comma.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                  |
| [               [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                         |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                             |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                                                                         |
|                **.Register([\"Grid,Menu,Toolbar,Accordion\"]{style="COLOR: #a31515"})**[//Specify the component names   separated by a comma.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                             |
| [.Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[2.   ]{style="COLOR: #2b91af"}Second overload uses the [ComponentType]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ to register the controls.[ ]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                                                     |
|                ]{style="FONT-FAMILY: 'Courier New'"}**[.Register]{style="FONT-FAMILY: 'Courier New'"}**[(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [                stylesheets.Add([ComponentType]{style="COLOR: #2b91af"}.]{style="FONT-FAMILY: 'Courier New'"}**[Accordion]{style="FONT-FAMILY: 'Courier New'"}**[);                              ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                         |
| [            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [     [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Courier New'"}                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**[ ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [ [\@{]{style="BACKGROUND: yellow"}Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                          |
| [        **.Register**(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                          |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                          |
| [                stylesheets.Add([ComponentType]{style="COLOR: #2b91af"}.]{style="FONT-FAMILY: 'Courier New'"}**[Accordion]{style="FONT-FAMILY: 'Courier New'"}**[);                               ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                          |
| [.Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

To avoid child control register, use **DisableChildRegister()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

**For example:** Grid with paging and sorting feature doesn't require sub controls like Menu, Dialog (these sub controls are used in filtering feature). In order to avoid these child registers use ***DisableChildRegister*()** as  follows: []{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}**[ **View\[aspx**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}**                  |
|                                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable or disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                           |
|                                                                                                                                                                                                                                                                                |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify theme.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                      |
|                                                                                                                                                                                                                                                                                |
| [ComponentType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Menu)**.DisableChildRegister()**;\                                                                                                                                                                        |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                              |
|             }) ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [ [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable or disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                           |
|                                                                                                                                                                                                                                                                                |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify theme.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                                                           |
|             {\                                                                                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu)**.DisableChildRegister()**;\                                                                                                                                                                      |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                              |
|             }).Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

To enable or disable the sub component registrations based on some condition, use **AllowChildRegister()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}[View\[aspx]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}** |
|                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                    |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                    |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                    |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                    |
| [ComponentType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Menu)**.AllowChildRegister([true]{style="COLOR: blue"});\**                                                                   |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                  |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                    |
|             })  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                    |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                  |
|                                                                                                                                                                                         |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                         |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                         |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                         |
| [         .Register(styleSheet =\> \                                                                                                                                                    |
|             {\                                                                                                                                                                          |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu)**.AllowChildRegister([true]{style="COLOR: blue"});\**                                                        |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                       |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                         |
|             }).Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                         |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Theme

To register the CSS Stylesheets for all controls, use Theme() method. Office2007Blue theme is the default theme.

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}[View\[aspx]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**                                                                             |
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
|             {                \                                                                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                              |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                       |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                      |
|                                                                                                                                                                                                                                                                                |
| [         .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: green"}[// Enable or disable Minify feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                                                                |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                           |
|                                                                                                                                                                                                                                                                                |
| [         **.Theme([Skins]{style="COLOR: #2b91af"}.Almond)**[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                 |
|                                                                                                                                                                                                                                                                                |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                                                           |
|             {                \                                                                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                                                                                              |
|             }).Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

To configure individual theme for every controls use **Theme()** method inside Register().[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[aspx**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**                                                                               |
|                                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                      |
|             {\                                                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion)**.Theme([Skins]{style="COLOR: #2b91af"}.Blend)**;      \                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar]{style="FONT-FAMILY: 'Courier New'"}[)]{style="FONT-FAMILY: 'Courier New'"}[;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                           |
| [})  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                                                                      |
|             {\                                                                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion)**.Theme([Skins]{style="COLOR: #2b91af"}.Blend)**;      \                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu);\                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                           |
| [}).Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                           |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

In this above code, Office2007Blue theme registers all the other components and Blend theme registers for Grid.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

To register JQuery themes to JqueryControls, use **JqueryTheme()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}[View\[aspx]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}** |
|                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                    |
| [         .Register(styleSheet =\> \                                                                                                                                                               |
|             {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                    |
| [  styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion).**JqueryTheme(Syncfusion.Mvc.Tools.[jQuerySkins]{style="COLOR: #2b91af"}.Cupertino);**\                                       |
|              })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                  |
|                                                                                                                                                                                         |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [         .Register(styleSheet =\> \                                                                                                                                                    |
|             {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                         |
| [  styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion).**JqueryTheme(Syncfusion.Mvc.Tools.[jQuerySkins]{style="COLOR: #2b91af"}.Cupertino);**\                            |
|              }).Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                         |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

To avoid theme override by external Theme() method, use **DontOverride()** method. []{style="FONT-FAMILY: 'Times New Roman','serif'"}

[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}[View\[aspx]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}** |
|                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                |
|       .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components]{style="COLOR: green"}.   ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                    |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[      .Register(styleSheet =\> \                                                                                              |
|           {\                                                                                                                                                                                       |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu).Theme([Skins]{style="COLOR: #2b91af"}.Blend**).DontOverride();**\                                                             |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);       \                                                                                                                 |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                          |
|            })[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                    |
|                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\       |
|       .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components]{style="COLOR: green"}.     ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                           |
| [      .Register(styleSheet =\> \                                                                                                                         |
|           {\                                                                                                                                              |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu).Theme([Skins]{style="COLOR: #2b91af"}.Blend**).DontOverride();**\                    |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);       \                                                                        |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                 |
|            })  .Render(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                           |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

In general, the external Theme() method overrides all the internal component themes register. The DontOverride() method preserves the theme registered in the Register() methods.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image56_5.jpg){border="0"}Note: The Theme () method will register the CSS style sheets for the specified theme in the html head section. Using this method, we cannot apply themes for the controls (cannot add CSS classes). If we don't use StyleManager then the CSS style sheet for default theme or specified theme will be registered just before controls render starts. The StyleManager is introduced to improve the performance using its Minify and Combine feature.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}
:::

Add CSS Files

To include the application CSS files to styleManager, use **Add()** method.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX]{style="FONT-FAMILY: 'Courier New'"}[View\[aspx]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}** |
|                                                                                                                                                                                                    |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                                                |
|         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components.]{style="COLOR: green"}\                                                                                 |
|         .Register(styleSheet =\> \                                                                                                                                                                 |
|             {\                                                                                                                                                                                     |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu).Theme([Skins]{style="COLOR: #2b91af"}.Blend).DontOverride();\                                                         |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                                                                |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                                                                  |
|                 **styleSheet.Add([\"\~/Content/Site.css\"]{style="COLOR: #a31515"});\**                                                                                                            |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                           |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| [ **View\[cshtml\]**]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                              |
|                                                                                                                                                     |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\ |
|         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components.]{style="COLOR: green"}\                                  |
|         .Register(styleSheet =\> \                                                                                                                  |
|             {\                                                                                                                                      |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Menu).Theme([Skins]{style="COLOR: #2b91af"}.Blend).DontOverride();\          |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Accordion);\                                                                 |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Toolbar);\                                                                   |
|                 **styleSheet.Add([\"\~/Content/Site.css\"]{style="COLOR: #a31515"});\**                                                             |
|             })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                     |
| [        .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                     |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[  ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
::::
