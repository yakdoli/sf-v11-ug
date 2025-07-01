::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### [Client-Side Object Model]{style="FONT-WEIGHT: normal"} {#client-side-object-model style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------- ----------- ------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Method    Parameter   Return Type   Description
  GetHTML   \-          string        Returns HTML editor content.
  SetHTML   string      \-            Sets HTML editor content.
  GetText   \-          string        Returns editor content text (formatting removed).
  SetText   string      \-            Sets editor content text. If HTML tags are present content is HTML-encoded. To set HTML use SetHTML() method.
  Refresh   string      \-            **For .NET Framework version 2.0 only**. Sends callback to server without page refreshing and triggers CallbackRefresh server side RTE event. To perform callback the EnableCallbacks property must be set to true.
  --------- ----------- ------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following code example demonstrates how to add link to editor html.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[cc1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[RichTextEditor]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[ [ID]{style="COLOR: red"}[=\"RTE\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[input]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}[ [type]{style="COLOR: red"}[=\"button\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"Add link\"]{style="COLOR: blue"} [onclick]{style="COLOR: red"}[=\"AddLink()\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[javascript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                      |
|                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                    |
|                                                                                                                                                               |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[  AddLink()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                  |
|                                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                       |
|                                                                                                                                                               |
| [    [var]{style="COLOR: blue"} sHTML = \_sfRTE.GetHTML();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                               |
|                                                                                                                                                               |
| [    sHTML += [\"\<br/\>\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                      |
|                                                                                                                                                               |
| [    sHTML += [\"\<A href=\\\"http://www.syncfusion.com\\\"\>Syncfusion\</A\>\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                               |
| [    \_sfRTE.SetHTML(sHTML);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                             |
|                                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

RTE ClientEventData object

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

ClientEventData

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

::: {align="center"}
  ---------- ------------- ---------------------------------------------
  Property   Parameter     Description
  El         HTMLElement   Represents control root HTML element.
  Self       object        Represents RTE client-side object instance.
  Event      object        Represents event.
  HTML       string        Represents editor HTML content.
  ---------- ------------- ---------------------------------------------
:::

 

 

ClientObjectID

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

You can access the Client-Side Object Model  by using the ClientObjectID of the RichTextEditor control.

 

The ClientObjectID can be used effectively to refer to the control\'s objects when used with MasterPages and UserControls. By default, a client object ID is computed by concatenating the *\_sf* and the control\'s *ID* property. In case of hosting the control in a MasterPage or UserControl, the computed client object ID cannot be identified spontaneously. To make this  simple, you can specify a custom value in this property and access the client-side object model using that value.

 

::: {align="center"}
  ---------------- ------------------------------------------------------------------------ ------------- ----------- -----------------
  Property         Description                                                              Type          Data Type   Reference Links
  ClientObjectID   Specifies the user defined ID for accessing the object on client side.   Server side   String      NA
  ---------------- ------------------------------------------------------------------------ ------------- ----------- -----------------
:::

 

[Programmatically the ClientObjectID can be set as given in the following codes:]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                       |
|                                                                                                                                                                       |
|                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.RichTextEditor1.ClientObjectID = [\"CustomID\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                         |
|                                                                                                                                                                         |
|                                                                                                                                                                         |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ RichTextEditor1.ClientObjectID = [\"CustomID\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The following code examples demonstrate how to add link to editor HTML using custom ClientObjectID.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[cc1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RichTextEditor]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [ID]{style="COLOR: red"}[=\"RTE\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\" ]{style="COLOR: blue"}[ClientObjectID]{style="COLOR: red"}[=\"RTEditor\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[input]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"button\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"Add link\"]{style="COLOR: blue"} [onclick]{style="COLOR: red"}[=\"AddLink()\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[javascript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                      |
|                                                                                                                                               |
|                                                                                                                                               |
|                                                                                                                                               |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  AddLink()]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                               |
| [    [var]{style="COLOR: blue"} sHTML = RTEditor.GetHTML();]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                               |
| [    sHTML += [\"\<br/\>\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                               |
| [    sHTML += [\"\<A href=\\\"http://www.syncfusion.com\\\"\>Syncfusion\</A\>\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                               |
| [    RTEditor.SetHTML(sHTML);]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
::::::
