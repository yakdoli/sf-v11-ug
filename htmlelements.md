::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=87185cab-f85d-49ef-a6a8-faffe3999eba){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=58746f34-23ad-492a-839d-be543478c65e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential HTML UI]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts And Features](ms-xhelp:///?Id=fcb5d682-601f-4d1c-ae54-299d1cc60ad8){.d2h_breadcrumbsNormal}
:::

## HTML Elements {#html-elements style="tab-stops: 0pt"}

[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 14pt"}]{.underline} 

HTMLUI supports various elements in an HTML document for rendering and presenting them to the user and also allows the user to dynamically access the elements to produce rich, customized user interfaces. Each HTML element defines properties and methods which can be used for customization. 

 

The property **SupportedEvents** and the method **MergeSupportedEvents** are common to most HTML elements.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

SupportedEvents

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This property returns an array of events supporting the element.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                    |
| [// SupportedEvents property returns an array of events supporting the element. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                |
|                                                                                                                                                                                                                                                                    |
| [Hashtable htmlelements = [this]{style="COLOR: blue"}.htmluiControl1.Document.GetElementsByUserIdHash();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                      |
|                                                                                                                                                                                                                                                                    |
| [BRElementImpl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ br = htmlelements\[[\"br\"]{style="COLOR: #a31515"}\] [as]{style="COLOR: blue"} [BRElementImpl]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[.label1.Text = [this]{style="COLOR: blue"}.br.SupportedEvents.Length.ToString(); ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\' SupportedEvents property returns an array of events supporting the element. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ htmlelements [As]{style="COLOR: blue"} Hashtable = [Me]{style="COLOR: blue"}.HtmluiControl1.Document.GetElementsByUserIdHash()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ tr [As]{style="COLOR: blue"} BRElementImpl = [CType]{style="COLOR: blue"}(IIf([TypeOf]{style="COLOR: blue"} htmlelements([\"br\"]{style="COLOR: #a31515"}) [Is]{style="COLOR: blue"} BRElementImpl, htmlelements([\"br\"]{style="COLOR: #a31515"}), [Nothing]{style="COLOR: blue"}), BRElementImpl)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [Me]{style="COLOR: blue"}.label1.Text = [Me]{style="COLOR: blue"}.br.SupportedEvents.Length.ToString()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

MergeSupportedEvents[ ]{style="FONT-SIZE: 9pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **MergeSupportedEvents** method is used to merge the standard and special events.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                            |
| [// MergeSupportedEvents method is to merge the standard and special events.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                            |
|                                                                                                                                                                                                                                                                            |
| [Hashtable]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ htmlelements = [this]{style="COLOR: blue"}.htmluiControl1.Document.GetElementsByUserIdHash();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                        |
|                                                                                                                                                                                                                                                                            |
| [INPUTElementImpl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ txt = htmlelements\[[\"txt\"]{style="COLOR: #a31515"}\] [as]{style="COLOR: blue"} [INPUTElementImpl]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                            |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[\[\] specialEvents = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[2\];]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                         |
|                                                                                                                                                                                                                                                                            |
| [specialEvents\[0\] = [\"Yes\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                            |
| [specialEvents\[1\] = [\"No\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                            |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[.Show([\"Before Merging:\"]{style="COLOR: #a31515"} + [this]{style="COLOR: blue"}.txt.SupportedEvents.Length.ToString());]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}            |
|                                                                                                                                                                                                                                                                            |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[.txt.MergeSupportedEvents(specialEvents);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                     |
|                                                                                                                                                                                                                                                                            |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[.Show([\"After Merging:\"]{style="COLOR: #a31515"} + [this]{style="COLOR: blue"}.txt.SupportedEvents.Length.ToString());]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [\' MergeSupportedEvents method is to merge the standard and special events.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ htmlelements [As]{style="COLOR: blue"} Hashtable = [Me]{style="COLOR: blue"}.HtmluiControl1.Document.GetElementsByUserIdHash()]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ txt [As]{style="COLOR: blue"} INPUTElementImpl = [CType]{style="COLOR: blue"}(IIf([TypeOf]{style="COLOR: blue"} htmlelements([\"txt\"]{style="COLOR: #a31515"}) [Is]{style="COLOR: blue"} INPUTElementImpl, htmlelements([\"txt\"]{style="COLOR: #a31515"}), [Nothing]{style="COLOR: blue"}), INPUTElementImpl)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ specialEvents [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}() = [New]{style="COLOR: blue"} [String]{style="COLOR: blue"}(1) {}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ specialEvents(0) = [\"Yes\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ specialEvents(1) = [\"No\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [MessageBox.Show([\"Before Merging:\"]{style="COLOR: #a31515"} + [Me]{style="COLOR: blue"}.txt.SupportedEvents.Length.ToString())]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[.txt.MergeSupportedEvents(specialEvents)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [MessageBox.Show([\"After Merging:\"]{style="COLOR: #a31515"} + [Me]{style="COLOR: blue"}.txt.SupportedEvents.Length.ToString())]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p36} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Element Types](ms-xhelp:///?Id=58746f34-23ad-492a-839d-be543478c65e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}A - Anchor Element](ms-xhelp:///?Id=dcf9a795-0670-4f93-b098-a7cf957424a2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}B - Bold Element](ms-xhelp:///?Id=8d5ef9fa-7057-49cf-81de-3d732b4c82fa){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}BODY Element](ms-xhelp:///?Id=8baa2f10-d77b-4839-a84d-4a1c0df3ccd6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}BR - Break Element](ms-xhelp:///?Id=022b7ea4-1f39-4a73-bffc-87007b724e48){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}CODE Element](ms-xhelp:///?Id=07d6480f-04d2-4f70-821a-b25b5eda3d6b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}CUSTOM Element](ms-xhelp:///?Id=1330166a-c1b5-483d-a855-42ca8d42e711){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DIV - Division Element](ms-xhelp:///?Id=7a223837-0a0a-4eef-9bff-816c5edf7931){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}EM - Emphasize element](ms-xhelp:///?Id=6577fcff-edcb-4422-b35e-dd0a6feb0254){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}FONT Element](ms-xhelp:///?Id=a6ea6ee3-3092-47f4-b967-55057fa0d7b3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}FORM Element](ms-xhelp:///?Id=972858be-3c0a-489c-ac07-d63d759e318b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}H1 - H6 Header Elements](ms-xhelp:///?Id=b8e0b1ac-473a-4650-9777-8c33f10daa73){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HEAD Element](ms-xhelp:///?Id=cc860c58-8e8e-472a-8da2-089d21e7cccb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HTML Element](ms-xhelp:///?Id=62f68cfe-f4ed-4753-a566-3c2ded0988f2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HR - Horizontal Rule Element](ms-xhelp:///?Id=1f002779-06de-4d99-bca4-df95a2d15872){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}I - Italics Element](ms-xhelp:///?Id=77b8405e-26c7-4906-a08d-059f0ca98652){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}IMG - Image Element](ms-xhelp:///?Id=932d24e8-e063-4318-9fb5-daa0c6f74d61){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}INPUT Element](ms-xhelp:///?Id=21321dc8-ccad-4039-bd7a-04b25defbc76){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LI - List Element](ms-xhelp:///?Id=5697628e-13ca-4257-82c2-5b309c1d9036){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LINK Element](ms-xhelp:///?Id=1be43fc6-2c94-4efb-9a11-930f2eb5edc1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}OL - Ordered List Element](ms-xhelp:///?Id=629c4f7d-b36f-45be-89f9-aada9507e2e0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}P - Paragraph Element](ms-xhelp:///?Id=3240cad4-4312-4001-953e-635376cc057e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PRE - Preformatted Element](ms-xhelp:///?Id=ceebb639-1ee8-4bef-a505-3a78dc838ed0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SCRIPT Element](ms-xhelp:///?Id=ed9a1d7a-84f1-4868-a0c3-88ec38c271c2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SELECT Element](ms-xhelp:///?Id=60089db9-f82b-4323-8135-0ee5672a3ed9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SPAN Element](ms-xhelp:///?Id=db9c6368-dee4-4bbd-98d3-5d14cf62a657){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}STRONG Element](ms-xhelp:///?Id=d21e5195-4af7-4776-b2d3-f96fa951fffe){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}STYLE Element](ms-xhelp:///?Id=5f953498-011d-41ed-ae70-07a97faf6bbb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TABLE Element](ms-xhelp:///?Id=fe847a1a-4a69-4e4d-8ffc-bd6349c0ec83){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TD - Table cell Element](ms-xhelp:///?Id=081731fe-5593-4873-93f2-e6d552833f47){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TEXTAREA Element](ms-xhelp:///?Id=d7ee8b00-41c9-4f53-b970-c358bddfda3e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TH - Table Head Element](ms-xhelp:///?Id=87adc5b6-e99c-4c36-b994-ad6279f32301){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TR - Table Row Element](ms-xhelp:///?Id=8b0e2bd3-6bac-45fa-846b-dac4ae1b2926){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}UL - Unordered List Element](ms-xhelp:///?Id=0ec77284-341f-4df0-8d06-06b4fda7aebd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}U - Underline Element](ms-xhelp:///?Id=566558dd-d37e-49ca-90f2-239271512648){style="TEXT-DECORATION: none"}
::::
