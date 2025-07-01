::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=24b52614-5fe3-4aee-96a2-dc835d874411){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b3ad3624-d74b-4256-94b5-734c481969a0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=9e489974-524d-457c-9881-e458b1321685){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[AJAX](ms-xhelp:///?Id=bf52d324-77f7-410d-b75f-324b9b7bba76){.d2h_breadcrumbsNormal}
:::

### AJAX Grid {#ajax-grid style="tab-stops: 0pt"}

The AJAX Grid control handles data presentation operations like paging, sorting, grouping, and filtering, or you can perform those operations. But this mode of action for the AJAX Grid control is decided using the **AjaxActionMode** property whose options are described in the following table. AJAX Grid supports two kinds of ActionModes.

 

+----------------+---------------------------------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------+-----------------------------+
| **Property**   | **Description**                                                                                                                             | **Type of Property** | **Value It Accepts**    | **Dependencies**            |
+----------------+---------------------------------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------+-----------------------------+
| EnableAjaxMode | Specifies the mode of GridGroupingControl                                                                                                   | Boolean              | True                    | NA                          |
|                |                                                                                                                                             |                      |                         |                             |
|                |                                                                                                                                             |                      | False                   |                             |
|                |                                                                                                                                             |                      |                         |                             |
|                |                                                                                                                                             |                      | Default value is False  |                             |
+----------------+---------------------------------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------+-----------------------------+
| AjaxActionMode | Used to set the action mode of the control.                                                                                                 | Enum                 | Json                    | Dependent on EnableAjaxMode |
|                |                                                                                                                                             |                      |                         |                             |
|                | Server---All the operations like sorting and grouping are handled by Essential Grid itself (by default).                                    |                      | Server                  |                             |
|                |                                                                                                                                             |                      |                         |                             |
|                | JSON (JavaScript Object Notation)---You have to handle the operations. The possible operations are paging, sorting, grouping and filtering. |                      | Default value is Server |                             |
|                |                                                                                                                                             |                      |                         |                             |
|                |                                                                                                                                             |                      |                         |                             |
|                |                                                                                                                                             |                      |                         |                             |
|                |                                                                                                                                             |                      |                         |                             |
+================+=============================================================================================================================================+======================+=========================+=============================+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=b23be3e7-4324-4e27-9079-2ac07d9a0eea){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=32599323-4758-4a85-bd32-39c131c8266a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Paging](ms-xhelp:///?Id=65d70062-4179-4820-9cb3-26fb7ef957a0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sorting](ms-xhelp:///?Id=34c83e9d-6148-4fc7-9c62-ca64c7f260e6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Grouping](ms-xhelp:///?Id=68adc869-057d-4a19-809c-1290ea5d7454){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Filtering](ms-xhelp:///?Id=739982d1-6718-4cb5-8c8f-8a58667b0449){style="TEXT-DECORATION: none"}
::::
