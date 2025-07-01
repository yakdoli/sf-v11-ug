::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Add ScriptManager to an Application {#add-scriptmanager-to-an-application style="tab-stops: 0pt"}

The **ScriptManager()** method can be added after all the components on the page. Generally, you can use this method at the end of the master page.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                   |
|                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}  |
|                                                                                                                                                                      |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                      |
| [    [\<%]{style="BACKGROUND: yellow"}{ Html.MobSyncfusion().ScriptManager().Render(); } [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                      |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}  |
|                                                                                                                                                                      |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                      |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                        |
|                                                                                                                                                                      |
| [        Html.MobSyncfusion().ScriptManager().Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                      |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                      |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                      |
| []{style="FONT-SIZE: 12pt"}                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Methods

::: {align="center"}
  **[Method]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**        **[Description]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**                                                                                                                                       **[Parameters]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**   **[Type ]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**                                                                       **[Return Type ]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**
  ------------------------------------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------------------------------------------------------------------------ --------------------------------------------------------------------------------------------------------------------------------------------- -----------------------------------------------------------------------------------
  [ScriptManager()]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}   [Used to register the Syncfusion.Mvc component's script files. The files in ScriptManager resources are set to be combined, minified, and compressed]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}   [NA]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}               **[Server-side]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**[]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}   [MvcResourceRenderer]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}
:::

 

 

Customization

**Minify---**To enable or disable the minify feature, use the **Minify()** method. Minify is enabled by default.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                              |
|                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                             |
|                                                                                                                                                                                                 |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                 |
| [    [\<%]{style="BACKGROUND: yellow"}{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                 |
| [          Html.MobSyncfusion().ScriptManager()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [                 .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| [                 .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                 |
| [      } [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                            |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
|                                                                                                                                                                                                 |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                             |
|                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                             |
|                                                                                                                                                                                                 |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                 |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                 |
| [        Html.MobSyncfusion().ScriptManager()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                 |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                 |
| [            .Minify([false]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                 |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                 |
| [            .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                 |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-SIZE: 12pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
