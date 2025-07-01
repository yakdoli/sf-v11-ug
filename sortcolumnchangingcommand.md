::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### SortColumnChangingCommand {#sortcolumnchangingcommand style="tab-stops: 0pt"}

SortColumnChangingCommand allows customizing the sort columns at run time and this command get hooked before the column is sorted. SortColumnsChanging event accepts an argument of type GridDataSortColumnsChangingEventArgs. The GridDataSortColumnsChangingEventArgs contains the following customization properties. Now you can make use of this

  ------------------------------- ----------------------------------------------------------------------------------------------
  Property                        Description
  AddedItems                      Gives the Collection of GridDataSortColumns that are newly added to the GridDataControl.
  RemovedItems                    Gives the Collection of GridDataSortColumns that are removed from the GridDataControl.
  NotifyCollectionChangedAction   Gives the Action that are going to perform in the SortColumns Collection in GridDataControl.
  ------------------------------- ----------------------------------------------------------------------------------------------

 

Properties

Table 45: Property Table

::: {align="center"}
  --------------------------- -------------------------------------------------------------------------------- --------------------- ----------- -----------------
  Property                    Description                                                                      Type                  Data Type   Reference links
  QueryCellInfoCommand        Gets or sets the command to invoke when QueryCellInfo event is triggered.        Dependency Property   ICommand     
  SortColumnChangingCommand   Gets or sets the command to invoke when SortColumnChanging event is triggered.   Dependency Property   ICommand     
  --------------------------- -------------------------------------------------------------------------------- --------------------- ----------- -----------------
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 
:::

[]{#related-topics}
:::::
