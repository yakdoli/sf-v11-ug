::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f8a62d29-ea65-45d0-9c59-edaf2d45e684){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0d2d59bc-d002-4c1a-8e62-2960e858f119){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8126789d-b192-4c3c-9e36-f0119f12b8b9){.d2h_breadcrumbsNormal}
:::

## Grid Data Control {#grid-data-control style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Grid Data control is specifically designed for the scenarios, where you need to bound the grid to an external data source and customize the data view by performing the operations such as grouping, sorting, summarizing, filtering, conditional formats and unbound fields. It attains the fundamental features by deriving from the **GridControlBaseclass** and hence adapts most of the features of Grid control, which are discussed in the previous sections. It can display nested grids with hierarchical data and can also display multiple unrelated tables in one grid.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Major Control Classes

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[·      ]{style="FONT-FAMILY: Symbol"}**GridDataControl** (GDC) is the main control class of this control. It is templated with GridDataControlBaseImpl class thatis based on GridControlBase class. GDC exposes numerous properties and methods that are available for the end-user to setup the grid in the desired manner.

 

[·      ]{style="FONT-FAMILY: Symbol"}The **GridDataTableModelserves** as the model class for GDC. It stores all the data information of the grid and provides methods to completely initialize the grid.  It also provides methods to attach the grid later to the GDC, for rendering.

 

[·      ]{style="FONT-FAMILY: Symbol"}The **GridDataTableProperties** defines property values for the Grid Table that lets you customize the appearance and behavior of the GDC.

 

[·      ]{style="FONT-FAMILY: Symbol"}As a data bound grid, GDC displays tabular data where each row corresponds to a data record and every column stands for data field of the data source. You wrap all the columns in a group together and manipulate them. The **GridDataVisibleColumn** class is used for this purpose. It groups the columns that are visible in the screen and holds information about each column.

 

[·      ]{style="FONT-FAMILY: Symbol"}The **GridDataStyleInfo** class, which is derived from GridStyleInfo, provides user-friendly access to all the cell level properties that control the appearance of the cell. It holds all the information  of the cell.

 

[·      ]{style="FONT-FAMILY: Symbol"}**GridDataTable** provides the virtual representation of the entity set and manages all the underlying records  in the data source.

 

[·      ]{style="FONT-FAMILY: Symbol"}**GridDataGroupDropAreaGridImpl** is the class that defines the group drop area for a GDC. It displays a panel on the top of the GDC, where the user can drag-and-drop any column header in order to group the grid against that column. **GridDataGroupDropAreaModel** is the model class for this purpose.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image61_4.jpg){border="0"}Note: There are several other classes that assist the user in creating groups, summaries, filters, sorted columns, etc.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following sections will elaborate on the properties of the Grid Data control:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Data Model-This discusses the ICollectionViewAdv interface.

[·      ]{style="FONT-FAMILY: Symbol"}Data Binding-Elaborates on the data binding concept in GDC.

[·      ]{style="FONT-FAMILY: Symbol"}Data Presentation-Discusses different data presentation techniques.

[·      ]{style="FONT-FAMILY: Symbol"}Look and Feel-Different appearance settings are elaborated here.

[]{#p223} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Data Model](ms-xhelp:///?Id=0d2d59bc-d002-4c1a-8e62-2960e858f119){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Binding](ms-xhelp:///?Id=6754a2f6-5a6d-4168-9a5c-20bb09ecc789){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Presentation](ms-xhelp:///?Id=ecfa9815-f049-4e03-b329-88068c98ee19){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting and persistence](ms-xhelp:///?Id=0f198c02-5db3-4d6f-960c-d79789a1033d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Look and Feel](ms-xhelp:///?Id=801997c0-f723-46ce-aaef-fdd4dacc38c8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Skins](ms-xhelp:///?Id=eaa1e3b8-8876-4668-846a-32f9ac00aebc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Backward Compatibility](ms-xhelp:///?Id=f4648dad-c426-4a49-8193-d8d3dc4f6120){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Blend Support](ms-xhelp:///?Id=c0e08d82-cc39-4048-962f-15ffff30117d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}VS2010 Designer support](ms-xhelp:///?Id=f40f9c5a-5436-4cfc-93c9-b54f7518b34a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Localization Support](ms-xhelp:///?Id=a7a3286c-273f-45a8-afd4-f1c7e33318da){style="TEXT-DECORATION: none"}
:::::
