::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=441b2158-da5c-43b5-b68f-50f7a875de26){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=047f69d5-ab2d-4e07-b982-3ccfb62750d8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Features](ms-xhelp:///?Id=4ae10797-e3a8-4270-b8ba-34441d2e1a3d){.d2h_breadcrumbsNormal}
:::

## Dynamic Connection {#dynamic-connection style="tab-stops: 0pt"}

Dynamic Connection enables an OlapClient to connect different servers at run time. Therefore, report manipulation for different servers can be done consequently rather than closing and re-initializing the process.

The Dynamic Connection Option facilitates the following:

[·      ]{style="FONT-FAMILY: Symbol"}Connecting different SSAS (SQL Server Analysis Service) or XMLA (XML for Analysis Service) (for example, Mondrian server) through well-formed connection strings.

[·      ]{style="FONT-FAMILY: Symbol"}Passes the encrypted string for tightly coupled connection strings by providing an option to encrypt the string using a private key.

[·      ]{style="FONT-FAMILY: Symbol"}It is not necessary to close the existing client connection to connect a new server.

 

Use Case Scenarios

The user can manipulate an OlapReport for different servers dynamically by a client control at run time.

 

Tables for Properties, Methods, and Events

Properties

Table 9: Property Table

::: {align="center"}
  Property                                             Description                                                                       Type                                    Data Type                            Reference links
  ---------------------------------------------------- --------------------------------------------------------------------------------- --------------------------------------- ------------------------------------ -------------------------------
  ConnectionString                                     Gets or sets the connection string for an OlapClient[]{style="FONT-SIZE: 12pt"}   Dependency[]{style="FONT-SIZE: 12pt"}   String[]{style="FONT-SIZE: 12pt"}    \-[]{style="FONT-SIZE: 12pt"}
  EnabledConnectionOption[]{style="FONT-SIZE: 12pt"}   To show or hide the connection option button[]{style="FONT-SIZE: 12pt"}           Dependency[]{style="FONT-SIZE: 12pt"}   Boolean[]{style="FONT-SIZE: 12pt"}   \-[]{style="FONT-SIZE: 12pt"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Methods

Table 10: Method Table

::: {align="center"}
+----------------------------------------+-------------------------------------------------------------------------------------------------------------+------------------------------------------------------+----------------------------------+---------------------------------+-------------------------------+
| Method                                 | Description                                                                                                 | Parameters                                           | Type                             | Return Type                     | Reference links               |
+----------------------------------------+-------------------------------------------------------------------------------------------------------------+------------------------------------------------------+----------------------------------+---------------------------------+-------------------------------+
| UpdateConnection                       | Updates the Client's connection with the specified connection string[]{style="FONT-SIZE: 12pt"}             | (string connectionString)[]{style="FONT-SIZE: 12pt"} | **-**[]{style="FONT-SIZE: 12pt"} | Void[]{style="FONT-SIZE: 12pt"} | \-[]{style="FONT-SIZE: 12pt"} |
|                                        |                                                                                                             |                                                      |                                  |                                 |                               |
|                                        |                                                                                                             |                                                      |                                  |                                 |                               |
+----------------------------------------+-------------------------------------------------------------------------------------------------------------+------------------------------------------------------+----------------------------------+---------------------------------+-------------------------------+
| ResetClient[]{style="FONT-SIZE: 12pt"} | Resets the client( i.e., clears the Client's current server related information)[]{style="FONT-SIZE: 12pt"} | \-[]{style="FONT-SIZE: 12pt"}                        | **-[]{style="FONT-SIZE: 12pt"}** | Void[]{style="FONT-SIZE: 12pt"} | \-[]{style="FONT-SIZE: 12pt"} |
+========================================+=============================================================================================================+======================================================+==================================+=================================+===============================+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

 

Windows 7/Vista:

 

SystemDrive:\\Users\\\<user_name\>\\AppData\\Local\\Syncfusion\\EssentialStudio\\\<version_number\>\\BI\\Silverlight\\OlapClient.SL\\DynamicConnection

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

Windows XP:

 

SystemDrive:\\Syncfusion\\EssentialStudio\\\<version_number\>\\BI\\Silverlight\\OlapClient.SL\\DynamicConnection

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enabling the Dynamic Connection Option in an Application](ms-xhelp:///?Id=047f69d5-ab2d-4e07-b982-3ccfb62750d8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Creating New Session or Server Connection](ms-xhelp:///?Id=fa83d9bf-1cc4-4268-9c36-4a2ab8ccc72a){style="TEXT-DECORATION: none"}
::::::
