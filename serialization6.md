::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=eae13d2b-35cd-48de-a709-b2072a0c747e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9d78f488-830d-48f8-acd3-c828500b3689){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Serialization {#serialization style="tab-stops: 0pt"}

[]{#p101}Serialization is the process of saving and retrieving the Essential Diagram file. Essential Diagram WPF supports saving the diagram page as an XAML file. The page and all its properties get saved. On loading, the page gets loaded in the current view with all its nodes and connections. This load and save feature allows you to save their diagram page for future use. You can continue working on their page by loading the appropriate XAML file.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 84: Methods Table

+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Name         | Parameters       | Return Type | Description                                                                     | Reference Links                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Save()       | Null             | Void        | Displays the Save Dialogue Box to save the DiagramPage into XAML file.          | [**[Save Diagram Page]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=18757426-5b22-4b31-bdc1-0a8acb9645ac) |
|              |                  |             |                                                                                 |                                                                                                            |
|              |                  |             |                                                                                 |                                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Save(string) | String           | Void        | Saves the DiagramPage into  XAML file whose file name is specified.             | [**[Save Diagram Page]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=8cd05ca3-67cc-42a6-a7a5-34cc02dc7415) |
|              |                  |             |                                                                                 |                                                                                                            |
|              |                  |             |                                                                                 |                                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Save(Stream) | System.IO.Stream | Void        | Saves the DiagramPage into memory stream.                                       | [**[Save Diagram Page]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=f3611187-903d-4142-8031-d9492b4a7ce3) |
|              |                  |             |                                                                                 |                                                                                                            |
|              |                  |             |                                                                                 |                                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Load()       | Null             | Void        | Displays the Load Dialogue Box to load the DiagramPage from selected XAML file. | [**[Load Diagram Page]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=ce1920b1-edfc-4766-a86c-14070a3538a3) |
|              |                  |             |                                                                                 |                                                                                                            |
|              |                  |             |                                                                                 |                                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Load(string) | String           | Void        | Loads the DiagramPage from the file name mentioned.                             | [**[Load Diagram Page]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=811f5856-a1ee-4549-a012-21d07248b4b6) |
|              |                  |             |                                                                                 |                                                                                                            |
|              |                  |             |                                                                                 |                                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+
| Load(Stream) | System.IO.Stream | Void        | Loads the DiagramPage from the memory stream.                                   | [**[Load Diagram Page]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=2e9614fb-e36a-4d40-be08-adb30a37211c) |
|              |                  |             |                                                                                 |                                                                                                            |
|              |                  |             |                                                                                 |                                                                                                            |
+--------------+------------------+-------------+---------------------------------------------------------------------------------+------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 This process is explained in the following topic:

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Save Diagram Page](ms-xhelp:///?Id=9d78f488-830d-48f8-acd3-c828500b3689){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Loading the Diagram Page](ms-xhelp:///?Id=bbc3dee0-4fa5-47a7-8f0d-11ea989af3d7){style="TEXT-DECORATION: none"}
::::
