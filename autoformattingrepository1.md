::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6a10bc1f-478a-4f7c-831d-f1d012c7f49a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=82eb08c4-33ff-49bf-8095-0afea84bdb75){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How to](ms-xhelp:///?Id=0d8a7383-ca49-43db-8609-dca7963c87ab){.d2h_breadcrumbsNormal}
:::

## AutoFormatting Repository {#autoformatting-repository style="tab-stops: 0pt"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [static]{style="COLOR: blue"} [class]{style="COLOR: blue"} [AutoFormatRepository]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                                                 |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                 |
| [        [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                 |
| [        [///]{style="COLOR: gray"}[ Get all AutoFormatting data.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                 |
| [        [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\</summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                                                 |
| [        [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<returns\>\</returns\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                 |
| [        [public]{style="COLOR: blue"} [static]{style="COLOR: blue"} [IList]{style="COLOR: #2b91af"}\<[AutoFormatting]{style="COLOR: #2b91af"}\> GetData()]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                                                 |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                 |
| [            [List]{style="COLOR: #2b91af"}\<[AutoFormatting]{style="COLOR: #2b91af"}\> result = [new]{style="COLOR: blue"} [List]{style="COLOR: #2b91af"}\<[AutoFormatting]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"10/10/2005 6:30AM\"]{style="COLOR: #a31515"}), 15123.45m, 1362, 458792658));]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"10/9/2006 7:20PM\"]{style="COLOR: #a31515"}), 12893.45m, 234, 254879362));]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"9/10/2007 8:45AM\"]{style="COLOR: #a31515"}), 45123.45m, 1298, 569786269));]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"5/10/2004 7:45PM\"]{style="COLOR: #a31515"}), 67189.45m, 3362, 163840382));]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"2/3/2009 5:34AM\"]{style="COLOR: #a31515"}), 23190.45m, 1839, 983729405));]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"6/8/2020 9:56PM\"]{style="COLOR: #a31515"}), 43145.45m, 89982, 937292033));]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"3/2/2001 1:45AM\"]{style="COLOR: #a31515"}), 5198.45m, 6739, 473920219));]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"2/1/2003 2:23PM\"]{style="COLOR: #a31515"}), 345123.45m, 2262, 987654321));]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                 |
| [            result.Add([new]{style="COLOR: blue"} [AutoFormatting]{style="COLOR: #2b91af"}([Convert]{style="COLOR: #2b91af"}.ToDateTime([\"11/12/2005 9:56PM\"]{style="COLOR: #a31515"}), 315123.45m, 48393, 123456789));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                 |
| [            [return]{style="COLOR: blue"} result;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                 |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
