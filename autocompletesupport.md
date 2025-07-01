::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3f18d395-b947-424d-9d18-25a8a36cc2e8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a39110e0-a530-4fe5-bc15-41cf6b98e149){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts And Features](ms-xhelp:///?Id=7c39cee6-8434-4711-a18e-efaba8ac85c0){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Code Completion](ms-xhelp:///?Id=3f18d395-b947-424d-9d18-25a8a36cc2e8){.d2h_breadcrumbsNormal}
:::

### AutoComplete Support {#autocomplete-support style="tab-stops: 0pt"}

 

Complete Word feature is a user-friendly functionality that can be used in conjunction with the Context Choice, and is analogous to the Complete Word feature in Visual Studio. This feature autocompletes the rest of the member name once you have entered enough characters to distinguish it. Type the first few letters of the member name, and then press ALT+RIGHT ARROW or CTRL+SPACEBAR keys to see this functionality.

 

**Example**

 

When the following text is typed - \"this.editControl1.\", it displays a Context Choice list with members in the following order

 

[·      ]{style="FONT-FAMILY: Symbol"}New

[·      ]{style="FONT-FAMILY: Symbol"}Word

[·      ]{style="FONT-FAMILY: Symbol"}WordLeft

[·      ]{style="FONT-FAMILY: Symbol"}WordRight

 

**Case 1**

 

If you type \"w\" after \"this.editControl1.\", such that it looks like - \"this.editControl1.w\", and press the ALT+RIGHT ARROW (or CTRL+SPACEBAR) keys, it will autocomplete it with the first matching member name. In this case, it will be autocompleted as \"this.editControl1.Word\".

 

**Case 2**

 

If you type \"wordr\" after \"this.editControl1.\", such that it looks like - \"this.editControl1.wordr\", and press the ALT+RIGHT ARROW (or CTRL+SPACEBAR) keys, it will autocomplete it with the first matching member name. In this case, it will be autocompleted as \"this.editControl1.WordRight\".

 

**Case 3**

 

If you type \"move\" after \"this.editControl1.\", such that it looks like - \"this.editControl1.move\", and press the ALT+RIGHT ARROW (or CTRL+SPACEBAR) keys, it will autocomplete it with the first matching member name. In this case, there is no matching member name to autocomplete, and hence nothing will happen.

 

**Case 4**

 

If you type nothing after \"this.editControl1.\", and press the ALT+RIGHT ARROW (or CTRL+SPACEBAR) keys, it will autocomplete it with the first member name in the Context Choice list. In this case, it should be autocompleted as \"this.editControl1.New\".

 

Note that the searching process for the first matching member is not case sensitive. For example, \"wordr\" and \"WordR\" will be treated in the same way.

 

Set the **UseAutocomplete** property associated with the **IContextChoiceController** to **True**, to enable this functionality while using Context Choice.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                  |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.[IContextChoiceController]{style="COLOR: teal"} controller)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                  |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                  |
| [controller.UseAutocomplete = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} editControl1_ContextChoiceOpen([ByVal]{style="COLOR: blue"} controller [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController) [Handles]{style="COLOR: blue"} editControl1.ContextChoiceOpen]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                               |
| [controller.UseAutocomplete = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                               |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also

 

[AutoReplace Triggers]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p30} 

[]{#related-topics}
::::
