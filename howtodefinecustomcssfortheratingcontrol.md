::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to define Custom CSS for the Rating control? {#how-to-define-custom-css-for-the-rating-control style="tab-stops: 0pt"}

[[[]{style="TEXT-DECORATION: none"}]{style="COLOR: blue"}]{.underline} 

The rating control supports custom CSS so that images for ratings (size, shape, and so on) can be customized to suit your application.

 This is the property for Custom skins for Rating control-

Properties

  ------------------- ------------------------------------------------------ ------------------ ------------------- ------------
  Name                Description                                            Type of property   Value it accepts    Dependency
  CustomCSS           Sets the class attribute of the control.               string             Any string          NA
  CustomImageHeight   Gets the height of the custom rating icon in pixels.   int                1 to int.MaxValue   NA
  CustomImageWidth    Gets the height of the custom rating icon in pixels.   int                1 to int.MaxValue   NA
  ------------------- ------------------------------------------------------ ------------------ ------------------- ------------

 

Using ASPX code-

Build and run the application using the following ASPX code:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Rating]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [ID]{style="COLOR: red"}[=\"Rating1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [CustomCss]{style="COLOR: red"}[=\"MyRatingStyle\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [CustomImageHeight]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"28\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [CustomImageWidth]{style="COLOR: red"}[=\"28\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

**Using C# or VB code-**

Build and run the application using either one of the following code snippets:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                             |
| [       [Rating]{style="COLOR: #2b91af"} rating = [new]{style="COLOR: blue"} [Rating]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                             |
| [    rating.CustomCss = [\"]{style="COLOR: #a31515"}[ MyRatingStyle]{style="COLOR: maroon"}[ \"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                             |
| [    rating.CustomImageHeight = 28;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                             |
| [    rating.CustomImageWidth = 28;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[VB\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                               |
| [        [Dim]{style="COLOR: blue"} rating [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [Rating]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [    rating.CustomCss = [\"]{style="COLOR: #a31515"}[ MyRatingStyle]{style="COLOR: maroon"}[ \"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                               |
| [    rating.CustomImageHeight = 28]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                               |
| [    rating.CustomImageWidth = 28]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[[[]{style="TEXT-DECORATION: none"}]{style="COLOR: blue"}]{.underline} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [ \[Css\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                    |
| [.MyRatingStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [display]{style="COLOR: red"}: [block]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                    |
| [            [position]{style="COLOR: red"}: [relative]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                    |
| [            [margin-top]{style="COLOR: red"}: [-7px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.horizontal]{style="COLOR: maroon"} [.star-container]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                    |
| [            [padding]{style="COLOR: red"}: [0]{style="COLOR: blue"} [2px]{style="COLOR: blue"}; [display]{style="COLOR: red"}:[inline]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.vertical]{style="COLOR: maroon"} [.star-container]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                    |
| [            [margin]{style="COLOR: red"}: [0]{style="COLOR: blue"} [0]{style="COLOR: blue"} [0]{style="COLOR: blue"} [-2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                    |
| [            [padding]{style="COLOR: red"}: [0]{style="COLOR: blue"} [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.horizontal]{style="COLOR: maroon"} [.star-list]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                    |
| [            [float]{style="COLOR: red"}: [left]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                    |
| [            [background]{style="COLOR: red"}: [url(\"../Images/crystal-stars.png\")no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-56px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [            [cursor]{style="COLOR: red"}:[pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.vertical]{style="COLOR: maroon"} [.star-list]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [list-style-type]{style="COLOR: red"}: [none]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                    |
| [            [background]{style="COLOR: red"}: [url(\"../Images/crystal-stars.png\")no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-56px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [            [cursor]{style="COLOR: red"}:[pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.horizontal]{style="COLOR: maroon"} [.stars]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background]{style="COLOR: red"}: [url(\"../Images/crystal-stars.png\")no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                    |
| [            [float]{style="COLOR: red"}: [left]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.vertical]{style="COLOR: maroon"} [.stars]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background]{style="COLOR: red"}: [url(../Images/crystal-stars.png)]{style="COLOR: blue"} [no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                    |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.horizontal]{style="COLOR: maroon"} [.reset]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background]{style="COLOR: red"}: [url(\"../Images/crystal-stars.png\")no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                    |
| [            [float]{style="COLOR: red"}: [left]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [margin-right]{style="COLOR: red"}: [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                    |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0px]{style="COLOR: blue"} [0px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle.vertical]{style="COLOR: maroon"} [.reset]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background]{style="COLOR: red"}: [url(\"../Images/crystal-stars.png\")no-repeat]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                    |
| [            [height]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                    |
| [            [margin-bottom]{style="COLOR: red"}: [2px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                    |
| [            [cursor]{style="COLOR: red"}: [pointer]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0px]{style="COLOR: blue"} [0px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle]{style="COLOR: maroon"} [.reset:hover]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle]{style="COLOR: maroon"} [.stars.inactive]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-56px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle]{style="COLOR: maroon"} [.stars.active]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-112px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle]{style="COLOR: maroon"} [.stars.selected]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-84px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [        [.MyRatingStyle]{style="COLOR: maroon"} [.stars.precision]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| [            [background-position]{style="COLOR: red"}: [0]{style="COLOR: blue"} [-84px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                    |
| [            [width]{style="COLOR: red"}: [0px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                    |
| [            [margin-left]{style="COLOR: red"}: [-28px]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The following figure shows the crystal-stars.png sprite image used in the code sample.

![Description: Description: Description: C:\\RP - 8.3\\Tools.MVC\\Samples\\3.5\\Images\\Rating\\crystal-stars.png](ImagesExt/image72_579.png){border="0"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

**[Figure ]{style="FONT-STYLE: normal"}[449]{style="FONT-STYLE: normal"}[: Sprite Image]{style="FONT-STYLE: normal"}**

                  

Individual images can be made into sprites by using [[SpriteGen]{style="COLOR: blue"}](http://spritegen.website-performance.org/)---an automated process for generating CSS sprites.

The figure shows the how the sprite images appear in the rating control.

![Description: Description: Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\Rating\\Concepts_Features\\customcss.png](ImagesExt/image72_580.png){border="0"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

**[Figure ]{style="FONT-STYLE: normal"}[450]{style="FONT-STYLE: normal"}[: Rating Control with Custom CSS Sprite Image]{style="FONT-STYLE: normal"}**

 

[]{#related-topics}
:::
