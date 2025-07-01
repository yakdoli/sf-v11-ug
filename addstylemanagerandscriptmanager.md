::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Add StyleManager and ScriptManager {#add-stylemanager-and-scriptmanager style="tab-stops: 0pt"}

 

Adding StyleManager

 

**StyleManager** is a new CSS resource manager that helps in registering CSS files, which enables minification, compression, and combination of CSS resources for ASP.NET MVC Web applications. The files in StyleManager resources are set to be combined, minified, and compressed (either gzip or deflate, depending on your browser) before being sent to the browser. All are done using a single HTTP request per resource set.

Add the StyleManager extension method in the HEAD tag of the **View** pages (in most cases, it is reasonable to call it within the Site.Master page). Use the **Register** method to register Grid component.

 

+----------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                      |
|                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                          |
|                                                                                                                      |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[=Html.Syncfusion().StyleManager()\    |
|         .Register(styleSheet =\> \                                                                                   |
|             {\                                                                                                       |
|                 styleSheet.Add(ComponentType.{ComponentName});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                      |
| [            })  [%\>]{style="BACKGROUND: yellow"} ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}            |
+----------------------------------------------------------------------------------------------------------------------+

 

 

Adding ScriptManager

**ScriptManager** is a new script resource manager that helps in registering the JavaScript file. The ScriptManager registers only the Syncfusion.Mvc components script files. The files in ScriptManager resources are set to be combined, minified, and compressed (either gzip and deflate, depending on your browser) before being sent to the browser. 

The **ScriptManager()** extension has improved performance over the **RegisterStaticResource()** method. Hence we always suggest this method in registering the scripts. 

The **ScriptManager()** method should be placed after all the components on the page. Generally, you can use this method at the end of the master page.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 11pt"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 11pt"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 11pt"}[ ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} |
|                                                                                                                                                                                                                                                                                |
| [...]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [...]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow; FONT-SIZE: 11pt"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 11pt"}[Html.Syncfusion().ScriptManager()[%\>]{style="BACKGROUND: yellow"}\                                                        |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![Description: http://help.syncfusion.com/ug_91/User%20Interface/ASP.NET%20MVC/Tools/ImagesExt/image9_5.png](ImagesExt/image70_25.png){border="0"}Note: Add this ScriptManager() at the end of the body tag. Don't add this at the top of the body tag.

 
:::

[]{#related-topics}
::::
