::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=77c51f80-0202-4c54-bd4b-214de85ddfba){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f689ed94-0b37-44fa-9462-c7b28314f183){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=01073408-6fb5-4943-a653-da9fd3358a53){.d2h_breadcrumbsNormal}
:::

## AutoExecute {#autoexecute style="tab-stops: 0pt"}

By default, on dragging and dropping a node from cube dimension browser into an axis element builder, the grid and chart controls would be updated immediately. Instead of updating the grid and chart controls immediately, we can update it on-demand just by setting the "AutoExecute" property to "False".

On setting the "AutoExecute" property to "False", an icon appears in the OLAP Client Toolbar as well as on dragging and dropping a node from cube dimension browser; the grid and chart controls won't be updated. Whenever the user wants to update the grid and chart controls, he/she can just click the "AutoExecute" button available in the toolbar (Binding the data into grid and chart control on-demand).

 

The below code snippet would enable the AutoExecute option:

+-----------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                       |
| [this.OlapClient1.AutoExecute = false;\                               |
| this.OlapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}     |
+-----------------------------------------------------------------------+

 

+--------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                         |
|                                                                          |
| [Me.OlapClient1.AutoExecute = False]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                          |
| [Me.OlapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}          |
+--------------------------------------------------------------------------+

 

![](ImagesExt/image45_63.jpg){border="0"}

 

Figure 47: AutoExecute button in OLAP Client Toolbar

 

Table 20: AutoExecute Property

 

::: {align="center"}
  ------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------- ----------- ----------------
  Property      Description                                                                                                                                                          Type          Data type   Reference link
  AutoExecute   Instead of updating the grid and chart controls immediately after drag and drop, we can update it on-demand just by setting the "AutoExecute" property to "False".   Server side   boolean     \-
  ------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------- ------------- ----------- ----------------
:::

 

Sample Link

A sample demo is available at the following link:

**..\\Syncfusion\\EssentialStudio\\\<Version Number\>\\BI\\Web\\OlapClient.Web\\Samples\\3.5\\OlapClient\\ AutoExecuteDemo**

 

[]{#related-topics}
:::::
