::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### StatusBarAdv - Behavior Settings {#statusbaradv---behavior-settings style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

This section discusses the properties that determine the behavior of the StatusBarAdv control.

 

**AutoSize Settings**

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

This includes the properties that enable auto sizing of the StatusBarAdv control.

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| StatusBarAdv Property             | Description                                                                                                 |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| AutoSize                          | Specifies whether a control will automatically resize itself to fit it\'s contents.                         |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| AutoSizeMode                      | Specifies the mode by which the control automatically resizes itself. The options included are given below. |
|                                   |                                                                                                             |
|                                   |                                                                                                             |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}GrowAndShrink and                                                     |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}GrowOnly.                                                             |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

If the \'GrowAndShrink\' option is selected, then the control grows and shrinks to fit it\'s contents to a size that may be a little more or less than the value specified in the Size property of the control.

 

If the \'GrowOnly\'*[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}*option is selected, the control grows as much as necessary to fit it\'s contents, but doesn\'t shrink smaller than the value specified in the Size property of the control.

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoSize = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoSizeMode = System.Windows.Forms.[AutoSizeMode]{style="COLOR: teal"}.GrowOnly;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoHeightControls = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoSize = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoSizeMode = System.Windows.Forms.[AutoSizeMode]{style="COLOR: teal"}.GrowOnly]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoHeightControls = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

AutoHeight Settings

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

The height of the panels can be made to change automatically when the height of the StatusBarAdv control changes. This can be accomplished using the property given below.

[]{style="COLOR: #15428b"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------+
| StatusBarAdv Property             | Description                                                                                    |
+-----------------------------------+------------------------------------------------------------------------------------------------+
| AutoHeightControls                | Determines if the StatusBarAdv will resize the height of the panels according to it\'s height. |
|                                   |                                                                                                |
|                                   |                                                                                                |
|                                   |                                                                                                |
|                                   | The default value will be set to \'True\'.                                                     |
+-----------------------------------+------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                |
|                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoHeightControls = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                         |
|                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                   |
|                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.statusBarAdv1.AutoHeightControls = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

The methods associated with the above properties are given below.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------ -----------------------------------------------------------------
  Methods            Description
  GetPreferredSize   Returns the preferred size of the specified control.
  SetPreferredSize   Sets the preferred size in the layout of the specified control.
  ------------------ -----------------------------------------------------------------
:::

 

 

 

 

[]{#related-topics}
::::::
