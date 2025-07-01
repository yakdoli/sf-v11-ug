::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=60c24963-35c5-41f5-87b6-5bb4e2f1b409){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=23ce1683-c6f7-4f95-b32f-923ceb0fc2d1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}
:::

## Serialization {#serialization style="tab-stops: 0pt"}

 

[]{#p101}Serialization is the process of saving and retrieving the Essential Diagram file. Essential Diagram Silverlight supports saving the diagram page as an XAML file. The page and all its properties get saved. On loading, the page gets loaded in the current view with all its nodes and connections. This load and save feature allows the user to save their diagram page for future use. The users can continue working on their page by loading the appropriate XAML file.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Methods[:]{style="FONT-SIZE: 9pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+
| Name         | Parameters       | Return Type | Description                                                                        | Reference Links   |
+==============+==================+=============+====================================================================================+===================+
| Save()       | Null             | Void        | Displays the Save Dialogue Box to save the DiagramPage into xaml file              | Save Diagram Page |
|              |                  |             |                                                                                    |                   |
|              |                  |             |                                                                                    |                   |
+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+
| Save(string) | String           | Void        | Saves the DiagramPage into  xaml file whose file name is specified.                | Save Diagram Page |
|              |                  |             |                                                                                    |                   |
|              |                  |             |                                                                                    |                   |
+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+
| Save(Stream) | System.IO.Stream | Void        | Saves the DiagramPage into memory stream                                           | Save Diagram Page |
|              |                  |             |                                                                                    |                   |
|              |                  |             |                                                                                    |                   |
+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+
| Load()       | Null             | Void        | Displays the Load Dialogue Box to load the DiagramPage from the selected xaml file | Load Diagram Page |
|              |                  |             |                                                                                    |                   |
|              |                  |             |                                                                                    |                   |
+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+
| Load(string) | String           | Void        | Loads the DiagramPage from the file name mentioned.                                | Load Diagram Page |
|              |                  |             |                                                                                    |                   |
|              |                  |             |                                                                                    |                   |
+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+
| Load()       | System.IO.Stream | Void        | Loads the DiagramPage from the memory stream                                       | Load Diagram Page |
|              |                  |             |                                                                                    |                   |
|              |                  |             |                                                                                    |                   |
+--------------+------------------+-------------+------------------------------------------------------------------------------------+-------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 This process is explained in the following topic:

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Save Diagram Page](ms-xhelp:///?Id=23ce1683-c6f7-4f95-b32f-923ceb0fc2d1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Loading the Diagram Page](ms-xhelp:///?Id=76ddac97-6996-40b0-b2b9-9de158358f89){style="TEXT-DECORATION: none"}
::::
