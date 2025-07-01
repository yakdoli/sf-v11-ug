::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=fcaa087e-0a8c-4e93-a91d-75fef7304e13){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a75e4b42-9cc6-4ff7-af15-3ce52ab02fa5){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Toolbar](ms-xhelp:///?Id=23189d4a-325f-4b16-ae02-c7743a26d407){.d2h_breadcrumbsNormal}
:::

### Methods {#methods style="tab-stops: 0pt"}

The following table provides the methods of the **ToolbarOptions** class.

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

::: {align="center"}
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| Method                                                                             | Method                            | Return type                 | Description                                                                 |
+====================================================================================+===================================+=============================+=============================================================================+
| Add(Expression\<Func\<T, object\>\> expression)                                    | Expression                        | IGridPrimaryKeyBuilder\<T\> | Used to add the primary keys to grid                                        |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| ToolBar(Action\<IToolBarBuilder\> toobar)                                          | Action\<IToolbarbuilder\> toolbar | IEditingBuilder\<T\>        | Used to configure the toolbar in the editing mode                           |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| Add(GridToolBarItems item)                                                         | GridToolBarItems                  | IToolBarBuilder             | Used to add the toolbar item to grid                                        |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| Add(GridToolBarItems item, string caption)                                         | GridToolBarItems, string          | IToolBarBuilder             | Used to add the toolbar item with a caption                                 |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| Add(string customItemTitle, string customItemCssClass)                             | string, string                    | IToolBarBuilder             | Used to add the custom toolbar item with title and customCss class          |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| Add(GridToolBarItems item, string caption, string mapper)                          | GridToolBarItems, string, string  | IToolBarBuilder             | Used to add the toolbar item with caption and mapper                        |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
|  Add(string customItemTitle, string customItemCaption,  string customItemCssClass) | string, string, string            |  IToolBarBuilder            | Used to add the custom toolbar item with title, caption and customCss class |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
| EnableToolbar(bool enable)                                                         | Bool                              | IToolBarBuilder             | Used to enable or disable the toolbar in grid.                              |
|                                                                                    |                                   |                             |                                                                             |
|                                                                                    |                                   |                             |                                                                             |
+------------------------------------------------------------------------------------+-----------------------------------+-----------------------------+-----------------------------------------------------------------------------+
:::

**[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}** 

[]{#related-topics}
:::::
