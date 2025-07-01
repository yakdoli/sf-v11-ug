Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace PaletteGroupbar1
    Partial Public Class Form1
        Inherits MetroForm
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            AddHandler PaletteGroupbar1.GroupBarItemAdded, AddressOf paletteGroupBar1_GroupBarItemAdded
            AddHandler PaletteGroupbar1.NavigationPaneDropDownClick, AddressOf paletteGroupBar1_NavigationPaneDropDownClick
            'Load edp files
            PaletteGroupbar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Circuit Shapes.edp")
            PaletteGroupbar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Basic Shapes.edp")
            paletteGroupBar3.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\FloorPlan Shapes.edp")
            paletteGroupBar3.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")
            GroupBarAppearance()
            GroupViewAppearance()
            'Initialize a PaletteGroupbar events
            AddHandler PaletteGroupbar1.GroupBarItemRemoved, AddressOf paletteGroupBar1_GroupBarItemRemoved
            AddHandler PaletteGroupbar1.GroupBarItemSelected, AddressOf paletteGroupBar1_GroupBarItemSelected
            AddHandler PaletteGroupbar1.GroupBarItemSelectionChanging, AddressOf paletteGroupBar1_GroupBarItemSelectionChanging
            AddHandler PaletteGroupbar1.NodeDoubleClick, AddressOf paletteGroupBar1_NodeDoubleClick
            AddHandler PaletteGroupbar1.NodeSelected, AddressOf paletteGroupBar1_NodeSelected
            AddHandler PaletteGroupbar1.StateChanged, AddressOf paletteGroupBar1_StateChanged
            AddHandler PaletteGroupbar1.StateChanging, AddressOf paletteGroupBar1_StateChanging
            AddHandler PaletteGroupbar1.StyleChanged, AddressOf paletteGroupBar1_StyleChanged
            cmbVisualStyle.SelectedItem = PaletteGroupbar1.VisualStyle.ToString()
            cmbOffice2007Theme.SelectedIndex = 1
            cmbTextAlignment.SelectedItem = paletteGroupBar3.TextAlign.ToString()
            cmbGBBorder.SelectedItem = paletteGroupBar3.BorderStyle.ToString()
        End Sub

#Region "Event Handlers"

        Private Sub paletteGroupBar1_NavigationPaneDropDownClick(ByVal sender As Object, ByVal args As NavigationPaneDropDownClickEventArgs)
            txtEvents.Text &= "NavigationPaneDropDownClick event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_GroupBarItemAdded(ByVal sender As Object, ByVal args As GroupBarItemEventArgs)
            txtEvents.Text &= "GroupBarItemAdded event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            txtEvents.Text &= "StyleChanged event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_StateChanging(ByVal sender As Object, ByVal e As CancelEventArgs)
            txtEvents.Text &= "StateChanging event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_StateChanged(ByVal sender As Object, ByVal e As EventArgs)
            txtEvents.Text &= "StateChanged event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_NodeSelected(ByVal sender As Object, ByVal evtArgs As NodeEventArgs)
            txtEvents.Text &= "NodeSelected event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_NodeDoubleClick(ByVal sender As Object, ByVal evtArgs As NodeEventArgs)
            txtEvents.Text &= "NodeDoubleClick event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_GroupBarItemSelectionChanging(ByVal sender As Object, ByVal args As GroupBarItemSelectionChangingEventArgs)
            txtEvents.Text &= "GroupBarItemSelectionChanging event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_GroupBarItemSelected(ByVal sender As Object, ByVal e As EventArgs)
            txtEvents.Text &= "GroupBarItemSelected event fired." & Environment.NewLine
        End Sub

        Private Sub paletteGroupBar1_GroupBarItemRemoved(ByVal sender As Object, ByVal args As GroupBarItemEventArgs)
            txtEvents.Text &= "GroupBarItemRemoved event fired." & Environment.NewLine
        End Sub

#End Region

#Region "Button Click Events"
        Private Sub btnAddPalette_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPalette.Click
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "PaletteFiles(*.edp)|*.edp"
            If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                PaletteGroupbar1.LoadPalette(openFileDialog.FileName)
                GroupBarAppearance()
            End If
        End Sub

        Private Sub btnRemovePalette_Click(ByVal sender As Object, ByVal e As EventArgs)
            If PaletteGroupbar1.SelectedNode IsNot Nothing Then
                PaletteGroupbar1.CurrentSymbolPalette.RemoveChild(PaletteGroupbar1.SelectedNode)
            End If
        End Sub

        Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            txtEvents.Clear()
        End Sub

#End Region

#Region "SelectedIndex Changed events"

        Private Sub cboVisualStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbVisualStyle.SelectedIndexChanged
            If cmbVisualStyle.SelectedIndex <> -1 Then
                If cmbVisualStyle.SelectedItem.ToString() = "Office2007" Then
                    cmbOffice2007Theme.Enabled = True
                Else
                    cmbOffice2007Theme.Enabled = False
                End If
                PaletteGroupbar1.VisualStyle = CType(System.Enum.Parse(GetType(VisualStyle), cmbVisualStyle.SelectedItem.ToString()), VisualStyle)
            End If
        End Sub

        Private Sub cboOffice2007Theme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbOffice2007Theme.SelectedIndexChanged
            If cmbOffice2007Theme.SelectedIndex <> -1 Then
                PaletteGroupbar1.Office2007Theme = CType(System.Enum.Parse(GetType(Office2007Theme), cmbOffice2007Theme.SelectedItem.ToString()), Office2007Theme)
            End If
        End Sub

        Private Sub cmbPopupResize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPopupResize.SelectedIndexChanged
            Me.paletteGroupBar1.PopupResizeMode = CType(System.Enum.Parse(GetType(PopupResizeMode), Me.cmbPopupResize.SelectedItem.ToString()), PopupResizeMode)
        End Sub

        Private Sub cmbTextAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTextAlignment.SelectedIndexChanged
            Me.paletteGroupBar3.TextAlign = CType(System.Enum.Parse(GetType(TextAlignment), Me.cmbTextAlignment.SelectedItem.ToString(), True), TextAlignment)
        End Sub

        Private Sub cmbGBBorder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGBBorder.SelectedIndexChanged
            Me.paletteGroupBar3.BorderStyle = CType(System.Enum.Parse(GetType(BorderStyle), Me.cmbGBBorder.SelectedItem.ToString(), True), BorderStyle)
        End Sub

#End Region

#Region "Checkbox CheckedChanged Events"

        Private Sub cbStackedMode_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbStackedMode.CheckedChanged
            PaletteGroupbar1.StackedMode = cbStackedMode.Checked
            cbChevron.Enabled = cbStackedMode.Checked
            cbCollapse.Enabled = cbStackedMode.Checked
        End Sub

        Private Sub cbChevron_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbChevron.CheckedChanged
            PaletteGroupbar1.ShowChevron = cbChevron.Checked
        End Sub

        Private Sub cbAllowCollapse_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbAllowCollapse.CheckedChanged
            Me.paletteGroupBar1.AllowCollapse = cbAllowCollapse.Checked
        End Sub

        Private Sub cbCollapse_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbCollapse.CheckedChanged
            Me.paletteGroupBar1.Collapsed = cbCollapse.Checked
        End Sub

        Private Sub cbShowGripper_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbShowGripper.CheckedChanged
            Me.paletteGroupBar1.ShowPopupGripper = cbShowGripper.Checked
        End Sub

        Private Sub cbAutoClose_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbAutoClose.CheckedChanged
            Me.paletteGroupBar1.PopupAutoClose = Me.cbAutoClose.Checked
        End Sub

        Private Sub cbThemesEnabled_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbThemesEnabled.CheckedChanged
            Me.paletteGroupBar1.ThemesEnabled = cbThemesEnabled.Checked
        End Sub

        Private Sub cbDragNode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDragNode.CheckedChanged
            Me.paletteGroupBar1.ShowDragNodeCue = cbDragNode.Checked
        End Sub

        Private Sub cbAnimatedSelection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAnimatedSelection.CheckedChanged
            Me.paletteGroupBar3.AnimatedSelection = Me.cbAnimatedSelection.Checked
        End Sub

        Private Sub cbIntegratedScrolling_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbIntegratedScrolling.CheckedChanged
            Me.paletteGroupBar3.IntegratedScrolling = Me.cbIntegratedScrolling.Checked
        End Sub

        Private Sub cbflatLook_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbflatLook.CheckedChanged
            Me.paletteGroupBar3.FlatLook = Me.cbflatLook.Checked
        End Sub

        Private Sub cbDrawClientBorder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDrawClientBorder.CheckedChanged
            Me.paletteGroupBar3.DrawClientBorder = Me.cbDrawClientBorder.Checked
            For Each gbItem As GroupBarItem In Me.paletteGroupBar3.GroupBarItems
                gbItem.ClientBorderColors = New BorderColors(cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor, cpBack.SelectedColor)
            Next gbItem
        End Sub

        Private Sub cbEditMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEditMode.CheckedChanged
            For Each item As GroupBarItem In paletteGroupBar3.GroupBarItems
                Dim groupView As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
                groupView.EditMode = cbEditMode.Checked
            Next item
        End Sub

#End Region

        Private Sub numericCollapsedWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericCollapsedWidth.ValueChanged
            Me.paletteGroupBar1.CollapsedWidth = CInt(Fix(Me.numericCollapsedWidth.Value))
        End Sub

        Private Sub cpBack_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpBack.ColorSelected
            Me.paletteGroupBar3.BackColor = cpBack.SelectedColor
            For Each gbItem As GroupBarItem In Me.paletteGroupBar3.GroupBarItems
                gbItem.BackColor = cpBack.SelectedColor
            Next gbItem
        End Sub

#Region "Class Helper Methods"

        Private Sub GroupBarAppearance()
            Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
            For Each item As GroupBarItem In PaletteGroupbar1.GroupBarItems
                'palette view settings
                If TypeOf item.Client Is PaletteGroupView Then
                    Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
                    view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
                    view.ForeColor = Color.Black
                    view.FlowView = True
                    view.ShowToolTips = True
                    view.ShowFlowViewItemText = True
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118)
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149)
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184)
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
                    view.FlowViewItemTextLength = 80
                    view.BackColor = Color.White
                    view.TextWrap = True
                    view.FlatLook = True
                    view.BorderStyle = BorderStyle.FixedSingle

                End If
            Next item
        End Sub

        Private Sub GroupViewAppearance()
            For Each item As GroupBarItem In paletteGroupBar3.GroupBarItems
                Dim groupView As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
                groupView.SmallImageView = True
                groupView.BackColor = Color.White
            Next item
        End Sub

        Private Sub GroupViewAppearance1(ByVal Name As String)
            For Each item As GroupBarItem In PaletteGroupbar1.GroupBarItems
                Dim groupView As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
                Select Case Name
                    Case "cbFlowView"
                        If cbFlowView.Checked Then
                            groupView.FlowView = True
                            cbFlowViewText.Enabled = True
                            numericUpDown1.Enabled = True
                        Else
                            groupView.FlowView = False
                            cbFlowViewText.Enabled = False
                            numericUpDown1.Enabled = False
                        End If
                    Case "cbButtonView"
                        If cbButtonView.Checked Then
                            groupView.ButtonView = True
                        Else
                            groupView.ButtonView = False
                        End If
                    Case "cbFlowViewText"
                        If cbFlowViewText.Checked Then
                            groupView.ShowFlowViewItemText = True
                        Else
                            groupView.ShowFlowViewItemText = False
                        End If
                    Case "cbSmallImageView"
                        If cbSmallImageView.Checked Then
                            groupView.SmallImageView = True
                        Else
                            groupView.SmallImageView = False
                        End If
                    Case "numericUpDown1"
                        groupView.FlowViewItemTextLength = Convert.ToInt32(numericUpDown1.Value)
                End Select

            Next item
        End Sub

#End Region

        Private Sub cbFlowView_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbFlowView.CheckedChanged
            GroupViewAppearance1(cbFlowView.Name)
        End Sub

        Private Sub cbButtonView_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbButtonView.CheckedChanged
            GroupViewAppearance1(cbButtonView.Name)
        End Sub

        Private Sub cbFlowViewText_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbFlowViewText.CheckedChanged
            GroupViewAppearance1(cbFlowViewText.Name)
        End Sub

        Private Sub cbSmallImageView_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles cbSmallImageView.CheckedChanged
            GroupViewAppearance1(cbSmallImageView.Name)
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            GroupViewAppearance1(numericUpDown1.Name)
        End Sub


    End Class
End Namespace