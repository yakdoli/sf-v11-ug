::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c4989e9a-ca5f-4ba5-8638-b8c5518361b4){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=06d53ef1-93c3-4a6d-a19c-bdc0ef06ee5c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}
:::

## Editing {#editing style="tab-stops: 0pt"}

 

Essential Grid has built-in support for editing grid content. This can be achieved by defining a **GridEditing** class for the grid. Using this class, you can specify the action mappers for insert, edit, update, delete, and cancel requests.

Key Features

The key features of editing are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}Allows three modes of editing such as inline row editing, inline form editing, and inline custom template form editing.

[·      ]{style="FONT-FAMILY: Symbol"}Enables MVC 2.0 client validation.

[·      ]{style="FONT-FAMILY: Symbol"}Provides toolbar support for editing records.

 

Properties

 

::: {align="center"}
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| Property               | Description                                                                 | Type of property       | Value it accepts      | Any other dependencies/sub-properties associated |
+========================+=============================================================================+========================+=======================+==================================================+
| Editing                | Gets or sets the editing properties for the Grid control.                   | Class                  | NA                    | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| AllowNew               | Used to enable or disable the insert action in the editing mode.            | bool                   | True/False            | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| AllowEdit              | Used to enable or disable the edit action in the editing mode.              | bool                   | True/False            | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| AllowDelete            | Used to enable or disable the delete action in the editing mode.            | bool                   | True/False            | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| DeleteMapper           | Gets or sets the action mapper for the delete action.                       | string                 | Delete action name    | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| InsertMapper           | Gets or sets the action mapper for the insert actions.                      | string                 | Insert action name    | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| GridSaveMapper         | Gets or sets the action mapper for the update action.                       | string                 | Save action name      | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| EditMode               | Gets or sets the edit mode for editing.                                     | Enum                   | Normal                | NA                                               |
|                        |                                                                             |                        |                       |                                                  |
|                        |                                                                             |                        | InlineForm            |                                                  |
|                        |                                                                             |                        |                       |                                                  |
|                        |                                                                             |                        | InlineTemplateForm    |                                                  |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| FormModeEditorTemplate | Gets or sets the partial view name for the InlineTemplateForm mode editing. | string                 | Any partial view name | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| Toolbar                | Gets or sets the toolbar for grid.                                          | Class                  | NA                    | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| Enable                 | Used to enable or disable the toolbar in grid.                              | Bool                   | True/False            | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| Items                  | Used to add the items to grid toolbars.                                     | List\<ToolbarOptions\> | Any toolbar items     | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
| AllowEditing           | Gets or sets the particular column enabling and disabling editing.          | Bool                   | True/False            | NA                                               |
+------------------------+-----------------------------------------------------------------------------+------------------------+-----------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following table illustrates the default **CellEditTypes** and their corresponding controls for specific data types.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

::: {align="center"}
  ----------- --------------------------- --------------------------------------------------------
  Data Type   Default CellEditType        Control
  String      CellEditType.StringEdit     TextBox control
  Boolean     CellEditType.BooleanEdit    CheckBox control
  Integer     CellEditType.NumericEdit    NumericTextBox control
  Decimal     CellEditType.NumericEdit    NumericTextBox control with default two decimal digits
  Double      CellEditType.NumericEdit    NumericTextBox control with default two decimal digits
  Date-time   CellEditType.DateTimeEdit   DatePicker control
  ----------- --------------------------- --------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Methods

 

::: {align="center"}
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| Method                                                | Parameters                            | Return type                 | Description                                                                                                     |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| Editing (Action\<IEditingBuilder\<T\>\> editing)      | Action\<IEditingBuilder\<T\>\>        | IGridBuilder\<T\>           | Used to configure the editing mode.                                                                             |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| AllowNew(bool allowDelete, string mapperName)         | Bool ,string                          | IEditingBuilder\<T\>        | Used to configure the **Add New** action in the editing mode.                                                   |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             | Used to set the mapper name and enable or disable the **Add New** action.                                       |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| AllowEdit(bool allowEdit, string mapperName)          | Bool ,string                          | IEditingBuilder\<T\>        | Used to configure the **Edit** action in the editing mode.                                                      |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             | Used to set the mapper name and to enable or disable the **Edit** action.                                       |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| AllowDelete(bool allowDelete, string mapperName)      | Bool ,string                          | IEditingBuilder\<T\>        | Used to configure the **Delete** action in the editing mode.                                                    |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             | Used to set the **mapperName** and enable or disable the **Delete** action                                      |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| EditMode(GridEditMode editMode)                       | GridEditMode                          | IEditingBuilder\<T\>        | Used to configure the grid's editing mode. Set any editing mode from an enum collection. Default is **Normal**. |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| FormModeEditorTemplate(string editmodeTemplate)       | String partialview name               | IEditingBuilder\<T\>        | Used to set the partial view name in the inline template form editing mode.                                     |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| PrimaryKey(Action\<IGridPrimaryKeyBuilder\<T\>\> key) | Action\<IGridPrimaryKeyBuilder\<T\>\> | IEditingBuilder\<T\>        | Used to add primary keys to grid which are used in the editing mode to uniquely identify the record.            |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| CloseOnEscape(bool enable)                            | Bool                                  | IEditingBuilder\<T\>        | Used to enable or disable the ESC key event in cancel request through the keyboard.                             |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| SaveOnEnter(bool enable)                              | Bool                                  | IEditingBuilder\<T\>        | Used to enable or disable the ENTER key event for raise the save request through the keyboard.                  |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| Add(Expression\<Func\<T, object\>\> expression)       | Expression                            | IGridPrimaryKeyBuilder\<T\> | Used to add primary keys to the grid.                                                                           |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| ToolBar(Action\<IToolBarBuilder\> toobar)             | Action\<IToolbarbuilder\> toolbar     | IEditingBuilder\<T\>        | Used to configure the toolbar in the editing mode.                                                              |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| Add(GridToolBarItems item)                            | GridToolBarItems                      | IToolBarBuilder             | Used to add a toolbar item to grid.                                                                             |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| Add(GridToolBarItems item, string caption)            | GridToolBarItems, string              | IToolBarBuilder             | Used to add a toolbar item with a caption.                                                                      |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
| EnableToolbar(bool enable)                            | Bool                                  | IToolBarBuilder             | Used to enable or disable the toolbar in the grid.                                                              |
|                                                       |                                       |                             |                                                                                                                 |
|                                                       |                                       |                             |                                                                                                                 |
+-------------------------------------------------------+---------------------------------------+-----------------------------+-----------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=06d53ef1-93c3-4a6d-a19c-bdc0ef06ee5c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=a904fe43-26c8-49bd-9fdc-cbb93bfa702e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}CellEditType](ms-xhelp:///?Id=60d4e885-c23e-4d25-82bc-c0e48627dbb6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}EditableOrder Class](ms-xhelp:///?Id=e99ec62d-9bac-496c-80cf-c65154e3d149){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}OrderRepository Class](ms-xhelp:///?Id=a1e9828c-aec8-4210-b7da-d643fd70fe5e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Excel-Like Editing in MVC Grid](ms-xhelp:///?Id=8ec2774c-5b36-4eed-bd04-83f7c6e98721){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Dialog editing in MVC Grid](ms-xhelp:///?Id=f672fb9b-47fe-4035-beb0-ff6b45d7774c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}External Form Edit Mode](ms-xhelp:///?Id=f107da84-15e1-4b81-be1b-cb02833496ae){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Unbound Column Editing](ms-xhelp:///?Id=38f2e995-3847-457c-b724-d752828043a7){style="TEXT-DECORATION: none"}
:::::::
