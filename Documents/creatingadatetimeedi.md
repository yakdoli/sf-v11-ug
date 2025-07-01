::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Creating a DateTimeEdit control in C#

The steps to create DateTimeEdit control by using Visual Studio in C# as follows:

1.   Open Visual Studio, On the **File** menu click New -\> Project. This opens the New Project Dialog box.

![Description: C:\\Documents and Settings\\labuser\\My Documents\\SL tools correct image.png](../ImagesExt/image261_45.png){border="0"}

Figure 416: New Project Dialog box

 

2.   Select WPF Application in the ProjectDialog window and type the name of the project in the name field.Click OK.

![](../ImagesExt/image261_46.png){border="0"}

Figure 417: New Project

3.   Add the following Reference with the sample project.

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Silverlight.dll

 

 

![](../ImagesExt/image261_47.png){border="0"}

Figure 418: Solution Explorer

4.   Click and open C# file. Add DateTimeEdit control to your application.

            Here is the code to create DateTimeEdit control in C#.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [            [DateTimeEdit]{style="COLOR: #2b91af"} dateTimeEdit = [new]{style="COLOR: blue"} [DateTimeEdit]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                              |
| [            dateTimeEdit.Width = 200;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                              |
| [            dateTimeEdit.Height = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](../ImagesExt/image261_342.png){border="0"}

Figure 419: DateTimeEdit control

See Also

[Creating a DateTimeEdit control in XAML]{.UGHyperlink}[]{.UGHyperlink}

[Creating a DateTimeEdit control by using Blend]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#related-topics}
:::
