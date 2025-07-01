::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding through C# {#adding-through-c style="tab-stops: 0pt"}

Follow the below steps to add the Carousel control by using VisualStudio.

1.   Open Visual Studio. On the File menu, select **New -\> Project**. This opens the New Project Dialog box.

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\WPF Tools correct Image.png](ImagesExt/image30_13.png){border="0"}

Figure 105: Open New Project

 

2.   In the Project Dialog window, select **WPF Application** and in the name field type the name of the project, and then click **OK**.

 

3.   Add the following reference with the sample project.

**Syncfusion.Shared.Wpf.dll**

 

4.   Click and open the C# file and add the Carousel control to your application.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The below code shows how the Carousel control can be added to an application:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                             |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                              |
| [Carousel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ carousel = [new]{style="COLOR: blue"} [Carousel]{style="COLOR: #2b91af"}();\ |
| carousel.Items.Add([new]{style="COLOR: blue"} [CarouselItem]{style="COLOR: #2b91af"}() { Content = [\"1\"]{style="COLOR: #a31515"} });\      |
| carousel.Items.Add([new]{style="COLOR: blue"} [CarouselItem]{style="COLOR: #2b91af"}() { Content = [\"2\"]{style="COLOR: #a31515"} });\      |
| carousel.Items.Add([new]{style="COLOR: blue"} [CarouselItem]{style="COLOR: #2b91af"}() { Content = [\"3\"]{style="COLOR: #a31515"} });\      |
| carousel.Items.Add([new]{style="COLOR: blue"} [CarouselItem]{style="COLOR: #2b91af"}() { Content = [\"4\"]{style="COLOR: #a31515"} });\      |
| carousel.Items.Add([new]{style="COLOR: blue"} [CarouselItem]{style="COLOR: #2b91af"}() { Content = [\"5\"]{style="COLOR: #a31515"} });\      |
| [this]{style="COLOR: blue"}.LayoutRoot.Children.Add(carousel);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
