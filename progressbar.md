::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=014e4dc8-6bde-4ba3-bf6f-a3cffefdf344){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=11d19af6-2f8a-4f51-814b-ebd99f08fd87){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=99dc3762-3a6c-4306-b62b-5aa347ed3105){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Notification Package](ms-xhelp:///?Id=29371862-8248-4f92-80cc-129b797d975c){.d2h_breadcrumbsNormal}
:::

### ProgressBar {#progressbar style="tab-stops: 0pt"}

 

 

The ProgressBar control is ideal to show the progress of a lengthy operation on the server with a live progress bar on the client.

[·      ]{style="FONT-FAMILY: Symbol"}Uses asynchronous callbacks.

[·      ]{style="FONT-FAMILY: Symbol"}Fires a callback event called UpdateProgress that the user can listen to and update the ProgressPercentage.

[·      ]{style="FONT-FAMILY: Symbol"}Frequency property indicates the time interval at which progress should be updated.

[·      ]{style="FONT-FAMILY: Symbol"}ProgressBar control can be hosted in Safari browser too.

   

Limitations in using the ProgressBar

 

The ProgressBar control relies on being able to trigger asynchronous callbacks to update the progress state. But, such calls are prevented by the framework when Session states are used in an application. If you use Session state in your application you will notice that the progress does not update smoothly. It would go from 0 to 100% directly.

So, the workaround is to not use Session state in your application or isolate the ProgressBar using logic in a separate application that does not use Session state.

[]{#p585} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating ProgressBar](ms-xhelp:///?Id=8a0ccbf8-1b67-49fe-af1d-8338f8013b5f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Concepts and Features](ms-xhelp:///?Id=8d92a307-4d95-431d-8779-4f577beb1624){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Events](ms-xhelp:///?Id=06677de1-300a-40b1-bf74-b6a240f8300b){style="TEXT-DECORATION: none"}
::::
