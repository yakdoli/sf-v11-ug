::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=cf9498a9-9703-4527-85ad-8015a3869c83){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e6da3db3-340c-469d-9e96-35d5ab6edd0c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=64869483-f57f-4838-b322-b1a3d1ce8e40){.d2h_breadcrumbsNormal}
:::

## Data Binding {#data-binding style="tab-stops: 0pt"}

The Data Binding feature enables to bind the Schedule control with external data sources like MS Access, SQL, XML, GenericList, and so on. While creating the data source, there are a few constraints on its structure. The data type of the column must match with the data type of the Schedule Appointments, Resources and Categories properties. This is the minimal set of requirements. If any of these requirements are not met, the Schedule control will throw an error when the data source is bound.

 

The Database always reflects the state of the schedule. This means that when the user operates on an appointment by adding, removing, dragging, or deleting appointments, the database is updated. Also, if the database is modified outside the schedule while it is still bound, the changes will be reflected on the Schedule control as well. A data source can be defined visually using the Visual Studio environment. In this way, you can create a strongly typed data source with appropriate columns and constraints.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: When the Schedule control is bound, make sure that there are no static appointments, if so the schedule control will throw an error. Also, ensure that the data type of the column matches with the data type of the Schedule Appointments, Resources and Categories properties.
:::

 

For binding the Schedule control with the data source, you need to set the following properties.

 

[·      ]{style="FONT-FAMILY: Symbol"}AppointmentDataSourceID

[·      ]{style="FONT-FAMILY: Symbol"}CategoryDataSourceID

[·      ]{style="FONT-FAMILY: Symbol"}ResourceDataSourceID

 

The below properties are used to map the various fields of Appointments, Categories and Resources properties of the Schedule control to particular fields from the Data Source.

 

::: {align="center"}
  ---------------------------------------------------------- ----------------------------------------------------------------------------------------------------------------------
           Property        []{style="FONT-WEIGHT: normal"}   Fields[]{style="FONT-WEIGHT: normal"}
  AppointmentBindProperties                                  AllDayField, ContentField, SubjectField, UniqueIDField, OwnerField, EndTimeField, LocationValueField, StartTimeField
  CategoryBindProperties                                     DescriptionField, ExpandedField, InfoField, NameField, ShortNameField
  ResourceBindProperties                                     CategoryField, DescriptionField, InfoField, NameField
  ---------------------------------------------------------- ----------------------------------------------------------------------------------------------------------------------
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Binding to AccessDataSource](ms-xhelp:///?Id=e6da3db3-340c-469d-9e96-35d5ab6edd0c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Binding to LinqDataSource](ms-xhelp:///?Id=fdb533cf-7cf8-484c-a013-18e9e86b3b8e){style="TEXT-DECORATION: none"}
::::::
