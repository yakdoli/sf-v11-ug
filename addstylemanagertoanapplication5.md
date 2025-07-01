::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Add StyleManager to an Application {#add-stylemanager-to-an-application style="tab-stops: 0pt"}

Add the **StyleManager extension** method in the HEAD tag of the View pages (in most cases, It is reasonable to call it within the Site.Master page).[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [head]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [ [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                            |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                            |
| [...\                                                                                                                                                                                                                      |
| [\</]{style="COLOR: blue"}[head]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Use the *Register()* method to register the Syncfusion components CSS resources.

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()\ |
|         .Register(styleSheet =\> \                                                                                                                    |
|             {\                                                                                                                                        |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart);\                                                                       |
|                 \...]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                       |
| [                \...                ]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                       |
| [            })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

The above code registers the default Office2007Blue theme for added components. All the CSS resources are combined and minified before sending to browser.

Customization

 

Various customization options have been provided. They are:

[·      ]{style="FONT-FAMILY: Symbol"}Minify

[·      ]{style="FONT-FAMILY: Symbol"}Combine

[·      ]{style="FONT-FAMILY: Symbol"}Register

[·      ]{style="FONT-FAMILY: Symbol"}Theme

[·      ]{style="FONT-FAMILY: Symbol"}Add CSS Files

 

**Minify ** []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[You can enable or disable the Minify feature using the *Minify()* method. By default this is enabled.]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [         **.Minify([false]{style="COLOR: blue"})**[ // Enable/disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                           |
| [        .Register(styleSheet =\> \                                                                                                                                                       |
|             {\                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart);\                                                                                                           |
|                 \...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                           |
| [                \...\                                                                                                                                                                    |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Please refer HTTP Requests and the time details from the below images.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

Before:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_9.jpg](ImagesExt/image106_9.jpg){border="0"} []{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 4: Minify Disabled[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

After:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_10.jpg](ImagesExt/image106_10.jpg){border="0"} []{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 5: Minify Enabled

The above images show the size of the resource files before and after the Minfication process. Before the Minification process 19KB file is downloaded in browser (Figure 1), whereas after minification, 14.5KB files downloaded in browser (Figure 2). 4.5KB size reduced in the above minification process sample 

 

Combine  

 

 You can enable or disable the Combine file feature using the *Combine()*method. By default this is enabled.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                             |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                             |
| **[          .Combine([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}** [// Enable or disable Combine feature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [        .Register(styleSheet =\> \                                                                                                                                                                                         |
|             {\                                                                                                                                                                                                              |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart);\                                                                                                                                             |
|                 \...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                \...\                                                                                                                                                                                                      |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Please refer HTTP Requests and the time details from the below images:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Before:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_11.jpg](ImagesExt/image106_11.jpg){border="0"} []{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 6: Combine Disabled[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

After:[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: http://help.syncfusion.com/ug_84/User%20Interface/ASP.NET%20MVC/Grid/ImagesExt/image14_12.jpg](ImagesExt/image106_12.jpg){border="0"} []{style="FONT-FAMILY: 'Times New Roman','serif'"}

Figure 7: Combine Enabled

The above images show the downloading time before and after the Combine process of the resource files. Before the Combine process, browser takes 257ms to download the css resources (Figure 1), where as after Combine it takes only 63ms to the download resources (Figure 2). 194ms time is reduced in the above Combine process sample.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Register

There are two overloads available for the *Register()* method.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[·      ]{style="FONT-FAMILY: Symbol"}Adding StyleManager to an application uses the first overload where the component names can be specified as the String separated by comma.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

To add controls in a single line, use the *Register()* method.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                          |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()\                                    |
|                **.Register([\"Chart,Menu\"]{style="COLOR: #a31515"})**[//Specify the component names   separated by a comma.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [               [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Second overload uses the *ComponentType* to register the controls.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()\ |
|                **.Register**(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                       |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                       |
| [                stylesheets.Add([ComponentType]{style="COLOR: #2b91af"}.Chart);                              ]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                       |
| [            })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                       |
| [     [%\>]{style="BACKGROUND: yellow"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

You can avoid child control register using the *DisableChildRegister()* method.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

 For example: Grid with paging and sorting feature doesn't require sub controls like Menu, Dialog (these sub controls are used in filtering feature). In order to avoid these child registers use the DisableChildRegister() as  follows:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                           |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                           |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify theme.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                      |
|             {\                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart)**.DisableChildRegister()**;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                           |
| [                . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                           |
| [                . . .\                                                                                                                                                                   |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

You can enable or disable the sub component registrations based on the condition you define using the *AllowChildRegister()*  method.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                           |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                           |
| [         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                      |
|             {\                                                                                                                                                                            |
|               styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart)**.AllowChildRegister([true]{style="COLOR: blue"});\**                                                         |
|               . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                           |
| [              . . .\                                                                                                                                                                     |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Theme[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

*[To]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}* register the CSS Stylesheets for all controls, use the *Theme()* method. Default theme is Office2007Blue.

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [         .Minify([false]{style="COLOR: blue"})[ // Enable or disable Minify feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                           |
| [         .Combine([false]{style="COLOR: blue"})[// Enable or disable Combine feature.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                           |
| [         **.Theme([Skins]{style="COLOR: #2b91af"}.Almond)**[ // Specify Theme. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                      |
|             {\                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart);\                                                                                                           |
|                 . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                           |
| [                . . .\                                                                                                                                                                   |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

You can configure the individual theme for every controls using the *Theme()*method inside the *Register().*

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [         .Register(styleSheet =\> \                                                                                                                                                      |
|             {\                                                                                                                                                                            |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart)**.Theme([Skins]{style="COLOR: #2b91af"}.Blend)**;]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                           |
| [                . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                           |
| [                . . .\                                                                                                                                                                   |
|             })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

In this above code, Office2007Blue theme registers all the other components and Blend theme registers for Grid.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[ ]{style="FONT-FAMILY: 'Times New Roman','serif'"} [ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} []{style="FONT-FAMILY: 'Times New Roman','serif'"}

You can avoid theme override by the external *Theme()* method using the *DontOverride()* method.

+-------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                       |
| [  [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().StyleManager()\                                                         |
|    .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components]{style="COLOR: green"}.    ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                       |
| [   .Register(styleSheet =\> \                                                                                                                        |
|           {\                                                                                                                                          |
|         styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart).Theme([Skins]{style="COLOR: #2b91af"}.Blend**).DontOverride();**\               |
|         . . .]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                       |
| [        . . .\                                                                                                                                       |
|            })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

In general, the external Theme() method overrides all the internal component themes register. The DontOverride() method preserves the theme registered in the Register() methods.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image106_5.jpg){border="0"}Note: The Theme () method will register the CSS style sheets for the specified theme in the html head section. Using this method, we cannot apply themes for the controls (cannot add CSS classes). If we don't use StyleManager then the CSS style sheet for default theme or specified theme will be registered just before controls render starts. The StyleManager is introduced to improve the performance using its Minify and Combine feature.

 
:::

**Add the CSS Files**

To include the application CSS files to the styleManager, use the *Add()* method.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                             |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().StyleManager()\       |
|         .Theme([Skins]{style="COLOR: #2b91af"}.Almond)[// Specify Theme to all components.]{style="COLOR: green"}\                                          |
|         .Register(styleSheet =\> \                                                                                                                          |
|             {\                                                                                                                                              |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart).Theme([Skins]{style="COLOR: #2b91af"}.Blend).DontOverride();                \ |
|                 **styleSheet.Add([\"\~/Content/Site.css\"]{style="COLOR: #a31515"});**]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                             |
| **[                . . .\                                                                                                                                   |
| ]{style="FONT-FAMILY: 'Courier New'"}** [            })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Add ScriptManager to an Application

 

The *ScriptManager()* method can be added after all the components on the page. Generally, you can use this method at the end of the master page.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                              |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                              |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().ScriptManager()[%\>]{style="BACKGROUND: yellow"}\                      |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Customization

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

**Minify** - To enable or disable the minify feature, use the **Minify()** method. Minify is enabled by default.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                              |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                              |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.Syncfusion().ScriptManager()]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                              |
| [.Minify([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                              |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [\                                                                                                                                             |
| [\</]{style="COLOR: blue"} [body]{style="COLOR: maroon"} [\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
::::
