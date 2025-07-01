::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties {#properties style="tab-stops: 0pt"}

Table 5: Project Properties

  Property                                            Description
  --------------------------------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------
  SaveVersion                                         Gets or sets the version of Microsoft Office Project from which the project was saved.
  UID                                                 Gets or set the unique ID of the project.
  Name                                                Gets or sets the name of the project.
  Title                                               Gets or sets the title of the project.
  Subject                                             Gets or sets the subject of the project.
  Category                                            Gets or sets the category of the project.
  Company                                             Gets or sets the company that owns the project.
  Manager                                             Gets or sets the manager of the project.
  Author                                              Gets or sets the author of the project.
  CreationDate                                        Gets or sets the date when the project was created.
  Revision                                            Gets or sets the number of times a project has been saved.
  LastSaved                                           Gets or sets the date the project was last saved.
  ScheduleFromStart                                   True if the project is scheduled from the start date.
  StartDate                                           Gets or sets the start date of the project. Required if ScheduleFromStart is true.
  FinishDate                                          Gets or sets the finish date of the project. Required if ScheduleFromStart is false.
  FYStartDate                                         Gets or sets the Fiscal Year starting month
  CriticalSlackLimit                                  Gets or sets the number of days past its end date that a task can go before Microsoft Project marks that task as a critical task.
  CurrencyDigits                                      Gets or sets the number of digits after the decimal symbol.
  CurrencySymbol                                      Gets or sets the currency symbol used in the project.
  CurrencyCode                                        Gets or sets the three letter currency character code as defined in ISO 4217. Only USD is supported.
  CurrencySymbolPosition                              Gets or sets the position of the currency symbol.
  CalendarUID                                         Gets or sets the project calendar UID.  Refers to a valid UID in the Calendars collection.
  Calendar                                            Gets or sets the project calendar.
  DefaultStartTime                                    Gets or sets the default start time of new tasks.
  DefaultFinishTime                                   Gets or sets the default finish time of new tasks.
  MinutesPerDay                                       Gets or sets the number of minutes per day.
  MinutesPerWeek                                      Gets or sets the number of minutes per week.
  DaysPerMonth                                        Gets or sets the number of days per month.
  DefaultTaskType                                     Gets or sets the default type of new tasks.
  DefaultFixedCostAccrual                             Gets or sets the default from where fixed costs are accrued. 
  DefaultStandardRate                                 Gets or sets the default standard rate for new resources.
  DefaultOvertimeRate                                 Gets or sets the default overtime rate for new resources.
  DurationFormat                                      Gets or sets the format for expressing the bulk duration.
  WorkFormat                                          Gets or sets the default work unit format.
  EditableActualCosts                                 True if actual costs are editable.
  HonorConstraints                                    True if tasks honor their constraint dates.
  EarnedValueMethod                                   Gets or sets the default method for calculating earned value.
  InsertedProjectsLikeSummary                         True if subtasks are calculated as summary tasks.
  MultipleCriticalPaths                               True if multiple critical paths are calculated.
  NewTasksEffortDriven                                True if new tasks are effort driven.
  NewTasksEstimated                                   True to show the estimated duration by default.
  SplitsInProgressTasks                               True if in-progress tasks can be split.
  SpreadActualCost                                    True if actual costs are spread to the status date.
  SpreadPercentComplete                               True if percent complete is spread to the status date.
  TaskUpdatesResource                                 True if updates to tasks, update resources.
  FiscalYearStart                                     True to use fiscal year numbering.
  WeekStartDay                                        Gets or sets the Start day of the week.
  MoveCompletedEndsBack                               True if the end of completed portions of tasks scheduled to begin after the status date but begun early should be moved back to the status date.
  MoveRemainingStartsBack                             True if the beginning of remaining portions of tasks scheduled to begin after the status date but began early, should be moved back to the status date.
  MoveRemainingStartsForward                          True if the beginning of remaining portions of tasks scheduled to begin late should be moved up to the status date.
  MoveCompleteEndsForward                             True if the end of completed portions of tasks scheduled to get completed before the status date but began late should be moved up to the status date.
  BaselineForEarnedValue                              Gets or sets the specific baseline used to calculate Variance values.
  AutoAddNewResourcesAndTasks                         True to automatically add new resources to the resource pool.
  StatusDate                                          Gets or sets the date used for calculation and reporting.
  CurrentDate                                         Gets or sets the system date that the XML was generated.
  MicrosoftProjectServerURL                           True if the project was created by a Project Server user as opposed to an NT user.
  Autolink                                            True to auto link inserted or moved tasks.
  NewTaskStartDate                                    Gets or sets the default date for new tasks start.
  DefaultTaskEVMethod                                 Gets or sets the default earned value method for tasks.
  ProjectExternallyEdited                             True if the project XML was edited.
  ExtendedCreationDate                                Gets or sets date used for calculation and reporting.
  ActualInSync                                        True if all actual work has been synchronized with the project.
  RemoveFileProperties                                True to remove all file properties on save.
  AdminProject                                        True if the project is an administrative project.
  BaselineCalendar                                    Gets or sets the name of the Baseline Calendar.
  NewTasksAreManual                                   True if new tasks should be made in Manual mode.
  UpdateManuallyScheduledTasksWhenEditingLinks        True to update manually scheduled tasks when editing links.
  KeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled   True if tasks moving from Manual to Auto Scheduled should be moved to the nearest working time.
  OutlineCodes                                        Gets or sets the collection of outline code definitions associated with the project.
  WBSMasks                                            Gets or sets the table of entries that define the outline code mask.
  ExtendedAttributes                                  Gets or sets the collection of extended attribute (custom field) definitions associated with the project.
  Calendars                                           Gets or sets the collection of calendars that are associated with the project.
  Tasks                                               Gets or sets the collection of tasks that make up the project.
  Resources                                           Gets or sets the collection of resources that make up the project.
  Assignments                                         Gets or sets the collection of assignments that make up the project.

 

[]{#related-topics}
:::
