::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### User Dictionary {#user-dictionary style="tab-stops: 0pt"}

Spell Checker can also look into the specified user dictionary for spell checking.

 

Methods

**[]{style="COLOR: #4e84c4; FONT-SIZE: 13pt"}** 

::: {align="center"}
+---------------------------------------------------------------+-----------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Method                                                        | Prototype                                                                   | Description                                                                                                                                                                                                                   |
+---------------------------------------------------------------+-----------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [SetUserDictionary]{style="COLOR: black"}                     | [SetUserDictionary(string dicName),]{style="COLOR: black"}                  | [SetUserDictionary is an overloaded method. You can set the UserDictionary by passing the file name of the dictionary to this method or you can pass UserDictionary instance to this method]{style="COLOR: black"}            |
|                                                               |                                                                             |                                                                                                                                                                                                                               |
|                                                               | [SetUserDictionary(UserDictionary userDic)]{style="COLOR: black"}           |                                                                                                                                                                                                                               |
+---------------------------------------------------------------+-----------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [SetIncludeUserDictionaryInSuggestions]{style="COLOR: black"} | [SetIncludeUserDictionaryInSuggestions(bool include)]{style="COLOR: black"} | [The UserDictionary will be taken into account only if we pass true to this method. If we pass false as its argument, the SpellChecker will not look into the UserDictionary while checking spellings.]{style="COLOR: black"} |
+---------------------------------------------------------------+-----------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: #c00000"} 

Setting User Dictionary  

Create a SpellChecker instance and set the user dictionary as given in the below code.

**** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                           |
|                                                                                                                                                                                            |
| [SpellChecker]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ SpellCheck = [new]{style="COLOR: blue"} [SpellChecker]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [SpellCheck.]{style="FONT-FAMILY: 'Courier New'"} [      SetUserDictionary("D:\\custom");]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                            |
| [SpellCheck.]{style="FONT-FAMILY: 'Courier New'"} [      SetIncludeUserDiction-aryInSuggestions(true);]{style="FONT-FAMILY: 'Courier New'"}                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

Sample Link

To access the sample link:

1.   Open the Synfusion Dashboard.

2.   Select **User Interface**.

3.   Click the WPF drop-down list and select **Explore Samples**.

4.   Navigate to **Tools** -\> **SpellChecker** -\> **SpellCheckerDemo**.

 

[]{#related-topics}
::::
