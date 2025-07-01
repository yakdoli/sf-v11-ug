::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Commands support

 

The **RichTextBoxAdv** control provides the build in commands to show case the features available in RichTextBoxAdv. It can be executed in the RichTextBoxAdv whenever it is bound to Command Property.

 

Properties

Table 83: Property/Properties Table

::: {align="center"}
  ----------------------------- --------------------------------------------------------- --------------------- ------------- -----------------
  Property                      Description                                               Type                  Data Type     Reference links
  AfterSpacingCommand           Command to change the spacing after.                      Dependency Property   CommandBase   NA
  BeforeSpacingCommand          Command to change the spacing before.                     Dependency Property   CommandBase   NA
  BoldCommand                   Command which will toggle bold                            Dependency Property   CommandBase   NA
  ChangeFontFamilyCommand       Command to change font family of the selected text.       Dependency Property   CommandBase   NA
  ChangeFontSizeCommand         Command to change font size of the selected text.         Dependency Property   CommandBase   NA
  ChangeHighlightColorCommand   Command to change highlight color of the selected text.   Dependency Property   CommandBase   NA
  ChangeFontColorCommand        Command to change font color.                             Dependency Property   CommandBase   NA
  CopyCommand                   Command to copy the selected text.                        Dependency Property   CommandBase   NA
  CutCommand                    Command to cut the selected text.                         Dependency Property   CommandBase   NA
  StrikeThroughCommand          Command to change the strike through of the text.         Dependency Property   CommandBase   NA
  FontDialogCommand             Command to show the in-built font dialog box.             Dependency Property   CommandBase   NA
  ItalicCommand                 Command which will toggle Italics                         Dependency Property   CommandBase   NA
  HyperlinkDialogCommand        Command to show the in-built hyperlink dialog box.        Dependency Property   CommandBase   NA
  IncreaseIndentCommand         Command to increase the left indent of the paragraph.     Dependency Property   CommandBase   NA
  DecreaseIndentCommand         Command to decrease the left indent of the paragraph.     Dependency Property   CommandBase   NA
  LeftIndentCommand             Command to change the left indent of the paragraph.       Dependency Property   CommandBase   NA
  RightIndentCommand            Command to change the right indent of the paragraph.      Dependency Property   CommandBase   NA
  ParagraphDialogCommand        Command to show the in-built paragraph dialog box.        Dependency Property   CommandBase   NA
  OpenDocumentCommand           Command to open the Open dialog and open the document.    Dependency Property   CommandBase   NA
  SaveDocumentCommand           Command to open the Save dialog and save the document.    Dependency Property   CommandBase   NA
  PasteCommand                  Command to paste the copied text.                         Dependency Property   CommandBase   NA
  SubscriptCommand              Command which will toggle subscript                       Dependency Property   CommandBase   NA
  SuperscriptCommand            Command which will toggle superscript                     Dependency Property   CommandBase   NA
  TextAlignmentCommand          Command to change the text alignment of the paragraph.    Dependency Property   CommandBase   NA
  UnderlineCommand              Command to change the underline.                          Dependency Property   CommandBase   NA
  NewDocumentCommand            Command to create the new document.                       Dependency Property   CommandBase   NA
  PrintDocumentCommand          Command to show the build in Print dialog box.            Dependency Property   CommandBase   NA
  ChangeListTypeCommand         Command to apply the Bullets and Numbering                Dependency Property   CommandBase   NA
  UndoCommand                   Command to undo the operation.                            Dependency Property   CommandBase   NA
  RedoCommand                   Command to redo the operation.                            Dependency Property   CommandBase   NA
  ChangePageLayoutCommand       Command to change the LayoutMode.                         Dependency Property   CommandBase   NA
  DoubleStrikeThroughCommand    Command to apply double strike through.                   Dependency Property   CommandBase   NA
  LineSpacingCommand            Command to change the line spacing.                       Dependency Property   CommandBase   NA
  ----------------------------- --------------------------------------------------------- --------------------- ------------- -----------------
:::

 

Properties

Table 84: Method/s Table

::: {align="center"}
  Method                      Description                                                         Parameters                  Type   Return Type   Reference links
  --------------------------- ------------------------------------------------------------------- --------------------------- ------ ------------- -----------------
  Copy                        This should be called to copy the selected text.                    NA                          NA     Void          NA
  Paste                       This should be called to paste the text from clipboard              NA                          NA     Void          NA
  Cut                         This should be called to cut the selected text.                     NA                          NA     Void          NA
  ChangeTextAlignment         Changes the specified text alignment                                (object commandparameter)   NA     Void          NA
  Bold                        Toggles bold for the selected text                                  NA                          NA     Void          NA
  Italic                      Toggles Italics for the selected text                               NA                          NA     Void          NA
  ChangeLeftIndent            Changes the left indent of the current paragraph                    (object commandparameter)   NA     Void          NA
  ChangeRightIndent           Changes the right indent of the current paragraph                   (object commandparameter)   NA     Void          NA
  IncreaseIndent              Increases the indent                                                NA                          NA     Void          NA
  DecreaseIndent              Decreases the indent                                                NA                          NA     Void          NA
  ChangeLineSpacing           Changes the line spacing                                            (object commandparameter)   NA     Void          NA
  ChangeFontFamily            Changes the font family                                             (object commandparameter)   NA     Void          NA
  ChangeAfterSpacing          Changes the AfterSpacing of the paragraph to the specified value    NA                          NA     Void          NA
  ChangeBeforeSpacing         Changes the BeforeSpacing of the paragraph to the specified value   NA                          NA     Void          NA
  ChangeFontSize              Changes the font size of the selected text                          (object commandparameter)   NA     Void          NA
  ChangeSingleStrikeThrough   Toggles single strike through                                       NA                          NA     Void          NA
  ChangeDoubleStrikeThrough   Toggles double strike through                                       NA                          NA     Void          NA
  ChangeHighlightColor        Changes the highlight color to the specified color                  NA                          NA     Void          NA
  ChangeUnderline             Toggles the underline                                               NA                          NA     Void          NA
  ChangeSuperscript           Toggles the superscript                                             NA                          NA     Void          NA
  ChangeSubscript             Toggles the subscript                                               NA                          NA     Void          NA
  Undo                        Undo the operation                                                  NA                          NA     Void          NA
  Redo                        Redo the operation                                                  NA                          NA     Void          NA
  ChangePageLayout()          Changes the layout of the document                                  (object commandparameter)   NA     Void          NA
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{#related-topics}
:::::
