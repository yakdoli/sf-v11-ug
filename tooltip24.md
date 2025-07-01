::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=be4163ad-30a8-4eb6-9008-98f2a5b36fd3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c7d802e0-0b0d-4895-bf8f-dc4671cfd9bd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=895ee437-1738-49ea-b2a5-247d41ce7a5b){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interaction](ms-xhelp:///?Id=be4163ad-30a8-4eb6-9008-98f2a5b36fd3){.d2h_breadcrumbsNormal}
:::

### ToolTip {#tooltip style="tab-stops: 0pt"}

The ToolTip feature allows users to display ToolTips for the chart points.

The **ShowTooltips** property enables ToolTips for all the chart regions. To render all the chart regions, you need to set the **ChartModel.Calcregions** property to **true**.

 

 ToolTips can be displayed in the series using the following code.

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[      ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                 |
| [ [this]{style="COLOR: blue"}.ChartAdv1.CalcRegion=[true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}               |
|                                                                                                                                                 |
| [ [this]{style="COLOR: blue"}.ChartAdv1.ShowToolTip=[true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}              |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                             |
|                                                                                                                                                 |
| [       ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                      |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}[      ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'"}**                           |
|                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[.ChartAdv1.CalcRegion = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}  |
|                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[.ChartAdv1.ShowToolTip = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

![](ImagesExt/image113_30.jpg){border="0"}

Figure 22: Chart ToolTip

 

 

 

 

 

 

+-------------------------------------+----------------------------------------------------------+
|                                                                                                |
|                                                                                                |
| **Feature Request ID:SF4970**                                                                  |
|                                                                                                |
|                                                                                                |
+-------------------------------------+----------------------------------------------------------+
| **Content Contributor:**            | Vijayabharathi                                           |
+-------------------------------------+----------------------------------------------------------+
| **Team Lead:**                      | Solaiappan R                                             |
+-------------------------------------+----------------------------------------------------------+
| **Technical Reviewer:**             | Solaiappan R                                             |
+-------------------------------------+----------------------------------------------------------+
| **Date Reviewed:**                  |                                                          |
+-------------------------------------+----------------------------------------------------------+
| **Comments:**                       |                                                          |
+-------------------------------------+----------------------------------------------------------+
| **Content Editor:**                 | Graham High                                              |
+-------------------------------------+----------------------------------------------------------+
| **Date Reviewed:**                  | 2/8/2012                                                 |
+-------------------------------------+----------------------------------------------------------+
| **Comments:**                       | **Copyedit completed. Content posted to source UG doc.** |
+-------------------------------------+----------------------------------------------------------+
| **Location in the UG**              | New Control in Chart\[ASP.NET\]                          |
|                                     |                                                          |
|                                     |                                                          |
|                                     |                                                          |
|                                     |                                                          |
+-------------------------------------+----------------------------------------------------------+
| **Status:**                         | **Content posted.**                                      |
+-------------------------------------+----------------------------------------------------------+

 

[**Appendix**]{#Appendix}

***Tables for Properties, Methods and Events for IO Products***

[The following tables have been correctly formatted. When you need to create a table, simply copy the appropriate one from below and paste it to the section you are working on above.]{style="COLOR: #c00000"}

**** 

***Property Table***

**** 

  ---------------------------------------------------------------------------------------------- ----------------------------------------------------------------------------------------------------------------------------------
  **[Property]{style="COLOR: black"}**                                                           **[Description]{style="COLOR: black"}[]{style="COLOR: black"}**
  [Name]{style="COLOR: #c00000"}[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}   [Detailed information about the property.]{style="COLOR: #c00000"}[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}
  ---------------------------------------------------------------------------------------------- ----------------------------------------------------------------------------------------------------------------------------------

 

***[Method Table]{style="COLOR: black"}***

***[]{style="COLOR: black"}*** 

+--------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------+
| **[Method]{style="COLOR: black"}*[]{style="COLOR: black"}*** | **[Prototype]{style="COLOR: black"}*[]{style="COLOR: black"}***                                                         | **[Description]{style="COLOR: black"}**                          |
+--------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------+
| [Name]{style="COLOR: #c00000"}***[]{style="COLOR: black"}*** | [MethodName(\<Datatype\>Arg1, \<Datatype\>Arg2,\<Datatype\>Arg3)]{style="COLOR: #c00000"}***[]{style="COLOR: black"}*** | [Why should it be called? ]{style="COLOR: #c00000"}              |
|                                                              |                                                                                                                         |                                                                  |
|                                                              |                                                                                                                         | [When should it be called? ]{style="COLOR: #c00000"}             |
|                                                              |                                                                                                                         |                                                                  |
|                                                              |                                                                                                                         | [What does the method do? ]{style="COLOR: #c00000"}              |
|                                                              |                                                                                                                         |                                                                  |
|                                                              |                                                                                                                         | [Other additional information, if any. ]{style="COLOR: #c00000"} |
+--------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------+

***[]{style="COLOR: black"}*** 

***[Event Table]{style="COLOR: black"}***

***[]{style="COLOR: black"}*** 

+-------------------------------------------------------------------------------------------------+--------------------------------------------+-------------------------------------------------------------------+
| **[Event]{style="COLOR: black"}**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"} | **[Parameters]{style="COLOR: black"}**     | **[Description]{style="COLOR: black"}**                           |
+-------------------------------------------------------------------------------------------------+--------------------------------------------+-------------------------------------------------------------------+
| [Name]{style="COLOR: #c00000"}                                                                  | [ Event Arguments]{style="COLOR: #c00000"} | [When is the event triggered? ]{style="COLOR: #c00000"}           |
|                                                                                                 |                                            |                                                                   |
|                                                                                                 |                                            | [Mention if the event can be cancelled. ]{style="COLOR: #c00000"} |
|                                                                                                 |                                            |                                                                   |
|                                                                                                 |                                            | [Other additional information, if any. ]{style="COLOR: #c00000"}  |
+-------------------------------------------------------------------------------------------------+--------------------------------------------+-------------------------------------------------------------------+

**** 

***Code Table***

**** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                      |
| [  [\<]{style="COLOR: blue"}[input]{style="COLOR: maroon"} [type]{style="COLOR: red"}[=\"text\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"\"]{style="COLOR: blue"} [id]{style="COLOR: red"}[=\"SetDropDowntext\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                                                                      |
| [   [\<]{style="COLOR: blue"}[input]{style="COLOR: maroon"} [type]{style="COLOR: red"}[=\"button\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"Set Text\"]{style="COLOR: blue"} [id]{style="COLOR: red"}[=\"setText\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                                                                                                      |
| [       \$([\"#setText\"]{style="COLOR: maroon"}).bind([\'click\']{style="COLOR: maroon"}, [function]{style="COLOR: blue"} () {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                      |
| [           [var]{style="COLOR: blue"} multiDD = \$find([\"MultiColumnDropdown\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                      |
| [           multiDD.setText(\$([\'#SetDropDowntext\']{style="COLOR: maroon"}).val());]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                      |
| [       });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                      |
| [  [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
