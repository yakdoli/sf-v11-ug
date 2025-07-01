::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Events And Methods {#events-and-methods style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

RibbonControlAdv comes with various events and methods to make easy customization.

**[]{style="COLOR: #15428b"}** 

Events

**[]{style="COLOR: #15428b"}** 

::: {align="center"}
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| Events                                                                                                                                                                                                                     | Description                                                                  | EventArgs                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| QuickAccessToolbar Events                                                                                                                                                                                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv1.BeforeCustomizeDropDownPopup]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_BeforeCustomizeDropDownPopup_Event)[]{style="COLOR: black"} | Occurs before the DropDown of QuickItemsDropDownButton is shown.             | DropDownEventArgs           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| RibbonControlAdv1.AfterCustomizeDropDownPopup                                                                                                                                                                              | Occurs after the DropDown of QuickItemsDropDownButton is shown.              | EventArgs                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv1.Header.QuickItems.BeforeAddItem]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_BeforeAddItem_and_BeforeRemoveItem)[]{.UGHyperlink}      | Occurs before ToolStripItem added to the QuickAccessPanel collection.        | RibbonItemsEventArgs        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv1.Header.QuickItems.BeforeRemoveItem]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_BeforeAddItem_and_BeforeRemoveItem)[]{.UGHyperlink}   | Occurs before ToolStripItem is removed from the QuickAccessPanel collection. | RibbonItemsEventArgs        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv.Header.QuickItemAdded]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_QuickItemAdded_and_QuickItemRemoved)[]{.UGHyperlink}                | Occurs when an item is added to the Quick Menu.                              | ToolStripItemEventArgs      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv.Header.QuickItemRemoved]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_QuickItemAdded_and_QuickItemRemoved)[]{.UGHyperlink}              | Occurs when an item is removed from the Quick Menu.                          | ToolStripItemEventArgs      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| ToolStripTabItem Events                                                                                                                                                                                                                                                                                                                 |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv1.SelectedTabItemChanged]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_SelectedTabItemChanged_Event)[]{.UGHyperlink}                     | Occurs when selected ToolStripTabItem has changed.                           | SelectedTabChangedEventArgs |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv1.Header.MainItems.BeforeAddItem]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_BeforeAddItem_and_BeforeRemoveItem)[]{.UGHyperlink}       | Occurs before a ToolStripItem is added to the collection.                    | RibbonItemEventArgs         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| [[RibbonControlAdv1.Header.MainItems.BeforeRemoveItem]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_BeforeAddItem_and_BeforeRemoveItem)[]{.UGHyperlink}    | Occurs before a ToolStripItem is removed from the collection.                | RibbonItemEventArgs         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| OfficeMenuButton Event                                                                                                                                                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
| RibbonControlAdv.MenuButtonDoubleClick                                                                                                                                                                                     | Occurs when the OfficeMenuButton is double clicked.                          | EventArgs                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+-----------------------------+
:::

[]{style="COLOR: #15428b"} 

Methods[]{#p1167}

[]{style="COLOR: #15428b"} 

::: {align="center"}
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| Methods                                                                                                                                                                                      | Description                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| **QuickAccessToolbar Methods**                                                                                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| [[RibbonControlAdv1.ShowCustomizeDialog]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_How_to_show)[]{.UGHyperlink}           | Shows QuickItems customizing dialog.                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| [[RibbonControlAdv1.Header.AddQuickItem]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Quick_Access_Toolbar)[]{.UGHyperlink}  | Adds ToolStripItems to the QuickAccessPanel.                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| [[RibbonControlAdv1.Header.QuickItems.RemoveAt]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_How_to_remove)[]{.UGHyperlink}  | Removes the specified ToolStripItems from the QuickAccessPanel.    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| **ToolStripTabItem Method**                                                                                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| [[RibbonControlAdv1.Header.AddMainItem]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_ToolStripTabItem)[]{.UGHyperlink}       | Adds ToolStripTabItems to the RibbonPanel.                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
| [[RibbonControlAdv1.Header.MainItems.RemoveAt]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_How_to_remove_1)[]{.UGHyperlink} | Removes the specified ToolStripTabItems from the QuickAccessPanel. |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------+
:::

 

###### []{#_SelectedTabItemChanged_Event}3.15.1.2.5.1        SelectedTabItemChanged Event {#selectedtabitemchanged-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

This event is handled when selected tab of the RibbonControlAdv is changed. With the **SelectedTabChangedEventArgs** of this event, we can retrieve the NewSelectedTab and PrevSelectedTab.[]{#p1168}

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                   |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} ribbonControlAdv1_SelectedTabItemChanged([object]{style="COLOR: blue"} sender, [SelectedTabChangedEventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                   |
| [    [MessageBox]{style="COLOR: teal"}.Show(e.NewSelectedTab.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                                   |
| [} ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                         |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} ribbonControlAdv1_SelectedTabItemChanged([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} SelectedTabChangedEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                         |
| [    MessageBox.Show(e.NewSelectedTab.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                         |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

###### []{#_BeforeCustomizeDropDownPopup_Event}3.15.1.2.5.2        BeforeCustomizeDropDownPopup Event {#beforecustomizedropdownpopup-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

RibbonControlAdv has two events **BeforeCustomizeDropDownPopup** and **AfterCustomizeDropDownPopup** events that are handled before and after the CustomizeDropDownPopup is activated.

 

**Example**

 

The QAT context menu items can be accessed through the DropDownEventArgs of the BeforeCustomizeDropDownPopup event and the QAT context menu can be customized such as adding new items, accessing existing items and so on.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                               |
| [ToolStripButton]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ newItem = [new]{style="COLOR: blue"} [ToolStripButton]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                                               |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} ribbonControlAdv1_BeforeCustomizeDropDownPopup([object]{style="COLOR: blue"} sender, [DropDownEventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                               |
| [    newItem.Text = [\"New Item\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                               |
| [    e.DropDown.Items.Add(newItem);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                               |
| [    [foreach]{style="COLOR: blue"} ([ToolStripItem]{style="COLOR: teal"} ts [in]{style="COLOR: blue"} e.DropDown.Items)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                               |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                               |
| [        [this]{style="COLOR: blue"}.listBox1.Items.Add(ts.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                               |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                               |
| [} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p1169}[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                     |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ newItem [As]{style="COLOR: blue"} ToolStripButton = [New]{style="COLOR: blue"} ToolStripButton()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                     |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} ribbonControlAdv1_BeforeCustomizeDropDownPopup([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} DropDownEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                     |
| [    newItem.Text = [\"New Item\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                     |
| [    e.DropDown.Items.Add(newItem)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                     |
| [    [For]{style="COLOR: blue"} [Each]{style="COLOR: blue"} ts [As]{style="COLOR: blue"} ToolStripItem [In]{style="COLOR: blue"} e.DropDown.Items]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                     |
| [        [Me]{style="COLOR: blue"}.listBox1.Items.Add(ts.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                     |
| [    [Next]{style="COLOR: blue"} ts]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                     |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::::
