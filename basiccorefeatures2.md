::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Basic Core Features {#basic-core-features style="tab-stops: 0pt"}

AutoComplete supports basic core features which are listed below.

[·      ]{style="FONT-FAMILY: Symbol"}SelectedIndex--- Used to set and get the index of the selected item.

[·      ]{style="FONT-FAMILY: Symbol"}SelectedItem---Used to get which item of the AutoComplete has been selected.

[·      ]{style="FONT-FAMILY: Symbol"}SelectedValue---Used to get the value of the selected item, the value of the **SelectedValue** property will be set based on the value of the **SelectedValuePath** property.

[·      ]{style="FONT-FAMILY: Symbol"}SelectedValuePath---Used to set the value of the **SelectedValue** property of the AutoComplete.

[·      ]{style="FONT-FAMILY: Symbol"}DisplayMemberPath---Used to set the value for the items displayed in the drop-down list.

[·      ]{style="FONT-FAMILY: Symbol"}IsDropDownOpen---Used to open or close the Drop-down list by setting its value as True or False.

[·      ]{style="FONT-FAMILY: Symbol"}SelectionChanged.

[·      ]{style="FONT-FAMILY: Symbol"}TextChanged.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Using Basic Core Features in an Application

In the SelectionChanged event the **SelectedIndex**, **SelectedItem** & **SelectedValue** properties can be used in the application to get these property values. The properties and events listed can be used in the application as mentioned below.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                  |
| [List]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\<[String]{style="COLOR: #2b91af"}\> Products = [new]{style="COLOR: blue"} [List]{style="COLOR: #2b91af"}\<[String]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                  |
| [Products.Add([\"Diagram\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                  |
| [Products.Add([\"Gauge\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                  |
| [Products.Add([\"Chart\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                  |
| [Products.Add([\"Business Intelligence\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                                  |
| [AutoComplete]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ autoComplete1 = [new]{style="COLOR: blue"} [AutoComplete]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                                  |
| [autoComplete1.CustomSource = Products;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                  |
| [autoComplete1.SelectedIndex = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [autoComplete1.IsDropDownOpen = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                                  |
| [autoComplete1.SelectionChanged += ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                  |
| [new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [SelectionChangedEventHandler]{style="COLOR: #2b91af"}(autoComplete1_SelectionChanged);]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                                  |
| [autoComplete1.TextChanged += [new]{style="COLOR: blue"} [PropertyChangedCallback]{style="COLOR: #2b91af"}(autoComplete1_TextChanged);]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ autoComplete1_TextChanged([DependencyObject]{style="COLOR: #2b91af"} d, ]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                  |
| [                                   DependencyPropertyChangedEventArgs]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ e)]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                                  |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                  |
| [      this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBlock.Text = [this]{style="COLOR: blue"}.autoComplete1.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ autoComplete1_SelectionChanged([object]{style="COLOR: blue"} sender, ]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                                  |
| [                                            [SelectionChangedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                                  |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                  |
| [      [MessageBox]{style="COLOR: #2b91af"}.Show([\"SelectedItem: \"]{style="COLOR: #a31515"} +]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                                                  |
| [      [this]{style="COLOR: blue"}.autoComplete1.SelectedItem.ToString()+ [\"\\n\"]{style="COLOR: #a31515"} + [\"SelectedValue: \"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                                  |
| [      + [this]{style="COLOR: blue"}.autoComplete1.SelectedValue.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                                  |
| [}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for Properties, and Events

Properties[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

Table 1: Properties Table for Basic Features

::: {align="center"}
  ------------------- --------------------------------------------------------- -------------------- -------------- -----------------
  Property            Description                                               Type                 Data Type      Reference links
  SelectedIndex       Gets or sets the SelectedIndex of the AutoComplete.       DependencyProperty   Int(-1)        
  SelectedValue       Gets or sets the SelectedValue of the AutoComplete.       DependencyProperty   Object(null)   
  SelectedItem        Gets or sets the SelectedItem of the AutoComplete.        DependencyProperty   Object(null)   
  SelectedValuePath   Gets or sets the SelectedValuePath of the AutoComplete.   DependencyProperty   String(null)   
  DisplayMemberPath   Gets or sets the DisplayMemberPath of the AutoComplete.   DependencyProperty   String(null)   
  ------------------- --------------------------------------------------------- -------------------- -------------- -----------------
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Events

Table 2: Events Table for Basic Features

::: {align="center"}
+------------------+-----------------------------------------------------------------------------------+------------------------------------+-------------------+---------------------------------+
| Event            | Description                                                                       | Arguments                          | Type              | Reference links                 |
+------------------+-----------------------------------------------------------------------------------+------------------------------------+-------------------+-------------------+-------------+
| SelectionChanged |  When the value of SelectedItem property is changed this event will be triggered. | Object,                            | SelectionChangedEventHandler          |             |
|                  |                                                                                   |                                    |                                       |             |
|                  | It cannot be cancelled.                                                           | SelectionChangedEventArgs          |                                       |             |
+------------------+-----------------------------------------------------------------------------------+------------------------------------+---------------------------------------+-------------+
| TextChanged      | When the value of the Text property is changed this event will be triggered.      | DependencyObject,                  | DependencyPropertyChangedCallBack     |             |
|                  |                                                                                   |                                    |                                       |             |
|                  | It cannot be cancelled.                                                           | DependencyPropertyChangedEventArgs |                                       |             |
+==================+===================================================================================+====================================+===================+===================+=============+
|                  |                                                                                   |                                    |                   |                   |             |
+------------------+-----------------------------------------------------------------------------------+------------------------------------+-------------------+-------------------+-------------+
:::

 

Sample Link

WPF Sample Browser-\> Tools -\> Editors -\> AutoComplete Demo

 

[]{#related-topics}
:::::
