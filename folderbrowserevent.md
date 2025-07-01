::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### FolderBrowser Event {#folderbrowser-event style="tab-stops: 0pt"}

[]{#p499}[]{style="COLOR: #15428b"} 

A detailed explanation about the FolderBrowserCallback event is given in the following section.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ----------------------- -------------------------------------------------------------------------------------------------------------
  FolderBrowser Event     Description
  FolderBrowserCallback   The event occurs when an event within the Folder Browser Dialog triggers a call to the validation callback.
  ----------------------- -------------------------------------------------------------------------------------------------------------
:::

 

[]{#p500} 

###### 3.3.7.1.4.1 FolderBrowserCallback Event {#folderbrowsercallback-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The event occurs when an event within the folder browser dialog triggers a call to the validation callback. The event handler receives an argument of type **FolderBrowserCallbackEventArgs**.

 

The following FolderBrowserCallbackEventArgs[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"}members provide information specific to this event.

 

::: {align="center"}
  ------------------------------- ------------------------------------------------------------------------------------------
  Members                         Description
  Dismiss                         Specifies whether the dialog is either dismissed or retained depending upon this value.
  FolderBrowserCallbackSetState   Gets / sets the Folder Browser dialog\'s state.
  BrowseCallbackText              Gets / sets the contextual string based upon the FolderBrowserCallbackSetState property.
  FolderBrowserMessage            Returns a value indentifying the event.
  Path                            Returns valid or invalid folder name.
  Window                          Returns window handle of browser dialog box.
  ------------------------------- ------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

It can be handled when browser validation is required.

 

This handler is functionally equivalent to the **Win32 BrowseCallbackProc** callback function.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                       |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} folderBrowser1_BrowseCallback([object]{style="COLOR: blue"} sender, Syncfusion.Windows.Forms.[FolderBrowserCallbackEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                       |
| [// We can log the events and Folder Browser Message to the Label control.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.label1.Text = [String]{style="COLOR: #2b91af"}.Format([\"Event: {0}, Path: {1}\"]{style="COLOR: #a31515"}, e.FolderBrowserMessage, e.Path);]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                                                                                                       |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (e.FolderBrowserMessage == FolderBrowserMessage.ValidateFailed)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                       |
| [e.Dismiss = e.Path != [\"NONE\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} folderBrowser1_BrowseCallback([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.FolderBrowserCallbackEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [\' We can log the events and Folder Browser Message to the Label control.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.label1.Text = [String]{style="COLOR: blue"}.Format([\"Event: {0}, Path: {1}\"]{style="COLOR: maroon"}, e.FolderBrowserMessage, e.Path)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ e.FolderBrowserMessage = FolderBrowserMessage.ValidateFailed [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [e.Dismiss = e.Path \<\> [\"NONE\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::::
