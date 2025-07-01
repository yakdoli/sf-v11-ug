::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b28ae4de-f607-4d37-a668-9355096898c5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3f84b720-8b83-422e-948f-88d7c396dd1c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data Binding](ms-xhelp:///?Id=4e3356df-66f2-4ab8-801e-d5ab48a4e93a){.d2h_breadcrumbsNormal}
:::

### ADO.NET Entity Model Data Source {#ado.net-entity-model-data-source style="tab-stops: 0pt"}

 

The Entity Framework supports an Entity Data Model (EDM) for defining data at both the storage and conceptual level and also mapping between the two. It also enables you to program directly against the data types defined at the conceptual level as common language runtime (CLR) objects. The Entity Framework provides tools to generate an EDM and the related CLR objects based on an existing database. This reduces much of the data access code that is required to create object-based data application and services. This makes it faster to create object-oriented data applications and services from an existing database.

 

The Entity Framework enables you to avoid the tedious work of building your data access classes by hand. Entity Framework applications can run on any computer on which the .NET Framework 3.5 Service Pack 1 (SP1) is installed.

 

For details, see: [[http://msdn.microsoft.com/en-in/library/bb399567(v=VS.90).aspx]{.UGHyperlink}](http://msdn.microsoft.com/en-in/library/bb399567(v=VS.90).aspx)

[[http://msdn.microsoft.com/en-in/library/bb896338%28v=VS.90%29.aspx]{.UGHyperlink}](http://msdn.microsoft.com/en-in/library/bb896338%28v=VS.90%29.aspx)[]{.UGHyperlink}

 

Most applications are currently written on top of relational databases. At some point, these applications will have to interact with the data represented in a relational form.Database schemas are not always ideal for building applications and the conceptual models of applications differ from the logical models of databases. The Entity Data Model (EDM) is a conceptual data model that can be used to model the data of a particular domain so that applications can interact with data as entities or objects.

 

Properties

 

::: {align="center"}
  ------------ ---------------------------------------------------- ------------------ ----------------------- --------------------------------------------------
  Property     Description                                          Type of property   Value it accepts        Any other dependencies/sub-properties associated
  DataSource   Gets or sets the data source for the Grid control.   IEnumerable        Any IEnumerable data.   None
  ------------ ---------------------------------------------------- ------------------ ----------------------- --------------------------------------------------
:::

[]{style="COLOR: black"} 

Methods

 

::: {align="center"}
  ------------------------------- ------------------------------------------------ ------------------------- -------------------
  Method                          Description                                      Parameters                Return type
  Datasource (IEnumerable\<T\>)   Used to set a data source to the Grid control.   IEnumerable data source   IGridBuilder\<T\>
  ------------------------------- ------------------------------------------------ ------------------------- -------------------
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Binding Data through GridBuilder](ms-xhelp:///?Id=b3a8fdfd-edc0-4756-bd76-085c2bc57fa8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Binding Data through GridPropertiesModel](ms-xhelp:///?Id=c6abeed5-b2ce-4a3a-bf02-9465fa689166){style="TEXT-DECORATION: none"}
::::::
