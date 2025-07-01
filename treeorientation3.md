::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=66a598fc-f2a7-43e4-a96a-f544d63972b4){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6fe97994-93ab-4d08-a72c-4f1ae77ff4f4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Diagram Model](ms-xhelp:///?Id=be19c280-2b22-42bc-855f-c6c4be06cdab){.d2h_breadcrumbsNormal}
:::

### Tree Orientation  {#tree-orientation style="tab-stops: 0pt"}

The Layout Manager lets you orient the tree in many directions and can be used for the creation of many sophisticated arrangements. The **Orientation** property of **Diagram Model** can be used to specify the tree orientation. 

Properties

+-------------+-------------------------------+----------------------+---------------------------+--------------------------------------------------+
| Property    | Description                   | Type of the Property | Value it Accepts          | Any Other Dependencies/Sub-Properties Associated |
+-------------+-------------------------------+----------------------+---------------------------+--------------------------------------------------+
| Orientation | Gets or sets the orientation. | CLR Property         | TreeOrientation.LeftRight | No                                               |
|             |                               |                      |                           |                                                  |
|             |                               |                      | TreeOrientation.RightLeft |                                                  |
|             |                               |                      |                           |                                                  |
|             |                               |                      | TreeOrientation.TopBottom |                                                  |
|             |                               |                      |                           |                                                  |
|             |                               |                      | TreeOrientation.BottomTop |                                                  |
+-------------+-------------------------------+----------------------+---------------------------+--------------------------------------------------+

 

The following are the four orientations supported:

 

[·      ]{style="FONT-FAMILY: Symbol"}**TopBottom**---Places the root node at the top and the child nodes are arranged below the root node.

[·      ]{style="FONT-FAMILY: Symbol"}**BottomTop**---Places the root node at the bottom and the child nodes are arranged above the root node.

[·      ]{style="FONT-FAMILY: Symbol"}**LeftRight**---Places the root node at the left and the child nodes are arranged on the right side of the root node.

[·      ]{style="FONT-FAMILY: Symbol"}**RightLeft**---Places the root node at the right and the child nodes are arranged on the left side of the root node. 

 

The **RootOffsetX** and **RootOffsetY** properties can be used to specify the position of the root node based on which the entire tree gets generated. 

The tree orientation can be set using the following code: 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=f162dcda-50ea-4547-8a18-dc1168b39447){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using Properties Model](ms-xhelp:///?Id=e5d65ab7-55a5-49f7-9837-0d352c3a64b7){style="TEXT-DECORATION: none"}
::::
