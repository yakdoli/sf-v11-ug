::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=53546a39-c596-40cd-9cce-ab3a9db0efd0){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f6a7153b-0fa0-47b7-9391-ae9a75982582){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Overview](ms-xhelp:///?Id=53546a39-c596-40cd-9cce-ab3a9db0efd0){.d2h_breadcrumbsNormal}
:::

## Introduction to Essential Grid WPF {#introduction-to-essential-grid-wpf style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The grid at its core functions as a very efficient display engine for tabular data that can be customized down to the cell level. It does not make any assumptions on the structure of the data (many grid controls implemented as straight data bound controls make such explicit assumptions). This leads to a very flexible design that can be easily adapted to a variety of tasks including the display of completely unstructured data and the display of structured data from a database.

 

The display system also hosts powerful and complete styles architecture. Settings can be specified at the cell level or at higher levels using parent styles that are referred to as base styles. Base styles can affect groups of cells. Cell level settings override any higher level settings and enable easy customization right down to that level.

 

With this version, our core focus has been on the underlying architecture for displaying cells with virtualized cell editors in a manner that enables good performance characteristics. The core display system also supports several building block features such as nested grids, virtual mode and support for a virtually unlimited number of rows and columns.

[]{style="COLOR: #15428b"} 

Real World Scenarios

Essential Grid WPF finds its application in various fields such as finance, banking, software, etc. Some of the important areas are:

Excel-like UI---Rich feature set of Essential Grid allows the users to build feature-rich applications. Below image illustrates an example of an Excel-like UI.

 

![](ImagesExt/image28_0.jpg)

Figure 1: Excel-like UI

 

[·      ]{style="FONT-FAMILY: Symbol"}Stock Portfolio---Using Essential Grid Control in high performance applications is very much beneficial as it can display large amount of real time data that tends to change periodically, without any performance hits. Below is an illustration of Stock Portfolio using essential grid.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image28_1.jpg)

Figure 2:  Stock portfolio

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}File Explorer---The GridTree control can be used for file explorer-type applications where the child items should be loaded on demand when the user opens the corresponding parent item.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image28_2.jpg)

Figure 3:  File Explorer

Key Features

The following are the key features of Essential Grid WPF:

[·      ]{style="FONT-FAMILY: Symbol"}Easy APIs to add/delete/move row and columns - You can easily add, delete and move rows and columns throughout the grid control using its well-defined APIs.

[·      ]{style="FONT-FAMILY: Symbol"}Clipboard Support - Grid provides excellent clipboard support that allows the users to copy/paste grid cells into text or any format.

[·      ]{style="FONT-FAMILY: Symbol"}Frozen Row and Column Footers - Grid allows the user to freeze grid columns to the left and also allows to freeze rows to the top of the grid.

[·      ]{style="FONT-FAMILY: Symbol"}Resize Rows and Columns - Grid provides option for resizing the rows and columns.

[·      ]{style="FONT-FAMILY: Symbol"}Hide Rows and Columns - The grid provides support to hide or unhide a range of rows and columns.

[·      ]{style="FONT-FAMILY: Symbol"}Keyboard Interface - Essential Grid provides extensive support for keyboard handling. The following are some of them-

[o  ]{style="FONT-FAMILY: 'Courier New'"}Arrow keys-move current cell

[o  ]{style="FONT-FAMILY: 'Courier New'"}PageUp/PageDown key-scroll grid by page

[o  ]{style="FONT-FAMILY: 'Courier New'"}F2-activate/deactivate cell

[o  ]{style="FONT-FAMILY: 'Courier New'"}F4+ALT-Drop-Down/Close-Up cell

[o  ]{style="FONT-FAMILY: 'Courier New'"}CTRL + Arrow keys-move to first/last, row/column

[o  ]{style="FONT-FAMILY: 'Courier New'"}SHIFT + Arrow keys-select cell

[o  ]{style="FONT-FAMILY: 'Courier New'"}DELETE key-delete cell

[o  ]{style="FONT-FAMILY: 'Courier New'"}CTRL+X, CTRL+V, CTRL+C, INSERT key and DELETE key support common clipboard operations

**[]{style="COLOR: #15428b"}** 

All keyboard operations can be customized.

[·      ]{style="FONT-FAMILY: Symbol"}Selection Modes - Essential Grid offers different kinds of selection modes such as RowOnly, ColumnOnly and CellOnly for the selection of a particular row, column and a cell respectively.

[·      ]{style="FONT-FAMILY: Symbol"}Drag-Drop Support - Essential Grid allows you to drag any column and drop it at any position in the grid. This allows repositioning of columns at the required place.

[·      ]{style="FONT-FAMILY: Symbol"}Virtual Mode - Essential Grid for WPF supports a virtual mode, which lets you dynamically provide data to the grid from an external data source through an event. This means that the grid does not store any data in its internal data structure.

[]{style="COLOR: #15428b"} 

User Guide Organization

The product comes with numerous samples as well as an extensive documentation to guide you. This User Guide provides detailed information on the features and functionalities of the Essential Grid for WPF. It is organized into the following sections:

[·      ]{style="FONT-FAMILY: Symbol"}Overview-This section gives a brief introduction to the product and its key features.

[·      ]{style="FONT-FAMILY: Symbol"}Installation and Deployment-This section elaborates on the install location of the samples, license etc.

[·      ]{style="FONT-FAMILY: Symbol"}What\'s New-This section lists the new features implemented for every release.

[·      ]{style="FONT-FAMILY: Symbol"}Getting Started-This section guides you on getting started with WPF application, controls etc.

[·      ]{style="FONT-FAMILY: Symbol"}Grid WPF Controls-The features of individual controls are illustrated with use case scenarios, code examples and screen shots under this section.

[]{style="COLOR: #15428b"} 

Document Conventions

The conventions below will help you to quickly identify the important sections of information, while using the content:

**[]{style="COLOR: #15428b"}** 

Table 1: Document Convention

::: {align="center"}
  ------------------------ ------------------------------------------ ---------------------------------------------------------------------------------
  Convention               Icon                                       Description of the Icon
  Note                      **![](ImagesExt/image28_3.jpg)***Note:*   Represents important information.
  Example                  Example:                                   Represents an example.
  Tip                      **![](ImagesExt/image28_4.jpg)**           Represents useful hints, that will help you in using the controls and features.
  Additional information   **![](ImagesExt/image28_5.jpg)**           Represents additional information on the corresponding topic.
  ------------------------ ------------------------------------------ ---------------------------------------------------------------------------------
:::

[]{#related-topics}
:::::
