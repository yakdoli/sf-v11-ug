::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=fe84b6a3-fe1a-449e-9a42-7ec0ad40cec7){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b4af1a07-0f91-4388-82de-75fead2f8c5f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## TreeView

***TreeViewAdv*** control displays hierarchical data in tree structure with support for Blendability, drag and drop, context menu, left, right and state images (Collapsed image and Expand image). Each item (or node) in TreeViewAdv can have a number of sub items.

The core features of *TreeViewAdv* are:

[·      ]{style="FONT-FAMILY: Symbol"}Data binding support with objects such as XML, WCF services

[·      ]{style="FONT-FAMILY: Symbol"}Customizable root lines

[·      ]{style="FONT-FAMILY: Symbol"}Image support for expand, collapse item states and Left, Right image support

[·      ]{style="FONT-FAMILY: Symbol"}Drag and Drop support

[·      ]{style="FONT-FAMILY: Symbol"}Multi Selection

[·      ]{style="FONT-FAMILY: Symbol"}Keyboard support

[·      ]{style="FONT-FAMILY: Symbol"}TreeViewItemAdv Editing support

 

  Name                    Type                 Value it accepts   Description                                                                      Default Value   Reference Link
  ----------------------- -------------------- ------------------ -------------------------------------------------------------------------------- --------------- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  ContextMenu             DependencyProperty   ContextMenuAdv     Gets or sets the contextmenu for TreeViewAdv.                                    Null            [[ContextMenu]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Context_Menu_Support)[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}
  DragLineVisibility      DependencyProperty   Visibility         Gets or sets the Visibility of DragLine.                                         True            [[DragLineVisibility]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Drag_and_Drop)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  DraggingEnabled         DependencyProperty   Bool               Gets or sets the Visibility of DragLine.                                         True            [[DraggingEnabled]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Drag_and_Drop)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  EnableMouseOverEffect   DependencyProperty   Bool               Enables or disables the MouseOverEffect.                                         True            [[EnableMouseOverEffect]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_How_to_disable)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  FullRowSelect           DependencyProperty   Bool               Gets or sets the FullRowSelect property.                                         True            [[FullRowSelect]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_FullRowSelect)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  IsMultiSelect           DependencyProperty   Bool               Enables or disables MultiSelection in TreeViewAdv.                               False           [[IsMultiSelect]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_MultiSelection)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  RootLineVisibility      DependencyProperty   Bool               Gets or sets the visibility of RootLine.                                                         [[RootLineVisibility]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_RootLine_Support)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  IsInEditMode            DependencyProperty   ImageSource        Enables or disables the EditMode in TreeViewAdv.                                 False           [[IsInEditMode]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Editing_TreeViewItemAdv)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  CollapseImageSource     DependencyProperty   ImageSource        Gets or sets the ImageSource to display when the item is collapsed.              Null            [[CollapseImageSource]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Expand_and_Collapse)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  ExpandImageSource       DependencyProperty   ImageSource        Gets or sets the ImageSource to display when the item is expanded.               Null            [[ExpandImageSource]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Expand_and_Collapse)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  LeftImageSource         DependencyProperty   ImageSource        Gets or sets the ImageSource to show on the Left side of the TreeViewItemAdv.    Null            [[LeftImageSource]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Left_and_Right)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  RightImageSource        DependencyProperty   ImageSource        Gets or sets the ImageSource to show on the right side of the TreeViewItemAdv.   Null            [[RightImageSource]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Left_and_Right)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}
  IsExpanded              DependencyProperty   Bool               Gets or sets the state of the TreeViewItemAdv                                    False           [[IsExpanded]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #1364c4"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_TreeViewItem)[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

More:

[ ]{#related-topics}

[![](../button.gif){border="0" align="absMiddle"}Control Structure](ms-xhelp:///?Id=b4af1a07-0f91-4388-82de-75fead2f8c5f){style="TEXT-DECORATION: none"}

[![](../button.gif){border="0" align="absMiddle"}Features](ms-xhelp:///?Id=e3fea4a0-265f-481b-bfa5-a0ff12e0d63b){style="TEXT-DECORATION: none"}

[![](../button.gif){border="0" align="absMiddle"}How to](ms-xhelp:///?Id=61ee2760-eed4-4efd-b98c-9bc1673c57f4){style="TEXT-DECORATION: none"}
:::
