::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### GAMMAINV {#gammainv style="tab-stops: 0pt"}

 

Returns the inverse of the gamma cumulative distribution. If p = GAMMADIST(x,\...), then GAMMAINV(p,\...) = x.

 

**Syntax**

 

**GAMMAINV(probability, alpha, beta)**

 

where:

**probability** is the probability associated with the gamma distribution.

**alpha** is a parameter to the distribution.

**beta** is a parameter to the distribution.

 

**Remarks**

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Probability must be \>= 0 and \<= 1.

[·      ]{style="FONT-FAMILY: Symbol"}Alpha and beta must be positive.

 

Given a value for probability, GAMMAINV seeks value x such that GAMMADIST(x, alpha, beta, True) = probability. Thus, precision of GAMMAINV depends on the precision of GAMMADIST. GAMMAINV uses an iterative search technique.

 

[]{#p122} 

[]{#related-topics}
:::
