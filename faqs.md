::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b1223048-ed96-4fbc-8331-9d64002b8f89){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b2ed5382-73e5-4acc-9c73-c48ecaad1300){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::::::::::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}
:::

# FAQs {#faqs style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

Essential Tools is a 100% Native **.NET** UI library that provides several packages for building modern Windows applications using **Microsoft .NET framework**. Our control and framework packages can be used in any .NET environment, including **C#, VB.NET** and **managed C++**. Here are some of the most common questions that may arise, regarding the usage and functionality of Essential Tools-Windows:

 

[·      ]{style="FONT-FAMILY: Symbol"}How to modify the existing source code given by Syncfusion and use the modified code in my application?

 

All the Syncfusion dlls are signed with the Syncfusion\'s private key. Hence, to use a modified source code, the Syncfusion Source code has to be built with your company private key, for all the dependencies.

 

**Example:** For **Tools.Windows**, you will be using the following dll list:

1.   Syncfusion.Core

2.   Syncfusion.Shared.Base

3.   Syncfusion.Grid.Base

4.   Syncfusion.Tools.Base

5.   Syncfusion.Shared.Windows

6.   Syncfusion.Grid.Windows

7.   Syncfusion.Tools.Windows

 

Source of the dlls listed above can be found under the following path:

***\${install_drive}:\\Program Files\\Syncfusion\\Essential Studio\\\${version}***

 

**Modifying AssemblyInfo.cs files**

[]{style="COLOR: #15428b"} 

Make the following modifications to the AssemblyInfo.cs files of each source:

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                              |
|                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                        |
|                                                                                                                                                             |
| [\<i\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                             |
| [\[[assembly]{style="COLOR: blue"}: AssemblyDelaySign([false]{style="COLOR: blue"})\]]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                             |
| [\[[assembly]{style="COLOR: blue"}: AssemblyKeyFile([@\"c:\\keys\\my_company_pri_key.snk\"]{style="COLOR: #a31515"})\]]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                             |
| [\</i\>]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p1207}[]{#p1208}[]{#p1209}[]{#p1210}[]{#p1211}[]{#p1212}[]{#p1213}[]{#p1214}[]{#p1215}[]{#p1216}[]{#p1217}[]{#p1218}[]{#p1219}[]{#p1220}[]{#p1221}[]{#p1222}[]{#p1223}[]{#p1224}[]{#p1225}[]{#p1226}[]{#p1227}[]{#p1228}[]{#p1229}[]{#p1230}[]{#p1231}[]{#p1232}[]{#p1233}[]{#p1234}[]{#p1235}[]{#p1236}[]{#p1237}[]{#p1238}[]{#p1239}[]{#p1240}[]{#p1241}[]{#p1242}[]{#p1243}[]{#p1244}[]{#p1245}[]{#p1246}[]{#p1247}[]{#p1248}[]{#p1249}[]{#p1250}[]{#p1251}[]{#p1252}[]{#p1253}[]{#p1254}[]{#p1255}[]{#p1256}[]{#p1257}[]{#p1258}[]{#p1259}[]{#p1260}[]{#p1261}[]{#p1262}[]{#p1263}[]{#p1264}[]{#p1265}[]{#p1266}[]{#p1267}[]{#p1268}[]{#p1269}[]{#p1270}[]{#p1271}[]{#p1272}[]{#p1273}[]{#p1274}[]{#p1275}[]{#p1276}[]{#p1277}[]{#p1278}[]{#p1279}[]{#p1280}[]{#p1281}[]{#p1282}[]{#p1283}[]{#p1284}[]{#p1285}[]{#p1286}[]{#p1287}[]{#p1288}[]{#p1289}[]{#p1290}[]{#p1291}[]{#p1292}[]{#p1293}[]{#p1294}[]{#p1295}[]{#p1296}[]{#p1297}[]{#p1298}[]{#p1299}[]{#p1300}[]{#p1301}[]{#p1302}[]{#p1303}[]{#p1304}[]{#p1305}[]{#p1306}[]{#p1307}[]{#p1308}[]{#p1309}[]{#p1310}[]{style="COLOR: #15428b"} 

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image76_1.jpg){border="0"}Note:
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 72pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
1\. Source for Syncfusion.Core is not available as it is a licensing dll built with a separate private key. This pre-built dll can be shipped to any machine without  modification, hence building this dll can be ignored. This dll can be used to build other dlls.
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 36pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
             2. All the dlls that to be used in the project should be built using the modifications mentioned above.
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
                           3. The process should be started from Syncfusion.Shared.Base dll and continued in order.
:::

[]{style="COLOR: #15428b"} 

Any of the following two approaches can be used to build the Tools.Windows related Syncfusion assembly references:

[]{style="COLOR: #15428b"} 

Approach 1-Manual Approach

[]{style="COLOR: #15428b"} 

Follow the procedure below to build the assemblies for Tools.Windows dll dependencies:

[]{style="COLOR: #15428b"} 

1.   Open Dashboard \--\> Assembly Management \--\> Run Assembly Manager.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: The Syncfusion Assembly Manager (Version) window is displayed.
:::

[]{style="COLOR: #15428b"} 

2.   Under the **Actions** group box, click **Remove all versions**.

[]{style="COLOR: #15428b"} 

3.   Click Perform Action.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: All the Syncfusion assemblies saved on your system are cleared.
:::

[]{style="COLOR: #15428b"} 

4.   Drag and drop the **Syncfusion.Core** dll to the GAC.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: Syncfusion.Core dll can be used from the current shipping assembly saved under the path-

                            C:\\Program Files\\Syncfusion\\Essential Studio\\7.3.0.20\\precompiledassemblies\\7.3.0.20\\3.5.
:::

[]{style="COLOR: #15428b"} 

[]{style="COLOR: #15428b"} 

Let us take building **Syncfusion.Shared.Base** dll as an example.

[]{style="COLOR: #15428b"} 

5.   Modify the **AssemblyInfo.cs** settings in all the source files. For details, refer **Modifying AssemblyInfo.cs files** topic.

[]{style="COLOR: #15428b"} 

6.   Build the **Syncfusion.Shared.Base** project.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image76_1.jpg){border="0"}Note: Following two projects are available in the project folder:

                           1. \*\_2005.csproj -- Will be useful when used in Visual Studio 2005.

                           2. \*\_2008.csproj -- Will be useful when used in Visual Studio 2008.
:::

[]{style="COLOR: #15428b"} 

7.   Move the **Syncfusion.Shared.Base** dll to a separate location.

[]{style="COLOR: #15428b"} 

8.   Drag and drop the dll in the GAC.

[]{style="COLOR: #15428b"} 

9.   Select the **PublicKeyToken** check box.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: The  public key token should have been changed, based on your company private key.
:::

[]{style="COLOR: #15428b"} 

The Syncfusion.Shared.Base dll is successfully built.

 

Steps 6-9 mentioned above can be repeated to build all the Tools.Windows related Syncfusion assembly references (refer the dll list) required for the project, in order.

 

**Approach 2-Using Build Manager**

 

The dlls can also be built using a Build Manager. This avoids the need to create the dlls one by one. Follow the instructions provided below to build dlls using Build Manager:

[]{style="COLOR: #15428b"} 

1.   Modify the AssemblyInfo.cs settings in all the source files. For details, refer **Modifying AssemblyInfo.cs files** topic.

[]{style="COLOR: #15428b"} 

2.   Open Dashboard \--\> Assembly Management \--\> Run Assembly Manager.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: The Syncfusion Assembly Manager (Version) window is displayed.
:::

[]{style="COLOR: #15428b"} 

3.   Under the **Actions** group box, click **Remove all versions**.

[]{style="COLOR: #15428b"} 

4.   Click Perform Action.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: All the Syncfusion assemblies saved on your system are cleared.
:::

[]{style="COLOR: #15428b"} 

5.   Open Dashboard \--\> Run Build Manager.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image76_1.jpg){border="0"}Note: The Syncfusion Build Manager (Version) window is displayed.
:::

[]{style="COLOR: #15428b"} 

6.   Under the **Framework Version** group box, click the required .NET Framework.

[]{style="COLOR: #15428b"} 

7.   Under the **Product** group box, select the required product from the drop-down list box.

[]{style="COLOR: #15428b"} 

8.   Under the **Assembly Type** group box, click the required assembly type.

[]{style="COLOR: #15428b"} 

9.   Click Perform Build.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: All the required Syncfusion assemblies are built in order.
:::

[]{style="COLOR: #15428b"} 

The set of assemblies built can now be used in your project.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: If the private key setting of any one of the assemblies is modified, the rest of the assemblies (to be used in the project) should be built with the same key.
:::

 

 

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

 

 

 

 

 

 

 

[]{#related-topics}
::::::::::::::::::
