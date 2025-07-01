::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Enhancement of GridDataCommandManager {#enhancement-of-griddatacommandmanager style="tab-stops: 0pt"}

Command is an input mechanism, which provides input handling at a more semantic level.  Commands in WPF are created by implementing the ICommand interface. ICommand exposes two methods, **Execute**, and **CanExecute** and an event **CanExecuteChanged**.

[·      ]{style="FONT-FAMILY: Symbol"}**Execute** performs the actions that are associated with the command

[·      ]{style="FONT-FAMILY: Symbol"}**CanExecute** determines whether the command can execute on the current command target

[·      ]{style="FONT-FAMILY: Symbol"}**CanExecuteChanged** is raised if the command manager that centralizes the commanding operations detects a change in the command source that might invalidate a command that has been raised but not yet executed by the command binding.

GridDataControl provides Commands for the following events. This will help to write the application in pure MVVM model.

[·      ]{style="FONT-FAMILY: Symbol"}QueryCellInfoCommand

[·      ]{style="FONT-FAMILY: Symbol"}SortColumnChangingCommand

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}QueryCellInfoCommand](ms-xhelp:///?Id=23c619f9-345c-436b-a7b5-9994d8431e59){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SortColumnChangingCommand](ms-xhelp:///?Id=32dc660d-7a00-451d-9e2f-5ca9263b7b4a){style="TEXT-DECORATION: none"}
:::
