::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=32b546e9-9d95-42a6-a35c-9acc3f9939bc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a210ada1-25c4-4966-be29-993b303c7694){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Word Document](ms-xhelp:///?Id=d4b2bc62-8cff-43ca-bbb3-bdd5cc1553de){.d2h_breadcrumbsNormal}
:::

### Track Changes {#track-changes style="tab-stops: 0pt"}

 

Track Changes feature enables you to keep track of the changes made to a document in Microsoft Word. Using this feature, you can maintain a record of every insertion, deletion and modification in the document, including who made the change and when it was made. The objects that carry such information are called \"Tracking Changes\" or \"Revisions\".

 

Revision Tracking is normally meant for use in a shared environment, so you can track how other people may have changed a document for which you are responsible. However, it can also be a valuable tool even if you are the only one using a document, as you can view your own changes in the document.\
\
**Accessing Revisions**

 

You can choose to accept or reject the changes made to a document in Microsoft Word. ParagraphItem and TextBodyItem (WParagraph and WTable are TextBodyItems) objects have the **WordDocument.AcceptChanges** and **WordDocument.RejectChanges** properties, to detect whether an object was inserted or deleted in Microsoft Word (revision tracking being enabled).

 

**WordDocument.HasChanges** specifies whether the document has any revisions (changes). It returns **True**, if the document has atleast one revision.

 

**WordDocument.TrackChanges** property is used to enable revision tracking in Microsoft Word. Note that this setting does not affect the changes made to the document by using DocIO. Also, the changes made to the document by using DocIO, are never tracked as revisions.

*[]{style="COLOR: red"}* 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                |
| [Syncfusion.DocIO.DLS.[WordDocument]{style="COLOR: #2b91af"} doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}([@\"../../Essential DocIO.doc\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Doc);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([WSection]{style="COLOR: #2b91af"} section [in]{style="COLOR: blue"} doc.Sections)]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                |
| [    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} i = 0; i \<= section.Paragraphs.Count - 1; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                                                |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                |
| [        para = section.Paragraphs\[i\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [        [// Check each paragraph items revisions.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                |
| [        [foreach]{style="COLOR: blue"} ([ParagraphItem]{style="COLOR: #2b91af"} item [in]{style="COLOR: blue"} para.Items)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                |
| [            [Console]{style="COLOR: #2b91af"}.WriteLine(item.EntityType.ToString() + [\" Inserted: \"]{style="COLOR: #a31515"} + item.IsInsertRevision.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                                                |
| [            [Console]{style="COLOR: #2b91af"}.WriteLine(item.EntityType.ToString() + [\"Deleted:\"]{style="COLOR: #a31515"} + item.IsDeleteRevision.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                                                |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [// Accept tracking changes of the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                |
| [doc.AcceptChanges();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                |
| [doc.Save([\"sample.doc\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} Syncfusion.DocIO.DLS.WordDocument = [New]{style="COLOR: blue"} WordDocument([\"../../Essential DocIO.doc\"]{style="COLOR: #a31515"}, FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                 |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} section [As]{style="COLOR: blue"} WSection [In]{style="COLOR: blue"} doc.Sections]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                                                 |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} section.Paragraphs.Count - 1]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                                                                 |
| [para = section.Paragraphs(i)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\' Check each paragraph items revisions.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                 |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} item [As]{style="COLOR: blue"} ParagraphItem [In]{style="COLOR: blue"} para.Items]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                                                 |
| [Console.WriteLine((item.EntityType.ToString() & [\" Inserted: \"]{style="COLOR: #a31515"}) + item.IsInsertRevision.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [Console.WriteLine((item.EntityType.ToString() & [\"Deleted:\"]{style="COLOR: #a31515"}) + item.IsDeleteRevision.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                                                 |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                 |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                 |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                 |
| [\' Accept tracking changes of the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                 |
| [doc.AcceptChanges()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                 |
| [doc.Save([\"sample.doc\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
