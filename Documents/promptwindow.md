::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### []{#_Prompt_Window}Prompt Window

The Prompt allows the user to get input from the end user. The Prompt Window can be shown by calling a static method *ShowPrompt()*. The method will take the following arguments:

[·      ]{style="FONT-FAMILY: Symbol"}Message

[·      ]{style="FONT-FAMILY: Symbol"}Title

[·      ]{style="FONT-FAMILY: Symbol"}Prompt Text

[·      ]{style="FONT-FAMILY: Symbol"}DialogIcon

[·      ]{style="FONT-FAMILY: Symbol"}DialogButton

[·      ]{style="FONT-FAMILY: Symbol"}ClosedEventHandler

[·      ]{style="FONT-FAMILY: Symbol"}AnimationType

  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  C#
  [WindowControl]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[.ShowPrompt([\"Enter the text:\"]{style="COLOR: #a31515"}, [\"Prompt\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

![](../ImagesExt/image261_986.jpg){border="0"}

Figure 1091: Prompt

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  C#
  [WindowControl]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[.ShowPrompt([\"Enter the text:\"]{style="COLOR: #a31515"}, [\"Prompt\"]{style="COLOR: #a31515"}, [\"Input\"]{style="COLOR: #a31515"}, [DialogIcon]{style="COLOR: #2b91af"}.Question, [DialogButton]{style="COLOR: #2b91af"}.OKCancel, [null]{style="COLOR: blue"}, [AnimationType]{style="COLOR: #2b91af"}.Fade);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}
  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 

![](../ImagesExt/image261_987.jpg){border="0"}

Figure 1092: Input

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| C#                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [WindowControl]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[.ShowPrompt([\"Enter the text:\"]{style="COLOR: #a31515"}, [\"Prompt\"]{style="COLOR: #a31515"}, [\"Input\"]{style="COLOR: #a31515"}, [DialogIcon]{style="COLOR: #2b91af"}.Question, [DialogButton]{style="COLOR: #2b91af"}.OKCancel, [new]{style="COLOR: blue"} [ClosedEventHandler]{style="COLOR: #2b91af"}(OnClosed), [AnimationType]{style="COLOR: #2b91af"}.Fade);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [private]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [void]{style="COLOR: blue"} OnClosed([object]{style="COLOR: blue"} sender, [ClosedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [{]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
