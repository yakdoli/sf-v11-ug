::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6f4a0e5e-48dc-4dc3-87e7-705426cf4ec2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0c3044e5-1fdb-4f23-b73f-a73cd7caf33d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}
:::

## Groups {#groups style="tab-stops: 0pt"}

 

[]{#p60}Essential Diagram Silverlight provides support to group and ungroup nodes. The Grouping feature comes in handy when you want to apply the same edits to a number of objects and yet retain their individuality. All the operations performed on the group also affect the individual items in the group. However any item in the group can also be edited individually. On ungrouping, the items in the group again act as individual entities.

 

A Group is essentially just another node added, which acts as a container for other objects. Therefore a group node is referred to as the parent node, and the grouped objects are referred to as the children of the group.

 

The Group class is inherited from the Node class. Therefore all the node properties apply to a group too.

 

The following table lists the methods that are used for grouping.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------------------- ---------------------------------------------------------------------------------------------------------------------------
  Method                                Description
  Group.AddChild(INodeGroup child)      Adds the specified INodeGroup object to the group. INodeGroup provides an interface to the nodes and the connectors.
  Group.RemoveChild(INodeGroup child)   Removes the specified INodeGroup object from the group. INodeGroup provides an interface to the nodes and the connectors.
  ------------------------------------- ---------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating a Group](ms-xhelp:///?Id=0c3044e5-1fdb-4f23-b73f-a73cd7caf33d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Editing a Group](ms-xhelp:///?Id=d9d7ac92-8999-4187-8612-df9dc0f58aed){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Connecting Groups](ms-xhelp:///?Id=b45b3494-65e9-44de-b3d7-3ea75acf79c2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Ungroup](ms-xhelp:///?Id=8c9c9f51-3f17-4ed4-bc2a-92ba54b8aa96){style="TEXT-DECORATION: none"}
:::::
