::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=1aae38f0-3087-4c09-93d7-c9d71d530fd6){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=53bc01f1-b6b5-4b6e-b990-dae1157cd39a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## Custom Calculations {#custom-calculations style="tab-stops: 0pt"}

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

Hence, the sales amount for FY 2011 is 33.33 % of overall year sales (FY 2008 to FY 2011) at United States[.]{style="COLOR: #c00000"}

                  

Properties*[]{style="FONT-SIZE: 9pt"}*

Table 11: Properties Table

+-----------------+--------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------------------+
| Property        | Description                                                                                                        | Type        | Data Type       | Reference links                                                           |
+-----------------+--------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------------------+
| CalculationType | Gets or sets the CalculationType for the PivotComputationInfo object.                                              | CLR         | CalculationType | \<Class Reference link for CalculationType                                |
|                 |                                                                                                                    |             |                 |                                                                           |
|                 |                                                                                                                    |             |                 | In PivotAnalysis.Base.Silverlight\>.                                      |
+-----------------+--------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------------------+
| BaseField       | Gets or sets the BaseField for calculations \[Applicable only for the  PercentageOfParentTotal calculation type\]. | CLR         | string          | \<Class Reference link for BaseField in PivotAnalysis.Base.Silverlight\>. |
+-----------------+--------------------------------------------------------------------------------------------------------------------+-------------+-----------------+---------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Location

A demo is available in the following location:

*\<SystemDrive\>:\\Users\\\<UserName\>\\AppData\\Local\\Syncfusion\\EssentialStudio\\\<version_number\>\\ BI\\Silverlight\\PivotGrid.SL\\ProductShowcase\\PivotGridDemo*

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Implementing Custom Calculations](ms-xhelp:///?Id=53bc01f1-b6b5-4b6e-b990-dae1157cd39a){style="TEXT-DECORATION: none"}
:::
