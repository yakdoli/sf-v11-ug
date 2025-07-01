::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a47967cc-2d47-4bfd-9533-c088b570205a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=101dab68-acec-406a-b9c2-d843f11dfc64){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=49a475aa-006c-4335-93c8-97725e766e43){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Resource Management](ms-xhelp:///?Id=2e920793-54e7-4a82-b4f7-b5bf434809b3){.d2h_breadcrumbsNormal}
:::

### Adding Resource Registration to an Application {#adding-resource-registration-to-an-application style="tab-stops: 0pt"}

 

Methods

 

::: {align="center"}
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| Method                           | Description                                                   | Parameters                                     | Type            | Return Type       | Reference links |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| StyleManager()                   | Used to initialize the StyleManager instance                  | NA                                             | **Server-side** | StyleManager      | NA              |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| [Register]{style="COLOR: black"} | Used to register the component's style                        | (Action\<Com\[ponentFactoryBuilder components) | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               | (string components)                            |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| [Theme]{style="COLOR: black"}    | Used to apply themes to all the components                    | (Skins skin)                                   | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               | Default:Office2007Blue                         |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| [Minify]{style="COLOR: black"}   | Used to enable or disable the minify feature for StyleManager | (bool enable)                                  | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               | Default:True                                   |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| [Combine]{style="COLOR: black"}  | Used to enable/disable the combined files feature             | (bool enable)                                  | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               | Default: True                                  |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| [Add]{style="COLOR: black"}      | Used to add the components/CSS files to StyleManager          | (Component Type)                               | **Server-side** | IComponentBuilder | Register        |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               |                                                |                 |                   |                 |
|                                  |                                                               | (string path)                                  |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+------------------------------------------------+-----------------+-------------------+-----------------+
| [Theme]{style="COLOR: black"}    | Used to apply theme to specific component                     | (Skins skin)                                   | **Server-side** | IComponentBuilder | Register        |
+==================================+===============================================================+================================================+=================+===================+=================+
:::

***[]{style="COLOR: black"}*** 

::: {align="center"}
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| Method               | Description                                                              | Parameters          | Type        | Return Type         | Reference links |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| JqueryTheme          | Used to apply JqueryTheme to JqueryControls                              | (JquerySkins skins) | Server-side | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| DontOverrride        | Used to disable the Theme override to specific control by external theme | NA                  | Server-side | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| DisableChildRegister | Used to disable the sub-component registration                           | NA                  | Server-side | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| AllowChildRegister   | Used to enable or disable the sub-component registration                 | (bool enable)       | Server-side | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| ScriptManager        | Used to register the JavaScript files in Syncfusion MVC assemblies       | NA                  | Server-side | MvcResourceRenderer | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-------------+---------------------+-----------------+
| Minify               | Used to enable or disable the minify feature to ScriptManager            | (bool enable)       | Server-side | MvcResourceRenderer | ScriptManager   |
|                      |                                                                          |                     |             |                     |                 |
|                      |                                                                          | Default:True        |             |                     |                 |
+======================+==========================================================================+=====================+=============+=====================+=================+
:::

[]{style="COLOR: black"} 

Sample Link

To view the samples:

1.   Open the **ASP.NET MVC** sample browser from the dashboard (Refer to the Samples and Location chapter).

2.   Navigate to SiteMaster.Master file.

[]{style="COLOR: black"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Add StyleManager to an Application](ms-xhelp:///?Id=986cc9b6-8d58-41b6-ab4c-b25c3492861d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Add ScriptManager to an Application](ms-xhelp:///?Id=0bd5d108-042e-4cf0-88d6-3bb03489c11a){style="TEXT-DECORATION: none"}
::::::
