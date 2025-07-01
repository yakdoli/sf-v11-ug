::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Lexical Macros {#lexical-macros style="tab-stops: 0pt"}

 

Edit Control allows you to define macros that represent regular expression elements. These macros are valid for use in any regular expression.

 

**Usage**

 

Using defined macros is easy. To reference a macro, simply type its name within curly braces ({ \... }). The following examples illustrate this feature better:

 

[•]{style="FONT-FAMILY: 'Arial Black','sans-serif'"} This regular expression uses a macro that represents the character class \[0-9\] to build a decimal number regular expression.

{DigitMacro}+ (\\. {DigitMacro}+)?

 

[•]{style="FONT-FAMILY: 'Arial Black','sans-serif'"} This regular expression builds a C# identifier using two macros.

(\_ \| {AlphaMacro})({WordMacro})\*

 

**Built-In Macros**

 

Edit Control recognizes a number of built-in macros. If a language definition defines a lexical macro of the same name as a built-in lexical macro, the user\'s definition will override the system definition. The following table summarizes the built-in macros of Edit Control.

 

::: {align="center"}
  ---------------------------------- -------------------------------------------------------------------------------------------------------------------------------
  Macro                              Description
  AllMacro                           Contains all Unicode characters. This is the same as \[\\u0000-\\uFFFF\]
  AlphaMacro                         Contains all Unicode alphanumeric digits. This is the same as: \[a-zA-Z\]
  DigitMacro                         Contains all Unicode decimal digits. This is the same as: \[0-9\]
  HexDigitMacro                      Contains all Unicode hexadecimal digits. This is same as:\[0-9a-fA-F\]
  LineTerminatorMacro                Contains all Unicode line terminators. This is the same as: \[\\r\\n\\u2028\\u2029\]
  LineTerminatorWhitespaceMacro      Contains all Unicode line terminators and whitespace characters. This is the same as: \[ \\r\\n\\u2028\\u2029\\f\\t\\v\\x85\]
  NonAlphaMacro                      Contains the inverse of AlphaMacro.
  NonDigitMacro                      Contains the inverse of DigitMacro.
  NoneMacro                          Contains no characters.
  NonHexDigitMacro                   Contains the inverse of HexDigitMacro.
  NonLineTerminatorMacro             Contains the inverse of LineTerminatorMacro.
  NonLineTerminatorWhitespaceMacro   Contains the inverse of LineTerminatorWhitespaceMacro.
  NonWhitespaceMacro                 Contains the inverse of WhitespaceMacro.
  NonWordMacro                       Contains the inverse of WordMacro.
  WhitespaceMacro                    Contains all Unicode whitespace characters. This is the same as: \[\\f\\t\\v\\x85\]
  WordMacro                          Contains all Unicode word characters. This is the same as: \[0-9a-zA-Z\]
  ---------------------------------- -------------------------------------------------------------------------------------------------------------------------------
:::

 

The lexical macros are used to specify configuration settings, and can be added to the current configuration language settings, as shown below.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                              |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [// Create and add a lexical macro to the Edit Control.LexicalMacrosManager\'s collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                                                                             |
| [// The Add method also returns the IMacro object associated with the lexical macro.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                                                             |
| [IMacro macro = [this]{style="COLOR: blue"}.Edit Control1.LexicalMacrosManager.Add([\"testMacro\"]{style="COLOR: maroon"}, [\".+\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [// Consider a scenario where configuration settings are being created dynamically in code.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                                                             |
| [// Create a config lexem that belongs to a custom format. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                                             |
| [ConfigLexem configLex = [new]{style="COLOR: blue"} ConfigLexem([\"\<%@\"]{style="COLOR: maroon"}, [\"%\>\"]{style="COLOR: maroon"}, FormatType.Custom, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [// The actual regex can then be substituted with the lexical macro while defining the config lexem.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                                                                                             |
| [// NameInConfig returns the name of the macro rounded with braces, like \"{testmacro}\".]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                |
|                                                                                                                                                                                                                             |
| [configLex.ContinueBlock = macro.NameInConfig;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                             |
| [configLex.IsContinueRegex = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                             |
| [\' Create and add a lexical macro to the Edit Control.LexicalMacrosManager\'s collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                             |
| [\' The Add method also returns the IMacro object associated with the lexical macro.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ macro [As]{style="COLOR: blue"} IMacro = [Me]{style="COLOR: blue"}.Edit Control1.LexicalMacrosManager.Add([\"testMacro\"]{style="COLOR: maroon"}, [\".+\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [\' Consider a scenario where configuration settings are being created dynamically in code.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                             |
| [\' Create a config lexem that belongs to a custom format. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ configLex [As]{style="COLOR: blue"} ConfigLexem = [New]{style="COLOR: blue"} ConfigLexem([\"\<%@\"]{style="COLOR: maroon"}, [\"%\>\"]{style="COLOR: maroon"}, FormatType.Custom, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [\' The actual regex can then be substituted with the lexical macro while defining the config lexem.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                             |
| [\' NameInConfig returns name of the macro rounded with braces, like \"{testmacro}\".]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                             |
| [configLex.ContinueBlock = macro.NameInConfig ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                             |
| [configLex.IsContinueRegex = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-SIZE: 9pt"} 

[Language Elements]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p27} 

[]{#related-topics}
::::
