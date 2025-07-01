::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=9dfef0ae-c8dd-4098-a3b6-8fac403c6941){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0bcfb5bb-c849-4421-8ca9-29ee06f099fb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c52dd0c5-bab1-416e-8b27-3f2be113aa2c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Tutorials](ms-xhelp:///?Id=ec37d422-c102-40ce-8e79-23d6c564cae7){.d2h_breadcrumbsNormal}
:::

### Lesson 4: Virtual Grid Tutorial {#lesson-4-virtual-grid-tutorial style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A virtual grid is one where the grid does not hold any data. All the data that is displayed by the grid is provided on demand from some external data source to the grid when it needs it. Virtual grids are ideal for displaying large amounts of data which are already stored in some manner. This data is not moved from its original location or stored in **GridStyleInfo** objects. Instead, GridInfoStyle objects are created on the fly, to temporarily hold only the necessary data and are discarded when they are no longer needed. There is no data stored in the grid.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Implementing a virtual grid is straight forward. Depending upon the functionality that you need, you can implement a virtual grid with as few as three events. To implement a virtual grid, you must tell the grid how many rows and columns your data source has, and provide the grid the data from your data source. You must do these things in real time, only when the grid requests these data elements. When the grid needs to know the number of rows in the grid, it will fire the **QueryRowCount** event. When it needs to know the number of columns in the grid, it will fire the **QueryColCount** event. When it needs to know a GridStyleInfo object for a particular cell, it will fire the **QueryCellInfo** event. By handling these events and setting appropriate members of the **EventArgs**, you are providing the information that the grid needs at the time when it needs it.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In this section, you will learn how to set up an external data source, and then display it by using a virtual grid. The first iteration will allow the display of the external data source; a second iteration will add code that will allow you to edit the displayed data in the virtual grid, pushing the changes back to your data source.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In this lesson, you will learn about the following topics.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

[]{#p20} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating the Project and Data Source](ms-xhelp:///?Id=16d6f1cb-481e-43ae-a83d-dfdd369270a1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding Virtual Grid](ms-xhelp:///?Id=d342912c-f131-489e-a6d6-1f190717ee5a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Initializing the Virtual Grid](ms-xhelp:///?Id=c2394825-6ccf-4561-9c48-ed0d8ba3b530){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Style Properties](ms-xhelp:///?Id=5c5a4e23-b128-413f-9e48-af5b0ac6142b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Handling Events to Retrieve Data for Virtual Grid](ms-xhelp:///?Id=290a216b-19a0-49af-a1e2-383ef8a71968){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Saving Edited Values](ms-xhelp:///?Id=e0bd1ff9-06da-4e6b-90d6-e472e26e5188){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Setting Properties in a Virtual Grid](ms-xhelp:///?Id=2690cbd1-4d4d-4ea1-928d-49c02bc67d02){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Type Conversions](ms-xhelp:///?Id=6db33ebb-36f7-4803-b2b7-a7746b4fcee0){style="TEXT-DECORATION: none"}
::::
