::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### User Dictionary

Spell Checker can also look into the user dictionary for spell checking. The user dictionary needs to be placed in IsolatedStorage.

Methods

 

+---------------------------------------+-----------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Method                                | Prototype                                           | Description                                                                                                                                                                                                |
+---------------------------------------+-----------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SetUserDictionary                     | SetUserDictionary(string dicName),                  | SetUserDictionary is overloaded method. You can set the user dictionary by passing the file name of the dictionary to this method or you can pass UserDictionary instance to this method.                  |
|                                       |                                                     |                                                                                                                                                                                                            |
|                                       | SetUserDictionary(UserDictionary userDic)           |                                                                                                                                                                                                            |
+---------------------------------------+-----------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SetIncludeUserDictionaryInSuggestions | SetIncludeUserDictionaryInSuggestions(bool include) | The user dictionary will be taken into account only if you pass true to this method. If you pass false as its argument, the SpellChecker will not look into the user dictionary, while checking spellings. |
+---------------------------------------+-----------------------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Setting User Dictionary  

Create a spell checker instance and set the user dictionary as given in the following code.

 

+-------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                       |
| [SpellChecker SpellCheck = new SpellChecker();]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                       |
| [SpellCheck.       SetUserDictionary("custom");]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                       |
| [SpellCheck.       SetIncludeUserDiction-aryInSuggestions(true);]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------+

 

Sample Link

To view samples:

1.   Open the Synfusion Dashboard.

2.   Select User Interface.

3.   Click the SL drop-down list and select Explore Samples.

4.   Navigate to Tools -\> SpellChecker -\> SpellCheckerDemo.

 

[]{#related-topics}
:::
