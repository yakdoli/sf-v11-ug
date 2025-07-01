::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d064728b-ff88-4fb3-824f-46395df893be){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2d753c4a-6247-4e89-888d-adf9de4ab81c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=2206ded2-cc47-47f5-86b1-d5d1f5b27678){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Advanced](ms-xhelp:///?Id=d064728b-ff88-4fb3-824f-46395df893be){.d2h_breadcrumbsNormal}
:::

### Animate the Dodes in the Diagram {#animate-the-dodes-in-the-diagram style="tab-stops: 0pt"}

You can perform many kinds of animations on nodes by using the double animation. Rotation and Translation are some of the basic operations performed on the nodes. You can use double animation to perform these operations on the node in a specific pattern.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To rotate a node, the following code can be used.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                          |
|                                                                                                                                                                                                               |
| [DoubleAnimation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ nodeanimation = [new]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                               |
| [nodeanimation.From = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                               |
| [nodeanimation.To = 360;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                               |
| [nodeanimation.Duration = [new]{style="COLOR: blue"} [Duration]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(0, 0, 0, 0, 500));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [nodeanimation.RepeatBehavior = [new]{style="COLOR: blue"} [RepeatBehavior]{style="COLOR: #2b91af"}(15);]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [RotateTransform]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rt = [new]{style="COLOR: blue"} [RotateTransform]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                               |
| [nodeObj.RenderTransform = rt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                               |
| [nodeObj.RenderTransformOrigin = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(.5, .5);]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                               |
| [rt.BeginAnimation([RotateTransform]{style="COLOR: #2b91af"}.AngleProperty, nodeanimation);]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                             |
|                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ nodeanimation [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DoubleAnimation()]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                  |
| [nodeanimation.From = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                  |
| [nodeanimation.To = 360]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                  |
| [nodeanimation.Duration = [New]{style="COLOR: blue"} Duration(New TimeSpan(0, 0, 0, 0, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                  |
| [nodeanimation.RepeatBehavior = [New]{style="COLOR: blue"} RepeatBehavior(15)]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rt [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [RotateTransform]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                  |
| [nodeObj.RenderTransform = rt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                  |
| [nodeObj.RenderTransformOrigin = [New]{style="COLOR: blue"} Point(.5,.5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                  |
| [rt.BeginAnimation(RotateTransform.AngleProperty, nodeanimation)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To translate a node with respect to the x-axis, the TranslateTransform can be applied.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                          |
|                                                                                                                                                                                                               |
| [DoubleAnimation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ nodeanimation = [new]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                               |
| [nodeanimation.From = 500;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                               |
| [nodeanimation.To = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                               |
| [nodeanimation.Duration = [new]{style="COLOR: blue"} [Duration]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(0, 0, 0, 0, 500));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [nodeanimation.RepeatBehavior = [new]{style="COLOR: blue"} [RepeatBehavior]{style="COLOR: #2b91af"}(1);]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                    |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ nodeanimation [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DoubleAnimation()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [nodeanimation.From = 500]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                   |
| [nodeanimation.To = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                   |
| [nodeanimation.Duration = [New]{style="COLOR: blue"} Duration(New TimeSpan(0, 0, 0, 0, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                   |
| [nodeanimation.RepeatBehavior = [New]{style="COLOR: blue"} RepeatBehavior(1)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Once you have created the double animation, you can then apply it to the node which we want to translate in the following way.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                          |
|                                                                                                                                                                                                               |
| [DoubleAnimation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ nodeanimation = [new]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                               |
| [nodeanimation.From = 500;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                               |
| [nodeanimation.To = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                               |
| [nodeanimation.Duration = [new]{style="COLOR: blue"} [Duration]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(0, 0, 0, 0, 500));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [nodeanimation.RepeatBehavior = [new]{style="COLOR: blue"} [RepeatBehavior]{style="COLOR: #2b91af"}(1);]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [TranslateTransform]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rt = [new]{style="COLOR: blue"} [TranslateTransform]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                               |
| [nodeObj.RenderTransform = rt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                               |
| [rt.BeginAnimation([TranslateTransform]{style="COLOR: #2b91af"}.XProperty, nodeanimation);]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                |
|                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ nodeanimation [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DoubleAnimation()]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                     |
| [nodeanimation.From = 500]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                     |
| [nodeanimation.To = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                     |
| [nodeanimation.Duration = [New]{style="COLOR: blue"} Duration(New TimeSpan(0, 0, 0, 0, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                     |
| [nodeanimation.RepeatBehavior = [New]{style="COLOR: blue"} RepeatBehavior(1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rt [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [TranslateTransform]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| [nodeObj.RenderTransform = rt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                     |
| [rt.BeginAnimation(TranslateTransform.XProperty, nodeanimation)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
::::
