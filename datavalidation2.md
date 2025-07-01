::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=78474e55-ced7-405f-b252-c5b8c9b37887){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a50a4635-245d-4cb4-aaad-2cc7645ac785){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Spreadsheet](ms-xhelp:///?Id=25812fa4-b4ea-4485-bbfb-30849a783142){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Spreadsheet Silverlight]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=7bfcfdc3-3540-43e3-b029-ceaea5fe92f5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data Management](ms-xhelp:///?Id=f018e2be-98d7-475e-a2ae-929eae0d3ba0){.d2h_breadcrumbsNormal}
:::

### Data Validation {#data-validation style="tab-stops: 0pt"}

The Data Validation enables you to dynamically validate the data entered in a cell. You can specify the validation rules in the Data Validation dialog box. Spreadsheet control supports the various validation types for each data type. This also enables you to show the error message for invalid.

 

![Description: C:\\Users\\jananit\\AppData\\Local\\Microsoft\\Windows\\Temporary Internet Files\\Content.Word\\DataValidation_SL.PNG](ImagesExt/image20_30.png){border="0"}

Figure 25: Data Validation Dialog

 

Data Validation in Spreadsheet control

 

Essential Spreadsheet control enables you to edit the existing data validation. You can also create new data validation. Spreadsheet control supports the following validation types:

[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Text Length Validation

[·      ]{style="FONT-FAMILY: Symbol"}Time Validation

[·      ]{style="FONT-FAMILY: Symbol"}List Validation

[·      ]{style="FONT-FAMILY: Symbol"}Number Validation

[·      ]{style="FONT-FAMILY: Symbol"}Date Validation

 

Events

 

Table 1: EventTable

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

[![](button.gif){border="0" align="absMiddle"}Defining Condition for Validating Cells](ms-xhelp:///?Id=9bea00c0-fa25-4ae2-86c7-9e7fe1c30222){style="TEXT-DECORATION: none"}
:::::
