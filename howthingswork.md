::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d26f2177-4276-44d8-b993-5b2ad2e06db3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=cfaf8e79-72b1-411b-aad1-f20b51f6b236){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Inside CalcEngine](ms-xhelp:///?Id=62aefe41-8f1a-4067-a820-8a2339080e94){.d2h_breadcrumbsNormal}
:::

### How Things Work {#how-things-work style="tab-stops: 0pt"}

 

1.   What happens when you enter the formula = A1 + 5 into a cell in a CalcSheet object?

 

2.   Here lets assume that CalcSheet is using its own internal data storage to hold values, so that it makes it simple to understand what is going on within CalcEngine. If the data is being held in some other object (like a DataGrid with a DataTable datasource) things will look the same from within the CalcEngine.

 

3.   Here is a sketch of the major steps taken within the library code when you enter a formula into a cell assuming CalcEngine.UseDependencies is True. The actual processing is more involved; these steps should give you an outline of what happens:

 

4.   The string is tested to see whether it begins with an equal sign. If not, CalcSheet stores the entered string in its internal memory so that it will be available if needed. A check is made to see if this cell is a key in the DependentCells collection. If it is, then all cells depending upon this cell are recomputed. This recomputing is a recursive process as changing a cell, that depends upon the changed cell which triggers the recomputing needs of the newly changed cell and so on.

 

5.   If the entered string does begin with an equal sign, the CalcEngine sees this as an entered formula. At this point, the CalcEngine checks to see if the cell is a key in the FormulaInfoTable.

 

6.   If the cell is a key in the FormulaInfoTable, the corresponding FormulaInfo object is retrieved and updated. This amounts to the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Parsing the string.

[·      ]{style="FONT-FAMILY: Symbol"}Computing the string.

[·      ]{style="FONT-FAMILY: Symbol"}Saving the original formula, the parsed formula and the computed value in the FormulaInfo object.

 

7.   If the cell is not a key in the FormulaInfoTable, a new FormulaInfo object is created. This new FormulaInfo object is populated from the entered string. This amounts to the following:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: red; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Parsing the string.

[·      ]{style="FONT-FAMILY: Symbol"}Computing the string.

[·      ]{style="FONT-FAMILY: Symbol"}Saving the original formula, the parsed formula and the computed value in the FormulaInfo object.

 

There are several other scenarios that must be handled in the CalcEngine. They include things like the newly entered string changes from an existing formula cell to a non-formula cell. In this situation, the CalcEngine uses the DependFormulaCells collection to remove dependencies that are no longer needed.

 

All this dependent tracking is done conditionally depending upon CalcEngine.UseDependencies. Additionally, you can turn off formula calculations using **CalcEngine.CalculatingSuspended**.

 

[]{#p70} 

[]{#related-topics}
::::
