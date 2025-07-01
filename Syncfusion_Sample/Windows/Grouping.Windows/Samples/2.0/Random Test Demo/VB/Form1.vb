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


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Grouping

'INSTANT VB NOTE: VB does not allow aliasing interfaces:
'using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary

Namespace RandomTest
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents StartTestbutton As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private totalCount As System.Windows.Forms.Label
		Private bucket3Count As System.Windows.Forms.Label
		Private bucket56Count As System.Windows.Forms.Label
		Private average As System.Windows.Forms.Label
		Private median As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private label6 As System.Windows.Forms.Label
		Private timeInTest As System.Windows.Forms.NumericUpDown
		Private refreshrate As System.Windows.Forms.NumericUpDown
		Private label7 As System.Windows.Forms.Label
		Private percent25 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private percent75 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
			Me.Icon = ico

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
            Me.StartTestbutton = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.totalCount = New System.Windows.Forms.Label
            Me.bucket3Count = New System.Windows.Forms.Label
            Me.bucket56Count = New System.Windows.Forms.Label
            Me.average = New System.Windows.Forms.Label
            Me.median = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.percent75 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.percent25 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.timeInTest = New System.Windows.Forms.NumericUpDown
            Me.refreshrate = New System.Windows.Forms.NumericUpDown
            Me.label7 = New System.Windows.Forms.Label
            Me.panel1.SuspendLayout()
            CType(Me.timeInTest, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.refreshrate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'StartTestbutton
            '
            Me.StartTestbutton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.StartTestbutton.Location = New System.Drawing.Point(264, 24)
            Me.StartTestbutton.Name = "StartTestbutton"
            Me.StartTestbutton.Size = New System.Drawing.Size(176, 32)
            Me.StartTestbutton.TabIndex = 0
            Me.StartTestbutton.Text = "Start Test"
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label2.Location = New System.Drawing.Point(16, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(112, 32)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Total number of random numbers"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label1.Location = New System.Drawing.Point(16, 48)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(112, 32)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Count in bucket 3"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label3.Location = New System.Drawing.Point(16, 80)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(112, 32)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Count in bucket 56"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label4.Location = New System.Drawing.Point(16, 112)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(112, 32)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Average value of all random numbers"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label5.Location = New System.Drawing.Point(16, 144)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(112, 32)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Median value of all random numbers"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'totalCount
            '
            Me.totalCount.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.totalCount.Location = New System.Drawing.Point(136, 16)
            Me.totalCount.Name = "totalCount"
            Me.totalCount.Size = New System.Drawing.Size(56, 32)
            Me.totalCount.TabIndex = 11
            Me.totalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'bucket3Count
            '
            Me.bucket3Count.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.bucket3Count.Location = New System.Drawing.Point(136, 48)
            Me.bucket3Count.Name = "bucket3Count"
            Me.bucket3Count.Size = New System.Drawing.Size(56, 32)
            Me.bucket3Count.TabIndex = 12
            Me.bucket3Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'bucket56Count
            '
            Me.bucket56Count.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.bucket56Count.Location = New System.Drawing.Point(136, 80)
            Me.bucket56Count.Name = "bucket56Count"
            Me.bucket56Count.Size = New System.Drawing.Size(56, 32)
            Me.bucket56Count.TabIndex = 13
            Me.bucket56Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'average
            '
            Me.average.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.average.Location = New System.Drawing.Point(136, 112)
            Me.average.Name = "average"
            Me.average.Size = New System.Drawing.Size(56, 32)
            Me.average.TabIndex = 14
            Me.average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'median
            '
            Me.median.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.median.Location = New System.Drawing.Point(136, 144)
            Me.median.Name = "median"
            Me.median.Size = New System.Drawing.Size(56, 32)
            Me.median.TabIndex = 15
            Me.median.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.panel1.Controls.Add(Me.percent75)
            Me.panel1.Controls.Add(Me.label11)
            Me.panel1.Controls.Add(Me.percent25)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.median)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.totalCount)
            Me.panel1.Controls.Add(Me.bucket3Count)
            Me.panel1.Controls.Add(Me.bucket56Count)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.average)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Location = New System.Drawing.Point(24, 16)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 248)
            Me.panel1.TabIndex = 16
            '
            'percent75
            '
            Me.percent75.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.percent75.Location = New System.Drawing.Point(136, 208)
            Me.percent75.Name = "percent75"
            Me.percent75.Size = New System.Drawing.Size(56, 32)
            Me.percent75.TabIndex = 19
            Me.percent75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label11.Location = New System.Drawing.Point(16, 208)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(112, 32)
            Me.label11.TabIndex = 18
            Me.label11.Text = "75 percentile level"
            Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'percent25
            '
            Me.percent25.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.percent25.Location = New System.Drawing.Point(136, 176)
            Me.percent25.Name = "percent25"
            Me.percent25.Size = New System.Drawing.Size(56, 32)
            Me.percent25.TabIndex = 17
            Me.percent25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.SystemColors.ControlLight
            Me.label9.Location = New System.Drawing.Point(16, 176)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(112, 32)
            Me.label9.TabIndex = 16
            Me.label9.Text = "25 percentile level"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label6.Location = New System.Drawing.Point(256, 86)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(100, 32)
            Me.label6.TabIndex = 17
            Me.label6.Text = "Number of seconds in test"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'timeInTest
            '
            Me.timeInTest.Location = New System.Drawing.Point(376, 88)
            Me.timeInTest.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
            Me.timeInTest.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.timeInTest.Name = "timeInTest"
            Me.timeInTest.Size = New System.Drawing.Size(64, 20)
            Me.timeInTest.TabIndex = 18
            Me.timeInTest.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'refreshrate
            '
            Me.refreshrate.Location = New System.Drawing.Point(376, 120)
            Me.refreshrate.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.refreshrate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.refreshrate.Name = "refreshrate"
            Me.refreshrate.Size = New System.Drawing.Size(64, 20)
            Me.refreshrate.TabIndex = 20
            Me.refreshrate.Value = New Decimal(New Integer() {100, 0, 0, 0})
            '
            'label7
            '
            Me.label7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label7.Location = New System.Drawing.Point(256, 120)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(100, 24)
            Me.label7.TabIndex = 19
            Me.label7.Text = "Refresh iteration"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(464, 286)
            Me.Controls.Add(Me.refreshrate)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.timeInTest)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.StartTestbutton)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Random Test Demo"
            Me.panel1.ResumeLayout(False)
            CType(Me.timeInTest, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.refreshrate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
			Application.Run(New Form1())
		End Sub

		'grouping support objects 
		Private theTable As Syncfusion.Grouping.Table
		Private engine As Syncfusion.Grouping.Engine

		'supports IBindingList
		Private intCollection As IntegerCollection

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'create an integer collection to hold the random numbers
			intCollection = New IntegerCollection()

			'create a new grouping engine and assign it a IList datasource
			engine = New Engine()
			engine.SetSourceList(intCollection)
			engine.RecordAsDisplayElements = True

			'get a reference to the underlying grouping Table
			theTable = engine.Table

			'group by the Value
			engine.TableDescriptor.GroupedColumns.Add("Value")

			'add the Summaries that we want
			engine.TableDescriptor.Summaries.Add("Int32Agg", "Value", SummaryType.Int32Aggregate)
			engine.TableDescriptor.Summaries.Add("Vect", "Value", SummaryType.DoubleVector)

		End Sub

		Private Sub StartTestbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartTestbutton.Click
			Me.totalCount.Text = ""
			Me.average.Text = ""
			Me.median.Text = ""
			Me.percent25.Text = ""
			Me.percent75.Text = ""
			Me.bucket56Count.Text = ""
			Me.bucket3Count.Text = ""

			intCollection.Clear()

			Dim refreshValue As Integer = CInt(Fix(Me.refreshrate.Value))

			Dim timeLimit As Integer = Environment.TickCount + 1000 * CInt(Fix(Me.timeInTest.Value))

			Dim count As Integer = 0

			Dim r As Random = New Random()

			Do While count < Integer.MaxValue AndAlso Environment.TickCount < timeLimit
				intCollection.Add(New WrappedInt(r.Next(100)))
				count += 1
				If (count Mod refreshValue) = 0 Then
					UpdateDisplay()
					Application.DoEvents()
				End If
			Loop
			UpdateDisplay()
		End Sub

		Private Sub UpdateDisplay()
			'bool summaryChange;
			Dim summaries As Syncfusion.Collections.BinaryTree.ITreeTableSummary() = Me.theTable.TopLevelGroup.GetSummaries(Me.theTable)
			Dim sdc As SummaryDescriptorCollection = Me.theTable.TableDescriptor.Summaries
			Dim index As Integer = sdc.IndexOf(sdc("Int32Agg"))
			Dim summaryInt32Agg As Int32AggregateSummary = TryCast(summaries(index), Int32AggregateSummary)

			Me.totalCount.Text = Me.theTable.Records.Count.ToString()
			Me.average.Text = summaryInt32Agg.Average.ToString("F2")

			index = sdc.IndexOf(sdc("Vect"))
			Dim summaryVector As DoubleVectorSummary = TryCast(summaries(index), DoubleVectorSummary)

			Me.median.Text = summaryVector.Median.ToString()
			Me.percent25.Text = summaryVector.Percentile25.ToString()
			Me.percent75.Text = summaryVector.Percentile75.ToString()

			index = sdc.IndexOf(sdc("Int32Agg"))

			Dim bucketCount As Integer = Me.theTable.TopLevelGroup.Groups.Count
			If bucketCount > 3 Then
				summaries = Me.theTable.TopLevelGroup.Groups(3).GetSummaries(Me.theTable)
				summaryInt32Agg = TryCast(summaries(index), Int32AggregateSummary)

				Me.bucket3Count.Text = summaryInt32Agg.Count.ToString()
			Else
				' Less than 3 buckets ...
				Me.bucket3Count.Text = "###"
			End If

			If bucketCount > 56 Then
				summaries = Me.theTable.TopLevelGroup.Groups(56).GetSummaries(Me.theTable)
				summaryInt32Agg = TryCast(summaries(index), Int32AggregateSummary)
				Me.bucket56Count.Text = summaryInt32Agg.Count.ToString()
			Else
				' Less than 56 buckets ...
				Me.bucket56Count.Text = "###"
			End If
		End Sub

	End Class
End Namespace
