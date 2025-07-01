Imports System
Imports System.Windows.Forms
Imports Syncfusion.ProjIO
Imports System.Diagnostics
Imports System.ComponentModel
Public Class HelloWorld

#Region "Fields"
    Private Const outputFileName As String = "NewProject.xml"
    Private CurrentDirectory As String = String.Empty
#End Region

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        CurrentDirectory = Environment.CurrentDirectory
        ' Create an instance of Project
        Dim project As New Project()

        'creating a new task
        Dim task As New Task("Hello World task")

        'specifying the start date and duration for the task
        task.Start = DateTime.Now
        task.Duration = TimeSpan.FromHours(16)

        'Add the task to the project
        project.RootTask.Children.Add(task)

        'Invoking this method to recalculate IDs of the task present in the project
        project.CalculateTaskIDs()

        ' Save the project
        project.Save(outputFileName)

        'Message box confirmation to view the created project.
        If MessageBox.Show("Do you want to view the Project file?", "Project file has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
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

End Class
