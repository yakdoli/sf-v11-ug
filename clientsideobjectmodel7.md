::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Client-Side Object Model {#client-side-object-model style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Methods

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

::: {align="center"}
  ----------------------------------- ----------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Method                              Parameter   Description
  Refresh                             string      []{#DDE_LINK1}**For .NET Framework version 2.0 only.** Sends callback to server without page refreshing and triggers CallbackRefresh server side TabStrip\'s event. To perform callback the **EnableCallbacks** property must be set to true .
  GetMultiPageID                      \-          Gets a value specifies the id of the multipage control to be integrated with tabstrip.
  SetMultiPageID                      string      Sets a value specifies the id of the multipage control to be integrated with tabstrip.
  SelectTabByText(\"TabText\")                    Selects TabStrip item based on the TabText.
  SelectTabByID(\"TabStripItemID\")               Selects TabStrip item based on the ID of the TabStrip item
  SelectTabByIndex(Index)                         Selects TabStrip Item based on index.
  SelectTab(TabStripItemObj)                      Selects TabStrip item based on the Tabstrip Object
  ----------------------------------- ----------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

TabStrip\'s ClientEventData Object

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

::: {align="center"}
  ------------ ------------- -----------------------------------------------------------------------------------
  Property     Parameter     Description
  ID           string        Specifies the client side item identifier.
  Text         string        Specifies the item text.
  PageViewID   string        Specifies ID of PageView element.
  Tooltip      string        Specifies the help message that showing when user moves mouse over TabStrip item.
  Disabled     bool          Specifies whether item is disabled.
  TemplateID   string        Specifies template ID which associates item with custom template.
  NaviURL      string        Specifies the item\'s target URL.
  HtmlID       string        Specifies the client side TabStrip identifier.
  Element      HTMLElement   Represents HTML item element.
  Event        object        Represents event.
  ------------ ------------- -----------------------------------------------------------------------------------
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                              |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                                   |
|                                                                                                                                                                                                       |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ OnItemSelect( EventData )]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                           |
|                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                               |
|                                                                                                                                                                                                       |
| [       [var]{style="COLOR: blue"} sText = [\"You selected item \'\"]{style="COLOR: maroon"} + EventData.Text + [\"\'\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                       |
| [       alert( sText );]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                          |
|                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

The following code illustrates how to select the tab by **SelectTabByText** method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**                                                |
|                                                                                                                  |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ selectbytext()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                  |
| [     {   ]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                  |
| [         Tab1_client.SelectTabByText([\"Tab1\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                  |
| [         [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                  |
| [     }]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
+------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}** 

The following code illustrates how to select the tab by **SelectTabByID** method.

+----------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**                                              |
|                                                                                                                |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ selectbyid()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                |
| [     {  ]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                |
| [         Tab1_client.SelectTabByID([\"Tab1\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                |
| [         [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                |
| [     }]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
+----------------------------------------------------------------------------------------------------------------+

[     ]{style="FONT-FAMILY: 'Courier New'"}

The following code illustrates how to select the tab by **SelectTabByIndex** method[.]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**                                                 |
|                                                                                                                   |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ selectbyindex()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                   |
| [     {  ]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                   |
| [         Tab1_client.SelectTabByIndex(0);]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                   |
| [         [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                   |
| [     }]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
+-------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code illustrates selects the tab by the Tab Item's client object.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**                                                                             |
|                                                                                                                                               |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ selectbytabobj()]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                               |
| [     {  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                               |
| [         [var]{style="COLOR: blue"} obj = Tab1_client.FindItemByID([\"Tab1\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                               |
| [         Tab1_client.SelectTab(obj);]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                               |
| [         [return]{style="COLOR: blue"} [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                               |
| [     }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::
