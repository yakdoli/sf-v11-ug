::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=53000f73-da02-46a6-84da-95adc28a841a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f25630a0-d3de-450c-9fc9-7966d1a701d5){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f9aa55fb-f8cf-43da-a8be-de231dc0d949){.d2h_breadcrumbsNormal}
:::

## []{style="FONT-SIZE: 10pt"}[]{#p36}[]{#_Optimization}Optimization[]{style="FONT-SIZE: 10pt"} {#optimization style="tab-stops: 0pt"}

 

When you drag the DiagramWebControl onto an aspx page, the control will be created with default settings. No optimization modes will be active. Such a control has excellent performance and user interaction in the most of common cases. It is best for small documents with less nodes.

 

However you can create large documents, i.e., documents with many nodes, which are not all in view-port at the same time. For this reason, DiagramWebControl has useful optimization modes.

 

There are two main optimizations: for diagram document background (**OptimizedBackgroundRendering** mode) and for diagram document content (**OptimizedContentRendering** mode).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[Note]{style="BACKGROUND: white"}[:]{style="BACKGROUND: white"} Diagram document content is a collection of diagram nodes.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Now you can use the caching optimization for fast loading prepared images in the future. You can separately mark one special caching mode, i.e., Virtual.

You can also customize the optimization modes of the DiagramWebControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[Properties and Events for Optimization,]{.UGHyperlink}[ ]{.UGHyperlink}[Optimized Background Rendering Mode]{.UGHyperlink}[, ]{.UGHyperlink}[Optimized Content Rendering Mode,]{.UGHyperlink}[ ]{.UGHyperlink}[Flattened Mode]{.UGHyperlink}[, ]{.UGHyperlink}[Diagram Optimization via HTML Elements]{.UGHyperlink}[, ]{.UGHyperlink}[Diagram Caching Modes]{.UGHyperlink}[, ]{.UGHyperlink}[Virtual Caching Type and Image Grid Cell Updating Event]{.UGHyperlink}[, ]{.UGHyperlink}[[Optimization Customization]{style="COLOR: blue"}]{.UGHyperlink}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Properties and Events](ms-xhelp:///?Id=f25630a0-d3de-450c-9fc9-7966d1a701d5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Optimized Background Rendering Mode](ms-xhelp:///?Id=28164b3e-b9a0-46d2-9bb8-c790e025a4bd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Optimized Content Rendering Mode](ms-xhelp:///?Id=88bf5521-7256-4cd6-9555-6b81c9646f68){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Flattened Mode](ms-xhelp:///?Id=87c73eb8-0ffe-4ece-81f2-9386505f8639){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Diagram Optimization via HTML Elements](ms-xhelp:///?Id=b4e24b18-1acc-4652-94ce-4c246b8a86cc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Diagram Caching modes](ms-xhelp:///?Id=eca3b060-1eec-4d92-8cc6-3cdd27014c1d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Virtual Caching Type and Image Grid Cell Updating Event](ms-xhelp:///?Id=9b1c2bf3-f784-41d5-872d-fadc1ff99d96){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Optimization Customization](ms-xhelp:///?Id=c5db2127-a586-4fb4-aced-3289a504c161){style="TEXT-DECORATION: none"}
:::::
