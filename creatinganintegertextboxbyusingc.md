::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Creating an IntegerTextBox by using C# {#creating-an-integertextbox-by-using-c style="tab-stops: 0pt"}

The steps to create an IntegerTextBox by using Visual Studio in C# are as follows:

1.  Open Visual Studio.

    2.  On the File menu, select **New -\> Project**. This opens the New Project Dialog box.

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\WPF Tools correct Image.png](ImagesExt/image30_13.png){border="0"}

Figure 604: Open New Project

3.   On the Project Dialog window, select **WPF Application**, in the name field, type the name of the project, and then click **OK**.

 

![](ImagesExt/image30_14.png){border="0"}

 

Figure 605: New Project Dialog

 

4.   Add the following reference with the sample project:

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.WPF.dll

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image30_219.png){border="0"}

 

Figure 606: Solution Explorer

 

5.   Click the **C#** file, to open the C# file and add the **IntegerTextBox** to the application.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[C#]{style="COLOR: black"}[]{style="FONT-FAMILY: Consolas; COLOR: black; FONT-SIZE: 9.5pt"}**                                                                                                                              |
|                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}**                                                                                                                                                         |
|                                                                                                                                                                                                                              |
| **[namespace]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ WpfApp]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                      |
|                                                                                                                                                                                                                              |
| **[{]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                              |
| **[    [public]{style="COLOR: blue"} [partial]{style="COLOR: blue"} [class]{style="COLOR: blue"} [MainWindow]{style="COLOR: #2b91af"} : [Window]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}** |
|                                                                                                                                                                                                                              |
| **[    {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                              |
| **[        [public]{style="COLOR: blue"} MainWindow()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                    |
|                                                                                                                                                                                                                              |
| **[        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                             |
|                                                                                                                                                                                                                              |
| **[            InitializeComponent();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                    |
|                                                                                                                                                                                                                              |
| **[            [//Adding IntegerTextBox to Application]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                            |
|                                                                                                                                                                                                                              |
| **[            Syncfusion.Windows.Shared.[IntegerTextBox]{style="COLOR: #2b91af"} integerTextBox = [new]{style="COLOR: blue"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                            |
|                                                                                                                                                                                                                              |
| **[                                    Syncfusion.Windows.Shared.[IntegerTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                             |
|                                                                                                                                                                                                                              |
| **[            integerTextBox.Height = 25;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                               |
|                                                                                                                                                                                                                              |
| **[            integerTextBox.Width = 100;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                               |
|                                                                                                                                                                                                                              |
| **[            [this]{style="COLOR: blue"}.LayoutRoot.Children.Add(integerTextBox);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                      |
|                                                                                                                                                                                                                              |
| **[        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                             |
|                                                                                                                                                                                                                              |
| **[    }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                              |
| **[}]{style="FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

![](ImagesExt/image30_555.png){border="0"}

 

Figure 607: IntegerTextBox

 

See Also

[[Creating an IntegerTextBox by using XAML]{.UGHyperlink}](ms-xhelp:///?Id=98a30f06-d286-444a-8468-a523d23df7c1)[]{.UGHyperlink}

[[Blendability]{.UGHyperlink}](ms-xhelp:///?Id=3a8c90d1-1f38-4064-8f29-b1c63b9f1a07)[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.underline} 

[]{#related-topics}
:::
