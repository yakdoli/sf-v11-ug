::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Paging Support for GridDataControl {#paging-support-for-griddatacontrol style="tab-stops: 0pt"}

Paging support is used to return pages of data with entries where selection of the pages can be done using the numbered buttons. There are 3 types:

[·      ]{style="FONT-FAMILY: Symbol"}**OnDemandPaging**

                   Current page item source adding by OnDemand basis.  Using this we can fetch the data from the data source for the current page.

 

[·      ]{style="FONT-FAMILY: Symbol"}**ViewLevelPaging**

                   ItemsSource for the page load on Grid load. In this type sorting, filtering and grouping is applicable for the Current view element. Excel-like filtering is not applicable here.

 

[·      ]{style="FONT-FAMILY: Symbol"}**SourceLevelPaging**

                     ItemsSource for the page load while grid load. In this type sorting, filtering and grouping is applicable for the whole collection. Excel-like filtering is not applicable here.

 

Use Case Scenario

Paging Support is a very useful feature to load large amount of data. We can load millions of records in an efficient way.

![](ImagesExt/image28_254.jpg){border="0"}

Figure 179: Paging Support for GridControl

 

Properties, Methods and Events tables

Properties

  ----------------------- -------------------------------------------------------------------------------------- ---------------------------------- ----------- -----------------
  Property                Description                                                                            Type                               Data Type   Reference links
  **IsPagingOnDemand**    Loads the page based on demand                                                         NA                                 Boolean     NA
  **EnablePaging**        When the property is set as true, it will be loaded pagewise                           NA                                 Boolean     NA
  **IsViewLevelPaging**   It differentiated paging as view level or source level                                 NA                                 Boolean     NA
  **PageCount**           It sets the number of pages that can be viewed. This is valid only for OnDemandPage.   NA                                 Integer     NA
  **PageSize**            It sets the number of items to be displayed on a page.                                 Dependency[]{style="COLOR: red"}   Integer     NA
  ----------------------- -------------------------------------------------------------------------------------- ---------------------------------- ----------- -----------------

 

Events

+----------------------------+--------------------------------------------------------------------------------+-------------+--------------------------------------+-----------------+
| Event                      | Description                                                                    | Arguments   | Type                                 | Reference links |
+----------------------------+--------------------------------------------------------------------------------+-------------+--------------------------------------+-----------------+
| **OnDemandDataSourceLoad** | The event is triggered when it moves to the next page or when the page changes | PagedRows   | GridDataOnDemandPageLoadingEventArgs | NA              |
|                            |                                                                                |             |                                      |                 |
|                            |                                                                                | MaximumRows |                                      |                 |
+============================+================================================================================+=============+======================================+=================+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Features of Paging Support](ms-xhelp:///?Id=68936c67-7376-4d1b-873b-b72c63d39e8a){style="TEXT-DECORATION: none"}
:::
