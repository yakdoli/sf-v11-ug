::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Events for the SpellCheck Control {#events-for-the-spellcheck-control style="tab-stops: 0pt"}

Support has been incorporated into the SpellCheck for Client and Server-side events.

Client-side events can be triggered at the start and end of the SpellCheck of every control.

A Server-side event can be triggered at the end of the SpellCheck of all the controls.

Use Case Scenarios-

**For Client-Side Events:**

The user can change the properties of the control at the beginning and end of the SpellCheck of that control.

For Example-

Consider a page on which you have three text boxes. You have started the SpellCheck control, but you don't know for which one the SpellCheck is going on, since the control will check the text in all the three text boxes.

In order to see which text box is getting checked, you can modify the properties of the control while the SpellCheck is running, so that this textbox gets highlighted.

For Server-Side Events:

The Server-side events for the SpellCheck control allow the user to save data to the server without any errors in spelling.

Properties

There is only one Server-side property for the events of the Spellchecker control:

 

::: {align="center"}
+--------------+-------------------------------------------------------------------------------------------+------------------+---------------------------------------------+--------------+
| Property     | Description                                                                               | Type of Property | Value it accepts                            | Dependencies |
+--------------+-------------------------------------------------------------------------------------------+------------------+---------------------------------------------+--------------+
| Autopostback | Allow us to specify the postback of the control which needs to be fired.                  | bool             | [·      ]{style="FONT-FAMILY: Symbol"}True  | NA           |
|              |                                                                                           |                  |                                             |              |
|              |                                                                                           |                  | [·      ]{style="FONT-FAMILY: Symbol"}False |              |
|              |                                                                                           |                  |                                             |              |
|              | If Autopostback is set to **true**,then both Client and **Server-side** events are fired. |                  |                                             |              |
|              |                                                                                           |                  |                                             |              |
|              |                                                                                           |                  | Default value is False                      |              |
|              |                                                                                           |                  |                                             |              |
|              | If Autopostback is set to **false**, then only the **client-side** events are fired.      |                  |                                             |              |
+--------------+-------------------------------------------------------------------------------------------+------------------+---------------------------------------------+--------------+
:::

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: There are no properties for Client-side events.
:::

 

 

Events

 

Client Side Events

 

::: {align="center"}
  -------------------------------- --------------------------------------------------------------------------------------------------------------------
  Name                             Description
  ClientSideOnSpellCheckStarted    Allows you to specify the client-side function when SpellCheck is started.
  ClientSideOnSpellCheckComplete   Allows you to specify the client-side function (which executes after the Spellcheckcompletion) for the SpellCheck.
  -------------------------------- --------------------------------------------------------------------------------------------------------------------
:::

 

Server Side Events

 

  ---------------------- -----------------------------------------------------------------------------------------------------------------
  Name                   Description
  OnSpellCheckComplete   Allow us to specify the server side function for the spell-check which executes after the spellcheckcompletion.
  ---------------------- -----------------------------------------------------------------------------------------------------------------

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Adding events for the SpellCheck Control to ASP.NET Tools](ms-xhelp:///?Id=844ef4cd-1e0e-43f5-9ff2-83b13085b8b8){style="TEXT-DECORATION: none"}
::::::
