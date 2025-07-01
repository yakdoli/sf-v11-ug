::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ffecc17b-c690-435e-8d44-4514802030d1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9efd05e8-45ae-40fa-8790-c8e9b8210e02){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}
:::

## Formatting {#formatting style="tab-stops: 0pt"}

 

Essential Grid allows  you to format grid cells. You can achieve this formatting by three methods. They are:

[·      ]{style="FONT-FAMILY: Symbol"}Using column formatting

[·      ]{style="FONT-FAMILY: Symbol"}Using custom actions

[·      ]{style="FONT-FAMILY: Symbol"}Using conditional formatting

 

Properties

 

 

::: {align="center"}
  -------------------- --------------------------------------------------------------------------------------------- ---------------------------------------------------- --------------------------------------------------
  Property             Description                                                                                   Type of the property                                 Value it accepts
  ConditionalFormats   A collection from GridConditionalFormatDescritor that defines conditional formats for Grid.   ICollection\<GridConditionalFormatDescritor\<T\>\>   IEnumerable of GridConditionalFormatDescriptors.
  Format               Gets or sets format for the column.                                                           String                                               Any string
  CssClass             Used to CssClass for the  the Column.                                                         String                                               Any class name in string format
  -------------------- --------------------------------------------------------------------------------------------- ---------------------------------------------------- --------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Methods

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

::: {align="center"}
+-----------------------------------+----------------------+-------------------------+-------------------------------------------------------------------------+
| Method                            | Parameters           | Return type             | Descriptions                                                            |
+-----------------------------------+----------------------+-------------------------+-------------------------------------------------------------------------+
| QueryCellInfo(GridTableCell\<T\>) | GridTableCell\<T\>   | Void                    | Used to format the cell dynamically.                                    |
|                                   |                      |                         |                                                                         |
|                                   |                      |                         | Executed for every cell in the grid.                                    |
+-----------------------------------+----------------------+-------------------------+-------------------------------------------------------------------------+
| RowDataBound(GridTableRow\<T\>)   | GridTableRow\<T\>    | Void                    | Used to format the row dynamically. Executed for every row in the grid. |
+-----------------------------------+----------------------+-------------------------+-------------------------------------------------------------------------+
| Format(string)                    | Format string        | IGridColumnBuilder\<T\> | Used to set the format to the column.                                   |
+-----------------------------------+----------------------+-------------------------+-------------------------------------------------------------------------+
| CssClass(string)                  | Class name as string | IGridColumnBuilder\<T\> | Used to set the CssClass to the column.                                 |
+-----------------------------------+----------------------+-------------------------+-------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Column Formatting](ms-xhelp:///?Id=9efd05e8-45ae-40fa-8790-c8e9b8210e02){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Custom Actions](ms-xhelp:///?Id=d7d6e9e3-118a-4854-b3f2-083695e4d444){style="TEXT-DECORATION: none"}
::::::
