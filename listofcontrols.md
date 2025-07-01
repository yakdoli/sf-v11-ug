::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=983dde6f-2138-428e-ab37-6e0032c4d9de){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bf2d70d7-33dc-4c67-a55d-4fcf8d51dc2b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c52dd0c5-bab1-416e-8b27-3f2be113aa2c){.d2h_breadcrumbsNormal}
:::

## List of Controls {#list-of-controls style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential Grid provides the following controls.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Grid Control**-This class is derived from GridControlBase. It is the primary class that encapsulates both the state persistence (including data persistence) and the rendering of the grid. Unless you are using one of the special grids (Grid Data Bound Grid, Grid Grouping control, or Grid List control), GridControl is the class you will use. This is a cell-oriented grid which will easily allow you to set both row and column properties, as well as set cell specific properties for the grid to hold the data. It can also be used in a virtual mode where the data is provided on demand or the Grid control can physically hold the data for you.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Grid Data Bound Grid**-This class is also derived from GridControlBase. This control is more column-oriented than the Grid control. It is primarily used as a grid bound to a data source that supports either IList or IListSource. Classes such as ArrayList, DataTable, and DataView are included in this collection of possible data sources. Grid Data Bound Grid has a collection property called GridBoundColumns, that maintains the column properties which is similar to the System.Windows.Forms.DataGridColumnStyle class. It is this property that allows Grid Data Bound Grid to be described as a column-oriented grid.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Grid Grouping Control**-This grouping control which is derived from the control class implements several interfaces that add Grouping support to this class. If you need grouping support, multi-column sort support, or true nested-table hierarchical support in a grid, then this control is the one to be used. You can easily add expression columns, filter columns, and summary rows to this grid, as well as bind it to any IList data source. It can be fully designed by using Visual Studio.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Grid List Control**-This class is derived from System.Windows.Forms.ListControl, but can display multiple columns in its list. It has a GridControl object as a property of the class. This Grid member gives you grid-like access to a ListControl, and also provides both the data and formatting for the list control. This control is easy to use, provided your data source has the exact data you want displayed. But if you need to customize this control by hiding columns in your data source or changing column names, then generally using either the Grid Data Bound Grid or the Grid control in the list box mode is a simpler solution. This control exists so it can serve as the drop list object for the combo box that serves as a cell control.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Grid Record Navigation Control**-This class provides MS Access-like navigation support. It is normally used in conjunction with the Grid Data Bound Grid to display record numbers, and to allow record scrolling within the grid through a record information window which is displayed at the lower-left corner of the grid. You can also use it in conjunction with a Grid control.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Grid Aware Text Box**-This class is derived from System.Windows.Forms.TextBox. It allows you to bind it to the CurrentCell of either a Grid control or a Grid Data Bound Grid. The standard use for such a text box is to provide a special edit bar for editing grid cells or to serve as a formula bar in a formula grid.

 

[]{#p35} 

 

[]{#related-topics}
::::
