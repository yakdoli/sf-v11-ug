::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Null Value {#null-value style="tab-stops: 0pt"}

The Null Value feature enables the UpDown control to accept null values.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Using NullValue and UseNullOption

You can enter a null value in the UpDown control only if the UseNullOption is set to true. Also, you can specify a value to be displayed in the UpDown control when the value of the UpDown control is set to null by using the NullValue property.

NullValue can be set for the UpDown control, as shown in the following code snippets.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}[ [Name]{style="COLOR: red"}[=\"upDown\"]{style="COLOR: blue"} [UseNullOption]{style="COLOR: red"}[=\"true\" ]{style="COLOR: blue"}[NullValue]{style="COLOR: red"}[=\"1\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                                |
| [UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ upDown = [new]{style="COLOR: blue"} [UpDown]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                |
| [upDown.UseNullOption = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                    |
|                                                                                                                                                                                                                |
| [upDown.NullValue = 2;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for Properties, and Events

Properties

Table 34: Properties Table

  --------------- ---------------------------------------------------------------------------------------------------------- -------------------- ----------- -----------------
  Property        Description                                                                                                Type                 Data Type   Reference links
  UseNullOption   Gets or sets the value that indicates whether to use the null value.                                       DependencyProperty   bool        Not applicable
  NullValue       Gets or sets a value to be displayed in the UpDown control when the value of the UpDown control is null.   DependencyProperty   double?     Not applicable
  --------------- ---------------------------------------------------------------------------------------------------------- -------------------- ----------- -----------------

 

Events

Table 35: Event Table

+----------------------+-------------------------------------------------+-------------------------------------+-------------------------+-----------------+
| Event                | Description                                     | Arguments                           | Type                    | Reference links |
+----------------------+-------------------------------------------------+-------------------------------------+-------------------------+-----------------+
| UseNullOptionChanged | Occurs when the UseNullOption value is changed. | DependencyObject and                | PropertyChangedCallback | Not applicable  |
|                      |                                                 |                                     |                         |                 |
|                      |                                                 | DependencyPropertyChangedEventArgs. |                         |                 |
+======================+=================================================+=====================================+=========================+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
:::
