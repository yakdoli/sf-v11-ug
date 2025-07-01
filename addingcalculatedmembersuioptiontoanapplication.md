::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d86767af-ad28-4c48-89fd-ee897069b9f5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4f1747ee-bf9b-4dcd-b99f-af26af2ccdb7){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Client]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=ac4d4da8-25e2-4317-98b8-e507a1eb5062){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Calculated Members UI Option in OlapClient Control](ms-xhelp:///?Id=dcf77273-2569-45ca-96dd-179cadacec40){.d2h_breadcrumbsNormal}
:::

### Adding Calculated Members UI Option to an Application {#adding-calculated-members-ui-option-to-an-application style="tab-stops: 0pt"}

The following code sample explains how to enable or disable the Calculated Members UI option in an OlapClient application:

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [////Enable the Calculated Members in current view of the OlapClient.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [.olapClient1.IsCalculatedMembersEnabled = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} [true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [; ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                       |
| [//if set false, then it will be disabled or all calculated members will be deleted from the current view of the OlapClient.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                  |
|                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                             |
| [\'Enable the Calculated Members in ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} [current view of the OlapClient.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                        |
|                                                                                                                                                                             |
|                     Me                                                                                                                                                      |
|                     .olapClient1.IsCalculatedMembersEnabled =                                                                                                               |
|                     True                                                                                                                                                    |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                     ''''if set false, then it will be disabled or all calculated members will be deleted from the current view of the OlapClient.                           |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
|                                                                                                                                                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: black"} 

+-----------------------------------------------------------------------+
|                                                                       |
|                       [XAML]                                          |
|                                                                       |
|                                                                       |
|                                                                       |
|                                                                       |
|                                                                       |
|                                                                       |
|                                                                       |
|                                                                       |
|                     <                                                 |
|                     CheckBox                                          |
|                      Name                                             |
|                     ="chk_CalcMember                                  |
|                     ToolTip                                           |
|                     ="Enable/Disable Calculated Members"              |
|                      Content                                          |
|                     ="Enable Calculated Members"                      |
|                      IsChecked                                        |
|                     ="{                                               |
|                     Binding                                           |
|                      ElementName                                      |
|                     =olapClient1,                                     |
|                      Path                                             |
|                     =IsCalculatedMembersEnabled}"/>                   |
|                                                                       |
|                                                                       |
|                                                                       |
|                                                                       |
+-----------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; COLOR: black"} 

 

[]{#related-topics}
::::
