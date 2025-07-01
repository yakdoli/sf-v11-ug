::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding through C# {#adding-through-c style="tab-stops: 0pt"}

Following are the steps to add the PropertyGrid control by using VisualStudio in C#:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Open Visual Studio. On the **File** menu, select **New -\> Project**. This opens the New Project Dialog box.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\WPF Tools correct Image.png](ImagesExt/image30_13.png){border="0"}

Figure 815: VisualStudio Opening Project

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

2.   On the Project Dialog window, select **WPF Application**, in the Name field, type the name of the project, and then click **OK**.

 

3.   Add the following reference with the sample project:

 

**Syncfusion.PropertyGrid.Wpf.dll**

**Syncfusion.Shared.Wpf.dll**

**Syncfusion.Tools.Wpf.dll**

 

4.   Click the C# file and add the PropertyGrid control to your application as follows.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                             |
|                                                                                                                                                                                              |
| [           ]{style="FONT-FAMILY: Consolas"}                                                                                                                                                 |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: Consolas"}                                                                                                                                                            |
|                                                                                                                                                                                              |
| [Syncfusion.Windows.PropertyGrid.[PropertyGrid]{style="COLOR: #2b91af"} propertyGrid = [new]{style="COLOR: blue"} Syncfusion.Windows.PropertyGrid.[PropertyGrid]{style="COLOR: #2b91af"}();\ |
| propertyGrid.Height = 250;\                                                                                                                                                                  |
| propertyGrid.Width = 250;\                                                                                                                                                                   |
| propertyGrid.BorderBrush = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Gray);\                                                     |
| propertyGrid.BorderThickness = [new]{style="COLOR: blue"} [Thickness]{style="COLOR: #2b91af"}(2);\                                                                                           |
| propertyGrid.SelectedObject = [new]{style="COLOR: blue"} [Button]{style="COLOR: #2b91af"}();\                                                                                                |
| LayoutRoot.Children.Add(propertyGrid);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image30_707.png){border="0"}

Figure 816: PropertyGrid

 

[]{#related-topics}
:::
