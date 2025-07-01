::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=edea31f5-da2c-4d4a-9825-06cd5a71e037){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c98195aa-a9e8-43aa-bf85-dbb7933fc8a8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Diagram Model](ms-xhelp:///?Id=be19c280-2b22-42bc-855f-c6c4be06cdab){.d2h_breadcrumbsNormal}
:::

### Dragging Mode of Node {#dragging-mode-of-node style="tab-stops: 0pt"}

Essential Diagram for MVC provides preview support while dragging a node in the diagram page[[. When you drag any node within the diagram page, a preview of the dragged node will be displayed. ]{style="COLOR: black"}]{.apple-style-span}

Use Case Scenario

[[This feature displays a preview of the node you drag from diagram page, thus enables you to identify the node you are dragging from the diagram page.]{style="COLOR: black"}]{.apple-style-span}

Property

+------------------------------------------+---------------------------------------------------------------------------------------+----------------------+----------------------------------------------------------------------------+----------------------------------------------------+
| Property                                 | Description                                                                           | Type of the Property | Value it Accepts                                                           | Any Other Dependencies/Sub-Properties Associated   |
+==========================================+=======================================================================================+======================+============================================================================+====================================================+
| [NodeDraggingMode]{style="COLOR: black"} | Gets or sets a value indicating whether node is dragged with preview or default mode. | Dependency property  | [DraggingType]{style="COLOR: #2b91af"}.[DefaultMode]{style="COLOR: black"} | No (This property is not supported in Canvas mode) |
|                                          |                                                                                       |                      |                                                                            |                                                    |
|                                          | ``` {style="BACKGROUND: white"}                                                       |                      |                                                                            |                                                    |
|                                          | The default value is DefaultMode.                                                     |                      |                                                                            |                                                    |
|                                          | ```                                                                                   |                      | [DraggingType.]{style="COLOR: #2b91af"}[PreviewMode]{style="COLOR: black"} |                                                    |
+------------------------------------------+---------------------------------------------------------------------------------------+----------------------+----------------------------------------------------------------------------+----------------------------------------------------+

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=76c8d8b2-6037-4a54-9e03-b24723a5410d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using Properties Model](ms-xhelp:///?Id=dbdfa9d8-6763-4ae8-9aa4-38602f1e602a){style="TEXT-DECORATION: none"}
::::
