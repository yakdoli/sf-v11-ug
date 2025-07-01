::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7963ba34-946c-4d71-adc8-e006ad8d625a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=43cb4ee7-d6a4-4c7e-af6a-4b200269e1ae){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential HTML UI]{.d2h_breadcrumbsContentsOnly}
:::

# Concepts And Features {#concepts-and-features style="tab-stops: 0pt"}

 

The HTMLUIControl is the main control of the HTMLUI library. The control exposes several properties, methods and events to load, display and interact with rich HTML-based user interfaces.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Creating the HTMLUI Control

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The HTMLUI control can be created by dragging it from the Visual Studio .NET toolbox, just like any other Windows Forms control.

The following code snippet illustrates how to create a HTMLUIControl programmatically.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| [// Initialize a HTMLUIControl.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[.htmluiControl1 = [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.HTMLUI.[HTMLUIControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Important Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following properties help you to get started with the HTMLUIControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property          Description
  StartupDocument   This is the path to the HTML document that will be loaded when the HTMLUIControl is called. Using this property to set a document is the simplest means to load an HTML document.
  Text              The HTMLUIControl does not display the Text property as text. This is the HTML that will be rendered as in the HTMLUIControl. This is the equivalent of the View Source option in a traditional web browser.
  Document          This property provides access to all the display HTML elements programmatically.
  ----------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Important Methods

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following methods help you to get started with the HTMLUIControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------- --------------------------------------------------------------------------------
  Method     Description
  LoadHTML   This method is used to load the HTML document.
  LoadCSS    This method is used to load CSS styles from file and refresh current document.
  ---------- --------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Loading HTML](ms-xhelp:///?Id=43cb4ee7-d6a4-4c7e-af6a-4b200269e1ae){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}MHT Formats](ms-xhelp:///?Id=f04cde59-4141-491f-9457-b063c57535e7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Control Events](ms-xhelp:///?Id=6b1e144c-e72e-4e8c-b660-68a6c5b797af){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Element Events](ms-xhelp:///?Id=c6bd5160-9cd4-43c6-ac24-30be38474de5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Elements](ms-xhelp:///?Id=aae39d32-dc39-4d21-aaa8-26cadaa44333){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Tags](ms-xhelp:///?Id=e2f7b4d3-2fdf-48e5-a144-5d44b29c1d76){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Custom Controls](ms-xhelp:///?Id=877c6103-287e-415d-9155-3f3ef685e097){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Forms](ms-xhelp:///?Id=e3ad4d86-fecb-4b2a-9b2c-fe3899bfa015){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Bookmarks](ms-xhelp:///?Id=33362f83-8107-43ac-bbd5-c3dac69edb0d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Tables](ms-xhelp:///?Id=b08818ac-563e-4652-a8f4-8226744d8f04){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Layout](ms-xhelp:///?Id=17a4d9cf-cafe-4dd2-80ca-de66b7a5985f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Renderer](ms-xhelp:///?Id=9f67c9dc-c1e3-469f-8c7f-176ded2aeeab){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Style Sheets CSS](ms-xhelp:///?Id=f035a77b-5395-4ad5-8d87-af365947ca45){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTMLUI Appearance](ms-xhelp:///?Id=3fd0254f-5007-418d-9f15-1663442493b8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Format](ms-xhelp:///?Id=95cea2d2-0f16-4a2e-94f3-5a7976c66b80){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Element Format](ms-xhelp:///?Id=4bf38ac5-9f31-4777-aa67-270482abaf2b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Exporting](ms-xhelp:///?Id=bf48aa24-db67-4947-9691-a72a9f06918a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Keyboard](ms-xhelp:///?Id=8ce87a7f-1058-4b58-a4e0-efcc1351da79){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Printing](ms-xhelp:///?Id=0f4ecd17-71b6-4d91-91b5-52a49658f9e4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Searching](ms-xhelp:///?Id=87f59765-26be-4f7c-a229-276f0bcf3637){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Scrolling](ms-xhelp:///?Id=5c3f452f-d3ed-4f6f-8cbd-8e7179669be6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Scripting](ms-xhelp:///?Id=825cc5dc-6b26-4691-8e6b-bca205065891){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Text Selection](ms-xhelp:///?Id=fe3fbb1e-e50e-4c1e-85a1-0b00256273d3){style="TEXT-DECORATION: none"}
::::::
