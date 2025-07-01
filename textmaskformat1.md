::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### TextMaskFormat {#textmaskformat style="tab-stops: 0pt"}

  Details

Old:

[                        ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}The text inside the **MaskedTextBox** was the output.

                        Example: When the Mask string is **(00)-(000).(0)**

                        And the user inputs 1, the output will be **(1\_)-(\_\_\_).(\_)**

[            ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}New:

[                        ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}The text inside the **MaskedTextBox** is formatted and given as the output.

                        There are four formatting properties and it is an enum. they are,

1)         ExcludePromptAndLiterals

2)         IncludeLiterals

           3)      IncludePrompt

           4)      IncludePromptAndLiterals

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example: When the Mask string is (00)-(000). (0)

And the user inputs 1, the output Text will be

1\) ExcludePromptAndLiterals                    -           1

2\) IncludeLiterals                           -           (1)-(). ()

3\) IncludePrompt                          -           1\_\_\_\_\_

4\) IncludePromptAndLiterals                      -           (1\_)-(\_\_\_). (\_)

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

IncludePromptAndLiterals is enabled by default.

Usage

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[MaskedTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"maskedtextBox1\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ TextMaskFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"ExcludePromptAndLiterals\" /\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**                                                                                                                      |
|                                                                                                                                                                                                 |
| [MaskedTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ maskedTextBox = [new]{style="COLOR: blue"} [MaskedTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [maskedTextBox.TextMaskFormat = [MaskFormat]{style="COLOR: #2b91af"}.ExcludePromptAndLiterals;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{#related-topics}
:::
