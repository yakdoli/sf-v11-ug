::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Programmatically {#programmatically style="tab-stops: 0pt"}

Apply Theme for Ribbon

The following code illustrates how to apply the Office2010 theme to the ribbon:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                                                                                                         |
|                                                                                                                                                                                                |
| [            [this]{style="COLOR: blue"}.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.[RibbonStyle]{style="COLOR: #2b91af"}.Office2010;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[VB\]                                                                                                                                                                            |
|                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

Creating BackStageView

[]{style="COLOR: black"} 

The following code illustrates how to create a backstage with a *BackStageButtom* and a *BackStageTab*:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [                using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [                [BackStageView]{style="COLOR: #2b91af"} backStageView1 = [new]{style="COLOR: blue"} [BackStageView]{style="COLOR: #2b91af"}([this]{style="COLOR: blue"}.components);]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                                    |
| [                [BackStage]{style="COLOR: #2b91af"} backStage1 = [new]{style="COLOR: blue"} [BackStage]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                    |
| [                [BackStageTab]{style="COLOR: #2b91af"} backStageTab1 = [new]{style="COLOR: blue"} [BackStageTab]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                                    |
| [                [BackStageButton]{style="COLOR: #2b91af"} backStageButton1 = [new]{style="COLOR: blue"} [BackStageButton]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                                    |
| [      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| [                  [// backStageView1]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                    |
| [                backStageView1.BackStage = backStage1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| [                backStageView1.HostControl = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                                    |
| [                backStageView1.HostForm = [this]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| [                 ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                    |
| [                  [// backStage1]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                    |
| [                backStage1.Controls.Add(backStageTab1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                    |
| [                backStage1.Controls.Add(backStageButton1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| [                backStage1.Dock = System.Windows.Forms.[DockStyle]{style="COLOR: #2b91af"}.Fill;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| [                  [// backStageTab1]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| [                backStageTab1.Text = [\"backStageTab1\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                                    |
| [               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                    |
| [                  [// backStageButton1]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                                    |
| [                backStageButton1.Text = [\"backStageButton1\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [                [// ribbonControlAdv1]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                    |
| [                  ribbonControlAdv1.BackStageView = backStageView1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                    |
| [                 ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                    |
| [                  [//Add BackStage to RibbonControlAdv ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                    |
| [                  ribbonControlAdv1.BackStageView =backStageView1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                    |
| [      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                    |
| [                 [//Add BackStage and RibbonControlAdv to form]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                    |
| [                  [this]{style="COLOR: blue"}.Controls.Add(backStage1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                    |
| [                  [this]{style="COLOR: blue"}.Controls.Add([this]{style="COLOR: blue"}.ribbonControlAdv1);]{style="FONT-FAMILY: 'Courier New'"}[        ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[VB\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                  |
| [                    Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        [Dim]{style="COLOR: blue"} backStageView1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} BackStageView([Me]{style="COLOR: blue"}.components)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| [                        [Dim]{style="COLOR: blue"} backStage1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} BackStage()]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                                  |
| [                        [Dim]{style="COLOR: blue"} backStageTab1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} BackStageTab()]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                  |
| [                        [Dim]{style="COLOR: blue"} backStageButton1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} BackStageButton()]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        \' backStageView1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                  |
| [                        backStageView1.BackStage = backStage1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                  |
| [                        backStageView1.HostControl = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                  |
| [                        backStageView1.HostForm = [Me]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        \' backStage1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                  |
| [                        backStage1.Controls.Add(backStageTab1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                  |
| [                        backStage1.Controls.Add(backStageButton1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                  |
| [                        backStage1.Dock = System.Windows.Forms.DockStyle.Fill]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        \' backStageTab1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                  |
| [                        backStageTab1.Text = [\"backStageTab1\"]{style="COLOR: darkred"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        \' backStageButton1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                  |
| [                        backStageButton1.Text = [\"backStageButton1\"]{style="COLOR: darkred"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        \' ribbonControlAdv1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                  |
| [                        ribbonControlAdv1.BackStageView = backStageView1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                        \'Add BackStage to RibbonControlAdv ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                  |
| [                        ribbonControlAdv1.BackStageView =backStageView1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [                     \'Add BackStage and RibbonControlAdv to form]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                  |
| [                        [Me]{style="COLOR: blue"}.Controls.Add(backStage1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                  |
| [                              [Me]{style="COLOR: blue"}.Controls.Add([Me]{style="COLOR: blue"}.ribbonControlAdv1)]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

**[Refer to:]{style="COLOR: black"}**

[]{style="COLOR: black"} 

Appearance Setting[]{style="COLOR: black"}

[]{style="COLOR: black"} 

 

 

[]{#related-topics}
:::
