::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3f84b720-8b83-422e-948f-88d7c396dd1c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=34221523-67af-4851-a010-ad9c3d9ecb5c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data Binding](ms-xhelp:///?Id=4e3356df-66f2-4ab8-801e-d5ab48a4e93a){.d2h_breadcrumbsNormal}
:::

### Unbound Column {#unbound-column style="tab-stops: 0pt"}

The data you display in the Grid control will normally come from a data source of some kind, but you might want to display a column of data that does not come from the data source. This kind of column is called an unbound column.

Unbound columns are used to display custom content in the grid. For example, if you want to display some new columns like buttons or links to other parts of the grid, this feature will be useful.

Essential Grid supports adding unbound column through **IRootGridColumnBuilder** in the view. While using unbound columns you will be unable to perform sorting, grouping, and filtering functionalities.

 

Methods

 

::: {align="center"}
  ----------- -------------------------------------------- -------------- -------------------------
  Method      Descriptions                                 Parameters     Return type
  Add()       Used to add unbound column to grid control   string         IRootColumnBuilder\<T\>
  UnBound()   Used to convert the bound to Unbound         No parameter   IColumnBuilder\<T\>
  ----------- -------------------------------------------- -------------- -------------------------
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through GridBuilder](ms-xhelp:///?Id=f72a0a29-864c-4758-83fe-c74f6694ba92){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through GridPropertiesModel](ms-xhelp:///?Id=2222ac2e-1f57-489d-ad04-81324335de12){style="TEXT-DECORATION: none"}
:::::
