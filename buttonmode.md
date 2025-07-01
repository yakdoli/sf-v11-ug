::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Button Mode {#button-mode style="tab-stops: 0pt"}

This feature enables you to set the button in normal or toggle mode.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Norma Mode - ** Execute normal button command

[·      ]{style="FONT-FAMILY: Symbol"}**Toggle Mode  -** Execute toggle mode click event

          []{style="COLOR: #c00000"}

 

Setting Button Mode

You can set the button mode using the *ButtonMode* property.

The following code illustrates how to set the button in normal mode:

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\][]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.[ButtonMode]{style="COLOR: #2b91af"}.Normal;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"}                                                                                                                                             |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Normal]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The following code illustrates how to set the button in toggle mode:

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\][]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.[ButtonMode]{style="COLOR: #2b91af"}.Toggle;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                    |
|                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Toggle]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Setting Button State for Toggle Mode

You can set the button state using the *IsButtonChecked* property. When this is set to true button will be in *Checked* state. When this is set to false button will be in Unchecked state. This Property will active only When this SplitButton in Toggle Mode.

 

The following code illustrates how to set the button in checked state:

 

+-------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                            |
|                                                                                                                   |
| [                splitButton1.isButtonChecked = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------+
| [ ]{style="FONT-FAMILY: 'Courier New'"}\[VB\]                                                                    |
|                                                                                                                  |
| [                splitButton1.isButtonChecked = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------+

 

The following code illustrates how to set the button in unchecked state:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ ]{style="FONT-FAMILY: 'Courier New'"}\[C#\]                                                                                                            |
|                                                                                                                                                          |
| [                splitButton1.isButtonChecked = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------+
| [ ]{style="FONT-FAMILY: 'Courier New'"}\[VB\]                                                                     |
|                                                                                                                   |
| [                splitButton1.isButtonChecked = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------+

 

 

 

 

[]{#related-topics}
:::
