::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d3d93d8a-bf75-4dc3-9c1b-1e59ca3ba99c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d9f11dc0-c096-408b-bb0b-301142dda2b3){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=99dc3762-3a6c-4306-b62b-5aa347ed3105){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Callback Package](ms-xhelp:///?Id=8abd71e0-5dee-456d-840b-4751e98e8381){.d2h_breadcrumbsNormal}
:::

### CallbackMultiplexer {#callbackmultiplexer style="tab-stops: 0pt"}

 

 

A CallbackMultiplexer gives you the most flexibility when executing callbacks. In a general sense, you can trigger a callback from any event in the page on the multiplexer and return any data from multiplexer\'s Callback event handler, all this without automatically affecting any UI in the page. On the other hand you can also choose to update the contents of more than one callback control or panel in the Callback event handler and hence the name multiplexer.

The CallbackMultiplexer control is a CallbackWebControl-derived class that lets you invoke AJAX style callbacks from the client and refresh the contents of Multiple CallbackPanels in the server.

The common usage for this control is very simple.

 

1.   Drag the CallbackMultiplexer control from the Toolbox onto your page.

20.  Fill more CallbackPanels and add more controls inside these panels.

21.  Decide which and when to invoke a callback on these CallbackPanels. For example, on a button click or listbox selection change.

22.  Write java script code to invoke the callback on panel from button element\'s click, for example, as given below.

 

  ----------------------------------------------------------------------------------------------------------------------------------
  [\_sfCallbackMultiplexer1.callback([\"some args\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}
  ----------------------------------------------------------------------------------------------------------------------------------

 

This will load the page on server and calls the CallbackMultiplexer\'s Callback event handler. In this event handler, the new values that the user might have selected / changed in the page are available based on which you can update CallbackPanel\'s content.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                       |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} CallbackMultiplexer1_Callback([object]{style="COLOR: blue"} sender, Syncfusion.Web.UI.WebControls.CallbackEventArgs e)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                       |
| [   [// Refresh elements within the particular Callback panels based up on the Arguments ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                    |
| [Protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [Sub]{style="COLOR: blue"} CallbackMultiplexer1_Callback([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} Syncfusion.Web.UI.WebControls.CallbackEventArgs)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                    |
| [    [\' Refresh elements within the particular Callback panels based up on the Arguments ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                    |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p253} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Events](ms-xhelp:///?Id=d8c1c30f-73d9-4fb9-aed8-4082231d3986){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Refreshing multiple CallbackPanels through CallbackMultiplexer](ms-xhelp:///?Id=3e42bfe7-b3e8-4690-a382-df7c9a7ade18){style="TEXT-DECORATION: none"}
::::
