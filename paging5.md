::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=9f772443-b0fd-4c0e-aa10-302e654e4205){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ecfcc123-6637-4ec1-a5ab-c6df19e318cf){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=45772664-2e19-4523-9f80-67c80a02ab5e){.d2h_breadcrumbsNormal}
:::

## Paging {#paging style="tab-stops: 0pt"}

Essential Grid for Mobile MVC offers complete navigation support to easily switch between the pages through swipe-up and swipe-down actions on the grid content area. Also, a pager bar will be available at the bottom of the page and it will be visible only on swiping the grid content area. It facilitates splitting up huge grid data and displays viewable sets of grid rows on each page.

The Grid control for MVC exposes the following properties and methods to enable and control the paging feature.

Properties

::: {align="center"}
+------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+----------------------+------------------------------------------------------+
| [ ]{style="FONT-SIZE: 12pt"}**Property** | **Description**                                                                                                                                                                                            | **Type of Property** | **Value it Accepts** | **Any Other Dependencies/Sub-Properties Associated** |
+------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+----------------------+------------------------------------------------------+
| AllowPaging                              | Enables the paging feature.                                                                                                                                                                                | Boolean              | True/false           | NA                                                   |
|                                          |                                                                                                                                                                                                            |                      |                      |                                                      |
|                                          |                                                                                                                                                                                                            |                      |                      |                                                      |
+------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+----------------------+------------------------------------------------------+
| PageSize                                 | Sets the number of records to be displayed in a single grid page. The same number of records will be available for the next page and you will be able to navigate between these pages using the pager bar. | Int                  | +ve Integers         | Dependent on AllowPaging                             |
+------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+----------------------+------------------------------------------------------+
| ShowPager(bool)                          | Sets whether the pager bar should be displayed at the bottom of the page or not.                                                                                                                           | bool                 | True/false           | Dependent on AllowPaging                             |
+------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+----------------------+------------------------------------------------------+
| CurrentPage                              | Set the current page to the Grid control.                                                                                                                                                                  | Int                  | +ve Intergers        | Dependent on AllowPaging                             |
+------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+----------------------+------------------------------------------------------+
:::

[]{style="FONT-SIZE: 12pt"} 

**[Methods]{style="FONT-SIZE: 12pt"}**

::: {align="center"}
  -------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- -------------------------------- -------------------
  **Method**           **Descriptions**                                                                                                                                                                                          **Parameters**                   **Return type**
  EnablePaging()       Used to enable the paging feature in the Grid control.                                                                                                                                                    No parameter                     IGridBuilder\<T\>
  AllowPaging(bool)    Used to enable/disable the paging feature.                                                                                                                                                                Enable as bool                   PageBuilder
  PageSize(Int32)      Sets the number of records to be displayed in a single grid page. The same number of records will be available for the next page and you will be able to navigate between these pages using pager bars.   Page size as integer             PageBuilder 
  ShowPager(bool)      Sets whether the pager bar should be displayed at the bottom of the page or not.                                                                                                                          ShowPager  as bool               PageBuilder 
  CurrentPage(Int32)   Set the current page to the Grid control.                                                                                                                                                                 Current page number as integer   PageBuilder
  -------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- -------------------------------- -------------------
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=ecfcc123-6637-4ec1-a5ab-c6df19e318cf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=70fd8b44-be81-4f68-88ee-ad6f5a74bc02){style="TEXT-DECORATION: none"}
::::::
