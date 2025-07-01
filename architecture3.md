::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c9e0fb88-16ff-414a-be28-644aa190a1c5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=625a8128-e556-4a29-9ea6-d472120ad9e1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Spreadsheet]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=330f795f-499d-4559-8fe6-81b08305ceec){.d2h_breadcrumbsNormal}
:::

## Architecture {#architecture style="tab-stops: 0pt"}

Architecture

The Spreadsheet control supports **ControlTemplate** to define its content. By default, its content includes a *TabControlExt* object that contains number of *TabItemExt* based on sheet count. The *TabItemExt* contains a ScrollViewer object that contains a *SpreadsheetGrid* object.

 

The following sketch illustrates the Spreadsheet control architecture.

 

![Description: C:\\Users\\ponrajaa\\Desktop\\spreadsheet_architecture_2.png](ImagesExt/image27_12.jpg){border="0"}

Figure 11: Spreadsheet Architecture[]{style="FONT-STYLE: normal"}

*[]{style="FONT-SIZE: 9pt"}* 

Accessing the Underlying Grid control

The Spreadsheet control is a control derived class that has its own properties. You can use Grid control derived property namely *ActiveSpreadsheetGrid to* get its grid-like behavior. To access the underlying Grid control associated with the Spreadsheet control, you can use the *SpreadsheetControl.GridProperties.ActiveSpreadsheetGrid* property.

 

[]{#related-topics}
::::
