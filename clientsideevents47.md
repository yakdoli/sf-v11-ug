::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d5215103-858b-49c2-96c7-4fe730a989e1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3d5605cf-b939-4a9b-bc45-8401c83966a8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[MultiColumnDropDown](ms-xhelp:///?Id=cf0e6254-8964-4a67-b141-e26bc6e4f04a){.d2h_breadcrumbsNormal}
:::

### Client-Side Events {#client-side-events style="tab-stops: 0pt"}

This section details the client-side events raised by the MultiColumnDropDown control.

Properties

 

::: {align="center"}
  ------------------------------ --------------------------------------------------------------------------- ------------------------------- ------------------ ------------
  Name                           Description                                                                 Type of property                Value it accepts   Dependency
  ClientSideOnBeforePopupShown   Used to add the clientside ClientSideOnBeforePopupShown event to control.   [string]{style="COLOR: blue"}   alphanumeric       NA
  ClientSideOnPopupHidden        Used to add the clientside ClientSideOnPopupHidden event to control.        [string]{style="COLOR: blue"}   alphanumeric       NA
  ClientSideOnPopupShown         Used to add the clientside ClientSideOnPopupShown event to control.         [string]{style="COLOR: blue"}   alphanumeric       NA
  ClientSideOnSelect             Used to add the clientside ClientSideOnSelect event to control.             [string]{style="COLOR: blue"}   alphanumeric       NA
  ClientSideOnTextChanged        Used to add the clientside ClientSideOnTextChanged event to control.        [string]{style="COLOR: blue"}   alphanumeric       NA
  ------------------------------ --------------------------------------------------------------------------- ------------------------------- ------------------ ------------
:::

 

Methods

 

::: {align="center"}
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
| Method                                | Parameters                     | Return type                 | Descriptions                                                              |
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
| ClientSideOnBeforePopupShown(handler) | Function name in string format | IMultiColumnDropDownBuilder | Used to add the client-side OnBeforePopupShown event to the control.      |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
| ClientSideOnPopupHidden(handler)      | Function name in string format | IMultiColumnDropDownBuilder | Used to add the client-side ClientSideOnPopupHidden event to the control. |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
| ClientSideOnPopupShown(handler)       | Function name in string format | IMultiColumnDropDownBuilder | Used to add the client-side ClientSideOnPopupShown event to the control.  |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
| ClientSideOnSelect(handler)           | Function name in string format | IMultiColumnDropDownBuilder | Used to add the client-side ClientSideOnSelect event to the control.      |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
| ClientSideOnTextChanged(handler)      | Function name in string format | IMultiColumnDropDownBuilder | Used to add the client-side ClientSideOnTextChanged event to the control. |
|                                       |                                |                             |                                                                           |
|                                       |                                |                             |                                                                           |
+---------------------------------------+--------------------------------+-----------------------------+---------------------------------------------------------------------------+
:::

 

Events

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {align="center"}
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
| Name                         | Description                                                                     | Arguments                                                                                                     |
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
| ClientSideOnBeforePopupShown | This event is raised just before the popup is shown.                            | get_SelectedRow() [// Contains the Selected record object (JSON).]{style="COLOR: green"}                      |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_DisplayValue() [// Contains the display value.]{style="COLOR: green"}                                     |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_SelectedValue() [// Contains the selected value.]{style="COLOR: green"}                                   |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedRow [// Returns the Selected record object (JSON).]{style="COLOR: green"}[]{style="COLOR: #00b050"} |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_DisplayValue [// Returns the display value.]{style="COLOR: green"}[]{style="COLOR: #00b050"}                |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedValue [// Returns the selected Value.]{style="COLOR: green"}                                        |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 |                                                                                                               |
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
| ClientSideOnPopupHidden      | This event is raised when the pop-up panel hides.                               | get_SelectedRow() [// Contains the Selected record object (JSON).]{style="COLOR: green"}                      |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_DisplayValue() [// Contains the display value. ]{style="COLOR: green"}                                    |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_SelectedValue() [// Contains the selected value.]{style="COLOR: green"}                                   |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedRow [// Returns the Selected record object (JSON).]{style="COLOR: green"}[]{style="COLOR: #00b050"} |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_DisplayValue [// Returns the display value.]{style="COLOR: green"}[]{style="COLOR: #00b050"}                |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedValue [// Returns the selected Value.]{style="COLOR: green"}                                        |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 |                                                                                                               |
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
| ClientSideOnPopupShown       | This event is raised when the pop-up panel displays.                            | get_SelectedRow() [// Contains the Selected record object (JSON).]{style="COLOR: green"}                      |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_DisplayValue() [// Contains the display value. ]{style="COLOR: green"}                                    |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_SelectedValue() [// Contains the selected value.]{style="COLOR: green"}                                   |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedRow [// Returns the Selected record object (JSON).]{style="COLOR: green"}[]{style="COLOR: #00b050"} |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_DisplayValue [// Returns the display value.]{style="COLOR: green"}[]{style="COLOR: #00b050"}                |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedValue [// Returns the selected Value.]{style="COLOR: green"}                                        |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 |                                                                                                               |
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
| ClientSideOnSelect           | This event is raised when you select the record from dropdown.                  | get_SelectedRow() [// Contains the Selected record object (JSON).]{style="COLOR: green"}                      |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_DisplayValue() [// Contains the display value. ]{style="COLOR: green"}                                    |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_SelectedValue() [// Contains the selected value.]{style="COLOR: green"}                                   |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedRow [// Returns the Selected record object (JSON).]{style="COLOR: green"}[]{style="COLOR: #00b050"} |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_DisplayValue [// Returns the display value.]{style="COLOR: green"}[]{style="COLOR: #00b050"}                |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedValue [// Returns the selected Value.]{style="COLOR: green"}                                        |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 |                                                                                                               |
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
| ClientSideOnTextChanged      | This event is raised when the value of the generic drop-down text box  changes. | get_SelectedRow() [// Contains the Selected record object (JSON).]{style="COLOR: green"}                      |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_DisplayValue() [// Contains the display value.]{style="COLOR: green"}                                     |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | get_SelectedValue() [// Contains the selected value.]{style="COLOR: green"}                                   |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedRow [// Returns the Selected record object (JSON).]{style="COLOR: green"}[]{style="COLOR: #00b050"} |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_DisplayValue [// Returns the display value.]{style="COLOR: green"}[]{style="COLOR: #00b050"}                |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 | \_SelectedValue [// Returns the selected Value.]{style="COLOR: green"}                                        |
|                              |                                                                                 |                                                                                                               |
|                              |                                                                                 |                                                                                                               |
+------------------------------+---------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Adding Handlers through Builder](ms-xhelp:///?Id=0b6de06c-b1aa-4f5e-a94f-f8b9a569f27d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Adding Handlers through MultiColumnDropDownModel](ms-xhelp:///?Id=41732d19-031b-4852-8ad3-5896f5eb0dd8){style="TEXT-DECORATION: none"}
:::::::
