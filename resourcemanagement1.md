::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=49a475aa-006c-4335-93c8-97725e766e43){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a47967cc-2d47-4bfd-9533-c088b570205a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=49a475aa-006c-4335-93c8-97725e766e43){.d2h_breadcrumbsNormal}
:::

## Resource Management {#resource-management style="tab-stops: 0pt"}

Many Web developers will probably be aware of various website optimization techniques described in the following Yahoo Developer Network article (Please refer to [[http://developer.yahoo.com/performance/rules.html]{.UGHyperlink}](http://developer.yahoo.com/performance/rules.html)).

Here are some important rules to improve the Web site optimization.

 

Minimize HTTP Requests:

Browsers spend approximately 80% of their time fetching external components such as scripts, style sheets, and images. Each unique HTTP request requires a round-trip to a server, introducing indeterminate delays. Browsers must load and parse external CSS files referenced within the head of your HTML before they parse the body content. By minimizing the HTTP request load, you can maximize the initial display speed of your content.

The number of HTTP requests may be reduced by combining all the scripts into a single script and similarly combining all external stylesheets into a single stylesheet. For more information, refer to Yahoo\'s performance rules #1.

 

Minify JavaScript and CSS:

Minification is the practice of removing unnecessary characters from code to reduce its size, removing unnecessary spacing, newlines, tabs, and optimizing the CSS/JavaScript code; thus improving load times. Additionally, code can be further formatted onto a single line instead of multiple lines. For more information, refer to Yahoo\'s performance rules #10.

 

Put Stylesheets at the Top:

Loading stylesheets in the document HEAD makes the page start rendering sooner because this allows three pages to render progressively. For more information, refer to Yahoo\'s performance rules #5.

 

Put Scripts at the Bottom:

Scripts block parallel downloads. While a script is downloading, the browser won\'t start any other downloads. You can get your site to load faster by moving your scripts to the bottom. For more information, refer to Yahoo\'s performance rules #6.

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}StyleManager and ScriptManager](ms-xhelp:///?Id=a47967cc-2d47-4bfd-9533-c088b570205a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding Resource Registration to an Application](ms-xhelp:///?Id=6855dbfa-16bb-4e08-b953-e1e7501ec189){style="TEXT-DECORATION: none"}
::::
