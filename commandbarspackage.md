::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=13c3c4f4-9d16-4b69-93f2-7e98eec67452){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=faad23f4-719c-44bc-98b7-8d13b18fa957){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Tools Controls](ms-xhelp:///?Id=13c3c4f4-9d16-4b69-93f2-7e98eec67452){.d2h_breadcrumbsNormal}
:::

## []{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}CommandBars Package {#commandbars-package style="tab-stops: 0pt"}

 

The Essential Tools **CommandBar** implements a framework for creating and hosting ToolBars, ReBars and StatusBars similar to those that are found in the Visual Studio .NET and Office XP user interfaces.

[]{style="COLOR: #15428b"} 

The three main classes of the CommandBar framework are **CommandBarController**, **CommandBar** and **ControlBar**.

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}The **CommandBarController** component serves as a form scope controller for the CommandBar and ControlBar hosted on a form and provides the required design time support and API for creating and working with the CommandBars and ControlBars.

[·              ]{style="FONT-FAMILY: Symbol"}

[·      ]{style="FONT-FAMILY: Symbol"}A **CommandBar**, similar to the Win32 / MFC ControlBars, is purely a container control that is responsible only for it\'s layout state.

[·              ]{style="FONT-FAMILY: Symbol"}

[·      ]{style="FONT-FAMILY: Symbol"}A **ControlBar** enables application developers to add dockable / floatable controls to their form\'s toolbar layout. A common example of a ControlBar is the task pane window found in the Microsoft Office 2003 product suite. Refer to the \'Detached ControlBars\' topic under the Menus Package which has explained the ControlBar in detail.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 Note:
:::

1.   The CommandBar framework should be used directly in an application only when there is no requirement for XP style menus and toolbars. Refer to the Essential Tools Menus Package for implementing XP style menus and toolbars.

 

2.   ReBar controls act as containers for child controls. They contain one or more bands, and each band can have any combination of a gripper bar, a bitmap, a text label, and many more controls. ReBar control is also called as CoolBar. This control is not included in the .NET framework. It is available only in the VB 6.0 and MFC framework.

[]{style="COLOR: #15428b"} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Features](ms-xhelp:///?Id=faad23f4-719c-44bc-98b7-8d13b18fa957){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Creating CommandBar](ms-xhelp:///?Id=c1636237-7c6a-4421-a6f1-7fd9f22af71f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Concepts and Features](ms-xhelp:///?Id=be498917-908c-4145-9950-2fc0b7d8bf9a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Frequently Asked Questions](ms-xhelp:///?Id=f58b32dc-d3e0-4c08-97f1-82bdb1c97ef7){style="TEXT-DECORATION: none"}
:::::
