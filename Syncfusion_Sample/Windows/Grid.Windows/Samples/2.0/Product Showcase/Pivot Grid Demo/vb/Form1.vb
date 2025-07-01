Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace PrivotGridSample
    Partial Public Class Form1
        Inherits MetroForm
        Public Sub New()
            InitializeComponent()
            Me.menuStrip1.BackColor = Color.Black

            pivotGridControl1.DefaultComputationName = "Average"
            pivotGridControl1.DataSource = GetDataTable()
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
            Me.menuStrip1.BackColor = Color.WhiteSmoke
            Me.menuStrip1.ForeColor = Color.Black
        End Sub
        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function
        Protected Overrides Sub OnClosed(ByVal e As EventArgs)
            pivotGridControl1.Dispose()
            pivotGridControl1 = Nothing

            MyBase.OnClosed(e)
        End Sub
        Private Function GetDataTable() As DataTable
            '			#Region "Get the DataSource"
            Dim dt As DataTable = New DataTable("MyTable")

            Dim nRows As Integer = 2000
            Dim r As Random = New Random(123345345)

            dt.Columns.Add(New DataColumn("City", GetType(String)))
            dt.Columns.Add(New DataColumn("Sex", GetType(String)))
            Dim sexes As String() = New String() {"Male", "Female"}
            dt.Columns.Add(New DataColumn("Age", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Profession", GetType(String)))
            Dim jobs As String() = New String() {"nurse", "teacher", "engineer", "tailor", "salesperson", "programmer", "gardener", "cook", "surgeon"}
            dt.Columns.Add(New DataColumn("Salary", GetType(Double)))
            dt.Columns.Add(New DataColumn("State", GetType(String)))
            Dim states As String() = New String() {"NC", "SC", "GA", "VA"}
            Dim NCcities As String() = New String() {"Raleigh", "Charlotte", "Wilmington", "Ashville"}
            Dim GAcities As String() = New String() {"Augusta", "Albany", "Atlanta"}
            Dim VAcities As String() = New String() {"Norfolk", "Richmond"}
            Dim SCcities As String() = New String() {"Clemson", "Myrtle Beach", "Charleston"}
            dt.Columns.Add(New DataColumn("Married", GetType(Boolean)))
            dt.Columns.Add(New DataColumn("Children", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Siblings", GetType(Integer)))
            dt.Columns.Add(New DataColumn("CC Debt", GetType(Double)))


            For i As Integer = 0 To nRows - 1
                Dim dr As DataRow = dt.NewRow()
                '  dr["City"] = cities[r.Next(cities.GetLength(0))];
                dr("Sex") = sexes(r.Next(sexes.GetLength(0)))
                dr("Age") = r.Next(45) + 20
                dr("Profession") = jobs(r.Next(jobs.GetLength(0)))
                dr("Salary") = 15000.0R + CInt(Fix(r.NextDouble() * 100000))
                dr("State") = states(r.Next(states.GetLength(0)))
                Dim k As Integer = "NCSCVAGA".IndexOf(dr("State").ToString())
                Select Case k
                    Case 0
                        dr("City") = NCcities(r.Next(NCcities.GetLength(0)))
                    Case 2
                        dr("City") = SCcities(r.Next(SCcities.GetLength(0)))
                    Case 6
                        dr("City") = GAcities(r.Next(GAcities.GetLength(0)))
                    Case 4
                        dr("City") = VAcities(r.Next(VAcities.GetLength(0)))
                End Select
                dr("Married") = r.Next(3) = 1
                If CBool(dr("Married")) Then
                    dr("Children") = r.Next(6)
                Else
                    dr("Children") = 0
                End If
                dr("Siblings") = r.Next(7)
                dr("CC Debt") = (CInt(Fix(r.NextDouble() * 2000000))) / 100.0R
                dt.Rows.Add(dr)
            Next i
            '			#End Region

            Return dt
        End Function


#Region "menu handlers"
        Private Function GetFile(ByVal fileName As String) As String
            Dim dataFileName As String = "Common\Data\PivotGrid\" & fileName
            For n As Integer = 0 To 11
                If System.IO.File.Exists(dataFileName) Then
                    Return New FileInfo(dataFileName).FullName
                End If
                dataFileName = "..\" & dataFileName
            Next n
            Return dataFileName
        End Function
#Region "Load Schema"

        Private Sub loadSchemaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadSchemaToolStripMenuItem.Click
            'load schema
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Open Pivot Table Schema file"
            dlg.InitialDirectory = GetFile("default.schema.xml")
            'Environment.CurrentDirectory
            dlg.Filter = "Pivot Table Schema files (*.schema.xml)|*.schema.xml|All files (*.*)|*.*"

            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Application.DoEvents() ' let the dialog close before loading schema
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim schema As PivotGridLibrary.PivotSchema = PivotGridLibrary.PivotSchema.LoadXML(dlg.FileName)
                    pivotGridControl1.ApplySchema(schema)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

#End Region

#Region "Save Schema"

        Private Sub saveSchemaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveSchemaToolStripMenuItem.Click
            'save schema
            Dim saveFile As SaveFileDialog = New SaveFileDialog()
            saveFile.DefaultExt = "*.schema.xml"
            saveFile.Filter = "Pivot Table Schema files (*.schema.xml)|*.schema.xml|All files (*.*)|*.*"

            ' get a file name from the user
            If saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    Dim schema As PivotGridLibrary.PivotSchema = pivotGridControl1.InitSchema()
                    schema.SaveXML(saveFile.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End Sub

#End Region

#Region "Reset Schema"

        Private Sub resetSchemaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles resetSchemaToolStripMenuItem.Click
            'reset schema
            pivotGridControl1.ResetSchema()
        End Sub

#End Region

#Region "Show Data"

        Private Sub displayDataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles displayDataToolStripMenuItem.Click
            'display data - just shows the underlying flat list in a DataGridView...
            Dim f As Form2 = New Form2()
            f.dataGridView1.DataSource = pivotGridControl1.DataSource
            f.Show()
        End Sub

#End Region

#Region "Exit"

        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
            Me.Close()
        End Sub
#End Region

#Region "Change Appearance"
        Private propertyForm As PropertyGridForm = Nothing

        Private Sub changeAppearanceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles changeAppearanceToolStripMenuItem.Click
            'change appearance
            If propertyForm Is Nothing Then
                propertyForm = New PropertyGridForm()
                AddHandler propertyForm.Closing, AddressOf propertyForm_Closing
                propertyForm.AppearancePropertyGrid1.SelectedObject = pivotGridControl1.GetAppearance()
                AddHandler propertyForm.AppearancePropertyGrid1.PropertyValueChanged, AddressOf AppearancePropertyGrid1_PropertyValueChanged
            End If
            If (Not propertyForm.Visible) Then
                propertyForm.Show()
            End If
        End Sub
        Private Sub propertyForm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            propertyForm.Hide()
            e.Cancel = True
        End Sub
        Private Sub AppearancePropertyGrid1_PropertyValueChanged(ByVal s As Object, ByVal e As PropertyValueChangedEventArgs)
            Me.pivotGridControl1.UpdateValues()
        End Sub
#End Region

#Region "Load Appearance"

        Private Sub loadAppearanceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadAppearanceToolStripMenuItem.Click
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Open Pivot Table Appearance file"
            dlg.InitialDirectory = GetFile("default.appearance.XML")
            'Environment.CurrentDirectory
            dlg.Filter = "Pivot Table Appearance files (*.appearance.xml)|*.appearance.xml|All files (*.*)|*.*"

            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Application.DoEvents() ' let the dialog close before loading schema
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim appearance As PivotGridLibrary.PivotAppearance = PivotGridLibrary.PivotAppearance.LoadXML(dlg.FileName)
                    pivotGridControl1.SetAppearance(appearance)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

#End Region

#Region "Save Appearance"

        Private Sub saveAppearanceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveAppearanceToolStripMenuItem.Click
            'save appearance
            Dim saveFile As SaveFileDialog = New SaveFileDialog()
            saveFile.DefaultExt = "*.appearance.xml"
            saveFile.Filter = "Pivot Table Appearance files (*.appearance.xml)|*.appearance.xml|All files (*.*)|*.*"

            ' get a file name from the user
            If saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    pivotGridControl1.GetAppearance().SaveXML(saveFile.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End Sub

#End Region

#Region "Expand All / Collapse All"

        Private Sub expandAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles expandAllToolStripMenuItem.Click
            'expandall
            pivotGridControl1.ExpandAll()
        End Sub

        Private Sub collapseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles collapseAllToolStripMenuItem.Click
            'collapse all
            pivotGridControl1.CollapseAll()
        End Sub

#End Region

#Region "Refresh display"

        Private Sub refreshCalculationsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshCalculationsToolStripMenuItem.Click

            'refresh calculations...
            Dim start As DateTime = DateTime.Now

            pivotGridControl1.UpdateValues()
            Me.Text = String.Format("Update time: {0:0.0000} secs     {1} rows x {2} cols", (CType(DateTime.Now.Subtract(start), TimeSpan)).TotalSeconds, pivotGridControl1.MainDisplayGrid.RowCount, pivotGridControl1.MainDisplayGrid.ColCount)

        End Sub
#End Region

#Region "Show All Colors"

        Private Sub showAllColorsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showAllColorsToolStripMenuItem.Click
            'show all colors - just for illustration to allow you to see what Appearance property affects what part of the pivotCOntrol1.MainDisplayGrid.
            Dim appearance As PivotGridLibrary.PivotAppearance = pivotGridControl1.GetAppearance()
            appearance.RowTotalCell.BackColor = Color.Gold
            appearance.RowExpandCell.BackColor = Color.Blue
            appearance.ColumnExpandCell.BackColor = Color.Red
            appearance.RowCell.BackColor = Color.Pink
            appearance.ValueCell.BackColor = Color.LemonChiffon
            appearance.ColumnTotalCell.BackColor = Color.IndianRed
            appearance.ColumnCell.BackColor = Color.LawnGreen
            appearance.CalculationNameCell.BackColor = Color.Yellow
            appearance.TopLeftCell.BackColor = Color.Turquoise

            pivotGridControl1.UpdateValues() 'forces a refresh to display new appearance
        End Sub
#End Region

#End Region


    End Class
End Namespace