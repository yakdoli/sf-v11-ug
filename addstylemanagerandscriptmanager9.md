::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=37c24013-c079-4c44-92c6-4e7f9387ece9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=770e5177-f611-4433-a67c-23d7f05f95c0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=397f4d98-2e34-4dc5-8b77-1d56a317b150){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Adding Essential Mobile Grid to the Razor Application](ms-xhelp:///?Id=e84cebdb-8c9e-4c07-a1be-3f559be3b842){.d2h_breadcrumbsNormal}
:::

### [[Add]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](ms-xhelp:///?Id=9ac024a0-198b-48a3-bbae-5cd7f82ae041) StyleManager and ScriptManager {#add-stylemanager-and-scriptmanager style="tab-stops: 0pt"}

 

Adding StyleManager

**StyleManager** is a new CSS resource manager that helps in registering CSS files which enables minification, compression, and combination of CSS resources for ASP.NET MVC Web applications. The files in StyleManager resources are set to be combined, minified, and compressed (either gzip or deflate, depending on your browser) before being sent to the browser. All are done using a single HTTP request per resource set.

Add the StyleManager extension method in the HEAD tag of the **view** pages (in most cases, it is reasonable to call it within the Site.Master page). Use the **Register** method to register grid component.

 

+------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                |
|                                                                                                                                    |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                    |
| [        Html.MobSyncfusion().StyleManager()]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                    |
| [        .Register(stylesheets =\>]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                    |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                    |
| [                stylesheets.Add([MobComponentType]{style="COLOR: #2b91af"}.{ComponentName});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                    |
| [            }).Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                    |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                               |
+------------------------------------------------------------------------------------------------------------------------------------+

 

Adding ScriptManager

**ScriptManager** is a new script resource manager that helps in registering the JavaScript files. The ScriptManager registers only the **Syncfusion.Mvc** component script files. The files in ScriptManager resources are set to be combined, minified, and compressed (either gzip and deflate, depending on your browser) before being sent to the browser.

The **ScriptManager()** method should be placed after all the components on the page. Generally, you can use this method at the end of the master page.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                 |
|                                                                                                                                                                     |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                     |
|                                                                                                                                                                     |
|                                                                                                                                                                     |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                     |
| [...]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                     |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                     |
| [        Html.MobSyncfusion().ScriptManager()]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                     |
| [            .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                     |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                     |
| [\                                                                                                                                                                  |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[![Description: http://help.syncfusion.com/ug_94/User%20Interface/Mobile%20MVC/Tools/ImagesExt/image10_6.jpg](ImagesExt/image107_5.jpg){border="0"}]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}[Note: Add this **ScriptManager()** at the end of the **body** tag. Do not add this in the top of the **body** tag.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

[]{#related-topics}
::::
