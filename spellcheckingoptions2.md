::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Spell Checking Options {#spell-checking-options style="tab-stops: 0pt"}

The Spell Checking engine can also be customized to ignore certain text or words from being spell checked. By setting the respective properties, these words will be overlooked and will not indicate them as misspelled words. This option will be effective when there are a number of  email id\'s and addresses, filenames, htmltags, combination of words and numbers, combination of upper and lower case words that are used frequently in the document.

 

Properties

**[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}** 

  --------------------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property                                                                                      Description
  [ExcludeEmailAddress]{style="COLOR: black"}[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}   [Specifies whether or not to ignore email address during Spell Ceck. Default value is True.]{style="COLOR: black"}[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}
  [ExcludeFilenames]{style="COLOR: black"}                                                      [Specifies whether or not to ignore file names during Spell Check. Default value is True.]{style="COLOR: black"}
  [ExcludeHtmlTags]{style="COLOR: black"}                                                       [Specifies whether or not to ignore html tags during Spell Check. Default value is True.]{style="COLOR: black"}
  [ExcludeInternetAddress]{style="COLOR: black"}                                                [Specifies whether or not to ignore internet address during Spell Check. Default value is True.]{style="COLOR: black"}
  [ExcludeWordsInMixedCase]{style="COLOR: black"}                                               [Specifies whether or not to ignore mixed case words during Spell Check.  Default value is False.]{style="COLOR: black"}
  [ExcludeWordsInUpperCase]{style="COLOR: black"}                                               [Specifies whether or not to ignore uppercase words during Spell Check. Default value is True.]{style="COLOR: black"}
  [ExcludeWordsWithNumbers]{style="COLOR: black"}                                               [Specifies whether or not to Spell Check numbers or words with numbers during Spell Check. Default value is True.]{style="COLOR: black"}
  --------------------------------------------------------------------------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{style="COLOR: #c00000"} 

Setting Spell Checking options  

Create a spell checker instance and set the spell checking options as given below:

**** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                           |
|                                                                                                                                                                                            |
| [SpellChecker]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ SpellCheck = [new]{style="COLOR: blue"} [SpellChecker]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeEmailAddress = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeFileNames = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeHtmlTags = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeInternetAddresses = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeWordsInMixedCase = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeWordsInUpperCase = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                            |
| [SpellCheck.ExcludeWordsWithNumbers = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

Sample Link

To access the sample link:

1.   Open the Synfusion Dashboard.

2.   Select **User Interface**.

3.   Click the WPF drop-down list and select **Explore Samples**.

4.   Navigate to **Tools** -\> **SpellChecker** -\> **SpellCheckerDemo**.

[]{#related-topics}
:::
