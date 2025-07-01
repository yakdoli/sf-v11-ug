Imports Microsoft.VisualBasic
Imports System
Namespace EssentialBlocks
	Public Partial Class NextPieceForm
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
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Me.gridNextPiece = New Syncfusion.Windows.Forms.Grid.GridControl
            CType(Me.gridNextPiece, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridNextPiece
            '
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.CellType = "Static"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.CellType = "Static"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle4.Name = "Header"
            GridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.CellType = "Static"
            GridBaseStyle4.StyleInfo.Font.Bold = True
            GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            GridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridNextPiece.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
            Me.gridNextPiece.ColCount = 5
            Me.gridNextPiece.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 28), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 25), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 24), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 24), New Syncfusion.Windows.Forms.Grid.GridColWidth(5, 25)})
            Me.gridNextPiece.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridNextPiece.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridNextPiece.ForeColor = System.Drawing.SystemColors.ControlText
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo2.Col = 1
            GridCellInfo2.Row = 1
            Me.gridNextPiece.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2})
            Me.gridNextPiece.Location = New System.Drawing.Point(0, 0)
            Me.gridNextPiece.Name = "gridNextPiece"
            Me.gridNextPiece.Properties.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
            Me.gridNextPiece.Properties.ColHeaders = False
            Me.gridNextPiece.Properties.GridLineColor = System.Drawing.SystemColors.Control
            Me.gridNextPiece.Properties.RowHeaders = False
            Me.gridNextPiece.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridNextPiece.RowCount = 5
            Me.gridNextPiece.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridNextPiece.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
            Me.gridNextPiece.Size = New System.Drawing.Size(126, 86)
            Me.gridNextPiece.SmartSizeBox = False
            Me.gridNextPiece.TabIndex = 0
            '
            'NextPieceForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(126, 86)
            Me.ControlBox = False
            Me.Controls.Add(Me.gridNextPiece)
            Me.MaximumSize = New System.Drawing.Size(163, 147)
            Me.Name = "NextPieceForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Next Piece"
            CType(Me.gridNextPiece, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Public WithEvents gridNextPiece As Syncfusion.Windows.Forms.Grid.GridControl
	End Class
End Namespace