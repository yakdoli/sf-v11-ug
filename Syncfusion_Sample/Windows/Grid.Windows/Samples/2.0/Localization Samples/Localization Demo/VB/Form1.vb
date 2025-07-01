Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms


Partial Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridCtrl As GridControl = Nothing
    Public Sub New()
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
        Syncfusion.Windows.Forms.LocalizationProvider.Provider = New Localizer()
        InitializeComponent()
        InitalizeGrid()
        gridCtrl.InitializeCols()
        gridCtrl.Grid.GridVisualStyles = GridVisualStyles.Metro
        gridCtrl.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro
        gridCtrl.Grid.TableStyle.WrapText = False
        Me.DropShadow = True
        Me.BackColor = Color.White

        'this.ClientSize = new Size(600, 400);
    End Sub

    Private Sub InitalizeGrid()
        Me.SuspendLayout()
        gridCtrl = New GridControl()
        Me.gridCtrl.Grid.Model.EnableLegacyStyle = True
        Me.gridCtrl.Grid.GridVisualStyles = GridVisualStyles.Metro
        gridCtrl.Grid.BackColor = Color.White
        Me.gridCtrl.Grid.ThemesEnabled = True
		Me.gridCtrl.Grid.BorderStyle = BorderStyle.FixedSingle
        'gridCtrl.Grid.Location = new Point(250, 200);
        Me.panel1.Controls.Add(gridCtrl.Grid)
        Me.ResumeLayout(False)
        Me.gridCtrl.Grid.ColStyles(2).CellValueType = GetType(DateTime)
        AddHandler gridCtrl.Grid.CurrentCellValidating, AddressOf Grid_CurrentCellValidating
    End Sub

#Region "Event Handler"
    Private Sub Grid_CurrentCellValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim strError As String = "Please enter valid value"
        Dim numError As String = "Please enter less than 10"
        If checkBox1.Checked Then
            numError = "Bitte geben Sie weniger als 10"
            strError = "Geben Sie einen gültigen Wert"
        End If
        Dim result As Long
        If Me.gridCtrl.Grid.CurrentCell.ColIndex <> 2 Then
            If Long.TryParse(Me.gridCtrl.Grid.CurrentCell.Renderer.ControlText, result) Then
                If result > 10 Then
                    Me.gridCtrl.Grid.CurrentCell.SetError(numError)
                    e.Cancel = True
                End If
            Else
                Me.gridCtrl.Grid.CurrentCell.SetError(strError)
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.gridCtrl.Grid.ShowMessageBoxOnDrop = True
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox1.CheckedChanged
        Dim loc As New Localizer()
        loc.getstring(checkBox1.Checked)
        LocalizationProvider.Provider = loc
    End Sub
#End Region
#Region "Method"
    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function
#End Region
End Class

