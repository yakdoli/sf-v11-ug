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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Protected sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
		Protected sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
		Protected sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
		Protected sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
		Protected sqlConnection1 As System.Data.SqlClient.SqlConnection
		Protected sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
		Protected dataSet11 As CategoryView.DataSet1
		Private WithEvents reset As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnLoadXmlSchema As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnSaveXmlSchema As Syncfusion.Windows.Forms.ButtonAdv
		Protected gridGroupingControl1 As GridGroupingControl
		Private propertyGrid1 As PropertyGrid
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Dim msdeAvailable As Boolean = False
			If msdeAvailable Then
				Me.sqlDataAdapter1.Fill(Me.dataSet11)
				Me.dataSet11.WriteXml("NWCategories.xml", XmlWriteMode.WriteSchema)
			Else
				' Read from a xml file instead. 
				ReadXml(Me.dataSet11, "NWCategories.xml")
			End If


			' Knowing the initail state
			stream = New System.IO.MemoryStream()
			Me.gridGroupingControl1.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            'this.BackColor = Color.FromArgb(223, 227, 239);
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try
            Me.gridGroupingControl1.TableDescriptor.Appearance.AddNewRecordFieldCell.BackColor = Color.Orange
            Me.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.Orange
		End Sub
		Private stream As System.IO.MemoryStream

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			xmlFileName = "Common\data\grid\" & xmlFileName
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim gridColumnDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
			Dim gridColumnDescriptor2 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
			Me.dataSet11 = New CategoryView.DataSet1()
			Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
			Me.reset = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnLoadXmlSchema = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnSaveXmlSchema = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			' 
			' sqlSelectCommand1
			' 
			Me.sqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
			Me.sqlSelectCommand1.Connection = Me.sqlConnection1
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "data source=(local)\NETSDK;initial catalog=Northwind;integrated security=SSPI;per" & "sist security info=True;workstation id=localhost;packet size=4096"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' sqlInsertCommand1
			' 
			Me.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText")
			Me.sqlInsertCommand1.Connection = Me.sqlConnection1
			Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture")})
			' 
			' sqlUpdateCommand1
			' 
			Me.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText")
			Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
			Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID")})
			' 
			' sqlDeleteCommand1
			' 
			Me.sqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" & "e = @Original_CategoryName)"
			Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
			Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' sqlDataAdapter1
			' 
			Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
			Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
			Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
			Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
			Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
			' 
			' reset
			' 
			Me.reset.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.reset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.reset.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.reset.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.reset.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.reset.ForeColor = System.Drawing.Color.White
			Me.reset.Location = New System.Drawing.Point(340, 426)
			Me.reset.Name = "reset"
			Me.reset.Size = New System.Drawing.Size(130, 28)
			Me.reset.TabIndex = 12
			Me.reset.Text = "Reset Schema"
			Me.reset.UseVisualStyle = True
'			Me.reset.Click += New System.EventHandler(Me.reset_Click)
			' 
			' btnLoadXmlSchema
			' 
			Me.btnLoadXmlSchema.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnLoadXmlSchema.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.btnLoadXmlSchema.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.btnLoadXmlSchema.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnLoadXmlSchema.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnLoadXmlSchema.ForeColor = System.Drawing.Color.White
			Me.btnLoadXmlSchema.Location = New System.Drawing.Point(199, 426)
			Me.btnLoadXmlSchema.Name = "btnLoadXmlSchema"
			Me.btnLoadXmlSchema.Size = New System.Drawing.Size(130, 28)
			Me.btnLoadXmlSchema.TabIndex = 11
			Me.btnLoadXmlSchema.Text = "Load Xml Schema"
			Me.btnLoadXmlSchema.UseVisualStyle = True
'			Me.btnLoadXmlSchema.Click += New System.EventHandler(Me.btnLoadXmlSchema_Click)
			' 
			' btnSaveXmlSchema
			' 
			Me.btnSaveXmlSchema.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnSaveXmlSchema.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.btnSaveXmlSchema.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.btnSaveXmlSchema.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnSaveXmlSchema.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnSaveXmlSchema.ForeColor = System.Drawing.Color.White
			Me.btnSaveXmlSchema.Location = New System.Drawing.Point(60, 426)
			Me.btnSaveXmlSchema.Name = "btnSaveXmlSchema"
			Me.btnSaveXmlSchema.Size = New System.Drawing.Size(130, 28)
			Me.btnSaveXmlSchema.TabIndex = 10
			Me.btnSaveXmlSchema.Text = "Save Xml Schema"
			Me.btnSaveXmlSchema.UseVisualStyle = True
'			Me.btnSaveXmlSchema.Click += New System.EventHandler(Me.btnSaveXmlSchema_Click)
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.DataSource = Me.dataSet11.Categories
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.Location = New System.Drawing.Point(15, 16)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(504, 400)
            Me.gridGroupingControl1.TabIndex = 9
			gridColumnDescriptor1.MappingName = "CategoryID"
			gridColumnDescriptor1.Width = 80
			gridColumnDescriptor2.MappingName = "Description"
			gridColumnDescriptor2.Width = 250
			Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() { gridColumnDescriptor1, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CategoryName"), gridColumnDescriptor2, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Picture")})
			Me.gridGroupingControl1.TableOptions.RecordRowHeight = 57
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.propertyGrid1.BackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(533, 16)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(309, 400)
			Me.propertyGrid1.TabIndex = 13
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(858, 464)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.reset)
			Me.Controls.Add(Me.btnLoadXmlSchema)
			Me.Controls.Add(Me.btnSaveXmlSchema)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "XML Serialization Demo"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()

			Application.Run(New Form1())
		End Sub

		Private Sub btnSaveXmlSchema_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveXmlSchema.Click
				Dim xw As New XmlTextWriter("GridSchema.xml", System.Text.Encoding.UTF8)
				Dim xwApp As New XmlTextWriter("GridLooknFeel.xml", System.Text.Encoding.UTF8)
				xw.Formatting = System.Xml.Formatting.Indented
				Me.gridGroupingControl1.WriteXmlSchema(xw)
				Me.gridGroupingControl1.WriteXmlLookAndFeel(xwApp)
				xw.Close()
				xwApp.Close()
		End Sub

		Private Sub btnLoadXmlSchema_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoadXmlSchema.Click
			If File.Exists("GridSchema.xml") AndAlso File.Exists("GridLooknFeel.xml") Then
				Dim xr As XmlReader = New XmlTextReader("GridSchema.xml")
				Dim xrApp As XmlReader = New XmlTextReader("GridLooknFeel.xml")
				Me.gridGroupingControl1.ApplyXmlSchema(xr)
				Me.gridGroupingControl1.ApplyXmlLookAndFeel(xrApp)
				xr.Close()
				xrApp.Close()
			Else
				MessageBox.Show("Click ""Save Xml Schema"" button to serialize the grid.")
			End If
		End Sub

		Private Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
			Dim stream2 As New System.IO.MemoryStream(stream.ToArray())
			Me.gridGroupingControl1.ApplyXmlSchema(New XmlTextReader(stream2))
		End Sub
	End Class
