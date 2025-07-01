::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Setting the Value for UpDown {#setting-the-value-for-updown style="tab-stops: 0pt"}

The value for UpDown can be specified by using the Value property.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Using the Value Property

A value can be set for the UpDown control, as shown in the following code snippets.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}[ [Name]{style="COLOR: red"}[=\"upDown\"]{style="COLOR: blue"} [Value]{style="COLOR: red"}[=\"10\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                                |
| [UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ upDown = [new]{style="COLOR: blue"} [UpDown]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                |
| [upDown.Value = 10;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for Properties, and Events

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Properties

Table 32: Property Table

  ---------- ----------------------------------------------- -------------------- ----------- -----------------
  Property   Description                                     Type                 Data Type   Reference links
  Value      Gets or sets the value of the UpDown control.   DependencyProperty   double?     Not applicable
  ---------- ----------------------------------------------- -------------------- ----------- -----------------

Events

Table 33:Events Table

+---------------+-----------------------------------------------------------+-------------------------------------+---------------------------+----------------+
| Event         | Description                                               | Arguments                           | Type                      | Reference Link |
+---------------+-----------------------------------------------------------+-------------------------------------+---------------------------+----------------+
| ValueChanged  | Occurs when the value in the text box changes.            | DependencyObject and                | PropertyChangedCallback   | Not applicable |
|               |                                                           |                                     |                           |                |
|               |                                                           | DependencyPropertyChangedEventArgs. |                           |                |
+---------------+-----------------------------------------------------------+-------------------------------------+---------------------------+----------------+
| ValueChanging | Occurs when the value in the text box is about to change. | Object and                          | ValueChangingEventHandler | Not applicable |
|               |                                                           |                                     |                           |                |
|               |                                                           | ValueChangingEventArgs.             |                           |                |
+===============+===========================================================+=====================================+===========================+================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
:::
