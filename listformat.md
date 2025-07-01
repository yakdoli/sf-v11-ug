::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### List Format {#list-format style="tab-stops: 0pt"}

 

WListFormat class defines the formatting for DocIO list paragraph. The type of the list is specified by using the ListType property of WListFormat. ListLevelNumber property defines the level number for the list paragraph. CurrentListStyle property defines the list style, applied for the current list paragraph. CurrentListLevel property returns the object of the WListLevel type, which defines the formatting for the list level (paragraph). For example, a value that the list starts at (for numbered lists), list symbols, alignment of list text, and so forth.

 

[·      ]{style="FONT-FAMILY: Symbol"}To apply default bullet or numbered style to the paragraph, use **ApplyDefBulletStyle** or **ApplyDefNumberedStyle** function.

[·      ]{style="FONT-FAMILY: Symbol"}To apply custom style, use **ApplyStyle** function.

[·      ]{style="FONT-FAMILY: Symbol"}**ContinueListNumbering** function is used to continue previous list numbering.

[·      ]{style="FONT-FAMILY: Symbol"}Use **IncreaseIndentLevel** or **DecreaseIndentLevel** to increase or decrease indent for the level.

[·      ]{style="FONT-FAMILY: Symbol"}To remove list from the paragraph use **RemoveList** function.

 

Class Hierarchy

 

FormatBase

\|

            WListFormat

 

**Public Constructor**

 

::: {align="center"}
  --------------------------------------- ------------------------------------------------
  Name                                    Description
  WListFormat.WListFormat (IWParagraph)   Initializes new instance of WListFormat class.
  --------------------------------------- ------------------------------------------------
:::

**[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}** 

Public Properties

 

::: {align="center"}
  ------------------ -----------------------------------------------------------------------------
  Name               Description
  CurrentListLevel   Gets or sets paragraph\'s ListLevel.
  CurrentListStyle   Gets paragraph\'s list style.
  CustomStyleName    Gets or sets name of custom style.
  ListLevelNumber    Gets or sets list nesting level.
  ListType           Gets or sets type of the list.
  RestartNumbering   Gets or sets whether numbering of the list must restart from previous list.
  ------------------ -----------------------------------------------------------------------------
:::

 

Public Methods

 

::: {align="center"}
  ----------------------- ---------------------------------------------------------
  Name                    Description
  ApplyDefBulletStyle     Applies default bullet style for current paragraph.  
  ApplyDefNumberedStyle   Applies default numbered style for current paragraph.  
  ApplyStyle              Gets or sets name of custom style.  
  ContinueListNumbering   Continues last list.  
  DecreaseIndentLevel     Decreases level indent.  
  IncreaseIndentLevel     Increases level indent.  
  RemoveList              Removes the list from current paragraph.  
  ----------------------- ---------------------------------------------------------
:::

 

The following example illustrates how to use the WListFormat and list styles in DocIO.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                         |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [//Write default numbered list          ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                            |
|                                                                                                                                                                                                                        |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"First Numbered ( level 0 )\"]{style="COLOR: maroon"} );      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ApplyDefNumberedStyle();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"Level 1\"]{style="COLOR: maroon"} ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ContinueListNumbering();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.IncreaseIndentLevel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"Level 0\"]{style="COLOR: maroon"} ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ContinueListNumbering();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.DecreaseIndentLevel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                        |
| [section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [//Write default bulleted list  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"First bulleted ( level 0 )\"]{style="COLOR: maroon"} );      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ApplyDefBulletStyle();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"Level 1\"]{style="COLOR: maroon"} ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ContinueListNumbering();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.IncreaseIndentLevel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"Level 0\"]{style="COLOR: maroon"} ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ContinueListNumbering();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.DecreaseIndentLevel();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                        |
| [section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [//Write mixed bulleted and numbered list ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                                        |
| [ListStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ myStyle = doc.AddListStyle( [ListType]{style="COLOR: teal"}.Numbered, [\"UserStyle\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                        |
| [WListLevel]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ listLevel1 = myStyle.Levels\[ 0 \];]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                        |
| [listLevel1.FollowCharacter = [FollowCharacterType]{style="COLOR: teal"}.Tab;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                        |
| [listLevel1.TextPosition = 80f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [listLevel1.NumberAlignment = [ListNumberAlignment]{style="COLOR: teal"}.Right;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                        |
| [listLevel1.TabSpaceAfter = 40f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                        |
| [listLevel1.StartAt = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                        |
| [listLevel1.NumberPrefix = [\"(((\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                        |
| [listLevel1.NumberSufix = [\"\*\*\*.\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"First numbered\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ApplyStyle( [\"UserStyle\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [ListStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ bulletStyle = doc.AddListStyle( [ListType]{style="COLOR: teal"}.Bulleted, [\"UserStyle1\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| [WListLevel]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ level = bulletStyle.Levels\[ 0 \];]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                        |
| [level.NumberPosition = 30f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                        |
| [level.TabSpaceAfter = 15f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                        |
| [level.FollowCharacter = [FollowCharacterType]{style="COLOR: teal"}.Tab;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"First bullet\"]{style="COLOR: maroon"} );      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ApplyStyle( [\"UserStyle1\"]{style="COLOR: maroon"} );     ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"Bulleted level 1\"]{style="COLOR: maroon"} );      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ContinueListNumbering();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                        |
| [paragraph.AppendText( [\"Numbered level 0 again\"]{style="COLOR: maroon"} );             ]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                        |
| [paragraph.ListFormat.ApplyStyle( [\"UserStyle\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                        |
| [section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                        |
| [section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                          |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [\'Write default numbered list          ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paragraph [As]{style="COLOR: blue"} IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"First Numbered ( level 0 )\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ApplyDefNumberedStyle()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"Level 1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ContinueListNumbering()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.IncreaseIndentLevel()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"Level 0\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ContinueListNumbering()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.DecreaseIndentLevel()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| [section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'Write default bulleted list  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                         |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"First bulleted ( level 0 )\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ApplyDefBulletStyle()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"Level 1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ContinueListNumbering()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.IncreaseIndentLevel()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"Level 0\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ContinueListNumbering()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.DecreaseIndentLevel()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| [section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'Write mixed bulleted and numbered list ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                               |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ myStyle [As]{style="COLOR: blue"} ListStyle = doc.AddListStyle(ListType.Numbered, [\"UserStyle\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ listLevel1 [As]{style="COLOR: blue"} WListLevel = myStyle.Levels(0)]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                             |
| [listLevel1.FollowCharacter = FollowCharacterType.Tab]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                             |
| [listLevel1.TextPosition = 80f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                             |
| [listLevel1.NumberAlignment = ListNumberAlignment.Right]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                             |
| [listLevel1.TabSpaceAfter = 40f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [listLevel1.StartAt = 3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| [listLevel1.NumberPrefix = [\"(((\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                             |
| [listLevel1.NumberSufix = [\"\*\*\*.\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                                                       |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"First numbered\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ApplyStyle([\"UserStyle\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bulletStyle [As]{style="COLOR: blue"} ListStyle = doc.AddListStyle(ListType.Bulleted, [\"UserStyle1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ level [As]{style="COLOR: blue"} WListLevel = bulletStyle.Levels(0)]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                             |
| [level.NumberPosition = 30f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                             |
| [level.TabSpaceAfter = 15f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                             |
| [level.FollowCharacter = FollowCharacterType.Tab]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"First bullet\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ApplyStyle([\"UserStyle1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"Bulleted level 1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ContinueListNumbering()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [paragraph.AppendText([\"Numbered level 0 again\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                             |
| [paragraph.ListFormat.ApplyStyle([\"UserStyle\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                             |
| [section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                             |
| [section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::::
