::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=78a323ce-db3b-4966-be06-75b25e15138c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=21a1cf5e-e36e-4914-9aff-74ab204872dd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=441600f8-d90f-4620-8409-37c4381209d8){.d2h_breadcrumbsNormal}
:::

## How to save exported excel file in server {#how-to-save-exported-excel-file-in-server style="tab-stops: 0pt"}

 

You can save the exported excel file in server by setting *SaveIn* type while creating object for *GridExcelExport* class. By default *SaveIn* type is set to client. The constructor for *GridExcelExport* class contains 3 arguments:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**GridGroupingControl** - GridGroupingControl object

[·      ]{style="FONT-FAMILY: Symbol"}**String filename** - Name of the file to be saved

[·      ]{style="FONT-FAMILY: Symbol"}**GridExcelExport.SaveIn** - Enum value to specify where the file has to be saved

[o  ]{style="FONT-FAMILY: 'Courier New'"}**Client**  - Saving in client

[o  ]{style="FONT-FAMILY: 'Courier New'"}**Server** -  Saving in server

**[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 12pt"}** 

Example

Saving file in server

The following code illustrates how to save the exported excel file in server.

**** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                          |
| [String]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ file = Server.MapPath([\"\~/Sample.xls\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                          |
| [// Save the file in server.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                    |
|                                                                                                                                                                                          |
| [GridExcelExport]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ excel = [new]{style="COLOR: blue"} [GridExcelExport]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [([this]{style="COLOR: blue"}.GridGroupingControl1,file,[GridExcelExport]{style="COLOR: #2b91af"}.[SaveIn]{style="COLOR: #2b91af"}.Server);]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                          |
| [excel.ExportNestedTable = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                          |
| [excel.Export();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
|                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

**** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ file [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = Server.MapPath(\"\~/Sample.xls\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                                               |
| [// Save the file in server.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ excel [As]{style="COLOR: blue"} GridExcelExport = [New]{style="COLOR: blue"} GridExcelExport ([Me]{style="COLOR: blue"}.GridGroupingControl1,file,GridExcelExport.SaveIn.Server)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| [excel.ExportNestedTable = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                               |
| [excel.Export()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Saving file in client

The following code illustrates how to save the exported excel file in client.

**           **

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                          |
| [String]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ file = Server.MapPath([\"\~/Sample.xls\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                          |
| [// Save the file in client.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                    |
|                                                                                                                                                                                          |
| [GridExcelExport]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ excel = [new]{style="COLOR: blue"} [GridExcelExport]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [([this]{style="COLOR: blue"}.GridGroupingControl1,file,[GridExcelExport]{style="COLOR: #2b91af"}.[SaveIn]{style="COLOR: #2b91af"}.Client);]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                          |
| [excel.ExportNestedTable = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                          |
| [excel.Export();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
|                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ file [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = Server.MapPath(\"\~/Sample.xls\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                                               |
| [// Save the file in client.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ excel [As]{style="COLOR: blue"} GridExcelExport = [New]{style="COLOR: blue"} GridExcelExport ([Me]{style="COLOR: blue"}.GridGroupingControl1,file,GridExcelExport.SaveIn.Client)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| [excel.ExportNestedTable = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                               |
| [excel.Export()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

[]{style="COLOR: black"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{#related-topics}
::::
