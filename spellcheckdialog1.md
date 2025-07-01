::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### SpellCheckDialog {#spellcheckdialog style="tab-stops: 0pt"}

Spell Checker contains in-built dialog for checking spellings for any input control. SpellChecker will not directly checks spelling for the control. You need to create a wrapper class for that control by implementing the interface **ISpellEditor** and you need to define all the members given in the interface. Using this interface the SpellChecker will interact with any control.

 

Methods

**[]{style="COLOR: #4e84c4; FONT-SIZE: 13pt"}** 

::: {align="center"}
  --------------------------------------------- ------------------------------------------------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Method                                        Prototype                                                          Description
  [SpellCheckForEditor]{style="COLOR: black"}   [SpellCheckForEditor(ISpellEditor editor)]{style="COLOR: black"}   [If you use this method for checking spellings, the SpellChecker will launch a SpellCheckDialog.Using this dialog you can ignore, replace  and add the selected word to the dictionary.]{style="COLOR: black"}
  --------------------------------------------- ------------------------------------------------------------------ ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

Events

***[]{style="COLOR: black"}*** 

::: {align="center"}
  ------------------------------------------------------- ------------------------------ -------------------------------------------------------------------------------------------------------------------------------------
  Event[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}   Parameters                     Description
  [SpellCheckCompleted]{style="COLOR: black"}             [ Nil]{style="COLOR: black"}   [This event will be triggered when the spell checking is completed for the input text using SpellCheckDialog]{style="COLOR: black"}
  ------------------------------------------------------- ------------------------------ -------------------------------------------------------------------------------------------------------------------------------------
:::

**** 

[]{style="COLOR: #c00000"} 

Spell Checking Using ISpellEditor

In the below code snippet, a wrapper class is created for TextBox by implementing ISpellEditor interface.****

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                             |
| [        [public]{style="COLOR: blue"} [class]{style="COLOR: blue"} [TextBoxSpellEditor]{style="COLOR: #2b91af"} : ISpellEditor]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                      |
|                                                                                                                                                                                                                             |
| [        {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                           |
|                                                                                                                                                                                                                             |
| [            [private]{style="COLOR: blue"} [TextBox]{style="COLOR: #2b91af"} textBox;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} TextBoxSpellEditor([Control]{style="COLOR: #2b91af"} control)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                             |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                ControlToCheck = control;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                           |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [Control]{style="COLOR: #2b91af"} ControlToCheck]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                          |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                [get]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [                {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                    [return]{style="COLOR: blue"} textBox;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                          |
|                                                                                                                                                                                                                             |
| [                }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                [set]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [                {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                    textBox = [value]{style="COLOR: blue"} [as]{style="COLOR: blue"} [TextBox]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                             |
|                                                                                                                                                                                                                             |
| [                }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [string]{style="COLOR: blue"} SelectedText]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                [get]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [                {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                    [return]{style="COLOR: blue"} textBox.SelectedText;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                             |
|                                                                                                                                                                                                                             |
| [                }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                [set]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [                {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                    textBox.SelectedText = [value]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                            |
|                                                                                                                                                                                                                             |
| [                }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [string]{style="COLOR: blue"} Text]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                        |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                [get]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [                {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                    [return]{style="COLOR: blue"} textBox.Text;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                     |
|                                                                                                                                                                                                                             |
| [                }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                [set]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [                {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [                    textBox.Text = [value]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                    |
|                                                                                                                                                                                                                             |
| [                }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [void]{style="COLOR: blue"} Select([int]{style="COLOR: blue"} selectionStart, [int]{style="COLOR: blue"} selectionLength)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                textBox.Select(selectionStart, selectionLength);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                    |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [bool]{style="COLOR: blue"} HasMoreTextToCheck()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                          |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                         |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [void]{style="COLOR: blue"} Focus()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                       |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [                textBox.Focus();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            [public]{style="COLOR: blue"} [void]{style="COLOR: blue"} UpdateTextField()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                             |
|                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [        }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                           |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

After creating the wrapper class, you need to pass the instance of the ISpellEditor to SpellCheckForEditor method as given in the following code snippet:

**** 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                               |
|                                                                                                                                                |
| [SpellChecker spellCheck = [new]{style="COLOR: blue"} SpellChecker();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                   |
|                                                                                                                                                |
| [TextBoxSpellEditor spellEditor = [new]{style="COLOR: blue"} TextBoxSpellEditor(txtbx);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                |
| [spellCheck.SpellCheckForEditor(spellEditor);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

Sample Link

To access the sample link:

1.   Open the Synfusion Dashboard.

2.   Select **User Interface**.

3.   Click the WPF drop-down list and select **Explore Samples**.

4.   Navigate to **Tools** -\> **SpellChecker** -\> **SpellCheckerDemo**.

 

 

[]{#related-topics}
:::::
