::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4f03daee-0355-49e3-8df6-19356be64765){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3b6df348-8c96-4eca-9257-99b0321447df){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Features of Spell Checker

Spell Checking Options

The spell checking engine can also be customized to ignore certain text or words from being spell checked. By setting the respective properties, these words will be overlooked and will not be indicated as misspelled words. This option will be effective when there are many email IDs and addresses, filenames, htmltags, combinations of words and numbers, combinations of upper and lower case words that are used frequently in the document.

 

 

Properties

 

  ----------------------------------------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property                                                                            Description
  ExcludeEmailAddress[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}   Specifies whether or not to ignore email addresses, during spell check. The default value is True.[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}
  ExcludeFilenames                                                                    Specifies whether or not to ignore file names, during spell check. The default value is True.
  ExcludeHtmlTags                                                                     Specifies whether or not to ignore html tags, during spell check. The default value is True.
  ExcludeInternetAddress                                                              Specifies whether or not to ignore internet addresses, during spell check. The default value is True.
  ExcludeWordsInMixedCase                                                             Specifies whether or not to ignore mixed case words, during spell check. The default value is False.
  ExcludeWordsInUpperCase                                                             Specifies whether or not to ignore uppercase words, during spell check. The default value is True.
  ExcludeWordsWithNumbers                                                             Specifies whether or not to spell check words with numbers, during spell check. The default value is True.
  ----------------------------------------------------------------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

 

Setting Spell Checking options  

Create a spell checker instance and set the spell checking options as given below:

 

+------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                          |
| [SpellChecker SpellCheck = new SpellChecker();]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                          |
| [SpellCheck.ExcludeEmailAddress = true;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                          |
| [SpellCheck.ExcludeFileNames = true;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                          |
| [SpellCheck.ExcludeHtmlTags = true;]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                          |
| [SpellCheck.ExcludeInternetAddresses = true;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                          |
| [SpellCheck.ExcludeWordsInMixedCase = true;]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                          |
| [SpellCheck.ExcludeWordsInUpperCase = true;]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                          |
| [SpellCheck.ExcludeWordsWithNumbers = true;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------+

 

Sample Link

To view samples:

1.   Open the Synfusion Dashboard.

2.   Select User Interface.

3.   Click the SL drop-down list and select Explore Samples.

4.   Navigate to **Tools -\> SpellChecker -\> SpellCheckerDemo**.

 

More:

[ ]{#related-topics}

[![](../button.gif){border="0" align="absMiddle"}User Dictionary](ms-xhelp:///?Id=8e88ac0b-7dcd-4965-b4ac-1f3b1795f3b2){style="TEXT-DECORATION: none"}

[![](../button.gif){border="0" align="absMiddle"}SpellCheckDialog](ms-xhelp:///?Id=efee2acd-e490-4cb9-aa87-05b6260bf735){style="TEXT-DECORATION: none"}
:::
