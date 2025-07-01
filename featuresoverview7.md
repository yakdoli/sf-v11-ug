::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f6d856fa-f22c-4eb0-865c-4556abe01f77){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4952d183-2fa0-4ecd-87df-2a09757384a9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Tools Controls](ms-xhelp:///?Id=13c3c4f4-9d16-4b69-93f2-7e98eec67452){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[TabbedMDI Package](ms-xhelp:///?Id=f6d856fa-f22c-4eb0-865c-4556abe01f77){.d2h_breadcrumbsNormal}
:::

### Features Overview {#features-overview style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

 

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

The TabbedMDI framework contains the TabbedMDIManager control with features to create rich user applications.

[]{style="COLOR: #15428b"} 

Features

[]{style="FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Styles -** TabbedMDI supports wide range of Tab Styles and Window Styles. Windows in the TabbedMDI framework can be arranged in four different styles such as horizontal, vertical, cascade and inside the client area of the parent form. It also provides advanced features to set the styles for the DropDown Menus and Context Menus.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Tab Alignment** - Aligns the Tabs to the Top, Left, Right or Bottom using the Alignment property. To access this property, the TabControlAdded event is used.

[]{style="FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Tab Groups[ ]{style="FONT-SIZE: 8pt"}-** [[Tab Groups]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Tab_Groups) are resizable exactly as in the Visual Studio .NET IDE. The number and layout of the Tab Groups can be restricted and controlled.

 

[·      ]{style="FONT-FAMILY: Symbol"}**MDI List** - The list of MDIChild Forms in the application can be retrieved by using a single property. Also the Menu Item or ToolStrip Menu Item to which the list should be added can be specified.

[]{style="FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Button Settings[ - ]{style="FONT-SIZE: 8pt"}**Options to add [[DropDown]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_DropDown_Button) and [[Close buttons]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Close_Button) are available. Close buttons can be displayed individually for each tab. The color of the close button can be set according to the needs of the user. It also provides options to close tabs on clicking the middle button of the mouse.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Appearance Settings -[ ]{style="FONT-SIZE: 8pt"}**User Controls, Images and Icons can be added to the Tabs. Options are provided to customize the tab\'s text and image and control the tab\'s image size.

 

Themed tabs can be displayed using the[ ]{style="FONT-SIZE: 8pt"}**ThemesEnabled**[ ]{style="FONT-SIZE: 8pt"}property.

[]{style="FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Context Menu** **[- ]{style="FONT-SIZE: 8pt"}**[[Context Menu]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Context_Menu)[ ]{.UGHyperlink}Items of the Tabs can be customized. Customized Bar Items can be added to the default context menu by accessing the ParentBarItem instance through the **contextMenuItem.Items.Add(baritem)** property.

[]{style="FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Automatic State Persistence -** TabbedMDI provides full state persistence support. The TabbedMDIManager automatically persists Tab Groups and Tab Group Sizes for use across application invocations.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Serialization Support** - Provides[ ]{style="FONT-SIZE: 8pt"}[[serialization support]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Serialization_support) to save and load the Tab States.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Tooltip Support** - Tooltips can be enabled for individual Tabs.

[]{style="COLOR: navy; FONT-SIZE: 8pt"} 

See Also

**[]{style="COLOR: #15428b"}** 

[[Concepts and Features]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Concepts_and_Features_8)[, ]{style="COLOR: #15428b"}[[Creating TabbedMDIManager]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Creating_TabbedMDIManager)[]{style="COLOR: black"}

 

 

 

[]{#p900} 

[]{#related-topics}
::::
