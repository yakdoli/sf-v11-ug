#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms

Namespace BindingArrayList
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private components As IContainer
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private WithEvents button1 As ButtonAdv
		Private WithEvents button2 As ButtonAdv
		Private groupBox1 As GroupBox
		Private toolTip1 As ToolTip
		Private dataSource As DataCollection

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			Me.gridGroupingControl1.TableModel.Options.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridGroupingControl1.TableModel.Properties.GridLineColor = System.Drawing.Color.Silver

			Dim rand As New Random()
			Dim r As Integer = rand.Next(100)

			dataSource = New DataCollection()

			For i As Integer = 0 To 5
				dataSource.Add(New Data(r.ToString(), "Category" & r.ToString(), "Desc" & r.ToString()))
				r = rand.Next(100)
			Next i

			Me.gridGroupingControl1.DataSource = dataSource

			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.BackColor = Color.White
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.AllowProportionalColumnSizing = True

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

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(22, 28)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(456, 297)
            Me.gridGroupingControl1.TabIndex = 6
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer)))
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.toolTip1.SetToolTip(Me.gridGroupingControl1, "Implements ListChanged event to make the grid aware if any items are added" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " or r" & _
                    "emoved and thus the grid can update itself automatically when the bound" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "data ch" & _
                    "anges.")
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.VersionInfo = "5.102.0.28"
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(13, 33)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(224, 23)
            Me.button1.TabIndex = 9
            Me.button1.Text = "Add Record to underlying DataSource"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(14, 69)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(224, 23)
            Me.button2.TabIndex = 10
            Me.button2.Text = "Delete Record @ End"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(505, 28)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(254, 117)
            Me.groupBox1.TabIndex = 11
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Add/Update/Remove"
            '
            'toolTip1
            '
            Me.toolTip1.ShowAlways = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(782, 353)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "IBindingList Demo"
            Me.toolTip1.SetToolTip(Me, "Implements ListChanged event to make the grid aware if any items are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "added or r" & _
                    "emoved and thus the grid can update itself automatically when" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the bound data c" & _
                    "hanges.")
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim rand As New Random()
			Dim r As Integer = rand.Next(100)
			dataSource.Add(New Data(r.ToString(), "Category" & r.ToString(), "Desc" & r.ToString()))
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Try
				dataSource.Remove(dataSource(dataSource.Count - 1))
			Catch
				MessageBox.Show("No Records found")
			End Try
		End Sub


	End Class
End Namespace