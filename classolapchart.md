::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Class: OlapChart {#class-olapchart style="tab-stops: 0pt"}

###### 1.4.1.1.1.1 Public Properties {#public-properties style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

  ---------------------------- ----------------------------------------------------------------------------------------------------------
  DesignerSettings             Gets or sets the designer settings that can be used for creating the XAML report during the design-time.
  ChartAppearance              Gets or sets the chart appearance settings such as ChartArea background, BorderColor, ChartType, etc.
  ChartType                    Gets or sets the chart type.
  ColorModel                   Gets the color model used to paint series.
  CornerRadius                 Gets or sets the corner radius of the OLAP Chart.
  GridBackground               Gets or sets the grid background.
  GridLineStroke               Gets or sets the grid line stroke.
  Legend                       Gets or sets the chart legend.
  OlapDataManager              Gets or sets the olap data manager.
  PrimaryAxis                  Gets or sets the primary axis.
  ShowPrimaryAxisLabelBoder    Gets or sets a value indicating whether the primary axis label border should be visible or not.
  SecondaryAxis                Gets or sets the secondary axis.
  Series                       Gets the series collection.
  DisplayMode                  Gets or sets the display mode.
  SeriesToolTipTemplate        Gets or sets the series tool tip template.
  KpiAlignment                 Gets or sets the KPI alignment.
  PrimaryAxisLabelVisibility   Gets or sets the primary axis label visibility.
  ---------------------------- ----------------------------------------------------------------------------------------------------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

###### 1.4.1.1.1.2 Public Methods {#public-methods style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

::: {align="center"}
  -------------------------- ---------------------------------------------------------------------------------------------------------------------
  DataBind                   Binds the data.
  ExportintoNewDoc           Exports the chart to a new word document.
  ExportIntoTemplateDoc      Overloaded. Exports the chart to an existing word document by replacing the chart at the marker string position.
  ExportIntoNewPdf           Exports the chart to a new PDF document.
  OnApplyTemplate            Invoked whenever application code or internal processes call ApplyTemplate().
  SetChartApperanceDetails   Sets the chart appearance settings.
  ShowAppearanceDialog       Displays the chart appearance customization dialog. It can be used for customizing the chart appearance properties.
  -------------------------- ---------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

###### 1.4.1.1.1.3 Public Events {#public-events style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

::: {align="center"}
  --------------- ---------------------------------------------
  BeforeRefresh   Occurs before the refresh of the OLAP area.
  AfterRefresh    Occurs after the refresh of the OLAP area.
  --------------- ---------------------------------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::::
