::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### To set unit property for Segment decorator setting {#to-set-unit-property-for-segment-decorator-setting style="tab-stops: 0pt"}

LineUnit property is used to access the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}**AbsoluteFraction:** the fraction values (double value between 0 to 1) entered are considered from the particular segment's StartPointPosition

[·      ]{style="FONT-FAMILY: Symbol"}**RelativeFraction:**  the fraction values (double value between 0 to 1) entered are considered from the previous DecoratorShape position

[·      ]{style="FONT-FAMILY: Symbol"}**AbsoluteValue:** the pixel values (double) entered are considered from the particular segment's StartPointPosition

[·      ]{style="FONT-FAMILY: Symbol"}**RelativeValue:** the pixel values (double) entered are considered from the previous DecoratorShape position

 

Through XAML

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[LineConnector.SegmentDecoratorSettings]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [   \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SegmentDecoratorSettings]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Unit]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"RelativeFraction\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [      \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SegmentDecoratorSettings.SegmentDecorator]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[CollectionExt]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [          ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SegmentDecorator]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ DecoratorOffset]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"0.2\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DecoratorShape]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Arrow\" /\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [          ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SegmentDecorator]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ DecoratorOffset]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"0.5\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DecoratorShape]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Diamond\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [         ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[CollectionExt]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [      \</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SegmentDecoratorSettings.SegmentDecorator]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [     ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SegmentDecoratorSettings]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[LineConnector.SegmentDecoratorSettings]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

 

 

 

 

 

 

 

 

 

 

 

 

 

 

 

 

Through code behind \[c#\]

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                              |
| [           SegmentDecorator]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ decorator1=[new]{style="COLOR: blue"} [SegmentDecorator]{style="COLOR: #2b91af"} ();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| [            decorator1.DecoratorOffset=0.2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                              |
| [            decorator1.DecoratorShape=Syncfusion.Windows.Diagram.[DecoratorShape]{style="COLOR: #2b91af"}.Arrow;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                              |
| [              [SegmentDecorator]{style="COLOR: #2b91af"} decorator2=[new]{style="COLOR: blue"} [SegmentDecorator]{style="COLOR: #2b91af"} ();]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                              |
| [            decorator2.DecoratorOffset=0.5;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                              |
| [            decorator2.DecoratorShape=Syncfusion.Windows.Diagram.[DecoratorShape]{style="COLOR: #2b91af"}.Diamond;]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                              |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                              |
| [            [CollectionExt]{style="COLOR: #2b91af"} collection=[new]{style="COLOR: blue"} [CollectionExt]{style="COLOR: #2b91af"} ();]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                              |
| [            collection.Add(decorator1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                              |
| [            collection.Add(decorator2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                              |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                              |
| [            [SegmentDecoratorSettings]{style="COLOR: #2b91af"} decoratorsettings = [new]{style="COLOR: blue"} [SegmentDecoratorSettings]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                              |
| [            decoratorsettings.Unit = [LineUnit]{style="COLOR: #2b91af"}.RelativeFraction;]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                              |
| [            decoratorsettings.SegmentDecorator = collection;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                              |
| [            line.SegmentDecoratorSettings = decoratorsettings;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
