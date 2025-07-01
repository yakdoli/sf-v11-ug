::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=da6429bd-4ff5-4756-b503-ae7eecff11e0){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=67416cf0-23e4-44c3-8bda-a98e0f16a85e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Exporting](ms-xhelp:///?Id=cae2e093-41c5-4375-a1a0-3822fc84dd51){.d2h_breadcrumbsNormal}
:::

### Properties {#properties style="tab-stops: 0pt"}

Exporting Grid to PDF and Word are two different actions that require slightly different properties, methods, and events.

Properties to be used for PDF Export

 

+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+
| Property            | Description                                                | Type of property | Value it accepts                                | Dependencies                  |
+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+
| FileName            | Returns the name of the exported PDF file                  | String           | Any type of String                              | NA                            |
+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+
| PdfVersion          | Gets or sets the version of the PDF Document               | PdfVersion       | [PdfVersion]{style="COLOR: #2b91af"}.Version1_1 | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | [PdfVersion]{style="COLOR: #2b91af"}.Version1_2 |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | [PdfVersion]{style="COLOR: #2b91af"}.Version1_3 |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | [PdfVersion]{style="COLOR: #2b91af"}.Version1_4 |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | [PdfVersion]{style="COLOR: #2b91af"}.Version1_5 |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | [PdfVersion]{style="COLOR: #2b91af"}.Version1_6 |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | [PdfVersion]{style="COLOR: #2b91af"}.Version1_7 |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  |                                                 |                               |
+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+
| ConverterOptionsExt | Returns the exporting options                              | Enum             | All                                             | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | Visible                                         |                               |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  |                                                 |                               |
+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+
| ExportNestedTables  | Specifies whether nested tables can be exported            | bool             | True                                            | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | False                                           |                               |
+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+
| UseAutoFormat       | Specifies whether you can use the in-built styles for Grid | bool             | True                                            | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                  |                                                 |                               |
|                     |                                                            |                  | False                                           |                               |
+---------------------+------------------------------------------------------------+------------------+-------------------------------------------------+-------------------------------+

 

Properties to be used for Word Export

 

+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+
| **Property**        | **Description**                                            | **Type of property** | **Value it accepts**                               | **Dependencies**              |
+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+
| FileName            | Returns the name of the exported PDF file                  | String               | Any type of String                                 | NA                            |
+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+
| WordVersion         | Gets or sets the version of the Word Document              | DocumentVersion      | [DocumentVersion]{style="COLOR: #2b91af"}.Word2000 | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      | [DocumentVersion]{style="COLOR: #2b91af"}.Word2002 |                               |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      | [DocumentVersion]{style="COLOR: #2b91af"}.Word2003 |                               |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      | [DocumentVersion]{style="COLOR: #2b91af"}.Word2007 |                               |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      |                                                    |                               |
+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+
| ConverterOptionsExt | Returns the exporting options                              | Enum                 | All                                                | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      | Visible                                            |                               |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      |                                                    |                               |
+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+
| ExportNestedTables  | Specifies whether nested tables can be exported            | bool                 | True                                               | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      | False                                              |                               |
+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+
| UseAutoFormat       | Specifies whether you can use the in-built styles for Grid | bool                 | True                                               | NA[]{style="FONT-SIZE: 11pt"} |
|                     |                                                            |                      |                                                    |                               |
|                     |                                                            |                      | False                                              |                               |
+---------------------+------------------------------------------------------------+----------------------+----------------------------------------------------+-------------------------------+

 

[]{#related-topics}
::::
