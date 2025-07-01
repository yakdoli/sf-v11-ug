::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=cf357881-9a22-4448-911b-cb04327a0076){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0adb649f-2172-44d8-be90-837a2f55d6d2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Windows](ms-xhelp:///?Id=af2b5ead-c104-4cdd-b5e2-2b2aee61afe3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4c7c53bf-fd09-4600-aaf4-4f09cc0f9359){.d2h_breadcrumbsNormal}
:::

## Subtotal Hiding {#subtotal-hiding style="tab-stops: 0pt"}

The subtotal hiding feature is used to show or hide the subtotals in the PivotGrid.[ I]{style="COLOR: gray"}n the case of larger data table, this feature enables the user to have an abstract view of the data by hiding subtotals using the *ShowSubTotals* property.

 

Use Case Scenarios

When the user has more computational fields with subtotals in each group of their PivotGrid, the user might find it difficult to view all the data. In that case, the user can hide the subtotals and make it visible when required.

The following screen shots shows the PivotGrid with shown and hidden sub totals.

 

![Description: C:\\Users\\diana\\Desktop\\SubTotalsshown.PNG](ImagesExt/image112_15.png){border="0"}

Figure 13: PivotGrid with Subtotals

 

![Description: C:\\Users\\diana\\Desktop\\SuTotals Hidden.PNG](ImagesExt/image112_16.png){border="0"}

Figure 14: PivotGrid with Subtotals Hidden

 

Properties

Table 9: Property Table

::: {align="center"}
  --------------- ------------------------------- ----------- -----------------
  Property        Description                     Data Type   Reference links
  ShowSubTotals   Shows or hides the sub totals   Boolean     \-
  --------------- ------------------------------- ----------- -----------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Methods

Table 10: Method Table

::: {align="center"}
  Method               Description                                                                                                                                                                 Parameters   Return Type   Reference links
  -------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------ ------------- -----------------
  SubTotalsRendering   Handles rendering of cells(showing or hiding the cells) by calculating the cell range values in the Pivot Engine based on the ShowSubTotals property value in the control   \-           Void          \-
:::

[]{style="COLOR: #c00000"} 

Sample Link

Follow the steps given below to view a sample of this feature:

1.   Select Start \> Programs \> Syncfusion \> Essential Studio x.x.x.x -\> Dashboard.

2.   Click **Run Samples** under UI edition.

3.   Select **PivotGrid.**

4.   Navigate to **Selection** \> **Cell Selection Demo.**

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Showing or Hiding Subtotals in PivotGrid](ms-xhelp:///?Id=0adb649f-2172-44d8-be90-837a2f55d6d2){style="TEXT-DECORATION: none"}
::::::
