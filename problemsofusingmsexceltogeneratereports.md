::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=71521297-e8c6-4bb9-9152-2c26e572d7e9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d0af9123-dd30-4e7e-8849-b0edb2474feb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Overview](ms-xhelp:///?Id=bf585262-493a-41b9-a346-f63b5e75614f){.d2h_breadcrumbsNormal}
:::

## Problems of Using MS Excel to Generate Reports {#problems-of-using-ms-excel-to-generate-reports style="tab-stops: 0pt"}

 

MS Excel was not designed to be a report generation library, so it has several disadvantages compared to XlsIO. Here is a list of some of the problems in using Excel as a reporting component:

 

[[·      ]{style="FONT-FAMILY: Symbol; COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}Microsoft, themselves do not recommend using Excel as a report generation server-side component. The reasons are clearly explained in the following Knowledge Base article from Microsoft: [[[[http://support.microsoft.com]{style="COLOR: blue"}]{.underline}[]{style="COLOR: windowtext"}](http://support.microsoft.com/default.aspx?scid=kb;EN-US;q257757)]{.UGHyperlink}

 

[·      ]{style="FONT-FAMILY: Symbol"}Here is a quote from the article \"Microsoft does not currently recommend, and does not support, Automation of Microsoft Office applications from any unattended, non-interactive client application or component (including ASP, DCOM, and NT Services), because Office may exhibit unstable behavior and/or deadlock when run in this environment.\"

[·      ]{style="FONT-FAMILY: Symbol"}**Speed**-Excel automation is about 100 times slower than Essential XlsIO while generating reports.

[·      ]{style="FONT-FAMILY: Symbol"}**Cost**-Licensing XlsIO is much cheaper than MS Excel licensing options. Here is a link to a Knowledge Base article from Microsoft-[[http://support.microsoft.com.]{.UGHyperlink}](http://support.microsoft.com/default.aspx?scid=kb;EN-US;q243006)

[·      ]{style="FONT-FAMILY: Symbol"}**Usability**-Essential XlsIO has a very intuitive object model that is modeled after the Excel object model, making it easy to work. XlsIO also includes some additional helper functionalities like the **ImportDataTable** method which makes programming with XlsIO much easier than using COM automation. Intellisense comments also make the job of programming with XlsIO much easier than Excel automation.

 

 

[]{#related-topics}
::::
