::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### AutoComplete Events {#autocomplete-events style="tab-stops: 0pt"}

 

The events of the AutoComplete control are as follows.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ----------------------------------- --------------------------------------------------------------------------------------------------------------------------------
  AutoComplete Events                 Description
  BeforeAddItem                       Handled when a new item is about to be added.
  AutoCompleteCustomize               Handled to customize the AutoCompletion.
  AutoCompleteItemBrowsed             Handled when the user selects an item from the list of possible matches when the AutoComplete is set to AutoSuggest.
  AutoCompleteItemSelected Event      Occurs when a new item has been selected by the user when the AutoComplete mode is set to AutoSuggest.
  DropDownClosed                      Occurs when the AutoComplete dropdown is closed.
  DropDownDisplayed                   Occurs when the AutoComplete dropdown is displayed.
  MatchItem[]{style="COLOR: black"}   Enables you to provide a custom matching routine for the current value in the Edit control.
  PreMatchItem                        Handled before the AutoComplete control performs a matching operation for the current text content of the active Edit control.
  TargetChanging                      Occurs when the target control of the AutoComplete control changes.
  ----------------------------------- --------------------------------------------------------------------------------------------------------------------------------
:::

###### []{#p178}[]{#_AutoCompleteItemSelected_Event}3.3.1.1.4.1 AutoCompleteItemSelected Event {#autocompleteitemselected-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

AutoCompleteItemSelected Event is raised, when a new item has been selected by the user when the AutoComplete mode is set to AutoSuggest.

[]{style="COLOR: #15428b"} 

[This event is discussed in ]{style="COLOR: #15428b"}External DataSource[ topic.]{style="COLOR: #15428b"}

###### []{#_BeforeAddItem_Event}3.3.1.1.4.2 BeforeAddItem Event {#beforeadditem-event style="tab-stops: 0pt"}

[]{#p179}[]{style="COLOR: #15428b"} 

This event will be raised when new item is about to be added. New items can be added by calling AutoComplete.AddHistoryItem() method. The event handler receives an argument of type AutoCompleteAddItemCancelEventArgs containing data related to this event. The following are the properties associated with AutoCompleteAddItemCancelEventArgs argument.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------ -------------------------------------------------------------------------------------------------------
   Members           Description
  Cancel             Gets/Sets a value indicating whether the event should be canceled.
  ImageColumnIndex   Gets/Sets the ColumnIndex into the AutoComplete.ImageList property.
  RowItem            It is the System.Data.DataRow object that contains the value that is to be added to the history list.
  ------------------ -------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                             |
| []{style="COLOR: black"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} autoComplete1_BeforeAddItem([object]{style="COLOR: blue"} sender, [AutoCompleteAddItemCancelEventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                             |
| [//Cancels the item that is going to be added.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [    e.Cancel = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                   |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                   |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} autoComplete1_BeforeAddItem([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} AutoCompleteAddItemCancelEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                   |
| [\'Cancels the item that is going to be added.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[   ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                   |
| [   e.Cancel = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                   |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

###### []{#p180}[]{#_AutoCompleteItemBrowsed_Event}3.3.1.1.4.3 AutoCompleteItemBrowsed Event {#autocompleteitembrowsed-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

This event will be raised when the user selects an item from the list of possible matches when the AutoComplete is set to AutoSuggest. The event handler receives an argument of type AutoCompleteItemEventArgs. The event properties associated with the AutoCompleteItemEventArgs are as follows.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------ ---------------------------------------------------------------------------------------------------------------------------
  Members            Description
  SelectedValue      Gets/Sets the value selected.
  Handled            Specifies whether SelectedValue should be applied to target control. This can be used only with AutoCompleteItemSelected.
  ItemArray          Returns AutoComplete item as an object array.
  MatchColumnIndex   Returns the index of the item that was used for matching.
  ------------------ ---------------------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

When the user selects an item from the list of possible matches when the AutoComplete is set to AutoSuggest, we can display the selected URL in separate TextBox. The following code illustrate this.

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| []{style="COLOR: #15428b"}                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                         |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} autoComplete1_AutoCompleteItemBrowsed([object]{style="COLOR: blue"} sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                         |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ itemText = args.ItemArray\[0\].ToString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                                         |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ eventlogmessage = String.Format(\"Event: {0} Item: {1}\\r\\n\", \"AutoCompleteItemSelected\", itemText);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                                                         |
| [textBox1.Text = textBox1.Text + eventlogmessage;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                      |
| []{style="COLOR: #15428b"}                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} autoComplete1_AutoCompleteItemBrowsed([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} args [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                      |
| [    [Dim]{style="COLOR: blue"} itemText [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = args.ItemArray(0).ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                      |
| [    [Dim]{style="COLOR: blue"} eventlogmessage [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = \[String\].Format([\"Event: {0} Item: {1}\"]{style="COLOR: maroon"} & Chr(13) & [\"\"]{style="COLOR: maroon"} & Chr(10) & [\"\"]{style="COLOR: maroon"}, [\"AutoCompleteItemSelected\"]{style="COLOR: maroon"}, itemText)]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                                                                                                                                                                                                      |
| [    textBox1.Text = textBox1.Text + eventlogmessage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                      |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

###### []{#p181}[]{#_MatchItem_Event}3.3.1.1.4.4 MatchItem Event {#matchitem-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

We can override the default matching of the current content of the target edit control using this event. The event handler receives an argument of type AutoCompleteMatchItemEventArgs. The following are the properties associated with AutoCompleteMatchItemEventArgs argument.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------------- -------------------------------------------------------------------------------------------------------------------------------------
   Members        Description
  Cancel          Gets/Sets a value indicating whether the event should be canceled.
  CurrentText     Returns the current text value to be matched.
  PossibleMatch   Returns the possible match value that needs to be compared against AutoCompleteMatchItemEventArgs.CurrentText by the event handler.
  --------------- -------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                        |
| []{style="COLOR: black"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                        |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} autoComplete1_MatchItem([object]{style="COLOR: blue"} sender, [AutoCompleteMatchItemEventArgs]{style="COLOR: teal"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                        |
| [   //Cancels the match operation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [   e.Cancel = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                        |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                      |
| []{style="COLOR: #15428b"}                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} autoComplete1_MatchItem([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} args [As]{style="COLOR: blue"} [AutoCompleteMatchItemEventArgs]{style="COLOR: black"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                      |
| [   [//Cancels the match operation]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                      |
| [   e.Cancel = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                      |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::::::
