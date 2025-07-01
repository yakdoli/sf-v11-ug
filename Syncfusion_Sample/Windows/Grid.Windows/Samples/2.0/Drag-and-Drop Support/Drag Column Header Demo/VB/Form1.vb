#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace DragColumnHeader

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits MetroForm
        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
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
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            AddHandler gridControl1.QueryAllowDragColumnHeader, AddressOf gridControl1_QueryAllowDragColumnHeader
            Me.gridControl1.ControllerOptions = Me.gridControl1.ControllerOptions Or GridControllerOptions.DragColumnHeader
            AddHandler gridControl1.CellClick, AddressOf gridControl1_CellClick
            AddHandler gridControl1.CellDoubleClick, AddressOf gridControl1_CellDoubleClick
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.ColCount = 20
            Me.gridControl1.EnableIntelliMouse = True
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.HScrollPixel = True
            Me.gridControl1.Location = New System.Drawing.Point(19, 15)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RowCount = 12
            Me.gridControl1.Size = New System.Drawing.Size(590, 254)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.VerticalThumbTrack = True
            Me.gridControl1.VScrollPixel = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
            '
            'panel1
            '
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(624, 281)
            Me.panel1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(624, 281)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Drag Column Header Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim i As Integer = 1
            Do While i <= Me.gridControl1.ColCount
                Me.gridControl1(1, i).Text = i.ToString()
                i += 1
            Loop

            i = 1
            Do While i <= Me.gridControl1.ColCount
                Me.gridControl1(2, i).Text = Convert.ToChar((i Mod 26) + 65 - 1).ToString()
                i += 1
            Loop

                       Me.gridControl1.DefaultRowHeight = 18
            Me.gridControl1.DefaultColWidth = 70
            Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.BackColor = Color.White
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Me.gridControl1.ThemesEnabled = True
            Dim style As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Segoe UI"
            Me.StartPosition = FormStartPosition.CenterScreen
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


        Private Sub gridControl1_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            System.Diagnostics.Debug.WriteLine("gridControl1_CellClick: " & e.ToString())
        End Sub

        Private Sub gridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            System.Diagnostics.Debug.WriteLine("gridControl1_CellDoubleClick: " & e.ToString())
            e.Cancel = True ' Avoid subsequent CellClick being raised.
        End Sub

        Private Sub gridControl1_QueryAllowDragColumnHeader(ByVal sender As Object, ByVal e As GridQueryDragColumnHeaderEventArgs)
            If e.Reason <> GridQueryDragColumnHeaderReason.HitTest Then
                System.Diagnostics.Debug.WriteLine("gridControl1_QueryAllowDragColumnHeader: " & e.ToString())
            End If
        End Sub


    End Class
End Namespace
