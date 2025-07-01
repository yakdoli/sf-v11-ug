::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Frequently Asked Questions {#frequently-asked-questions style="tab-stops: 0pt"}

This section will help you become more familiar in using the FolderBrowser control.

[]{style="COLOR: #15428b"} 

###### []{#p502}[]{#_What_are_FolderBrowser}3.3.7.1.5.1 What are FolderBrowser Flags? {#what-are-folderbrowser-flags style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

Flags can be used to set various styles for the FolderBrowser Dialog. Each style has it\'s own behavior and these styles can be added or removed to get the desired style for the FolderBrowser Dialog.

 

Look at the below given snippet to apply \"RestrictToSubfolders\" style and to remove the \"ShowTextBox\" style for the FolderBrowser Dialog.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                              |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                        |
|                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.folderBrowser1.Style &= \~[FolderBrowserStyles]{style="COLOR: #2b91af"}.RestrictToSubfolders;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.folderBrowser1.Style \|= [FolderBrowserStyles]{style="COLOR: #2b91af"}.ShowTextBox;]{style="FONT-FAMILY: 'Courier New'"}           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.folderBrowser1.Style = [Me]{style="COLOR: blue"}.folderBrowser1.Style [And]{style="COLOR: blue"} [Not]{style="COLOR: blue"} FolderBrowserStyles.RestrictToSubfolders]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.folderBrowser1.Style = [Me]{style="COLOR: blue"}.folderBrowser1.Style [Or]{style="COLOR: blue"} FolderBrowserStyles.ShowTextBox]{style="FONT-FAMILY: 'Courier New'"}                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
