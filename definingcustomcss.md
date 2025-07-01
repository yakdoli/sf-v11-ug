::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Defining Custom CSS {#defining-custom-css style="tab-stops: 0pt"}

The rating control supports custom CSS so that images for ratings (size, shape, and so on) can be customized to suit your application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Properties

  --------------------------------------------------------- ------------------------------------------------------ ------------------ ------------------- ------------
  Name                                                      Description                                            Type of property   Value it accepts    Dependency
  CustomCSS                                                 Sets the class attribute of the control.               string             Any string          NA
  CustomImageHeight[]{style="FONT-FAMILY: 'Courier New'"}   Gets the height of the custom rating icon in pixels.   int                1 to int.MaxValue   NA
  CustomImageWidth                                          Gets the height of the custom rating icon in pixels.   int                1 to int.MaxValue   NA
  --------------------------------------------------------- ------------------------------------------------------ ------------------ ------------------- ------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following steps explain how to define custom styling for the rating control.

1.   In **View**, invoke the rating helper followed by the **CustomCSS**, **CustomImageHeight**, and **CustomImageWidth** methods with the desired options as arguments.

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View \[ASPX\]**                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().Rating([\"myRating\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                |
| [.**CustomCSS([\"MyRatingStyle\"]{style="COLOR: #a31515"})**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                |
| **[.CustomImageHeight(28)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                |
| **[.CustomImageWidth(28)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[%\>]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                         |
|                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                                                |
|                                                                                                                                                                                                                   |
| [\@{]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[ Html.Syncfusion().Rating([\"myRating\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                    |
|                                                                                                                                                                                                                   |
| [.**CustomCSS([\"MyRatingStyle\"]{style="COLOR: #a31515"})**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                    |
|                                                                                                                                                                                                                   |
| **[.CustomImageHeight(28)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                     |
|                                                                                                                                                                                                                   |
| **[.CustomImageWidth(28)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[.Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[}]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

2.   In the style sheet, define the styles.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ** \[CSS\]**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                         |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[style]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [type]{style="COLOR: red"}[=\"text/css\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [display]{style="COLOR: red"}: [block]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                         |
| [            [position]{style="COLOR: red"}: [relative]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                         |
| [            [margin-top]{style="COLOR: red"}: [-11px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.horizontal]{style="COLOR: #a31515"} [.star-container]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                         |
| [            [padding]{style="COLOR: red"}: [0]{style="COLOR: blue"} [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.vertical]{style="COLOR: #a31515"} [.star-container]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                         |
| [            [margin]{style="COLOR: red"}: [0]{style="COLOR: blue"} [0]{style="COLOR: blue"} [0]{style="COLOR: blue"} [-2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                         |
| [            [padding]{style="COLOR: red"}: [0]{style="COLOR: blue"} [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.horizontal]{style="COLOR: #a31515"} [.star-list]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                         |
| [            [float]{style="COLOR: red"}: [left]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                         |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-56px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [            [cursor]{style="COLOR: red"}:[pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.vertical]{style="COLOR: #a31515"} [.star-list]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                         |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                         |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-56px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [            [cursor]{style="COLOR: red"}:[pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.horizontal]{style="COLOR: #a31515"} [.stars]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                         |
| [            [float]{style="COLOR: red"}: [left]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                         |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.vertical]{style="COLOR: #a31515"} [.stars]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                         |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                         |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.horizontal]{style="COLOR: #a31515"} [.reset]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                         |
| [            [float]{style="COLOR: red"}: [left]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                         |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [margin-right]{style="COLOR: red"}: [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                         |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0px]{style="COLOR: blue"} [0px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle.vertical]{style="COLOR: #a31515"} [.reset]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                         |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                         |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                         |
| [            [margin-bottom]{style="COLOR: red"}: [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                         |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0px]{style="COLOR: blue"} [0px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle]{style="COLOR: #a31515"} [.reset:hover]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle]{style="COLOR: #a31515"} [.stars.inactive]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-56px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle]{style="COLOR: #a31515"} [.stars.active]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-112px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [        [.MyRatingStyle]{style="COLOR: #a31515"} [.stars.selected]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-84px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [    [\</]{style="COLOR: blue"}[style]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Build and run the application. 

The following figure shows the crystal-stars.png sprite image used in the code sample.

 

![Description: C:\\RP - 8.3\\Tools.MVC\\Samples\\3.5\\Images\\Rating\\crystal-stars.png](ImagesExt/image56_200.png){border="0"}

Figure 190: Sprite Image

 

Individual images can be made into sprites by using [[SpriteGen]{.UGHyperlink}](http://spritegen.website-performance.org/)---an automated process for generating CSS sprites.

The figure shows the how the sprite images appear in the rating control.

 

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Rating\\Concepts_Features\\customcss.png](ImagesExt/image56_201.png){border="0"}

Figure 191: Rating Control with Custom CSS Sprite Image

 

*[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}* 

[]{#related-topics}
:::
