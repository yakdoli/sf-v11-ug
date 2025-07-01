::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties {#properties style="tab-stops: 0pt"}

Table 8: Task Properties

  Property                      Description
  ----------------------------- ---------------------------------------------------------------------------------------------------------
  UID                           Gets or sets the unique ID of the task.
  ID                            Gets or sets the position identifier of the task within the list of tasks.
  Name                          Gets or sets the name of the task.
  Type                          Gets or sets the type of task.
  IsNull                        True if the task is null
  CreateDate                    Gets or sets the date the task was created.
  Contact                       Gets or sets the contact person for the task.
  WBS                           Gets or sets the work breakdown structure code of the task.
  WBSLevel                      Gets or sets the rightmost WBS level of the task.
  OutlineNumber                 Gets or sets the outline number of the task.
  OutlineLevel                  Gets or sets the outline level of the task.
  Priority                      Gets or sets the priority of the task from 0 to 1000.
  Start                         Gets or sets the scheduled start date of the task
  Finish                        Gets or sets the scheduled finish date of the task.
  Duration                      Gets or sets the planned duration of the task.
  DurationFormat                Gets or sets the format for expressing the Duration of the Task.
  Work                          Gets or sets the amount of scheduled work for the task.
  Stop                          Gets or sets the date that the task was stopped.
  Resume                        Gets or sets the date that the task resumed.
  ResumeValid                   True if the task can be resumed.
  EffortDriven                  True if the task is effort-driven.
  Recurring                     True if the task is a recurring task.
  OverAllocated                 True if the task is overallocated.
  Estimated                     True if the task is estimated.
  Milestone                     True if the task is a milestone.
  Summary                       True if the task is a summary task.
  DisplayAsSummary              True if the task should be displayed as a summary task.
  Critical                      True if the task is in the critical chain.
  IsSubProject                  True if the task is an inserted project.
  IsSubProjectReadOnly          True if the inserted project is read-only.
  SubProjectName                Gets or sets the source location of the inserted project.
  ExternalTask                  True if the task is external.
  ExternalTaskProject           Gets or sets the source location and task identifier of the external task.
  EarlyStart                    Gets or sets the early start date of the task.
  EarlyFinish                   Gets or sets the early finish date of the task.
  LateStart                     Gets or sets the late start date of the task.
  LateFinish                    Gets or sets the late finish date of the task.
  StartVariance                 Gets or sets the variance of the task start date from the baseline start date as minutes x 1000.
  FinishVariance                Gets or sets the variance of the task finish date from the baseline finish date as minutes x 1000.
  WorkVariance                  Gets or sets the variance of task work from the baseline task work as minutes x 1000.
  FreeSlack                     Gets or sets the amount of free slack.
  StartSlack                    Gets or sets the amount of free slack at the start of the task.
  FinishSlack                   Gets or sets the amount of free slack at the end of the task.
  TotalSlack                    Gets or sets the amount of total slack.
  FixedCost                     Gets or sets the fixed cost of the task.
  FixedCostAccrual              Gets or sets how the fixed cost is accrued against the task. Values are: 1=Start, 2=Prorated and 3=End.
  PercentComplete               Gets or sets the percentage of the task duration completed.
  PercentWorkComplete           Gets or sets the percentage of the task work completed.
  Cost                          Gets or sets the projected or scheduled cost of the task.
  OvertimeCost                  Gets or sets the sum of the actual and remaining overtime cost of the task.
  OvertimeWork                  Gets or sets the amount of overtime work scheduled for the task.
  ActualStart                   Gets or sets the actual start date of the task.
  ActualFinish                  Gets or sets the actual finish date of the task.
  ActualDuration                Gets or sets the actual duration of the task.
  ActualCost                    Gets or sets the actual cost of the task.
  ActualOvertimeCost            Gets or sets the actual overtime cost of the task.
  ActualWork                    Gets or sets the actual work for the task.
  ActualOvertimeWork            Gets or sets the actual overtime work for the task.
  RegularWork                   Gets or sets the amount of non-overtime work scheduled for the task.
  RemainingDuration             Gets or sets the amount of time required to complete the unfinished portion of the task.
  RemainingCost                 Gets or sets the remaining projected cost of completing the task.
  RemainingWork                 Gets or sets the remaining work scheduled to complete the task.
  RemainingOvertimeCost         Gets or sets the remaining overtime cost projected to finish the task.
  RemaningOvertimeWork          Gets or sets the remaining overtime work scheduled to finish the task.
  ACWP                          Gets or sets the actual cost of work performed on the task to-date.
  CV                            Gets or sets the earned value cost variance.
  ConstraintType                Gets or sets the constraint on the start or finish date of the task.
  CalendarUID                   Gets or sets the task calendar. Refers to a valid UID in the Calendars collection.
  ConstraintDate                Gets or sets the date argument for the task constraint type.
  Deadline                      Gets or sets the deadline for the task to be completed.
  LevelAssignments              True if leveling can adjust assignments.
  LevelingCanSplit              True if leveling can split the task.
  LevelingDelay                 Gets or sets the delay caused by leveling the task.
  LevelingDelayFormat           Gets or sets the format for expressing the duration of the delay.
  PreLevelStart                 Gets or sets the start date of the task before it was leveled.
  PreLevelFinish                Gets or sets the finish date of the task before it was leveled.
  Hyperlink                     Gets or sets the title of the hyperlink associated with the task.
  HyperlinkAddress              Gets or sets the hyperlink associated with the task.
  HyperlinkSubAddress           Gets or sets the document bookmark of the hyperlink associated with the task.
  IgnoreResourceCalendar        True if the task ignores the resource calendar.
  Notes                         Gets or sets the text notes associated with the task.
  HideBar                       True if the GANTT bar of the task is hidden when displayed in Microsoft Project.
  Rollup                        True if the task is rolled up.
  BCWS                          Gets or sets the budgeted cost of work scheduled for the task.
  BCWP                          Gets or sets the budgeted cost of work performed on the task to-date.
  PhysicalPercentComplete       Gets or sets the percentage complete value entered by the Project Manager.
  EarnedValueMethod             Gets or sets the method for calculating earned value.
  PredecessorLink               Gets or sets the predecessor task of the task that contains it.
  ActualWorkProtected           Gets or sets the duration through which actual work is protected.
  ActualOvertimeWorkProtected   Gets or sets the duration through which actual overtime work is protected.
  ExtendedAttribute             Gets or sets the value of an extended attribute.
  Baseline                      Gets or sets the collection of baseline values of the task.
  OutlineCode                   Gets or sets the value of an outline code.
  IsPublished                   True if the task is published.
  StatusManager                 Gets or sets the name of the task status manager.
  CommitmentStart               Gets or sets the start date of the deliverable.
  CommitmentFinish              Gets or sets the finish date of the deliverable.
  CommitmentType                Gets or sets the commitment type of the deliverable.
  Active                        True if the task is active.
  Pinned                        True if the task is in manually scheduled mode.
  PinnedStart                   Gets or sets text displayed in start field when the task is in Manually Scheduled mode.
  PinnedFinish                  Gets or sets text displayed in finish field when the task is in Manually Scheduled mode.
  PinnedDuration                Gets or sets text displayed in duration field when the task is in Manually Scheduled mode.
  TimePhasedData                Gets or sets the time phased data block associated with the task.

[]{#related-topics}
:::
