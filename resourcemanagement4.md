::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=659dde2c-da37-4d15-9752-a5d1c2730cad){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2815c4e9-e801-4ff9-b89d-ebcd2abe77be){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET MVC](ms-xhelp:///?Id=32b055b8-3bdf-473c-bb73-f99a534ce79c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=659dde2c-da37-4d15-9752-a5d1c2730cad){.d2h_breadcrumbsNormal}
:::

## Resource Management {#resource-management style="tab-stops: 0pt"}

Many web developers will most probably be aware of various website optimization techniques described in Yahoo Developer Network article (Please refer [[http://developer.yahoo.com/performance/rules.html]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://developer.yahoo.com/performance/rules.html)).

Here are some important rules to improve the website optimization.

 

Minimize HTTP Requests:[]{style="FONT-WEIGHT: normal"}

Browsers spend approximately 80% of the time fetching external components such as scripts, style sheets and images. Each unique HTTP request requires a round trip to a server, introducing indeterminate delays.Browsers must load and parse external CSS files referenced within the head of your HTML before they parse the body content. By minimizing the HTTP request load, you can maximize the initial display speed of your content.

Number of HTTP requests may be reduced by combining all the scripts into a single script and similarly combining all external stylesheets into a single stylesheet. For more information, refer to Yahoo\'s performance rule #1.

 

Minify JavaScript and CSS:[]{style="FONT-WEIGHT: normal"}

Minification is the practice of removing unnecessary characters from code to reduce its size, removing unnecessary spacing, newlines, tabs  and optimizing the CSS/javascript code; thus improving load times. Additionally, code can be further formatted onto a single line instead of multiple lines.For more information, refer to Yahoo\'s performance rule #10.

 

Put Stylesheets at the Top:*[]{style="FONT-WEIGHT: normal"}*

Loadingstylesheets in the document HEAD makes the page to start rendering sooner because this allows three pages to render progressively. For more information, refer to Yahoo\'s performance rule #5.

 

Put Scripts at the Bottom:[]{style="FONT-WEIGHT: normal"}

Scripts block parallel downloads. While a script is downloading, the browser won\'t start any other downloads. You can get your site to load faster by moving your scripts to the bottom.. For more information, refer to Yahoo\'s performance rule #6.

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}StyleManager and ScriptManager](ms-xhelp:///?Id=2815c4e9-e801-4ff9-b89d-ebcd2abe77be){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding Resource Registration to an Application](ms-xhelp:///?Id=6e02696a-1651-4bcb-96e8-b2d592c643fa){style="TEXT-DECORATION: none"}
::::
