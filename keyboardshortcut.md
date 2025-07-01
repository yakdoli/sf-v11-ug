::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Keyboard Shortcut {#keyboard-shortcut style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Menu supports keyboard shortcuts that allows easy access to the menu items and its commands. Keyboard mnemonic facility is also supported that enables to quickly access the menu items.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------+
|                                   |                                                                          |
|                                   |                                                                          |
| Property                          | Description                                                              |
+-----------------------------------+--------------------------------------------------------------------------+
| KeyboardShortcut                  | Specifies the shortcut key that enables quick access of menu items.      |
+-----------------------------------+--------------------------------------------------------------------------+
| ShortcutIndent                    | Specifies distance between the menu item text and its shortcut key text. |
+-----------------------------------+--------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Keyboard shortcut in designer and code

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Setting the[ ]{style="COLOR: black"}**KeyboardShortcut**[ ]{style="COLOR: black"}property in the Designer dialog to the key combination enables to access the menu items using the shortcut keys. This property must be set to the shortcut key combination that you require to access the menu item.

 

Sample code snippet illustrating programmatic setting of KeyboardShortcut for the menu items.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                     |
|                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                           |
|                                                                                                                                                                                                      |
| [MenuItem]{style="FONT-FAMILY: 'Courier New'; COLOR: teal; FONT-SIZE: 9pt"}[ item=[new]{style="COLOR: blue"} [MenuItem]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                      |
| [item.Text=[\"&Consulting\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                            |
|                                                                                                                                                                                                      |
| [item.KeyboardShortcut=[\"Ctrl+S\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                 |
|                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                       |
|                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ item [As]{style="COLOR: blue"} MenuItem = [New]{style="COLOR: blue"} MenuItem()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ item.Text=[\"&Consulting\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                              |
|                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ item.KeyboardShortcut=[\"Ctrl+S\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Shortcut indent in designer and code

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The[ ]{style="COLOR: black"}**ShortcutIndent** property allows you to specify the space between the menu item text and the shortcut key.

You can also specify the indent between item text and item shortcut in code as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                 |
|                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                       |
|                                                                                  |
| [Menu1.ShortcutIndent = 50;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+----------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                           |
|                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                 |
|                                                                                                                                                            |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ Menu1.ShortcutIndent = 50]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In the above shown image, the shortcut indent has been set to 50 pixels.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Keyboard Mnemonics

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To set mnemonics for menu items, in the[ ]{style="COLOR: black"}**Text**[ ]{style="COLOR: black"}property in the Designer dialog add the to the character with which you want to access the menu item should precede with \'&\' symbol. In the above shown diagram, mnemonics for Technology item has been set as **Te&chnology** to the Text property.

When mnemonics is set in the designer, the html view will appear as[ ]{style="COLOR: black"}**Text= \"Te&amp;chnology\"**[.]{style="COLOR: black"}

A sample which demonstrates the above feature is available in the below sample installation path.

..MyDocuments\\Syncfusion\\EssentialStudio\\VersionNumber\\Windows\\Tools.Web\\Samples\\3.5\\MenuPackage\\Menu\\Menu-AdvancedFeatures\\Keyboardshortcuts

 

[]{#related-topics}
::::
