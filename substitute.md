::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4d00a550-5a6c-4aea-ab19-25b4aae1a48e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=167782f1-e2ba-471e-9412-1d87dd953e41){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Function Reference Section](ms-xhelp:///?Id=64c2cb3d-2548-4fe4-b0d1-0c2249ee26c8){.d2h_breadcrumbsNormal}
:::

### SUBSTITUTE {#substitute style="tab-stops: 0pt"}

 

Substitutes new_text for old_text in a text string. Use SUBSTITUTE when you want to replace specific text in a text string; use REPLACE when you want to replace any text that occurs in a specific location in a text string.

 

Syntax

 

SUBSTITUTE(text, old_text, new_text, instance_num)

 

where:

**Text** is the text or the reference to a cell containing text for which you want to substitute characters.

**Old_text** is the text you want to replace.

**New_text** is the text you want to replace old_text with.

**Instance_num** specifies which occurrence of old_text you want to replace with new_text. If you specify **instance_num**, only that instance of old_text is replaced. Otherwise, every occurrence of old_text in text is changed to new_text.

 

For example:

 

The example may be easier to understand if you copy it to a blank worksheet.

 

::: {align="center"}
  --- -------------------------------------- ------------------------------------------------------------------
      A                                       
  1   Data                                    
  2   Sales Data                              
  3   Quarter 1, 2008                         
  4   Quarter 1, 2011                         
      Formula                                Description (Result)
      =SUBSTITUTE(A2, \"Sales\", \"Cost\")   Substitutes Cost for Sales (Cost Data)
      =SUBSTITUTE(A3, \"1\", \"2\", 1)       Substitutes first instance of \"1\" with \"2\" (Quarter 2, 2008)
      =SUBSTITUTE(A4, \"1\", \"2\", 3)       Substitutes third instance of \"1\" with \"2\" (Quarter 1, 2012)
  --- -------------------------------------- ------------------------------------------------------------------
:::

 

[]{#p201} 

[]{#related-topics}
:::::
