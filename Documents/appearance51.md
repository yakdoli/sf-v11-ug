::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Appearance

Blendability

The PropertyGrid control can easily be editable in blend. You can edit the template of the PropertyGrid control to give a good look and feel for the control using Expression Blend.

Using Blendability support in an Application

Create the PropertyGrid control using Blend. After creating the PropertyGrid control using Blend, select it and go to "Object" -\> "Edit Style" -\> "Edit a Copy" to edit the Template of the PropertyGrid control.

 

![](../ImagesExt/image261_221.png){border="0"}

Figure 1155: [Blend Open New Project]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}

This will open a dialog (below) where you can give a name of your own style and define exactly where you would like to store it.

![](../ImagesExt/image261_1047.png){border="0"}

Figure 1156: [Creating Style Resource]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}

 

What's produced through the set of steps is quite a bit of XAML which is placed within your application. This XAML represents the default style for the PropertyGrid control.

 

![](../ImagesExt/image261_1048.png){border="0"}

Figure 1157: [Objects and Timeline]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}

Now you can edit each part in the template and create custom look and feel for the control.

 

Background and Foreground support

You can customize the foreground and background of the PropertyGrid using the following properties,

[·      ]{style="FONT-FAMILY: Symbol"}LineColor

[·      ]{style="FONT-FAMILY: Symbol"}ViewBackground

[·      ]{style="FONT-FAMILY: Symbol"}CategoryForeground

Using Background and Foreground support in an Application

Using LineColor, you can set the background for category heading while grouping.Using CategoryForeground, you can set the foreground for category heading.

![](../ImagesExt/image261_1049.png){border="0"}

Figure 1158: PropertyGrid

 

Properties

Table 70: Grouping and SortingTable

  -------------------- ---------------------------------------------------------- -------------------- ----------- -----------------
  Property             Description                                                Type                 Data Type   Reference links
  ViewBackground       Sets the background for the PropertyGrid control.          DependencyProperty   Brush       
  LineColor            Sets the background for category heading while grouping.   DependencyProperty   Brush        
  CategoryForeground   Sets the foreground for category heading.                  DependencyProperty   Brush        
  -------------------- ---------------------------------------------------------- -------------------- ----------- -----------------

 

Sample Link

5.   Select Start -\> Programs -\> Syncfusion -\> Essential Studio x.x.xx -\> Dashboard.

6.   Select   Run Locally Installed Samples in Silverlight Button.

7.   Now expand the PropertyGrid treeview item in the Sample Browser.

8.   Choose any one of the samples listed under it to launch.

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{#related-topics}
:::
