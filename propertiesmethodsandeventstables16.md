::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties, Methods and Events tables {#properties-methods-and-events-tables style="tab-stops: 0pt"}

 

IDataSort Members:

IDataSort members represent the sort of the range.

 

Properties

 

+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| Name                                                                                | Description                                             |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| ![Description: Public method](ImagesExt/image47_140.gif){border="0"}IsCaseSensitive | Indicates whether or not to perform case sensitive sort |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| HasHeader![Description: Public method](ImagesExt/image47_140.gif){border="0"}       | Indicates whether the range has header                  |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| Orientation                                                                         | Represents the sort orientation                         |
|                                                                                     |                                                         |
|                                                                                     |                                                         |
|                                                                                     |                                                         |
|                                                                                     |                                                         |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| SortFields                                                                          | Represents the SortFields Collection                    |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| SortRange                                                                           | Represents the sort range                               |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+
| Algorithm                                                                           | Represents the algorithm to sort                        |
+-------------------------------------------------------------------------------------+---------------------------------------------------------+

 

Methods

 

  ---------------------------------------------------------------------------- --------------------------------------------
  Name                                                                         Description
  ![Description: Public method](ImagesExt/image47_140.gif){border="0"}Sort()   Sorts the range, based on the sort fields.
  ---------------------------------------------------------------------------- --------------------------------------------

 

ISortField Members:

ISortField members contain all the sort information.

 

Properties

 

+-------------------------------------------------------------------------+------------------------------------------------------------------------------+
| Name                                                                    | Description                                                                  |
+-------------------------------------------------------------------------+------------------------------------------------------------------------------+
| ![Description: Public method](ImagesExt/image47_140.gif){border="0"}Key | Represents the column to be sorted                                           |
+-------------------------------------------------------------------------+------------------------------------------------------------------------------+
| SortOn                                                                  | Represents on which the range should be sorted.                              |
|                                                                         |                                                                              |
|                                                                         |                                                                              |
|                                                                         |                                                                              |
|                                                                         |                                                                              |
+-------------------------------------------------------------------------+------------------------------------------------------------------------------+
| Order                                                                   | Represents the sort order                                                    |
|                                                                         |                                                                              |
|                                                                         |                                                                              |
|                                                                         |                                                                              |
|                                                                         |                                                                              |
+-------------------------------------------------------------------------+------------------------------------------------------------------------------+
| Color                                                                   | Represents the color to sort. Throws exception when SortOn type is "Values". |
+-------------------------------------------------------------------------+------------------------------------------------------------------------------+

 

ISortFields Members:        

ISortFields members represent the collection Sort Field.

 

**Properties**

  --------------------------------------------------------------------------- ----------------------------
  Name                                                                        Description
  ![Description: Public method](ImagesExt/image47_140.gif){border="0"}Count   Represents the field count
  --------------------------------------------------------------------------- ----------------------------

 

Methods

 

  ------------------------------------------------------------------------- -----------------------------------------
  Name                                                                      Description
  ![Description: Public method](ImagesExt/image47_140.gif){border="0"}Add   Adds the SortField in the collection
  Remove                                                                    Removes the SortField in the collection
  ------------------------------------------------------------------------- -----------------------------------------

 

[]{#related-topics}
:::
