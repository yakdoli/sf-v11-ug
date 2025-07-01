::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### []{#_Creating_DoubleTextBox_using_1}Creating DoubleTextBox using C#

 

Steps to create DoubleTextBox by using Visual Studio in C# as follows:

1.   Open Visual Studio, On the **File** menu click New -\> Project. This opens the New Project Dialog box.

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\SL tools correct image.png](../ImagesExt/image261_45.png){border="0"}

Figure 38: Creating DoubleTextBox control

 

2.   Select Silverlight Application in the Project Dialog window and type the name of the project in the name field.Click OK.

![](../ImagesExt/image261_46.png){border="0"}

Figure 39: Project dialog box

3.   Add the following Reference with the sample project.

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Silverlight.dll

 

![](../ImagesExt/image261_47.png){border="0"}

Figure 40: Solution Explorer

4.   Click and open C# file. Add DoubleTextBox to your application.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [            [//Adding DoubleTextBox to Application]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                |
| [            Syncfusion.Windows.Shared.[DoubleTextBox]{style="COLOR: #2b91af"} doubleTextBox = [new]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| [                          Syncfusion.Windows.Shared.[DoubleTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                |
| [            doubleTextBox.Height = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                |
| [            doubleTextBox.Width = 100;]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](../ImagesExt/image261_48.png){border="0"}

Figure 41: Doubletextbox with Nullvalue

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"} |
| ![](../ImagesExt/image261_3.jpg){border="0"}Note:                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                             |
| If user does not set any value to DoubleTextBox then the default value will be as follows...                                                                                                                                                                |
|                                                                                                                                                                                                                                                             |
| If UseNullOption set to true then,                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                             |
|     Value of NullValue property will be the default value.                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                             |
| Otherwise                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                             |
|    Zero will be the default value (based on the MinValue and MaxValue the default value will change).                                                                                                                                                       |
| :::                                                                                                                                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also

[·      ]{style="FONT-FAMILY: Symbol"}[Creating DoubleTextBox using XAML]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}

[·      ]{style="FONT-FAMILY: Symbol"}[Creating DoubleTextBox by using Blend]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}

 

[]{#related-topics}
:::
