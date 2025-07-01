::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Summaries in Grouping {#summaries-in-grouping style="tab-stops: 0pt"}

[]{#p255}The ICollectionViewAdv interface exposes an ObservableCollection\<ISummaryRow\> and CaptionSummary.

 

![](ImagesExt/image28_216.jpg){border="0"}

Figure 140: ISummayRow Interface

 

Any class implementing this interface should be able to interact with the TopLevelGroup for specifying summaries.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image28_3.jpg){border="0"}Note: The ICollectionViewAdv interface was made as an interface since the WPF properties had to be DependencyProperties to enable binding in XAML. With ICollectionViewAdv, we can specify two kinds of summaries:
:::

[·      ]{style="FONT-FAMILY: Symbol"}Group summaries.

[·      ]{style="FONT-FAMILY: Symbol"}Caption summary.

**[]{style="COLOR: #15428b"}** 

Group Summaries

 

Specifies summaries added for each bottom level group. Access each summary node from GridRecordEntry.Summaries.

 

Caption Summary

 

Specifies a caption summary row required by an UI control to display the group caption. Access the caption summary as Group.SummaryRecordEntry.

 

[]{#related-topics}
::::
