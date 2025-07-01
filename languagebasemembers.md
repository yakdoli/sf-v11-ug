::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=de8e7df8-c35c-4973-9bd8-8a1a0390070e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4d03beb4-80c7-4824-8f25-d3c92bd8051b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f61feb80-1940-4b18-ab36-1ab89df8b52a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Language Support](ms-xhelp:///?Id=25124e73-46d4-4eee-a5bb-f3c15c93e5b4){.d2h_breadcrumbsNormal}
:::

###   LanguageBase Members  {#languagebase-members style="tab-stops: 0pt"}

LanguageBase class in Syncfusion.Windows.Edit namespace plays a vital role in the implementation of language support in EditControl. In order to include a support for a new or custom language, a class inherited from LanguageBase or its sub classes need to be implemented. LanguageBase contains a number of properties and methods to enable the custom language developers configure their languages easily. This topic discusses about the properties and methods available in the LanguageBase class.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

Properties

The following table lists the properties available in LanguageBase class and its usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 9: LanguageBase Properties

::: {align="center"}
  ----------------------------------- ------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property Name                       Type          Description
  ApplyColoring                       Boolean       Gets or sets a value indicating if the language supports syntax highlighting.
  BlockEnd                            String        Gets or sets a value indicating the end text that denotes end of a block in code.
  BlockStart                          String        Gets or sets a value indicating the start text that denotes start of a block in code.
  CaseSensitive                       Boolean       Gets or sets a value indicating whether the Language has case sensitive or not.
  CommitsIntellisenseItemOnSpaceBar   Boolean       Gets or sets a value indicating whether the selected intellisense items to be appended when space bar is pressed.
  EllipsisText                        String        Gets or sets a value indicating the text to be displayed when a block is collapsed. By default its set to \"\...\".
  FileExtension                       String        Gets or sets File Extension supported by the language.
  Formats                             IEnumerable   Gets or Sets a collection of type of IFormat indicating the language configurations. It has been modified to IEnumerable type to allow the users to binding a custom collection as language formats.
  IntellisenseCommitCharacters        String        Gets or sets a value indicating when the selected intellisense items to be appended. The string given will be converted to individual characters internally and verified to append the selected item to text.
  IntellisenseDrillDownChar           Char          Gets or sets a value indicating a char on which the sub-items of the intellisense items to displayed.
  IsSplitTextToWords                  Boolean       Gets or sets a value indicating if the text in lines has to be spitted in to tokens.
  Lexem                               IEnumerable   Gets or Sets a collection of type of ILexem indicating the language configurations. It has been modified to IEnumerable type to allow the users to binding a custom collection as language lexems.
  Name                                String        Gets or sets Name of the Language.
  ParentControl                       EditControl   Gets a value indicating the parent EditControl's reference.
  SplitLinesRegex                     String        Gets or sets a value indicating the Regex to be applied for splitting the text in lines.
  SplitWordsRegex                     String        Gets or sets a value indicating the Regex to be applied for splitting the lines into individual tokens.
  SupportsIntellisense                Boolean       Gets or sets a value indicating whether the language supports IntelliSense or not.
  SupportsOutlining                   Boolean       Gets or Sets a value indicating whether the language supports outlining.
  TextForeground                      Brush         Gets or sets foreground brush to be applied when no Lexems are applicable for the text.
  ----------------------------------- ------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Methods

The following table lists the methods available in LanguageBase class and its purpose.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 10: LanguageBase Methods

::: {align="center"}
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Method                                             | Return Type           | Description                                                                                                                                                                                                                                                                                                        |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ApplyColor(string text, int line);                 | IFormat               | Helper method to apply coloring to the text based on the Lexems in the Language configurations. It is a protected method and can be overridden in the sub classes. The method is used to manipulate the Format to be applied to a particular token in a line.                                                      |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ApplyExpandCollapse(ApplyExpandCollapseArgs args)  | Void                  | Helper method for perform expand collapse for line items. This method can be overridden if custom expand collapse logics has be implemented. This method runs in a background thread to overcome performance hits, usage of any properties and methods outside the scope of the thread may result in an exception. |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ApplyExpandItems()                                 | Void                  | Helper method to Apply Expansions for the content in the EditControl. This method can be called if the expand collapse has to be refreshed for entire text in EditControl.                                                                                                                                         |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| HideIntellisensePopup()                            | Void                  | Method to Hide Intellisense Popup.                                                                                                                                                                                                                                                                                 |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| InitializeExpandCollapse()                         | Void                  | This method can gets called before the ApplyExpandCollapse and can be used to perform any initialization operations.                                                                                                                                                                                               |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| PositionIntellisensePopup(int line, int index)     | Void                  | Method to adjust the position of the intellisense box. Line value in parameter                                                                                                                                                                                                                                     |
|                                                    |                       |                                                                                                                                                                                                                                                                                                                    |
|                                                    |                       | represents the line number (starts of 0)                                                                                                                                                                                                                                                                           |
|                                                    |                       |                                                                                                                                                                                                                                                                                                                    |
|                                                    |                       | and index in the parameter                                                                                                                                                                                                                                                                                         |
|                                                    |                       |                                                                                                                                                                                                                                                                                                                    |
|                                                    |                       | represents the cursor index                                                                                                                                                                                                                                                                                        |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| RefreshExpandItems(int line)                       | Void                  | Helper method to refresh lines expansions from a specified line number. Line value in parameter refers to the index (starts from 0)                                                                                                                                                                                |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowIntellisenseBox(EditIntellisenseArgs args)     | Void                  | Helper method to Show the Intellisense popup.                                                                                                                                                                                                                                                                      |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SplitTextToLines()                                 | Void                  | A helper method to split the text in the EditControl in to individual lines.                                                                                                                                                                                                                                       |
+----------------------------------------------------+-----------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{#related-topics}
::::::
