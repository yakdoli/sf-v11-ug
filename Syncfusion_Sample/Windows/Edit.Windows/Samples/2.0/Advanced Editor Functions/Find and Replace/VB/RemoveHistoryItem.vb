Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace FindReplaceDemo
	''' <summary>
	''' Summary description for RemoveHistoryItem.
	''' </summary>
	Public Class RemoveHistoryItem : Inherits System.Windows.Forms.Form
		Private HistoryList As System.Windows.Forms.ListBox
		Private RemoveList As System.Windows.Forms.ListBox
		Private WithEvents btnOk As System.Windows.Forms.Button
		Private myArrayList As System.Collections.ArrayList
		Private myRemoveList As System.Collections.ArrayList
		Private BtnCancel As System.Windows.Forms.Button
		Private WithEvents btnCancelRemoved As System.Windows.Forms.Button
        Private collection As System.Collections.ICollection
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents BtnRemoveItem As System.Windows.Forms.Button
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal ar As System.Collections.ArrayList)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.myArrayList=ar
			'this.myRemoveList=new ArrayList();

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
            Me.HistoryList = New System.Windows.Forms.ListBox
            Me.RemoveList = New System.Windows.Forms.ListBox
            Me.btnOk = New System.Windows.Forms.Button
            Me.BtnCancel = New System.Windows.Forms.Button
            Me.BtnRemoveItem = New System.Windows.Forms.Button
            Me.btnCancelRemoved = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'HistoryList
            '
            Me.HistoryList.Location = New System.Drawing.Point(24, 32)
            Me.HistoryList.Name = "HistoryList"
            Me.HistoryList.Size = New System.Drawing.Size(136, 121)
            Me.HistoryList.TabIndex = 0
            '
            'RemoveList
            '
            Me.RemoveList.Location = New System.Drawing.Point(208, 32)
            Me.RemoveList.Name = "RemoveList"
            Me.RemoveList.Size = New System.Drawing.Size(128, 121)
            Me.RemoveList.TabIndex = 1
            '
            'btnOk
            '
            Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOk.Location = New System.Drawing.Point(352, 48)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(96, 28)
            Me.btnOk.TabIndex = 2
            Me.btnOk.Text = "Remove"
            '
            'BtnCancel
            '
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.Location = New System.Drawing.Point(352, 96)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(96, 28)
            Me.BtnCancel.TabIndex = 3
            Me.BtnCancel.Text = "Cancel"
            '
            'BtnRemoveItem
            '
            Me.BtnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnRemoveItem.Location = New System.Drawing.Point(168, 48)
            Me.BtnRemoveItem.Name = "BtnRemoveItem"
            Me.BtnRemoveItem.Size = New System.Drawing.Size(32, 24)
            Me.BtnRemoveItem.TabIndex = 4
            Me.BtnRemoveItem.Text = ">>"
            '
            'btnCancelRemoved
            '
            Me.btnCancelRemoved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelRemoved.Location = New System.Drawing.Point(168, 88)
            Me.btnCancelRemoved.Name = "btnCancelRemoved"
            Me.btnCancelRemoved.Size = New System.Drawing.Size(32, 24)
            Me.btnCancelRemoved.TabIndex = 5
            Me.btnCancelRemoved.Text = "<<"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(24, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 23)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Existing "
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(208, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(112, 24)
            Me.label2.TabIndex = 7
            Me.label2.Text = "Remove List"
            '
            'RemoveHistoryItem
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(464, 166)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnCancelRemoved)
            Me.Controls.Add(Me.BtnRemoveItem)
            Me.Controls.Add(Me.BtnCancel)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.RemoveList)
            Me.Controls.Add(Me.HistoryList)
            Me.MaximizeBox = False
            Me.Name = "RemoveHistoryItem"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "RemoveHistoryItem"
            Me.ResumeLayout(False)

        End Sub
		#End Region

        Private Sub RemoveHistoryItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim item As Object
            For Each item In Me.myArrayList
                Me.HistoryList.Items.Add(item)
            Next item

        End Sub

        Private Sub Remove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
            If Not HistoryList.SelectedItem Is Nothing Then
                Me.RemoveList.Items.Add(Me.HistoryList.SelectedItem)
                Me.HistoryList.Items.Remove(Me.HistoryList.SelectedItem)
            End If
        End Sub

        Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
            collection = Me.RemoveList.Items
            Me.myRemoveList = New ArrayList(collection)
        End Sub

        Private Sub btnCancelRemoved_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelRemoved.Click
            If Not RemoveList.SelectedItem Is Nothing Then
                Me.HistoryList.Items.Add(Me.RemoveList.SelectedItem)
                Me.RemoveList.Items.Remove(Me.RemoveList.SelectedItem)
            End If
        End Sub

        Public ReadOnly Property RemoveListItems() As System.Collections.ArrayList
            Get
                If Not Me.RemoveList.Items Is Nothing Then
                    Return Me.myRemoveList
                Else
                    Return Nothing
                End If
            End Get
        End Property
    End Class
End Namespace
