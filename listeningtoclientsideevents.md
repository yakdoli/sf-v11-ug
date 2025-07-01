::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=89268e42-e318-48e9-95ed-ddd33211b5b1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c65855e5-29ff-4d50-b72f-f4a4469f33cd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=99dc3762-3a6c-4306-b62b-5aa347ed3105){.d2h_breadcrumbsNormal}
:::

## []{style="FONT-SIZE: 10pt"}[]{#p661}Listening to Client Side Events {#listening-to-client-side-events style="tab-stops: 0pt"}

 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ClientSideXXX properties

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

Most of the controls in Tools.Web provide properties where you can specify some Java Script code that you want executed for some client event. For example, **Menu.ClientSideOnItemSelect** is a property in our Menu control where you can specify some JS code that you want to be executed when a menu gets selected.

 

The specified value (code) will be evaluated as follows during run time.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Java Script:]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                          |
| [\....]{style="COLOR: black"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                          |
| [eval( [\"bCont=(\"]{style="COLOR: maroon"} + clientCode + [\")\"]{style="COLOR: maroon"} ); [// where clientCode is the value of the above ClientSideOnItemSelect property.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [\....]{style="COLOR: black"}                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

So, provide Java Script code that are executable without syntax errors, within the above statement.

Some valid values are given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"someFunction()\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                             |
|                                                                                                                                                                                                                                            |
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"myFunction(this)\" ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[// More on the \"this\" pattern below]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                                                                            |
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"a+b\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                        |
|                                                                                                                                                                                                                                            |
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"false\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Some invalid values are given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"return false;\" ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\<%\--The \"return\" keyword is invalid in this context. Just specify \"false\".\--%\>]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                      |
|                                                                                                                                                                                                                                                                                                               |
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"a+b;\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  ]{style="COLOR: black"}[\<%\--Remember not to use \";\" \--%\>]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                      |
|                                                                                                                                                                                                                                                                                                               |
| [ClientSideOnItemSelect]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"myFunc(arg1)\" ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\<%\--\"arg1\" will be invalid when evaluated; \"this\" is the only valid argument  that can be passed\--%\>]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

*[this]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}* Argument

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

Note that when your event handler code is executed, it will be executed in the scope of the client side object corresponding to the event you are listening to. In this example, \"this\" would refer to the client side object representing the menu item (not the overall menu) that was selected.

For example, specify the event handler code as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [Menu]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.ClientSideOnItemSelect = [\"MyFunc(this)\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For the above event handler code, you can define the function as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MyFunc(oMenuItem)]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                |
| [      [var]{style="COLOR: blue"} theEvent = oMenuItem.Event; [// Provides reference to the event.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| [      [var]{style="COLOR: blue"} text = oMenuItem.Text;    [// Also use the client side API of the menu item.\                                                |
|       \.....]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p662} 

[]{#related-topics}
::::
