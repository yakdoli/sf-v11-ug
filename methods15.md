::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Methods {#methods style="tab-stops: 0pt"}

 

The following table describes the methods required for Zooming and Panning of Chart.

Methods for Chart Zooming/Panning

::: {align="center"}
  ------------------ ---------------------------------- ------------ -------------
  Method             Description                        Parameters   Return Type
  SwitchZooming      Enables zooming operations            Nil       void
  ZoomInCommand      Enables zooming in operation          Nil       void
  ZoomOutCommand     Enables zooming out operation         Nil       void
  ZoomResetCommand   Enables zooming reset operation.      Nil       void
  ------------------ ---------------------------------- ------------ -------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #1f497d; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image77_1.jpg){border="0"}]{style="COLOR: #15428b"}Note[:]{style="COLOR: #15428b"}[ T]{style="COLOR: #15428b"}o enable the zooming feature, the SwitchZooming method has to be invoked.
:::

 The following code snippet describes how to call the above methods.[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #1f497d; FONT-SIZE: 9pt"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[\[C#\][]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                       |
|                                                                                                                                                                  |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[//To Enable Zoom Operations]{style="COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}         |
|                                                                                                                                                                  |
| chart.Areas\[0\].SwitchZooming();[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                              |
|                                                                                                                                                                  |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[//To perform the Zoom-In command]{style="COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}    |
|                                                                                                                                                                  |
| chart.Areas\[0\].ZoomInCommand();[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                              |
|                                                                                                                                                                  |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[//To perform the Zoom-Out command]{style="COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}   |
|                                                                                                                                                                  |
| chart.Areas\[0\].ZoomOutCommand();[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                             |
|                                                                                                                                                                  |
| [ ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[//To perform the Zoom-Reset command]{style="COLOR: green"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                  |
| chart.Areas\[0\].ZoomResetCommand();                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::
