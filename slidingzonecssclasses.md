::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### SlidingZone CSS Classes {#slidingzone-css-classes style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Using this feature, we can add custom styles to Splitter control through external cascading style sheets.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}The CSS folder contains style settings for different themes, one file for each theme.

[·      ]{style="FONT-FAMILY: Symbol"}In aspx, a CSS style gets associated with the corresponding control\'s style.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

CSS Classes

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

We can add our own styles to the following CSS classes to change the entire look and feel of the control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Splitter

[·      ]{style="FONT-FAMILY: Symbol"}SplitterBar_Default

[·      ]{style="FONT-FAMILY: Symbol"}SplitterBar_Hover

[·      ]{style="FONT-FAMILY: Symbol"}SplitterBar_Resize

[·      ]{style="FONT-FAMILY: Symbol"}SplitterBar_ResizeError

[·      ]{style="FONT-FAMILY: Symbol"}Sliding Zone

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPanel_CollapseHeader

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPanel_CollapseHeader_Hover

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPanel_ExpandHeader

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPanel_ExpandHeader_Hover

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPane_ResizeBar

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPane_ResizeBar_Hover

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPane_ResizeBar_Resize

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPane_ResizeBar_ResizeError

[·      ]{style="FONT-FAMILY: Symbol"}SlidingPane

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------+
| [/\*Splitter css setting\*/]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                           |
|                                                                                |
| [Splitter]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                |
| [      border:1px solid #9D5806;]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                |
| [      background-color: #FDFCFB;]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                        |
+--------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

Property

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In order to apply the styles from the custom css file to the control, we need to set the **CustomCSSClass** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

  -----------------------------------------------------------------------------------------------
  [CustomCSSClass = "css/Splitter_style.css"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}
  -----------------------------------------------------------------------------------------------

 

[]{#related-topics}
:::
