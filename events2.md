::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=702aba3f-783d-4f9e-b654-b0ecccd81b0d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=441600f8-d90f-4620-8409-37c4381209d8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=9e489974-524d-457c-9881-e458b1321685){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Localization](ms-xhelp:///?Id=a0edf727-e68d-42b1-b365-6f774bb95a8d){.d2h_breadcrumbsNormal}
:::

### Events {#events style="tab-stops: 0pt"}

This section lists the server-side and client-side events of the Grid Grouping control.[]{#p115}

Server-side Events[]{style="COLOR: #4e84c4; FONT-SIZE: 13pt"}

The server-side events are listed in the below table with descriptions:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------------ ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Event Name                     Description
  QueryCellStyleInfo             It occurs for each cell before it gets rendered. Using this event you can customize the contents of the cell.
  QueryCoveredRange              Occurs to determine if the cell belongs to a covered range and returns the covered range of the cell.
  CurrentRecordContextChanged    Occurs before and after the status of the current record is changed. Using the CurrentRecordContextChangeEventArgs.Action you can get information on which record, state was changed.
  DataSourceControlRowAdding     Occurs before adding a new record in the bound DataSourceControl.
  DataSourceControlRowUpdating   Occurs before updating a record in the bound DataSourceControl.
  DataSourceControlRowDeleting   Occurs before deleting a record in the bound DataSourceControl.
  RowDataBound                   Occurs when a data row is bound to data in a GridGroupingControl.
  GroupedColumnsChanged          Occurs when a column is added or removed from the GroupedColumns collection.
  SortedColumnsChanged           Occurs when a column is added or removed from the SortedColumns collection.
  SearchDataSourceEvent          Occurs after the search button is clicked in the SearchTextBox.
  RecordDoubleClicked            Occurs after the record is double clicked.
  ------------------------------ ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

Client-side Events

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The client-side events are listed in the below table with description.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------+
| Event Name                        | Description                                                                                    |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnRecordClick           | Specifies the client side function to call, when record is clicked.                            |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnSelectionChanged      | Specifies the client side function to call, when the selection of records are getting changed. |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideColumnResizing          | Specifies the client side function to call, when the columns are getting resized.              |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnBeginDragRows         | Specifies the client side function to call, when rows are dragged.                             |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnCellValidate          | Specifies the client side function to call, when cell is clicked in the ExcelEditMode.         |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnRowMouseOut           | Specifies the client side function to call, when record is hovered out.                        |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnRowMouseOver          | Specifies the client side function to call, when record is hovered.                            |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnRowsDropping          | Specifies the client side function to call, when rows are dropped.                             |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| ClientSideOnRowDoubleClick        | Specifies the client side function to call, when record is double clicked                      |
|                                   |                                                                                                |
|                                   |                                                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------+
:::

 

 

[]{#related-topics}
::::::
