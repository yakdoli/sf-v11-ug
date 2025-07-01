::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f52590e0-d7fb-4cf0-8417-7a9640bc5d3d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=af3644f2-ceb1-4f8e-aeba-172b41e685cf){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=094c35c7-db8e-4341-9619-16644b2a4e34){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid WPF Controls](ms-xhelp:///?Id=1249c159-5431-465a-b1af-1cf1e5e90ac8){.d2h_breadcrumbsNormal}
:::

## GridData Control {#griddata-control style="tab-stops: 0pt"}

The GridData control is specifically designed for the scenarios, where you need to bound the grid to an external data source and customize the data view by performing the operations such as grouping, sorting, summarizing, filtering, conditional formats and unbound fields. It attains the fundamental features by deriving from the GridControlBaseclass and hence adapts most of the features of Grid control, which are discussed in the previous sections. It can display nested grids with hierarchical data and can also display multiple unrelated tables in one grid.

 

Major Control Classes

 

[·      ]{style="FONT-FAMILY: Symbol"}GridDataControl (GDC) is the main control class of this control. It is templated with GridDataControlBaseImpl class thatis based on GridControlBase class. GDC exposes numerous properties and methods that are available for the end-user to setup the grid in the desired manner.

[·      ]{style="FONT-FAMILY: Symbol"}The GridDataTableModelserves as the model class for GDC. It stores all the data information of the grid and provides methods to completely initialize the grid.  It also provides methods to attach the grid later to the GDC, for rendering.

[·      ]{style="FONT-FAMILY: Symbol"}The GridDataTableProperties defines property values for the Grid Table that lets you customize the appearance and behavior of the GDC.

[·      ]{style="FONT-FAMILY: Symbol"}As a data bound grid, GDC displays tabular data where each row corresponds to a data record and every column stands for data field of the data source. You wrap all the columns in a group together and manipulate them. The GridDataVisibleColumn class is used for this purpose. It groups the columns that are visible in the screen and holds information about each column.

[·      ]{style="FONT-FAMILY: Symbol"}The GridDataStyleInfo class, which is derived from GridStyleInfo, provides user-friendly access to all the cell level properties that control the appearance of the cell. It holds all the information  of the cell.

[·      ]{style="FONT-FAMILY: Symbol"}GridDataTable provides the virtual representation of the entity set and manages all the underlying records  in the data source.

[·      ]{style="FONT-FAMILY: Symbol"}GridDataGroupDropAreaGridImpl is the class that defines the group drop area for a GDC. It displays a panel on the top of the GDC, where  the user can drag-and-drop any column header in order to group the grid against that column. GridDataGroupDropAreaModel is the model class for this purpose.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note[: ]{style="COLOR: #15428b"}There are several other classes that assist the user in creating groups, summaries, filters, sorted columns, etc.
:::

 

The following sections will elaborate on the properties of the GridData control:

 

[·      ]{style="FONT-FAMILY: Symbol"}Data Binding-Elaborates on the data binding concept in GDC

[·      ]{style="FONT-FAMILY: Symbol"}Data Presentation-Discusses different data presentation techniques

[·      ]{style="FONT-FAMILY: Symbol"}Events- Events that are handled in GDC are discusses here

[·      ]{style="FONT-FAMILY: Symbol"}Look and Feel-Different appearance settings are elaborated here

[·      ]{style="FONT-FAMILY: Symbol"}Exporting GDC to Excel-Discusses the steps to export a GDC into the Excel

[·      ]{style="FONT-FAMILY: Symbol"}Performance-High performance of the Grid with large amount of data is discussed in this section

[·      ]{style="FONT-FAMILY: Symbol"}Real Time Application-Illustrates how to employ the grid in portfolio applications

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Data Model](ms-xhelp:///?Id=af3644f2-ceb1-4f8e-aeba-172b41e685cf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Binding](ms-xhelp:///?Id=3aa3e71e-b03c-49ea-b035-808f819b3262){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Presentation](ms-xhelp:///?Id=8c33a32c-f616-4733-b345-77fcff34986e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting and persistence](ms-xhelp:///?Id=ae9b06df-29c1-4a96-b6c2-668aab38bd97){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Events](ms-xhelp:///?Id=765ad820-3935-4b9a-af10-cf9527f6257d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Performance](ms-xhelp:///?Id=8fba608f-39b5-4dfd-b613-690a9f5af2a4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Features that work in PLINQ](ms-xhelp:///?Id=1251870f-d60e-4632-b841-a42f0f34359b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Real Time Application](ms-xhelp:///?Id=f2dedfee-6601-411b-92be-8c2df4cb0ca4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}VS2010 Designer support](ms-xhelp:///?Id=c5d5e011-9899-47af-846f-bb53919cbd88){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Freezable Support in GridDataControl](ms-xhelp:///?Id=3318f9e5-bd2b-46e2-8299-fc29d83afc9b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Grid Localization Support](ms-xhelp:///?Id=b49c9acc-5b36-4259-a607-55ab335aced8){style="TEXT-DECORATION: none"}
:::::
