::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=cae2e093-41c5-4375-a1a0-3822fc84dd51){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=46c5efff-dc11-455b-853f-1bca1cca9834){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Exporting](ms-xhelp:///?Id=cae2e093-41c5-4375-a1a0-3822fc84dd51){.d2h_breadcrumbsNormal}
:::

### Excel Export {#excel-export style="tab-stops: 0pt"}

Export to Excel is one of the most common functionalities that is required in .NET. The Essential Grid Control has in-built support for Excel Export. You can download data from the Grid control to an Excel spreadsheet for offline verification and/or computation. This can be achieved by using the GridExcelExportActionResult\<T\> extension. This extension applies the Grid control\'s styles and formats to Excel. The GridExcelExportActionResult\<T\> is derived from GridActionResultBase\<T\>. The XlsIO libraries are used to support the conversion of the Grid contents to Excel.

All the content from a Grid can be converted to an Excel Spreadsheet. It also provides the option to specify the version of the Excel file by using the ExcelVersion enum. The versions that can be specified are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}ExcelVersion.Excel97to2003

[·      ]{style="FONT-FAMILY: Symbol"}ExcelVersion.Excel2007

[·      ]{style="FONT-FAMILY: Symbol"}ExcelVersion.Excel2010

 

Properties

 

::: {align="center"}
+--------------+----------------------------------------------------+------------------+---------------------------------------------------+-------------------------------------------------------------------------------------------------+--------------------------------------------------+
| Property     | Description                                        | Type of property | Value it accepts                                  | Property syntax                                                                                 | Any other dependencies/sub-properties associated |
+--------------+----------------------------------------------------+------------------+---------------------------------------------------+-------------------------------------------------------------------------------------------------+--------------------------------------------------+
| FileName     | Gets or sets the Excel file name.                  | String           | Any string value.                                 |             var data = new NorthwindDataContext().Orders.Take(200).ToList();                    |                                                  |
|              |                                                    |                  |                                                   |                                                                                                 |                                                  |
|              |                                                    |                  |                                                   |             return data.GridExportToExcel\<Order\>(\"GridExcel.xlsx\", ExcelVersion.Excel2007); |                                                  |
|              |                                                    |                  |                                                   |                                                                                                 |                                                  |
|              |                                                    |                  |                                                   |                                                                                                 |                                                  |
+--------------+----------------------------------------------------+------------------+---------------------------------------------------+-------------------------------------------------------------------------------------------------+--------------------------------------------------+
| ExcelVersion | Gets or sets the Excel version for the Excel file. | Enum             | ExcelVersion.Excel97to2003 ExcelVersion.Excel2007 |             var data = new NorthwindDataContext().Orders.Take(200).ToList();                    | NA                                               |
|              |                                                    |                  |                                                   |                                                                                                 |                                                  |
|              |                                                    |                  | ExcelVersion.Excel2010                            |             return data.GridExportToExcel\<Order\>(\"GridExcel.xlsx\", ExcelVersion.Excel2007); |                                                  |
|              |                                                    |                  |                                                   |                                                                                                 |                                                  |
|              |                                                    |                  |                                                   |                                                                                                 |                                                  |
+--------------+----------------------------------------------------+------------------+---------------------------------------------------+-------------------------------------------------------------------------------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Methods

 

::: {align="center"}
+------------------------------------------+----------------------------------+-----------------+-----------------------------------------------------------------------------------+
| Name                                     | Parameters                       | Return type     | Description                                                                       |
+------------------------------------------+----------------------------------+-----------------+-----------------------------------------------------------------------------------+
| GridExportToExcel                        | ExcelFileName, ExcelVersion      | ActionResult    | Used to export the grid content to the Excel format.                              |
|                                          |                                  |                 |                                                                                   |
|  (IEnumerable\<T\>)                      |                                  |                 |                                                                                   |
+------------------------------------------+----------------------------------+-----------------+-----------------------------------------------------------------------------------+
| Export(GridToolbarItem,mapper)           | GridToolbarItem, Mapper          | IToolBarBuilder | Used to add the GridExcel toolbar button and the Excel export action mapper.      |
|                                          |                                  |                 |                                                                                   |
|                                          |                                  |                 |                                                                                   |
+------------------------------------------+----------------------------------+-----------------+-----------------------------------------------------------------------------------+
| Export(GridToolbarItem, Caption, mapper) | GridToolBarItem, Caption, Mapper | IToolBarBuilder | Used to add the GridExcel toolbar button with the caption and  the action mapper. |
+------------------------------------------+----------------------------------+-----------------+-----------------------------------------------------------------------------------+
:::

 

The Excel exporting feature can be enabled through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}GridBuilder

[·      ]{style="FONT-FAMILY: Symbol"}GridPropertiesModel

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using GridBuilder](ms-xhelp:///?Id=391060dc-c0b3-4c69-880a-0b861128ab8c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using GridPropertiesModel](ms-xhelp:///?Id=b65771f0-e77c-4c38-a453-19b8dc59f083){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting through Custom Buttons](ms-xhelp:///?Id=39af3a72-b9a5-4d4f-a1b5-f41e7cecb42b){style="TEXT-DECORATION: none"}
::::::
