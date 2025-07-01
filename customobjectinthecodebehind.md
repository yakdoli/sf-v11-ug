::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Custom object in the Code Behind {#custom-object-in-the-code-behind style="tab-stops: 0pt"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                         |
| [        [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                   |
|                                                                                                                                                                                                                                         |
| [        [///]{style="COLOR: gray"}[ Interaction logic for the class person]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                         |
| [        [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\</summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                  |
|                                                                                                                                                                                                                                         |
| [        [public]{style="COLOR: blue"} [class]{style="COLOR: blue"} [Person]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                             |
|                                                                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ Initializes a new instance of the ]{style="COLOR: green"}[\<see cref=\"Person\"/\>]{style="COLOR: gray"}[ class.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\</summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                              |
|                                                                                                                                                                                                                                         |
| [            [public]{style="COLOR: blue"} Person()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                              |
|                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.Name = [\"Tres\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                          |
|                                                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.Age = 45;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                           |
|                                                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.BackgroundBrush = [Brushes]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                            |
|                                                                                                                                                                                                                                         |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ Gets or sets the name.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                           |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\</summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                              |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<value\>]{style="COLOR: gray"}[The name.]{style="COLOR: green"}[\</value\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}               |
|                                                                                                                                                                                                                                         |
| [            [public]{style="COLOR: blue"} [string]{style="COLOR: blue"} Name]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                    |
|                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [                [get]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [                [set]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ Gets or sets the age.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                            |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\</summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                              |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<value\>]{style="COLOR: gray"}[The age.]{style="COLOR: green"}[\</value\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                |
|                                                                                                                                                                                                                                         |
| [            [public]{style="COLOR: blue"} [int]{style="COLOR: blue"} Age]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                        |
|                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [                [get]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [                [set]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ Gets or sets the background brush.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                               |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\</summary\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                              |
|                                                                                                                                                                                                                                         |
| [            [///]{style="COLOR: gray"}[ ]{style="COLOR: green"}[\<value\>]{style="COLOR: gray"}[The background brush.]{style="COLOR: green"}[\</value\>]{style="COLOR: gray"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}   |
|                                                                                                                                                                                                                                         |
| [            [public]{style="COLOR: blue"} [Brush]{style="COLOR: #2b91af"} BackgroundBrush]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                       |
|                                                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [                [get]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [                [set]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| [            }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"}                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![Description: C:\\Users\\Hemanth\\Desktop\\Documentation\\Images\\DataBinding.jpg](ImagesExt/image30_342.jpg){border="0"}

Figure 363:DataBinding Demo[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[                                              ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

[]{#related-topics}
:::
