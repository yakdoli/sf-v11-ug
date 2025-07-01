::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=26b63a83-2025-466b-b99a-437522255425){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2e5e553d-7f2b-4e5a-b18a-339af9e9e13d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=99dc3762-3a6c-4306-b62b-5aa347ed3105){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Editors Package](ms-xhelp:///?Id=1534f372-551a-461d-8ed1-14747acc09f8){.d2h_breadcrumbsNormal}
:::

### SpellCheckControl {#spellcheckcontrol style="MARGIN-LEFT: 1.8pt; tab-stops: 1.8pt"}

 

The ASP.NET SpellCheckControl component, including an electronic dictionary, allows you to easily perform a spell check on any of the ASP.NET controls text values and automatically provides the user, suggestions for correcting misspelled words using an in-built dialog.

 

[Powerful Spell Check Engine]{style="FONT-WEIGHT: normal"}

 

The SpellCheckControl implements a complex spell checking algorithm. The suggestion list for a misspelled word is generated using **Near Miss Strategy** and **Phonetic** (sounds like) matching.

 

[·      ]{style="FONT-FAMILY: Symbol"}The Near Miss Strategy is a simple way to generate the suggestion list with words that closely match the spelling of the mistyped word.

[·      ]{style="FONT-FAMILY: Symbol"}A phonetic match provides the suggestion list with words that sound similar to the misspelled word using **Soundex** algorithm.

 

The list is then ranked using the **Edit Distance** algorithm and gets displayed in the Suggestion list.

 

AJAX enabled

 

When spell check is invoked, the SpellCheckControl uses the 2.0 AJAX framework to perform a callback with the sentence to spell check as an argument. The callback then returns the misspelled word and suggestion list which gets displayed in the in-built dialog box to let the user pick the correct words. Using callbacks significantly improves performance and lowers the load on the server.

 

Built-in Integration

 

The Essential Tools RichTextEditor control incorporates SpellCheckControl to automatically support spell check the contents edited by the user. Similarly, the control could be easily integrated with any other custom controls.

 

Client API

 

Simple API on the client side lets you optionally, manually invoke a spell check on any string and also provides a user friendly UI during run time for spell correction.

 

Spell Dialog Form

 

The control comes with a built-in rich dialog form. This aspx page needs to be deployed in the application folder. You can change the style settings and page layout based on your design requirements to fully customize the page.

 

Check For Repeated Words

 

The spell check engine also detects repeated words and lets the user correct it.

 

Check Selection

 

The control can also restrict it\'s spell check to the selected text.

[]{#p143} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Performing Spell check](ms-xhelp:///?Id=3b9919ae-67fa-4e41-bd5a-3940c33600b9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Concepts and Features](ms-xhelp:///?Id=b2b52b21-276c-47c3-ae6e-9d5935bbbaaa){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Events for the SpellCheck Control](ms-xhelp:///?Id=4e6b0428-6603-4739-b455-3382470628b9){style="TEXT-DECORATION: none"}
::::
