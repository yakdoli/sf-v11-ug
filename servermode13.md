::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5e65b315-24cb-4333-b9df-296c0546094c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9f772443-b0fd-4c0e-aa10-302e654e4205){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=45772664-2e19-4523-9f80-67c80a02ab5e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[ActionModes](ms-xhelp:///?Id=5e65b315-24cb-4333-b9df-296c0546094c){.d2h_breadcrumbsNormal}
:::

### Server Mode {#server-mode style="tab-stops: 0pt"}

[Essential Mobile Grid for ASP.NET MVC will perform service-side requests (HTTP POST) when doing operations like paging and sorting. This is called "server binding."]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

[For the first request, bind the grid with data using the **Datasource** property and render the view. For subsequent paging and sorting actions you need to write a **Post** action method in your controller. The grid is fully AJAX enabled, so while calling grid actions such as paging and sorting, the entire view won't be rendered. It just calls the **MobGridHtmlActionResult** to update the grid.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

[This can be achieved in the following ways.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

[[5.1.1.1 Through Grid Builder]{style="FONT-FAMILY: 'Arial','sans-serif'"}](ms-xhelp:///?Id=7b6937b1-502a-4e90-bd42-84d57d75bb35)

[[5.1.1.2 Through MobGridPropertiesModel](ms-xhelp:///?Id=765192ed-b1af-4b4d-b2fa-5722124eee34)]{style="FONT-FAMILY: 'Arial','sans-serif'"}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through Grid Builder](ms-xhelp:///?Id=7b6937b1-502a-4e90-bd42-84d57d75bb35){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through MobGridPropertiesModel](ms-xhelp:///?Id=765192ed-b1af-4b4d-b2fa-5722124eee34){style="TEXT-DECORATION: none"}
::::
