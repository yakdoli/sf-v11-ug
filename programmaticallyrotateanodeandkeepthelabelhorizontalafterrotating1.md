::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f60c6643-ba84-4be7-a129-2fb63feff5bb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ba4698dd-302b-4fa6-b2f1-a263092e0525){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=2206ded2-cc47-47f5-86b1-d5d1f5b27678){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=91822e4e-e58d-43c2-9da2-bfbf6a7d32a0){.d2h_breadcrumbsNormal}
:::

### Programmatically Rotate a Node and Keep the Label Horizontal after Rotating {#programmatically-rotate-a-node-and-keep-the-label-horizontal-after-rotating style="tab-stops: 0pt"}

Node can be programmatically rotated and the Label can be kept horizontal after rotation using the following code snippet.\
\

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                             |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                       |
|                                                                                                                                                                            |
| [Node ]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[NewClient = new [Node]{style="COLOR: #2b91af"}();[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                            |
| [NewClient.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Shape = [Shapes]{style="COLOR: #2b91af"}.FlowChart_Card;]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                            |
| [diagramModel.Nodes.Add(NewClient);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                       |
|                                                                                                                                                                            |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ angle = 90;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                            |
| [NewClient.RenderTransform = [new]{style="COLOR: blue"} [RotateTransform]{style="COLOR: #2b91af"}(angle);]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                            |
| [NewClient.Label = [\"90 deg rotation\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                            |
| [NewClient.RenderTransformOrigin = [new]{style="COLOR: blue"} System.Windows.[Point]{style="COLOR: #2b91af"}(0.5, 0.5);]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                            |
| [NewClient.LabelAngle = 360 - angle;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ NewClient [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [NewClient.Shape = Shapes.FlowChart_Card]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                              |
| [diagramModel.Nodes.Add(NewClient)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ angle [As]{style="COLOR: blue"} [Double]{style="COLOR: blue"} = 90]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                              |
| [NewClient.RenderTransform = [New]{style="COLOR: blue"} RotateTransform(angle)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                              |
| [NewClient.Label = \"90 deg rotation\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                              |
| [NewClient.RenderTransformOrigin = [New]{style="COLOR: blue"} System.Windows.Point(0.5, 0.5)]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                              |
| [NewClient.LabelAngle = 360 - angle]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Here diagramModel is an instance of DiagramModel.

 

[]{#related-topics}
::::
