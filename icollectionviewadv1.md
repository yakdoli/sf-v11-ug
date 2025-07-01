::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ICollectionViewAdv {#icollectionviewadv style="tab-stops: 0pt"}

The ICollectionViewAdv interface is an extended ICollectionView interface that includes support for the following:

[·      ]{style="FONT-FAMILY: Symbol"}Grouping structure---Binary tree data structure to maintain the groups.

[·      ]{style="FONT-FAMILY: Symbol"}Group summaries---Collection to specify group summaries.

[·      ]{style="FONT-FAMILY: Symbol"}Caption summary---Specifies caption summary row.

[·      ]{style="FONT-FAMILY: Symbol"}Records structure---Flat data structure to maintain the list of internal records.

[·      ]{style="FONT-FAMILY: Symbol"}Table summaries---Collection to specify table summaries.

[·      ]{style="FONT-FAMILY: Symbol"}Filter definitions---Collection to specify filter descriptors.

**[]{style="COLOR: #15428b"}** 

ICollectionViewAdv interface implements the following:

![](ImagesExt/image28_212.jpg){border="0"}

Figure 136: ICollectionViewAdv Interface

 

 

ICollectionViewAdv is implemented as two parts in Syncfusion.Linq.Base library, as shown below:

 

![](ImagesExt/image28_213.jpg){border="0"}

[]{#p254} 

Figure 137: CollectionViewAdv

 

The CollectionViewAdv is an abstract class implementing ICollectionViewAdv. By sub-classing the CollectionViewAdv, the specific actions for the following can be defined:

[·      ]{style="FONT-FAMILY: Symbol"}Sorting

[·      ]{style="FONT-FAMILY: Symbol"}Filtering

[·      ]{style="FONT-FAMILY: Symbol"}Grouping

[·      ]{style="FONT-FAMILY: Symbol"}Summaries

 

QueryableCollectionView - Implements an IQueryable way to provide Sorting, Filtering, Grouping and Summaries.

DataTableCollectionView -- Uses the DataView to provide Sorting/Filtering and uses custom logics to implement grouping and calculating summaries.

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Grouping in ICollectionViewAdv](ms-xhelp:///?Id=266d75d7-8c23-4d61-8403-053c36ac76b2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Summaries in Grouping](ms-xhelp:///?Id=24a40089-fdcf-4d6a-949f-b85ef28e71e4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sorting in ICollectionViewAdv](ms-xhelp:///?Id=31f629c4-758f-4979-96c9-c14e7083ab62){style="TEXT-DECORATION: none"}
:::
