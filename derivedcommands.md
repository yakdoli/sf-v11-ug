::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Derived Commands {#derived-commands style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The Undo / Redo architecture of the Essential Grid is complete as shipped with the product. If, for some reason, you need to handle special grid requirements that cannot be performed with the standard implementation, the Undo / Redo architecture is extensible. To extend it, you need to derive custom command classes from either the abstract class **SyncfusionCommand** or the abstract class **GridModelCommand**. In your derived class, you will need to add whatever members you need in order to track enough state information that will allow you to Undo / Redo the action that is being done. Then you have to implement an execute method and other abstract members of the base class. If you do a search in the Essential Grid source code for GridModelCommand, you will see many examples of the derived command classes.

 

Once you have your derived SyncfusionCommand class, whenever the action is taken, you will have to create a proper instance of your derived SyncfusionCommand class and add it to the **GridControl.CommandStack.UndoStack**. Thus when Essential Grid needs to undo this action, your command will be popped from the **UndoStack**, and its execute method will be called indicating that this action needs to be undone (Also, at this point Essential Grid will add this same instance to the RedoStack so that the action can later be redone if necessary).

 

[]{#p298} 

 

[]{#related-topics}
:::
