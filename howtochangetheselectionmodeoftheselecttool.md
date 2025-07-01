::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a6bdf319-254f-48b2-83c4-8e6e24f641dd){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1f1c7f8b-6af4-4616-b2ab-bd8384b62ca4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How to Change the Selection Mode of the SelectTool {#how-to-change-the-selection-mode-of-the-selecttool style="tab-stops: 0pt"}

The Diagram SelectTool provides an enum property called *SelectMode*, to change the selection mode. The following are the supported selection modes:

[·      ]{style="FONT-FAMILY: Symbol"}**Containing** - Specific objects that are fully enveloped by the tracking rectangle will be selected by the tool.

[·      ]{style="FONT-FAMILY: Symbol"}**Intersecting** - Specific objects that are intersecting the tracking rectangle will be selected by the tool.

 

Containing is the default selection mode.

The following code snippet illustrates how to change the selection mode at runtime:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                             |
| [(([DiagramViewerEventSink]{style="COLOR: #2b91af"})diagram1.EventSink).ToolActivated += [new]{style="COLOR: blue"} [ToolEventHandler]{style="COLOR: #2b91af"}(Diagram_ToolActivated);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} Diagram_ToolActivated([ToolEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                             |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                             |
| [            [if]{style="COLOR: blue"} (evtArgs.Tool [is]{style="COLOR: blue"} [SelectTool]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                             |
| [                [//change the SelectionMode as \"Intersecting\" which Specifies that objects intersecting the tracking rectangle will be selected by the tool.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [                (([SelectTool]{style="COLOR: #2b91af"})evtArgs.Tool).SelectMode = [SelectMode]{style="COLOR: #2b91af"}.Intersecting;]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                             |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([CType]{style="COLOR: blue"}(Diagram1.EventSink, DiagramViewerEventSink)).ToolActivated, [AddressOf]{style="COLOR: blue"} Diagram_ToolActivated]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                                                                                                                                                                |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} Diagram_ToolActivated([ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} ToolEventArgs)]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                                                                                |
| [        [If]{style="COLOR: blue"} [TypeOf]{style="COLOR: blue"} evtArgs.Tool [Is]{style="COLOR: blue"} SelectTool [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                                                                |
| [            [\'change the SelectionMode as \"Intersecting\" which Specifies that objects intersecting the tracking rectangle will be selected by the tool. ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                                                                                |
| [            [CType]{style="COLOR: blue"}(evtArgs.Tool, SelectTool).SelectMode = SelectMode.Intersecting]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                |
| [        [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

 

 

[]{#related-topics}
::::
