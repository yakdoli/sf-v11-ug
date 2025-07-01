::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Apply Skin for Ribbon Control

Add the following dll's to apply corresponding theme for Hierarchy Navigator control. SkinManager class is used to apply different visual styles for a control, which is available in Syncfusion.Theming.Silverlight project[.]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Theming.Silverlight.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Theming.Office2007Blue.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Theming.Office2007Black.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Theming.Office2007Silver.dll

 

1.   Create Ribbon instance either in xaml or code behind as below.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [XAML[]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Ribbon]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"myRibbon\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

\[Or\]

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                             |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}                                                                                                                  |
|                                                                                                                                                                    |
| [Ribbon]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ myRibbon = [new]{style="COLOR: blue"} [Ribbon]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

2.   Apply Visual Style as shown below in Code behind, by calling the static method in SkinManager class in Syncfusion.Theming.Silverlight. The example is provided here for Office2007Blue. You can refer See also link to see more details on Skins.

 

**Office2007Blue**

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [SkinManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.SetVisualStyle(myRibbon, Syncfusion.Windows.Controls.Theming.[VisualStyle]{style="COLOR: #2b91af"}.Office2007Blue);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also:

[Skins]{.UGHyperlink}[]{.UGHyperlink}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

[]{#related-topics}
:::
