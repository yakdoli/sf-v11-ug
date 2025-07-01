::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Installation Steps {#installation-steps style="tab-stops: 0pt"}

 

To facilitate conversion, our HTML Converter depends on our Active-X Wrapper control which talks to GECKO APIs during conversion.  While installing the Essential Studio, the assembly manager will register the Syncfusion.GeckoWrapper.dll in the machine. To register our Active-X wrapper control manually:

1.   Copy the Syncfusion.GeckoWrapper.dll to the Bin folder of Gecko SDK (a.k.a, XulRunner-SDK 2.0.) which can download from this [[location]{.UGHyperlink}](https://developer.mozilla.org/en/Gecko_SDK).

2.   Register the Syncfusion.GeckoWrapper.dll using the following command in the command prompt:

*regsvr32 Syncfusion.GeckoWrapper.dll*

[]{#related-topics}
:::
