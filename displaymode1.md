::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d6400d99-db53-481f-8258-8455f70aec39){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=843057a1-197d-4ebc-a70c-6a9c64dc0a60){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Features](ms-xhelp:///?Id=4ae10797-e3a8-4270-b8ba-34441d2e1a3d){.d2h_breadcrumbsNormal}
:::

## Display Mode {#display-mode style="tab-stops: 0pt"}

The display is used to specify whether you want to view the output of the report in both Chart and Grid or in any one of them.  

There are three display Modes in OLAP Client, namely:

 

Both -- This will include both Chart and Grid for displaying the output of the report.

Chart -- This will contain only Chart for displaying the output of the report.

Grid -- This will contain only Grid for displaying the output of the report.

These display modes will increase the performance when you set the display mode to either Chart or Grid instead of both. It will increase the performance of the OLAP Client.

Code snippet for Changing the Display Mode:

 

+------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                             |
|                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                              |
| [//// To display the Client with both Chart and Grid (Default)\                                                              |
| this.OlapClient.DisplayMode = Syncfusion.Silverlight.Client.Olap.DisplayModes.Both;\                                         |
|  \                                                                                                                           |
| //// To display the Client only with Chart]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                              |
| [this.OlapClient.DisplayMode = Syncfusion.Silverlight.Client.Olap.DisplayModes.ChartOnly;\                                   |
|  \                                                                                                                           |
| //// To display the Client only with Grid\                                                                                   |
| this.OlapClient.DisplayMode = Syncfusion.Silverlight.Client.Olap.DisplayModes.GridOnly;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                            |
|                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                             |
| [\'// To display the Client with both Chart and Grid (Default)]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                             |
| [Me.OlapClient.DisplayMode Syncfusion.Silverlight.Client.Olap.DisplayModes.Both;]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                             |
| [\'// To display the Client only with Chart]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                             |
| [Me.OlapClient.DisplayMode = Syncfsion.Silverlight.Client.Olap.DisplayModes.ChartOnly;\                                     |
| \                                                                                                                           |
| ]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                             |
| [\'// To display the Client only with Grid]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                             |
| [Me.OlapClient.DisplayMode = Syncfusion.Silverlight.Client.Olap.DisplayModes.GridOnly;]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------+

 

Use Case Scenarios

When users want to view reports only in Chart or Grid, they can set the corresponding display mode to exclude another control.

[]{#related-topics}
::::
