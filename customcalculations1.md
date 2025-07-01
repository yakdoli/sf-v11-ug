::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Custom Calculations {#custom-calculations style="tab-stops: 0pt"}

Custom Calculations can be applied to the value fields through the following built-in calculation functions:

[·      ]{style="FONT-FAMILY: Symbol"}Percentage of Grand Total Cell

[·      ]{style="FONT-FAMILY: Symbol"}Percentage of Column Total Cell

[·      ]{style="FONT-FAMILY: Symbol"}Percentage of Row Total Cell

[·      ]{style="FONT-FAMILY: Symbol"}Percentage of Parent Total Cell

[·      ]{style="FONT-FAMILY: Symbol"}Percentage of Parent Column Total Cell

[·      ]{style="FONT-FAMILY: Symbol"}Percentage of Parent Row Total Cell and

[·      ]{style="FONT-FAMILY: Symbol"}Index

Use Case Scenarios

The user can easily analyze the specific value field based on the different value cells through the custom calculations. For example, the user can view the sales amount for United States in FY 2011 as a percentage of the whole sales at United States by selecting the Percentage of Parent Total option.

For an instant,

The sales amount in Untied States for FY 2011: \$40,000,000.00

The sales amount in United States for all years: \$120,000,000.00

Hence, the sales amount for FY 2011 is 33.33 % of overall year sales (FY 2008 to FY 2011) at United States.

[]{style="COLOR: #c00000"} 

Properties

Table 12: Properties Table

+-----------------+-------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------+
| Property        | Description                                                                                                       | Type        | Data Type       | Reference links                                               |
+-----------------+-------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------+
| CalculationType | Gets or sets the CalculationType for the PivotComputationInfo object.                                             | CLR         | CalculationType | \<Class Reference link for CalculationType                    |
|                 |                                                                                                                   |             |                 |                                                               |
|                 |                                                                                                                   |             |                 | In PivotAnalysis.Base\>.                                      |
+-----------------+-------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------+
| BaseField       | Gets or sets the BaseField for calculations \[Applicable only for the PercentageOfParentTotal calculation type\]. | CLR         | string          | \<Class Reference link for BaseField in PivotAnalysis.Base\>. |
+-----------------+-------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Location

A sample is found in the following location:

*\<SystemDrive\>:\\Users\\\<user_name\>\\AppData\\Local\\Syncfusion\\EssentialStudio\\\<version_number\>\\BI\\WPF\\PivotAnalysis.Wpf\\Samples\\Product Showcase\\PivotGrid Demo*

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Implementing Custom Calculations](ms-xhelp:///?Id=dce1aa59-93cd-4f21-8a6e-54ee654e08b8){style="TEXT-DECORATION: none"}
:::
