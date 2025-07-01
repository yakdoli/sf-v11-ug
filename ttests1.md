::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### T-Tests {#t-tests style="tab-stops: 0pt"}

 

TTest is a statistical formula that is used to measure the equality between the means of two series. In other words, the T test compares the actual difference between two means in relation to the variation in data that can be measured by calculating the standard deviation of the difference between the means.

 

It is a statistical test used to test the null hypothesis that the means of two normally distributed populations are equal. This test can be performed on two given samples(series), each characterized by its mean, standard deviation and number of data points, to determine whether the means are distinct based on the assumption that the underlying distributions are normal.

 

Different T-Tests

 

There are different versions of T tests depending on whether the samples are:

 

[·      ]{style="FONT-FAMILY: Symbol"}**independent** of each other, (where the series are random with no relationship between each other)

***OR***

[·      ]{style="FONT-FAMILY: Symbol"}**paired**, (where every data point in one series will have a relationship with a particular point of another series).

 

If the calculated t-statistic exceeds the chosen threshold value (usually 0.05), then the decision is to reject the null hypothesis, which states that the two sample means are equal, in favor of an alternate hypothesis, which typically specifies that the two samples differ.

 

Below are the different formulae to calculate the t-statistic:

 

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[T-Test with Equal Variances]{style="COLOR: blue"}]{.UGHyperlink}

This formula performs a T test for two groups of data and assumes equal variances between the two groups (i.e. series).

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[T-Test Paired]{.UGHyperlink}[]{.UGHyperlink}

This formula performs a paired two-sample student\'s t-test to determine whether a sample\'s means are distinct. This form of the t-test does not assume that the variances of both the populations are equal.

Use a paired test when there is a natural pairing of observations in the samples, such as a sample group that is tested twice. (e.g. before and after an experiment)

 

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[T-Test with UnEqual Variances]{.UGHyperlink}[]{.UGHyperlink}

This formula performs a T-test for two groups of data and assumes unequal variances between the two groups. (i.e. series)

This analysis tool is referred to as a heteroscedastic t-test and can be used when the groups that are under study are distinct. Use a paired test when there is one group before and after a treatment.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: For programming example, refer to the following Browser Sample:
:::

 

[\[Installed drive\]:\\Documents and Settings\\\[User name\]\\My Documents\\Syncfusion\\EssentialStudio\\\[Installed version\]\\Windows\\Chart.Windows\\Samples\\2.0\\Statistical Analysis\\Chart Statistical Formulas]{.UGHyperlink}

 

[]{#p225} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}TTest with Equal Variances](ms-xhelp:///?Id=c80b91ad-afd7-4f23-a7e1-1affc92bae73){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}T-Test with UnEqual Variance](ms-xhelp:///?Id=0201c9d2-f178-4683-9443-4da1cb6b281f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TTest Paired](ms-xhelp:///?Id=66fa18bc-d149-4e41-af12-6acf6ad9cb55){style="TEXT-DECORATION: none"}
::::
