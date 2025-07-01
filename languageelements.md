::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Language Elements {#language-elements style="tab-stops: 0pt"}

 

The Edit Control regular expression engine accepts an extensive set of regular expression elements that enable you to efficiently search for text patterns. This section details the set of characters, operators and constructs that you can use to define regular expressions.

 

**Character Escapes**

 

Most of the important regular expression language operators are unescaped single characters. The escape character \\ (a single backslash) signals to the regular expression parser that the character following the backslash is not an operator. For example, the parser treats an asterisk (\*) as a repeating quantifier, and a backslash followed by an asterisk (\\\*) as the Unicode character \\u002A.

 

::: {align="center"}
  ----------------------- ------------------------------------------------------------------------------------------------------------------------------------------
  Escaped Character       Description
  (Ordinary characters)   Characters other than . \$ \^ { \[ ( \| ) \* + ? \\ match themselves.
  \\a                     Matches a bell (alarm) \\u0007.
  \\t                     Matches a tab \\u0009.
  \\r                     Matches a carriage return \\u000D.
  \\v                     Matches a vertical tab \\u000B.
  \\f                     Matches a form feed \\u000C.
  \\n                     Matches a new line \\u000A.
  \\e                     Matches an escape \\u001B.
  \\040                   Matches an ASCII character as octal (exactly three digits). The character \\040 represents a space.
  \\x20                   Matches an ASCII character using hexadecimal representation (exactly two digits).
  \\u0020                 Matches a Unicode character using hexadecimal representation (exactly four digits).
  \\                      Matches a character when followed by a character that is not recognized as an escaped character. For example, \\\* is the same as \\x2A.
  ----------------------- ------------------------------------------------------------------------------------------------------------------------------------------
:::

 

Character Classes

 

A character class is a set of characters that will find a match if any one of the characters included in the set matches. The following table summarizes the character matching syntax.

 

::: {align="center"}
  ----------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------
  Character Class   Description
  .                 Matches any character except \\n. When within a character class, the . will be treated as a period character.
  \[aeiou\]         Matches any single character included in the specified set of characters.
  \[\^aeiou\]       Matches any single character not in the specified set of characters.
  \[0-9a-fA-F\]     Use of a hyphen (-) allows specification of contiguous character ranges.
  \\w               Matches any word character.
  \\W               Matches any non-word character.
  \\s               Matches any whitespace character.
  \\S               Matches any non-whitespace character.
  \\d               Matches any decimal digit.
  \\D               Matches any non-digit.
  \[.\\w\\s\]       Escaped built-in character classes such as \\w and \\s may be used in a character class. This example matches any period, word or whitespace character.
  ----------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Quantifiers[ ]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

Quantifiers add optional quantity data to a regular expression. A quantifier expression applies to the character, group, or character class that immediately precedes it. The .NET Framework regular expressions support minimal matching (\"lazy\") quantifiers.

 

The following table describes the metacharacters that affect the matching quantity.

 

::: {align="center"}
  ------------ ------------------------------------------------------------------------------
  Quantifier   Description
  \*           Specifies zero or more matches; for example, \\w\* or (abc)\*. Same as {0,}.
  \+           Specifies one or more matches; for example, \\w+ or (abc)+. Same as {1,}
  ?            Specifies zero or one matches; for example, \\w? or (abc)?. Same as {0,1}.
  {n}          Specifies exactly n matches; for example, (pizza){2}.
  {n,}         Specifies at least n matches; for example, (abc){2,}.
  {n,m}        Specifies at least n, but no more than m, matches.
  ------------ ------------------------------------------------------------------------------
:::

 

**Atomic Zero-Width Assertions**

 

The metacharacters described in the following table do not cause the engine to advance through the string or consume characters. They simply cause a match to succeed or fail depending on the current position in the string. For instance, \^ specifies that the current position is at the beginning of a line or string. Thus, the regular expression \^#region, returns only those occurrences of the character string #region that occur at the beginning of a line.

 

The following table lists other regular expression constructs.

 

::: {align="center"}
  ----------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Assertion   Description
  \^          Specifies that the match must occur at the beginning of the string or the beginning of the line.
  \$          Specifies that the match must occur at the end of the string, before \\n at the end of the string, or at the end of the line.
  \\A         Specifies that the match must occur at the beginning of the document.
  \\z         Specifies that the match must occur at the end of the document.
  \\b         Specifies that the match must occur on a boundary between \\w (alphanumeric) and \\W (nonalphanumeric) characters.
  \\B         Specifies that the match must not occur on a \\b boundary.
  (?= )       Zero-width positive look ahead assertion. Continues match only if the subexpression matches at this position on the right. For example, \_(?=\\w) matches an underscore followed by a word character, without matching the word character.
  (?! )       Zero-width negative look ahead assertion. Continues match only if the subexpression does not match at this position on the right. For example, \\b(?!un)\\w+\\b matches words that do not begin with un.
  ----------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

**Miscellaneous Constructs**

 

The following table lists other regular expression constructs.

 

::: {align="center"}
  ----------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Construct   Description
  \" \"       Encapsulates a fixed string of characters.
  { }         Provides a call to a lexical macro. The use of a WordMacro (which is similar to \\w) would appear as {WordMacro}.
  ( )         Provides a grouping construct that groups the contained regular expression elements and changes their precedence.
  (?#)        Inline comment inserted within a regular expression. The comment terminates at the first closing parenthesis character.
  \|          Provides an alternation construct that matches any one of the terms separated by the \| (vertical bar) character. For example, cat\|dog\|tiger. The leftmost successful match wins.
  ----------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-SIZE: 9pt"} 

[Lexical Macros]{.UGHyperlink}[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[]{#p26} 

[]{#related-topics}
::::::::
