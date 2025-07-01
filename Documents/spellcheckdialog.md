::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### SpellCheckDialog

Spell Checker contains in-built dialog for checking spellings for any input control. SpellChecker will not directly check spelling for the control. You need to create a wrapper class for that control by implementing the interface ISpellEditor and you need to define all the members given in the interface. Using this interface, the SpellChecker will interact with any control.

Methods

  --------------------- ------------------------------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Method                Prototype                                  Description
  SpellCheckForEditor   SpellCheckForEditor(ISpellEditor editor)   When this method for checking spellings, the SpellChecker will launch a SpellCheckDialog.Using this dialog, you can ignore, replace, and add the selected word to the dictionary.
  --------------------- ------------------------------------------ -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

Events

  --------------------- ------------ -----------------------------------------------------------------------------------------------------------------
  Event                 Parameters   Description
  SpellCheckCompleted    Nil         This event will be triggered when the spell checking is completed for the input text using the SpellCheckDialog
  --------------------- ------------ -----------------------------------------------------------------------------------------------------------------

 

More:

[ ]{#related-topics}

[![](../button.gif){border="0" align="absMiddle"}Spell Checking Using ISpellEditor](ms-xhelp:///?Id=e86af7bb-1738-4c25-89d2-349d172d3c4d){style="TEXT-DECORATION: none"}
:::
