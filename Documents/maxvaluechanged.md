::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_MaxValueChanged_1}MaxValueChanged

 

MaxValueChanged -- The event occurs when **MaxValue** property of the DoubleTextBox is changed.

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [XAML]{style="FONT-FAMILY: 'Courier New'"}
  [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DoubleTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ MaxValueChanged]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"DoubleTextBox_MaxValueChanged\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

[]{style="FONT-FAMILY: 'Courier New'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [DoubleTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doubleTextBox = [new]{style="COLOR: blue"} [DoubleTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [doubleTextBox.MaxValueChanged+=[new]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                 |
| [              [PropertyChangedCallback]{style="COLOR: #2b91af"}(DoubleTextBox_MaxValueChanged);]{style="FONT-FAMILY: 'Courier New'"}                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[User can handle the MaxValueChanged event as follows.]{style="FONT-FAMILY: 'Courier New'"}

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} DoubleTextBox_MaxValueChanged([DependencyObject]{style="COLOR: #2b91af"} d, [DependencyPropertyChangedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [            [//Insert code to do some operations when the MaxValue changed]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                                                          |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

[]{#related-topics}
:::
