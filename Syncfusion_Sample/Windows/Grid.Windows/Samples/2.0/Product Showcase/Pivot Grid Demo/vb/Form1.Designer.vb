Imports Microsoft.VisualBasic
Imports System
Namespace PrivotGridSample
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip
            Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.loadSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.resetSchemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.displayDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.actionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.changeAppearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.loadAppearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveAppearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.expandAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.collapseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.refreshCalculationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.showAllColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pivotGridControl1 = New PivotGridLibrary.PivotGridControl
            Me.menuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'menuStrip1
            '
            Me.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.actionsToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Size = New System.Drawing.Size(882, 24)
            Me.menuStrip1.TabIndex = 5
            Me.menuStrip1.Text = "menuStrip1"
            '
            'fileToolStripMenuItem
            '
            Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loadSchemaToolStripMenuItem, Me.saveSchemaToolStripMenuItem, Me.resetSchemaToolStripMenuItem, Me.displayDataToolStripMenuItem, Me.exitToolStripMenuItem})
            Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
            Me.fileToolStripMenuItem.Text = "File"
            '
            'loadSchemaToolStripMenuItem
            '
            Me.loadSchemaToolStripMenuItem.Name = "loadSchemaToolStripMenuItem"
            Me.loadSchemaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.loadSchemaToolStripMenuItem.Text = "Load Schema"
            '
            'saveSchemaToolStripMenuItem
            '
            Me.saveSchemaToolStripMenuItem.Name = "saveSchemaToolStripMenuItem"
            Me.saveSchemaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.saveSchemaToolStripMenuItem.Text = "Save Schema"
            '
            'resetSchemaToolStripMenuItem
            '
            Me.resetSchemaToolStripMenuItem.Name = "resetSchemaToolStripMenuItem"
            Me.resetSchemaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.resetSchemaToolStripMenuItem.Text = "Reset Schema"
            '
            'displayDataToolStripMenuItem
            '
            Me.displayDataToolStripMenuItem.Name = "displayDataToolStripMenuItem"
            Me.displayDataToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.displayDataToolStripMenuItem.Text = "Display  Data"
            '
            'exitToolStripMenuItem
            '
            Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            Me.exitToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
            Me.exitToolStripMenuItem.Text = "Exit"
            '
            'actionsToolStripMenuItem
            '
            Me.actionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.changeAppearanceToolStripMenuItem, Me.loadAppearanceToolStripMenuItem, Me.saveAppearanceToolStripMenuItem, Me.expandAllToolStripMenuItem, Me.collapseAllToolStripMenuItem, Me.refreshCalculationsToolStripMenuItem, Me.showAllColorsToolStripMenuItem})
            Me.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem"
            Me.actionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
            Me.actionsToolStripMenuItem.Text = "Actions"
            '
            'changeAppearanceToolStripMenuItem
            '
            Me.changeAppearanceToolStripMenuItem.Name = "changeAppearanceToolStripMenuItem"
            Me.changeAppearanceToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.changeAppearanceToolStripMenuItem.Text = "Change Appearance"
            '
            'loadAppearanceToolStripMenuItem
            '
            Me.loadAppearanceToolStripMenuItem.Name = "loadAppearanceToolStripMenuItem"
            Me.loadAppearanceToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.loadAppearanceToolStripMenuItem.Text = "Load Appearance"
            '
            'saveAppearanceToolStripMenuItem
            '
            Me.saveAppearanceToolStripMenuItem.Name = "saveAppearanceToolStripMenuItem"
            Me.saveAppearanceToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.saveAppearanceToolStripMenuItem.Text = "Save Appearance"
            '
            'expandAllToolStripMenuItem
            '
            Me.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem"
            Me.expandAllToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.expandAllToolStripMenuItem.Text = "Expand All"
            '
            'collapseAllToolStripMenuItem
            '
            Me.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem"
            Me.collapseAllToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.collapseAllToolStripMenuItem.Text = "Collapse All"
            '
            'refreshCalculationsToolStripMenuItem
            '
            Me.refreshCalculationsToolStripMenuItem.Name = "refreshCalculationsToolStripMenuItem"
            Me.refreshCalculationsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.refreshCalculationsToolStripMenuItem.Text = "Refresh Calculations"
            '
            'showAllColorsToolStripMenuItem
            '
            Me.showAllColorsToolStripMenuItem.Name = "showAllColorsToolStripMenuItem"
            Me.showAllColorsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
            Me.showAllColorsToolStripMenuItem.Text = "Show All Colors"
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.AllString = "(all)"
            Me.pivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.AutoSizeColumns = True
            Me.pivotGridControl1.BackColor = System.Drawing.SystemColors.Control
            Me.pivotGridControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pivotGridControl1.DataSource = Nothing
            Me.pivotGridControl1.DefaultComputationName = "Sum"
            Me.pivotGridControl1.DefaultDescriptionFormat = "{0} of {1}"
            Me.pivotGridControl1.GrandTotalString = "Grand Total"
            Me.pivotGridControl1.LeftPanelHeight = 30
            Me.pivotGridControl1.LeftPanelWidth = 90
            Me.pivotGridControl1.Location = New System.Drawing.Point(24, 47)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(830, 545)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.TotalString = "Total"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(882, 609)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.menuStrip1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MainMenuStrip = Me.menuStrip1
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pivot Grid Demo"
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pivotGridControl1 As PivotGridLibrary.PivotGridControl
		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents loadSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents saveSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents resetSchemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents displayDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private actionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents changeAppearanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents loadAppearanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents saveAppearanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents expandAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents collapseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents refreshCalculationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents showAllColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

