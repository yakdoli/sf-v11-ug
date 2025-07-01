::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=37688364-5e35-4877-85c1-a3b61c36abb5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bb22dd98-ef6e-4b87-8311-a398efba5fda){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=37688364-5e35-4877-85c1-a3b61c36abb5){.d2h_breadcrumbsNormal}
:::

## Resource Management {#resource-management style="tab-stops: 0pt"}

Many Web developers will most probably be aware of various website optimization techniques described in the Yahoo Developer Network article: [[http://developer.yahoo.com/performance/rules.html]{style="FONT-FAMILY: 'Arial','sans-serif'"}](http://developer.yahoo.com/performance/rules.html).

Here are some important rules to improve Web site optimization.

**[Minimize HTTP Requests]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**[]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

Browsers spend approximately 80% of the time fetching external components such as scripts, style sheets and images. Each unique HTTP request requires a round trip to a server, introducing indeterminate delays. Browsers must load and parse external CSS files referenced within the head of your HTML before they parse the body content. By minimizing the HTTP request load, you can maximize the initial display speed of your content.

The number of HTTP requests may be reduced by combining all the scripts into a single script and similarly combining all external style sheets into a single style sheet. For more information refer to Yahoo\'s performance rules #1.

**[Minify JavaScript and CSS]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**

Minification is the practice of removing unnecessary characters from code to reduce its size, removing unnecessary spacing, new lines, tabs, and optimizing the CSS/JavaScript code; thus improving load times. Additionally, code can be further formatted onto a single line instead of multiple lines. For more information refer to Yahoo\'s performance rules #10.

**[Put Style Sheets at the Top]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**

Loading style sheets in the document HEAD makes the page start rendering sooner because it allows three pages to render progressively. For more information refer to Yahoo\'s performance rules #5.

**[Put Scripts at the Bottom]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}**

Scripts block parallel downloads. While a script is downloading, the browser won\'t start any other downloads. You can get your site to load faster by moving your scripts to the bottom. For more information refer to Yahoo\'s performance rules #6.

[[3.1.1 StyleManager and ScriptManager]{style="FONT-FAMILY: 'Arial','sans-serif'"}](ms-xhelp:///?Id=bb22dd98-ef6e-4b87-8311-a398efba5fda)

[[3.1.2 Adding Resource Registration to an Application](ms-xhelp:///?Id=ac994809-d123-4848-9541-193003fe481e)]{style="FONT-FAMILY: 'Arial','sans-serif'"}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}StyleManager and ScriptManager](ms-xhelp:///?Id=bb22dd98-ef6e-4b87-8311-a398efba5fda){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding Resource Registration to an Application](ms-xhelp:///?Id=ac994809-d123-4848-9541-193003fe481e){style="TEXT-DECORATION: none"}
::::
