::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Through Code {#through-code style="tab-stops: 0pt"}

Following are the steps to add the SplitButton control to an application through code:

 

1.   Include the Tools Windows namespace as given in the following code:

 

+-------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"}                                                                       |
|                                                                                                                                     |
| [     using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Tools;]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[VB\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                          |
|                                                                                                                                                                                                                                                           |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 12pt"}[Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Tools]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

2.   Create an instance of  SplitButton  control and add it to the form as given in the following code:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ \[C#\]]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                          |
|                                                                                                                                                                                                                     |
| [     Syncfusion.Windows.Forms.Tools.[SplitButton]{style="COLOR: #2b91af"} splitButton;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                     |
| [     this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.splitButton = [new ]{style="COLOR: blue"}Syncfusion.Windows.Forms.Tools.[SplitButton]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                     |
| [     this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Controls.Add(splitButton);]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[VB\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 12pt"}                                                                                                                           |
|                                                                                                                                                                                         |
| [      Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ splitButton [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.SplitButton]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                         |
| [      Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.splitButton = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.SplitButton()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [      [Me]{style="COLOR: blue"}.Controls.Add(splitButton)]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
