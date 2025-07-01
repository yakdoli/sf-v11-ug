::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=89650b82-522a-452e-b60c-6d54f08b12a1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=761e6de8-3f8e-4165-ac1b-229d47cb74c1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How to Get the Nearest Grid Point on a Diagram {#how-to-get-the-nearest-grid-point-on-a-diagram style="tab-stops: 0pt"}

The **GetNearestGridPoint method** can be used to get the nearest grid point on a diagram based on a given point.

This method has the following two parameters:

[·      ]{style="FONT-FAMILY: Symbol"}**Point** - specifies the location which calculates the nearest grid point.

[·      ]{style="FONT-FAMILY: Symbol"}**Int** - specifies the ruler height.

 

The following code snippet illustrates the implementation of **GetNearestGridPoint** method:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                        |
|                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                              |
|                                                                                                                                                                                       |
| [//Current mouse position]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                          |
|                                                                                                                                                                                       |
| [Point]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ ptMouse = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(e.X, e.Y);]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                       |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rulerHeight = (diagram1.ShowRulers) ? diagram1.RulersHeight : 0;]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                       |
| [//Nearest grid point]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                       |
| [PointF]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ ptGridNearestPoint = diagram1.View.Grid.GetNearestGridPoint(ptMouse, rulerHeight);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                           |
| [Current mouse position]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                            |
|                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ptMouse [As]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} = [New]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"} (e.X, e.Y)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rulerHeight [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                           |
| [rulerHeight = [If]{style="COLOR: blue"}((diagram1.ShowRulers), diagram1.RulersHeight, 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                           |
| [\'Nearest grid point]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ptGridNearestPoint [As]{style="COLOR: blue"} [PointF]{style="COLOR: #2b91af"} = diagram1.View.Grid.GetNearestGridPoint(ptMouse, rulerHeight)]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
