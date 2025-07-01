::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=fa8f4616-7800-446b-a2dd-5f69626422a1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8b70717e-33bf-4e70-ad46-29eb82928549){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How to Get a Connector Vertex Point? {#how-to-get-a-connector-vertex-point style="tab-stops: 0pt"}

Connector has a method called GetPoint to get its vertex point.

This method has two parameters: *int* and *bool*[]{style="FONT-FAMILY: 'Courier New'"}

[·      ]{style="FONT-FAMILY: Symbol"}int specifies the vertex point in the local coordinates

[·      ]{style="FONT-FAMILY: Symbol"}bool specifies the path of the connector

Set the bool parameter to True to get the connector vertex point based on its graphical path and False to get the connector point based on its relative path.

The following code snippet illustrates this:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                   |
| [//LineConnector]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                   |
| [ConnectorBase]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ Connector = [new]{style="COLOR: blue"} [LineConnector]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} Drawing.PointF(0F, 0F), [new]{style="COLOR: blue"} Drawing.PointF(10F, 10F));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                   |
| [//set points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                   |
| [Connector.SetPoints([new]{style="COLOR: blue"} [PointF]{style="COLOR: #2b91af"}\[2\] { Connector.GetPoint(0), Connector.GetPoint(Connector.GetPoints().GetLength(0) - 1, [false]{style="COLOR: blue"}) });]{style="FONT-FAMILY: 'Courier New'"}                                                  |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [\'LineConnector]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Connector [As]{style="COLOR: blue"} [ConnectorBase]{style="COLOR: #2b91af"} = [New]{style="COLOR: blue"} [LineConnector]{style="COLOR: #2b91af"}([New]{style="COLOR: blue"} Drawing.[PointF]{style="COLOR: #2b91af"}(0.0F, 0.0F), [New]{style="COLOR: blue"} Drawing.[PointF]{style="COLOR: #2b91af"}(10.0F, 10.0F))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [\'set points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [Connector.SetPoints([New]{style="COLOR: blue"} [PointF]{style="COLOR: #2b91af"}(1) {Connector.GetPoint(0), Connector.GetPoint(Connector.GetPoints().GetLength(0) - 1, [False]{style="COLOR: blue"})})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
::::
