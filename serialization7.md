::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=60ab91a5-d78d-452c-9a9c-762cb34acc8b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=66711bb0-e714-454f-b06e-1b3b111d6845){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}
:::

## Serialization {#serialization style="tab-stops: 0pt"}

Serialization is the process of saving and retrieving Essential Diagram (for MVC and SL) which supports saving the diagram page as an XML file. The page and all its properties get saved in the process.\
On loading, the page gets loaded in the current view with all its nodes and connections. The users can continue working on their page while loading the appropriate XML file.

Use Case Scenario

This load and save feature allows the user to save their diagram page for future use.

 

Limitations of using the Save and Load feature for diagrams from Silverlight

This feature doesn't have any significant limitations in MVC, but there are a few that show up when you try to save and load diagrams from Silverlight, as given below:

1.   Content other than shapes (images, buttons etc.) from Silverlight will not be supported in the diagram page in MVC. This means content that you save or load from SL will not work in MVC diagram, unless they are shapes.

2.   The stretch option for SL is not supported in diagram MVC. This means that if you had formatted you shapes in SL, and loaded or saved the shape to diagram MVC, the changes will be discarded and only the original shape will be usable.

3.   In order to use custom shapes and save, or load them in diagram from SL, you will have to use the path name of the required custom shape. In case you retrieve the path name using the namespace attributes, the shape will not be loaded, or saved.

 

Where do I find the installed samples?

[To view the samples:]{style="BACKGROUND: white"}

1.   [Open the Essential Diagram sample browser from the Dashboard. (Refer to the Samples and Locations section).]{style="BACKGROUND: white"}

2.   [Go to the **Getting Started** tab, and click **Serialization**.]{style="BACKGROUND: white"}

 

Methods

+-------------------+-----------------------------------------------------------------------+-------------------------------------------------+-------------+--------------+
| Method            | Description                                                           | Parameters                                      | Type        | Return Type  |
+-------------------+-----------------------------------------------------------------------+-------------------------------------------------+-------------+--------------+
| Save              | Saves the diagram page into an XML file whose file name is specified. | String file name                                | Server Side | ActionResult |
+-------------------+-----------------------------------------------------------------------+-------------------------------------------------+-------------+--------------+
| Save              | Saves the diagram page into memory stream.                            | [System.IO.Stream stream]{style="COLOR: black"} | Server Side | ActionResult |
|                   |                                                                       |                                                 |             |              |
|                   | This method is not applicable for diagrams in Silverlight.            |                                                 |             |              |
+-------------------+-----------------------------------------------------------------------+-------------------------------------------------+-------------+--------------+
| Load              | Loads the diagram page from the file name mentioned.                  | String file name                                | Server Side | Void         |
+-------------------+-----------------------------------------------------------------------+-------------------------------------------------+-------------+--------------+
| Load              | Loads the diagram page from the memory stream.                        | [System.IO.Stream stream]{style="COLOR: black"} | Server Side | void         |
|                   |                                                                       |                                                 |             |              |
|                   | This method is not applicable for diagrams in SL.                     |                                                 |             |              |
+-------------------+-----------------------------------------------------------------------+-------------------------------------------------+-------------+--------------+
| LoadCommonDiagram | Loads the Silverlight diagram page from the file name mentioned.      | String file name                                | Server Side | Void         |
+===================+=======================================================================+=================================================+=============+==============+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enabling Serialization in Diagram](ms-xhelp:///?Id=66711bb0-e714-454f-b06e-1b3b111d6845){style="TEXT-DECORATION: none"}
::::
