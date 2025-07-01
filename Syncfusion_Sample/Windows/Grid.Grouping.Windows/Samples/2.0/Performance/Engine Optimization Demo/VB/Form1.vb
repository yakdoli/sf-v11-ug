Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports System.IO

Namespace TestEngineOptimizations
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private _gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private components As IContainer
		Public Log As ListboxTextWriter
		Private groupBox1 As GroupBox
		Private label2 As Label
		Private label1 As Label
		Private WithEvents comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private panel1 As Panel
		Private listBox1 As ListBox

'INSTANT VB NOTE: The variable configurations was renamed since Visual Basic does not allow class members with the same name:
		Private configurations_Renamed As ConfigCollection

		Public Property Configurations() As ConfigCollection
			Get
				Return configurations_Renamed
			End Get
			Set(ByVal value As ConfigCollection)
				configurations_Renamed = value
			End Set
		End Property

		Friend Property gridGroupingControl1() As GridGroupingControl
			Get
				Return Me._gridGroupingControl1
			End Get
			Set(ByVal value As GridGroupingControl)
				If Me._gridGroupingControl1 IsNot value Then
					If Me._gridGroupingControl1 IsNot Nothing Then
						RemoveHandler _gridGroupingControl1.PropertyChanging, AddressOf _gridGroupingControl1_PropertyChanging
					End If
					Me._gridGroupingControl1 = value
					If Me._gridGroupingControl1 IsNot Nothing Then
						AddHandler _gridGroupingControl1.PropertyChanging, AddressOf _gridGroupingControl1_PropertyChanging
					End If
				End If
			End Set
		End Property


		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Try

				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			configurations_Renamed = New ConfigCollection()
			configurations_Renamed.Add(New Config("Reset Datasource"))
			configurations_Renamed.Add(New Config("Flat Virtual List, 30 million records, Virtual Mode"))
			configurations_Renamed.Add(New Config("Flat Virtual List, VirtualMode"))
			configurations_Renamed.Add(New Config("Flat Virtual List, No Optimizations"))
			configurations_Renamed.Add(New Config("Flat Virtual List, Using Custom Engine"))
			configurations_Renamed.Add(New Config("Flat Virtual List, Sorted"))
			configurations_Renamed.Add(New Config("Flat Virtual List, Grouped"))
			configurations_Renamed.Add(New Config("Flat Virtual List, Grouped, VerticalPixelScroll"))
			configurations_Renamed.Add(New Config("Flat DataView, VirtualMode, Pass-Through sorting enabled."))
			configurations_Renamed.Add(New Config("Flat DataView, VirtualMode, Pass-Through sorting disabled."))
			configurations_Renamed.Add(New Config("Flat DataView, Summaries."))
			configurations_Renamed.Add(New Config("Flat DataView, Grouped."))

'//			configurations.Add(new Config());

			InitializeSelectMenu()

			gridGroupingControl1 = New GridGroupingControl()

			Dim con As New Config("Flat Virtual List, 30 million records, Virtual Mode")
			con.ApplyTo(Me)
            gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Log = New ListboxTextWriter(Me.listBox1)
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


		Private Sub InitializeSelectMenu()
			Dim menuItemSelectConfig_Click As New System.EventHandler(AddressOf Me.menuItemSelectConfig_Click)
			Dim list As New ArrayList()

			For Each config As Config In configurations_Renamed
				list.Add(config.Name)

			Next config
			Me.comboBoxAdv2.DataSource = list
			Me.comboBoxAdv2.SelectedIndex = -1
		End Sub

		Private Sub menuItemSelectConfig_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim mi As MenuItem = CType(sender, MenuItem)
			Dim config As Config = Me.configurations_Renamed.Find(mi.Text)
			Log.WriteLine()
			Log.WriteLine("Select Configuration: " & mi.Text)
			Log.WriteLine(config.Comment)

			Dim time As Integer = Environment.TickCount

			Cursor.Current = Cursors.WaitCursor
			config.ApplyTo(Me)
			Me.Refresh()
			Cursor.Current = Cursors.Arrow

			Log.WriteLine("Elapsed Time: {0}", Environment.TickCount-time)
			gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro

		End Sub

		Private Sub LogMemoryUsage()
			' Force garbage collection and get used memory size
			GC.Collect()
			System.Threading.Thread.Sleep(10)
			GC.Collect()
			System.Threading.Thread.Sleep(100)
			GC.Collect()
			Log.Write("Optimizations for {0}: ", Me.gridGroupingControl1.TableDescriptor.Name)
			Log.Write("VirtualMode: {0}, ", Me.gridGroupingControl1.Table.VirtualMode)
			Log.Write("WithoutCounter: {0}, ", Me.gridGroupingControl1.Table.WithoutCounter)
			Log.WriteLine("RecordsAsDisplayElements: {0}, ", Me.gridGroupingControl1.Table.RecordsAsDisplayElements)
			Dim myProcess As Process = Process.GetCurrentProcess()
#If SyncfusionFramework2_0 Then
			Dim workingSetSizeinKiloBytes As Double = myProcess.WorkingSet64 \ 1000
#Else
			Dim workingSetSizeinKiloBytes As Double = myProcess.WorkingSet \ 1000
#End If
			Dim s As String = "Process's physical memory usage: " & workingSetSizeinKiloBytes.ToString() & " kb " & Constants.vbCrLf
			Log.WriteLine(s)
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
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.groupBox1.SuspendLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.comboBoxAdv2)
			Me.groupBox1.Controls.Add(Me.comboBoxAdv1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(423, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(291, 89)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Menu"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(14, 57)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(38, 15)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Select"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(14, 26)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(81, 15)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Configuration"
			' 
			' comboBoxAdv2
			' 
			Me.comboBoxAdv2.BackColor = System.Drawing.Color.White
			Me.comboBoxAdv2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxAdv2.Location = New System.Drawing.Point(105, 54)
			Me.comboBoxAdv2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.comboBoxAdv2.Name = "comboBoxAdv2"
			Me.comboBoxAdv2.Size = New System.Drawing.Size(172, 23)
			Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBoxAdv2.TabIndex = 1
'			Me.comboBoxAdv2.SelectedIndexChanged += New System.EventHandler(Me.comboBoxAdv2_SelectedIndexChanged)
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
			Me.comboBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxAdv1.Items.AddRange(New Object() { "Modify", "Save to", "Open", "Exit"})
			Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Modify"))
			Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Save to"))
			Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Open"))
			Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Exit"))
			Me.comboBoxAdv1.Location = New System.Drawing.Point(105, 19)
			Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Size = New System.Drawing.Size(172, 23)
			Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBoxAdv1.TabIndex = 0
'			Me.comboBoxAdv1.SelectedIndexChanged += New System.EventHandler(Me.comboBoxAdv1_SelectedIndexChanged)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.DimGray
			Me.panel1.Location = New System.Drawing.Point(411, 20)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1, 300)
			Me.panel1.TabIndex = 3
			' 
			' listBox1
			' 
			Me.listBox1.HorizontalScrollbar = True
			Me.listBox1.Location = New System.Drawing.Point(20, 327)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(704, 147)
			Me.listBox1.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(736, 489)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.groupBox1)
			Me.DropShadow = True
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.MinimizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Engine Optimization Demo"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private t As Timer = Nothing

		Private Sub _gridGroupingControl1_PropertyChanging(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
			If Log IsNot Nothing Then
				Log.WriteLine(e.ToString())
				If t IsNot Nothing Then
					RemoveHandler t.Tick, AddressOf t_Tick
					t.Dispose()
				End If
				t = New Timer()
				t.Interval = 100
				AddHandler t.Tick, AddressOf t_Tick
				t.Start()
			End If
		End Sub

		Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim t As Timer = CType(sender, Timer)
			RemoveHandler t.Tick, AddressOf t_Tick
			t.Dispose()
			Me.LogMemoryUsage()
		End Sub

		Private Sub menuItemModifyConfiguration_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim ce As New System.ComponentModel.Design.CollectionEditor(Me.configurations_Renamed.GetType())
			Dim esc As New Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(Nothing)
			Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(Me)("Configurations")
			Dim tdc As New Syncfusion.ComponentModel.TypeDescriptorContext(Me, pd)
			tdc.ServiceProvider = esc

			ce.EditValue(tdc, esc, Configurations)
			InitializeSelectMenu()
		End Sub
		Private stream As System.IO.MemoryStream
		Private Sub menuItemExitApp_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Application.Exit()
		End Sub

'INSTANT VB NOTE: The variable configCollectionSerializer was renamed since Visual Basic does not allow class members with the same name:
		Private Shared configCollectionSerializer_Renamed As XmlSerializer

		Private Shared ReadOnly Property ConfigCollectionSerializer() As XmlSerializer
			Get
				If configCollectionSerializer_Renamed Is Nothing Then
					configCollectionSerializer_Renamed = New XmlSerializer(GetType(ConfigCollection))
				End If
				Return configCollectionSerializer_Renamed
			End Get
		End Property

		Private Sub menuItemOpenFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Try
				Dim dlg As FileDialog = New OpenFileDialog()
				dlg.DefaultExt = "xml"
				If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim xr As New XmlTextReader(dlg.FileName)
					Me.configurations_Renamed = CType(ConfigCollectionSerializer.Deserialize(xr), ConfigCollection)
					Dim stream2 As New System.IO.MemoryStream(stream.ToArray())
					Me.gridGroupingControl1.ApplyXmlSchema(New XmlTextReader(stream2))
					xr.Close()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub menuItemSaveToFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Try
				Dim dlg As FileDialog = New SaveFileDialog()
				dlg.DefaultExt = "xml"
				If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim xw As New XmlTextWriter(dlg.FileName, System.Text.Encoding.UTF8)
					xw.Formatting = Formatting.Indented
					ConfigCollectionSerializer.Serialize(xw, configurations_Renamed)
					stream = New System.IO.MemoryStream()
					Me.gridGroupingControl1.WriteXmlSchema(New XmlTextWriter(stream, Nothing))

					xw.Close()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try

		End Sub

		Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			abtForm.ShowDialog()
		End Sub

		Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
			Select Case comboBoxAdv1.SelectedItem.ToString()
				Case "Modify"
					Dim ce As New System.ComponentModel.Design.CollectionEditor(Me.configurations_Renamed.GetType())
					Dim esc As New Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(Nothing)
					Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(Me)("Configurations")
					Dim tdc As New Syncfusion.ComponentModel.TypeDescriptorContext(Me, pd)
					tdc.ServiceProvider = esc

					ce.EditValue(tdc, esc, Configurations)
					InitializeSelectMenu()
				Case "Save to"
					Try
						Dim dlg As FileDialog = New SaveFileDialog()
						dlg.DefaultExt = "xml"
						If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
							Dim xw As New XmlTextWriter(dlg.FileName, System.Text.Encoding.UTF8)
							xw.Formatting = Formatting.Indented
							ConfigCollectionSerializer.Serialize(xw, configurations_Renamed)
							stream = New System.IO.MemoryStream()
							Me.gridGroupingControl1.WriteXmlSchema(New XmlTextWriter(stream, Nothing))

							xw.Close()
						End If
					Catch ex As Exception
						MessageBox.Show(ex.Message)
					End Try
				Case "Open"
					Try
						Dim dlg As FileDialog = New OpenFileDialog()
						dlg.DefaultExt = "xml"
						If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
							Dim xr As New XmlTextReader(dlg.FileName)
							Me.configurations_Renamed = CType(ConfigCollectionSerializer.Deserialize(xr), ConfigCollection)
							Dim stream2 As New System.IO.MemoryStream(stream.ToArray())
							Me.gridGroupingControl1.ApplyXmlSchema(New XmlTextReader(stream2))
							xr.Close()
						End If
					Catch ex As Exception
						MessageBox.Show(ex.Message)
					End Try
				Case "Exit"
					Application.Exit()
			End Select
		End Sub

		Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv2.SelectedIndexChanged
			If Log IsNot Nothing AndAlso comboBoxAdv2.SelectedItem IsNot Nothing Then
				'MenuItem mi = (ComboBox)sender;
				Dim config As Config = Me.configurations_Renamed.Find(comboBoxAdv2.SelectedItem.ToString())
				Log.WriteLine()
				Log.WriteLine("Select Configuration: " & comboBoxAdv2.SelectedItem.ToString())
				Log.WriteLine(config.Comment)
				Dim time As Integer = Environment.TickCount
				Cursor.Current = Cursors.WaitCursor
				config.ApplyTo(Me)
				Me.Refresh()
				Cursor.Current = Cursors.Arrow
				Log.WriteLine("Elapsed Time: {0}", Environment.TickCount - time)
				gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
				gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
				Me.BackColor = Color.White
			End If
		End Sub
	End Class

	#Region "TextWriter"
	Public Class ListboxTextWriter
		Inherits TextWriter
		Private lb As ListBox
		Private lastItem As String = ""

		Public Sub New(ByVal lb As ListBox)
			Me.lb = lb
		End Sub

		Public Overrides Overloads Sub Write(ByVal buffer() As Char, ByVal index As Integer, ByVal count As Integer)
			lastItem = New String(buffer, index, count).TrimEnd(ControlChars.Cr, ControlChars.Lf, ControlChars.NullChar)
			MyBase.Write(buffer, index, count)
			lb.Items.Add(lastItem)
			lb.SelectedIndex = lb.Items.Count - 1
		End Sub

		Public Overrides ReadOnly Property Encoding() As System.Text.Encoding
			Get
				Return System.Text.Encoding.Unicode
			End Get
		End Property
	End Class
	#End Region

End Namespace
