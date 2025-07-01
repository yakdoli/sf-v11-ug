::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### []{#_Creating_MaskedTextBox_using_1}Creating MaskedTextBox using C#

Steps to create MaskedTextBox by using Visual Studio in C# as follows:

1.   Open Visual Studio, On the **File** menu click New -\> Project. This opens the New Project Dialog box.

 

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\SL tools correct image.png](../ImagesExt/image261_45.png){border="0"}

Figure 172: New Project Dialog box

 

2.   Select Silverlight Application in the ProjectDialog window and type the name of the project in the name field.Click OK.

 

 

![](../ImagesExt/image261_46.png){border="0"}

Figure 173: Select Silverlight Application

3.   Add the following Reference with the sample project.

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Silverlight.dll

 

![](../ImagesExt/image261_47.png){border="0"}

Figure 174: Solution explorer

4.   Click and open C# file.Add MaskedTextBox to your application.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'; COLOR: white"}                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [            MaskedTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ maskedTextBox = [new]{style="COLOR: blue"} [MaskedTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| [            maskedTextBox.Height = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                             |
| [            maskedTextBox.Width = 150;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                             |
| [            maskedTextBox.Mask = [\"00/00/0000\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

![](../ImagesExt/image261_151.png){border="0"}

Figure 175: MaskedTextBox

See Also

[Creating MaskedTextBox using XAML]{.UGHyperlink}[]{.UGHyperlink}

[Creating MaskedTextBox using Blend]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
:::
