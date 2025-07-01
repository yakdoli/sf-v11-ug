::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=73742c31-568b-4359-8dd0-21b7a60058f9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3eb7eb94-5332-4941-affa-4bfbabf22ff3){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Common](ms-xhelp:///?Id=4c050309-bc37-44e2-9d2e-da3ac3e4d92b){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Resource Management](ms-xhelp:///?Id=f36ede01-09bb-4efc-9261-b1a7d0297368){.d2h_breadcrumbsNormal}
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

+---------------+--------------------------------------------------------------------------+---------------+-----------------+---------------------+-----------------+
| Method        | Description                                                              | Parameters    | Type            | Return Type         | Reference links |
+---------------+--------------------------------------------------------------------------+---------------+-----------------+---------------------+-----------------+
| DontOverrride | Used to disable the Theme override to specific control by external theme | NA            | **Server-side** | IComponentBuilder   | Register        |
+---------------+--------------------------------------------------------------------------+---------------+-----------------+---------------------+-----------------+
| ScriptManager | Used to register the Javascript files in Syncfusion Mvc assemblies       | NA            | **Server-side** | MvcResourceRenderer | NA              |
+---------------+--------------------------------------------------------------------------+---------------+-----------------+---------------------+-----------------+
| Minify        | Used to enable or disable the minify feature to ScriptManager            | (bool enable) | **Server-side** | MvcResourceRenderer | ScriptManager   |
|               |                                                                          |               |                 |                     |                 |
|               |                                                                          | Default:True  |                 |                     |                 |
+===============+==========================================================================+===============+=================+=====================+=================+

***[]{style="COLOR: black"}***  

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

 

To view the samples, follow the below steps:

1.   Open the Mobile MVC sample browser from the dashboard. (Refer Samples and Location chapter)

2.   Navigate to Site.Master file

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Add ScriptManager to an Application](ms-xhelp:///?Id=3218b79e-c91b-437a-a201-d47c87ec0e04){style="TEXT-DECORATION: none"}
::::
