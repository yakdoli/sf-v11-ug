::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Spell Checking Using ISpellEditor  

In the following code snippet, a wrapper class is created for TextBox, by implementing ISpellEditor interface.

 

+-----------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                           |
| [public class TextBoxSpellEditor: ISpellEditor]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                           |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                           |
| [        private TextBox textBox;]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                           |
| [        public TextBoxSpellEditor(Control control)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            ControlToCheck = control;]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [        public Control ControlToCheck]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            get]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [                return textBox;]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                           |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [            set]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [                textBox = value as TextBox;]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                           |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [        public string SelectedText]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            get]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [                return textBox.SelectedText;]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                           |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [            set]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [                textBox.SelectedText = value;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                           |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [        public string Text]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            get]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [                return textBox.Text;]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                           |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [            set]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                           |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [                textBox.Text = value;]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                           |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [        public void Select(int selectionStart, int selectionLength)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            textBox.Select(selectionStart, selectionLength);]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [        public bool HasMoreTextToCheck()]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            return false;]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [        public void Focus()]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            textBox.Focus();]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [        public void UpdateTextField()]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                           |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                           |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                               |
+-----------------------------------------------------------------------------------------------------------+

After creating the wrapper class, you need to pass the instance of the ISpellEditor to SpellCheckForEditor method, as given in the following code snippet:

 

+-------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                       |
| [SpellChecker spellCheck = new SpellChecker();]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                       |
| [TextBoxSpellEditor spellEditor = new TextBoxSpellEditor(txtbx);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                       |
| [spellCheck.SpellCheckForEditor(spellEditor);]{style="FONT-FAMILY: 'Courier New'"}                    |
+-------------------------------------------------------------------------------------------------------+

 

Sample Link

To view samples:

1.   Open the Synfusion Dashboard.

2.   Select User Interface.

3.   Click the SL drop-down list and select Explore Samples.

4.   Navigate to Tools -\> SpellChecker -\> SpellCheckerDemo.

 

[]{#related-topics}
:::
