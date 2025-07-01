::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=bab41b6b-af10-4152-ba93-e7607768f28d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=58511398-be59-4b55-8c08-ee7c230ab241){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f61feb80-1940-4b18-ab36-1ab89df8b52a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[EditControl Members](ms-xhelp:///?Id=bb3fd9ce-59ed-4640-90f7-21692312ce10){.d2h_breadcrumbsNormal}
:::

### Methods {#methods style="tab-stops: 0pt"}

The following table lists the methods available in EditControl class and its purpose.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 6: EditControl Methods

::: {align="center"}
  ---------------------------------- --------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Methods                            Type      Description
    ExpandLine(int index)            Void      Expands a line, index in the argument refers the index of the line to be expanded (0 based value).
  ExpandLineUpTopLevel(int index);   Void      Expands  a line and its parent line up to top most level. Index in the argument refers to the index of the line to be expanded (0 based value).
  GetTextRange(int start, int end)   String    Returns the text between start and end lines. Start and End denotes the index of the Start and End lines (0 based values).
  LoadFile()                         Boolean   **LoadFile** method is used to open a file in the EditControl. It shows up a **OpenFileDialog** in order for the users to select the file to be opened using EditControl and returns a **bool** value stating whether file open was successful.
  LoadFile(string filename)          Boolean   This method does not display **OpenFileDialog** and loads the file specified as the parameter of the method. It returns a **boo**l value stating the file open was successful.
  SaveFile()                         Boolean   Save method is used to save the text in the EditControl under a file name with different supported file types.
  ---------------------------------- --------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

[]{#p14} 

 

[]{#related-topics}
:::::
