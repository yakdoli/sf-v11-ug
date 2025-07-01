::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3780abbc-e433-46d2-a4cc-85c884fbc270){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1cc0b5f6-68c2-47a2-81ec-2646310339e0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=f0af2fff-6f00-4ca4-85a6-54e41ac5dc96){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Progress Bar](ms-xhelp:///?Id=07685639-6970-4e9f-b5df-4d1b989a6824){.d2h_breadcrumbsNormal}
:::

### Adding ProgressBar control to MVC Tools {#adding-progressbar-control-to-mvc-tools style="LINE-HEIGHT: 115%; MARGIN: 10pt 0pt 0pt; tab-stops: 0pt"}

 

[In the]{style="COLOR: black"}[ ]{style="COLOR: black"}[Getting Started]{style="COLOR: windowtext"}[ ]{style="COLOR: black"}[section, we discussed how to]{style="COLOR: black"}[ ]{style="COLOR: black"}[create an MVC application]{style="COLOR: windowtext"}[ ]{style="COLOR: black"}[and]{style="COLOR: black"}[ ]{style="COLOR: black"}[add Tools package to the application]{style="COLOR: windowtext"}[. This section guides you to add the ProgressBar to an application.]{style="COLOR: black"}

**[Using Builder]{style="COLOR: black"}**

[The following steps guide in handling client side events through Builder:]{style="COLOR: black"}

1.   In **View**, [invoke the ProgressBar helper with the **ProgressBar** **id** as the first argument.]{style="BACKGROUND: white; COLOR: black"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[ \[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                             |
| [\<%]{style="BACKGROUND: yellow; COLOR: black"}[{]{style="COLOR: black"}                                                    |
|                                                                                                                             |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                             |
| [      .Height(22)]{style="COLOR: black"}                                                                                   |
|                                                                                                                             |
| [      .Width(700)]{style="COLOR: black"}                                                                                   |
|                                                                                                                             |
| [      .Value(50)]{style="COLOR: black"}                                                                                    |
|                                                                                                                             |
| [      .Render() ;]{style="COLOR: black"}                                                                                   |
|                                                                                                                             |
| [  } [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                               |
+-----------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                             |
| [ [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                      |
|                                                                                                                             |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                             |
| [      .Height(22)]{style="COLOR: black"}                                                                                   |
|                                                                                                                             |
| [      .Width(700)]{style="COLOR: black"}                                                                                   |
|                                                                                                                             |
| [      .Value(50)]{style="COLOR: black"}                                                                                    |
|                                                                                                                             |
| [      .Render() ;]{style="COLOR: black"}                                                                                   |
|                                                                                                                             |
| [ }]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="COLOR: black"}                                              |
+-----------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

2.   Build and run the application.

 

 

Using Properties Model

The following steps guide in handling client side events through the Properties model.

1.   In Controller, create an object for the ProgressBarModel class. Assign this model class to view data. 

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                             |
| [public]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ActionResult]{style="COLOR: #2b91af"}[ Index()]{style="COLOR: black"}                                                                                                                                |
|                                                                                                                                                                                                                                                             |
| [        {]{style="COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[ model = ]{style="COLOR: black"}[new]{style="COLOR: blue"}[ ]{style="COLOR: black"}[ProgressBarPropertiesModel]{style="COLOR: #2b91af"}[();]{style="COLOR: black"} |
|                                                                                                                                                                                                                                                             |
| [            model.Height = 22;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            model.Width = 700;]{style="COLOR: black"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [            model.Value = 50;]{style="COLOR: black"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                             |
| [            ViewData\[]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[\] = model;]{style="COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [            ]{style="COLOR: black"}[return]{style="COLOR: blue"}[ View();]{style="COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [        }]{style="COLOR: black"}                                                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

2.   In View, invoke the ProgressBar helper with the view data key as the control ID

[]{style="COLOR: black"} 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[\[View\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                             |
| [\<%]{style="BACKGROUND: yellow; COLOR: black"}[{]{style="COLOR: black"}                                                    |
|                                                                                                                             |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                             |
| [      .Render();]{style="COLOR: black"}                                                                                    |
|                                                                                                                             |
| [} [%\>]{style="BACKGROUND: yellow"}]{style="COLOR: black"}                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                             |
| [\@{]{style="BACKGROUND: yellow; COLOR: black"}[    ]{style="COLOR: black"}                                                 |
|                                                                                                                             |
| [      Html.Syncfusion().ProgressBar(]{style="COLOR: black"}[\"Progress\"]{style="COLOR: #a31515"}[)]{style="COLOR: black"} |
|                                                                                                                             |
| [      .Render();]{style="COLOR: black"}                                                                                    |
|                                                                                                                             |
| [}]{style="BACKGROUND: yellow; COLOR: black"}[]{style="COLOR: black"}                                                       |
+-----------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

3.   Build and run the application.

 

[]{#related-topics}
::::
