Imports Syncfusion.ProjIO
Imports System.ComponentModel

Public Class InsertingTask

#Region "Constants"
    Private Const outputFileName As String = "NewTasks.xml"
	Private CurrentDirectory As String= String.Empty
#End Region

#Region "Events"
    ''' <summary>
    ''' Creates Project with tasks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
	    CurrentDirectory=Environment.CurrentDirectory
        ' Create an instance of Project
        Dim project As New Project()

        'creating a new tasks
        Dim scopeTask As Task = CreateTask("Scope", New DateTime(2011, 12, 5), New DateTime(2011, 12, 19))
        ' TimeSpan.FromHours(80));5
        scopeTask.Duration = New TimeSpan(80, 0, 0)
        'scopeTask.IsSummary = true;
        Dim detProjectScopeTask As Task = CreateTask("Determine project scope", New DateTime(2011, 12, 5), New DateTime(2011, 12, 7))
        ' TimeSpan.FromHours(16));
        Dim secureProjectScopeTask As Task = CreateTask("Secure Project sponsorship", New DateTime(2011, 12, 8), New DateTime(2011, 12, 9))
        'TimeSpan.FromHours(16));
        Dim defPreliminaryTask As Task = CreateTask("Define preliminary resources", New DateTime(2011, 12, 10), New DateTime(2011, 12, 13))
        'TimeSpan.FromHours(16));
        Dim secureCoreResourcesTask As Task = CreateTask("Secure core resources", New DateTime(2011, 12, 14), New DateTime(2011, 12, 15))
        'TimeSpan.FromHours(16));
        Dim secureCompleteTask As Task = CreateTask("Secure Complete", New DateTime(2011, 12, 16), New DateTime(2011, 12, 19))
        'TimeSpan.FromHours(16));
        'Adding the subtasks into the parent task.
        scopeTask.Children.Add(detProjectScopeTask)
        scopeTask.Children.Add(secureProjectScopeTask)
        scopeTask.Children.Add(defPreliminaryTask)
        scopeTask.Children.Add(secureCoreResourcesTask)
        scopeTask.Children.Add(secureCompleteTask)

        'Add the scope task to the project
        project.RootTask.Children.Add(scopeTask)

        'Invoking this method to recalculate IDs of the task present in the project
        project.CalculateTaskIDs()

        ' Create task links
        Dim scopeLink As New TaskLink(detProjectScopeTask, secureProjectScopeTask, TaskLinkType.FinishToStart)
        Dim sponsorLink As New TaskLink(secureProjectScopeTask, defPreliminaryTask, TaskLinkType.FinishToStart)
        Dim preLink As New TaskLink(defPreliminaryTask, secureCoreResourcesTask, TaskLinkType.FinishToStart)
        Dim coreLink As New TaskLink(secureCoreResourcesTask, secureCompleteTask, TaskLinkType.FinishToStart)

        ' Save the project
        project.Save(outputFileName)

        'Message box confirmation to view the created project.
        If MessageBox.Show("Do you want to view the Project file?", "Project file has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
            Try
                Dim startInfo As New ProcessStartInfo("WINPROJ.exe")
                startInfo.Arguments = """" + CurrentDirectory + "\" + outputFileName + """"
                Process.Start(startInfo)

                'Exit
                Me.Close()
            Catch ex As Win32Exception
                MessageBox.Show("MS Project is not installed in this system")
                Console.WriteLine(ex.ToString())
            End Try
        Else
            ' Exit
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' Create a task with the specified properties
    ''' </summary>
    ''' <param name="taskName">The name of the task</param>
    ''' <param name="startTime">The start time of the task</param>
    ''' <param name="finishTime">The duration for the task</param>
    ''' <returns>Returns the created task</returns>
    Private Function CreateTask(ByVal taskName As String, ByVal startTime As DateTime, ByVal finishTime As DateTime) As Task
        'creating a new task
        Dim task As New Task(taskName)
        'specifying the start date and duration for the task
        task.Start = startTime
        task.Finish = finishTime
        task.Duration = New TimeSpan(16, 0, 0)
        Return task
    End Function
#End Region

End Class
