::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### []{#_Keyboard_Support}Keyboard Support

TabControlAdv has support for keyboard inputs. You can navigate the Tab Items from the keyboard. There are four properties to customize keyboard navigation as tabulated below.

[            ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}

+------------------------+-----------------------+-------------------------------------------------+
| Properties             | Default Key           | Description                                     |
+------------------------+-----------------------+-------------------------------------------------+
| LeftItemNavigationKey  | Left Arrow            | To navigate Tab Items through left orientation  |
|                        |                       |                                                 |
|                        |                       |                                                 |
+------------------------+-----------------------+-------------------------------------------------+
| RightItemNavigationKey | Right Arrow           | To navigate Tab Items through right orientation |
+------------------------+-----------------------+-------------------------------------------------+
| FirstItemNavigationKey | Home                  | To navigate First Tab Item                      |
+------------------------+-----------------------+-------------------------------------------------+
| LastItemNavigationKey  | End                   | To navigate Last Tab Item                       |
+------------------------+-----------------------+-------------------------------------------------+

[            ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}

You can define the keys for the properties through xaml and Code behind.

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Xaml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[TabControlAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[  [ Name]{style="COLOR: red"}[=\"MyTabCtrl\"]{style="COLOR: blue"}[ LeftItemNavigationKey]{style="COLOR: red"}[=\"A\"]{style="COLOR: blue"}[ RightItemNavigationKey]{style="COLOR: red"}[=\"D\"]{style="COLOR: blue"}[ FirstItemNavigationKey]{style="COLOR: red"}[=\"PageUp\"]{style="COLOR: blue"} [ LastItemNavigationKey]{style="COLOR: red"}[=\"PageDown\"]{style="COLOR: blue"} [ \>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]          ]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                             |
| [            MyTabCtrl.LeftItemNavigationKey = [Key]{style="COLOR: #2b91af"}.A;]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                             |
| [            MyTabCtrl.RightItemNavigationKey = [Key]{style="COLOR: #2b91af"}.D;]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                             |
| [            MyTabCtrl.FirstItemNavigationKey = [Key]{style="COLOR: #2b91af"}.PageUp;]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                             |
| [            MyTabCtrl.LastItemNavigationKey = [Key]{style="COLOR: #2b91af"}.PageDown;]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::
