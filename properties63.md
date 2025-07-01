::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=bb3fd9ce-59ed-4640-90f7-21692312ce10){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7b1df866-3d05-42cb-864d-eab6d168ad22){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=f61feb80-1940-4b18-ab36-1ab89df8b52a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[EditControl Members](ms-xhelp:///?Id=bb3fd9ce-59ed-4640-90f7-21692312ce10){.d2h_breadcrumbsNormal}
:::

### Properties {#properties style="tab-stops: 0pt"}

The following table illustrates the properties in EditControl and its usages[.]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Table 5: EditControl Properties

::: {align="center"}
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Name of the Property          | Type                  | Description                                                                                                                                                                               |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| AcceptsTab                    | Boolean               | Gets or sets a **bool** property to allow or restrict the usage of **TAB key**in EditControl.                                                                                             |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| AssemblyReferences            | IEnumberable\<Uri\>   | Gets or sets a collection of type Uri, this property enables the users to specify the path of assemblies from EditControl should fetch **Intellisense** items automatically.              |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CurrentLanguage               | LanguageBase          | Gets a **LanguageBase** instance based on the **DocumentLanguage** property.                                                                                                              |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CursorIndex                   | Int                   | Gets current index of text where the cursor is located in EditControl pane.                                                                                                               |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CustomLanguage                | LanguageBase          | Gets or sets an instance of **LanguageBase** type indicating the custom language.                                                                                                         |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DocumentLanguage              | Languages             | Gets or sets Language for the text in EditControl. Syntax highlighting and outlining of text in EditControl are performed based on the language set using this property                   |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DocumentSource                | string                | Gets or sets source for EditControl. The filename specified will be loaded in the EditControl.                                                                                            |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EnableIntellisense            | Boolean               | Gets or sets a value indicating whether **Intellisense** is enabled in this instance of EditControl.                                                                                      |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EnableOutlining               | Boolean               | Gets or sets a value indicating whether Outlining of text in EditControl should be applied.                                                                                               |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindOptions                   | FindOptions           | Gets or sets an instance of **FindOptions** indicating the options selected in the **FindReplace** Window.                                                                                |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindResultsTabHeight          | Double                | Gets or sets a value indicating desired height of the find results tab.                                                                                                                   |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindResultsTabVisibility      | TabVisibility         | Gets or sets a value indicating the Visibility mode of the find results tab. **TabVisibility** is enum type containing values such as Auto, Visible and Collapsed.                        |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| HorizontalScrollBarVisibility | ScrollBarVisibility   | Gets or sets a value indicating Visibility of Horizontal **ScrollBar**. By default, it is set to Auto, wherein the **ScrollBa**r will be visible when required.                           |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IntellisenseBoxStyle          | Style                 | Gets or sets a Style to be applied to **IntelliSense listbox.**                                                                                                                           |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IntellisenseCustomItemsSource | IEnumerable           | Gets or sets a collection of business object inherited from **IIntellisenseItem** to be dispalyed in the **IntellisenseBox.**                                                             |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IntellisenseItemTemplate      | DataTemplate          | Gets or sets a **DataTemplate** to be applied to an **IntellisenseBox.**                                                                                                                  |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IntellisenseMode              | IntellisenseMode      | Gets or sets a value indicating the **intellisense** mode. It supports two modes viz, Auto and Custom.                                                                                    |
|                               |                       |                                                                                                                                                                                           |
|                               |                       | [·      ]{style="FONT-FAMILY: Symbol"}In Auto mode, intellisense items are auto generated based on the language **lexems,** assembly references included.                                 |
|                               |                       |                                                                                                                                                                                           |
|                               |                       | [·      ]{style="FONT-FAMILY: Symbol"}                                                                                                                                                    |
|                               |                       |                                                                                                                                                                                           |
|                               |                       | [·      ]{style="FONT-FAMILY: Symbol"}In the Custom mode, users have to set the **IntellisenseCustomItemsSource** property to specify the items to be displayed in the intellisense.      |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IntellisensePopupHeight       | Double                | Gets or sets a value indicating desired height of the Intellisense popup.                                                                                                                 |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IntellisensePopupWidth        | Double                | Gets or sets a value indicating desired width of Intellisense Popup.                                                                                                                      |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsFindResultsTabClosed        | Boolean               | Gets or sets a value indicating whether the Find Results Tab is closed or not. This property has a value **true** if the find results tab in the EditControl is closed; otherwise, false. |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsReadOnly                    | Boolean               | Gets or sets a value indicating whether read only mode is enabled or not.                                                                                                                 |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsRedoEnabled                 | Boolean               | Gets or sets a value indicating whether this instance supports Redo operation or not.                                                                                                     |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| IsUndoEnabled                 | Boolean               | Gets or sets a value indicating whether this instance supports Undo operation or not.                                                                                                     |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| LineHeight                    | Double                | Gets and sets the height of each line in EditControl.                                                                                                                                     |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| LineNumber                    | Int                   | Gets the line number where the cursor is currently located.                                                                                                                               |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Lines                         | LinesCollection       | Gets the collection of lines in EditControl.                                                                                                                                              |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SearchResults                 | SearchResults         | Get or sets a value indicating the Search results.                                                                                                                                        |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SelectedText                  | String                | Gets a value indicating the selected text of EditControl.                                                                                                                                 |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowDefaultContextMenu        | Boolean               | Gets or sets a value indicating whether built-in context menu should be displayed.                                                                                                        |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowFindAndReplace            | Boolean               | Gets or Sets a value indicating whether find and replace functionality to enabled or not.                                                                                                 |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ShowLineNumber                | Boolean               | Gets or sets a value indicating whether line number to be displayed or not. Set this to **True** to display the Line number. Default value is true.                                       |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TabSpaces                     | Int                   | Gets or sets a value indicating the number of spaces to include when the tab key is pressed.                                                                                              |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Text                          | String                | Gets or sets a value indicating text in EditControl.                                                                                                                                      |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| VerticalScrollBarVisibility   | ScrollBarVisibility   | Gets or sets a value indicating Visibility of Vertical **ScrollBar**. By default, it is set to Auto, wherein the **ScrollBar** will be visible when required.                             |
+-------------------------------+-----------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

[]{#p13} 

 

[]{#related-topics}
:::::
