Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace NamedRangesForFormulas
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
		Private CashFlow As Syncfusion.Windows.Forms.TabBarPage
		Private Expenses As Syncfusion.Windows.Forms.TabBarPage
		Private Income As Syncfusion.Windows.Forms.TabBarPage
		Private gridExpenses As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridIncome As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridCashFlow As Syncfusion.Windows.Forms.Grid.GridControl
		Private contextMenu1 As System.Windows.Forms.ContextMenu
		Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
		Private label1 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

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
			Dim gridCellInfo8 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo7 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl()
			Me.CashFlow = New Syncfusion.Windows.Forms.TabBarPage()
			Me.gridCashFlow = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.contextMenu1 = New System.Windows.Forms.ContextMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.Expenses = New Syncfusion.Windows.Forms.TabBarPage()
			Me.gridExpenses = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.Income = New Syncfusion.Windows.Forms.TabBarPage()
			Me.gridIncome = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.tabBarSplitterControl1.SuspendLayout()
			Me.CashFlow.SuspendLayout()
			CType(Me.gridCashFlow, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Expenses.SuspendLayout()
			CType(Me.gridExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Income.SuspendLayout()
			CType(Me.gridIncome, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tabBarSplitterControl1
			' 
			Me.tabBarSplitterControl1.ActivePageIndex = 2
			Me.tabBarSplitterControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.tabBarSplitterControl1.Controls.Add(Me.CashFlow)
			Me.tabBarSplitterControl1.Controls.Add(Me.Expenses)
			Me.tabBarSplitterControl1.Controls.Add(Me.Income)
			Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
			Me.tabBarSplitterControl1.Location = New System.Drawing.Point(25, 42)
			Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
			Me.tabBarSplitterControl1.Size = New System.Drawing.Size(514, 271)
			Me.tabBarSplitterControl1.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.tabBarSplitterControl1.TabIndex = 0
			Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
            tabBarSplitterControl1.Office2007ScrollBars = True
            tabBarSplitterControl1.Style = TabBarSplitterStyle.Metro
			' 
			' CashFlow
			' 
			Me.CashFlow.Controls.Add(Me.gridCashFlow)
			Me.CashFlow.Location = New System.Drawing.Point(0, 0)
			Me.CashFlow.Name = "CashFlow"
			Me.CashFlow.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.CashFlow.TabBackColor = System.Drawing.SystemColors.Control
			Me.CashFlow.Text = "CashFlow"
			Me.CashFlow.ThemesEnabled = True
			' 
			' gridCashFlow
			' 
			Me.gridCashFlow.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.gridCashFlow.ContextMenu = Me.contextMenu1
			Me.gridCashFlow.DefaultRowHeight = 20
			Me.gridCashFlow.FillSplitterPane = True
			Me.gridCashFlow.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			gridCellInfo8.Col = -1
			gridCellInfo8.Row = -1
			gridCellInfo8.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo8.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo8.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo8.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo8.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridCashFlow.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo8})

			Me.gridCashFlow.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridCashFlow.Location = New System.Drawing.Point(0, 0)
			Me.gridCashFlow.Name = "gridCashFlow"
			Me.gridCashFlow.Size = New System.Drawing.Size(495, 252)
			Me.gridCashFlow.SmartSizeBox = False
			Me.gridCashFlow.Text = "gridControl1"
			Me.gridCashFlow.ThemesEnabled = True
			' 
			' contextMenu1
			' 
			Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.Text = "Edit Inputs"
'			Me.menuItem1.Click += New System.EventHandler(Me.menuItem1_Click)
			' 
			' Expenses
			' 
			Me.Expenses.Controls.Add(Me.gridExpenses)
			Me.Expenses.Location = New System.Drawing.Point(0, 0)
			Me.Expenses.Name = "Expenses"
			Me.Expenses.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.Expenses.TabBackColor = System.Drawing.SystemColors.Control
			Me.Expenses.Text = "Expenses"
            Me.Expenses.ThemesEnabled = True
			' 
			' gridExpenses
			' 
			Me.gridExpenses.ContextMenu = Me.contextMenu1
			Me.gridExpenses.DefaultRowHeight = 20
			Me.gridExpenses.FillSplitterPane = True
			Me.gridExpenses.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			gridCellInfo1.Col = -1
			gridCellInfo1.Row = -1
			gridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridExpenses.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo1})
			Me.gridExpenses.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridExpenses.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridExpenses.Location = New System.Drawing.Point(0, 0)
			Me.gridExpenses.MetroScrollBars = True
			Me.gridExpenses.Name = "gridExpenses"
			Me.gridExpenses.Size = New System.Drawing.Size(495, 252)
			Me.gridExpenses.SmartSizeBox = False
			Me.gridExpenses.Text = "gridControl2"
			Me.gridExpenses.ThemesEnabled = True
			Me.gridExpenses.GridVisualStyles = GridVisualStyles.Metro
			' 
			' Income
			' 
			Me.Income.ContextMenu = Me.contextMenu1
			Me.Income.Controls.Add(Me.gridIncome)
			Me.Income.Location = New System.Drawing.Point(0, 0)
			Me.Income.Name = "Income"
			Me.Income.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.Income.TabBackColor = System.Drawing.SystemColors.Control
			Me.Income.Text = "Income"
            Me.Income.ThemesEnabled = True
			' 
			' gridIncome
			' 
			Me.gridIncome.DefaultRowHeight = 20
			Me.gridIncome.FillSplitterPane = True
			Me.gridIncome.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			gridCellInfo7.Col = -1
			gridCellInfo7.Row = -1
			gridCellInfo7.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo7.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo7.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo7.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo7.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridIncome.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo7})
			Me.gridIncome.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridIncome.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridIncome.Location = New System.Drawing.Point(0, 0)
			Me.gridIncome.MetroScrollBars = True
			Me.gridIncome.Name = "gridIncome"
			Me.gridIncome.Size = New System.Drawing.Size(495, 252)
			Me.gridIncome.SmartSizeBox = False
			Me.gridIncome.Text = "gridControl3"
			Me.gridIncome.ThemesEnabled = True
			Me.gridIncome.GridVisualStyles = GridVisualStyles.Metro
			' 
			' label1
			' 
			Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(10, 3)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(246, 23)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Right-Click Any Cell To Edit the Input"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' panel1
			' 
			Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New System.Drawing.Point(12, 13)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(546, 320)
			Me.panel1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(570, 346)
			Me.Controls.Add(Me.tabBarSplitterControl1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.Text = "Named Range Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.tabBarSplitterControl1.ResumeLayout(False)
			Me.CashFlow.ResumeLayout(False)
			CType(Me.gridCashFlow, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Expenses.ResumeLayout(False)
			CType(Me.gridExpenses, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Income.ResumeLayout(False)
			CType(Me.gridIncome, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub

		#Region "Event Handler"
		Private engine As GridFormulaEngine
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'register grids for multisheeted use
			Dim sheetFamilyID As Integer = GridFormulaEngine.CreateSheetFamilyID()
			GridFormulaEngine.RegisterGridAsSheet("CashFlow", Me.gridCashFlow.Model, sheetFamilyID)
			GridFormulaEngine.RegisterGridAsSheet("Expenses", Me.gridExpenses.Model, sheetFamilyID)
			GridFormulaEngine.RegisterGridAsSheet("Income", Me.gridIncome.Model, sheetFamilyID)

			'make all cells potential formula cells
			'and set some other table wide styles
			Me.gridExpenses.TableStyle.CellType = "FormulaCell"
			Me.gridIncome.TableStyle.CellType = "FormulaCell"
			Me.gridCashFlow.TableStyle.CellType = "FormulaCell"

			Me.gridExpenses.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Right
			Me.gridIncome.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Right
			Me.gridCashFlow.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Right

			Me.gridExpenses.TableStyle.Format = "F2"
			Me.gridIncome.TableStyle.Format = "F2"
			Me.gridCashFlow.TableStyle.Format = "F2"

			'do not activate unless double click
			GridFormulaCellRenderer.ForceEditWhenActivated = False
			Me.gridExpenses.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell
			Me.gridIncome.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell
			Me.gridCashFlow.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell

			'get a reference to the GridFormulaEngine object
			'the same object is used for all registered sheets, so it doe not matter which grid we use
			Me.engine = (CType(gridCashFlow.Model.CellModels("FormulaCell"), GridFormulaCellModel)).Engine

			Me.gridExpenses.RowCount = 30

			'set up expenses grid & add values to NamedRanges
			SetValueAndFormulaFor("Mortgage", "800", 2, Me.gridExpenses)
			SetValueAndFormulaFor("Insurance", "200", 3, Me.gridExpenses)
			SetValueAndFormulaFor("Car", "300", 4, Me.gridExpenses)
			SetValueAndFormulaFor("Food", "200", 5, Me.gridExpenses)
			SetValueAndFormulaFor("Groceries", "200", 6, Me.gridExpenses)
			SetValueAndFormulaFor("Clothing", "100", 7, Me.gridExpenses)
			Me.gridExpenses(8,2).Text = "Total"
			Me.gridExpenses(8,2).Font.Bold = True

			Dim style As GridStyleInfo = Me.gridExpenses(8,3)
			style.Font.Bold = True
			style.Text = "=Sum(C2:C7)"


			'set up income grid
			Me.gridIncome.RowCount = 30
			SetValueAndFormulaFor("Investments", "150", 2, Me.gridIncome)
			SetValueAndFormulaFor("Salary1", "1300", 3, Me.gridIncome)
			SetValueAndFormulaFor("Salary2", "1200", 4, Me.gridIncome)
			Me.gridIncome(8,2).Text = "Total"
			Me.gridIncome(8,2).Font.Bold = True

			Me.engine.AdjustNameRangesForSize()

			style = Me.gridIncome(8,3)
			style.Font.Bold = True
			style.Text = "=Sum(C2:C7)"

			'set up CashFlow grid
			Me.gridCashFlow.RowCount = 30
			Me.gridCashFlow(2,2).Text = "Income"
			Me.gridCashFlow(3,2).Text = "Expenses"
			Me.gridCashFlow(2,3).Text = "=Income!C8"
			Me.gridCashFlow(3,3).Text = "=Expenses!C8"
			Me.gridCashFlow(5,2).Text = "Flow"
			Me.gridCashFlow(5,2).Font.Bold = True

			style = Me.gridCashFlow(5,3)
			style.Font.Bold = True
			style.Text = "=Sum(C2-C3)"

			'force everything to be recalculated so namedrange dependencies are fully known
			Me.engine.RecalculateRange(GridRangeInfo.Table(), Me.gridIncome.Model, True, True)
			Me.engine.RecalculateRange(GridRangeInfo.Table(), Me.gridExpenses.Model, True, True)


			'set the active tab
			Me.tabBarSplitterControl1.ActivePage = Me.tabBarSplitterControl1.TabBarPages(0)

			'To customize the dialog that appears when you edit NamedRanges using
			'GridFormulaNamedRangesEditHelper.ShowNamedRangesDialog, use this event
			AddHandler GridFormulaNamedRangesEditHelper.ShowingNamedRangesDialog, AddressOf helper_ShowingNamedRangesDialog

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridCashFlow.DefaultRowHeight = 18
			Me.gridCashFlow.DefaultColWidth = 70
			Me.gridCashFlow.Properties.GridLineColor = System.Drawing.Color.Silver
			Me.gridCashFlow.DefaultGridBorderStyle = GridBorderStyle.Solid

			Me.gridExpenses.DefaultRowHeight = 18
			Me.gridExpenses.DefaultColWidth = 70
			Me.gridExpenses.Properties.GridLineColor = System.Drawing.Color.Silver
			Me.gridExpenses.DefaultGridBorderStyle = GridBorderStyle.Solid

			Me.gridIncome.DefaultRowHeight = 18
			Me.gridIncome.DefaultColWidth = 70
			Me.gridIncome.Properties.GridLineColor = System.Drawing.Color.Silver
			Me.gridIncome.DefaultGridBorderStyle = GridBorderStyle.Solid

		End Sub

		'helper method to set named ranges and enter formulas in cells
		Private Sub SetValueAndFormulaFor(ByVal name As String, ByVal val As String, ByVal row As Integer, ByVal grid As GridControl)
			grid(row, 2).Text = name
			name.Replace(" ", "") 'no blanks in NamedRanges.Name
			Me.engine.AddNamedRange(name, val)
			grid(row, 3).Text = "= " & name
		End Sub

		'event handler to change the title of editing dialog
		Private Sub helper_ShowingNamedRangesDialog(ByVal sender As Object, ByVal e As ControlEventArgs)
			Dim f As Form = TryCast(e.Control, Form)
			If f IsNot Nothing Then
				'set the title for the dialog
				f.Text = "CashFlow Inputs"
			End If
		End Sub

		'menu handler for the Context menu
		Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Click
			GridFormulaNamedRangesEditHelper.ShowNamedRangesDialog(Me.engine)
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
End Namespace
