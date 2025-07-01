::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=eebfc06c-5e1c-48c3-a4bb-328da4d5b506){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e9afdf82-2747-471d-bd99-dc8cc36ade0d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Diagram View](ms-xhelp:///?Id=5fbfa644-6dd8-4969-8866-3f1b867be204){.d2h_breadcrumbsNormal}
:::

### Drawing Tools {#drawing-tools style="tab-stops: 0pt"}

This feature enables you to draw different shapes and lines. The drawn shapes and lines will be converted into Node and LineConnector respectively.

The following shapes and lines are available in DrawingTools:

1.   Ellipse

2.   Rectangle

3.   Rounded Rectangle

4.   Polygon

5.   Straight Line

6.   Bezier Line

7.   Orthogonal Line

8.   Polyline

 

Use Case Scenarios

DrawingTools such as Microsoft Paint and Expression Blend support drawing a particular shape continually on a page. This feature too, enables you to draw a shape repeatedly without selecting it manually each time.

 

Properties

Table 77: DrawingToolsProperty Table

::: {align="center"}
+--------------------+---------------------------------------------------------------------------------+----------------------+-----------------------------------------------+---------------------------------------------------+
| Property           | Description                                                                     | Type of the Property | Value It Accepts                              | Any Other Dependencies/ Sub properties Associated |
+--------------------+---------------------------------------------------------------------------------+----------------------+-----------------------------------------------+---------------------------------------------------+
| EnableDrawingTools | Gets or sets a value indicating whether   EnableDrawingTools is enabled or not. | Dependency property  | Boolean(True/False)[]{style="COLOR: #c00000"} | No[]{style="COLOR: #c00000"}                      |
+--------------------+---------------------------------------------------------------------------------+----------------------+-----------------------------------------------+---------------------------------------------------+
| DrawingTools       | Gets or sets the ShapeType to be used.                                          | Dependency property  | DrawingTools.Ellipse                          | No                                                |
|                    |                                                                                 |                      |                                               |                                                   |
|                    | Default value is                                                                |                      | DrawingTools.Rectangle                        |                                                   |
|                    |                                                                                 |                      |                                               |                                                   |
|                    | DrawingTools.Ellipse                                                            |                      | DrawingTool.RoundedRectangle                  |                                                   |
|                    |                                                                                 |                      |                                               |                                                   |
|                    |                                                                                 |                      | DrawingTools.Polygon                          |                                                   |
|                    |                                                                                 |                      |                                               |                                                   |
|                    |                                                                                 |                      | DrawingTools.StraightLine                     |                                                   |
|                    |                                                                                 |                      |                                               |                                                   |
|                    |                                                                                 |                      | DrawingTools.BezierLine                       |                                                   |
|                    |                                                                                 |                      |                                               |                                                   |
|                    |                                                                                 |                      | DrawingTools.OrthogonalLine                   |                                                   |
|                    |                                                                                 |                      |                                               |                                                   |
|                    |                                                                                 |                      | DrawingTools.PolyLine                         |                                                   |
+--------------------+---------------------------------------------------------------------------------+----------------------+-----------------------------------------------+---------------------------------------------------+
:::

 

Sample Link

To view a sample:

1.   Open the WPF sample browser from the dashboard.

2.   Navigate to WPF Diagram \> Product Showcase \>Features demo

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enable Drawing Tools](ms-xhelp:///?Id=afd7913e-1d59-48d2-961f-c52f6c4adfc5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Select a Drawing Tool](ms-xhelp:///?Id=2e74ad66-b226-4760-8a36-05edb144e91d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Steps for Drawing](ms-xhelp:///?Id=2aada26c-bdaf-4901-afa8-9dfab798d5db){style="TEXT-DECORATION: none"}
:::::
