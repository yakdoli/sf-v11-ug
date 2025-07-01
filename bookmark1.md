::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Bookmark {#bookmark style="tab-stops: 0pt"}

 

While loading an existing document, the library loads all bookmarks of the document. Each loaded bookmark is represented by the **PdfLoadedBookmark** class, inherited from the **PdfBookmark** class. You can access the root collection of document bookmarks by using the **Bookmark** property of the **PdfLoadedDocument** class. This collection is represented by the **PdfBookmarkBase** class.

 

The following code example illustrates how to access a loaded bookmark.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                               |
|                                                                                                                                                                                                   |
| [const]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"} filename = [\"\...\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                   |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfBookmarkBase rootCollection = ldDoc.Bookmarks;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfLoadedBookmark bookmark = rootCollection\[0\] [as]{style="COLOR: blue"} PdfLoadedBookmark;]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [ldDoc.Save(newFileName);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                   |
| [ldDoc.Close();  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                             |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                          |
|                                                                                                                                                                              |
| [const]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"} filename = [\"\...\"]{style="COLOR: maroon"};  ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                              |
| [PdfLoadedDocument ldDoc = [new]{style="COLOR: blue"} PdfLoadedDocument(filename); ]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [PdfBookmarkBase rootCollection = ldDoc.Bookmarks; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [PdfLoadedBookmark bookmark = rootCollection\[ 0 \] [as]{style="COLOR: blue"} PdfLoadedBookmark; ]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [ldDoc.Save( newFileName ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                              |
| [ldDoc.Close();  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Bookmark Manipulation

 

The following manipulations can be made to the bookmarks:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Modifying bookmarks

[·      ]{style="FONT-FAMILY: Symbol"}Adding Actions to the bookmark

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1\. Modifying bookmarks

 

Bookmarks can be modified in the following ways:

 

[·      ]{style="FONT-FAMILY: Symbol"}Change the bookmark style, color, title and destination

[·      ]{style="FONT-FAMILY: Symbol"}Add or insert new bookmarks into the root collection

[·      ]{style="FONT-FAMILY: Symbol"}Add or insert new bookmarks as a child of another bookmark

[·      ]{style="FONT-FAMILY: Symbol"}Assign the destination of the added bookmarks to a loaded page or a new page of the document

 

The following code example illustrates how to modify the bookmark style and destination.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                              |
|                                                                                                                                                                                                   |
| [const]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"} filename = [\"\...\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                   |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [bookmarPdfLoadedPage ldPage = loadedDoc.Pages\[1\] [as]{style="COLOR: blue"} [PdfLoadedPage]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfBookmarkBase rootCollection = ldDoc.Bookmarks;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfLoadedBookmark bookmark = rootCollection\[0\] [as]{style="COLOR: blue"} PdfLoadedBookmark;]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                   |
| [bookmark.Destination = [new]{style="COLOR: blue"} PdfDestination(ldPage);]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                   |
| [bookmark.Color = [Color]{style="COLOR: teal"}.Green;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                   |
| [bookmark.TextStyle = PdfTextStyle.Bold;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                   |
| [bookmark.Title = [\"Changed title\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                               |
|                                                                                                                                                                                                   |
| [ldDoc.Save(newFileName);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                   |
| [ldDoc.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                                         |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                     |
|                                                                                                                                                                                                                          |
| [Const]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ filename [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"\...\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedDocument(filename)]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldPage [As]{style="COLOR: blue"} bookmarPdfLoadedPage = [TryCast]{style="COLOR: blue"}(loadedDoc.Pages(1), PdfLoadedPage)]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rootCollection [As]{style="COLOR: blue"} PdfBookmarkBase = ldDoc.Bookmarks]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bookmark [As]{style="COLOR: blue"} PdfLoadedBookmark = [TryCast]{style="COLOR: blue"}(rootCollection(0), PdfLoadedBookmark)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                          |
| [bookmark.Destination = [New]{style="COLOR: blue"} PdfDestination(ldPage) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                          |
| [bookmark.Color = Color.Green ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                          |
| [bookmark.TextStyle = PdfTextStyle.Bold ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                          |
| [bookmark.Title = [\"Changed title\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [Const]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ newFileName [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"\...\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                          |
| [ldDoc.Save(newFileName) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                          |
| [ldDoc.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2\. Adding Actions to Bookmark

 

You can perform actions by clicking the bookmarks at run time. To add custom actions to the bookmarks use the following classes.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------------- -----------------------------------------------------------------------------------------------
  Class Name            Description
  PdfLaunchAction       Launches an application, opens or prints a document.
  PdfUriAction          Acts as a unique resource identifier.
  PdfJavaScriptAction   Performs a javascript action in the PDF document.
  PdfDestination        Represents an anchor in the document where bookmarks and annotations can direct when clicked.
  PdfGoToAction         This action goes to a destination in the current document.
  --------------------- -----------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [//Create new Bookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                        |
| [PdfBookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ bookmarkaction = doc.Bookmarks.Add([\"Annotations\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| [PdfLaunchAction]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ action = [new]{style="COLOR: blue"} [PdfLaunchAction]{style="COLOR: #2b91af"}([@\"..\\..\\Data\\Book.txt\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [//launch file when we click the Bookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                        |
| [bookmarkaction.Action = action;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| [PdfBookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ bookmarkaction1 = doc.Bookmarks.Add([\"Uriaction\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [//Create uri action]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                        |
| [PdfUriAction]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ uriAction = [new]{style="COLOR: blue"} [PdfUriAction]{style="COLOR: #2b91af"}([\"http://www.google.com\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [//Set uri action. Clicking the bookmark will move to the corresponding uri]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                        |
| [bookmarkaction1.Action = uriAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| [PdfBookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ bookmarkaction2 = doc.Bookmarks.Add([\"Scriptaction\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [//Create Java action]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                        |
| [PdfJavaScriptAction]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ javaAction = [new]{style="COLOR: blue"} [PdfJavaScriptAction]{style="COLOR: #2b91af"}([\"app.alert(\\\"You are looking at Java script action of PDF \\\")\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                        |
| [bookmarkaction2.Action = javaAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| [PdfBookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ bookmarkaction3 = doc.Bookmarks.Add([\"Pagelocation\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                                                                        |
| [PdfDestination]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dest = [new]{style="COLOR: blue"} [PdfDestination]{style="COLOR: #2b91af"}(doc.Pages\[1\], [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(0, 100));]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                                                                                        |
| [PdfGoToAction]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ goToAction = [new]{style="COLOR: blue"} [PdfGoToAction]{style="COLOR: #2b91af"}(doc.Pages\[1\]);]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                                                                        |
| [goToAction.Destination = dest;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                        |
| [// Will move to a particular location of this page]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| [bookmarkaction3.Action = goToAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[VB.NET[\]]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\'Create new Bookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bookmarkaction [As]{style="COLOR: blue"} PdfBookmark = doc.Bookmarks.Add([\"Annotations\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ action [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLaunchAction([\"..\\..\\Data\\Book.txt\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\'launch file when we click the Bookmark]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                 |
| [bookmarkaction.Action = action]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bookmarkaction1 [As]{style="COLOR: blue"} PdfBookmark = doc.Bookmarks.Add([\"Uriaction\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\'Create url action]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uriAction [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfUriAction([\"http://www.google.com\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\'Set uri action. Clicking the bookmark will move to the corresponding uri]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                 |
| [bookmarkaction1.Action = uriAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bookmarkaction2 [As]{style="COLOR: blue"} PdfBookmark = doc.Bookmarks.Add([\"Scriptaction\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\'Create Java action]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ javaAction [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfJavaScriptAction([\"app.alert(\"\"You are looking at Java script action of PDF \"\")\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                 |
| [bookmarkaction2.Action = javaAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bookmarkaction3 [As]{style="COLOR: blue"} PdfBookmark = doc.Bookmarks.Add([\"Pagelocation\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dest [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfDestination(doc.Pages(1), [New]{style="COLOR: blue"} Point(0, 100))]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ goToAction [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfGoToAction(doc.Pages(1))]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| [goToAction.Destination = dest]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [\' Will move to this page particular location]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                 |
| [bookmarkaction3.Action = goToAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image22_67.jpg){border="0"}

Figure 56: JavaScript alert message displayed using bookmark action

 

 

 

[]{#related-topics}
::::
