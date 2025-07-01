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

Imports Syncfusion.Calculate

Public Class Form1
    Inherits System.Windows.Forms.Form

    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(32, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate Data"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(32, 80)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 208)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(70, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(135, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(32, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "0"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(212, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = "123"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(264, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Set"
        '
        'label3
        '
        Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(173, 51)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 16)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Value:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(108, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(24, 14)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Col:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(32, 50)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 16)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Row:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 310)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.MinimumSize = New System.Drawing.Size(344, 344)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Array ICalcData Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private r As New Random()
    Private data As ArrayCalcData
    Dim nRows As Integer
    Dim nCols As Integer


    '/ <summary>
    '/ Populates the double array.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'create some sample data
        Me.nRows = r.Next(10) + 2
        Me.nCols = r.Next(3) + 1
        Dim a(nRows, nCols) As Double
        Dim row As Integer
        For row = 0 To nRows - 1
            Dim col As Integer
            For col = 0 To nCols - 1
                a(row, col) = CDbl(r.Next(100)) / 10
            Next
        Next

        'create a ArrayCalcData object and pass it this array
        Me.data = New ArrayCalcData(a)

        'create an CalcEngine object using this ArrayCalcData object
        Dim engine As New CalcEngine(Me.data)

        'Turn on dependency tracking so values set with the Set button
        'take effect immediately
        engine.UseDependencies = True

        'call RecalculateRange so any formulas in the data can be initially computed.
        engine.RecalculateRange(RangeInfo.Cells(1, 1, nRows + 1, nCols + 1), data)

        ShowObject()
    End Sub 'button1_Click


    '/ <summary>
    '/ Displays the ArrayCalcData values in a TextBox.
    '/ </summary>
    Private Sub ShowObject()
        Me.TextBox1.Text = ""
        Dim i As Integer
        For i = 0 To Me.nRows
            Dim j As Integer

            For j = 0 To Me.nCols
                Me.TextBox1.Text += Me.data(i, j).ToString() + ControlChars.Tab
            Next
            Me.TextBox1.Text += ControlChars.Cr + ControlChars.Lf
        Next
    End Sub 'ShowObject

    '/ <summary>
    '/ Populates a single entry in the ArrayCalcData object.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.nRows = 0 Then
            MessageBox.Show("Generate data first.")
            Return
        End If

        Try
            Dim row As Integer = Integer.Parse(Me.TextBox2.Text)
            Dim col As Integer = Integer.Parse(Me.TextBox3.Text)
            Dim val As String = Me.TextBox4.Text

            Me.data(row, col) = val

            ShowObject()
        Catch ex1 As IndexOutOfRangeException
            MessageBox.Show("Please enter a valid row and column index." & Constants.vbCrLf & "Exception: " & ex1.Message)
        Catch ex2 As FormatException
            MessageBox.Show("Please enter a valid row and column index." & Constants.vbCrLf & "Exception: " & ex2.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Environment.CommandLine.ToLower().EndsWith("automatedtest") Then
            Me.Button1.PerformClick()
            Me.Button2.PerformClick()
        End If
    End Sub

    ' utility to locate a sibling file
    Public Shared Function FindFile(ByVal dataDirName As String, ByVal fileName As String) As String
        dataDirName = dataDirName.TrimEnd("\"c, "/"c)
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = dataDirName + "\" + fileName
        Dim n As Integer
        For n = 0 To 9
            If System.IO.File.Exists(fileName) Then
                Return fileName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return dataFileName
            End If
            fileName = "..\" + fileName
            dataFileName = "..\" + dataFileName
        Next n '

        Return ""
    End Function 'FindFile
End Class
