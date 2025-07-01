::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Tabs {#tabs style="tab-stops: 0pt"}

 

**Tabs** class represents a tab collection within a paragraph. **Tab** class represents a single tab within the tab collection.

 

**Class Hierarchy**

 

WParagraphFormat

   \|

    Tabs

 

Public Properties

 

::: {align="center"}
  --------------- --------------------------------------
  Name            Description
  Justification   Gets or sets the tab justification.
  TabLeader       Gets or sets the tab leader.
  Position        Gets or sets the tab position.
  DeletePostion   Gets or sets the Clear tab position.
  --------------- --------------------------------------
:::

 

Public Methods

 

::: {align="center"}
  ------------------------------------------------------------------------- ---------------------------------------------------------------------------------
  Name                                                                      Description
  AddTab()                                                                  Adds default tab to the paragraph.
  AddTab(float position)                                                    Adds tab at the specfied position.
  AddTab(float position, TabJustification justification TabLeader leader)   Adds tab at specified location with the specified tab justification and leader.
  RemoveAt(int index)                                                       Removes tab at specified index from the tab collection.
  RemoveByTabPosition(float position)                                       Removes tab at specified tab position from the tab collection.
  ------------------------------------------------------------------------- ---------------------------------------------------------------------------------
:::

 

The following code examples illustrate how to add the tab to the paragraph and delete the tab from the paragraph.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                      |
|                                                                                                                                                                                                               |
| [//Create a new instance for the word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                               |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                               |
| [//Add one section to the document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                               |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ section=document .AddSection ();]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                               |
| [//Add one paragraph to the section]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                               |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ paragraph=section.AddParagraph ();]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [//Add tab stop at the postion 36 with tab justification\[left\] and tab leader\[dotted\]]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                  |
|                                                                                                                                                                                                               |
| [paragraph .ParagraphFormat .Tabs.AddTab(36,[TabJustification]{style="COLOR: #2b91af"} .Left ,Syncfusion.DocIO.DLS.[TabLeader]{style="COLOR: #2b91af"} .Dotted );]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                               |
| [//Add tab stop at the postion 80 with tab justification\[Right\] and tab leader\[Hyphenated\]]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                             |
|                                                                                                                                                                                                               |
| [paragraph .ParagraphFormat .Tabs.AddTab(80,[TabJustification]{style="COLOR: #2b91af"} .Right ,Syncfusion.DocIO.DLS.[TabLeader]{style="COLOR: #2b91af"}.Hyphenated  );]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                               |
| [//Add tab stop at the postion 144 with tab justification\[Center\] and with no tab leader]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                 |
|                                                                                                                                                                                                               |
| [paragraph .ParagraphFormat .Tabs.AddTab(144,[TabJustification]{style="COLOR: #2b91af"} .Centered ,Syncfusion.DocIO.DLS.[TabLeader]{style="COLOR: #2b91af"} .NoLeader );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [//Remove tab at index 1 from the tab collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                               |
| [paragraph .ParagraphFormat .Tabs .RemoveAt (1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                               |
| [//Remove tab at the position 144]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                               |
| [paragraph .ParagraphFormat .Tabs .RemoveByTabPosition (144);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                               |
| [//Append tab character]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                               |
| [paragraph.AppendText([\"\\t\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                               |
| [//Append Text to the paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                            |
|                                                                                                                                                                                                               |
| [paragraph.AppendText([\"Tabs are added and removed\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                               |
| [//Save the word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                               |
| [document .Save ([\"Sample.doc\"]{style="COLOR: #a31515"},[FormatType]{style="COLOR: #2b91af"}.Doc  );]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                            |
|                                                                                                                                                                           |
| []{style="COLOR: black"}                                                                                                                                                  |
|                                                                                                                                                                           |
| [\'Create a new instance for the word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                         |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [\'Add one section to the document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} IWSection = document.AddSection()]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                           |
| [\'Add one paragraph to the section]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                    |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paragraph [As]{style="COLOR: blue"} IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [\'Add tab stop at the postion 36 with tab justification\[left\] and tab leader\[dotted\]]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                              |
|                                                                                                                                                                           |
| [paragraph.ParagraphFormat.Tabs.AddTab(36, TabJustification.Left, Syncfusion.DocIO.DLS.TabLeader.Dotted)]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                           |
| [\'Add tab stop at the postion 80 with tab justification\[Right\] and tab leader\[Hyphenated\]]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                         |
|                                                                                                                                                                           |
| [paragraph.ParagraphFormat.Tabs.AddTab(80, TabJustification.Right, Syncfusion.DocIO.DLS.TabLeader.Hyphenated)]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                           |
| [\'Add tab stop at the postion 144 with tab justification\[Center\] and with no tab leader]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                             |
|                                                                                                                                                                           |
| [paragraph.ParagraphFormat.Tabs.AddTab(144, TabJustification.Centered, Syncfusion.DocIO.DLS.TabLeader.NoLeader)]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [\'Remove tab at index 1 from the tab collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                       |
|                                                                                                                                                                           |
| [paragraph.ParagraphFormat.Tabs.RemoveAt(1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                           |
| [\'Remove tab at the position 144]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                           |
| [paragraph.ParagraphFormat.Tabs.RemoveByTabPosition(144)]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                           |
| [\'Append tab character]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                           |
| [paragraph.AppendText([\"\\t\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                           |
| [\'Append Text to the paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                           |
| [paragraph.AppendText([\"Tabs are added and removed\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                           |
| [\'Save the word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                              |
|                                                                                                                                                                           |
| [document.Save([\"Sample.doc\"]{style="COLOR: #a31515"}, FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::
