::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Concepts and Features {#concepts-and-features style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The following topics will help you become more familiar in using the ComboBoxBase control.

[]{style="COLOR: #15428b"} 

###### []{#p411}[]{#_Appearance_and_Behavior}3.3.5.3.3.1 Appearance and Behavior Settings {#appearance-and-behavior-settings style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

This section includes the discussion of Appearance and Behavior Settings of ComboBoxBase.

 

The ComboBoxBase control provides Style, FlatStyle and other properties to enable advanced border drawing features. Written using native .**NET** Controls, this control lets you customize everything in the combo box from the text box to the drop-down window. Refer ComboBoxAdv user guide, which contains properties included in ComboBoxBase.

 

You will also notice that some of the properties you can find in the framework combo box (like **IntegralHeight**, **ItemHeight**, **MaxDropDownItems**, **datasource** and events like **SelectedIndexChanged**) are missing in the ComboBoxBase. These properties and events are meant to be set / handled in the plugged-in ListControl.

###### []{#p412}[]{#_Creating_ListControl_-}3.3.5.3.3.2 Creating ListControl - Derived Controls {#creating-listcontrol---derived-controls style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

When you create custom ListControl - derived controls for use with the ComboBoxBase class, it is essential that you provide certain properties and methods to avail all the capabilities of the ComboBoxBase class.

 

The ListBox control enables you to display a list of items, it can be selected by clicking. A ListBox control can provide single or multiple selections using the **SelectionMode** property. The ListBox also provides the **MultiColumn** property to enable the display of items in columns instead of a straight vertical list of items. This allows the control to display more visible items and prevents the need for the user to scroll to an item.

 

In addition to display and selection functionality, the ListBox also provides features that enable you to efficiently add items to the ListBox and to find text within the items of the list.

 

The **BeginUpdate** and **EndUpdate** methods enable you to add a large number of items to the ListBox without the control being repainted each time an item is added to the list.

 

The **Items**, **SelectedItem** and **SelectedIndices** properties provide access to the three collections that are used by the ListBox.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ---------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------
  Collection Class                   Use Within the List Box
  ListBox.ObjectCollection           Collection of all items contained in the ListBox control.
  ListBox.SelectedObjectCollection   Contains a collection of the selected items which is a subset of the items contained in the ListBox control.
  ListBoxSelectedIndexCollection     Contains a collection of the selected indexes, which is a subset of the indexes of the ListBox.ObjectCollection. These indexes specify items that are selected.
  ---------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

You should always implement an **Items** property and optionally implement an **IndexFromPoint** method and a **TopIndex** property. Implementing IndexFromPoint and TopIndex will enable QuickSelection capability for the combo box, wherein the user can click on the drop down button and start selecting items in the list, all this without releasing the mouse.[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 13pt"}You can find more information regarding these requirements in the class reference.

[]{#related-topics}
::::
