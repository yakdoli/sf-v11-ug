::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Supported Arithmetic Operators and Calculation Precedence {#supported-arithmetic-operators-and-calculation-precedence style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The current formula support will allow you to enter well-formed parenthetical algebraic expressions using operators and operands. The nine supported operators are shown in the precedence table given below, with operators on the same level being calculated as encountered when the expression is scanned from left to right.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Code Tables

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

::: {align="center"}
  -------------------------------------------------------------------------------------- ------------------------- ------------------------
  Operations                                                                             Symbols                   Calculation Precedence
  Multiplication, Division                                                                /  \*                    1st
  Addition, Subtraction                                                                  +  -                      2nd
  Less Than, Greater Than, Equal, Less Than Or Equal, Greater Than Or Equal, Not Equal    \<  \> = \<= \>= \<\>    3rd
  -------------------------------------------------------------------------------------- ------------------------- ------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The supported operands include those listed in the table given below. An operand by itself is also a well-formed algebraic expression that can serve as an entire formula in a cell.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------------------------------- ---------------------------------------
  Operand                                Examples
  number                                 532.1, -10.2, or 18.
  cell reference                         A12, BB1010, or Q18.
  library formula with valid arguments   Abs(E14), Cos(-3.14), or Sum(A1:A14).
  any well formed algebraic expression   E1+E2, Cos(2)\<A4, or Abs(A1-A5).
  -------------------------------------- ---------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Within a formula cell, a case is ignored. So, a1 is the same as A1, and Cos(3) is the same as COS(3).[]{#p22}

[]{#related-topics}
:::::
