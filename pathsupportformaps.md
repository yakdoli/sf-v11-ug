::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=57d48781-5304-4e67-89b3-e1ab31234818){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8f294004-bf54-4f05-976c-f03cf60a24d9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows Phone](ms-xhelp:///?Id=5ea1999c-4eff-4775-b84e-407dc825f555){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=fe4335c8-1cb6-47a4-a6f3-e9bc318bba8d){.d2h_breadcrumbsNormal}
:::

## Path Support for Maps {#path-support-for-maps style="tab-stops: 0pt"}

This feature enables you to provide a street view in a map. You can add paths to a map by specifying the points, and display label on those paths. While performing zoom and pan operations, paths will be automatically updated. You can customize the path style.

 

Use Case Scenarios

Path support enables you to draw paths that depict routes in a map.

 

Properties

Table 15: Properties Table

::: {align="center"}
  --------------------- --------------------------------------------------------------- ------------ --------------------------------------------------------- ------------------------------
  Property              Description                                                     Type         Data Type                                                 Reference links
  PathPoints\*          Specifies the start and end points of a particular path.        Dependency   ObservableCollection\<Point\>[]{style="COLOR: #c00000"}   NA[]{style="COLOR: #c00000"}
  PathLabel             Specifies the text for PathLabel.                               Dependency   String                                                    NA
  PathLabelFontStyle    Specifies the font style for PathLabel.                         Dependency   FontStyle                                                 NA
  PathColor             Specifies the color options for the path.                       Dependency   Brush                                                     NA
  PathStrokeThickness   Gets or sets stroke thickness of the MapPath.                   Dependency   Double                                                    NA
  PathLabelForeground   Specifies the color options of PathLabel's Foreground.          Dependency   Brush                                                     NA
  PathLabelFontFamily   Specifies the FontFamily for the PathLabel.                     Dependency   FontFamily                                                NA
  PathLabelFontSize     Specifies the font size for the Path Label.                     Dependency   Double                                                    NA
  LabelPoint            Specifies the PathLabel's Position on the Path.                 Dependency   Point                                                     NA
  PathLabelPosition     Specifies the PathLabel position as OnPoint or OnMiddlePoint.   Dependency   PathLabelPosition                                         NA
  IsDynamicCreatePath   Specifies whether dynamic path creation is enabled.             Dependency   Bool                                                      NA
  --------------------- --------------------------------------------------------------- ------------ --------------------------------------------------------- ------------------------------
:::

***[]{style="FONT-SIZE: 9pt"}*** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note:
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
***[·    ]{style="FONT-FAMILY: Symbol; COLOR: black"}***Properties marked with \* are mandatory.[]{style="COLOR: black"}

***[·    ]{style="FONT-FAMILY: Symbol"}***LabelPoint is mandatory, when you add label to the path through Code Behind.
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Adding Path to the Map Through Code](ms-xhelp:///?Id=8f294004-bf54-4f05-976c-f03cf60a24d9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customizing the Path Style](ms-xhelp:///?Id=9eb56fff-9d61-42be-82aa-03eb3af39ae9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding Path to the Map Dynamically](ms-xhelp:///?Id=64182866-32c3-4b76-bde4-20097022b9fa){style="TEXT-DECORATION: none"}
::::::::
