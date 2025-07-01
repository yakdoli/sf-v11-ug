::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=88bf5521-7256-4cd6-9555-6b81c9646f68){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b4e24b18-1acc-4652-94ce-4c246b8a86cc){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f9aa55fb-f8cf-43da-a8be-de231dc0d949){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Optimization](ms-xhelp:///?Id=b87d4bc7-af66-4e6f-81ff-c63c4bc639b4){.d2h_breadcrumbsNormal}
:::

### Flattened Mode[]{style="FONT-SIZE: 10pt"} {#flattened-mode style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Flattened mode is a simplified rendering mode. Background and contents (nodes) are rendered into a single image. This image will be cut to separate square images, if **OptimizedBackgroundRendering** mode is enabled.

 

This mode is useful when you do not have to perform any interactive operation with the node (selecting / dragging). It is designed especially for static documents. It is similar to the read-only mode.

 

This optimization mode reduces data transfer from the server to client. Also this optimization reduces loading time, when the document has many nodes.

 

***[Warning]{style="BACKGROUND: white"}***[:]{style="BACKGROUND: white"} Some interactive functionality won\'t work. For example, nodes dragging and selecting functionality.

 

You can turn on or off the Flattened mode by using the **Flattened** public property. The following code example illustrates how to set this property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                   |
|                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                         |
|                                                                                                    |
| [// Turn on]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                     |
|                                                                                                    |
| [DiagramWebControl1.Flattened = [true]{style="COLOR: blue"}; ]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                            |                                                                                                                                                                                                           |
|                                            |                                                                                                                                                                                                           |
|                                            | Flattened Mode                                                                                                                                                                                            |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Server Memory Usage**                    | Default, except when OptimizedBackgroundRendering is activated. For details, see [Optimized Background Rendering Mode]{.UGHyperlink}.                                                                     |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Client Memory Usage**                    | Default, except when OptimizedBackgroundRendering is activated. For details, see [Optimized Background Rendering Mode]{.UGHyperlink}[.]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Server HDD Space**                       | Default, except when OptimizedBackgroundRendering is activated. For details, see [Optimized Background Rendering Mode]{.UGHyperlink}.                                                                     |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Sever CPU Usage**                        | Default, except when OptimizedBackgroundRendering is activated. For details, see [Optimized Background Rendering Mode]{.UGHyperlink}.                                                                     |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Client CPU Usage**                       | May decrease when OptimizedBackgroundRendering is deactivated.                                                                                                                                            |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Interactive Ability**                    | No interaction -- only static view.                                                                                                                                                                       |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Interactive Speed**                      | Scrolling and panning will work faster when OptimizedBackgroundRendering is deactivated.                                                                                                                  |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Initial Loading Time on Client Browser** | Decreases in most of cases.                                                                                                                                                                               |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Data Size from Server to Client**        | Decreases in most of cases.                                                                                                                                                                               |
+--------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[Optimization]{.UGHyperlink}[, ]{.UGHyperlink}[Properties and Events for Optimization]{.UGHyperlink}[, ]{.UGHyperlink}[Optimized Background Rendering Mode]{.UGHyperlink}[, ]{.UGHyperlink}[Optimized Content Rendering Mode]{.UGHyperlink}[, ]{.UGHyperlink}[Diagram Optimization via HTML Elements]{.UGHyperlink}[, ]{.UGHyperlink}[Diagram Caching Modes]{.UGHyperlink}[, ]{.UGHyperlink}[Virtual Caching Type and Image Grid Cell Updating Event]{.UGHyperlink}[, ]{.UGHyperlink}[Optimization Customization]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
:::::
