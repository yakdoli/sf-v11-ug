::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=047086ea-18fa-4622-adf1-5c6e3bbc14e7){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7d90edec-0fbd-4c5d-b08a-a77b0e2263f5){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Gauge]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Common](ms-xhelp:///?Id=047086ea-18fa-4622-adf1-5c6e3bbc14e7){.d2h_breadcrumbsNormal}
:::

## Performance {#performance style="tab-stops: 0pt"}

 

The Syncfusion Essential studio makes use of class named ScriptResourceAttribute which can be used to define a resource in an assembly to be used from a client script file.

 

Then the resource files which are all used in the Syncfusion controls will be zipped and served over the network. The following screen shot shows this:

 

![](ImagesExt/image105_9.jpg){border="0"}

Figure 1

 

In order to achieve this, you will need to set the following attributes in the project\'s web.config file:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [configuration system.web.extensions]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [/\>\                                                                                                                                                                                                                                                                                                                |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}. . .\                                                                                                                                                                                                                                                                                                                                                                                                            |
|           [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[scripting]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>\                                                                                                                                                                                                                                                                                                                                   |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                   [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ScriptResourceHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[enableCompression]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}=[\"true\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[enableCaching]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}=[\"true\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[/\>\ |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}          [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}/[scripting]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>\                                                                                                                                                                                                                                                                                |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}. . .\                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[system.web.extensions]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

As the resource files gets zipped,

[·      ]{style="FONT-FAMILY: Symbol"}It saves the precious network band-width

[·      ]{style="FONT-FAMILY: Symbol"}It reduces the load-time. As a result, the webform which consists of the Syncfusion controls will get loaded faster on the client's browser

[·      ]{style="FONT-FAMILY: Symbol"}It also reduces the network traffic

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Page Compression Handler](ms-xhelp:///?Id=7d90edec-0fbd-4c5d-b08a-a77b0e2263f5){style="TEXT-DECORATION: none"}
::::
