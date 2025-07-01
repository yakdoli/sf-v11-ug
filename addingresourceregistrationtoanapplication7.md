::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2002c00a-e37b-431d-826e-feda65b4e042){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4f84e7b3-45ff-48f7-b998-6f4bdcadbc72){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Getting Started in ASP.NET MVC](ms-xhelp:///?Id=7be0cc3e-239f-44db-9c07-5f5ed873d123){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Adding Essential Chart to the Application](ms-xhelp:///?Id=e5169d46-cdad-4c31-a2e9-229ea700f874){.d2h_breadcrumbsNormal}
:::

### Adding Resource Registration to an Application {#adding-resource-registration-to-an-application style="TEXT-INDENT: -36pt; MARGIN-LEFT: 36pt; tab-stops: 36.0pt"}

Methods

 

+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| Method                           | Description                                                   | Parameters                                   | Type            | Return Type       | Reference links |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| StyleManager()                   | Used to initialize the StyleManager instance                  | NA                                           | **Server-side** | StyleManager      | NA              |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| [Register]{style="COLOR: black"} | Used to register the components style                         | (Action\<ComponentFactoryBuilder components) | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               | (string components)                          |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| [Theme]{style="COLOR: black"}    | Used to apply themes to all the Components                    | (Skins skin)                                 | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               | Default:Office2007Blue                       |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| [Minify]{style="COLOR: black"}   | Used to enable or disable the minify feature for styleManager | (bool enable)                                | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               | Default:True                                 |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| [Combine]{style="COLOR: black"}  | Used to enable/disable the combined files feature             | (bool enable)                                | **Server-side** | StyleManager      | StyleManager    |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               | Default: True                                |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| [Add]{style="COLOR: black"}      | Used to add the components/CSS files to stylemanager          | (Component Type)                             | **Server-side** | IComponentBuilder | Register        |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               |                                              |                 |                   |                 |
|                                  |                                                               | (string path)                                |                 |                   |                 |
+----------------------------------+---------------------------------------------------------------+----------------------------------------------+-----------------+-------------------+-----------------+
| [Theme]{style="COLOR: black"}    | Used to apply theme to specify component                      | (Skins skin)                                 | **Server-side** | IComponentBuilder | Register        |
+==================================+===============================================================+==============================================+=================+===================+=================+

***[]{style="COLOR: black"}***  

+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| Method               | Description                                                              | Parameters          | Type            | Return Type         | Reference links |
+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| JqueryTheme          | Used to apply JqueryTheme to JqueryControls                              | (JquerySkins skins) | **Server-side** | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| DontOverrride        | Used to disable the Theme override to specific control by external theme | NA                  | **Server-side** | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| DisableChildRegister | Used to disable the sub component registration                           | NA                  | **Server-side** | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| AllowChildRegister   | Used to enable or disable the Sub component registration                 | (bool enable)       | **Server-side** | IComponentBuilder   | Register        |
+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| ScriptManager        | Used to register the Javascript files in Syncfusion Mvc assemblies       | NA                  | **Server-side** | MvcResourceRenderer | NA              |
+----------------------+--------------------------------------------------------------------------+---------------------+-----------------+---------------------+-----------------+
| Minify               | Used to enable or disable the minify feature to ScriptManager            | (bool enable)       | **Server-side** | MvcResourceRenderer | ScriptManager   |
|                      |                                                                          |                     |                 |                     |                 |
|                      |                                                                          | Default:True        |                 |                     |                 |
+======================+==========================================================================+=====================+=================+=====================+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

 

To view the samples, follow the below steps:

1.   Open the MVC sample browser from the dashboard. (Refer Samples and Location chapter)

2.   Navigate to Site.Master file

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Add StyleManager to an Application](ms-xhelp:///?Id=68f512ac-3b9e-4ed6-876b-cb81ced10c2e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Add ScriptManager to an Application](ms-xhelp:///?Id=d4d19f5b-f559-4f8c-9b31-9ff660b77f50){style="TEXT-DECORATION: none"}
::::
