::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7e1c1423-1de0-4782-b407-fff4875578fc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=cf66a97b-515c-4b11-a121-84b031379f49){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[MultiColumnDropDown](ms-xhelp:///?Id=cf0e6254-8964-4a67-b141-e26bc6e4f04a){.d2h_breadcrumbsNormal}
:::

### Data Binding {#data-binding style="tab-stops: 0pt"}

This section explains how to bind a data source to the MultiColumnDropDown control.

Properties

 

::: {align="center"}
+-------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+------------------+-------------------+--------------------------------------------------+
| Property          | Description                                                                                                                                     | Type of property | Value it accepts  | Any other dependencies/sub-properties associated |
+-------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+------------------+-------------------+--------------------------------------------------+
| Datasoource       | [Gets or sets the data source to multi column dropdown control. ]{style="FONT-FAMILY: 'Times New Roman','serif'"}                               | IEnumerable      |                   | NA                                               |
|                   |                                                                                                                                                 |                  |                   |                                                  |
|                   |                                                                                                                                                 |                  |                   |                                                  |
+-------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+------------------+-------------------+--------------------------------------------------+
| DisplayExpression | Specifies the column index values in array format used to set the result values into Textbox.[]{style="FONT-FAMILY: 'Times New Roman','serif'"} | Integer array    | Any integer array |                                                  |
+-------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+------------------+-------------------+--------------------------------------------------+
| AllowTextEdit     | Specifies edit text is editable or not. Default value is True.                                                                                  | Boolean          | True/false        |                                                  |
+-------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+------------------+-------------------+--------------------------------------------------+
:::

 

Methods

 

::: {align="center"}
+----------------------------+-----------------+-----------------------------+-------------------------------------------------------------------------------------------------------+
| Name                       | Parameters      | Return type                 | Descriptions                                                                                          |
+----------------------------+-----------------+-----------------------------+-------------------------------------------------------------------------------------------------------+
| DataSource (IEnumerable)   | Skins           | IMultiColumnDropDownBuilder | Used to set skins to multi column dropdown.                                                           |
|                            |                 |                             |                                                                                                       |
|                            |                 |                             |                                                                                                       |
+----------------------------+-----------------+-----------------------------+-------------------------------------------------------------------------------------------------------+
| DisplayExpression(int\[\]) | Integer array   | IMultiColumnDropdownBuilder | Specifies the column index values in array format that is used to set the result values into Textbox. |
+----------------------------+-----------------+-----------------------------+-------------------------------------------------------------------------------------------------------+
| AllowTextEdit(bool)        | bool            | IMultiColumnDropdownBuilder | Specifies if edit text is editable or not. Default value is True.                                     |
+----------------------------+-----------------+-----------------------------+-------------------------------------------------------------------------------------------------------+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through Builder](ms-xhelp:///?Id=2f41c590-d1f9-4626-a650-a48ca29b0371){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through MultiColumnDropDownModel](ms-xhelp:///?Id=36dcc5a2-cd4d-414c-b974-771c17f05f7e){style="TEXT-DECORATION: none"}
::::::
