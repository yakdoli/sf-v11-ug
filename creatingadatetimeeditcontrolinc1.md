::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Creating a DateTimeEdit control in C# {#creating-a-datetimeedit-control-in-c style="tab-stops: 0pt"}

The steps to create a DateTimeEdit control by using Visual Studio in C# are as follows:

 

1.   Open Visual Studio.

2.   On the File menu, select **New -\> Project**. This opens the New Project Dialog box.

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\WPF Tools correct Image.png](ImagesExt/image30_13.png){border="0"}

Figure 266: Open New Project[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

3.   On the Project Dialog window, select **WPF Application**, in the name field, type the name of the project, and then click **OK**.

 

![](ImagesExt/image30_14.png){border="0"}

Figure 267: New Project Dialog[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

4.   Add the following reference with the sample project:

 

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.WPF.dll

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image30_219.png){border="0"}

Figure 268: Solution Explorer

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

5.   Click the **C#** file, to open the C# file and add the **DateTimeEdit** control to the application.

Here is the code to create the DateTimeEdit control in C#:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="COLOR: black"}                                                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [namespace]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ WpfApp]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                      |
|                                                                                                                                                                                                                          |
| [{]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                     |
|                                                                                                                                                                                                                          |
| [    [public]{style="COLOR: blue"} [partial]{style="COLOR: blue"} [class]{style="COLOR: blue"} [MainWindow]{style="COLOR: #2b91af"} : [Window]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                          |
| [    {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                 |
|                                                                                                                                                                                                                          |
| [        [public]{style="COLOR: blue"} MainWindow()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                    |
|                                                                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                             |
|                                                                                                                                                                                                                          |
| [            InitializeComponent();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                    |
|                                                                                                                                                                                                                          |
| [            [//Adding DateTimeEdit control to application from Syncfusion.Windows.Shared]{style="COLOR: green"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                          |
| [            Syncfusion.Windows.Shared.[DateTimeEdit]{style="COLOR: #2b91af"} dateTimeEdit = [new]{style="COLOR: blue"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                |
|                                                                                                                                                                                                                          |
| [                               Syncfusion.Windows.Shared.[DateTimeEdit]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                    |
|                                                                                                                                                                                                                          |
| [            dateTimeEdit.Width = 200;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                 |
|                                                                                                                                                                                                                          |
| [            dateTimeEdit.Height = 25;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                 |
|                                                                                                                                                                                                                          |
| [            [this]{style="COLOR: blue"}.LayoutRoot.Children.Add(dateTimeEdit);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                        |
|                                                                                                                                                                                                                          |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                             |
|                                                                                                                                                                                                                          |
| [    }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                 |
|                                                                                                                                                                                                                          |
| [}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image30_253.png){border="0"}

Figure 269: DateTimeEdit

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

See Also

[[Creating a DateTimeEdit control in XAML]{.UGHyperlink}](ms-xhelp:///?Id=4fc74b66-07ff-4d5b-81e2-b57393d53fc3)[]{.UGHyperlink}

[[Creating a DateTimeEdit control by using Expression Blend]{.UGHyperlink}](ms-xhelp:///?Id=6c9c13a7-f17b-49bf-be20-23013db2d44d)[[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: #0070c0"}]{.underline}

 

[]{#related-topics}
:::
