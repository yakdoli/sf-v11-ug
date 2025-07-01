::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=01b16c70-920b-4d26-9971-5b4ce9b2a2db){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4d97c0ec-3280-443d-902d-427b26c85a63){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Line Connector](ms-xhelp:///?Id=c7ae1b55-3b10-4b74-889d-cf088e9eca27){.d2h_breadcrumbsNormal}
:::

### Connector Deletion {#connector-deletion style="tab-stops: 0pt"}

This feature allows you to delete a [single]{style="BACKGROUND: white"} connector from the diagram page in Essential Diagram for MVC without deleting the nodes attached to it.

 

Appearance and Structure

The following figures illustrate the appearance, structure, and function of the connector deletion feature and its settings:

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image70_81.png){border="0"}

Figure 76: Selection of a Connector for Deletion

 

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image70_82.png){border="0"}

 

Figure 77: Connectors after Deletion of the Selected Connector

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 
:::

Where do I find the installed samples?

[To view the samples:]{style="BACKGROUND: white"}

1.   [Open the Essential Diagram sample browser from the dashboard. (Refer to the ]{style="BACKGROUND: white"}**[Samples and Locations]{style="BACKGROUND: white"}**[ section).]{style="BACKGROUND: white"}

2.   [Go to the **Getting Started** tab, and click **Flat Diagram**.]{style="BACKGROUND: white"}

 

Properties

+-------------+-----------------------------------------------------------------------+---------------------+----------------------+--------------+
| Property    | Description                                                           | Type of Property    | Value it Accepts     | Dependencies |
+-------------+-----------------------------------------------------------------------+---------------------+----------------------+--------------+
| AllowDelete | Gets or sets a value indicating whether the connector can be deleted. | Dependency property | Boolean (true/false) | No           |
|             |                                                                       |                     |                      |              |
|             | The default value is set to true.                                     |                     |                      |              |
|             |                                                                       |                     |                      |              |
|             |                                                                       |                     |                      |              |
+-------------+-----------------------------------------------------------------------+---------------------+----------------------+--------------+

 

Enabling Connector Deletion in Essential Diagram for MVC

This section guides you through the process of enabling connector deletion in an MVC application. You can implement this feature in either one of the following two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Using Builder

[·      ]{style="FONT-FAMILY: Symbol"}Through the properties model

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=e5c3ebf9-c8d2-444e-b3a1-7deddd907c02){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using Properties Model](ms-xhelp:///?Id=ff30aff3-7378-4e8a-a6ad-fa9f07eb65bb){style="TEXT-DECORATION: none"}
:::::
