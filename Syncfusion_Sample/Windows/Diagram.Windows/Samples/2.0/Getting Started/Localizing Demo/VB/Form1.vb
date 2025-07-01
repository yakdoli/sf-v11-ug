Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing.Printing
Imports System.Threading
Imports System.Diagnostics
Imports DemoCommon.Diagram

Namespace LocalizingDialogs
	Public Class Form1
		Inherits DemoForm
		#Region "Memberrs"

		Private WithEvents PageSetup As Button
		Private WithEvents PageBorder As Button
		Private panel2 As Expander
		Private WithEvents HeaderFooter As Button
		Private panel1 As TitlePanel
		Private panel3 As Panel
		Private diagram1 As Diagram
		Private model1 As Model
		Private components As System.ComponentModel.IContainer = Nothing

		#End Region

		#Region "Form Initialize"

		Public Sub New()
			InitializeComponent()

			'Code to fetch the German resources at run time.
			Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("de-DE")

			'Load a diagram.
			diagram1.LoadBinary("..\..\Data\SimpleDiagram.edd")
				diagram1.Model.BackgroundStyle.Color = Color.White
			For Each node As Node In diagram1.Model.Nodes
				node.EditStyle.AllowSelect = False
			Next node
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.PageSetup = New System.Windows.Forms.Button()
			Me.PageBorder = New System.Windows.Forms.Button()
			Me.panel2 = New DemoCommon.Diagram.Expander()
			Me.HeaderFooter = New System.Windows.Forms.Button()
			Me.panel1 = New DemoCommon.Diagram.TitlePanel()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel2.SuspendLayout()
			Me.panel3.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' PageSetup
			' 
			Me.PageSetup.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.PageSetup.FlatAppearance.BorderSize = 0
			Me.PageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.PageSetup.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PageSetup.ForeColor = System.Drawing.Color.White
			Me.PageSetup.Location = New System.Drawing.Point(13, 143)
			Me.PageSetup.Name = "PageSetup"
			Me.PageSetup.Size = New System.Drawing.Size(153, 25)
			Me.PageSetup.TabIndex = 36
			Me.PageSetup.Text = "PageSetup Dialog"
			Me.PageSetup.UseVisualStyleBackColor = False
'			Me.PageSetup.Click += New System.EventHandler(Me.PageSetup_Click)
			' 
			' PageBorder
			' 
			Me.PageBorder.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.PageBorder.FlatAppearance.BorderSize = 0
			Me.PageBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.PageBorder.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.PageBorder.ForeColor = System.Drawing.Color.White
			Me.PageBorder.Location = New System.Drawing.Point(13, 97)
			Me.PageBorder.Name = "PageBorder"
			Me.PageBorder.Size = New System.Drawing.Size(153, 25)
			Me.PageBorder.TabIndex = 35
			Me.PageBorder.Text = "PageBorder Dialog"
			Me.PageBorder.UseVisualStyleBackColor = False
'			Me.PageBorder.Click += New System.EventHandler(Me.PageBorder_Click)
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.panel2.Caption = "Dialogs"
			Me.panel2.Controls.Add(Me.PageSetup)
			Me.panel2.Controls.Add(Me.PageBorder)
			Me.panel2.Controls.Add(Me.HeaderFooter)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(553, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(10)
			Me.panel2.Size = New System.Drawing.Size(200, 386)
			Me.panel2.TabIndex = 4
			' 
			' HeaderFooter
			' 
			Me.HeaderFooter.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.HeaderFooter.FlatAppearance.BorderSize = 0
			Me.HeaderFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.HeaderFooter.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.HeaderFooter.ForeColor = System.Drawing.Color.White
			Me.HeaderFooter.Location = New System.Drawing.Point(13, 50)
			Me.HeaderFooter.Name = "HeaderFooter"
			Me.HeaderFooter.Size = New System.Drawing.Size(153, 25)
			Me.HeaderFooter.TabIndex = 34
			Me.HeaderFooter.Text = "HeaderFooter Dialog"
			Me.HeaderFooter.UseVisualStyleBackColor = False
'			Me.HeaderFooter.Click += New System.EventHandler(Me.HeaderFooter_Click)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel1.ControlBox = False
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Form = Me
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(751, 70)
			Me.panel1.TabIndex = 7
			Me.panel1.TitleText = "Localization Demo"
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.diagram1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(2, 72)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(551, 386)
			Me.panel3.TabIndex = 8
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.HScroll = True
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(551, 386)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.VScroll = True
			' 
			' model1
			' 
			Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model1.DocumentScale.DisplayName = "No Scale"
			Me.model1.DocumentScale.Height = 1F
			Me.model1.DocumentScale.Width = 1F
			Me.model1.DocumentSize.Height = 1169F
			Me.model1.DocumentSize.Width = 827F
			Me.model1.LineStyle.DashPattern = Nothing
			Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model1.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(755, 460)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Localization Demo"
			Me.panel2.ResumeLayout(False)
			Me.panel3.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Dim targetPath As String = Application.StartupPath & "\" & "de-DE"
			Dim sourceFile As String = System.IO.Path.GetFullPath("..\..\de-DE\Syncfusion.Diagram.Windows.resources.dll")
			If Not System.IO.Directory.Exists(targetPath) Then
				System.IO.Directory.CreateDirectory(targetPath)
				System.IO.File.Copy(sourceFile, targetPath & "\Syncfusion.Diagram.Windows.resources.dll")
			End If
			Dim pstart As New ProcessStartInfo("..\..\Data\run.bat")
			pstart.UseShellExecute = False
			'Hide DOS window
			pstart.CreateNoWindow = True
			Process.Start(pstart)

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "Class Events"
		Private Sub HeaderFooter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HeaderFooter.Click
			Dim dlgHF As New HeaderFooterDialog()
			dlgHF.Header = diagram1.Model.HeaderFooterData.Header
			dlgHF.Footer = diagram1.Model.HeaderFooterData.Footer
			dlgHF.MeasurementUnits = diagram1.Model.MeasurementUnits
			If dlgHF.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				diagram1.Model.HeaderFooterData.Header = dlgHF.Header
				diagram1.Model.HeaderFooterData.Footer = dlgHF.Footer
			End If
		End Sub

		Private Sub PageBorder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PageBorder.Click
			Dim borderDialog As New PageBorderDialog()
			borderDialog.PageBorderStyle = diagram1.View.PageBorderStyle
			If borderDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				diagram1.View.PageBorderStyle = borderDialog.PageBorderStyle
				diagram1.View.RefreshPageSettings()
				diagram1.UpdateView()
			End If
		End Sub

		Private Sub PageSetup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PageSetup.Click
			Dim dlgPrintSetup As New PrintSetupDialog()

			' Made to make values more user friendly. 
			dlgPrintSetup.PageSettings = Me.diagram1.View.PageSettings
			dlgPrintSetup.PrintZoom = Me.diagram1.View.PrintZoom

			If dlgPrintSetup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.diagram1.View.PageSettings = dlgPrintSetup.PageSettings
				Me.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom
				Me.diagram1.View.RefreshPageSettings()
			End If
		End Sub


		#End Region                   
	End Class
End Namespace