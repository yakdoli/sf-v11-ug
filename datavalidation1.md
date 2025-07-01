::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0f56dccc-6391-45d5-b4a5-b838f27ce69c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=97fa1ac5-0a87-489a-b21f-051b97f21541){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Spreadsheet]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=625a8128-e556-4a29-9ea6-d472120ad9e1){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data Management](ms-xhelp:///?Id=1127a59c-3e3e-44d6-9cf4-1a5208536317){.d2h_breadcrumbsNormal}
:::

### Data Validation {#data-validation style="tab-stops: 0pt"}

The Data Validation enables you to dynamically validate the data entered in a cell. You can specify the validation rules in the Data Validation dialog box. Spreadsheet control supports the various validation types for each data type. This also enables you to show the error message for invalid data.

 

![](ImagesExt/image27_27.png){border="0"}

Figure 21: Data Validation dialog box

 

 

Data Validation in Spreadsheet control

Essential Spreadsheet control enables you to edit the existing data validation. You can also create new data validation. Spreadsheet control supports the following validation types:

[·      ]{style="FONT-FAMILY: Symbol"}Text Length Validation

[·      ]{style="FONT-FAMILY: Symbol"}Time Validation

[·      ]{style="FONT-FAMILY: Symbol"}List Validation

[·      ]{style="FONT-FAMILY: Symbol"}Number Validation

[·      ]{style="FONT-FAMILY: Symbol"}Date Validation

 

Events

Table 1: Event Table

::: {align="center"}
+------------------------+-----------------------------------------------------+-----------------------------------------------------------------------------+-------------+-----------------+
| Event                  | Description                                         | Arguments                                                                   | Type        | Reference links |
+------------------------+-----------------------------------------------------+-----------------------------------------------------------------------------+-------------+-----------------+
| CurrentCellValidating  | Will be triggered when the cell value is committed. | void CurrentCellValidating(object sender, CurrentCellValidatingEventArgs e) | Routed      | NA              |
|                        |                                                     |                                                                             |             |                 |
|                        | This can be cancelled.                              |                                                                             |             |                 |
|                        |                                                     |                                                                             |             |                 |
|                        | Error alert can be customized.                      |                                                                             |             |                 |
+========================+=====================================================+=============================================================================+=============+=================+
:::

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Defining Condition for Validating Cells](ms-xhelp:///?Id=b4832843-8b70-4695-b36b-47ebdfa7d55f){style="TEXT-DECORATION: none"}
:::::
