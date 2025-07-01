::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=adb1ec18-8480-4cef-ae01-df7d8c0ba059){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=5fcc5122-b737-4ec8-88a0-2358772672eb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Scrolling](ms-xhelp:///?Id=d9587a7b-4a7e-40c2-a72a-0b6931d53628){.d2h_breadcrumbsNormal}
:::

### Virtual Scrolling in MVC Grid {#virtual-scrolling-in-mvc-grid style="tab-stops: 0pt"}

The virtual scrolling support in Essential Grid for MVC allows you to view data that you require without buffering the entire load of a huge database.

This is done by dynamically loading records from server while already loaded rows remain on the client side.

 

Use Case Scenario[]{style="FONT-FAMILY: 'Cambria','serif'; FONT-SIZE: 13pt"}

Virtual scrolling allows you to retrieve the data you want through smart rendering. This means you don't have to wait until whole databases are loaded for you to get the data you want.

 

ScrollSettings Properties Table

 

+-----------------------+----------------------------------------------------------+--------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------------------------------+
| Property              | Description                                              | Type of property                                                                     | Value it accepts                                                                                                                                                | Dependencies                        |
+-----------------------+----------------------------------------------------------+--------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------------------------------+
| AllowVirtualScrolling | Gets or sets whether VirtualScrolling is enabled or not. | bool                                                                                 | True                                                                                                                                                            | AllowScrolling---                   |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
|                       |                                                          |                                                                                      | False                                                                                                                                                           | Scrolling should be enabled         |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
+-----------------------+----------------------------------------------------------+--------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------------------------------+
| VirtualScrollMode     | Gets or sets the mode of scrolling                       | [VirtualScrollMode]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"} | [VirtualScrollMode]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[.Normal]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                  | AllowVirtualScrolling---            |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
|                       |                                                          |                                                                                      | [VirtualScrollMode]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[.Facebook]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                | Virtual Scrolling should be enabled |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
|                       |                                                          |                                                                                      |                                                                                                                                                                 |                                     |
|                       |                                                          |                                                                                      | Default value is[ VirtualScrollMode]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[.Normal]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |                                     |
+-----------------------+----------------------------------------------------------+--------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------------------------------+

 

Scrolling Methods

[]{style="FONT-FAMILY: 'Cambria','serif'; FONT-SIZE: 11pt"} 

  ----------------------------------- ---------------------------------------------------------- --------------------------------------------------------------------------------------
  Method[]{style="FONT-SIZE: 11pt"}   Description[]{style="FONT-SIZE: 11pt"}                     Arguments[]{style="FONT-SIZE: 11pt"}
  AllowVirtualScrolling               Gets or sets whether VirtualScrolling is enabled or not.   bool
  VirtualScrollMode                   Gets or sets the mode of scrolling                         [VirtualScrollMode]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}
  ----------------------------------- ---------------------------------------------------------- --------------------------------------------------------------------------------------

 

 

Where do I view Samples?

To view the samples:

1.   Open the **Dashboard**. The **Essential Studio Enterprise Edition** window is displayed. The **User Interface Edition** panel is displayed by default.

2.   Select the **ASP.NET MVC** platform in the panel on the right.

3.   Click the **Run Samples** link. The **Essential Studio MVC Edition** sample browser is displayed.

4.   Select **Grid**.

5.   Select the **Virtual Scrolling** sample from the **Product Showcase** tab and browse through the features.

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enabling Virtual Scrolling](ms-xhelp:///?Id=491cfad3-34cf-4ddb-b858-a9e586de1432){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Configuring the Virtual Scrolling Modes](ms-xhelp:///?Id=f768fb22-cd07-4dee-af36-4574ca433539){style="TEXT-DECORATION: none"}
::::
