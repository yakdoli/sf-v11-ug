::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d0473368-f993-4d63-9513-9fea468932fd){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=112c5511-a2a5-4fdf-9627-6fdde80e1d0a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=500c0c56-057a-4072-a17a-ec532fadd140){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Advanced](ms-xhelp:///?Id=d0473368-f993-4d63-9513-9fea468932fd){.d2h_breadcrumbsNormal}
:::

### How to animate the nodes in the diagram? {#how-to-animate-the-nodes-in-the-diagram style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

We can perform many kinds of animations on nodes by using the double animation. Rotation and Translation are some of the basic operations performed on the nodes. We can use double animation to perform these operations on the node in a specific pattern.

 

To rotate a node, the following code can be used:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                    |
| [Node]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ node = [new]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}([Guid]{style="COLOR: #2b91af"}.NewGuid(), [\"Node\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                    |
| [            node.Shape = [Shapes]{style="COLOR: #2b91af"}.FlowChart_Decision;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                                    |
| [            node.Level = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                    |
| [            node.Width = 150;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                    |
| [            node.Height = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                    |
| [            node.OffsetX = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                    |
| [            node.OffsetY = 100;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                    |
| [            node.Content = [\"Node\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                    |
| [            node.Level = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                    |
| [DoubleAnimation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ nodeanimation = [new]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                                    |
| [            nodeanimation.From = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                    |
| [            nodeanimation.To = 360;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                    |
| [            nodeanimation.Duration = [new]{style="COLOR: blue"} [Duration]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(0, 0, 0, 0, 500));]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                                    |
| [            nodeanimation.RepeatBehavior = [new]{style="COLOR: blue"} [RepeatBehavior]{style="COLOR: #2b91af"}(5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [            [RotateTransform]{style="COLOR: #2b91af"} rt = [new]{style="COLOR: blue"} [RotateTransform]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                    |
| [            node.RenderTransform = rt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| [            node.RenderTransformOrigin = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(.5, .5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                    |
| [            [Storyboard]{style="COLOR: #2b91af"}.SetTarget(nodeanimation, rt);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                    |
| [            [Storyboard]{style="COLOR: #2b91af"}.SetTargetProperty(nodeanimation, [new]{style="COLOR: blue"} [PropertyPath]{style="COLOR: #2b91af"}([\"(RotateTransform.Angle)\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [            [Storyboard]{style="COLOR: #2b91af"} storyBoard = [new]{style="COLOR: blue"} [Storyboard]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                                    |
| [            storyBoard.Children.Add(nodeanimation);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                    |
| [            storyBoard.Begin();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [    Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ node [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}([Guid]{style="COLOR: #2b91af"}.NewGuid(), [\"Node\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                         |
| [                  node.Shape = Shapes.FlowChart_Decision]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  node.Level = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [                  node.Width = 150]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [                  node.Height = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [                  node.OffsetX = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                         |
| [                  node.OffsetY = 100]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                         |
| [                  node.Content = \"Node\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [                  node.Level = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [    [Dim]{style="COLOR: blue"} nodeanimation [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.From = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.To = 360]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.Duration = [New]{style="COLOR: blue"} Duration(New TimeSpan(0, 0, 0, 0, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.RepeatBehavior = [New]{style="COLOR: blue"} RepeatBehavior(5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [    [Dim]{style="COLOR: blue"} rt [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [RotateTransform]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [                  node.RenderTransform = rt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                         |
| [                  node.RenderTransformOrigin = [New]{style="COLOR: blue"} Point(.5,.5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                         |
| [                  Storyboard.SetTarget(nodeanimation, rt)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [                  Storyboard.SetTargetProperty(nodeanimation, [New]{style="COLOR: blue"} PropertyPath(\"(RotateTransform.Angle)\"))]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [    [Dim]{style="COLOR: blue"} storyBoard [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Storyboard]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                                         |
| [                  storyBoard.Children.Add(nodeanimation)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  storyBoard.Begin()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To translate a node with respect to the x-axis, the TranslateTransform can be applied.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                            |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [DoubleAnimation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ nodeanimation = [new]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                           |
| [            nodeanimation.From = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                           |
| [            nodeanimation.To = 400;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                           |
| [            nodeanimation.Duration = [new]{style="COLOR: blue"} [Duration]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(0, 0, 0, 0, 500));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| [            nodeanimation.RepeatBehavior = [new]{style="COLOR: blue"} [RepeatBehavior]{style="COLOR: #2b91af"}(5);]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                              |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                        |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ nodeanimation [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| [                  nodeanimation.From = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                             |
| [                  nodeanimation.To = 400]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                             |
| [                  nodeanimation.Duration = [New]{style="COLOR: blue"} Duration(New TimeSpan(0, 0, 0, 0, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                             |
| [                  nodeanimation.RepeatBehavior = [New]{style="COLOR: blue"} RepeatBehavior(5)]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Once we have created the double animation, we can then apply it to the node, which we want to translate in the following way:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                   |
| [Node]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ node = [new]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}([Guid]{style="COLOR: #2b91af"}.NewGuid(), [\"Node\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                   |
| [            node.Shape = [Shapes]{style="COLOR: #2b91af"}.FlowChart_Decision;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                   |
| [            node.Level = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                   |
| [            node.Width = 150;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                   |
| [            node.Height = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                   |
| [            node.OffsetX = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                   |
| [            node.OffsetY = 100;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                   |
| [            node.Content = [\"Node\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                                   |
| [            node.Level = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                   |
| [            [DoubleAnimation]{style="COLOR: #2b91af"} nodeanimation = [new]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                   |
| [            nodeanimation.From = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                   |
| [            nodeanimation.To = 400;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                   |
| [            nodeanimation.Duration = [new]{style="COLOR: blue"} [Duration]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [TimeSpan]{style="COLOR: #2b91af"}(0, 0, 0, 0, 500));]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                                   |
| [            nodeanimation.RepeatBehavior = [new]{style="COLOR: blue"} [RepeatBehavior]{style="COLOR: #2b91af"}(5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                   |
| [            [TranslateTransform]{style="COLOR: #2b91af"} tt = [new]{style="COLOR: blue"} [TranslateTransform]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                                                   |
| [            node.RenderTransform = tt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                   |
| [            node.RenderTransformOrigin = [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(.5, .5);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                                   |
| [            [Storyboard]{style="COLOR: #2b91af"}.SetTarget(nodeanimation, tt);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                   |
| [            [Storyboard]{style="COLOR: #2b91af"}.SetTargetProperty(nodeanimation, [new]{style="COLOR: blue"} [PropertyPath]{style="COLOR: #2b91af"}([\"(TranslateTransform.X)\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                   |
| [            [Storyboard]{style="COLOR: #2b91af"} storyBoard = [new]{style="COLOR: blue"} [Storyboard]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                   |
| [            storyBoard.Children.Add(nodeanimation);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                   |
| [            storyBoard.Begin();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                         |
| [    Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ node [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"}([Guid]{style="COLOR: #2b91af"}.NewGuid(), [\"Node\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                         |
| [                  node.Shape = Shapes.FlowChart_Decision]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  node.Level = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [                  node.Width = 150]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [                  node.Height = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                         |
| [                  node.OffsetX = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                         |
| [                  node.OffsetY = 100]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                         |
| [                  node.Content = \"Node\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [                  node.Level = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ nodeanimation [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [DoubleAnimation]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.From = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.To = 400]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.Duration = [New]{style="COLOR: blue"} Duration(New TimeSpan(0, 0, 0, 0, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                                                         |
| [                  nodeanimation.RepeatBehavior = [New]{style="COLOR: blue"} RepeatBehavior(5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [    [Dim]{style="COLOR: blue"} tt [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [TranslateTransform]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                                         |
| [                  node.RenderTransform = tt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                         |
| [                  node.RenderTransformOrigin = [New]{style="COLOR: blue"} Point(.5,.5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                                                         |
| [                  Storyboard.SetTarget(nodeanimation, tt)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [                  Storyboard.SetTargetProperty(nodeanimation, [New]{style="COLOR: blue"} PropertyPath(\"(TranslateTransform.X)\"))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                         |
| [    [Dim]{style="COLOR: blue"} storyBoard [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Storyboard]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                                         |
| [                  storyBoard.Children.Add(nodeanimation)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
| [                  storyBoard.Begin()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

 

 

 

 

 

 

 

 

 

 

                                                                         

[]{#related-topics}
::::
