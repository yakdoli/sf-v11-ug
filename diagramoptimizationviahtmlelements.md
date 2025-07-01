::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=87c73eb8-0ffe-4ece-81f2-9386505f8639){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=eca3b060-1eec-4d92-8cc6-3cdd27014c1d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f9aa55fb-f8cf-43da-a8be-de231dc0d949){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Optimization](ms-xhelp:///?Id=b87d4bc7-af66-4e6f-81ff-c63c4bc639b4){.d2h_breadcrumbsNormal}
:::

### Diagram Optimization via HTML Elements[]{style="FONT-SIZE: 10pt"} {#diagram-optimization-via-html-elements style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There are situations when you do not have to render diagram document background as an image. If the diagram document background is simple, you can activate the optimization via HTML elements, by using the public property, **UseHTMLBackground**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image65_1.jpg){border="0"}[Note]{style="BACKGROUND: white"}[: ]{style="BACKGROUND: white"}A simple diagram document background is one that does not have any textures, color gradients or fill hatch styles, and so on.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The main advantages are increased loading speed, increased rendering speed, small memory usage and high interactivity speed. Also this optimization is not sensitive to the document size.

 

***[Warning]{style="BACKGROUND: white"}***[:]{style="BACKGROUND: white"}***[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}***Diagram border cannot be drawn in this mode.

 

You can turn on or off this mode by using the **UseHTMLBackground** public property. The following code example illustrates how to set this property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                 |
|                                                                                                            |
| [// Turn on]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                             |
|                                                                                                            |
| [DiagramWebControl1.UseHTMLBackground = [true]{style="COLOR: blue"}; ]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------------------------+-----------------------------------+
|                                            |                                   |
|                                            |                                   |
|                                            | UseHTMLBackground                 |
+--------------------------------------------+-----------------------------------+
| **Server Memory Usage**                    | Decreases                         |
+--------------------------------------------+-----------------------------------+
| **Client Memory Usage**                    | Decreases                         |
+--------------------------------------------+-----------------------------------+
| **Server HDD Space**                       | Default                           |
+--------------------------------------------+-----------------------------------+
| **Sever CPU Usage**                        | Decreases                         |
+--------------------------------------------+-----------------------------------+
| **Client CPU Usage**                       | Decreases                         |
+--------------------------------------------+-----------------------------------+
| **Interactive Ability**                    | All interactions are allowed.     |
+--------------------------------------------+-----------------------------------+
| **Interactive Speed**                      | Default                           |
+--------------------------------------------+-----------------------------------+
| **Initial Loading Time on Client Browser** | Decreases                         |
+--------------------------------------------+-----------------------------------+
| **Data Size from Server to Client**        | Decreases                         |
+--------------------------------------------+-----------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[Optimization]{.UGHyperlink}[, ]{.UGHyperlink}[Properties and Events for Optimization]{.UGHyperlink}[, ]{.UGHyperlink}[Optimized Background Rendering Mode]{.UGHyperlink}[, ]{.UGHyperlink}[Optimized Content Rendering Mode]{.UGHyperlink}[, ]{.UGHyperlink}[Diagram Caching Modes]{.UGHyperlink}[, ]{.UGHyperlink}[Virtual Caching Type and Image Grid Cell Updating Event]{.UGHyperlink}[, ]{.UGHyperlink}[Optimization Customization]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
::::::
