::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4c13a876-f22d-46ba-9eef-94e5014a9758){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=631bcf33-4104-4a02-a65a-5133e095b6dd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Tools Controls](ms-xhelp:///?Id=13c3c4f4-9d16-4b69-93f2-7e98eec67452){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Layout Managers Package](ms-xhelp:///?Id=d0ebd7bb-debf-4a29-97c5-763f1819bafc){.d2h_breadcrumbsNormal}
:::

### Overview of Layout Manager {#overview-of-layout-manager style="tab-stops: 0pt"}

Layout Manager

[]{style="COLOR: #15428b"} 

The Layout Manager is the base type of all components, providing a basic layout management framework over which the individual managers build on. It provides fundamental information on the five layout managers included in this package which are listed below.

[]{style="COLOR: #15428b"} 

BorderLayout

[]{style="COLOR: #15428b"} 

This Layout Manager will layout the Child controls along the borders and at the center, just like the .NET framework\'s built-in docking support.

[]{style="COLOR: #15428b"} 

CardLayout

[]{style="COLOR: #15428b"} 

This Layout Manager shows one Child control at a time in a Container.

[]{style="COLOR: #15428b"} 

FlowLayout

[]{style="COLOR: #15428b"} 

This Layout Manager will layout the Child components horizontally or vertically in a specific order, based on constraints. FlowLayout is one of the most commonly used Layout Managers.

[]{style="COLOR: #15428b"} 

GridLayout

[]{style="COLOR: #15428b"} 

This Layout Manager will layout Child controls in the form of a grid containing rows and columns.

[]{style="COLOR: #15428b"} 

GridBagLayout

[]{style="COLOR: #15428b"} 

This Layout Manager will layout the Child controls in a virtual grid of rows and columns. But, unlike the GridLayout, the size of the columns / rows can be varied and the children may span more than one cell.

 

[]{style="COLOR: #15428b"} 

[]{style="COLOR: #15428b"} 

 ![](ImagesExt/image76_638.jpg){border="0"}

[]{style="COLOR: #15428b"} 

Figure 649: Layout Managers in Toolbox

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Container Control

[]{style="COLOR: #15428b"} 

Container control is a control on which the Layout Manager is dropped or for which the layout is designed. All controls that inherit the System.Windows.Forms.ContainerControl can act as a Container control.

[]{style="COLOR: #15428b"} 

Windows Form and Panel controls are the most widely used Container controls.

[]{style="COLOR: #15428b"} 

Child Control

[]{style="COLOR: #15428b"} 

Child controls can be added to the Container control by just dragging and dropping the controls from the toolbox.

 

The Layout Managers can be associated with any Container control property. The Layout Managers will then automatically layout their Child controls based on specific constraints. They can also be used to layout the non-control-based components that are derived from a specific interface (LayoutItemBase) drawn within the Container.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"} Note: The Container control will be referred by its property name as ContainerControl and it\'s children referred to as Child components (emphasizing the fact that the children need not be a control-derived class) in this document.
:::

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[BorderLayout]{.UGHyperlink}[, ]{.UGHyperlink}[CardLayout]{.UGHyperlink}[, ]{.UGHyperlink}[FlowLayout]{.UGHyperlink}[, ]{.UGHyperlink}[GridLayout]{.UGHyperlink}[, ]{.UGHyperlink}[GridBagLayout]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
:::::
