::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a57b4fb4-fd68-47a4-8470-5dacafd9aad3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a9ae3fd1-e473-418f-ad79-e7927f3dc5af){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Groups {#groups style="tab-stops: 0pt"}

[]{#p60}Essential Diagram WPF provides support to group and ungroup nodes. Grouping feature comes in handy when you want to apply the same edits to a number of objects and yet retain their individuality. All the operations performed on the group also affect the individual items in the group. However any item in the group can also be edited individually. On ungrouping, the items in the group again act as individual entities.

 

A Group is essentially just another node added which acts as a container for other objects. Therefore a group node is referred to as the parent node, and the grouped objects are referred to as the children of the group.

 

The **Group** class is inherited from the **Node** class. Therefore all the node properties apply to a group too.

 

The following table lists the methods that are used for grouping.

 

Table 49: Property Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

::: {align="center"}
  ------------------------------- ------------ ------------- --------------------------------------------------------------------------------------------------------------------------- ----------------
  Name                            Parameter    Return Type   Description                                                                                                                 Reference Type
  Group.AddChild(INodeGroup)      INodeGroup   void          Adds the specified INodeGroup object to the group. INodeGroup provides an interface to the nodes and the connectors.        N/A
  Group.RemoveChild(INodeGroup)   INodeGroup   void          Removes the specified INodeGroup object from the group. INodeGroup provides an interface to the nodes and the connectors.   N/A
  ------------------------------- ------------ ------------- --------------------------------------------------------------------------------------------------------------------------- ----------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Create Group](ms-xhelp:///?Id=a9ae3fd1-e473-418f-ad79-e7927f3dc5af){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Select Group](ms-xhelp:///?Id=3c602506-b69a-473f-9b3d-1265bec21a57){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Edit Group](ms-xhelp:///?Id=5164a2fe-15db-4cef-9bdf-985efad6ce8b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Connecting Groups](ms-xhelp:///?Id=04488ef9-4465-4b1c-995a-afd6eb8b161d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Ungroup](ms-xhelp:///?Id=153a9a0d-8290-49dc-8717-69e9c2ca048e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Layers](ms-xhelp:///?Id=4f19c0af-ea90-4976-9a2e-182e50314a60){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Hidden or Active Layer](ms-xhelp:///?Id=6483aa7a-cb65-41e1-ac59-237a6766e2f8){style="TEXT-DECORATION: none"}
:::::
