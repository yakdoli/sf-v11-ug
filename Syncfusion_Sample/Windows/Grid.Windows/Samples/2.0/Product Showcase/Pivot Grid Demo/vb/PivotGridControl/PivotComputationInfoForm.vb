Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace PivotGridLibrary
	Public Partial Class PivotComputationInfoForm
		Inherits Form
		Public Sub New()
			InitializeComponent()

			listBox1.DataSource = Choices

			AddHandler listBox1.SelectedIndexChanged, AddressOf listBox1_SelectedIndexChanged

		End Sub

		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim info As PivotComputationInfo = TryCast(listBox1.SelectedItem, PivotComputationInfo)
			If Not info Is Nothing Then
				Me.textBoxDescription.Text = String.Format(pivotGrid_Renamed.DefaultDescriptionFormat, info.CalculationName, ComputationInfo.FieldName)
			End If
		End Sub

		Private Sub PivotComputationInfoForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			MoveComputationInfoToForm()
		End Sub

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If DialogResult <> System.Windows.Forms.DialogResult.Cancel Then
				MoveComputationInfoFromForm()
			End If
		End Sub

		Private Sub MoveComputationInfoFromForm()
			Me.ComputationInfo.Description = textBoxDescription.Text
			Me.ComputationInfo.Format = textBoxFormat.Text
			Dim info As PivotComputationInfo = TryCast(listBox1.SelectedItem, PivotComputationInfo)
			If Not info Is Nothing Then
				Me.ComputationInfo.Summary = info.Summary
				Me.ComputationInfo.Pd = info.Pd
			 '   this.ComputationInfo.FieldName = info.FieldName;  cnnot change the FieldName
				Me.ComputationInfo.CalculationName = info.CalculationName
			End If

		End Sub

		Private Sub MoveComputationInfoToForm()
			textBoxDescription.Text = Me.ComputationInfo.Description
			textBoxFormat.Text = Me.ComputationInfo.Format
			labelName.Text = Me.ComputationInfo.FieldName
			Dim loc As Integer
			If Not Choices.Find(Me.ComputationInfo.CalculationName, loc) Is Nothing Then
				listBox1.SelectedIndex = loc
			End If
		End Sub

		Private choices_Renamed As PivotComputationInfoList

		Public Overridable ReadOnly Property Choices() As PivotComputationInfoList
			Get
				If choices_Renamed Is Nothing Then
					choices_Renamed = New PivotComputationInfoList()
					choices_Renamed.PopulateWithListChoices()
				End If
				Return choices_Renamed
			End Get

		End Property


		Private pivotGrid_Renamed As PivotGridControl

		Friend Property PivotGrid() As PivotGridControl
			Get
				Return pivotGrid_Renamed
			End Get
			Set(ByVal value As PivotGridControl)
				pivotGrid_Renamed = value
			End Set
		End Property

		Private computationInfo_Renamed As PivotComputationInfo

		Friend Property ComputationInfo() As PivotComputationInfo
			Get
				Return computationInfo_Renamed
			End Get
			Set(ByVal value As PivotComputationInfo)
				computationInfo_Renamed = value
			End Set
		End Property

		Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
			DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
			DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()
		End Sub

	End Class
End Namespace