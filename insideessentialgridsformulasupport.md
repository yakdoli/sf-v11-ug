::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Inside Essential Grid\'s Formula Support {#inside-essential-grids-formula-support style="tab-stops: 0pt"}

 

The Formula Cell control is implemented with four classes: **GridFormulaCellModel**, **GridFormulaCellRenderer**, **GridFormulaEngine** and **GridFormulaTag**. The GridFormulaCellRenderer class handles a couple of activation issues which are specific to displaying formulas when a formula cell gets activated. The GridFormulaCellModel class does some significant work in its **GetFormattedText** method override where calculations and formula parsing are initiated dynamically as required.

 

The GridFormulaEngine class does the actual parsing and calculation that is required to evaluate a formula in a cell. This class also maintains the Formula Library. The programmer can gain access to an engine object by using the **GridFormulaCellModel.Engine** property. It is this property that will let you add functions to (or remove functions from) the Formula Library. The use of the class is discussed in the next section.

 

Finally, the GridFormulaTag class is used in conjunction with the **GridStyleInfo** class that has a property of this type. The GridFormulaTag tracks the computed value of the cell in its **Text** property.

 

[]{#p119} 

 

[]{#related-topics}
:::
