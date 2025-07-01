Imports Syncfusion.ProjIO
Imports System.ComponentModel

Public Class InsertingResources

#Region "Constants"
    Private Const outputFileName As String = "NewResources.xml"
    Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\ProjIO\{0}"
	Private CurrentDirectory As String= String.Empty
#End Region

#Region "Events"

    ''' <summary>
    ''' Creates Project with tasks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInsertResources_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertResources.Click
        CurrentDirectory = Environment.CurrentDirectory
        ' Create an instance of Project
        ' Create an instance of the Project
        Dim project As New Project()

        'Get the path of the input file
        Dim inputPath As String = GetFullTemplatePath("NewTasks.xml")
        project = ProjectReader.Open(inputPath)
        'Create Resources
        Dim managerResource As New Resource()
        managerResource.Name = "Product Manager"

        Dim managerResource1 As New Resource()
        managerResource1.Name = "Resource Manager"

        Dim leaderResource As New Resource()
        leaderResource.Name = "Team Leader"

        'Add resources to project
        project.Resources.Add(managerResource)
        project.Resources.Add(managerResource1)
        project.Resources.Add(leaderResource)

        'Invoke method to calculate Resource ID
        project.CalculateResourceIDs()

        'Create Assignments
        Dim scopeAssign As New Assignment()
        scopeAssign.Task = project.GetTaskByUID(2)
        scopeAssign.Resource = managerResource

        Dim sponsorAssign As New Assignment()
        sponsorAssign.Task = project.GetTaskByUID(3)
        sponsorAssign.Resource = managerResource

        Dim taskAssign As New Assignment()
        taskAssign.Task = project.GetTaskByUID(4)
        taskAssign.Resource = managerResource1

        Dim taskAssign1 As New Assignment()
        taskAssign1.Task = project.GetTaskByUID(5)
        taskAssign1.Resource = leaderResource

        Dim taskAssign2 As New Assignment()
        taskAssign2.Task = project.GetTaskByUID(6)
        taskAssign2.Resource = leaderResource

        'Add assignments to project
        project.Assignments.Add(scopeAssign)
        project.Assignments.Add(sponsorAssign)
        project.Assignments.Add(taskAssign)
        project.Assignments.Add(taskAssign1)
        project.Assignments.Add(taskAssign2)

        ' Save the project
        project.Save(outputFileName)

        project = ProjectReader.Open(outputFileName)

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

#End Region

#Region "HelperMethods"
    ''' <summary>
    ''' Get the file path of input file and return the same
    ''' </summary>
    ''' <param name="inputFile">Input file</param>
    ''' <returns>path of the input file</returns>
    Private Function GetFullTemplatePath(ByVal inputFile As String) As String
        Return String.Format(DEFAULTPATH, inputFile)
    End Function
#End Region

End Class
