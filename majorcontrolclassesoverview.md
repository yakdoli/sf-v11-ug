::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=837b4674-7605-4933-b9a5-444970074ef6){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e28b6163-7982-4120-8060-82299a4b3acb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Controls](ms-xhelp:///?Id=bf2d70d7-33dc-4c67-a55d-4fcf8d51dc2b){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Grouping Control](ms-xhelp:///?Id=5fcc9f60-cb19-43ad-bf98-72850f7d4f48){.d2h_breadcrumbsNormal}
:::

### Major Control Classes Overview {#major-control-classes-overview style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

GridGroupingControl Class

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The GridGroupingControl class is derived from the **Control** class and implements several interfaces that add Grouping support to this class. Provides support for displaying ADO.NET data and other data sources in a grid. Data will be loaded from the given datasource and changes will be written back to the datasource.

 

It is the proper choice if you need grouping support, multi-column sort support or true nested-table hierarchical support in a grid. It can be bound to any IList datasource. You can easily add expression columns, filter columns and summary rows to this grid. It is fully designable using Visual Studio and is customizable from code.

 

The **GridTableControl** is the main element in the Grid Grouping control. The Grid Table control displays the rows from the **Syncfusion.Grouping.Table.DisplayElements** collection of the Grid Grouping control.Table using schema information stored in the TableDescriptor.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"} 

The **TableDescriptor** gives access to the table schema information of the root table in the datasource. The TableDescriptor object is instantiated by the **GridEngine** class and initialized with default schema information from the list assigned to the DataSource.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"} 

There is only one GridEngine object for a Grid Grouping control. The GridTableDescriptor and GridTable objects on the other side can be more than one when hierarchies are displayed. For each hierarchy level, a GridTableDescriptor and GridTable are initialized. For example, if you have an ADO.NET DataSet with three tables: \"Products\", \"Orders\", and \"OrderDetails\", there will be three GridTableDescriptors and GridTables.

[  ]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"}

**Relations** between tables are defined with a GridTableDescriptor.Relations collection of a TableDescriptor. Each TableDescriptor can have one or multiple **RelationDescriptor** objects. A RelationDescriptor defines the foreign key columns in the parent table, a child with information about the related child table and the primary key columns in the child table.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"} 

The **GridTable** object is instantiated by the **GridEngine** class. The Table object manages the records from the engine\'s DataSource and provides access to records and grouped elements through several collection classes.

 

The most important collection used by the Grid Table control is the **DisplayElements** collection. This collection provides the Grid Table control with information on which element to display at a row. It returns elements such as CaptionSection, RecordRow, SummaryRow, and others. Based on the elements returned by this collection, the Grid Table control will display a record, a summary or a group caption bar. There are several collections returned such as Records which contains all records in the table. FilterRecords contains all visible records.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"} 

Another related collection is the **NestedDisplayElements** collection. Similar to DisplayElements, this collection also returns all records, groups and sections that are expanded and meet filter criteria. The only difference between these two collections is that the NestedDisplayElements collection steps into nested tables too where the DisplayElements collection will not.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The Grouping Engine

 

**Engine** is the main object of the grid grouping control. It contains the **TableDescriptor** with schema information such as fields, relations and the **Table** with runtime representation of the data source with groups, records, data and display elements. The engine lets you set the main datasource for the whole engine. The TableDescriptor will pick up the ItemProperties (schema information) from the datasource and the table will be initialized at runtime with records from the list.

 

The **GridEngineBase** class adds design-time support for the engine class. It can be dropped as a component into the component tray of the designer. It can be initialized with a BindingContext so that the CurrencyManager can be kept synchronized.

 

The **GridEngine** class adds the plumbing for displaying the data in a Grid Grouping control. You can specify the datasource using the DataSource and DataMember properties through the designer. It is instantiated with the virtual GridGroupingControl.CreateEngine method. If you want to customize the engine object, you should subclass this class and should override the CreateEngine method.

 

The GridEngine object is the main grouping engine object. It is derived from the Syncfusion.Grouping.Engine base class and adds Windows Forms specific functionality such as support for a Forms BindingContext and CurrencyManager. GridEngine also has special overrides of the virtual **Engine.CreateTableDescriptor** and **Engine.CreateTable** methods so that the grid-specific derived GridTable class and GridTableDescriptor class are instantiated.

 

[]{#p396} 

 

[]{#related-topics}
::::
