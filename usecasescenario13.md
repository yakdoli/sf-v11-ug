::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Use Case Scenario {#use-case-scenario style="tab-stops: 0pt"}

Starting with Internet Explorer 9, Microsoft has made a series of core-architectural changes to Internet Explorer.  One of them was to use DirectX (a.k.a, D2D) to render webpage to achieve full-hardware acceleration development to support HTML5 standard features instead of GDI based rendering. As our HTML to PDF conversion depends on IE's GDI based rendering during conversion, our HTML Converter will not be able to generate PDF documents that contain selectable text.  Hence, if the machine has IE9 or later installed, then you should consider using our Gecko based rendering.  This approach will reliably generate PDF documents that are text selectable and printer friendly.

 

[]{#related-topics}
:::
