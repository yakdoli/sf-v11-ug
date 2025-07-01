Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms

Namespace ChartExportData
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class Form2
		Inherits Office2007Form
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
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
				If Not components Is Nothing Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.ColCount = 2
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RowCount = 2
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(387, 280)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			' 
			' Form2
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(387, 280)
			Me.Controls.Add(Me.gridControl1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form2"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Essential Chart - Displayed in Grid"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'Creates a new instance of the Imagelist class.
			Dim img As ImageList = New ImageList()

			'Adds the image to the Image collection of the Imagelist.
			img.Images.Add(Image.FromFile(Me.Name))

			'Specify the size of the image.
			img.ImageSize = New Size(256, 256)

			'Set the imagelist of the cell.
			Me.gridControl1(1,1).ImageList = img

			'Specify the index for the image to be displayed.
			Me.gridControl1(1, 1).ImageIndex = 0

			'Specify the row and column height of the cell.
			Me.gridControl1.RowHeights(1) = 300
			Me.gridControl1.ColWidths(1) = 300

			'Specify the image size mode.
			Me.gridControl1(1, 1).ImageSizeMode = GridImageSizeMode.CenterImage
			'  
		'    


		End Sub
	End Class
End Namespace
