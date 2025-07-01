::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3606658c-d68b-458e-a08f-30489f8f2ddc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=65363287-fc82-49a7-8562-b30b6191f994){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapDataProvider](ms-xhelp:///?Id=3606658c-d68b-458e-a08f-30489f8f2ddc){.d2h_breadcrumbsNormal}
:::

### AdomdDataProvider {#adomddataprovider style="tab-stops: 0pt"}

The important properties and methods in AdomdDataProvider class are tabulated below:

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Table 1: Properties

::: {align="center"}
+------------------+---------------------------------------------------------------------+--------------------+------------------+----------------+
| Property Name    | Description                                                         | Type               | Value it Accepts | Reference Link |
+==================+=====================================================================+====================+==================+================+
| CatalogName      | To get the connected database name                                  | string             | \-               | \-             |
+------------------+---------------------------------------------------------------------+--------------------+------------------+----------------+
| ConnectionString | To set or get the connection string                                 | string             | \-               | \-             |
+------------------+---------------------------------------------------------------------+--------------------+------------------+----------------+
| CurrentCellSet   | To get the currently executed **CellSet**                           | CellSet            | \-               | \-             |
+------------------+---------------------------------------------------------------------+--------------------+------------------+----------------+
| GetCubes         | To get the information about the cubes in the connected data source | CubeInfoCollection | \-               | \-             |
|                  |                                                                     |                    |                  |                |
|                  |                                                                     |                    |                  |                |
+------------------+---------------------------------------------------------------------+--------------------+------------------+----------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Table 2: Methods

 

::: {align="center"}
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
| Method Name              | Description                                                                                                                                                                                                                                                                         | Parameters                                                                                                             | Return Type      | Reference Link |
+==========================+=====================================================================================================================================================================================================================================================================================+========================================================================================================================+==================+================+
| ExecuteCellSet           | Four arguments should be given to invoke this method. The arguments are MDX query as string, drill down state of result set as bool, query append info as bool and finally get the **OlapReport**. This method will generate the **CellSet** for the given query or **OlapReport**. | Mdx Query as string, drill down state as bool, Property append status as bool and Current OlapReort of OlapDataManager | CellSet          | \-             |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
| GetCubeSchema            | This method will get the cube name and intersect the cube to get all the information about the cube and return an object of type **CubeSchema**, which will contain all the information. **CubeSchema** is a class in Data namespace.                                               | Cube Name as string                                                                                                    | CubeSchema       | \-             |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
| GetChildMembers          | This method will get the member element and the expander state and return the child members of the given member as MemberCollection.                                                                                                                                                | Parent member as Member and drill down state as bool                                                                   | MemberCollection | \-             |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
| GetLevelMembers          | This method will get the level element as argument and return the member elements of that level as MemberCollection.                                                                                                                                                                | Level                                                                                                                  | MemberCollection | \-             |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
| GetParentMember          | This method is used to find the parent member of a member element. By passing a member element as an argument, this element will return its parent member.                                                                                                                          | Member                                                                                                                 | Member           | \-             |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
| ValidateConnectionString | This method will validate the specified connection string in the data manager or in the data provider and return the validated status.                                                                                                                                              | \-                                                                                                                     | bool             | \-             |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
|                          |                                                                                                                                                                                                                                                                                     |                                                                                                                        |                  |                |
+--------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------------------+------------------+----------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[]{#related-topics}
::::::
