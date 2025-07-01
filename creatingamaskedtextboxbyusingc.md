::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Creating a MaskedTextBox by using C# {#creating-a-maskedtextbox-by-using-c style="tab-stops: 0pt"}

The steps to create a MaskedTextBox by using Visual Studio in C# are as follows:

1.   Open Visual Studio.

2.   On the File menu, select **New -\> Project**. This opens the New Project Dialog box.

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\WPF Tools correct Image.png](ImagesExt/image30_13.png){border="0"}

Figure 666: Open New Project[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

3.   On the Project Dialog window, select **WPF Application**, in the name field, type the name of the project, and then click **OK**.

 

![](ImagesExt/image30_14.png){border="0"}

 

Figure 667: New Project Dialog

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

4.   Add the following reference with the sample project:

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.WPF.dll

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image30_219.png){border="0"}

 

Figure 668: Solution Explorer

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

5.   Click the **C#** file, to open the C# file and add the **MaskedTextBox** to the application.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **C#[    ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                               |
| [public]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [partial]{style="COLOR: blue"} [class]{style="COLOR: blue"} [MainWindow]{style="COLOR: #2b91af"} : [Window]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                               |
| [    {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                               |
| [        [public]{style="COLOR: blue"} MainWindow()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                               |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                               |
| [            InitializeComponent();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                               |
| [            Syncfusion.Windows.Shared.[MaskedTextBox]{style="COLOR: #2b91af"} maskedTextBox = [new]{style="COLOR: blue"} Syncfusion.Windows.Shared.[MaskedTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}              |
|                                                                                                                                                                                                                                                               |
| [            maskedTextBox.Height = 25;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                               |
| [            maskedTextBox.Width = 150;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                               |
| [            maskedTextBox.Mask = [\"00/00/0000\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                 |
|                                                                                                                                                                                                                                                               |
| [            [this]{style="COLOR: blue"}.LayoutRoot.Children.Add(maskedTextBox);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                            |
|                                                                                                                                                                                                                                                               |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                               |
| [    }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

![](ImagesExt/image30_595.png){border="0"}

Figure 669:  MaskedTextBox

See Also

[[Creating a MaskedTextBox by using XAML]{.UGHyperlink}](ms-xhelp:///?Id=1000a39e-f65f-452d-bdfa-7b56cf58e1da)[]{.UGHyperlink}

[[Creating a MaskedTextBox by using Blend]{.UGHyperlink}](ms-xhelp:///?Id=9aef2288-a7bd-411a-9903-d0811bd5734f)[]{.UGHyperlink}

 

[]{#related-topics}
:::
