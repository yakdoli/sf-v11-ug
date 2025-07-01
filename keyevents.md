::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Key Events {#key-events style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Following are the key events:

 

**KeyDown-**Occurs when a key is pressed when control has focus.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupingEngine.TableControl.KeyDown+=[new]{style="COLOR: blue"} [KeyEventHandler]{style="COLOR: #2b91af"}(TableControl_KeyDown);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                             |
|                                                                                                                                                                                                |
| []{style="COLOR: black"}                                                                                                                                                                       |
|                                                                                                                                                                                                |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ groupingEngine.TableControl.KeyDown, [AddressOf]{style="COLOR: blue"} TableControl_KeyDown]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The event handler receives an argument of type KeyEventArgs containing data related to this event.

The following KeyEventArgs properties provide information specific to this event.

 

**KeyData**-Gets the key data for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp event. 

[  ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

[·      ]{style="FONT-FAMILY: Symbol"}**Alt**-Gets a value indicating whether the ALT key was pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**Control**-Gets a value indicating whether the CTRL key was pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**Handled**-Gets or sets a value indicating whether the event was handled.

[·      ]{style="FONT-FAMILY: Symbol"}**KeyCode**-Gets the keyboard code for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp.

[·      ]{style="FONT-FAMILY: Symbol"}**KeyValue**-Gets the keyboard value for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp event.

[·      ]{style="FONT-FAMILY: Symbol"}**Modifiers**-Gets the modifier flags for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp.

[·      ]{style="FONT-FAMILY: Symbol"}**Shift**-Gets a value indicating whether the SHIFT key was pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**SuppressKeyPress**-Gets or sets a value indicating whether the key event should be passed on to the underlying control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**KeyPress-**Occurs when a key is pressed when control has focus.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupingEngine.TableControl.KeyPress+=[new]{style="COLOR: blue"} [KeyPressEventHandler]{style="COLOR: #2b91af"}(TableControl_KeyPress);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                                  |
| []{style="COLOR: black"}                                                                                                                                                                         |
|                                                                                                                                                                                                  |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ groupingEngine.TableControl.KeyPress, [AddressOf]{style="COLOR: blue"} TableControl_KeyPress]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The event handler receives an argument of type KeyPressEventArgs containing data related to this event. The following KeyPressEventArgs  properties provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**KeyChar**-The ASCII character corresponding to the key the user pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**Handled**-Gets or sets a value indicating whether the System.Windows.Forms.Control.KeyPress

[  ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

**KeyUp**:Occurs when a key is released when control has focus.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                             |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupingEngine.TableControl.KeyUp+=[new]{style="COLOR: blue"} [KeyEventHandler]{style="COLOR: #2b91af"}(TableControl_KeyUp);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                            |
| []{style="COLOR: black"}                                                                                                                                                                   |
|                                                                                                                                                                                            |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ groupingEngine.TableControl.KeyUp, [AddressOf]{style="COLOR: blue"} TableControl_KeyUp]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The event handler receives an argument of type KeyEventArgs containing data related to this event. The following KeyEventArgs  properties provide information specific to this event.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**KeyData-**Gets the key data for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp event. 

[·      ]{style="FONT-FAMILY: Symbol"}**Alt**-Gets a value indicating whether the ALT key was pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**Control**-Gets a value indicating whether the CTRL key was pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**Handled**-Gets or sets a value indicating whether the event was handled.

[·      ]{style="FONT-FAMILY: Symbol"}**KeyCode**-Gets the keyboard code for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp

[·      ]{style="FONT-FAMILY: Symbol"}**KeyValue**-Gets the keyboard value for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp event.

[·      ]{style="FONT-FAMILY: Symbol"}**Modifiers**-Gets the modifier flags for a System.Windows.Forms.Control.KeyDown or System.Windows.Forms.Control.KeyUp event.

[·      ]{style="FONT-FAMILY: Symbol"}**Shift**-Gets a value indicating whether the SHIFT key was pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**SuppressKeyPress**-Gets or sets a value indicating whether the key event should be passed on to the underlying control.           

 

[]{#p514} 

 

[]{#related-topics}
:::
