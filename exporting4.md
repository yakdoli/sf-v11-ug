::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Exporting {#exporting style="tab-stops: 0pt"}

 

Essential LinearGauge has built-in support for exporting the gauge control into various image formats like jpeg, bmp, gif and so on.

 

Essential LinearGauge can be exported in both server and client side.

The following table lists the file formats a LinearGauge can be exported to:

 

 

::: {align="center"}
  ---------------- -----------
  File Extension   File Type
  .bmp             BMP
  .jpg             JPEG
  .jpeg            JPEG
  .gif             GIF
  .tiff            TIFF
  .Wmf             WMF
  .Png             PNG
  .emf             EMF
  ---------------- -----------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

::: {align="center"}
+-------------+-----------------------+-----------------------------+--------------------------------------------------+--------------------------------------------------+
| Property    | Description           | Property Type               | Value It Accepts                                 | Any other dependencies/Sub properties associated |
+-------------+-----------------------+-----------------------------+--------------------------------------------------+--------------------------------------------------+
| GaugeExport | Sets the Export Type. | [enum]{style="COLOR: blue"} | [GaugeExport]{style="COLOR: #2b91af"}.ServerSide | NA                                               |
|             |                       |                             |                                                  |                                                  |
|             |                       |                             |                                                  |                                                  |
|             |                       |                             |                                                  |                                                  |
|             |                       |                             | [GaugeExport]{style="COLOR: #2b91af"}.ClientSide |                                                  |
|             |                       |                             |                                                  |                                                  |
|             |                       |                             |                                                  |                                                  |
|             |                       |                             |                                                  |                                                  |
|             |                       |                             | [GaugeExport]{style="COLOR: #2b91af"}.None       |                                                  |
+-------------+-----------------------+-----------------------------+--------------------------------------------------+--------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

 

::: {align="center"}
+--------------------+---------------------------------------------------------+--------------------------------------------------------+------------------------------------------------------------------------------------+
| Name               | Parameters                                              | Return Type                                            | Description[]{style="COLOR: black"}                                                |
+--------------------+---------------------------------------------------------+--------------------------------------------------------+------------------------------------------------------------------------------------+
| GenerateGaugeImage | [(Gauge_Obj,FileName,FileFormat)]{style="COLOR: black"} | [None]{style="COLOR: black"}[]{style="COLOR: #1f497d"} | [Used to generate the Gauge image in client or server side.]{style="COLOR: black"} |
|                    |                                                         |                                                        |                                                                                    |
|                    |                                                         |                                                        |                                                                                    |
+--------------------+---------------------------------------------------------+--------------------------------------------------------+------------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}ServerSide Export](ms-xhelp:///?Id=b8b09ad6-eac4-4209-ac6c-1d411c2aafb6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ClientSide Export](ms-xhelp:///?Id=edadd834-6ce7-4658-843b-ef58140419a9){style="TEXT-DECORATION: none"}
::::::
