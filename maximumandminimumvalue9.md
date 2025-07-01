::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Maximum and Minimum Value {#maximum-and-minimum-value style="tab-stops: 0pt"}

MaxValue is the maximum value that can be set for the UpDown control and MinValue is the minimum value that can be set for the UpDown control.

 

Using MaxValue and MinValue

MaxValue and MinValue can be set for the UpDown control, as shown in the following code snippets.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"}[ [Name]{style="COLOR: red"}[=\"upDown\"]{style="COLOR: blue"} [MaxValue]{style="COLOR: red"}[=\"100\" ]{style="COLOR: blue"}[MinValue]{style="COLOR: red"}[=\"0\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                                |
| [UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ upDown = [new]{style="COLOR: blue"} [UpDown]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                |
| [upDown.MaxValue = 100;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                 |
|                                                                                                                                                                                                                |
| [upDown.MinValue = 0;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for Properties, and Events

Properties

Table36: Properties Table

  ---------- ----------------------------------------------------- -------------------- ----------- -----------------
  Property   Description                                           Type                 Data Type   Reference links
  MaxValue   Gets or sets the maximum value that can be entered.   DependencyProperty   double      Not applicable
  MinValue   Gets or sets the minimum value that can be entered.   DependencyProperty   double      Not applicable
  ---------- ----------------------------------------------------- -------------------- ----------- -----------------

 

Events

Table 37: Events Table

+-----------------+----------------------------------+-------------------------------------+-------------------------+-----------------+
| Event           | Description                      | Arguments                           | Type                    | Reference links |
+-----------------+----------------------------------+-------------------------------------+-------------------------+-----------------+
| MaxValueChanged | Occurs when MaxValue is changed. | DependencyObject and                | PropertyChangedCallback | Not applicable  |
|                 |                                  |                                     |                         |                 |
|                 |                                  | DependencyPropertyChangedEventArgs. |                         |                 |
+-----------------+----------------------------------+-------------------------------------+-------------------------+-----------------+
| MinValueChanged | Occurs when MinValue is changed. | DependencyObject and                | PropertyChangedCallback | Not applicable  |
|                 |                                  |                                     |                         |                 |
|                 |                                  | DependencyPropertyChangedEventArgs. |                         |                 |
+=================+==================================+=====================================+=========================+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
:::
