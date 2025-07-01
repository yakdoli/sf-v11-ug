::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a7a3286c-273f-45a8-afd4-f1c7e33318da){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f32b7ff1-fac8-4cad-85f1-78a90c57d78f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8126789d-b192-4c3c-9e36-f0119f12b8b9){.d2h_breadcrumbsNormal}
:::

## Grid Tree control {#grid-tree-control style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Grid Tree control serves as multi-column trees control that is optimized to display tens and thousands of items. The control uses a modified load-on-demand architecture to manage the interactions between the Grid Tree control and the underlying data source. In a load-on-demand architecture, the information is loaded only when it is visible. Upon the initial display of the Grid Tree control, only the root items are loaded. Thereafter, information is retrieved from the underlying data source to display the newly loaded child items, whenever a tree node is expanded.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Key Features

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}You can control the order, content and appearance of the columns that appear in the Grid Tree.

[·      ]{style="FONT-FAMILY: Symbol"}There are options to display different drawing glyphs to indicate the expand node in the control.

[·      ]{style="FONT-FAMILY: Symbol"}You can display tree lines and images in the expand node.

[·      ]{style="FONT-FAMILY: Symbol"}You can display bitmaps in the expand cell by handling the RequestNodeImage event.

[·      ]{style="FONT-FAMILY: Symbol"}The Grid Tree control supports special column sizing behaviors so that the columns in your Grid Tree control will expand/collapse to occupy all the client area of the control, as the Grid Tree control's parent window is sized.

[·      ]{style="FONT-FAMILY: Symbol"}There are two selection architectures from which you can choose, one that selects whole rows, or the one that allows arbitrary cell selections. In both cases, the selections persist as the nodes in the Grid Tree control are expanded or collapsed.

[·      ]{style="FONT-FAMILY: Symbol"}Additionally, multicolumn sorting is supported by clicking and/or by holding the Ctrl key and clicking the column headers using mouse button.

[·      ]{style="FONT-FAMILY: Symbol"}You can specify cell style properties either by column or hierarchy levels.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following sections discuss the major features and properties of the Grid Tree control in depth. The discussions include-how the control is populated with data, how the display of the control is determined, and the properties that control the functionality available in the Grid Tree control as well as the general architecture to the control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Architecture-Describes on the GTC architecture

[·      ]{style="FONT-FAMILY: Symbol"}Grid Tree control Properties-Lists the properties with description

[·      ]{style="FONT-FAMILY: Symbol"}Data Population-Describes how to populate data in a Grid Tree control

[·      ]{style="FONT-FAMILY: Symbol"}Interactive Features-Describes the interactive feature in GTC at run time

[·      ]{style="FONT-FAMILY: Symbol"}Appearance-Properties that are used to enhance the appearance of the GTC are discussed in this section

[·      ]{style="FONT-FAMILY: Symbol"}Grid Tree control Events- Events that are handled for GTC are discussed here

[]{#p268} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Architecture](ms-xhelp:///?Id=f32b7ff1-fac8-4cad-85f1-78a90c57d78f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Grid Tree control Properties](ms-xhelp:///?Id=e7a25934-1ee3-49f5-8da4-9f822a65c79e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}GridTreeNode Objects](ms-xhelp:///?Id=abce9fd4-10de-4584-9f20-4df803ac6ea0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Population](ms-xhelp:///?Id=bf3e9394-b93f-4a17-90c8-d8d9d6847274){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Interactive Features](ms-xhelp:///?Id=b255038d-3503-4e63-95bf-33cc80d11988){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Styles Support](ms-xhelp:///?Id=f574a81e-90e6-4c19-a2f1-eae725594e5d){style="TEXT-DECORATION: none"}
::::
