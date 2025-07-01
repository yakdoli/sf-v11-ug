::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7b1df866-3d05-42cb-864d-eab6d168ad22){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ab512301-9b99-4529-a21c-ee3c1f2473ca){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f61feb80-1940-4b18-ab36-1ab89df8b52a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[EditControl Members](ms-xhelp:///?Id=bb3fd9ce-59ed-4640-90f7-21692312ce10){.d2h_breadcrumbsNormal}
:::

### Events {#events style="tab-stops: 0pt"}

The following table lists the events available in EditControl class and its purpose.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 7: EditControl Events

::: {align="center"}
  ------------------------ ----------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Event                    Type                          Description
  DocumentSourceChanged    PropertyChangedCallback       A property changed event gets raised when the **DocumentSource** property value is changed.
  IntellisenseBoxOpening   IntellisenseBoxEventHandler   Gets raised before the **Intellisense popup** is displayed. This event can be used to cancel the **Intellisense popup** display or change **ItemsSource** of the **Intellisense ListBox** and so on.
  IntellisenseDrillDown    IntellisenseBoxEventHandler   Drill down in Intellisense occurs when the user types the drill down char specified in the CurrentLanguage instance. When the drill down occurs, the Intellisense looks for any sub items are available for the selected Intellisense item and displays it the popup if any. This event gets raised before the Intellisense popup is displayed after a drill down char is typed by the user. This event can be used to perform any operations related to Intellisense during drill down.
  SelectedTextChanged      PropertyChangedCallback       A **PropertyChangedCallback** gets raised when the text in the EditControl is **selected.**
  TextChanged              PropertyChangedCallback       A **PropertyChangedCallback get** raised when the text in the EditControl gets **changed.**
  ------------------------ ----------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

[]{#p15} 

 

[]{#related-topics}
:::::
