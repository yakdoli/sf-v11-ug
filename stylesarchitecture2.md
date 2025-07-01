::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Styles Architecture {#styles-architecture style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

The tree control employs an extensive Styles Architecture, that let users specify node styles globally, specifically for a class of nodes. This is possible by using a style information instance for each class of nodes, represented by a **TreeNodeAdvStyleInfo**. Users will notice that for some of these classes of nodes, the style needs to be declared with a name at the tree level and stored in the tree\'s BaseStyles hatch table.

 

As illustrated below, implicit style inheritance is enforced by the framework while explicit style inheritance can be setup by the programmer. For all styles, explicit inheritance precedes implicit inheritance.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_1129.jpg){border="0"}

[]{style="COLOR: #15428b"} 

Figure 1153: Implicit and Explicit Style Inheritance

**[]{style="COLOR: #15428b"}** 

Implicit Style Inheritance

 

When a style is not set in a style info object, it inherits the style from the previous level and so on until it reaches the default global style on top of the hierarchy. This is called implicit style inheritance and is illustrated below.

 

The different levels in the above hierarchy are,

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol; COLOR: black"}**Node Specific Style**: At the bottom of the hierarchy is the node specific style which lets users specify a style directly on a TreeNodeAdv. Refer Node specific Style.[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol; COLOR: black"}**Node\'s Child Style**: Each node also exposes a **ChildStyle** property where you can specify the style for the immediate children of that node. Refer Child Style[ ]{style="COLOR: black"}for setting style of children nodes[.]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}**Node Level Styles**: The framework also lets you specify a style for all nodes at a particular level in the tree hierarchy, the top-most level being 1. Refer Node Level Style[ ]{style="COLOR: black"}for setting node level style settings.

[·      ]{style="FONT-FAMILY: Symbol"}**Standard Style or Global Style**: A standard, global style is exposed by the TreeViewAdv control to be applied on all the nodes in the tree. Refer Standard Style[ ]{style="COLOR: black"}for setting style in a Tree level.

[]{style="COLOR: #15428b"} 

Explicit Style Inheritance

 

Any StyleInfo instance can also inherit explicitly from a specific named StyleInfo object. This can be done using the BaseStyle property of the TreeNodeAdvStyleInfo type. As noted previously, such named styles should be available in the tree control\'s BaseStyles Collection Editor. You can also add custom styles using this editor.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------------ ----------------------------------------
  TreeViewAdv Properties   Description
  BaseStyle                Indicates the base style of the nodes.
  ------------------------ ----------------------------------------
:::

[]{style="COLOR: #15428b"} 

StandardStyle is the default style for the nodes. It can be edited using **StandardStyle** property. It can also be edited through BaseStyles Collection Editor dialog.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_1130.jpg){border="0"}

[]{style="COLOR: #15428b"} 

Figure 1154: BaseStyles Collection Editor

 

 

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Standard Style](ms-xhelp:///?Id=554306f2-0415-4ab4-b1d0-0b4775baee40){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Specific Style](ms-xhelp:///?Id=5f778a01-b063-468b-86e2-344d9a92a097){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Child Style](ms-xhelp:///?Id=b9562f7c-4147-4f1c-8344-e4a5cf420a35){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Level Style](ms-xhelp:///?Id=09027846-56bc-451a-9690-423ad773330b){style="TEXT-DECORATION: none"}
::::
