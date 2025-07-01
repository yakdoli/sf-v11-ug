::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2815c4e9-e801-4ff9-b89d-ebcd2abe77be){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8ba9d2bc-b57b-4d5f-ba35-37730bccec4e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET MVC](ms-xhelp:///?Id=32b055b8-3bdf-473c-bb73-f99a534ce79c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=659dde2c-da37-4d15-9752-a5d1c2730cad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Resource Management](ms-xhelp:///?Id=b0731ec2-5daa-49f7-bdee-2fcb636d710a){.d2h_breadcrumbsNormal}
:::

### Adding Resource Registration to an Application {#adding-resource-registration-to-an-application style="tab-stops: 0pt"}

 

Methods

Table 4: Resource Management Method Table

::: {align="center"}
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-------------+-------------------+-----------------+
| Method                           | Description                                                   | Parameters                                     | Type        | Return Type       | Reference links |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-------------+-------------------+-----------------+
| StyleManager()                   | Used to initialize the StyleManager instance                  | NA                                             | Server-side | StyleManager      | NA              |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-------------+-------------------+-----------------+
| [Register]{style="COLOR: black"} | Used to register the components style                         | (Action\<ComponentFactoryBuilder\> components) | Server-side | StyleManager      | NA              |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               | (string components)                            |             |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-------------+-------------------+-----------------+
| [Minify]{style="COLOR: black"}   | Used to enable or disable the minify feature for styleManager | (bool enable)                                  | Server-side | StyleManager      | NA              |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               | Default:True                                   |             |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-------------+-------------------+-----------------+
| [Combine]{style="COLOR: black"}  | Used to enable/disable the combined files feature             | (bool enable)                                  | Server-side | StyleManager      | NA              |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               | Default: True                                  |             |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-------------+-------------------+-----------------+
| [Add]{style="COLOR: black"}      | Used to add the components/CSS files to the stylemanager      | (Component Type)                               | Server-side | IComponentBuilder | NA              |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               |                                                |             |                   |                 |
|                                  |                                                               | (string path)                                  |             |                   |                 |
+==================================+===============================================================+================================================+=============+===================+=================+
:::

***[]{style="COLOR: black"}*** 

::: {align="center"}
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| Method               | Description                                                              | Parameters          | Type        | Return Type         | Reference links |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| JqueryTheme          | Used to apply JqueryTheme to JqueryControls                              | (JquerySkins skins) | Server-side | IComponentBuilder   | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| DontOverrride        | Used to disable the Theme override to specific control by external theme | NA                  | Server-side | IComponentBuilder   | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| DisableChildRegister | Used to disable the sub component registration                           | NA                  | Server-side | IComponentBuilder   | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| AllowChildRegister   | Used to enable or disable the Sub component registration                 | (bool enable)       | Server-side | IComponentBuilder   | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| ScriptManager        | Used to register the Javascript files in Syncfusion Mvc assemblies       | NA                  | Server-side | MvcResourceRenderer | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| Minify               | Used to enable or disable the minify feature to ScriptManager            | (bool enable)       | Server-side | MvcResourceRenderer | NA              |
|                      |                                                                          |                     |             |                     |                 |
|                      |                                                                          | Default:True        |             |                     |                 |
+======================+==========================================================================+=====================+=============+=====================+=================+
:::

[]{style="COLOR: black"} 

Sample Link[]{style="FONT-WEIGHT: normal"}

To view the samples:

1.   Open the  **ASP.NET MVC** sample browser from the dashboard. (Refer to [[Samples Installation Location]{.UGHyperlink}](ms-xhelp:///?Id=06222bf2-0b4f-4843-8c50-107ec1bd9b37) chapter).

2.   Navigate to **SiteMaster.Master** file.

[]{style="COLOR: black"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Adding StyleManager to an Application](ms-xhelp:///?Id=1b619b1b-5e55-4c89-853e-4eed7e1ca0eb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding ScriptManager to an Application](ms-xhelp:///?Id=cb7edd97-a33d-4a7f-84db-625f9d419f9c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding ScriptManager to an Application](ms-xhelp:///?Id=3429317e-5589-40a7-9839-4474e5e9727d){style="TEXT-DECORATION: none"}
::::::
