::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding ScriptManager to an Application {#adding-scriptmanager-to-an-application style="tab-stops: 0pt"}

The **ScriptManager()** method can be added after all the components on the page. Generally, you can use this method at the end of the master page.

***[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}*** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[ASPX\]]{style="FONT-FAMILY: 'Arial','sans-serif'"}**                                                                                                                                             |
|                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ScriptManager()[%\>]{style="BACKGROUND: yellow"}\                     |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Arial','sans-serif'"}                                                                                                                                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

***[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}*** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Arial','sans-serif'"}**                                                                                                                                           |
|                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ScriptManager().Render();[}]{style="BACKGROUND: yellow"}\             |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Arial','sans-serif'"}                                                                                                                                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

Methods

 

::: {align="center"}
+------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------+-----------------+---------------------+-----------------+
| Method                                                                                               | Description                                                                                                                                             | Parameters | Type            | Return Type         | Reference links |
+------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------+-----------------+---------------------+-----------------+
| ScriptManager ()                                                                                     | Used to register the Syncfusion.Mvc component's script files. The files in the ScriptManager resources are set to be combined, minified, and compressed | NA         | **Server-side** | MvcResourceRenderer | NA              |
+------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------+-----------------+---------------------+-----------------+
| [RegisterStaticResources()]{style="COLOR: black"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} | [(Deprecated)]{style="COLOR: red"}Used to register the Syncfusion.Mvc component's script files                                                          | NA         | **Server-side** | MvcResourceRenderer | NA              |
|                                                                                                      |                                                                                                                                                         |            |                 |                     |                 |
|                                                                                                      |                                                                                                                                                         |            |                 |                     |                 |
+======================================================================================================+=========================================================================================================================================================+============+=================+=====================+=================+
:::

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

Customization

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

**Minify** - To enable or disable the minify feature, use the **Minify()** method. Minify is enabled by default.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[ASPX\]]{style="FONT-FAMILY: 'Arial','sans-serif'"}**                                                                                                                                             |
|                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ScriptManager()]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                           |
| [.Minify([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                           |
| [%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[\                                                                                                                                           |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Arial','sans-serif'"}**                                                                                                                                           |
|                                                                                                                                                                                                           |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ScriptManager()]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                           |
| [.Minify([true]{style="COLOR: blue"}).Render();[}]{style="BACKGROUND: yellow"}\                                                                                                                           |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

**[]{style="FONT-FAMILY: 'Arial','sans-serif'; COLOR: red"}** 

[]{#related-topics}
::::
