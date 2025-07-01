::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Foreign Key Reference For Child Table {#foreign-key-reference-for-child-table style="tab-stops: 0pt"}

When you want to create a relation between the child and grandchild table with ForeignKeyReference, set the *RelationKind* property of *GridRelationDescriptor* to *ForeignKeyReference*.

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

The following code illustrates this:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Form1()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| [     {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                            |
| [// To Add relation to ParentTable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                                            |
| [                  [GridRelationDescriptor]{style="COLOR: #2b91af"} parentToChildRelationDescriptor = [new]{style="COLOR: blue"} [GridRelationDescriptor]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                                                                            |
| [                  parentToChildRelationDescriptor.ChildTableName = [\"MyChildTable\"]{style="COLOR: #a31515"};    [// same as SourceListSetEntry.Name for childTable (see below)]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                            |
| [                  parentToChildRelationDescriptor.RelationKind = [RelationKind]{style="COLOR: #2b91af"}.RelatedMasterDetails;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                                            |
| [                  parentToChildRelationDescriptor.RelationKeys.Add([\"parentID\"]{style="COLOR: #a31515"}, [\"ParentID\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                                            |
| [            parentToChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"Name\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                            |
| [            parentToChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"MyGrandChildTable_Name\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                            |
| [                  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| [                  gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                            |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [   ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [// To add Relation to GrandChildTable in Childtable like look up]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                            |
| [            [GridRelationDescriptor]{style="COLOR: #2b91af"} childToGrandChildRelationDescriptor = [new]{style="COLOR: blue"} [GridRelationDescriptor]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                                                                            |
| [                  childToGrandChildRelationDescriptor.ChildTableName = [\"MyGrandChildTable\"]{style="COLOR: #a31515"};  [// same as SourceListSetEntry.Name for grandChhildTable (see below)]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| [                  childToGrandChildRelationDescriptor.RelationKind = [RelationKind]{style="COLOR: #2b91af"}.ForeignKeyReference;]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                            |
| [                  childToGrandChildRelationDescriptor.RelationKeys.Add([\"childID\"]{style="COLOR: #a31515"}, [\"GrandChildID\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                                                            |
| [            childToGrandChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"GrandChildID\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                            |
| [            childToGrandChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"Name\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [    //Add relation to ChildTable]{style="FONT-FAMILY: 'Courier New'; COLOR: #00b050"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [            parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                            |
| [        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                            |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="DISPLAY: none"} 

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} [New]{style="COLOR: blue"}()]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                |
| [            [\' To Add relation to ParentTable]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                |
| [            [Dim]{style="COLOR: blue"} parentToChildRelationDescriptor [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} GridRelationDescriptor()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                |
| [            parentToChildRelationDescriptor.ChildTableName = [\"MyChildTable\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                |
| [            parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                |
| [            parentToChildRelationDescriptor.RelationKeys.Add([\"parentID\"]{style="COLOR: #a31515"}, [\"ParentID\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                |
| [            parentToChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"Name\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                |
| [            parentToChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"MyGrandChildTable_Name\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [            gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [            [\' To add Relation to GrandChildTable in Childtable like look up]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                |
| [            [Dim]{style="COLOR: blue"} childToGrandChildRelationDescriptor [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} GridRelationDescriptor()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [            childToGrandChildRelationDescriptor.ChildTableName = [\"MyGrandChildTable\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                                |
| [            childToGrandChildRelationDescriptor.RelationKind = RelationKind.ForeignKeyReference]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                |
| [            childToGrandChildRelationDescriptor.RelationKeys.Add([\"childID\"]{style="COLOR: #a31515"}, [\"GrandChildID\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                |
| [            childToGrandChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"GrandChildID\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                |
| [            childToGrandChildRelationDescriptor.ChildTableDescriptor.VisibleColumns.Add([\"Name\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [            [\'Add relation to ChildTable]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                |
| [            parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                |
| [        [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
