::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=89fc0e33-ba44-47d0-9c2e-e9a470ce882a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c904ce63-54bd-4ca4-b693-b655fab218ad){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How to ...](ms-xhelp:///?Id=f61296b6-d22f-4dec-82be-f560f0302129){.d2h_breadcrumbsNormal}
:::

## How to Use Other Controls Inside the Dialog? {#how-to-use-other-controls-inside-the-dialog style="tab-stops: 0pt"}

Essential Tools allows you to use other controls inside the Dialog. You need to make a note on the setting of *z-index* property for the control while using the controls inside the Dialog. In some cases**,** the control may set behind the Dialog**.** To make the control visible, you have to set the *z-index* for the control using their appropriate CSS classes. For example, when using the UploadBox and AutoCompleteTextBox controls inside the Dialog, you have to set the *z-index* as illustrated in the following code examples.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[CSS\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                 |
|                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                   |
| [// For UploadBox]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                   |
| [   .uploadbox]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [.sf_uploadinput]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                   |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                   |
| [        [z-index]{style="COLOR: red"}: [9999]{style="COLOR: blue"} [!important]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                   |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[CSS\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                           |
|                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                             |
| [// For AutoCompleteTextBox]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                             |
| [    [.Autocomplete_SuggestionList]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                             |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                             |
| [        [z-index]{style="COLOR: red"}: [9999]{style="COLOR: blue"} [!important]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                             |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
