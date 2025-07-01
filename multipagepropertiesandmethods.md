::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### MultiPage Properties and Methods {#multipage-properties-and-methods style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The MultiPage acts as a container for **PageView** objects. The page view can contain any ASP.NET controls.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

MultiPage Server Side Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------ ------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property                 Description
  SelectedIndex            Specifies the page index to be selected on pageload.
  Controls                 Specifies the collection of controls contained within MultiPage control. Instances of page view can be added dynamically to MultiPage using this property.
  RenderSelectedPageOnly   When this property is set to true, SelectedIndex page alone will be visible. By default it is set to false.
  ------------------------ ------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

MultiPage Server Side Methods

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------
  Method             Description
  GoFirst()          Displays the first pageview object in MultiPage control collection.
  GoNext()           Displays the next pageview object in MultiPage control collection.
  GoNext(bool)       Gets/sets a boolean value. When the value is true, if it\'s in the endmost page, it moves to the first page.
  GoPrevious()       Displays the previous pageview object in MultiPage Control collection.
  GoPrevious(bool)   This overloaded method takes a boolean value. When the value is set to true, it moves to the last page if there are no more pages at the beginning.
  GoLast()           Displays the last pageview object in MultiPage control collection.
  ------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

MultiPage Client Side Methods

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------ ------------------------------------------------------------------------
  Method             Description
  GetIndex()         Returns the index of the current page.
  GoFirst()          Displays the first page.
  GoLast()           Displays the last page.
  GoNext()           Displays the next page.
  GoNext(true)       If it\'s in the endmost page, it moves to the first page.
  GoPrevious()       Displays the previous page.
  GoPrevious(true)   It moves to the last page if there are no more pages at the beginning.
  PageCount()        Specifies the number of pages present in MultiPage.
  SetIndex(int)      Specifies to display the page with index provided.
  ------------------ ------------------------------------------------------------------------
:::

[]{#p427} 

[]{#related-topics}
::::::
