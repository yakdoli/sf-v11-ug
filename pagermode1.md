::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### [Pager Mode]{#PagerMode} {#pager-mode style="tab-stops: 0pt"}

This defines the type paging we are going to do with the OlapPager control. The PagerMode contains three different options. They are:

[·      ]{style="FONT-FAMILY: Symbol"}Categorical (Column)

[·      ]{style="FONT-FAMILY: Symbol"}Series (Row)

[·      ]{style="FONT-FAMILY: Symbol"}Both

 

Categorical (Column)

This mode allows only categorical paging. That is, it displays only one pager within the control for categorical paging. The code snippet to set this is as follows:

 

  -----------------------------------------------------------------------------------------------------------------------------------------
  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pager1.PagerMode = PagerMode.Categorical;]{style="FONT-FAMILY: 'Courier New'"}
  -----------------------------------------------------------------------------------------------------------------------------------------

 

  --------------------------------------------------------------------------------------------------------------------------------------
  **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**
  [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pager1.PagerMode = PagerMode.Categorical]{style="FONT-FAMILY: 'Courier New'"}
  --------------------------------------------------------------------------------------------------------------------------------------

 

Series (Row)

This mode allows only series paging. That is, it displays only one pager within the control for series paging. The code snippet to set this is as follows:

 

  ------------------------------------------------------------------------------------------------------------------------------------
  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pager1.PagerMode = PagerMode.Series;]{style="FONT-FAMILY: 'Courier New'"}
  ------------------------------------------------------------------------------------------------------------------------------------

 

  ---------------------------------------------------------------------------------------------------------------------------------
  **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: white"}**
  [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pager1.PagerMode = PagerMode.Series]{style="FONT-FAMILY: 'Courier New'"}
  ---------------------------------------------------------------------------------------------------------------------------------

[]{#_Appearance} 

Both

This mode displays two pagers in the control. One is for categorical (column) paging and another one is for series (row) paging. The code snippet to set this is as follows:

 

  ----------------------------------------------------------------------------------------------------------------------------------
  **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pager1.PagerMode = PagerMode.Both;]{style="FONT-FAMILY: 'Courier New'"}
  ----------------------------------------------------------------------------------------------------------------------------------

 

  -------------------------------------------------------------------------------------------------------------------------------
  **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**
  [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pager1.PagerMode = PagerMode.Both]{style="FONT-FAMILY: 'Courier New'"}
  -------------------------------------------------------------------------------------------------------------------------------

 

[]{#related-topics}
:::
