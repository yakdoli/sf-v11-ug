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
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports System.Reflection
Imports System.IO
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms.Tools

Namespace ContentCellDemo

	Public Class Form1
		Inherits MetroForm
		Private WithEvents gridControl1 As GridControl
        Private propertyGrid1 As PropertyGrid
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents CheckBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents label1 As System.Windows.Forms.Label
        Private components As IContainer

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

            InitializeGrid()
            Me.propertyGrid1.SelectedObject = gridControl1
        End Sub

        Private Sub InitializeGrid()

            '			#Region "Style prerequistes"
            Dim standard As GridStyleInfo = gridControl1.BaseStylesMap("Standard").StyleInfo
            standard.Font.Bold = False
            standard.Font.Facename = "Verdana" '"Verdana";
            standard.Font.Size = 10
            standard.TextColor = Color.FromArgb(240, 0, 21, 84)
            gridControl1.Font = New System.Drawing.Font("Verdana", 8.5F)


            ' grab some images...
            Dim imageList As New ImageList()
            imageList.Images.Add(SystemIcons.Warning.ToBitmap())
            imageList.Images.Add(SystemIcons.Application.ToBitmap())
            imageList.Images.Add(SystemIcons.Asterisk.ToBitmap())
            imageList.Images.Add(SystemIcons.Error.ToBitmap())
            imageList.Images.Add(SystemIcons.Exclamation.ToBitmap())
            imageList.Images.Add(SystemIcons.Hand.ToBitmap())
            imageList.Images.Add(SystemIcons.Information.ToBitmap())
            imageList.Images.Add(SystemIcons.Question.ToBitmap())
            'standard.ImageList = imageList;

            Dim icon As New Icon(Me.GetType().Module.Assembly.GetManifestResourceStream("gridform.ico"))
            imageList.Images.Add(icon.ToBitmap())

            icon = New Icon(Me.GetType().Module.Assembly.GetManifestResourceStream("toolsform.ico"))
            imageList.Images.Add(icon.ToBitmap())
            standard.ImageList = imageList

            '			#End Region

            '			#Region "Codes to apply celltypes in Grid"
            Me.gridControl1.BeginUpdate()
            gridControl1.TableStyle.FloatCell = True
            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation

            '			#Region "Style declaration"
            Dim headerstyle As New GridStyleInfo()
            headerstyle.Font.Size = 12
            headerstyle.Font.Bold = True
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center
            headerstyle.CellType = GridCellTypeName.Static

            Dim subheaderstyle As New GridStyleInfo()
            subheaderstyle.Font.Bold = True
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center
            subheaderstyle.CellType = GridCellTypeName.Static
            subheaderstyle.TextColor = Color.Gray

            gridControl1.Model.ColWidths(4) = 90
            gridControl1.Model.ColWidths(6) = 100
            '			#End Region

            '			#Region "TextBox Cells"
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount))
            gridControl1(1, 1) = headerstyle
            gridControl1(1, 1).Text = "TextBox Cells"

            Dim rowIndex As Integer = 3, colIndex As Integer = 4
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = subheaderstyle
            gridControl1(rowIndex, 1).Text = "TextBox Cells - represents the default textbox control in a cell as used for in - place editing"
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "TextBox"
            gridControl1(rowIndex, colIndex).CellType = GridCellTypeName.TextBox
            gridControl1(rowIndex, colIndex + 2).Text = "TextBox/Image"
            gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.TextBox
            gridControl1(rowIndex, colIndex + 2).ImageIndex = 9
            gridControl1.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(colIndex + 2))
            '			#End Region

            '			#Region "MaskEditCells"
            rowIndex += 2
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = headerstyle
            gridControl1(rowIndex, 1).Text = "MaskEdit Cells"
            rowIndex += 1
            rowIndex += 1
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = subheaderstyle
            gridControl1(rowIndex, 1).Text = "MaskEdit Cells - allow to mask any cell that permits valid inputs & also control the inputs values"

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "Date Format"
            gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.MaskEdit
            gridControl1(rowIndex, colIndex + 2).MaskEdit.Mask = "99-99-99"
            gridControl1(rowIndex, colIndex + 2).FloatCell = True

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "First Name"
            Dim style1 As GridStyleInfo = gridControl1(rowIndex, colIndex + 2)
            Dim maskedEditStyle1 As GridMaskEditInfo = style1.MaskEdit

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "Last Name"
            Dim style2 As GridStyleInfo = gridControl1(rowIndex, colIndex + 2)
            Dim maskedEditStyle2 As GridMaskEditInfo = style2.MaskEdit

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "Telephone"
            Dim style3 As GridStyleInfo = gridControl1(rowIndex, colIndex + 2)
            Dim maskedEditStyle3 As GridMaskEditInfo = style3.MaskEdit

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "Social Security"
            Dim style4 As GridStyleInfo = gridControl1(rowIndex, colIndex + 2)
            Dim maskedEditStyle4 As GridMaskEditInfo = style4.MaskEdit

            '			#Region "MaskEditBoxes"
            ' 
            ' maskedEditBox1
            ' 
            style1.CellType = "MaskEdit"
            maskedEditStyle1.AllowPrompt = False
            maskedEditStyle1.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals
            style1.CultureInfo = New System.Globalization.CultureInfo("en-US")
            maskedEditStyle1.DateSeparator = "-"c
            maskedEditStyle1.Mask = ">C<CCCCCCCCCCCC"
            style1.MaxLength = 13
            style1.AutoSize = True
            maskedEditStyle1.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
            maskedEditStyle1.UseLocaleDefault = False
            maskedEditStyle1.UseUserOverride = True

            ' 
            ' maskedEditBox2
            ' 
            style2.CellType = "MaskEdit"
            maskedEditStyle2.AllowPrompt = False
            maskedEditStyle2.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.IncludeLiterals
            style2.CultureInfo = New System.Globalization.CultureInfo("en-US")
            maskedEditStyle2.DateSeparator = "-"c
            maskedEditStyle2.Mask = "CCCCCCCCCCCCC"
            style2.MaxLength = 13
            maskedEditStyle2.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
            style2.Text = "_____________"
            maskedEditStyle2.UseLocaleDefault = False
            maskedEditStyle2.UseUserOverride = True
            ' 
            ' maskedEditBox3
            ' 
            style3.CellType = "MaskEdit"
            maskedEditStyle3.AllowPrompt = False
            maskedEditStyle3.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.IncludeLiterals
            style3.CultureInfo = New System.Globalization.CultureInfo("en-US")
            maskedEditStyle3.DateSeparator = "-"c
            maskedEditStyle3.Mask = "(999) 999 - 9999"
            style3.MaxLength = 16
            maskedEditStyle3.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
            style3.Text = "(___) ___ - ____"
            maskedEditStyle3.UseLocaleDefault = False
            maskedEditStyle3.UseUserOverride = True
            ' 
            ' maskedEditBox4
            ' 
            style4.CellType = "MaskEdit"
            maskedEditStyle4.AllowPrompt = False
            maskedEditStyle4.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.IncludeLiterals
            style4.CultureInfo = New System.Globalization.CultureInfo("en-US")
            maskedEditStyle4.DateSeparator = "-"c
            maskedEditStyle4.Mask = "999-99-9999"
            style4.MaxLength = 11
            maskedEditStyle4.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
            style4.Text = "___-__-____"
            maskedEditStyle4.UseLocaleDefault = False
            maskedEditStyle4.UseUserOverride = True
            '			#End Region
            '			#End Region

            '			#Region "NumericUpDown"
            rowIndex += 1
            rowIndex += 1
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = headerstyle
            gridControl1(rowIndex, 1).Text = "NumericUpDown Cells"

            rowIndex += 3
            ' Wrapping, Range 0-20
            gridControl1(rowIndex, colIndex).Text = "With wrapping"
            gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.NumericUpDown
            gridControl1(rowIndex, colIndex + 2).Text = "5"
            gridControl1(rowIndex, colIndex + 2).HorizontalAlignment = GridHorizontalAlignment.Right
            gridControl1(rowIndex, colIndex + 2).NumericUpDown = New GridNumericUpDownCellInfo(0, 20, 5, 1, True)

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Text = "Without wrapping"
            gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.NumericUpDown
            gridControl1(rowIndex, colIndex + 2).Text = "5"
            gridControl1(rowIndex, colIndex + 2).NumericUpDown = New GridNumericUpDownCellInfo(1, 20, 1, 1, False)
            gridControl1(rowIndex, colIndex + 2).HorizontalAlignment = GridHorizontalAlignment.Right
            '			#End Region

            '			#Region "Currency Cells"
            rowIndex += 1
            rowIndex += 1
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = headerstyle
            gridControl1(rowIndex, 1).Text = "Currency Cells"

            rowIndex += 1
            rowIndex += 1
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = subheaderstyle
            gridControl1(rowIndex, 1).Text = "Supports setting patterns to display (+), (-) numbers, grouping digits & decimal separators"

            '			#Region "CurrentStyle Settings"
            Dim currencyStyle As New GridStyleInfo()
            currencyStyle.CellType = GridCellTypeName.Currency
            currencyStyle.CurrencyEdit.ClipMode = CurrencyClipModes.ExcludeFormatting
            ' Set formatting properties
            currencyStyle.CurrencyEdit.NullString = ""
            currencyStyle.CurrencyEdit.CurrencyDecimalDigits = 2
            currencyStyle.CurrencyEdit.CurrencyDecimalSeparator = "."
            currencyStyle.CurrencyEdit.CurrencyGroupSeparator = ","
            currencyStyle.CurrencyEdit.CurrencyGroupSizes = New Integer() {3}
            currencyStyle.CurrencyEdit.CurrencyNumberDigits = 27
            currencyStyle.CurrencyEdit.CurrencyPositivePattern = 0
            'currencyStyle.CurrencyEdit.CurrencySymbol = (row % 2 == 0) ? "$ " : "DM ";
            currencyStyle.TextColor = System.Drawing.Color.Black
            currencyStyle.CurrencyEdit.NegativeColor = System.Drawing.Color.Red
            currencyStyle.CurrencyEdit.NegativeSign = "-"
            currencyStyle.CurrencyEdit.PositiveColor = System.Drawing.Color.Black
            currencyStyle.FloatCell = True
            '			#End Region

            rowIndex += 1
            rowIndex += 1
            gridControl1(rowIndex, colIndex - 2) = currencyStyle
            gridControl1(rowIndex, colIndex - 2).CellValue = 2
            gridControl1(rowIndex, colIndex - 2).CurrencyEdit.CurrencyNegativePattern = 1
            gridControl1(rowIndex, colIndex - 2).CurrencyEdit.CurrencySymbol = "$ "

            gridControl1(rowIndex, colIndex) = currencyStyle
            gridControl1(rowIndex, colIndex).CellValue = 4
            gridControl1(rowIndex, colIndex).CurrencyEdit.CurrencyNegativePattern = 2
            gridControl1(rowIndex, colIndex).CurrencyEdit.CurrencySymbol = "DM"

            gridControl1(rowIndex, colIndex + 2) = currencyStyle
            gridControl1(rowIndex, colIndex + 2).CellValue = -6
            gridControl1(rowIndex, colIndex + 2).CurrencyEdit.CurrencyNegativePattern = 1
            gridControl1(rowIndex, colIndex + 2).CurrencyEdit.CurrencySymbol = "$ "

            gridControl1(rowIndex, colIndex + 4) = currencyStyle
            gridControl1(rowIndex, colIndex + 4).CellValue = -8
            gridControl1(rowIndex, colIndex + 4).CurrencyEdit.CurrencyNegativePattern = 2
            gridControl1(rowIndex, colIndex + 4).CurrencyEdit.CurrencySymbol = "DM "

            '			#End Region

            '			#Region "Password cells"

            rowIndex += 1
            rowIndex += 1
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = headerstyle
            gridControl1(rowIndex, 1).Text = "Password Cells"

            rowIndex += 1
            rowIndex += 1
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
            gridControl1(rowIndex, 1) = subheaderstyle
            gridControl1(rowIndex, 1).Text = "Allows you to type a password, but only masking character like "" * "", will be displayed "


            Dim passwdStyle As New GridStyleInfo()
            For row As Integer = 37 To 45
                passwdStyle = gridControl1(row, 2)
                passwdStyle.PasswordChar = "*"c
                passwdStyle.CellType = GridCellTypeName.OriginalTextBox
                passwdStyle.Text = New String(CChar(ChrW(65 + row)), row)

                passwdStyle = gridControl1(row, 3)
                passwdStyle.CharacterCasing = CharacterCasing.Lower
                passwdStyle.Text = New String(CChar(ChrW(65 + row)), row)

                passwdStyle = gridControl1(row, 4)
                passwdStyle.CharacterCasing = CharacterCasing.Upper
                passwdStyle.Text = New String(CChar(ChrW(65 + row)), row)
            Next row
            '			#End Region

            AddHandler gridControl1.CheckBoxClick, AddressOf gridControl1_CheckBoxClick
            Me.gridControl1.EndUpdate(True)
            '			#End Region
        End Sub

#Region "Helper Methods"
        Private Sub gridControl1_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            If e.RowIndex = 21 Then
                For i As Integer = 23 To 36
                    gridControl1.HideRows(i) = Not gridControl1.HideRows(i)
                Next i
            End If
            If e.RowIndex = 36 Then
                Animate(Not (gridControl1(e.RowIndex, e.ColIndex).Text = "True"))
            End If
        End Sub

        Private timer As New Timer()

        Private Sub Animate(ByVal enabled As Boolean)
            If enabled Then
                AddHandler timer.Tick, AddressOf timer_Tick
                timer.Interval = 10
                timer.Enabled = True
                timer.Start()
            Else
                RemoveHandler timer.Tick, AddressOf timer_Tick
                timer.Stop()
            End If
        End Sub

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.BeginUpdate(BeginUpdateOptions.Invalidate)
            For rowIndex As Integer = 24 To 35 Step 2
                Dim style As GridStyleInfo = gridControl1(rowIndex, 2)
                Dim progressBarEx As GridProgressBarInfo = style.ProgressBar
                Dim pvalue As Integer = (progressBarEx.ProgressValue + rowIndex) Mod 100
                progressBarEx.ProgressValue = pvalue
            Next rowIndex

            Dim stylev As GridStyleInfo = gridControl1(26, 8)
            Dim progressBarExv As GridProgressBarInfo = stylev.ProgressBar
            Dim pvaluev As Integer = (progressBarExv.ProgressValue + 3) Mod 100
            progressBarExv.ProgressValue = pvaluev

            gridControl1.EndUpdate(True)
            Application.DoEvents()
        End Sub

#End Region

#Region "Form handlers"

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function

        Private Function GetBitmap(ByVal bitmapName As String) As Bitmap
            Dim bitmap As Bitmap = Nothing

            Try
                Dim ass As System.Reflection.Assembly = GetType(Form1).Assembly
                Dim name As String = ass.GetName().Name
                Dim stream As Stream = ass.GetManifestResourceStream(name & ".Resources." & bitmapName)
                bitmap = New Bitmap(stream)
            Catch ex As Exception
                TraceUtil.TraceExceptionCatched(ex)
            End Try

            Return bitmap
        End Function

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub


        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo3 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.CheckBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label1 = New System.Windows.Forms.Label
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColCount = 9
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo1.StyleInfo.Font.Bold = False
            GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo1.StyleInfo.Font.Italic = False
            GridCellInfo1.StyleInfo.Font.Size = 8.25!
            GridCellInfo1.StyleInfo.Font.Strikeout = False
            GridCellInfo1.StyleInfo.Font.Underline = False
            GridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridCellInfo2.Col = -1
            GridCellInfo2.Row = -1
            GridCellInfo2.StyleInfo.Font.Bold = False
            GridCellInfo2.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo2.StyleInfo.Font.Italic = False
            GridCellInfo2.StyleInfo.Font.Size = 8.25!
            GridCellInfo2.StyleInfo.Font.Strikeout = False
            GridCellInfo2.StyleInfo.Font.Underline = False
            GridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridCellInfo3.Col = -1
            GridCellInfo3.Row = -1
            GridCellInfo3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo3.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridCellInfo3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2, GridCellInfo3})
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RowCount = 45
            Me.gridControl1.Size = New System.Drawing.Size(640, 504)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.VerticalThumbTrack = True
            '
            'propertyGrid1
            '
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(672, 132)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(223, 384)
            Me.propertyGrid1.TabIndex = 1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.CheckBoxAdv1)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(672, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(223, 114)
            Me.groupBox1.TabIndex = 3
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "BrowseOnly"
            '
            'CheckBoxAdv1
            '
            Me.CheckBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBoxAdv1.Location = New System.Drawing.Point(39, 70)
            Me.CheckBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.CheckBoxAdv1.Name = "CheckBoxAdv1"
            Me.CheckBoxAdv1.Size = New System.Drawing.Size(116, 27)
            Me.CheckBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.CheckBoxAdv1.TabIndex = 4
            Me.CheckBoxAdv1.Text = "Browse Only"
            Me.CheckBoxAdv1.ThemesEnabled = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(6, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(211, 33)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Click the CheckBox to enable the GridControl as read mode(un editable)"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(905, 525)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Editor Cell Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "PropertyGrid Handlers"
        Private range As GridRangeInfo = GridRangeInfo.Empty
        Private style As GridStyleInfo = Nothing
        Private grid As GridControlBase = Nothing
        Private refreshPropertyGridNextIdle As Boolean = False
        Private refreshTimer As Timer = Nothing

        Private Sub DelayRefreshPropertyGrid(ByVal range As GridRangeInfo, ByVal interval As Integer)
            If refreshTimer IsNot Nothing Then
                refreshPropertyGridNextIdle = False
                refreshTimer.Stop()
            Else
                refreshTimer = New Timer()
                refreshTimer.Interval = interval
                AddHandler refreshTimer.Tick, AddressOf DelayedRefreshPropertyGrid
            End If
            refreshTimer.Start()
            refreshPropertyGridNextIdle = True
            Me.range = range
        End Sub

        Private Sub DelayedRefreshPropertyGrid(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfo()
            Dim t As Timer = TryCast(sender, Timer)
            t.Dispose()
            Me.refreshTimer = Nothing

            If refreshPropertyGridNextIdle Then
                RefreshPropertyGrid()
            End If
        End Sub

        Public Sub RefreshPropertyGrid()
            refreshPropertyGridNextIdle = False
            If style IsNot Nothing Then
                RemoveHandler style.Changed, AddressOf GridStyleInfoChanged
            End If

            grid = Me.gridControl1
            style = grid.Model.GetCombinedStyle(range)
            If style IsNot Nothing Then
                propertyGrid1.SelectedObject = style
                AddHandler style.Changed, AddressOf GridStyleInfoChanged
            Else
                range = GridRangeInfo.Empty
            End If
        End Sub

        Public Sub ShowPropertyGridItem(ByVal category As String, ByVal label As String)
            RefreshPropertyGrid()
            Dim gi As GridItem = propertyGrid1.SelectedGridItem
            Do While gi IsNot Nothing AndAlso gi.GridItemType <> GridItemType.Root
                gi = gi.Parent
            Loop

            If gi IsNot Nothing Then
                ' Categories
                Dim categories As GridItemCollection = gi.GridItems
                Dim sliderCategory As GridItem = categories(category)
                If sliderCategory IsNot Nothing Then
                    Dim items As GridItemCollection = sliderCategory.GridItems
                    Dim item As GridItem
                    If label = "" Then
                        item = items(Math.Min(10, items.Count - 1))
                    Else
                        item = items(label)
                    End If
                    item.Select()
                    If item.Expandable Then
                        propertyGrid1.ExpandAllGridItems()
                        items = item.GridItems
                        items(Math.Min(10, items.Count - 1)).Select()
                    End If
                End If
            End If
            RefreshPropertyGrid()
        End Sub
        Private Sub GridStyleInfoChanged(ByVal sender As Object, ByVal e As StyleChangedEventArgs)
            If (Not refreshPropertyGridNextIdle) AndAlso (Not range.IsEmpty) AndAlso grid IsNot Nothing AndAlso style IsNot Nothing Then
                grid.Model.ChangeCells(range, style, StyleModifyType.Changes)
            End If
        End Sub
        Private Sub gridControl1_CurrentCellMoved(ByVal sender As Object, ByVal e As GridCurrentCellMovedEventArgs) Handles gridControl1.CurrentCellMoved
            grid = CType(sender, GridControlBase)
            DelayRefreshPropertyGrid(GridRangeInfo.Cell(grid.CurrentCell.RowIndex, grid.CurrentCell.ColIndex), 50)
        End Sub

        Private Sub gridControl1_SelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs) Handles gridControl1.SelectionChanged
            DelayRefreshPropertyGrid(e.Range, 200)
        End Sub
#End Region

        Private Sub CheckBoxAdv1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAdv1.CheckStateChanged
            If (CheckBoxAdv1.Checked) Then
                Me.gridControl1.BrowseOnly = True
            Else
                Me.gridControl1.BrowseOnly = False
            End If
        End Sub
    End Class


End Namespace
