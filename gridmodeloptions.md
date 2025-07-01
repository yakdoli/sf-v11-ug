::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Grid Model Options {#grid-model-options style="tab-stops: 0pt"}

This section provides information on how to write syntax for the following GridModel Options:

[·      ]{style="FONT-FAMILY: Symbol"}ActivateCurrentCellBehavior

[·      ]{style="FONT-FAMILY: Symbol"}AllowScrollCurrentCellInView

[·      ]{style="FONT-FAMILY: Symbol"}AlphaBlendSelectionColor

[·      ]{style="FONT-FAMILY: Symbol"}ClickedOnDisabledCellBehavior

[·      ]{style="FONT-FAMILY: Symbol"}ShowCurrentCellBorderBehavior

[·      ]{style="FONT-FAMILY: Symbol"}DefaultGridBorderStyle

 

Activating Current Cell Behavior

 

The following code illustrates how to activate current cell behavior:

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.ActivateCurrentCellBehavior = [GridCellActivateAction]{style="COLOR: #2b91af"}.SelectAll;]{style="FONT-FAMILY: 'Courier New'"}
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

Allow scroll for Current cell view

The following code illustrates how to allow scroll for current cell view:

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.AllowScrollCurrentCellInView = [GridScrollCurrentCellReason]{style="COLOR: #2b91af"}.Activate;]{style="FONT-FAMILY: 'Courier New'"}
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

Alpha Blend Selection Color

The following code illustrates how to [select alpha blend selection color: ]{style="COLOR: black"}

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.AlphaBlendSelectionColor = [Color]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'"}
  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

ClickedOnDisabledCellBehavior

The following code illustrates how to define the current cell behavior when disabled cell is clicked:

  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.ClickedOnDisabledCellBehavior = [GridClickedOnDisabledCellBehavior]{style="COLOR: #2b91af"}.Default;]{style="FONT-FAMILY: 'Courier New'"}
  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

Show Current Cell Border Behavior

The following code illustrates how to show current cell border behavior:

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.ShowCurrentCellBorderBehavior = [GridShowCurrentCellBorder]{style="COLOR: #2b91af"}.HideAlways;]{style="FONT-FAMILY: 'Courier New'"}
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

Default Grid Border Style

The following code illustrates how to set default grid border style:

  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridGroupingControl1.DefaultGridBorderStyle = [GridBorderStyle]{style="COLOR: #2b91af"}.None;]{style="FONT-FAMILY: 'Courier New'"}
  ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

 

[]{#related-topics}
:::
