::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c49f7b99-e217-40bb-a068-544fb6cef873){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}
:::

## Action Modes {#action-modes style="tab-stops: 0pt"}

 

The Grid control handles data presentation operations like paging and sorting, or you can perform those operations. But this mode of action for the Grid control is decided using the **ActionMode** property whose options are described in the following table.

Essential Grid supports two kinds of ActionModes.

Properties

 

 

::: {align="center"}
+-----------------+-----------------------------------------------------------------------------------------------------------------------------+------------------+------------------+
| Property        | Description                                                                                                                 | Type of property | Value it accepts |
+-----------------+-----------------------------------------------------------------------------------------------------------------------------+------------------+------------------+
| ActionMode      | Used to set the action mode of the control.                                                                                 | String           | "Json"/"Server"  |
|                 |                                                                                                                             |                  |                  |
|                 | Server---All the operations like sorting and grouping are handled by Essential Grid itself (by default).                    |                  |                  |
|                 |                                                                                                                             |                  |                  |
|                 | JSON (JavaScript Object Notation)---You have to handle the operations. The only possible operations are paging and sorting. |                  |                  |
+=================+=============================================================================================================================+==================+==================+
:::

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Methods

 

 

::: {align="center"}
  Method               Parameters   Return type         Descriptions
  -------------------- ------------ ------------------- -----------------------------------------
  ActionMode(string)   actionMode   IGridBuilder\<T\>   Used to set the action mode to control.
:::

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=c49f7b99-e217-40bb-a068-544fb6cef873){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=cbd77497-1796-424b-b6c5-89fd43829b31){style="TEXT-DECORATION: none"}
::::::
