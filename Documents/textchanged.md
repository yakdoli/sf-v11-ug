::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_TextChanged_1}TextChanged

TextChanged -- The event occurs when **Value** property of the DoubleTextBox is changed.

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [XAML[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}
  [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DoubleTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ TextChanged]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"DoubleTextBox_TextChanged\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}
  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [DoubleTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doubleTextBox = [new]{style="COLOR: blue"} [DoubleTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [doubleTextBox.TextChanged+=[new]{style="COLOR: blue"} [TextChangedEventHandler]{style="COLOR: #2b91af"}(DoubleTextBox_TextChanged);]{style="FONT-FAMILY: 'Courier New'"}                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

[You can handle **TextChanged** event as follows.]{style="FONT-FAMILY: 'Courier New'"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} DoubleTextBox_TextChanged([object]{style="COLOR: blue"} sender, [TextChangedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                |
| [            [//Insert code to do some operations when Text of DoubleTextBox changes.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                                |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="COLOR: black"} 

[]{#related-topics}
:::
