::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Basic Core Features {#basic-core-features style="tab-stops: 0pt"}

AutoComplete supports the following basic core features:

[·      ]{style="FONT-FAMILY: Symbol"}**SelectedIndex** -- used to set and get the index of the selected item.

[·      ]{style="FONT-FAMILY: Symbol"}**SelectedItem** -- used to get which item of the AutoComplete has been selected.

[·      ]{style="FONT-FAMILY: Symbol"}**SelectedValue** - used to get the value of the selected item. The value of the **SelectedValue** property will be set based on the value of the **SelectedValuePath** property.

[·      ]{style="FONT-FAMILY: Symbol"}**IsDropDownOpen** -- used to open or close the Drop-down list by setting its value as True or False.

[·      ]{style="FONT-FAMILY: Symbol"}**SelectionChanged --** An event handler. This will be triggered when the currently selected item in the AutoComplete Control is changed** **

[·      ]{style="FONT-FAMILY: Symbol"}**TextChanged**- An Event Handler. This will be triggered when the user edits the text in the AutoComplete controls's textbox.  

 

Adding Basic Core Features to an Application

In the *SelectionChanged* event, the *SelectedIndex*, the *SelectedItem* and the *SelectedValue* properties can be used in the application to get these property values. The properties and events listed can be added to the application as mentioned in the following code:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                          |
| [autoComplete.SelectionChanged += [new]{style="COLOR: blue"} [SelectionChangedEventHandler]{style="COLOR: #2b91af"}(autoComplete_SelectionChanged);]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                          |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ autoComplete_SelectionChanged([object]{style="COLOR: blue"} sender, [SelectionChangedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [            [this]{style="COLOR: blue"}.textBlock1.Text = autoComplete.SelectedValue.ToString();           ]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                          |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for Properties, and Events

Properties

Table 1: Properties Table for Basic Features

  --------------- ----------------------------------------------------- -------------------- -------------- -----------------
  Property        Description                                           Type                 Data Type      Reference links
  SelectedIndex   Gets or sets the SelectedIndex of the AutoComplete.   DependencyProperty   Int(-1)        NA
  SelectedValue   Gets or sets the SelectedValue of the AutoComplete.   DependencyProperty   Object(null)   NA
  SelectedItem    Gets or sets the SelectedItem of the AutoComplete.    DependencyProperty   Object(null)   NA
  --------------- ----------------------------------------------------- -------------------- -------------- -----------------

.[ ]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}

Events

Table 2: Events Table for Basic Features

+------------------+---------------------------------------------------------------------------------------+------------------------------------+-----------------------------------+-----------------+
| Event            | Description                                                                           | Arguments                          | Type                              | Reference links |
+------------------+---------------------------------------------------------------------------------------+------------------------------------+-----------------------------------+-----------------+
| SelectionChanged | When the *SelectedValuePath* property value is changed, this event will be triggered. | Object,                            | SelectionChangedEventHandler      | NA              |
|                  |                                                                                       |                                    |                                   |                 |
|                  | This cannot be cancelled.                                                             | SelectionChangedEventArgs          |                                   |                 |
+------------------+---------------------------------------------------------------------------------------+------------------------------------+-----------------------------------+-----------------+
| TextChanged      | When the value of the *Text* property is changed, this event will be triggered.       | DependencyObject,                  | DependencyPropertyChangedCallBack | NA              |
|                  |                                                                                       |                                    |                                   |                 |
|                  | It cannot be cancelled.                                                               | DependencyPropertyChangedEventArgs |                                   |                 |
+==================+=======================================================================================+====================================+===================================+=================+

 

Sample Link

 

To access a Basic Core Features demo:

1.   Open the Syncfusion Dashboard.

2.   Click the **Windows Phones** drop-down list and select **Explore Samples.**

3\.   Navigate to **WindowsPhoneSampleBrowser-\> Tools -\> AutoComplete Demo**

 

[]{#related-topics}
:::
