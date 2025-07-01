::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=082824f2-1a1d-405e-a199-c186ff405637){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=24876712-9cf7-41ee-bcf5-9cdd9a32c3e9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Gauge]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=0eb97268-6d10-4db1-8ac8-dab54249067e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Adding Essential Gauge to the Application (ASPX)](ms-xhelp:///?Id=6a9b5bee-53a2-46cf-99d3-3c3d407362c1){.d2h_breadcrumbsNormal}
:::

### Adding ScriptManager {#adding-scriptmanager style="tab-stops: 0pt"}

 

**ScriptManager** is a new script resource manager that helps in registering the JavaScript files r. The ScriptManager registers only the Syncfusion.Mvc components script files. The files in ScriptManager resources are set to be combined, minified, and compressed (either gzip and deflate, depending on your browser) before sending to browser.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

ScriptManager() extension has improved performance over the **RegisterStaticResource**() method. Hence, we always suggest this method in registering the scripts.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

The ScriptManager() method should be placed after all the components on the page. Generally,  you can use this method at the end of the master page.

[]{style="FONT-FAMILY: 'Times New Roman','serif'"} 

Methods

 

::: {align="center"}
+------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------+------------+-----------------+-------------------------------------------------------------------------------------+-----------------+
| Method                                                                                               | Description                                                                                                                                         | Parameters | Type            | Return Type                                                                         | Reference links |
+------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------+------------+-----------------+-------------------------------------------------------------------------------------+-----------------+
| ScriptManager ()                                                                                     | Used to register the Syncfusion.Mvc component's script files. The files in ScriptManager resources are set to be combined, minified, and compressed | NA         | **Server-side** | [MvcResourceRenderer]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} | NA              |
+------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------+------------+-----------------+-------------------------------------------------------------------------------------+-----------------+
| [RegisterStaticResources()]{style="COLOR: black"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} | [(Deprecated) ]{style="COLOR: red"}Used to register the Syncfusion.Mvc component's script files                                                     | NA         | **Server-side** | [MvcResourceRenderer]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} | NA              |
|                                                                                                      |                                                                                                                                                     |            |                 |                                                                                     |                 |
|                                                                                                      |                                                                                                                                                     |            |                 |                                                                                     |                 |
+======================================================================================================+=====================================================================================================================================================+============+=================+=====================================================================================+=================+
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                  |
|                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[body]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                       |
| [...]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                           |
|                                                                                                                                                                                                                       |
| [...]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                           |
|                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ScriptManager()[%\>]{style="BACKGROUND: yellow"}\                                 |
| [\</]{style="COLOR: blue"}[body]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                               |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![Description: C:\\Documents and Settings\\jananit\\Desktop\\Dataicon.jpg](ImagesExt/image57_9.jpg){border="0"} Note : Add this ScriptManager() at the end of body tag. Don't add this at the top of the  body tag.
:::

 

[]{#related-topics}
::::::
