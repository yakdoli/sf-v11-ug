::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Events {#events style="tab-stops: 0pt"}

 

This section discusses the client-side and server-side events of the DropDownCalendarControl.

 

###### []{#_Client-Side_Events_4}5.1.2.3.3.1 Client-Side Events {#client-side-events style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The DropDownCalendarControl raises client side events that can be used to execute client side java script routines. This technique avoids postback and makes the control faster and more responsive.

The following are client-side events that are supported by the DropDownCalendarControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------- ------------------------------------------------------------------------------------------------------
  Event                     Description
  ClientSideOnFocusIn       Specifies the client side handler which will be called when control is in focus.
  ClientSideOnFocusOut      Specifies the client side handler which will be called when focus is shifted from the control.
  ClientSideOnMouseOut      Specifies the client side handler which will be called when mouse pointer leaves the control.
  ClientSideOnMouseOver     Specifies the client side handler which will be called when mouse pointer is moved over the control.
  ClientSideOnValueChange   Specifies the client side handler which will be called when the  value of control is changed.
  ------------------------- ------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To raise and process client side events

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   The client side events must be set to the respective functions to be executed when the events are triggered. The html view of the event settings are shown below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ssw]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[DropDownCalendar]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[ [Control]{style="COLOR: red"} [id ]{style="COLOR: red"}[= \"DropDownCalendar Control1\"]{style="COLOR: blue"} [runat ]{style="COLOR: red"}[= \"server\"]{style="COLOR: blue"} [Width ]{style="COLOR: red"}[= \"248px\"]{style="COLOR: blue"} [ClientSideOnFocusIn ]{style="COLOR: red"}[= \"GetDetails(\'OnFocus\', this)\"]{style="COLOR: blue"} [ClientSideOnFocusOut ]{style="COLOR: red"}[= \"GetDetails(\'OnBlur\', this)\"]{style="COLOR: blue"} [ClientSideOnMouseOver ]{style="COLOR: red"}[= \"GetDetails(\'OnMoseOver\', this)\"]{style="COLOR: blue"} [ClientSideOnMouseOut ]{style="COLOR: red"}[= \"GetDetails(\'OnMouseOut\', this)\"]{style="COLOR: blue"} [ClientSideOnValueChange ]{style="COLOR: red"}[= \"GetDetails(\'OnValueChange\', this)\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ssw]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[DropDownCalendar]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[ [Control]{style="COLOR: red"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   For the respective function names set to the client events, write the specific java script function. Here, for all the events, it lists the details of the corresponding event being fired and its details.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[ [language]{style="COLOR: red"}[=\"javascript\"]{style="COLOR: blue"} [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                     |
| [   [function]{style="COLOR: blue"} GetDetails( sCapt, oData )]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                     |
| [      {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          [var]{style="COLOR: blue"} sRes = [\"\"]{style="COLOR: maroon"} ;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          [var]{style="COLOR: blue"} sText = [\"\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          sRes = sCapt ;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          sRes = oData \[[\"ID\"]{style="COLOR: maroon"}\];]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          sRes = sRes.substring(0,(sRes.length-1));]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          sRes =  sRes + [\":\\t\"]{style="COLOR: maroon"} + sCapt + [\" Event is fired.\\n\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          sRes =sRes+ [\"ID\"]{style="COLOR: maroon"}+[\"\\t\\t\"]{style="COLOR: maroon"}+[\":\"]{style="COLOR: maroon"} +oData \[[\"ID\"]{style="COLOR: maroon"}\]+[\"\\n\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          sRes =sRes+ [\"Text\"]{style="COLOR: maroon"}+[\"\\t\\t\"]{style="COLOR: maroon"}+[\":\"]{style="COLOR: maroon"} +oData \[[\"Text\"]{style="COLOR: maroon"}\]+[\"\\n\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                     |
| [          [return]{style="COLOR: blue"} sRes;        ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                     |
| [      }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                     |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

###### 5.1.2.3.3.2 Server-Side Events {#server-side-events style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The server side events for the DropDownCalendar Control are as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Server-Side Event                 | Description                                                                                                                                                                                                                                    |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TextChanged                       | Occurs when the Text of DropDownCalendarControl changes between posts to the server.                                                                                                                                                           |
|                                   |                                                                                                                                                                                                                                                |
|                                   |                                                                                                                                                                                                                                                |
|                                   |                                                                                                                                                                                                                                                |
|                                   | **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                               |
|                                   |                                                                                                                                                                                                                                                |
|                                   | **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                     |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} DropDownCalendarControl1_TextChanged([object]{style="COLOR: blue"} sender, [EventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [      Label1.Text = DropDownCalendarControl1.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ValueChanged                      | Occurs when the Value of DropDownCalendarControl changes between posts to the server.                                                                                                                                                          |
|                                   |                                                                                                                                                                                                                                                |
|                                   | []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                           |
|                                   |                                                                                                                                                                                                                                                |
|                                   | **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                               |
|                                   |                                                                                                                                                                                                                                                |
|                                   | **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                     |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} DropDownCalendarControl1_ValueChanged([object]{style="COLOR: blue"} sender, [EventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [      Label2.Text = DropDownCalendarControl1.Value.ToShortDateString();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                   |                                                                                                                                                                                                                                                |
|                                   | [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| VisibleMonthChanged               | Occurs when visible month of popup Calendar is changed.                                                                                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| RenderDay                         | Occurs when each day cell in the current month of popup Calendar is being rendered.                                                                                                                                                            |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image72_1.jpg){border="0"}Note: AutoPostBack property has been depreciated. To execute the server side events, the AutoPostBackOnTextChanged and the AutoPostBackOnValueChanged properties must be enabled for the respective events, which triggers a postback and handles the server side event. If AutoPostBackOnValueChanged or AutoPostBackOnTextChanged is set to True, then Postback will be performed, only when the user changes the date in the DropDownCalendarControl\'s input html element and leaves the control.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To execute the server side **VisibleMonthChanged** event, the **AutoPostBackOnVisibleMonthChanged** property must be set to **True**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For more details, see [Server-Side Events]{.UGHyperlink} topic of Calendar control.

[]{#p79} 

[]{#related-topics}
::::::
