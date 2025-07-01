::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e9048ca4-69d2-4f96-8fd1-485b2c954250){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1aae38f0-3087-4c09-93d7-c9d71d530fd6){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Tables for Properties, Methods, and Events {#tables-for-properties-methods-and-events style="TEXT-ALIGN: justify; tab-stops: 0pt"}

Properties

Table 9: FilterBar Support Table

  ---------------------------------- -------------------------------------------------------------------------------------------------- ------------------------------------------ ------------------ ------------------------------------------
  Property                           Description                                                                                        Data Type                                  Default Value      Class Name
  PivotControl                       Gets or sets the PivotAnalysis (IPivotControl) control.                                            IPivotControl                              null                
  CustomSummaryBaseCollection        Gets or sets the CustomSummaryBaseCollection to use in the Pivot Computation Information dialog.   Enum                                       Count              SummaryType
  ShowDisplayFieldsOnly              Gets or sets a value indicating whether to show only DisplayFields.                                bool                                       false               
  PivotTableFieldList                Gets or sets the PivotTableField ListBox.                                                          ListBox                                    ListBox            ListBox
  PivotCalculationList               Gets or sets the PivotCalculation ListBox.                                                         ListBox                                    ListBox            ListBox
  PivotColumnList                    Gets or sets the PivotColumn ListBox.                                                              ListBox                                    ListBox            ListBox
  PivotRowList                       Gets or sets the PivotRow ListBox.                                                                 ListBox                                    ListBox            ListBox
  FilterList                         Gets or sets the Filters Listbox.                                                                  ListBox                                    ListBox            ListBox
  ShowCalculationsAsColumnCheckBox   Gets or sets the ShowCalculationAsColumn CheckBox.                                                 Checkbox                                   Checkbox (true)    Checkbox
  DeferLayoutUpdateCheckBox          Gets or sets the DeferLayoutUpdate check box.                                                      Checkbox                                   Checkbox (false)   Checkbox
  DeferLayoutUpdateButton            Gets or sets the DeferLayoutUpdate button.                                                         Button                                     Button             Button
  Filters                            Gets or sets the filters collection.                                                               ObservableCollection\<FilterExpression\>   null               ObservableCollection\<FilterExpression\>
  PivotTableFields                   Gets or sets the PivotTableFields.                                                                 ObservableCollection\<PivotTableField\>    null               ObservableCollection\<PivotTableField\>
  ---------------------------------- -------------------------------------------------------------------------------------------------- ------------------------------------------ ------------------ ------------------------------------------

[]{#_Tokens_to_filter} 

Events

Table 10: Pivot Schema Designer Events Table

  ---------------- ------------------------------------------------------------------- ----------- ---------------
  Events           Description                                                         Data Type   Default Value
  CommandExecute   Raises whenever a command is executed in the PivotSchemaDesigner.   Event       null
  ---------------- ------------------------------------------------------------------- ----------- ---------------

[]{style="COLOR: black"} 

[]{#related-topics}
:::
