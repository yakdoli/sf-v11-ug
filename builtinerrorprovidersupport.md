::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a00093fb-a076-41b4-ad20-6a584fb17ac8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3f598027-a791-4bbb-b105-cd792cf7c731){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Controls](ms-xhelp:///?Id=bf2d70d7-33dc-4c67-a55d-4fcf8d51dc2b){.d2h_breadcrumbsNormal}
:::

## Built-in Error Provider Support {#built-in-error-provider-support style="tab-stops: 0pt"}

Essential Grid for Windows Forms now provides a built-in error provider for error alerts. This feature enables you to display an error icon in a specific cell and row header when incorrect data is entered in a cell. This also enables you to specify the error conditions.

 

Use Case Scenarios

This feature is useful when you want to set that only numeric values can be entered in a cell.

 

Properties

::: {align="center"}
  ------------------------ -------------------------------------------------------------- ---------- ---------------
  **Property**             **Description**                                                **Type**   **Data Type**
  ShowerrorIcon            Specifies whether to show error icon.                          NA         Boolean
  ShowRowHeaderErrorIcon   Specifies whether to show error icon in the row header.        NA         Boolean
  ShowErrorMessageBox      Specifies whether to show error message box.                   NA         Boolean
  ValidationErrorText      Specifies the text to be displayed in the error message box.   NA         Boolean
  ------------------------ -------------------------------------------------------------- ---------- ---------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Methods

  **[Method ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Description ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Parameters ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Type ]{style="COLOR: black"}**[]{style="COLOR: black"}   **[Return Type ]{style="COLOR: black"}**[]{style="COLOR: black"}
  ------------------------------------------------------------- ------------------------------------------------------------------ ----------------------------------------------------------------- ----------------------------------------------------------- ------------------------------------------------------------------
  SetError()[]{style="COLOR: #c00000"}                                                                                             Method (string)                                                   Method                                                      String

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

A sample of this feature is available in the following location:

**GridDataBoundGrid**

***{Installed Path}\\Syncfusion\\EssentialStudio\\{Version}\\Windows\\GridDataBound.Windows\\Samples\\2.0\\Appearance\\Error Provider Demo***

 

**GridGroupingGrid**

***{Installed Path}\\Syncfusion\\EssentialStudio\\{Version}\\Windows\\Grid.Grouping.Windows\\Samples\\2.0\\Grouping Grid Layout\\Error Provider Demo***

 

**GridControl**

***{Installed Path}\\Syncfusion\\EssentialStudio\\{Version}\\Windows\\Grid.Windows\\Samples\\2.0\\Grid Layout\\Error Provider Demo***

***[]{style="COLOR: #c00000"}*** 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enabling Error Alert](ms-xhelp:///?Id=3f598027-a791-4bbb-b105-cd792cf7c731){style="TEXT-DECORATION: none"}
:::::
