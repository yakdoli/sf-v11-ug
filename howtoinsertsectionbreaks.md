::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8c378248-95fc-4cae-b35a-b42f4814bcd3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=655bff97-b031-4849-9a97-4f9cc3c696e1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=82ce5b36-6d4b-438d-b8f8-cf8bbfb1678f){.d2h_breadcrumbsNormal}
:::

## How to insert section breaks? {#how-to-insert-section-breaks style="LINE-HEIGHT: 115%; TEXT-INDENT: -28.8pt; MARGIN: 10pt 0pt 0pt 28.8pt; tab-stops: 28.8pt"}

Essential DocIO provides direct support to insert section breaks to Word documents. You can insert a section break to a Word document by using the InsertSectionBreak method of WParagraph class.

The following code snippets illustrate how to insert a section break:

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                             |
|                                                                                                                                                                                                                                      |
| [//Inserting a section break and it returns a newly created section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                                                      |
| [WSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section = paragraph.]{style="FONT-FAMILY: 'Courier New'"}[InsertSectionBreak();]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                      |
| [//Inserting a section break of the specified type and it returns a newly created section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                                                                                      |
| [WSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section = paragraph.]{style="FONT-FAMILY: 'Courier New'"}[InsertSectionBreak([SectionBreakCode]{style="COLOR: #2b91af"}.EvenPage);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\']{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Inserting a section break and it returns a newly created section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'"}[section ]{style="FONT-FAMILY: 'Courier New'"}[As ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[WSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ = paragraph.]{style="FONT-FAMILY: 'Courier New'"}[InsertSectionBreak()]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\']{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Inserting a section break of the specified type and it returns a newly created section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'"}[section ]{style="FONT-FAMILY: 'Courier New'"}[As ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[WSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ = paragraph.]{style="FONT-FAMILY: 'Courier New'"}[InsertSectionBreak([SectionBreakCode]{style="COLOR: #2b91af"}.EvenPage)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
