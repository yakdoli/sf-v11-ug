::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7f22dd56-cc2a-4a7f-bce3-060b1c950040){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6767efa7-2b84-4cc5-9d55-93f892ac64a2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Function Library](ms-xhelp:///?Id=7f22dd56-cc2a-4a7f-bce3-060b1c950040){.d2h_breadcrumbsNormal}
:::

### Add Function {#add-function style="tab-stops: 0pt"}

 

**CalcQuickBase** relies on a Calculate.Engine object through an **ICalcData** interface to provide its calculation support. To add functions to the Formula Library available to your CalcQuickBase object, you need to add them to the **CalcQuickBase\'s** underlying Engine object. You can access this engine object through the public \"read-only\" property, CalcQuickBase.Engine. Once you have a reference to the CalcQuickBase\'s Engine object, you can add library functions by following the steps given below.

 

Adding a custom function to the Formula Library is a two step process.

 

The first step is to write a method that actually does the calculation work for your custom function. The second step is to register this method with the CalcEngine. So, if your CalcEngine object is a member of a form, you can add your additional function methods to the form and then register these methods with the CalcEngine object after the object has been created, in Form_Load for example.

 

The above steps have been explained in detail in the following topics:

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Step 1-Writing the Method](ms-xhelp:///?Id=84f29e69-294d-488e-aace-e2f21f1d2939){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Step 2-Registering the Method with the CalcEngine](ms-xhelp:///?Id=8246bac4-0d4a-4251-b647-08af739ed913){style="TEXT-DECORATION: none"}
::::
