::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### []{#_Serialize_Layout}Serialize Layout

The user can utilize the serialization support in Syncfusion Tab control. By this feature, the user can save the current state of the tab control at any time. The user can reload the last saved state as the current state. The content of the whole Tab Control will maintain when saving the TabState. Also, the saved content with Tab Item content will be reloaded when loading the last saved state.

We can save the current state of Tab control using the following steps.

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[            ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}[TabControlAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ MyTabCtrl = [new]{style="COLOR: blue"} [TabControlAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}

[       MyTabCtrl.SaveTabState();]{style="FONT-FAMILY: 'Courier New'"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"} 

The following steps describe loading the saved state:

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[TabControlAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ MyTabCtrl = [new]{style="COLOR: blue"} [TabControlAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}

[MyTabCtrl.LoadTabState();]{style="FONT-FAMILY: 'Courier New'"}
:::

[]{#related-topics}
:::::
