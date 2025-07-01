::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to Efficiently Customize the Child Table / Group using a Custom Engine {#how-to-efficiently-customize-the-child-table-group-using-a-custom-engine style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

When customizing the GridChildTable / GridGroup by deriving the GridChildTable / GridGroup in the custom engine, the OnInitializeVisibleCounters method and the OnEnsureInitialized method must also be overridden along with the other overrides. Otherwise the GridGroup calls into the GridGroup extend methods and sometimes bypasses the methods like IsChildVisible that you have overridden.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In the OnInitializeVisibleCounters override, the total visible elements count, the total vertical scroll distance of elements in pixels and the total custom count of the visible elements must be calculated and set to the CachedVisibleCount, CachedYamountCount and CachedVisibleCustomCount respectively. The OnEnsureInitialized override method must return false (i.e changes were detected and the object was not updated) to ensure that the object is up to data.

 

[]{#p649} 

 

[]{#related-topics}
:::
