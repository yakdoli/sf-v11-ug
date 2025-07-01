Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Globalization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace EditorControls
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits Office2007Form
		#Region "Declarations"
		Private currencyTextBox1 As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label4 As System.Windows.Forms.Label
		Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private label6 As System.Windows.Forms.Label
		Private WithEvents comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label7 As System.Windows.Forms.Label
		Private WithEvents integerTextBox1 As Syncfusion.Windows.Forms.Tools.IntegerTextBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet11 As EditorControls.DataSet1
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private dataGrid1 As System.Windows.Forms.DataGrid
		Private tabControlAdv1 As TabControlAdv
		Private tabPageAdv1 As TabPageAdv
		Private label34 As Label
		Private label13 As Label
		Private checkBox5 As CheckBox
		Private label35 As Label
		Private label26 As Label
		Private label11 As Label
		Private label9 As Label
		Private checkBox9 As CheckBox
		Private checkBox8 As CheckBox
		Private checkBox7 As CheckBox
		Private checkBox6 As CheckBox
		Private checkBox4 As CheckBox
		Private checkBox3 As CheckBox
		Private checkBox10 As CheckBox
		Private checkBox11 As CheckBox
		Private colorDialog1 As ColorDialog
		Private label5 As Label
		Private label2 As Label
		Private label8 As Label
		Private label12 As Label
		Private tabPageAdv2 As TabPageAdv
		Private label17 As Label
		Private WithEvents comboBox1 As ComboBox
		Private label15 As Label
		Private label16 As Label
		Private label19 As Label
		Private label20 As Label
		Private label18 As Label
		Private WithEvents comboBox2 As ComboBox
		Private WithEvents radFinancial As RadioButton
		Private WithEvents radWinStd As RadioButton
		Private WithEvents checkBox12 As CheckBox
		Private WithEvents radWinXP As RadioButton
		Private WithEvents radOfficeXP As RadioButton
		Private WithEvents radOffice2003 As RadioButton
		Private WithEvents radOffice2007 As RadioButton
		Private WithEvents radOffice2000 As RadioButton
		Private WithEvents radClassic As RadioButton
		Private label21 As Label
		Private label22 As Label
		Private label23 As Label
		Private WithEvents cboButtonType As ComboBox
		Private WithEvents checkBox13 As CheckBox
		Private tabPageAdv3 As TabPageAdv
		Private WithEvents comboBox3 As ComboBox
		Private label30 As Label
		Private label29 As Label
		Private label28 As Label
		Private WithEvents comboBox4 As ComboBox
		Private WithEvents radioButton1 As RadioButton
		Private WithEvents radioButton2 As RadioButton
		Private WithEvents checkBox14 As CheckBox
		Private WithEvents checkBox15 As CheckBox
		Private label36 As Label
		Private toolTip1 As ToolTip
		Private WithEvents radioButton5 As RadioButton
		Private WithEvents radioButton4 As RadioButton
		Private WithEvents radioButton3 As RadioButton
		Private doubleTextBox1 As DoubleTextBox
		Private integerTextBox2 As IntegerTextBox
		Private WithEvents radioButton6 As RadioButton
		Private WithEvents radioButton7 As RadioButton
		Private label40 As Label
		Private WithEvents comboBox5 As ComboBox
		Private WithEvents comboBox6 As ComboBox
		Private label42 As Label
		Private label43 As Label
		Private label44 As Label
		Private WithEvents checkBox16 As CheckBox
		Private WithEvents textBox3 As TextBox
		Private label55 As Label
		Private label54 As Label
		Private WithEvents integerTextBox3 As IntegerTextBox
		Private label53 As Label
		Private WithEvents textBox2 As TextBox
		Private label52 As Label
		Private label46 As Label
		Private label58 As Label
		Private label61 As Label
		Private label62 As Label
		Private label69 As Label
		Private WithEvents textBox4 As TextBox
		Private label67 As Label
		Private label68 As Label
		Private WithEvents numericUpDownExt1 As NumericUpDownExt
		Private label70 As Label
		Private WithEvents integerTextBox7 As IntegerTextBox
		Private label72 As Label
		Private WithEvents textBox6 As TextBox
		Private label73 As Label
		Private WithEvents numericUpDownExt2 As NumericUpDownExt
		Private WithEvents numericUpDownExt3 As NumericUpDownExt
		Private WithEvents numericUpDownExt4 As NumericUpDownExt
		Private WithEvents numericUpDownExt5 As NumericUpDownExt
		Private label76 As Label
		Private percentTextBox1 As PercentTextBox
		Private label82 As Label
		Private label83 As Label
		Private WithEvents checkBox18 As CheckBox
		Private WithEvents checkBox17 As CheckBox
		Private label86 As Label
		Private label85 As Label
		Private groupBox1 As GroupBox
		Private label84 As Label
		Private label87 As Label
		Private label88 As Label
		Private label89 As Label
		Private label91 As Label
		Private label92 As Label
		Private domainUpDownExt1 As DomainUpDownExt
		Private WithEvents checkBox19 As CheckBox
		Private label27 As Label
		Private label32 As Label
		Private dataGrid2 As DataGrid
		Private WithEvents NegativeColorEdit As ButtonEdit
		Private buttonEditChildButton1 As ButtonEditChildButton
		Private textBoxExt2 As TextBoxExt
		Private WithEvents PositiveColorEdit As ButtonEdit
		Private buttonEditChildButton5 As ButtonEditChildButton
		Private textBoxExt1 As TextBoxExt
		Private tabPageAdv5 As TabPageAdv
		Private WithEvents buttonEdit1 As ButtonEdit
		Private buttonEditChildButton2 As ButtonEditChildButton
		Private textBoxExt3 As TextBoxExt
		Private WithEvents checkBox21 As CheckBox
		Private textBoxExt4 As TextBoxExt
		Private label103 As Label
		Private label104 As Label
		Private WithEvents radioButton10 As RadioButton
		Private WithEvents radioButton11 As RadioButton
		Private label105 As Label
		Private WithEvents comboBox10 As ComboBox
		Private WithEvents comboBox11 As ComboBox
		Private label106 As Label
		Private label107 As Label
		Private WithEvents comboBox12 As ComboBox
		Private WithEvents comboBox9 As ComboBox
		Private label101 As Label
		Private WithEvents comboBox8 As ComboBox
		Private label100 As Label
		Private label108 As Label
		Private WithEvents checkBox25 As CheckBox
		Private WithEvents checkBox24 As CheckBox
		Private WithEvents checkBox23 As CheckBox
		Private WithEvents checkBox22 As CheckBox
		Private label109 As Label
		Private label110 As Label
		Private WithEvents textBox11 As TextBox
		Private label102 As Label
		Private WithEvents checkBox26 As CheckBox
		Private label113 As Label
		Private label114 As Label
		Private label111 As Label
		Private label112 As Label
		Private WithEvents buttonEdit2 As ButtonEdit
		Private buttonEditChildButton4 As ButtonEditChildButton
		Private label115 As Label
		Private tabPageAdv6 As TabPageAdv
		Private WithEvents editableList2 As EditableList
		Private gradientPanel3 As GradientPanel
		Private label116 As Label
		Private editableList1 As EditableList
		Private label118 As Label
		Private label119 As Label
		Private label120 As Label
		Private label121 As Label
		Private gradientPanel4 As GradientPanel
		Private label122 As Label
		Private WithEvents comboBox13 As ComboBox
		Private label117 As Label
		Private label123 As Label
		Private WithEvents checkBox27 As CheckBox
		Private WithEvents checkBox28 As CheckBox
		Private WithEvents DomainBorderColorEdit As ButtonEdit
		Private buttonEditChildButton6 As ButtonEditChildButton
		Private label31 As Label
		Private WithEvents treeViewAdv1 As TreeViewAdv
		Private gradientPanel1 As GradientPanel
		Private gradientPanel5 As GradientPanel
		Private gradientPanel6 As GradientPanel
		Private label33 As Label
		Private label37 As Label
		Private gradientPanel7 As GradientPanel
		Private gradientPanel8 As GradientPanel
		Private label38 As Label
		Private label56 As Label
		Private gradientPanel11 As GradientPanel
		Private gradientPanel9 As GradientPanel
		Private gradientPanel12 As GradientPanel
		Private label45 As Label
		Private label47 As Label
		Private gradientPanel10 As GradientPanel
		Private label57 As Label
		Private label63 As Label
		Private gradientLabel1 As GradientLabel
		Private label48 As Label
		Private label49 As Label
		Private label1 As Label
		Private label10 As Label
		Private label50 As Label
		Private label51 As Label
		Private label39 As Label
		Private label41 As Label
		Private label66 As Label
		Private numericUpDownExt7 As NumericUpDownExt
		Private label24 As Label
		Private label25 As Label
		Private label65 As Label
		Private groupBox3 As GroupBox
		Private groupBox2 As GroupBox
		Private groupBox4 As GroupBox
		Private groupBox5 As GroupBox
		Private label14 As Label
		Private WithEvents checkBox20 As CheckBox
		Private label59 As Label
		Private label60 As Label
		Private panel1 As Panel
		Private WithEvents currencyEdit1 As CurrencyEdit
		Private tabPageAdv4 As TabPageAdv
		Private WithEvents buttonEdit3 As ButtonEdit
		Private buttonEditChildButton3 As ButtonEditChildButton
		Private label80 As Label
		Private label81 As Label
		Private label90 As Label
		Private WithEvents comboBox7 As ComboBox
		Private label93 As Label
		Private label94 As Label
		Private WithEvents radioButton8 As RadioButton
		Private WithEvents buttonEdit4 As ButtonEdit
		Private buttonEditChildButton7 As ButtonEditChildButton
		Private WithEvents radioButton9 As RadioButton
		Private WithEvents buttonEdit5 As ButtonEdit
		Private buttonEditChildButton8 As ButtonEditChildButton
		Private label95 As Label
		Private WithEvents comboBox14 As ComboBox
		Private label96 As Label
		Private label97 As Label
		Private label71 As Label
		Private label74 As Label
		Private groupBox6 As GroupBox
		Private maskedEditBox1 As MaskedEditBox
		Private label64 As Label
		Private label98 As Label
		Private WithEvents comboBox15 As ComboBox
		Private label79 As Label
		Private WithEvents checkBox29 As CheckBox
		Private WithEvents comboBox16 As ComboBox
		Private WithEvents checkBox30 As CheckBox
		Private WithEvents comboBox17 As ComboBox
		Private label125 As Label
		Private label126 As Label
		Private WithEvents comboBox18 As ComboBox
		Private label75 As Label
		Private WithEvents comboBox19 As ComboBox
		Private label77 As Label
		Private label78 As Label
		Private WithEvents button1 As Button
		Private WithEvents bannerClrEdit As ButtonEdit
		Private buttonEditChildButton9 As ButtonEditChildButton
		Private textBoxExt5 As TextBoxExt
		Private rdoFocus As RadioButton
		Private rdoEdit As RadioButton
		Private txtBanner As TextBox
		Private label127 As Label
		Private label124 As Label
		Private label99 As Label
		Private bannerTextProvider1 As BannerTextProvider
		Private label128 As Label
		Private label129 As Label
		Private cmbMode As ComboBoxAdv
		Private txtBnr As TextBox
		Private label130 As Label
		Private label131 As Label
		Private label132 As Label
		Private WithEvents btnSetBanner As Button
		Private WithEvents bannerClr As ButtonEdit
		Private buttonEditChildButton10 As ButtonEditChildButton
		Private textBoxExt6 As TextBoxExt
		Private textBanner As TextBox
		Private label136 As Label
		Private label135 As Label
		Private label134 As Label
		Private label133 As Label
		Private WithEvents bEditBanner As ButtonEdit
		Private textBoxExt7 As TextBoxExt
		Private comboMode As ComboBoxAdv
		Private buttonEditChildButton11 As ButtonEditChildButton
        Private WithEvents buttonBanner As Button
        Private WithEvents RadioButton12 As System.Windows.Forms.RadioButton
        Private WithEvents NumericUpDownExt6 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
        Private WithEvents Label137 As System.Windows.Forms.Label
        Private WithEvents NumericUpDownExt8 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
        Private WithEvents Label138 As System.Windows.Forms.Label
        Private WithEvents NumericUpDownExt9 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
        Private WithEvents Label139 As System.Windows.Forms.Label
        Private Dt As DataTable
        Friend WithEvents CheckBox32 As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox31 As System.Windows.Forms.CheckBox
        Private WithEvents chkPullCharOnDelete As System.Windows.Forms.CheckBox

        Private components As System.ComponentModel.IContainer
#End Region

#Region "Form constructor and Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
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

#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim BannerTextInfo8 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim BannerTextInfo1 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim BannerTextInfo2 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim BannerTextInfo3 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim BannerTextInfo4 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim BannerTextInfo9 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim BannerTextInfo10 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Dim TreeNodeAdvStyleInfo4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo
            Dim TreeNodeAdvStyleInfo5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo
            Dim TreeNodeAdvStyleInfo6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo
            Dim TreeNodeAdv7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv8 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv9 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv10 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv11 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv12 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.currencyTextBox1 = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox
            Me.integerTextBox1 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox
            Me.label7 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label3 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label6 = New System.Windows.Forms.Label
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel11 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.NumericUpDownExt6 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.Label137 = New System.Windows.Forms.Label
            Me.bannerClr = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton10 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt6 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.btnSetBanner = New System.Windows.Forms.Button
            Me.cmbMode = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.txtBnr = New System.Windows.Forms.TextBox
            Me.label130 = New System.Windows.Forms.Label
            Me.label131 = New System.Windows.Forms.Label
            Me.label132 = New System.Windows.Forms.Label
            Me.label128 = New System.Windows.Forms.Label
            Me.label129 = New System.Windows.Forms.Label
            Me.checkBox20 = New System.Windows.Forms.CheckBox
            Me.NegativeColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.label2 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label42 = New System.Windows.Forms.Label
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.label46 = New System.Windows.Forms.Label
            Me.label58 = New System.Windows.Forms.Label
            Me.label61 = New System.Windows.Forms.Label
            Me.label62 = New System.Windows.Forms.Label
            Me.radioButton6 = New System.Windows.Forms.RadioButton
            Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.radioButton7 = New System.Windows.Forms.RadioButton
            Me.PositiveColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton5 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.label40 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.checkBox16 = New System.Windows.Forms.CheckBox
            Me.label8 = New System.Windows.Forms.Label
            Me.label43 = New System.Windows.Forms.Label
            Me.label44 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.gradientPanel9 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label1 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.gradientPanel12 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label45 = New System.Windows.Forms.Label
            Me.label47 = New System.Windows.Forms.Label
            Me.gradientPanel7 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label59 = New System.Windows.Forms.Label
            Me.integerTextBox2 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox
            Me.label50 = New System.Windows.Forms.Label
            Me.label51 = New System.Windows.Forms.Label
            Me.gradientPanel10 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label57 = New System.Windows.Forms.Label
            Me.label63 = New System.Windows.Forms.Label
            Me.label69 = New System.Windows.Forms.Label
            Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.label68 = New System.Windows.Forms.Label
            Me.textBox4 = New System.Windows.Forms.TextBox
            Me.numericUpDownExt3 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.label67 = New System.Windows.Forms.Label
            Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label60 = New System.Windows.Forms.Label
            Me.label48 = New System.Windows.Forms.Label
            Me.label49 = New System.Windows.Forms.Label
            Me.percentTextBox1 = New Syncfusion.Windows.Forms.Tools.PercentTextBox
            Me.gradientPanel8 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label38 = New System.Windows.Forms.Label
            Me.label56 = New System.Windows.Forms.Label
            Me.label73 = New System.Windows.Forms.Label
            Me.textBox6 = New System.Windows.Forms.TextBox
            Me.label72 = New System.Windows.Forms.Label
            Me.numericUpDownExt5 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.integerTextBox7 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox
            Me.label76 = New System.Windows.Forms.Label
            Me.label70 = New System.Windows.Forms.Label
            Me.numericUpDownExt4 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label39 = New System.Windows.Forms.Label
            Me.label41 = New System.Windows.Forms.Label
            Me.doubleTextBox1 = New Syncfusion.Windows.Forms.Tools.DoubleTextBox
            Me.gradientPanel6 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label33 = New System.Windows.Forms.Label
            Me.label37 = New System.Windows.Forms.Label
            Me.label52 = New System.Windows.Forms.Label
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.label53 = New System.Windows.Forms.Label
            Me.integerTextBox3 = New Syncfusion.Windows.Forms.Tools.IntegerTextBox
            Me.label54 = New System.Windows.Forms.Label
            Me.label55 = New System.Windows.Forms.Label
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.numericUpDownExt2 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.buttonBanner = New System.Windows.Forms.Button
            Me.comboMode = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.bEditBanner = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton11 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt7 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBanner = New System.Windows.Forms.TextBox
            Me.label136 = New System.Windows.Forms.Label
            Me.label135 = New System.Windows.Forms.Label
            Me.label134 = New System.Windows.Forms.Label
            Me.label133 = New System.Windows.Forms.Label
            Me.label75 = New System.Windows.Forms.Label
            Me.comboBox19 = New System.Windows.Forms.ComboBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.RadioButton12 = New System.Windows.Forms.RadioButton
            Me.radioButton5 = New System.Windows.Forms.RadioButton
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.label14 = New System.Windows.Forms.Label
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.numericUpDownExt7 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.label24 = New System.Windows.Forms.Label
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.domainUpDownExt1 = New Syncfusion.Windows.Forms.Tools.DomainUpDownExt
            Me.label66 = New System.Windows.Forms.Label
            Me.label88 = New System.Windows.Forms.Label
            Me.label84 = New System.Windows.Forms.Label
            Me.label89 = New System.Windows.Forms.Label
            Me.DomainBorderColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton6 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.checkBox14 = New System.Windows.Forms.CheckBox
            Me.dataGrid2 = New System.Windows.Forms.DataGrid
            Me.checkBox19 = New System.Windows.Forms.CheckBox
            Me.label28 = New System.Windows.Forms.Label
            Me.label91 = New System.Windows.Forms.Label
            Me.label32 = New System.Windows.Forms.Label
            Me.label92 = New System.Windows.Forms.Label
            Me.label29 = New System.Windows.Forms.Label
            Me.checkBox15 = New System.Windows.Forms.CheckBox
            Me.label27 = New System.Windows.Forms.Label
            Me.label30 = New System.Windows.Forms.Label
            Me.label36 = New System.Windows.Forms.Label
            Me.label87 = New System.Windows.Forms.Label
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.tabPageAdv5 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.NumericUpDownExt8 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.Label138 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.bannerClrEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton9 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt5 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.rdoFocus = New System.Windows.Forms.RadioButton
            Me.rdoEdit = New System.Windows.Forms.RadioButton
            Me.txtBanner = New System.Windows.Forms.TextBox
            Me.label127 = New System.Windows.Forms.Label
            Me.label124 = New System.Windows.Forms.Label
            Me.label99 = New System.Windows.Forms.Label
            Me.label77 = New System.Windows.Forms.Label
            Me.label78 = New System.Windows.Forms.Label
            Me.groupBox4 = New System.Windows.Forms.GroupBox
            Me.label25 = New System.Windows.Forms.Label
            Me.textBoxExt4 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label109 = New System.Windows.Forms.Label
            Me.checkBox21 = New System.Windows.Forms.CheckBox
            Me.label31 = New System.Windows.Forms.Label
            Me.label103 = New System.Windows.Forms.Label
            Me.label107 = New System.Windows.Forms.Label
            Me.checkBox22 = New System.Windows.Forms.CheckBox
            Me.buttonEdit2 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton4 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt3 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label108 = New System.Windows.Forms.Label
            Me.label106 = New System.Windows.Forms.Label
            Me.checkBox23 = New System.Windows.Forms.CheckBox
            Me.label115 = New System.Windows.Forms.Label
            Me.comboBox12 = New System.Windows.Forms.ComboBox
            Me.comboBox11 = New System.Windows.Forms.ComboBox
            Me.checkBox24 = New System.Windows.Forms.CheckBox
            Me.label113 = New System.Windows.Forms.Label
            Me.comboBox9 = New System.Windows.Forms.ComboBox
            Me.comboBox10 = New System.Windows.Forms.ComboBox
            Me.checkBox25 = New System.Windows.Forms.CheckBox
            Me.label114 = New System.Windows.Forms.Label
            Me.label101 = New System.Windows.Forms.Label
            Me.label105 = New System.Windows.Forms.Label
            Me.checkBox26 = New System.Windows.Forms.CheckBox
            Me.label111 = New System.Windows.Forms.Label
            Me.comboBox8 = New System.Windows.Forms.ComboBox
            Me.radioButton11 = New System.Windows.Forms.RadioButton
            Me.label102 = New System.Windows.Forms.Label
            Me.label112 = New System.Windows.Forms.Label
            Me.label100 = New System.Windows.Forms.Label
            Me.radioButton10 = New System.Windows.Forms.RadioButton
            Me.textBox11 = New System.Windows.Forms.TextBox
            Me.label104 = New System.Windows.Forms.Label
            Me.label110 = New System.Windows.Forms.Label
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.groupBox5 = New System.Windows.Forms.GroupBox
            Me.label65 = New System.Windows.Forms.Label
            Me.currencyEdit1 = New Syncfusion.Windows.Forms.Tools.CurrencyEdit
            Me.label15 = New System.Windows.Forms.Label
            Me.label16 = New System.Windows.Forms.Label
            Me.label86 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.radClassic = New System.Windows.Forms.RadioButton
            Me.label85 = New System.Windows.Forms.Label
            Me.label83 = New System.Windows.Forms.Label
            Me.label17 = New System.Windows.Forms.Label
            Me.label82 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.radWinStd = New System.Windows.Forms.RadioButton
            Me.radFinancial = New System.Windows.Forms.RadioButton
            Me.checkBox13 = New System.Windows.Forms.CheckBox
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.radOffice2000 = New System.Windows.Forms.RadioButton
            Me.radOffice2007 = New System.Windows.Forms.RadioButton
            Me.label23 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.radOfficeXP = New System.Windows.Forms.RadioButton
            Me.cboButtonType = New System.Windows.Forms.ComboBox
            Me.label20 = New System.Windows.Forms.Label
            Me.radWinXP = New System.Windows.Forms.RadioButton
            Me.label21 = New System.Windows.Forms.Label
            Me.label19 = New System.Windows.Forms.Label
            Me.radOffice2003 = New System.Windows.Forms.RadioButton
            Me.checkBox18 = New System.Windows.Forms.CheckBox
            Me.label22 = New System.Windows.Forms.Label
            Me.checkBox12 = New System.Windows.Forms.CheckBox
            Me.checkBox17 = New System.Windows.Forms.CheckBox
            Me.tabPageAdv6 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.checkBox28 = New System.Windows.Forms.CheckBox
            Me.label123 = New System.Windows.Forms.Label
            Me.checkBox27 = New System.Windows.Forms.CheckBox
            Me.comboBox13 = New System.Windows.Forms.ComboBox
            Me.label117 = New System.Windows.Forms.Label
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label122 = New System.Windows.Forms.Label
            Me.label118 = New System.Windows.Forms.Label
            Me.label119 = New System.Windows.Forms.Label
            Me.label120 = New System.Windows.Forms.Label
            Me.label121 = New System.Windows.Forms.Label
            Me.editableList2 = New Syncfusion.Windows.Forms.Tools.EditableList
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label116 = New System.Windows.Forms.Label
            Me.editableList1 = New Syncfusion.Windows.Forms.Tools.EditableList
            Me.tabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.NumericUpDownExt9 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.Label139 = New System.Windows.Forms.Label
            Me.comboBox18 = New System.Windows.Forms.ComboBox
            Me.label126 = New System.Windows.Forms.Label
            Me.label79 = New System.Windows.Forms.Label
            Me.checkBox29 = New System.Windows.Forms.CheckBox
            Me.comboBox16 = New System.Windows.Forms.ComboBox
            Me.checkBox30 = New System.Windows.Forms.CheckBox
            Me.comboBox17 = New System.Windows.Forms.ComboBox
            Me.label125 = New System.Windows.Forms.Label
            Me.label98 = New System.Windows.Forms.Label
            Me.comboBox15 = New System.Windows.Forms.ComboBox
            Me.buttonEdit3 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label80 = New System.Windows.Forms.Label
            Me.label81 = New System.Windows.Forms.Label
            Me.label90 = New System.Windows.Forms.Label
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.label93 = New System.Windows.Forms.Label
            Me.label94 = New System.Windows.Forms.Label
            Me.radioButton8 = New System.Windows.Forms.RadioButton
            Me.buttonEdit4 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton7 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.radioButton9 = New System.Windows.Forms.RadioButton
            Me.buttonEdit5 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton8 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label95 = New System.Windows.Forms.Label
            Me.comboBox14 = New System.Windows.Forms.ComboBox
            Me.label96 = New System.Windows.Forms.Label
            Me.label97 = New System.Windows.Forms.Label
            Me.label71 = New System.Windows.Forms.Label
            Me.label74 = New System.Windows.Forms.Label
            Me.groupBox6 = New System.Windows.Forms.GroupBox
            Me.maskedEditBox1 = New Syncfusion.Windows.Forms.Tools.MaskedEditBox
            Me.label64 = New System.Windows.Forms.Label
            Me.label34 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.label35 = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.checkBox9 = New System.Windows.Forms.CheckBox
            Me.checkBox8 = New System.Windows.Forms.CheckBox
            Me.checkBox7 = New System.Windows.Forms.CheckBox
            Me.checkBox6 = New System.Windows.Forms.CheckBox
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.checkBox10 = New System.Windows.Forms.CheckBox
            Me.checkBox11 = New System.Windows.Forms.CheckBox
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.dataSet11 = New EditorControls.DataSet1
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.bannerTextProvider1 = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
            Me.CheckBox31 = New System.Windows.Forms.CheckBox
            Me.CheckBox32 = New System.Windows.Forms.CheckBox
            Me.chkPullCharOnDelete = New System.Windows.Forms.CheckBox
            CType(Me.currencyTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.integerTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            CType(Me.gradientPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel11.SuspendLayout()
            CType(Me.NumericUpDownExt6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bannerClr, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bannerClr.SuspendLayout()
            CType(Me.cmbMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NegativeColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.NegativeColorEdit.SuspendLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit1.SuspendLayout()
            CType(Me.PositiveColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PositiveColorEdit.SuspendLayout()
            CType(Me.gradientPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel9.SuspendLayout()
            CType(Me.gradientPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel12.SuspendLayout()
            CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel7.SuspendLayout()
            CType(Me.integerTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel10.SuspendLayout()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel5.SuspendLayout()
            CType(Me.percentTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel8.SuspendLayout()
            CType(Me.numericUpDownExt5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.integerTextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.doubleTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel6.SuspendLayout()
            CType(Me.integerTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv3.SuspendLayout()
            CType(Me.comboMode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bEditBanner, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bEditBanner.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            CType(Me.numericUpDownExt7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.DomainBorderColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DomainBorderColorEdit.SuspendLayout()
            CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv5.SuspendLayout()
            CType(Me.NumericUpDownExt8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bannerClrEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bannerClrEdit.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit2.SuspendLayout()
            Me.tabPageAdv2.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            CType(Me.currencyEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.currencyEdit1.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.tabPageAdv6.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            Me.tabPageAdv4.SuspendLayout()
            CType(Me.NumericUpDownExt9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit3.SuspendLayout()
            CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit4.SuspendLayout()
            CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit5.SuspendLayout()
            Me.groupBox6.SuspendLayout()
            CType(Me.maskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'currencyTextBox1
            '
            BannerTextInfo8.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode
            BannerTextInfo8.Text = "<Value>"
            BannerTextInfo8.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.currencyTextBox1, BannerTextInfo8)
            Me.currencyTextBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.currencyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.currencyTextBox1.CurrentCultureRefresh = True
            Me.currencyTextBox1.DecimalValue = New Decimal(New Integer() {200, 0, 0, 131072})
            Me.currencyTextBox1.Location = New System.Drawing.Point(61, 78)
            Me.currencyTextBox1.Name = "currencyTextBox1"
            Me.currencyTextBox1.NegativeInputPendingOnSelectAll = False
            Me.currencyTextBox1.NullString = ""
            Me.currencyTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing"
            Me.currencyTextBox1.ShowOverflowIndicator = False
            Me.currencyTextBox1.Size = New System.Drawing.Size(73, 20)
            Me.currencyTextBox1.TabIndex = 0
            '
            'integerTextBox1
            '
            Me.integerTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.integerTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.integerTextBox1.IntegerValue = CType(2, Long)
            Me.integerTextBox1.Location = New System.Drawing.Point(105, 178)
            Me.integerTextBox1.Name = "integerTextBox1"
            Me.integerTextBox1.NegativeInputPendingOnSelectAll = False
            Me.integerTextBox1.NullString = "0"
            Me.integerTextBox1.OverflowIndicatorToolTipText = Nothing
            Me.integerTextBox1.Size = New System.Drawing.Size(60, 20)
            Me.integerTextBox1.TabIndex = 7
            Me.integerTextBox1.ThemesEnabled = False
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(9, 178)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(84, 28)
            Me.label7.TabIndex = 6
            Me.label7.Text = "Decimal Digits" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Between 0-99)"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(105, 146)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(60, 20)
            Me.textBox1.TabIndex = 5
            Me.textBox1.Text = "$"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(9, 149)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(90, 14)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Currency Symbol"
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Items.AddRange(New Object() {"Left", "Right", "Middle"})
            Me.comboBoxAdv1.Location = New System.Drawing.Point(460, 49)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(69, 22)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv1.TabIndex = 3
            Me.comboBoxAdv1.Text = "Left"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(374, 49)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(55, 14)
            Me.label3.TabIndex = 2
            Me.label3.Text = "Text Align"
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(377, 121)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(124, 24)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "ThemesEnabled"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(374, 85)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(83, 14)
            Me.label6.TabIndex = 3
            Me.label6.Text = "Culture Settings"
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Location = New System.Drawing.Point(460, 85)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(134, 22)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv2.TabIndex = 4
            '
            'dataGrid1
            '
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(600, 69)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(210, 179)
            Me.dataGrid1.TabIndex = 4
            '
            'checkBox2
            '
            Me.checkBox2.Location = New System.Drawing.Point(600, 39)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(133, 24)
            Me.checkBox2.TabIndex = 2
            Me.checkBox2.Text = "Bind To DataBase"
            Me.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'oleDbDataAdapter1
            '
            Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
            Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sales", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Amount", "Amount"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("PurchaseDate", "PurchaseDate")})})
            '
            'oleDbSelectCommand1
            '
            Me.oleDbSelectCommand1.CommandText = "SELECT Amount, ID, PurchaseDate FROM Sales"
            Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv5)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv6)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv4)
            Me.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.tabControlAdv1.Location = New System.Drawing.Point(163, 54)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Padding = New System.Drawing.Point(10, 5)
            Me.tabControlAdv1.Size = New System.Drawing.Size(837, 606)
            Me.tabControlAdv1.TabGap = 15
            Me.tabControlAdv1.TabIndex = 3
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel11)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel9)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel7)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel5)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel1)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 26)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.Size = New System.Drawing.Size(835, 579)
            Me.tabPageAdv1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "Input Controls"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'gradientPanel11
            '
            Me.gradientPanel11.BackColor = System.Drawing.Color.White
            Me.gradientPanel11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel11.Controls.Add(Me.NumericUpDownExt6)
            Me.gradientPanel11.Controls.Add(Me.Label137)
            Me.gradientPanel11.Controls.Add(Me.bannerClr)
            Me.gradientPanel11.Controls.Add(Me.btnSetBanner)
            Me.gradientPanel11.Controls.Add(Me.cmbMode)
            Me.gradientPanel11.Controls.Add(Me.txtBnr)
            Me.gradientPanel11.Controls.Add(Me.label130)
            Me.gradientPanel11.Controls.Add(Me.label131)
            Me.gradientPanel11.Controls.Add(Me.label132)
            Me.gradientPanel11.Controls.Add(Me.label128)
            Me.gradientPanel11.Controls.Add(Me.label129)
            Me.gradientPanel11.Controls.Add(Me.checkBox20)
            Me.gradientPanel11.Controls.Add(Me.NegativeColorEdit)
            Me.gradientPanel11.Controls.Add(Me.label2)
            Me.gradientPanel11.Controls.Add(Me.label5)
            Me.gradientPanel11.Controls.Add(Me.dataGrid1)
            Me.gradientPanel11.Controls.Add(Me.label42)
            Me.gradientPanel11.Controls.Add(Me.comboBox6)
            Me.gradientPanel11.Controls.Add(Me.checkBox2)
            Me.gradientPanel11.Controls.Add(Me.label46)
            Me.gradientPanel11.Controls.Add(Me.label58)
            Me.gradientPanel11.Controls.Add(Me.label61)
            Me.gradientPanel11.Controls.Add(Me.label62)
            Me.gradientPanel11.Controls.Add(Me.radioButton6)
            Me.gradientPanel11.Controls.Add(Me.buttonEdit1)
            Me.gradientPanel11.Controls.Add(Me.radioButton7)
            Me.gradientPanel11.Controls.Add(Me.PositiveColorEdit)
            Me.gradientPanel11.Controls.Add(Me.label40)
            Me.gradientPanel11.Controls.Add(Me.comboBox5)
            Me.gradientPanel11.Controls.Add(Me.checkBox16)
            Me.gradientPanel11.Controls.Add(Me.label8)
            Me.gradientPanel11.Controls.Add(Me.label43)
            Me.gradientPanel11.Controls.Add(Me.label44)
            Me.gradientPanel11.Controls.Add(Me.label12)
            Me.gradientPanel11.Controls.Add(Me.comboBoxAdv1)
            Me.gradientPanel11.Controls.Add(Me.label3)
            Me.gradientPanel11.Controls.Add(Me.label6)
            Me.gradientPanel11.Controls.Add(Me.comboBoxAdv2)
            Me.gradientPanel11.Controls.Add(Me.checkBox1)
            Me.gradientPanel11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel11.Location = New System.Drawing.Point(12, 303)
            Me.gradientPanel11.Name = "gradientPanel11"
            Me.gradientPanel11.Size = New System.Drawing.Size(814, 274)
            Me.gradientPanel11.TabIndex = 124
            '
            'NumericUpDownExt6
            '
            Me.NumericUpDownExt6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.NumericUpDownExt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.NumericUpDownExt6.Location = New System.Drawing.Point(84, 91)
            Me.NumericUpDownExt6.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.NumericUpDownExt6.Name = "NumericUpDownExt6"
            Me.NumericUpDownExt6.Size = New System.Drawing.Size(89, 20)
            Me.NumericUpDownExt6.TabIndex = 137
            '
            'Label137
            '
            Me.Label137.AutoSize = True
            Me.Label137.Location = New System.Drawing.Point(1, 91)
            Me.Label137.Margin = New System.Windows.Forms.Padding(0)
            Me.Label137.Name = "Label137"
            Me.Label137.Size = New System.Drawing.Size(73, 14)
            Me.Label137.TabIndex = 136
            Me.Label137.Text = "CornerRadius"
            '
            'bannerClr
            '
            Me.bannerClr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bannerClr.Buttons.Add(Me.buttonEditChildButton10)
            Me.bannerClr.Controls.Add(Me.buttonEditChildButton10)
            Me.bannerClr.Controls.Add(Me.textBoxExt6)
            Me.bannerClr.Location = New System.Drawing.Point(245, 114)
            Me.bannerClr.Name = "bannerClr"
            Me.bannerClr.ShowTextBox = False
            Me.bannerClr.Size = New System.Drawing.Size(107, 21)
            Me.bannerClr.TabIndex = 135
            Me.bannerClr.TextBox = Me.textBoxExt6
            Me.bannerClr.UseVisualStyle = True
            '
            'buttonEditChildButton10
            '
            Me.buttonEditChildButton10.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton10.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton10.Image = Nothing
            Me.buttonEditChildButton10.Name = "buttonEditChildButton10"
            Me.buttonEditChildButton10.PreferredWidth = 20
            Me.buttonEditChildButton10.TabIndex = 1
            Me.buttonEditChildButton10.Text = "..."
            '
            'textBoxExt6
            '
            Me.textBoxExt6.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt6.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt6.Name = "textBoxExt6"
            Me.textBoxExt6.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt6.Size = New System.Drawing.Size(95, 13)
            Me.textBoxExt6.TabIndex = 0
            '
            'btnSetBanner
            '
            Me.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetBanner.Location = New System.Drawing.Point(213, 167)
            Me.btnSetBanner.Name = "btnSetBanner"
            Me.btnSetBanner.Size = New System.Drawing.Size(113, 23)
            Me.btnSetBanner.TabIndex = 2
            Me.btnSetBanner.Text = "Set Banner Text"
            Me.btnSetBanner.UseVisualStyleBackColor = True
            '
            'cmbMode
            '
            Me.cmbMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.cmbMode.IgnoreThemeBackground = True
            Me.cmbMode.Items.AddRange(New Object() {"EditMode", "FocusMode"})
            Me.cmbMode.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbMode, "EditMode"))
            Me.cmbMode.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbMode, "FocusMode"))
            Me.cmbMode.Location = New System.Drawing.Point(245, 78)
            Me.cmbMode.Name = "cmbMode"
            Me.cmbMode.Size = New System.Drawing.Size(107, 22)
            Me.cmbMode.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.cmbMode.TabIndex = 134
            '
            'txtBnr
            '
            Me.txtBnr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtBnr.Location = New System.Drawing.Point(245, 41)
            Me.txtBnr.Name = "txtBnr"
            Me.txtBnr.Size = New System.Drawing.Size(107, 20)
            Me.txtBnr.TabIndex = 130
            '
            'label130
            '
            Me.label130.AutoSize = True
            Me.label130.Location = New System.Drawing.Point(191, 43)
            Me.label130.Name = "label130"
            Me.label130.Size = New System.Drawing.Size(28, 14)
            Me.label130.TabIndex = 131
            Me.label130.Text = "Text"
            '
            'label131
            '
            Me.label131.AutoSize = True
            Me.label131.Location = New System.Drawing.Point(190, 81)
            Me.label131.Name = "label131"
            Me.label131.Size = New System.Drawing.Size(33, 14)
            Me.label131.TabIndex = 132
            Me.label131.Text = "Mode"
            '
            'label132
            '
            Me.label132.AutoSize = True
            Me.label132.Location = New System.Drawing.Point(190, 121)
            Me.label132.Name = "label132"
            Me.label132.Size = New System.Drawing.Size(32, 14)
            Me.label132.TabIndex = 133
            Me.label132.Text = "Color"
            '
            'label128
            '
            Me.label128.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label128.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label128.Image = CType(resources.GetObject("label128.Image"), System.Drawing.Image)
            Me.label128.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label128.Location = New System.Drawing.Point(180, 3)
            Me.label128.Name = "label128"
            Me.label128.Size = New System.Drawing.Size(142, 24)
            Me.label128.TabIndex = 122
            Me.label128.Text = "BannerText Settings"
            Me.label128.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label129
            '
            Me.label129.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label129.Location = New System.Drawing.Point(200, 27)
            Me.label129.Name = "label129"
            Me.label129.Size = New System.Drawing.Size(150, 1)
            Me.label129.TabIndex = 121
            '
            'checkBox20
            '
            Me.checkBox20.Location = New System.Drawing.Point(377, 193)
            Me.checkBox20.Name = "checkBox20"
            Me.checkBox20.Size = New System.Drawing.Size(179, 24)
            Me.checkBox20.TabIndex = 120
            Me.checkBox20.Text = "OverFlowIndicatorToolTip"
            '
            'NegativeColorEdit
            '
            Me.NegativeColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.NegativeColorEdit.Buttons.Add(Me.buttonEditChildButton1)
            Me.NegativeColorEdit.Controls.Add(Me.buttonEditChildButton1)
            Me.NegativeColorEdit.Location = New System.Drawing.Point(82, 215)
            Me.NegativeColorEdit.Name = "NegativeColorEdit"
            Me.NegativeColorEdit.ShowTextBox = False
            Me.NegativeColorEdit.Size = New System.Drawing.Size(91, 26)
            Me.NegativeColorEdit.TabIndex = 118
            Me.NegativeColorEdit.UseVisualStyle = True
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 18
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(1, 186)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(72, 14)
            Me.label2.TabIndex = 21
            Me.label2.Text = "Positive Color"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(1, 219)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(77, 14)
            Me.label5.TabIndex = 22
            Me.label5.Text = "Negative Color"
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.Location = New System.Drawing.Point(1, 252)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(68, 14)
            Me.label42.TabIndex = 48
            Me.label42.Text = "Border Color"
            '
            'comboBox6
            '
            Me.comboBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox6.Enabled = False
            Me.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.comboBox6.ForeColor = System.Drawing.Color.Black
            Me.comboBox6.Location = New System.Drawing.Point(82, 121)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(91, 22)
            Me.comboBox6.TabIndex = 49
            '
            'label46
            '
            Me.label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label46.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label46.Image = CType(resources.GetObject("label46.Image"), System.Drawing.Image)
            Me.label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label46.Location = New System.Drawing.Point(3, 0)
            Me.label46.Name = "label46"
            Me.label46.Size = New System.Drawing.Size(142, 24)
            Me.label46.TabIndex = 75
            Me.label46.Text = "Appearance Settings"
            Me.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label58
            '
            Me.label58.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label58.Location = New System.Drawing.Point(12, 24)
            Me.label58.Name = "label58"
            Me.label58.Size = New System.Drawing.Size(150, 1)
            Me.label58.TabIndex = 74
            '
            'label61
            '
            Me.label61.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label61.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label61.Image = CType(resources.GetObject("label61.Image"), System.Drawing.Image)
            Me.label61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label61.Location = New System.Drawing.Point(375, 3)
            Me.label61.Name = "label61"
            Me.label61.Size = New System.Drawing.Size(126, 24)
            Me.label61.TabIndex = 79
            Me.label61.Text = "Behavior Settings"
            Me.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label62
            '
            Me.label62.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label62.Location = New System.Drawing.Point(377, 28)
            Me.label62.Name = "label62"
            Me.label62.Size = New System.Drawing.Size(150, 1)
            Me.label62.TabIndex = 78
            '
            'radioButton6
            '
            Me.radioButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton6.Location = New System.Drawing.Point(82, 61)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.Size = New System.Drawing.Size(91, 25)
            Me.radioButton6.TabIndex = 54
            Me.radioButton6.Text = "Fixed3D"
            '
            'buttonEdit1
            '
            Me.buttonEdit1.BackColor = System.Drawing.Color.White
            Me.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.Location = New System.Drawing.Point(82, 245)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.ShowTextBox = False
            Me.buttonEdit1.Size = New System.Drawing.Size(91, 26)
            Me.buttonEdit1.TabIndex = 119
            Me.buttonEdit1.UseVisualStyle = True
            '
            'buttonEditChildButton2
            '
            Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton2.Image = Nothing
            Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
            Me.buttonEditChildButton2.PreferredWidth = 18
            Me.buttonEditChildButton2.TabIndex = 1
            Me.buttonEditChildButton2.Text = "..."
            '
            'radioButton7
            '
            Me.radioButton7.Checked = True
            Me.radioButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton7.Location = New System.Drawing.Point(82, 33)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.Size = New System.Drawing.Size(91, 25)
            Me.radioButton7.TabIndex = 53
            Me.radioButton7.TabStop = True
            Me.radioButton7.Text = "FixedSingle"
            '
            'PositiveColorEdit
            '
            Me.PositiveColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.PositiveColorEdit.Buttons.Add(Me.buttonEditChildButton5)
            Me.PositiveColorEdit.Controls.Add(Me.buttonEditChildButton5)
            Me.PositiveColorEdit.Location = New System.Drawing.Point(82, 186)
            Me.PositiveColorEdit.Name = "PositiveColorEdit"
            Me.PositiveColorEdit.ShowTextBox = False
            Me.PositiveColorEdit.Size = New System.Drawing.Size(91, 26)
            Me.PositiveColorEdit.TabIndex = 117
            Me.PositiveColorEdit.UseVisualStyle = True
            '
            'buttonEditChildButton5
            '
            Me.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton5.Image = Nothing
            Me.buttonEditChildButton5.Name = "buttonEditChildButton5"
            Me.buttonEditChildButton5.PreferredWidth = 18
            Me.buttonEditChildButton5.TabIndex = 1
            Me.buttonEditChildButton5.Text = "..."
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(3, 45)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(67, 14)
            Me.label40.TabIndex = 52
            Me.label40.Text = "Border Style"
            '
            'comboBox5
            '
            Me.comboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox5.ForeColor = System.Drawing.Color.Black
            Me.comboBox5.Items.AddRange(New Object() {"Left", "Top", "Right", "Bottom", "Middle", "All"})
            Me.comboBox5.Location = New System.Drawing.Point(82, 152)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(91, 22)
            Me.comboBox5.TabIndex = 50
            '
            'checkBox16
            '
            Me.checkBox16.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox16.Location = New System.Drawing.Point(377, 160)
            Me.checkBox16.Name = "checkBox16"
            Me.checkBox16.Size = New System.Drawing.Size(123, 24)
            Me.checkBox16.TabIndex = 60
            Me.checkBox16.Text = "OverFlowIndicator"
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(597, 2)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(99, 24)
            Me.label8.TabIndex = 24
            Me.label8.Text = "Data Binding"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label43
            '
            Me.label43.AutoSize = True
            Me.label43.Location = New System.Drawing.Point(1, 153)
            Me.label43.Name = "label43"
            Me.label43.Size = New System.Drawing.Size(70, 14)
            Me.label43.TabIndex = 47
            Me.label43.Text = "Border Sides"
            '
            'label44
            '
            Me.label44.AutoSize = True
            Me.label44.Location = New System.Drawing.Point(1, 120)
            Me.label44.Margin = New System.Windows.Forms.Padding(0)
            Me.label44.Name = "label44"
            Me.label44.Size = New System.Drawing.Size(80, 14)
            Me.label44.TabIndex = 46
            Me.label44.Text = "Border3D Style"
            '
            'label12
            '
            Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label12.Location = New System.Drawing.Point(608, 26)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(150, 1)
            Me.label12.TabIndex = 23
            '
            'gradientPanel9
            '
            Me.gradientPanel9.BackColor = System.Drawing.Color.White
            Me.gradientPanel9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel9.Controls.Add(Me.currencyTextBox1)
            Me.gradientPanel9.Controls.Add(Me.label1)
            Me.gradientPanel9.Controls.Add(Me.label10)
            Me.gradientPanel9.Controls.Add(Me.gradientPanel12)
            Me.gradientPanel9.Controls.Add(Me.label4)
            Me.gradientPanel9.Controls.Add(Me.textBox1)
            Me.gradientPanel9.Controls.Add(Me.label7)
            Me.gradientPanel9.Controls.Add(Me.integerTextBox1)
            Me.gradientPanel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel9.Location = New System.Drawing.Point(12, 7)
            Me.gradientPanel9.Name = "gradientPanel9"
            Me.gradientPanel9.Size = New System.Drawing.Size(193, 278)
            Me.gradientPanel9.TabIndex = 123
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(3, 116)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(84, 24)
            Me.label1.TabIndex = 127
            Me.label1.Text = "Properties"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label10.Location = New System.Drawing.Point(84, 129)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(74, 1)
            Me.label10.TabIndex = 126
            '
            'gradientPanel12
            '
            Me.gradientPanel12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel12.Controls.Add(Me.label45)
            Me.gradientPanel12.Controls.Add(Me.label47)
            Me.gradientPanel12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel12.Location = New System.Drawing.Point(3, -1)
            Me.gradientPanel12.Name = "gradientPanel12"
            Me.gradientPanel12.Size = New System.Drawing.Size(156, 76)
            Me.gradientPanel12.TabIndex = 124
            '
            'label45
            '
            Me.label45.BackColor = System.Drawing.Color.Transparent
            Me.label45.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label45.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label45.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label45.Location = New System.Drawing.Point(0, 18)
            Me.label45.Name = "label45"
            Me.label45.Size = New System.Drawing.Size(156, 58)
            Me.label45.TabIndex = 1
            Me.label45.Text = "CurrencyTextBox control is a textbox derived control for different currencies pre" & _
                "sent."
            '
            'label47
            '
            Me.label47.Dock = System.Windows.Forms.DockStyle.Top
            Me.label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label47.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label47.Location = New System.Drawing.Point(0, 0)
            Me.label47.Name = "label47"
            Me.label47.Size = New System.Drawing.Size(156, 18)
            Me.label47.TabIndex = 123
            Me.label47.Text = "CurrencyTextBox"
            Me.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gradientPanel7
            '
            Me.gradientPanel7.BackColor = System.Drawing.Color.White
            Me.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel7.Controls.Add(Me.label59)
            Me.gradientPanel7.Controls.Add(Me.integerTextBox2)
            Me.gradientPanel7.Controls.Add(Me.label50)
            Me.gradientPanel7.Controls.Add(Me.label51)
            Me.gradientPanel7.Controls.Add(Me.gradientPanel10)
            Me.gradientPanel7.Controls.Add(Me.label69)
            Me.gradientPanel7.Controls.Add(Me.numericUpDownExt1)
            Me.gradientPanel7.Controls.Add(Me.label68)
            Me.gradientPanel7.Controls.Add(Me.textBox4)
            Me.gradientPanel7.Controls.Add(Me.numericUpDownExt3)
            Me.gradientPanel7.Controls.Add(Me.label67)
            Me.gradientPanel7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel7.Location = New System.Drawing.Point(219, 7)
            Me.gradientPanel7.Name = "gradientPanel7"
            Me.gradientPanel7.Size = New System.Drawing.Size(193, 278)
            Me.gradientPanel7.TabIndex = 122
            '
            'label59
            '
            Me.label59.Image = CType(resources.GetObject("label59.Image"), System.Drawing.Image)
            Me.label59.Location = New System.Drawing.Point(167, 143)
            Me.label59.Name = "label59"
            Me.label59.Size = New System.Drawing.Size(20, 20)
            Me.label59.TabIndex = 128
            Me.toolTip1.SetToolTip(Me.label59, "When a negative value is entered, the value can be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "displayed in various pattern " & _
                    "such as the symbol in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "front of the number and so on.")
            '
            'integerTextBox2
            '
            BannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode
            BannerTextInfo1.Text = "<Value>"
            BannerTextInfo1.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.integerTextBox2, BannerTextInfo1)
            Me.integerTextBox2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.integerTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.integerTextBox2.Culture = New System.Globalization.CultureInfo("bg-BG")
            Me.integerTextBox2.IntegerValue = CType(2, Long)
            Me.integerTextBox2.Location = New System.Drawing.Point(51, 79)
            Me.integerTextBox2.Name = "integerTextBox2"
            Me.integerTextBox2.NegativeInputPendingOnSelectAll = False
            Me.integerTextBox2.NullString = ""
            Me.integerTextBox2.NumberGroupSizes = New Integer() {2}
            Me.integerTextBox2.NumberNegativePattern = 2
            Me.integerTextBox2.OverflowIndicatorToolTipText = "Text OverFlowing"
            Me.integerTextBox2.Size = New System.Drawing.Size(73, 20)
            Me.integerTextBox2.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
            Me.integerTextBox2.TabIndex = 0
            Me.integerTextBox2.UseNullString = True
            '
            'label50
            '
            Me.label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label50.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label50.Image = CType(resources.GetObject("label50.Image"), System.Drawing.Image)
            Me.label50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label50.Location = New System.Drawing.Point(3, 116)
            Me.label50.Name = "label50"
            Me.label50.Size = New System.Drawing.Size(81, 24)
            Me.label50.TabIndex = 127
            Me.label50.Text = "Properties"
            Me.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label51
            '
            Me.label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label51.Location = New System.Drawing.Point(84, 129)
            Me.label51.Name = "label51"
            Me.label51.Size = New System.Drawing.Size(74, 1)
            Me.label51.TabIndex = 126
            '
            'gradientPanel10
            '
            Me.gradientPanel10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel10.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel10.Controls.Add(Me.label57)
            Me.gradientPanel10.Controls.Add(Me.label63)
            Me.gradientPanel10.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientPanel10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel10.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel10.Name = "gradientPanel10"
            Me.gradientPanel10.Size = New System.Drawing.Size(191, 76)
            Me.gradientPanel10.TabIndex = 123
            '
            'label57
            '
            Me.label57.BackColor = System.Drawing.Color.Transparent
            Me.label57.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label57.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label57.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label57.Location = New System.Drawing.Point(0, 18)
            Me.label57.Name = "label57"
            Me.label57.Size = New System.Drawing.Size(191, 58)
            Me.label57.TabIndex = 1
            Me.label57.Text = "Integer TextBox is used to display Int64 values "
            '
            'label63
            '
            Me.label63.Dock = System.Windows.Forms.DockStyle.Top
            Me.label63.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label63.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label63.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label63.Location = New System.Drawing.Point(0, 0)
            Me.label63.Name = "label63"
            Me.label63.Size = New System.Drawing.Size(191, 18)
            Me.label63.TabIndex = 123
            Me.label63.Text = "IntegerTextBox"
            Me.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label69
            '
            Me.label69.AutoSize = True
            Me.label69.Location = New System.Drawing.Point(6, 146)
            Me.label69.Name = "label69"
            Me.label69.Size = New System.Drawing.Size(86, 14)
            Me.label69.TabIndex = 90
            Me.label69.Text = "Negative Pattern"
            '
            'numericUpDownExt1
            '
            Me.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt1.Location = New System.Drawing.Point(106, 143)
            Me.numericUpDownExt1.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
            Me.numericUpDownExt1.Name = "numericUpDownExt1"
            Me.numericUpDownExt1.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDownExt1.TabIndex = 92
            '
            'label68
            '
            Me.label68.AutoSize = True
            Me.label68.Location = New System.Drawing.Point(6, 178)
            Me.label68.Name = "label68"
            Me.label68.Size = New System.Drawing.Size(88, 14)
            Me.label68.TabIndex = 86
            Me.label68.Text = "Group Separator"
            '
            'textBox4
            '
            Me.textBox4.Location = New System.Drawing.Point(106, 178)
            Me.textBox4.Name = "textBox4"
            Me.textBox4.Size = New System.Drawing.Size(56, 20)
            Me.textBox4.TabIndex = 89
            Me.textBox4.Text = ","
            '
            'numericUpDownExt3
            '
            Me.numericUpDownExt3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.numericUpDownExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt3.Location = New System.Drawing.Point(106, 213)
            Me.numericUpDownExt3.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
            Me.numericUpDownExt3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDownExt3.Name = "numericUpDownExt3"
            Me.numericUpDownExt3.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDownExt3.TabIndex = 104
            Me.numericUpDownExt3.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'label67
            '
            Me.label67.AutoSize = True
            Me.label67.Location = New System.Drawing.Point(6, 210)
            Me.label67.Name = "label67"
            Me.label67.Size = New System.Drawing.Size(67, 14)
            Me.label67.TabIndex = 87
            Me.label67.Text = "Group Sizes"
            '
            'gradientPanel5
            '
            Me.gradientPanel5.BackColor = System.Drawing.Color.White
            Me.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel5.Controls.Add(Me.label60)
            Me.gradientPanel5.Controls.Add(Me.label48)
            Me.gradientPanel5.Controls.Add(Me.label49)
            Me.gradientPanel5.Controls.Add(Me.percentTextBox1)
            Me.gradientPanel5.Controls.Add(Me.gradientPanel8)
            Me.gradientPanel5.Controls.Add(Me.label73)
            Me.gradientPanel5.Controls.Add(Me.textBox6)
            Me.gradientPanel5.Controls.Add(Me.label72)
            Me.gradientPanel5.Controls.Add(Me.numericUpDownExt5)
            Me.gradientPanel5.Controls.Add(Me.integerTextBox7)
            Me.gradientPanel5.Controls.Add(Me.label76)
            Me.gradientPanel5.Controls.Add(Me.label70)
            Me.gradientPanel5.Controls.Add(Me.numericUpDownExt4)
            Me.gradientPanel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel5.Location = New System.Drawing.Point(633, 8)
            Me.gradientPanel5.Name = "gradientPanel5"
            Me.gradientPanel5.Size = New System.Drawing.Size(193, 278)
            Me.gradientPanel5.TabIndex = 121
            '
            'label60
            '
            Me.label60.Image = CType(resources.GetObject("label60.Image"), System.Drawing.Image)
            Me.label60.Location = New System.Drawing.Point(165, 235)
            Me.label60.Name = "label60"
            Me.label60.Size = New System.Drawing.Size(20, 20)
            Me.label60.TabIndex = 129
            Me.toolTip1.SetToolTip(Me.label60, "When a negative value is entered, the value can be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "displayed in various pattern " & _
                    "such as the symbol in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "front of the number and so on.")
            '
            'label48
            '
            Me.label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label48.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label48.Image = CType(resources.GetObject("label48.Image"), System.Drawing.Image)
            Me.label48.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label48.Location = New System.Drawing.Point(3, 115)
            Me.label48.Name = "label48"
            Me.label48.Size = New System.Drawing.Size(85, 24)
            Me.label48.TabIndex = 125
            Me.label48.Text = "Properties"
            Me.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label49
            '
            Me.label49.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label49.Location = New System.Drawing.Point(83, 128)
            Me.label49.Name = "label49"
            Me.label49.Size = New System.Drawing.Size(74, 1)
            Me.label49.TabIndex = 124
            '
            'percentTextBox1
            '
            BannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode
            BannerTextInfo2.Text = "<Value>"
            BannerTextInfo2.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.percentTextBox1, BannerTextInfo2)
            Me.percentTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.percentTextBox1.DoubleValue = 0.53
            Me.percentTextBox1.Location = New System.Drawing.Point(58, 77)
            Me.percentTextBox1.Name = "percentTextBox1"
            Me.percentTextBox1.NegativeInputPendingOnSelectAll = False
            Me.percentTextBox1.NullString = ""
            Me.percentTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing"
            Me.percentTextBox1.PercentGroupSeparator = "@"
            Me.percentTextBox1.PercentGroupSizes = New Integer() {2}
            Me.percentTextBox1.Size = New System.Drawing.Size(73, 20)
            Me.percentTextBox1.TabIndex = 0
            Me.percentTextBox1.UseNullString = True
            '
            'gradientPanel8
            '
            Me.gradientPanel8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel8.Controls.Add(Me.label38)
            Me.gradientPanel8.Controls.Add(Me.label56)
            Me.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientPanel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel8.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel8.Name = "gradientPanel8"
            Me.gradientPanel8.Size = New System.Drawing.Size(191, 76)
            Me.gradientPanel8.TabIndex = 123
            '
            'label38
            '
            Me.label38.BackColor = System.Drawing.Color.Transparent
            Me.label38.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label38.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label38.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label38.Location = New System.Drawing.Point(0, 18)
            Me.label38.Name = "label38"
            Me.label38.Size = New System.Drawing.Size(191, 58)
            Me.label38.TabIndex = 1
            Me.label38.Text = "PercentTextBox is used to display percentage values. "
            '
            'label56
            '
            Me.label56.Dock = System.Windows.Forms.DockStyle.Top
            Me.label56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label56.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label56.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label56.Location = New System.Drawing.Point(0, 0)
            Me.label56.Name = "label56"
            Me.label56.Size = New System.Drawing.Size(191, 18)
            Me.label56.TabIndex = 123
            Me.label56.Text = "PercentTextBox"
            Me.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label73
            '
            Me.label73.AutoSize = True
            Me.label73.Location = New System.Drawing.Point(12, 177)
            Me.label73.Name = "label73"
            Me.label73.Size = New System.Drawing.Size(94, 14)
            Me.label73.TabIndex = 93
            Me.label73.Text = "Decimal separator"
            '
            'textBox6
            '
            Me.textBox6.Location = New System.Drawing.Point(108, 171)
            Me.textBox6.Name = "textBox6"
            Me.textBox6.Size = New System.Drawing.Size(53, 20)
            Me.textBox6.TabIndex = 94
            Me.textBox6.Text = "."
            '
            'label72
            '
            Me.label72.AutoSize = True
            Me.label72.Location = New System.Drawing.Point(12, 209)
            Me.label72.Name = "label72"
            Me.label72.Size = New System.Drawing.Size(84, 28)
            Me.label72.TabIndex = 95
            Me.label72.Text = "Decimal Digits" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Between 0-99)"
            '
            'numericUpDownExt5
            '
            Me.numericUpDownExt5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.numericUpDownExt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt5.Location = New System.Drawing.Point(107, 139)
            Me.numericUpDownExt5.Name = "numericUpDownExt5"
            Me.numericUpDownExt5.Size = New System.Drawing.Size(53, 20)
            Me.numericUpDownExt5.TabIndex = 108
            Me.numericUpDownExt5.Value = New Decimal(New Integer() {52, 0, 0, 0})
            '
            'integerTextBox7
            '
            Me.integerTextBox7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.integerTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.integerTextBox7.IntegerValue = CType(2, Long)
            Me.integerTextBox7.Location = New System.Drawing.Point(108, 203)
            Me.integerTextBox7.Name = "integerTextBox7"
            Me.integerTextBox7.NegativeInputPendingOnSelectAll = False
            Me.integerTextBox7.NullString = "0"
            Me.integerTextBox7.OverflowIndicatorToolTipText = Nothing
            Me.integerTextBox7.Size = New System.Drawing.Size(53, 20)
            Me.integerTextBox7.TabIndex = 96
            Me.integerTextBox7.ThemesEnabled = False
            '
            'label76
            '
            Me.label76.AutoSize = True
            Me.label76.Location = New System.Drawing.Point(12, 145)
            Me.label76.Name = "label76"
            Me.label76.Size = New System.Drawing.Size(75, 14)
            Me.label76.TabIndex = 107
            Me.label76.Text = "Percent Value"
            '
            'label70
            '
            Me.label70.AutoSize = True
            Me.label70.Location = New System.Drawing.Point(12, 241)
            Me.label70.Name = "label70"
            Me.label70.Size = New System.Drawing.Size(81, 14)
            Me.label70.TabIndex = 98
            Me.label70.Text = "Positive Pattern"
            '
            'numericUpDownExt4
            '
            Me.numericUpDownExt4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.numericUpDownExt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt4.Location = New System.Drawing.Point(107, 235)
            Me.numericUpDownExt4.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.numericUpDownExt4.Name = "numericUpDownExt4"
            Me.numericUpDownExt4.Size = New System.Drawing.Size(53, 20)
            Me.numericUpDownExt4.TabIndex = 105
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label39)
            Me.gradientPanel1.Controls.Add(Me.label41)
            Me.gradientPanel1.Controls.Add(Me.doubleTextBox1)
            Me.gradientPanel1.Controls.Add(Me.gradientPanel6)
            Me.gradientPanel1.Controls.Add(Me.label52)
            Me.gradientPanel1.Controls.Add(Me.textBox2)
            Me.gradientPanel1.Controls.Add(Me.label53)
            Me.gradientPanel1.Controls.Add(Me.integerTextBox3)
            Me.gradientPanel1.Controls.Add(Me.label54)
            Me.gradientPanel1.Controls.Add(Me.label55)
            Me.gradientPanel1.Controls.Add(Me.textBox3)
            Me.gradientPanel1.Controls.Add(Me.numericUpDownExt2)
            Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel1.Location = New System.Drawing.Point(426, 8)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(193, 278)
            Me.gradientPanel1.TabIndex = 120
            '
            'label39
            '
            Me.label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label39.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label39.Image = CType(resources.GetObject("label39.Image"), System.Drawing.Image)
            Me.label39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label39.Location = New System.Drawing.Point(3, 115)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(82, 24)
            Me.label39.TabIndex = 127
            Me.label39.Text = "Properties"
            Me.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label41
            '
            Me.label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label41.Location = New System.Drawing.Point(83, 128)
            Me.label41.Name = "label41"
            Me.label41.Size = New System.Drawing.Size(74, 1)
            Me.label41.TabIndex = 126
            '
            'doubleTextBox1
            '
            BannerTextInfo3.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode
            BannerTextInfo3.Text = "<Value>"
            BannerTextInfo3.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.doubleTextBox1, BannerTextInfo3)
            Me.doubleTextBox1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.doubleTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.doubleTextBox1.DoubleValue = 1
            Me.doubleTextBox1.Location = New System.Drawing.Point(56, 77)
            Me.doubleTextBox1.Name = "doubleTextBox1"
            Me.doubleTextBox1.NegativeInputPendingOnSelectAll = False
            Me.doubleTextBox1.NullString = ""
            Me.doubleTextBox1.NumberGroupSizes = New Integer() {2}
            Me.doubleTextBox1.OverflowIndicatorToolTipText = "Text OverFlowing"
            Me.doubleTextBox1.Size = New System.Drawing.Size(73, 20)
            Me.doubleTextBox1.TabIndex = 0
            Me.doubleTextBox1.UseNullString = True
            '
            'gradientPanel6
            '
            Me.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel6.Controls.Add(Me.label33)
            Me.gradientPanel6.Controls.Add(Me.label37)
            Me.gradientPanel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientPanel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel6.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel6.Name = "gradientPanel6"
            Me.gradientPanel6.Size = New System.Drawing.Size(191, 76)
            Me.gradientPanel6.TabIndex = 122
            '
            'label33
            '
            Me.label33.BackColor = System.Drawing.Color.Transparent
            Me.label33.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label33.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label33.Location = New System.Drawing.Point(0, 18)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(191, 58)
            Me.label33.TabIndex = 1
            Me.label33.Text = "The DoubleTextBox supports display and collection of double values."
            '
            'label37
            '
            Me.label37.Dock = System.Windows.Forms.DockStyle.Top
            Me.label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label37.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label37.Location = New System.Drawing.Point(0, 0)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(191, 18)
            Me.label37.TabIndex = 123
            Me.label37.Text = "DoubleTextBox"
            Me.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label52
            '
            Me.label52.AutoSize = True
            Me.label52.Location = New System.Drawing.Point(11, 148)
            Me.label52.Name = "label52"
            Me.label52.Size = New System.Drawing.Size(94, 14)
            Me.label52.TabIndex = 63
            Me.label52.Text = "Decimal separator"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(111, 145)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(46, 20)
            Me.textBox2.TabIndex = 64
            Me.textBox2.Text = "."
            '
            'label53
            '
            Me.label53.AutoSize = True
            Me.label53.Location = New System.Drawing.Point(11, 180)
            Me.label53.Name = "label53"
            Me.label53.Size = New System.Drawing.Size(73, 14)
            Me.label53.TabIndex = 65
            Me.label53.Text = "Decimal Digits"
            '
            'integerTextBox3
            '
            Me.integerTextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.integerTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.integerTextBox3.IntegerValue = CType(2, Long)
            Me.integerTextBox3.Location = New System.Drawing.Point(111, 177)
            Me.integerTextBox3.Name = "integerTextBox3"
            Me.integerTextBox3.NegativeInputPendingOnSelectAll = False
            Me.integerTextBox3.NullString = "0"
            Me.integerTextBox3.OverflowIndicatorToolTipText = Nothing
            Me.integerTextBox3.Size = New System.Drawing.Size(46, 20)
            Me.integerTextBox3.TabIndex = 66
            Me.integerTextBox3.ThemesEnabled = False
            '
            'label54
            '
            Me.label54.AutoSize = True
            Me.label54.Location = New System.Drawing.Point(11, 212)
            Me.label54.Name = "label54"
            Me.label54.Size = New System.Drawing.Size(88, 14)
            Me.label54.TabIndex = 67
            Me.label54.Text = "Group Separator"
            '
            'label55
            '
            Me.label55.AutoSize = True
            Me.label55.Location = New System.Drawing.Point(11, 244)
            Me.label55.Name = "label55"
            Me.label55.Size = New System.Drawing.Size(67, 14)
            Me.label55.TabIndex = 69
            Me.label55.Text = "Group Sizes"
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(111, 209)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(46, 20)
            Me.textBox3.TabIndex = 71
            Me.textBox3.Text = ","
            '
            'numericUpDownExt2
            '
            Me.numericUpDownExt2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.numericUpDownExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt2.Location = New System.Drawing.Point(111, 241)
            Me.numericUpDownExt2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
            Me.numericUpDownExt2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDownExt2.Name = "numericUpDownExt2"
            Me.numericUpDownExt2.Size = New System.Drawing.Size(46, 20)
            Me.numericUpDownExt2.TabIndex = 103
            Me.numericUpDownExt2.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'tabPageAdv3
            '
            Me.tabPageAdv3.Controls.Add(Me.buttonBanner)
            Me.tabPageAdv3.Controls.Add(Me.comboMode)
            Me.tabPageAdv3.Controls.Add(Me.bEditBanner)
            Me.tabPageAdv3.Controls.Add(Me.textBanner)
            Me.tabPageAdv3.Controls.Add(Me.label136)
            Me.tabPageAdv3.Controls.Add(Me.label135)
            Me.tabPageAdv3.Controls.Add(Me.label134)
            Me.tabPageAdv3.Controls.Add(Me.label133)
            Me.tabPageAdv3.Controls.Add(Me.label75)
            Me.tabPageAdv3.Controls.Add(Me.comboBox19)
            Me.tabPageAdv3.Controls.Add(Me.panel1)
            Me.tabPageAdv3.Controls.Add(Me.radioButton2)
            Me.tabPageAdv3.Controls.Add(Me.radioButton1)
            Me.tabPageAdv3.Controls.Add(Me.label14)
            Me.tabPageAdv3.Controls.Add(Me.groupBox3)
            Me.tabPageAdv3.Controls.Add(Me.groupBox2)
            Me.tabPageAdv3.Controls.Add(Me.label88)
            Me.tabPageAdv3.Controls.Add(Me.label84)
            Me.tabPageAdv3.Controls.Add(Me.label89)
            Me.tabPageAdv3.Controls.Add(Me.DomainBorderColorEdit)
            Me.tabPageAdv3.Controls.Add(Me.checkBox14)
            Me.tabPageAdv3.Controls.Add(Me.dataGrid2)
            Me.tabPageAdv3.Controls.Add(Me.checkBox19)
            Me.tabPageAdv3.Controls.Add(Me.label28)
            Me.tabPageAdv3.Controls.Add(Me.label91)
            Me.tabPageAdv3.Controls.Add(Me.label32)
            Me.tabPageAdv3.Controls.Add(Me.label92)
            Me.tabPageAdv3.Controls.Add(Me.label29)
            Me.tabPageAdv3.Controls.Add(Me.checkBox15)
            Me.tabPageAdv3.Controls.Add(Me.label27)
            Me.tabPageAdv3.Controls.Add(Me.label30)
            Me.tabPageAdv3.Controls.Add(Me.label36)
            Me.tabPageAdv3.Controls.Add(Me.label87)
            Me.tabPageAdv3.Controls.Add(Me.comboBox4)
            Me.tabPageAdv3.Controls.Add(Me.comboBox3)
            Me.tabPageAdv3.Location = New System.Drawing.Point(1, 26)
            Me.tabPageAdv3.Name = "tabPageAdv3"
            Me.tabPageAdv3.Size = New System.Drawing.Size(835, 579)
            Me.tabPageAdv3.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv3.TabIndex = 3
            Me.tabPageAdv3.Text = "UpDownExt Controls"
            Me.tabPageAdv3.ThemesEnabled = False
            '
            'buttonBanner
            '
            Me.buttonBanner.Location = New System.Drawing.Point(253, 427)
            Me.buttonBanner.Name = "buttonBanner"
            Me.buttonBanner.Size = New System.Drawing.Size(99, 23)
            Me.buttonBanner.TabIndex = 2
            Me.buttonBanner.Text = "Set Banner Text"
            Me.buttonBanner.UseVisualStyleBackColor = True
            '
            'comboMode
            '
            Me.comboMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboMode.IgnoreThemeBackground = True
            Me.comboMode.Items.AddRange(New Object() {"EditMode", "FocusMode"})
            Me.comboMode.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboMode, "EditMode"))
            Me.comboMode.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboMode, "FocusMode"))
            Me.comboMode.Location = New System.Drawing.Point(274, 337)
            Me.comboMode.Name = "comboMode"
            Me.comboMode.Size = New System.Drawing.Size(101, 21)
            Me.comboMode.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboMode.TabIndex = 138
            '
            'bEditBanner
            '
            Me.bEditBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bEditBanner.Buttons.Add(Me.buttonEditChildButton11)
            Me.bEditBanner.Controls.Add(Me.buttonEditChildButton11)
            Me.bEditBanner.Controls.Add(Me.textBoxExt7)
            Me.bEditBanner.Location = New System.Drawing.Point(274, 379)
            Me.bEditBanner.Name = "bEditBanner"
            Me.bEditBanner.ShowTextBox = False
            Me.bEditBanner.Size = New System.Drawing.Size(100, 22)
            Me.bEditBanner.TabIndex = 137
            Me.bEditBanner.TextBox = Me.textBoxExt7
            Me.bEditBanner.UseVisualStyle = True
            '
            'buttonEditChildButton11
            '
            Me.buttonEditChildButton11.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton11.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton11.Image = Nothing
            Me.buttonEditChildButton11.Name = "buttonEditChildButton11"
            Me.buttonEditChildButton11.PreferredWidth = 20
            Me.buttonEditChildButton11.TabIndex = 1
            Me.buttonEditChildButton11.Text = "..."
            '
            'textBoxExt7
            '
            Me.textBoxExt7.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt7.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt7.Name = "textBoxExt7"
            Me.textBoxExt7.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt7.Size = New System.Drawing.Size(95, 14)
            Me.textBoxExt7.TabIndex = 0
            '
            'textBanner
            '
            Me.textBanner.Location = New System.Drawing.Point(274, 302)
            Me.textBanner.Name = "textBanner"
            Me.textBanner.Size = New System.Drawing.Size(100, 21)
            Me.textBanner.TabIndex = 136
            '
            'label136
            '
            Me.label136.AutoSize = True
            Me.label136.Location = New System.Drawing.Point(225, 384)
            Me.label136.Name = "label136"
            Me.label136.Size = New System.Drawing.Size(32, 13)
            Me.label136.TabIndex = 135
            Me.label136.Text = "Color"
            '
            'label135
            '
            Me.label135.AutoSize = True
            Me.label135.Location = New System.Drawing.Point(225, 341)
            Me.label135.Name = "label135"
            Me.label135.Size = New System.Drawing.Size(33, 13)
            Me.label135.TabIndex = 134
            Me.label135.Text = "Mode"
            '
            'label134
            '
            Me.label134.AutoSize = True
            Me.label134.Location = New System.Drawing.Point(225, 305)
            Me.label134.Name = "label134"
            Me.label134.Size = New System.Drawing.Size(29, 13)
            Me.label134.TabIndex = 133
            Me.label134.Text = "Text"
            '
            'label133
            '
            Me.label133.AutoSize = True
            Me.label133.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label133.Location = New System.Drawing.Point(412, 437)
            Me.label133.Name = "label133"
            Me.label133.Size = New System.Drawing.Size(102, 13)
            Me.label133.TabIndex = 132
            Me.label133.Text = "Office2007 Style:"
            '
            'label75
            '
            Me.label75.AutoSize = True
            Me.label75.Location = New System.Drawing.Point(409, 379)
            Me.label75.Name = "label75"
            Me.label75.Size = New System.Drawing.Size(97, 26)
            Me.label75.TabIndex = 131
            Me.label75.Text = "DomainUpdownExt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spin Orientation"
            '
            'comboBox19
            '
            Me.comboBox19.BackColor = System.Drawing.Color.White
            Me.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox19.ForeColor = System.Drawing.Color.Black
            Me.comboBox19.Items.AddRange(New Object() {"Vertical", "Horizontal"})
            Me.comboBox19.Location = New System.Drawing.Point(412, 408)
            Me.comboBox19.Name = "comboBox19"
            Me.comboBox19.Size = New System.Drawing.Size(137, 21)
            Me.comboBox19.TabIndex = 130
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.RadioButton12)
            Me.panel1.Controls.Add(Me.radioButton5)
            Me.panel1.Controls.Add(Me.radioButton4)
            Me.panel1.Controls.Add(Me.radioButton3)
            Me.panel1.Location = New System.Drawing.Point(412, 472)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(161, 93)
            Me.panel1.TabIndex = 129
            '
            'RadioButton12
            '
            Me.RadioButton12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButton12.Location = New System.Drawing.Point(3, 69)
            Me.RadioButton12.Name = "RadioButton12"
            Me.RadioButton12.Size = New System.Drawing.Size(141, 15)
            Me.RadioButton12.TabIndex = 56
            Me.RadioButton12.Text = "Managed Color Scheme"
            '
            'radioButton5
            '
            Me.radioButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton5.Location = New System.Drawing.Point(3, 48)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.Size = New System.Drawing.Size(126, 15)
            Me.radioButton5.TabIndex = 55
            Me.radioButton5.Text = "Black Color Scheme"
            '
            'radioButton4
            '
            Me.radioButton4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton4.Location = New System.Drawing.Point(3, 27)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(126, 15)
            Me.radioButton4.TabIndex = 54
            Me.radioButton4.Text = "Silver Color Scheme"
            '
            'radioButton3
            '
            Me.radioButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton3.Location = New System.Drawing.Point(3, 6)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(126, 15)
            Me.radioButton3.TabIndex = 53
            Me.radioButton3.Text = "Blue Color Scheme"
            '
            'radioButton2
            '
            Me.radioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton2.Location = New System.Drawing.Point(111, 329)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(69, 25)
            Me.radioButton2.TabIndex = 45
            Me.radioButton2.Text = "Fixed3D"
            '
            'radioButton1
            '
            Me.radioButton1.Checked = True
            Me.radioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton1.Location = New System.Drawing.Point(111, 305)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(80, 18)
            Me.radioButton1.TabIndex = 44
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "FixedSingle"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(31, 305)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(66, 13)
            Me.label14.TabIndex = 128
            Me.label14.Text = "Border Style"
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.numericUpDownExt7)
            Me.groupBox3.Controls.Add(Me.label24)
            Me.groupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.groupBox3.Location = New System.Drawing.Point(455, 35)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(335, 142)
            Me.groupBox3.TabIndex = 127
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "NumericUpDownExt"
            '
            'numericUpDownExt7
            '
            BannerTextInfo4.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode
            BannerTextInfo4.Text = "<value>"
            BannerTextInfo4.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.numericUpDownExt7, BannerTextInfo4)
            Me.numericUpDownExt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt7.Location = New System.Drawing.Point(107, 90)
            Me.numericUpDownExt7.Name = "numericUpDownExt7"
            Me.numericUpDownExt7.Size = New System.Drawing.Size(136, 21)
            Me.numericUpDownExt7.TabIndex = 124
            '
            'label24
            '
            Me.label24.BackColor = System.Drawing.Color.Transparent
            Me.label24.Dock = System.Windows.Forms.DockStyle.Top
            Me.label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label24.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label24.Location = New System.Drawing.Point(3, 17)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(329, 56)
            Me.label24.TabIndex = 1
            Me.label24.Text = "NumericUpdownExt is an advanced NumericUpdown control to increment/decrement nume" & _
                "ric values. It enables XP Themed look-and-feel for the UpDown." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.domainUpDownExt1)
            Me.groupBox2.Controls.Add(Me.label66)
            Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.groupBox2.Location = New System.Drawing.Point(58, 35)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(319, 142)
            Me.groupBox2.TabIndex = 126
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "DomainUpDownExt"
            '
            'domainUpDownExt1
            '
            BannerTextInfo9.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode
            BannerTextInfo9.Text = "<Value>"
            BannerTextInfo9.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.domainUpDownExt1, BannerTextInfo9)
            Me.domainUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.domainUpDownExt1.Items.Add("Item1")
            Me.domainUpDownExt1.Items.Add("Item2")
            Me.domainUpDownExt1.Items.Add("Item3")
            Me.domainUpDownExt1.Items.Add("Item4")
            Me.domainUpDownExt1.Items.Add("Item5")
            Me.domainUpDownExt1.Location = New System.Drawing.Point(80, 90)
            Me.domainUpDownExt1.Name = "domainUpDownExt1"
            Me.domainUpDownExt1.Size = New System.Drawing.Size(135, 21)
            Me.domainUpDownExt1.TabIndex = 52
            '
            'label66
            '
            Me.label66.BackColor = System.Drawing.Color.Transparent
            Me.label66.Dock = System.Windows.Forms.DockStyle.Top
            Me.label66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label66.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label66.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label66.Location = New System.Drawing.Point(3, 17)
            Me.label66.Name = "label66"
            Me.label66.Size = New System.Drawing.Size(313, 56)
            Me.label66.TabIndex = 1
            Me.label66.Text = "DomainUpDownEx is an advanced DomainUpDown control to increment/decrement string " & _
                "values. It enables XP Themed look-and-feel for the UpDown." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'label88
            '
            Me.label88.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label88.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label88.Image = CType(resources.GetObject("label88.Image"), System.Drawing.Image)
            Me.label88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label88.Location = New System.Drawing.Point(225, 255)
            Me.label88.Name = "label88"
            Me.label88.Size = New System.Drawing.Size(149, 24)
            Me.label88.TabIndex = 87
            Me.label88.Text = "BannerText Settings"
            Me.label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label84
            '
            Me.label84.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label84.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label84.Image = CType(resources.GetObject("label84.Image"), System.Drawing.Image)
            Me.label84.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label84.Location = New System.Drawing.Point(409, 256)
            Me.label84.Name = "label84"
            Me.label84.Size = New System.Drawing.Size(66, 24)
            Me.label84.TabIndex = 89
            Me.label84.Text = "General"
            Me.label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label89
            '
            Me.label89.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label89.Location = New System.Drawing.Point(225, 279)
            Me.label89.Name = "label89"
            Me.label89.Size = New System.Drawing.Size(150, 1)
            Me.label89.TabIndex = 86
            '
            'DomainBorderColorEdit
            '
            Me.DomainBorderColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.DomainBorderColorEdit.Buttons.Add(Me.buttonEditChildButton6)
            Me.DomainBorderColorEdit.Controls.Add(Me.buttonEditChildButton6)
            Me.DomainBorderColorEdit.Location = New System.Drawing.Point(110, 461)
            Me.DomainBorderColorEdit.Name = "DomainBorderColorEdit"
            Me.DomainBorderColorEdit.ShowTextBox = False
            Me.DomainBorderColorEdit.Size = New System.Drawing.Size(82, 27)
            Me.DomainBorderColorEdit.TabIndex = 120
            Me.DomainBorderColorEdit.UseVisualStyle = True
            '
            'buttonEditChildButton6
            '
            Me.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton6.Image = Nothing
            Me.buttonEditChildButton6.Name = "buttonEditChildButton6"
            Me.buttonEditChildButton6.PreferredWidth = 18
            Me.buttonEditChildButton6.TabIndex = 1
            Me.buttonEditChildButton6.Text = "..."
            '
            'checkBox14
            '
            Me.checkBox14.Location = New System.Drawing.Point(412, 305)
            Me.checkBox14.Name = "checkBox14"
            Me.checkBox14.Size = New System.Drawing.Size(137, 24)
            Me.checkBox14.TabIndex = 48
            Me.checkBox14.Text = "ThemesEnabled"
            '
            'dataGrid2
            '
            Me.dataGrid2.DataMember = ""
            Me.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid2.Location = New System.Drawing.Point(591, 355)
            Me.dataGrid2.Name = "dataGrid2"
            Me.dataGrid2.Size = New System.Drawing.Size(215, 133)
            Me.dataGrid2.TabIndex = 94
            '
            'checkBox19
            '
            Me.checkBox19.Location = New System.Drawing.Point(591, 305)
            Me.checkBox19.Name = "checkBox19"
            Me.checkBox19.Size = New System.Drawing.Size(147, 24)
            Me.checkBox19.TabIndex = 92
            Me.checkBox19.Text = "Bind To DataBase"
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Location = New System.Drawing.Point(30, 359)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(79, 13)
            Me.label28.TabIndex = 28
            Me.label28.Text = "Border3D Style"
            '
            'label91
            '
            Me.label91.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label91.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label91.Image = CType(resources.GetObject("label91.Image"), System.Drawing.Image)
            Me.label91.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label91.Location = New System.Drawing.Point(30, 255)
            Me.label91.Name = "label91"
            Me.label91.Size = New System.Drawing.Size(114, 24)
            Me.label91.TabIndex = 85
            Me.label91.Text = "Border Settings"
            Me.label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label32
            '
            Me.label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label32.Location = New System.Drawing.Point(591, 281)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(150, 1)
            Me.label32.TabIndex = 95
            '
            'label92
            '
            Me.label92.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label92.Location = New System.Drawing.Point(30, 279)
            Me.label92.Name = "label92"
            Me.label92.Size = New System.Drawing.Size(150, 1)
            Me.label92.TabIndex = 84
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(29, 409)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(67, 13)
            Me.label29.TabIndex = 29
            Me.label29.Text = "Border Sides"
            '
            'checkBox15
            '
            Me.checkBox15.Checked = True
            Me.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox15.Location = New System.Drawing.Point(412, 335)
            Me.checkBox15.Name = "checkBox15"
            Me.checkBox15.Size = New System.Drawing.Size(126, 24)
            Me.checkBox15.TabIndex = 49
            Me.checkBox15.Text = "InterceptArrowKeys"
            '
            'label27
            '
            Me.label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label27.Image = CType(resources.GetObject("label27.Image"), System.Drawing.Image)
            Me.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label27.Location = New System.Drawing.Point(591, 257)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(99, 24)
            Me.label27.TabIndex = 96
            Me.label27.Text = "Data Binding"
            Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Location = New System.Drawing.Point(31, 461)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(67, 13)
            Me.label30.TabIndex = 30
            Me.label30.Text = "Border Color"
            '
            'label36
            '
            Me.label36.Image = CType(resources.GetObject("label36.Image"), System.Drawing.Image)
            Me.label36.Location = New System.Drawing.Point(536, 338)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(20, 20)
            Me.label36.TabIndex = 50
            Me.toolTip1.SetToolTip(Me.label36, "Allows users to to use the UP ARROW and DOWN ARROW keys to select values.")
            '
            'label87
            '
            Me.label87.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label87.Location = New System.Drawing.Point(409, 280)
            Me.label87.Name = "label87"
            Me.label87.Size = New System.Drawing.Size(140, 1)
            Me.label87.TabIndex = 88
            '
            'comboBox4
            '
            Me.comboBox4.BackColor = System.Drawing.Color.White
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox4.ForeColor = System.Drawing.Color.Black
            Me.comboBox4.Items.AddRange(New Object() {"Left", "Top", "Right", "Bottom", "Middle", "All"})
            Me.comboBox4.Location = New System.Drawing.Point(110, 409)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(84, 21)
            Me.comboBox4.TabIndex = 41
            '
            'comboBox3
            '
            Me.comboBox3.BackColor = System.Drawing.Color.White
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.Enabled = False
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox3.ForeColor = System.Drawing.Color.Black
            Me.comboBox3.Location = New System.Drawing.Point(111, 360)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(84, 21)
            Me.comboBox3.TabIndex = 40
            '
            'tabPageAdv5
            '
            Me.tabPageAdv5.Controls.Add(Me.CheckBox32)
            Me.tabPageAdv5.Controls.Add(Me.CheckBox31)
            Me.tabPageAdv5.Controls.Add(Me.NumericUpDownExt8)
            Me.tabPageAdv5.Controls.Add(Me.Label138)
            Me.tabPageAdv5.Controls.Add(Me.button1)
            Me.tabPageAdv5.Controls.Add(Me.bannerClrEdit)
            Me.tabPageAdv5.Controls.Add(Me.rdoFocus)
            Me.tabPageAdv5.Controls.Add(Me.rdoEdit)
            Me.tabPageAdv5.Controls.Add(Me.txtBanner)
            Me.tabPageAdv5.Controls.Add(Me.label127)
            Me.tabPageAdv5.Controls.Add(Me.label124)
            Me.tabPageAdv5.Controls.Add(Me.label99)
            Me.tabPageAdv5.Controls.Add(Me.label77)
            Me.tabPageAdv5.Controls.Add(Me.label78)
            Me.tabPageAdv5.Controls.Add(Me.groupBox4)
            Me.tabPageAdv5.Controls.Add(Me.label109)
            Me.tabPageAdv5.Controls.Add(Me.checkBox21)
            Me.tabPageAdv5.Controls.Add(Me.label31)
            Me.tabPageAdv5.Controls.Add(Me.label103)
            Me.tabPageAdv5.Controls.Add(Me.label107)
            Me.tabPageAdv5.Controls.Add(Me.checkBox22)
            Me.tabPageAdv5.Controls.Add(Me.buttonEdit2)
            Me.tabPageAdv5.Controls.Add(Me.label108)
            Me.tabPageAdv5.Controls.Add(Me.label106)
            Me.tabPageAdv5.Controls.Add(Me.checkBox23)
            Me.tabPageAdv5.Controls.Add(Me.label115)
            Me.tabPageAdv5.Controls.Add(Me.comboBox12)
            Me.tabPageAdv5.Controls.Add(Me.comboBox11)
            Me.tabPageAdv5.Controls.Add(Me.checkBox24)
            Me.tabPageAdv5.Controls.Add(Me.label113)
            Me.tabPageAdv5.Controls.Add(Me.comboBox9)
            Me.tabPageAdv5.Controls.Add(Me.comboBox10)
            Me.tabPageAdv5.Controls.Add(Me.checkBox25)
            Me.tabPageAdv5.Controls.Add(Me.label114)
            Me.tabPageAdv5.Controls.Add(Me.label101)
            Me.tabPageAdv5.Controls.Add(Me.label105)
            Me.tabPageAdv5.Controls.Add(Me.checkBox26)
            Me.tabPageAdv5.Controls.Add(Me.label111)
            Me.tabPageAdv5.Controls.Add(Me.comboBox8)
            Me.tabPageAdv5.Controls.Add(Me.radioButton11)
            Me.tabPageAdv5.Controls.Add(Me.label102)
            Me.tabPageAdv5.Controls.Add(Me.label112)
            Me.tabPageAdv5.Controls.Add(Me.label100)
            Me.tabPageAdv5.Controls.Add(Me.radioButton10)
            Me.tabPageAdv5.Controls.Add(Me.textBox11)
            Me.tabPageAdv5.Controls.Add(Me.label104)
            Me.tabPageAdv5.Controls.Add(Me.label110)
            Me.tabPageAdv5.Location = New System.Drawing.Point(1, 26)
            Me.tabPageAdv5.Name = "tabPageAdv5"
            Me.tabPageAdv5.Size = New System.Drawing.Size(835, 579)
            Me.tabPageAdv5.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv5.TabIndex = 5
            Me.tabPageAdv5.Text = "TextBoxExt"
            Me.tabPageAdv5.ThemesEnabled = False
            '
            'NumericUpDownExt8
            '
            Me.NumericUpDownExt8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.NumericUpDownExt8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.NumericUpDownExt8.Location = New System.Drawing.Point(99, 383)
            Me.NumericUpDownExt8.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.NumericUpDownExt8.Name = "NumericUpDownExt8"
            Me.NumericUpDownExt8.Size = New System.Drawing.Size(89, 21)
            Me.NumericUpDownExt8.TabIndex = 140
            '
            'Label138
            '
            Me.Label138.AutoSize = True
            Me.Label138.Location = New System.Drawing.Point(16, 383)
            Me.Label138.Margin = New System.Windows.Forms.Padding(0)
            Me.Label138.Name = "Label138"
            Me.Label138.Size = New System.Drawing.Size(72, 13)
            Me.Label138.TabIndex = 139
            Me.Label138.Text = "CornerRadius"
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(345, 515)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(159, 23)
            Me.button1.TabIndex = 138
            Me.button1.Text = "Set Banner Text"
            Me.button1.UseVisualStyleBackColor = True
            '
            'bannerClrEdit
            '
            Me.bannerClrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bannerClrEdit.Buttons.Add(Me.buttonEditChildButton9)
            Me.bannerClrEdit.Controls.Add(Me.buttonEditChildButton9)
            Me.bannerClrEdit.Controls.Add(Me.textBoxExt5)
            Me.bannerClrEdit.Location = New System.Drawing.Point(303, 478)
            Me.bannerClrEdit.Name = "bannerClrEdit"
            Me.bannerClrEdit.ShowTextBox = False
            Me.bannerClrEdit.Size = New System.Drawing.Size(125, 22)
            Me.bannerClrEdit.TabIndex = 137
            Me.bannerClrEdit.TextBox = Me.textBoxExt5
            Me.bannerClrEdit.UseVisualStyle = True
            '
            'buttonEditChildButton9
            '
            Me.buttonEditChildButton9.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton9.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton9.Image = Nothing
            Me.buttonEditChildButton9.Name = "buttonEditChildButton9"
            Me.buttonEditChildButton9.PreferredWidth = 20
            Me.buttonEditChildButton9.TabIndex = 1
            Me.buttonEditChildButton9.Text = "..."
            '
            'textBoxExt5
            '
            Me.textBoxExt5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt5.Location = New System.Drawing.Point(3, 4)
            Me.textBoxExt5.Name = "textBoxExt5"
            Me.textBoxExt5.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt5.Size = New System.Drawing.Size(95, 14)
            Me.textBoxExt5.TabIndex = 0
            '
            'rdoFocus
            '
            Me.rdoFocus.AutoSize = True
            Me.rdoFocus.Checked = True
            Me.rdoFocus.Location = New System.Drawing.Point(502, 480)
            Me.rdoFocus.Name = "rdoFocus"
            Me.rdoFocus.Size = New System.Drawing.Size(82, 17)
            Me.rdoFocus.TabIndex = 136
            Me.rdoFocus.TabStop = True
            Me.rdoFocus.Text = "Focus Mode"
            Me.rdoFocus.UseVisualStyleBackColor = True
            '
            'rdoEdit
            '
            Me.rdoEdit.AutoSize = True
            Me.rdoEdit.Location = New System.Drawing.Point(502, 451)
            Me.rdoEdit.Name = "rdoEdit"
            Me.rdoEdit.Size = New System.Drawing.Size(72, 17)
            Me.rdoEdit.TabIndex = 135
            Me.rdoEdit.TabStop = True
            Me.rdoEdit.Text = "Edit Mode"
            Me.rdoEdit.UseVisualStyleBackColor = True
            '
            'txtBanner
            '
            Me.txtBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtBanner.Location = New System.Drawing.Point(303, 449)
            Me.txtBanner.Name = "txtBanner"
            Me.txtBanner.Size = New System.Drawing.Size(125, 21)
            Me.txtBanner.TabIndex = 134
            '
            'label127
            '
            Me.label127.AutoSize = True
            Me.label127.Location = New System.Drawing.Point(448, 451)
            Me.label127.Name = "label127"
            Me.label127.Size = New System.Drawing.Size(33, 13)
            Me.label127.TabIndex = 133
            Me.label127.Text = "Mode"
            '
            'label124
            '
            Me.label124.AutoSize = True
            Me.label124.Location = New System.Drawing.Point(259, 480)
            Me.label124.Name = "label124"
            Me.label124.Size = New System.Drawing.Size(32, 13)
            Me.label124.TabIndex = 132
            Me.label124.Text = "Color"
            '
            'label99
            '
            Me.label99.AutoSize = True
            Me.label99.Location = New System.Drawing.Point(255, 449)
            Me.label99.Name = "label99"
            Me.label99.Size = New System.Drawing.Size(29, 13)
            Me.label99.TabIndex = 131
            Me.label99.Text = "Text"
            '
            'label77
            '
            Me.label77.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label77.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label77.Image = CType(resources.GetObject("label77.Image"), System.Drawing.Image)
            Me.label77.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label77.Location = New System.Drawing.Point(235, 409)
            Me.label77.Name = "label77"
            Me.label77.Size = New System.Drawing.Size(150, 24)
            Me.label77.TabIndex = 130
            Me.label77.Text = "Banner Text Settings"
            Me.label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label78
            '
            Me.label78.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label78.Location = New System.Drawing.Point(259, 435)
            Me.label78.Name = "label78"
            Me.label78.Size = New System.Drawing.Size(320, 1)
            Me.label78.TabIndex = 129
            '
            'groupBox4
            '
            Me.groupBox4.Controls.Add(Me.label25)
            Me.groupBox4.Controls.Add(Me.textBoxExt4)
            Me.groupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.groupBox4.Location = New System.Drawing.Point(235, 21)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(339, 207)
            Me.groupBox4.TabIndex = 128
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "TextBoxExt"
            '
            'label25
            '
            Me.label25.BackColor = System.Drawing.Color.Transparent
            Me.label25.Dock = System.Windows.Forms.DockStyle.Top
            Me.label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label25.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label25.Location = New System.Drawing.Point(3, 17)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(333, 56)
            Me.label25.TabIndex = 1
            Me.label25.Text = "TextBoxExt is an advanced Textbox control that supports different border colors a" & _
                "nd styles, options to show text overflow indicators and over flow indicator tool" & _
                "tips. "
            '
            'textBoxExt4
            '
            BannerTextInfo10.Text = "<Text>"
            BannerTextInfo10.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.textBoxExt4, BannerTextInfo10)
            Me.textBoxExt4.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.textBoxExt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBoxExt4.FarImage = CType(resources.GetObject("textBoxExt4.FarImage"), System.Drawing.Image)
            Me.textBoxExt4.Location = New System.Drawing.Point(42, 105)
            Me.textBoxExt4.Name = "textBoxExt4"
            Me.textBoxExt4.NearImage = CType(resources.GetObject("textBoxExt4.NearImage"), System.Drawing.Image)
            Me.textBoxExt4.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt4.ShowOverflowIndicatorToolTip = True
            Me.textBoxExt4.Size = New System.Drawing.Size(242, 21)
            Me.textBoxExt4.TabIndex = 0
            Me.textBoxExt4.ThemesEnabled = False
            '
            'label109
            '
            Me.label109.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label109.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label109.Image = CType(resources.GetObject("label109.Image"), System.Drawing.Image)
            Me.label109.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label109.Location = New System.Drawing.Point(421, 281)
            Me.label109.Name = "label109"
            Me.label109.Size = New System.Drawing.Size(126, 24)
            Me.label109.TabIndex = 100
            Me.label109.Text = "OverflowIndicator"
            Me.label109.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'checkBox21
            '
            Me.checkBox21.Location = New System.Drawing.Point(421, 330)
            Me.checkBox21.Name = "checkBox21"
            Me.checkBox21.Size = New System.Drawing.Size(63, 24)
            Me.checkBox21.TabIndex = 61
            Me.checkBox21.Text = "Visible"
            '
            'label31
            '
            Me.label31.Image = CType(resources.GetObject("label31.Image"), System.Drawing.Image)
            Me.label31.Location = New System.Drawing.Point(484, 331)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(20, 20)
            Me.label31.TabIndex = 122
            Me.toolTip1.SetToolTip(Me.label31, "Set the multiLine property as False and enter lengthy text in the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TextBoxExt to" & _
                    " view the OverFlowIndicator." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label103
            '
            Me.label103.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label103.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label103.Image = CType(resources.GetObject("label103.Image"), System.Drawing.Image)
            Me.label103.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label103.Location = New System.Drawing.Point(21, 281)
            Me.label103.Name = "label103"
            Me.label103.Size = New System.Drawing.Size(114, 24)
            Me.label103.TabIndex = 84
            Me.label103.Text = "Border Settings"
            Me.label103.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label107
            '
            Me.label107.AutoSize = True
            Me.label107.Location = New System.Drawing.Point(17, 425)
            Me.label107.Margin = New System.Windows.Forms.Padding(0)
            Me.label107.Name = "label107"
            Me.label107.Size = New System.Drawing.Size(79, 13)
            Me.label107.TabIndex = 76
            Me.label107.Text = "Border3D Style"
            '
            'checkBox22
            '
            Me.checkBox22.Checked = True
            Me.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox22.Location = New System.Drawing.Point(303, 326)
            Me.checkBox22.Name = "checkBox22"
            Me.checkBox22.Size = New System.Drawing.Size(85, 24)
            Me.checkBox22.TabIndex = 92
            Me.checkBox22.Text = "Word Wrap"
            '
            'buttonEdit2
            '
            Me.buttonEdit2.BackColor = System.Drawing.Color.White
            Me.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit2.Buttons.Add(Me.buttonEditChildButton4)
            Me.buttonEdit2.Controls.Add(Me.buttonEditChildButton4)
            Me.buttonEdit2.Controls.Add(Me.textBoxExt3)
            Me.buttonEdit2.Location = New System.Drawing.Point(99, 525)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.ShowTextBox = False
            Me.buttonEdit2.Size = New System.Drawing.Size(95, 22)
            Me.buttonEdit2.TabIndex = 121
            Me.buttonEdit2.TextBox = Me.textBoxExt3
            Me.buttonEdit2.UseVisualStyle = True
            '
            'buttonEditChildButton4
            '
            Me.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton4.Image = Nothing
            Me.buttonEditChildButton4.Name = "buttonEditChildButton4"
            Me.buttonEditChildButton4.PreferredWidth = 18
            Me.buttonEditChildButton4.TabIndex = 1
            Me.buttonEditChildButton4.Text = "..."
            '
            'textBoxExt3
            '
            Me.textBoxExt3.BackColor = System.Drawing.Color.White
            Me.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt3.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt3.Name = "textBoxExt3"
            Me.textBoxExt3.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt3.ShowOverflowIndicatorToolTip = True
            Me.textBoxExt3.Size = New System.Drawing.Size(97, 14)
            Me.textBoxExt3.TabIndex = 0
            '
            'label108
            '
            Me.label108.AutoSize = True
            Me.label108.Location = New System.Drawing.Point(638, 383)
            Me.label108.Name = "label108"
            Me.label108.Size = New System.Drawing.Size(55, 13)
            Me.label108.TabIndex = 91
            Me.label108.Text = "Text Align"
            '
            'label106
            '
            Me.label106.AutoSize = True
            Me.label106.Location = New System.Drawing.Point(17, 475)
            Me.label106.Name = "label106"
            Me.label106.Size = New System.Drawing.Size(67, 13)
            Me.label106.TabIndex = 77
            Me.label106.Text = "Border Sides"
            '
            'checkBox23
            '
            Me.checkBox23.Location = New System.Drawing.Point(724, 425)
            Me.checkBox23.Name = "checkBox23"
            Me.checkBox23.Size = New System.Drawing.Size(89, 24)
            Me.checkBox23.TabIndex = 93
            Me.checkBox23.Text = "Right To Left"
            '
            'label115
            '
            Me.label115.AutoSize = True
            Me.label115.Location = New System.Drawing.Point(17, 525)
            Me.label115.Name = "label115"
            Me.label115.Size = New System.Drawing.Size(67, 13)
            Me.label115.TabIndex = 120
            Me.label115.Text = "Border Color"
            '
            'comboBox12
            '
            Me.comboBox12.BackColor = System.Drawing.Color.White
            Me.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox12.ForeColor = System.Drawing.Color.Black
            Me.comboBox12.Items.AddRange(New Object() {"Left", "Right", "Center"})
            Me.comboBox12.Location = New System.Drawing.Point(738, 372)
            Me.comboBox12.Name = "comboBox12"
            Me.comboBox12.Size = New System.Drawing.Size(75, 21)
            Me.comboBox12.TabIndex = 90
            '
            'comboBox11
            '
            Me.comboBox11.BackColor = System.Drawing.Color.White
            Me.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox11.Enabled = False
            Me.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox11.ForeColor = System.Drawing.Color.Black
            Me.comboBox11.Location = New System.Drawing.Point(99, 425)
            Me.comboBox11.Name = "comboBox11"
            Me.comboBox11.Size = New System.Drawing.Size(95, 21)
            Me.comboBox11.TabIndex = 78
            '
            'checkBox24
            '
            Me.checkBox24.Location = New System.Drawing.Point(638, 425)
            Me.checkBox24.Name = "checkBox24"
            Me.checkBox24.Size = New System.Drawing.Size(112, 24)
            Me.checkBox24.TabIndex = 94
            Me.checkBox24.Text = "Read Only"
            '
            'label113
            '
            Me.label113.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label113.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label113.Image = CType(resources.GetObject("label113.Image"), System.Drawing.Image)
            Me.label113.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label113.Location = New System.Drawing.Point(638, 281)
            Me.label113.Name = "label113"
            Me.label113.Size = New System.Drawing.Size(75, 24)
            Me.label113.TabIndex = 104
            Me.label113.Text = "General"
            Me.label113.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox9
            '
            Me.comboBox9.BackColor = System.Drawing.Color.White
            Me.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox9.ForeColor = System.Drawing.Color.Black
            Me.comboBox9.Items.AddRange(New Object() {"None", "Horizontal", "Vertical", "Both"})
            Me.comboBox9.Location = New System.Drawing.Point(286, 369)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(96, 21)
            Me.comboBox9.TabIndex = 88
            '
            'comboBox10
            '
            Me.comboBox10.BackColor = System.Drawing.Color.White
            Me.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox10.ForeColor = System.Drawing.Color.Black
            Me.comboBox10.Items.AddRange(New Object() {"Left", "Top", "Right", "Bottom", "Middle", "All"})
            Me.comboBox10.Location = New System.Drawing.Point(99, 478)
            Me.comboBox10.Name = "comboBox10"
            Me.comboBox10.Size = New System.Drawing.Size(95, 21)
            Me.comboBox10.TabIndex = 79
            '
            'checkBox25
            '
            Me.checkBox25.Location = New System.Drawing.Point(238, 326)
            Me.checkBox25.Name = "checkBox25"
            Me.checkBox25.Size = New System.Drawing.Size(112, 24)
            Me.checkBox25.TabIndex = 95
            Me.checkBox25.Text = "MultiLine"
            '
            'label114
            '
            Me.label114.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label114.Location = New System.Drawing.Point(638, 305)
            Me.label114.Name = "label114"
            Me.label114.Size = New System.Drawing.Size(150, 1)
            Me.label114.TabIndex = 103
            '
            'label101
            '
            Me.label101.AutoSize = True
            Me.label101.Location = New System.Drawing.Point(232, 372)
            Me.label101.Name = "label101"
            Me.label101.Size = New System.Drawing.Size(53, 13)
            Me.label101.TabIndex = 87
            Me.label101.Text = "Scrollbars"
            '
            'label105
            '
            Me.label105.AutoSize = True
            Me.label105.Location = New System.Drawing.Point(21, 330)
            Me.label105.Name = "label105"
            Me.label105.Size = New System.Drawing.Size(66, 13)
            Me.label105.TabIndex = 80
            Me.label105.Text = "Border Style"
            '
            'checkBox26
            '
            Me.checkBox26.Location = New System.Drawing.Point(520, 330)
            Me.checkBox26.Name = "checkBox26"
            Me.checkBox26.Size = New System.Drawing.Size(94, 24)
            Me.checkBox26.TabIndex = 96
            Me.checkBox26.Text = "ToolTip visible"
            '
            'label111
            '
            Me.label111.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label111.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label111.Image = CType(resources.GetObject("label111.Image"), System.Drawing.Image)
            Me.label111.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label111.Location = New System.Drawing.Point(238, 281)
            Me.label111.Name = "label111"
            Me.label111.Size = New System.Drawing.Size(84, 24)
            Me.label111.TabIndex = 102
            Me.label111.Text = "MultiLine"
            Me.label111.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox8
            '
            Me.comboBox8.BackColor = System.Drawing.Color.White
            Me.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox8.ForeColor = System.Drawing.Color.Black
            Me.comboBox8.Items.AddRange(New Object() {"Normal", "Upper Case", "Lower Case"})
            Me.comboBox8.Location = New System.Drawing.Point(734, 327)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(75, 21)
            Me.comboBox8.TabIndex = 86
            '
            'radioButton11
            '
            Me.radioButton11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton11.Location = New System.Drawing.Point(97, 325)
            Me.radioButton11.Name = "radioButton11"
            Me.radioButton11.Size = New System.Drawing.Size(82, 21)
            Me.radioButton11.TabIndex = 81
            Me.radioButton11.Text = "FixedSingle"
            '
            'label102
            '
            Me.label102.AutoSize = True
            Me.label102.Location = New System.Drawing.Point(418, 372)
            Me.label102.Name = "label102"
            Me.label102.Size = New System.Drawing.Size(63, 13)
            Me.label102.TabIndex = 97
            Me.label102.Text = "ToolTipText"
            '
            'label112
            '
            Me.label112.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label112.Location = New System.Drawing.Point(238, 306)
            Me.label112.Name = "label112"
            Me.label112.Size = New System.Drawing.Size(150, 1)
            Me.label112.TabIndex = 101
            '
            'label100
            '
            Me.label100.AutoSize = True
            Me.label100.Location = New System.Drawing.Point(638, 331)
            Me.label100.Name = "label100"
            Me.label100.Size = New System.Drawing.Size(90, 13)
            Me.label100.TabIndex = 85
            Me.label100.Text = "Character Casing"
            '
            'radioButton10
            '
            Me.radioButton10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton10.Location = New System.Drawing.Point(99, 349)
            Me.radioButton10.Name = "radioButton10"
            Me.radioButton10.Size = New System.Drawing.Size(74, 15)
            Me.radioButton10.TabIndex = 82
            Me.radioButton10.Text = "Fixed3D"
            '
            'textBox11
            '
            Me.textBox11.Location = New System.Drawing.Point(487, 369)
            Me.textBox11.Name = "textBox11"
            Me.textBox11.Size = New System.Drawing.Size(91, 21)
            Me.textBox11.TabIndex = 98
            Me.textBox11.Text = "Text Overflowed"
            '
            'label104
            '
            Me.label104.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label104.Location = New System.Drawing.Point(21, 305)
            Me.label104.Name = "label104"
            Me.label104.Size = New System.Drawing.Size(150, 1)
            Me.label104.TabIndex = 83
            '
            'label110
            '
            Me.label110.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label110.Location = New System.Drawing.Point(421, 309)
            Me.label110.Name = "label110"
            Me.label110.Size = New System.Drawing.Size(150, 1)
            Me.label110.TabIndex = 99
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.Controls.Add(Me.groupBox5)
            Me.tabPageAdv2.Controls.Add(Me.label15)
            Me.tabPageAdv2.Controls.Add(Me.label16)
            Me.tabPageAdv2.Controls.Add(Me.label86)
            Me.tabPageAdv2.Controls.Add(Me.comboBox1)
            Me.tabPageAdv2.Controls.Add(Me.radClassic)
            Me.tabPageAdv2.Controls.Add(Me.label85)
            Me.tabPageAdv2.Controls.Add(Me.label83)
            Me.tabPageAdv2.Controls.Add(Me.label17)
            Me.tabPageAdv2.Controls.Add(Me.label82)
            Me.tabPageAdv2.Controls.Add(Me.groupBox1)
            Me.tabPageAdv2.Controls.Add(Me.checkBox13)
            Me.tabPageAdv2.Controls.Add(Me.comboBox2)
            Me.tabPageAdv2.Controls.Add(Me.radOffice2000)
            Me.tabPageAdv2.Controls.Add(Me.radOffice2007)
            Me.tabPageAdv2.Controls.Add(Me.label23)
            Me.tabPageAdv2.Controls.Add(Me.label18)
            Me.tabPageAdv2.Controls.Add(Me.radOfficeXP)
            Me.tabPageAdv2.Controls.Add(Me.cboButtonType)
            Me.tabPageAdv2.Controls.Add(Me.label20)
            Me.tabPageAdv2.Controls.Add(Me.radWinXP)
            Me.tabPageAdv2.Controls.Add(Me.label21)
            Me.tabPageAdv2.Controls.Add(Me.label19)
            Me.tabPageAdv2.Controls.Add(Me.radOffice2003)
            Me.tabPageAdv2.Controls.Add(Me.checkBox18)
            Me.tabPageAdv2.Controls.Add(Me.label22)
            Me.tabPageAdv2.Controls.Add(Me.checkBox12)
            Me.tabPageAdv2.Controls.Add(Me.checkBox17)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 26)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.Size = New System.Drawing.Size(835, 579)
            Me.tabPageAdv2.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv2.TabIndex = 2
            Me.tabPageAdv2.Text = "Currency Edit"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'groupBox5
            '
            Me.groupBox5.Controls.Add(Me.label65)
            Me.groupBox5.Controls.Add(Me.currencyEdit1)
            Me.groupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.groupBox5.Location = New System.Drawing.Point(237, 21)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(326, 142)
            Me.groupBox5.TabIndex = 129
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "CurrencyEdit"
            '
            'label65
            '
            Me.label65.BackColor = System.Drawing.Color.Transparent
            Me.label65.Dock = System.Windows.Forms.DockStyle.Top
            Me.label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label65.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label65.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label65.Location = New System.Drawing.Point(3, 17)
            Me.label65.Name = "label65"
            Me.label65.Size = New System.Drawing.Size(320, 56)
            Me.label65.TabIndex = 1
            Me.label65.Text = "Currency Edit is used to display currency values with a calculator button to disp" & _
                "lay a dropdown calculator." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'currencyEdit1
            '
            Me.currencyEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.currencyEdit1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.currencyEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            '
            '
            '
            Me.currencyEdit1.CalculatorButton.BackColor = System.Drawing.SystemColors.ControlLight
            Me.currencyEdit1.CalculatorButton.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator
            Me.currencyEdit1.CalculatorButton.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.currencyEdit1.CalculatorButton.Dock = System.Windows.Forms.DockStyle.Right
            Me.currencyEdit1.CalculatorButton.Image = CType(resources.GetObject("currencyEdit1.CalculatorButton.Image"), System.Drawing.Image)
            Me.currencyEdit1.CalculatorButton.Name = ""
            Me.currencyEdit1.CalculatorButton.PreferredWidth = 24
            Me.currencyEdit1.CalculatorButton.TabIndex = 1
            Me.currencyEdit1.CloseAction = Syncfusion.Windows.Forms.Tools.CalcActions.CalcOperatorEquals
            Me.currencyEdit1.FlatBorderColor = System.Drawing.SystemColors.ControlLight
            Me.currencyEdit1.Location = New System.Drawing.Point(55, 86)
            Me.currencyEdit1.Name = "currencyEdit1"
            Me.currencyEdit1.PopupCalculatorAlignment = Syncfusion.Windows.Forms.Tools.CalculatorPopupAlignment.Left
            Me.currencyEdit1.ShowCalculator = True
            Me.currencyEdit1.ShowTextBox = False
            Me.currencyEdit1.Size = New System.Drawing.Size(177, 22)
            Me.currencyEdit1.TabIndex = 4
            '
            '
            '
            Me.currencyEdit1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.currencyEdit1.TextBox.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
            Me.currencyEdit1.TextBox.Location = New System.Drawing.Point(2, 4)
            Me.currencyEdit1.TextBox.Name = ""
            Me.currencyEdit1.TextBox.NegativeInputPendingOnSelectAll = False
            Me.currencyEdit1.TextBox.NullString = "0"
            Me.currencyEdit1.TextBox.OverflowIndicatorToolTipText = Nothing
            Me.currencyEdit1.TextBox.Size = New System.Drawing.Size(91, 14)
            Me.currencyEdit1.TextBox.TabIndex = 0
            Me.currencyEdit1.TextBox.Visible = False
            Me.currencyEdit1.UseVisualStyle = True
            '
            'label15
            '
            Me.label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label15.Image = CType(resources.GetObject("label15.Image"), System.Drawing.Image)
            Me.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label15.Location = New System.Drawing.Point(27, 235)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(120, 24)
            Me.label15.TabIndex = 26
            Me.label15.Text = "Culture Settings"
            Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label16
            '
            Me.label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label16.Location = New System.Drawing.Point(27, 263)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(150, 1)
            Me.label16.TabIndex = 25
            '
            'label86
            '
            Me.label86.Image = CType(resources.GetObject("label86.Image"), System.Drawing.Image)
            Me.label86.Location = New System.Drawing.Point(774, 350)
            Me.label86.Name = "label86"
            Me.label86.Size = New System.Drawing.Size(20, 20)
            Me.label86.TabIndex = 94
            Me.toolTip1.SetToolTip(Me.label86, "Specifies whether to transfer the calculated value to the edit control." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.ForeColor = System.Drawing.Color.Black
            Me.comboBox1.Location = New System.Drawing.Point(30, 294)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(133, 21)
            Me.comboBox1.TabIndex = 27
            '
            'radClassic
            '
            Me.radClassic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radClassic.Location = New System.Drawing.Point(450, 279)
            Me.radClassic.Name = "radClassic"
            Me.radClassic.Size = New System.Drawing.Size(96, 27)
            Me.radClassic.TabIndex = 0
            Me.radClassic.Text = "Classic"
            '
            'label85
            '
            Me.label85.Image = CType(resources.GetObject("label85.Image"), System.Drawing.Image)
            Me.label85.Location = New System.Drawing.Point(774, 383)
            Me.label85.Name = "label85"
            Me.label85.Size = New System.Drawing.Size(20, 20)
            Me.label85.TabIndex = 52
            Me.toolTip1.SetToolTip(Me.label85, "Specifies whether to transfer the value from the edit control to the calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
                    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label83
            '
            Me.label83.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label83.Location = New System.Drawing.Point(628, 264)
            Me.label83.Name = "label83"
            Me.label83.Size = New System.Drawing.Size(150, 1)
            Me.label83.TabIndex = 86
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Location = New System.Drawing.Point(27, 278)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(91, 13)
            Me.label17.TabIndex = 28
            Me.label17.Text = "Culture Full Name"
            '
            'label82
            '
            Me.label82.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label82.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label82.Image = CType(resources.GetObject("label82.Image"), System.Drawing.Image)
            Me.label82.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label82.Location = New System.Drawing.Point(626, 235)
            Me.label82.Name = "label82"
            Me.label82.Size = New System.Drawing.Size(66, 24)
            Me.label82.TabIndex = 87
            Me.label82.Text = "Others"
            Me.label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.White
            Me.groupBox1.Controls.Add(Me.radWinStd)
            Me.groupBox1.Controls.Add(Me.radFinancial)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.groupBox1.Location = New System.Drawing.Point(214, 330)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(144, 93)
            Me.groupBox1.TabIndex = 93
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Calculator Type"
            '
            'radWinStd
            '
            Me.radWinStd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radWinStd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radWinStd.Location = New System.Drawing.Point(6, 20)
            Me.radWinStd.Name = "radWinStd"
            Me.radWinStd.Size = New System.Drawing.Size(132, 25)
            Me.radWinStd.TabIndex = 33
            Me.radWinStd.Text = "Windows Standard"
            '
            'radFinancial
            '
            Me.radFinancial.Checked = True
            Me.radFinancial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radFinancial.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radFinancial.Location = New System.Drawing.Point(6, 56)
            Me.radFinancial.Name = "radFinancial"
            Me.radFinancial.Size = New System.Drawing.Size(132, 25)
            Me.radFinancial.TabIndex = 34
            Me.radFinancial.TabStop = True
            Me.radFinancial.Text = "Financial"
            '
            'checkBox13
            '
            Me.checkBox13.ForeColor = System.Drawing.Color.Black
            Me.checkBox13.Location = New System.Drawing.Point(632, 427)
            Me.checkBox13.Name = "checkBox13"
            Me.checkBox13.Size = New System.Drawing.Size(146, 24)
            Me.checkBox13.TabIndex = 41
            Me.checkBox13.Text = "Read Only"
            '
            'comboBox2
            '
            Me.comboBox2.BackColor = System.Drawing.Color.White
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox2.ForeColor = System.Drawing.Color.Black
            Me.comboBox2.Location = New System.Drawing.Point(30, 361)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(133, 21)
            Me.comboBox2.TabIndex = 29
            '
            'radOffice2000
            '
            Me.radOffice2000.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radOffice2000.Location = New System.Drawing.Point(450, 396)
            Me.radOffice2000.Name = "radOffice2000"
            Me.radOffice2000.Size = New System.Drawing.Size(81, 27)
            Me.radOffice2000.TabIndex = 1
            Me.radOffice2000.Text = "Office 2000"
            '
            'radOffice2007
            '
            Me.radOffice2007.Checked = True
            Me.radOffice2007.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radOffice2007.Location = New System.Drawing.Point(450, 474)
            Me.radOffice2007.Name = "radOffice2007"
            Me.radOffice2007.Size = New System.Drawing.Size(96, 27)
            Me.radOffice2007.TabIndex = 2
            Me.radOffice2007.TabStop = True
            Me.radOffice2007.Text = "Office 2007"
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Location = New System.Drawing.Point(632, 280)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(66, 13)
            Me.label23.TabIndex = 40
            Me.label23.Text = "Button Type"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Location = New System.Drawing.Point(27, 341)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(101, 13)
            Me.label18.TabIndex = 30
            Me.label18.Text = "Culture Short Name"
            '
            'radOfficeXP
            '
            Me.radOfficeXP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radOfficeXP.Location = New System.Drawing.Point(450, 357)
            Me.radOfficeXP.Name = "radOfficeXP"
            Me.radOfficeXP.Size = New System.Drawing.Size(96, 27)
            Me.radOfficeXP.TabIndex = 5
            Me.radOfficeXP.Text = "Office XP"
            '
            'cboButtonType
            '
            Me.cboButtonType.BackColor = System.Drawing.Color.White
            Me.cboButtonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboButtonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboButtonType.ForeColor = System.Drawing.Color.Black
            Me.cboButtonType.Location = New System.Drawing.Point(635, 305)
            Me.cboButtonType.Name = "cboButtonType"
            Me.cboButtonType.Size = New System.Drawing.Size(143, 21)
            Me.cboButtonType.TabIndex = 39
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.Location = New System.Drawing.Point(214, 263)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(150, 1)
            Me.label20.TabIndex = 31
            '
            'radWinXP
            '
            Me.radWinXP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radWinXP.Location = New System.Drawing.Point(450, 318)
            Me.radWinXP.Name = "radWinXP"
            Me.radWinXP.Size = New System.Drawing.Size(96, 27)
            Me.radWinXP.TabIndex = 6
            Me.radWinXP.Text = "Windows XP"
            '
            'label21
            '
            Me.label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label21.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label21.Image = CType(resources.GetObject("label21.Image"), System.Drawing.Image)
            Me.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label21.Location = New System.Drawing.Point(435, 235)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(96, 24)
            Me.label21.TabIndex = 37
            Me.label21.Text = "Button Style"
            Me.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label19
            '
            Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Image = CType(resources.GetObject("label19.Image"), System.Drawing.Image)
            Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label19.Location = New System.Drawing.Point(214, 235)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(130, 24)
            Me.label19.TabIndex = 32
            Me.label19.Text = "Calculator Settings"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'radOffice2003
            '
            Me.radOffice2003.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radOffice2003.Location = New System.Drawing.Point(450, 435)
            Me.radOffice2003.Name = "radOffice2003"
            Me.radOffice2003.Size = New System.Drawing.Size(96, 27)
            Me.radOffice2003.TabIndex = 3
            Me.radOffice2003.Text = "Office 2003"
            '
            'checkBox18
            '
            Me.checkBox18.ForeColor = System.Drawing.Color.Black
            Me.checkBox18.Location = New System.Drawing.Point(632, 387)
            Me.checkBox18.Name = "checkBox18"
            Me.checkBox18.Size = New System.Drawing.Size(148, 17)
            Me.checkBox18.TabIndex = 91
            Me.checkBox18.Text = "TransferToCalculator"
            '
            'label22
            '
            Me.label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label22.Location = New System.Drawing.Point(435, 263)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(150, 1)
            Me.label22.TabIndex = 36
            '
            'checkBox12
            '
            Me.checkBox12.Checked = True
            Me.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox12.ForeColor = System.Drawing.Color.Black
            Me.checkBox12.Location = New System.Drawing.Point(214, 285)
            Me.checkBox12.Name = "checkBox12"
            Me.checkBox12.Size = New System.Drawing.Size(120, 16)
            Me.checkBox12.TabIndex = 35
            Me.checkBox12.Text = "Show Calculator"
            '
            'checkBox17
            '
            Me.checkBox17.Checked = True
            Me.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox17.ForeColor = System.Drawing.Color.Black
            Me.checkBox17.Location = New System.Drawing.Point(632, 348)
            Me.checkBox17.Name = "checkBox17"
            Me.checkBox17.Size = New System.Drawing.Size(146, 16)
            Me.checkBox17.TabIndex = 90
            Me.checkBox17.Text = "TransferFromCalculator"
            '
            'tabPageAdv6
            '
            Me.tabPageAdv6.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tabPageAdv6.Controls.Add(Me.checkBox28)
            Me.tabPageAdv6.Controls.Add(Me.label123)
            Me.tabPageAdv6.Controls.Add(Me.checkBox27)
            Me.tabPageAdv6.Controls.Add(Me.comboBox13)
            Me.tabPageAdv6.Controls.Add(Me.label117)
            Me.tabPageAdv6.Controls.Add(Me.gradientPanel4)
            Me.tabPageAdv6.Controls.Add(Me.label118)
            Me.tabPageAdv6.Controls.Add(Me.label119)
            Me.tabPageAdv6.Controls.Add(Me.label120)
            Me.tabPageAdv6.Controls.Add(Me.label121)
            Me.tabPageAdv6.Controls.Add(Me.editableList2)
            Me.tabPageAdv6.Controls.Add(Me.gradientPanel3)
            Me.tabPageAdv6.Controls.Add(Me.editableList1)
            Me.tabPageAdv6.Location = New System.Drawing.Point(1, 26)
            Me.tabPageAdv6.Name = "tabPageAdv6"
            Me.tabPageAdv6.Size = New System.Drawing.Size(835, 579)
            Me.tabPageAdv6.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv6.TabIndex = 6
            Me.tabPageAdv6.Text = "Editable List"
            Me.tabPageAdv6.ThemesEnabled = False
            '
            'checkBox28
            '
            Me.checkBox28.Location = New System.Drawing.Point(548, 283)
            Me.checkBox28.Name = "checkBox28"
            Me.checkBox28.Size = New System.Drawing.Size(89, 24)
            Me.checkBox28.TabIndex = 87
            Me.checkBox28.Text = "Right To Left"
            '
            'label123
            '
            Me.label123.Image = CType(resources.GetObject("label123.Image"), System.Drawing.Image)
            Me.label123.Location = New System.Drawing.Point(422, 287)
            Me.label123.Name = "label123"
            Me.label123.Size = New System.Drawing.Size(20, 20)
            Me.label123.TabIndex = 86
            Me.toolTip1.SetToolTip(Me.label123, "Shows/Hides the button that appears to the right while editing.")
            '
            'checkBox27
            '
            Me.checkBox27.Checked = True
            Me.checkBox27.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox27.Location = New System.Drawing.Point(327, 283)
            Me.checkBox27.Name = "checkBox27"
            Me.checkBox27.Size = New System.Drawing.Size(89, 24)
            Me.checkBox27.TabIndex = 85
            Me.checkBox27.Text = "Want Button"
            '
            'comboBox13
            '
            Me.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox13.ForeColor = System.Drawing.Color.Black
            Me.comboBox13.Items.AddRange(New Object() {"Left", "Right", "Center"})
            Me.comboBox13.Location = New System.Drawing.Point(169, 280)
            Me.comboBox13.Name = "comboBox13"
            Me.comboBox13.Size = New System.Drawing.Size(75, 21)
            Me.comboBox13.TabIndex = 84
            '
            'label117
            '
            Me.label117.AutoSize = True
            Me.label117.Location = New System.Drawing.Point(71, 283)
            Me.label117.Name = "label117"
            Me.label117.Size = New System.Drawing.Size(92, 13)
            Me.label117.TabIndex = 83
            Me.label117.Text = "ListBox Text Align"
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.label122)
            Me.gradientPanel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel4.Location = New System.Drawing.Point(169, 403)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(449, 48)
            Me.gradientPanel4.TabIndex = 82
            '
            'label122
            '
            Me.label122.BackColor = System.Drawing.Color.Transparent
            Me.label122.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label122.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label122.Image = CType(resources.GetObject("label122.Image"), System.Drawing.Image)
            Me.label122.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label122.Location = New System.Drawing.Point(0, 0)
            Me.label122.Name = "label122"
            Me.label122.Size = New System.Drawing.Size(447, 46)
            Me.label122.TabIndex = 1
            Me.label122.Text = "Drag file names from Windows Explorer and drop them into EditableList. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double C" & _
                "lick on to any item to edit"
            '
            'label118
            '
            Me.label118.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label118.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label118.Image = CType(resources.GetObject("label118.Image"), System.Drawing.Image)
            Me.label118.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label118.Location = New System.Drawing.Point(67, 237)
            Me.label118.Name = "label118"
            Me.label118.Size = New System.Drawing.Size(86, 24)
            Me.label118.TabIndex = 81
            Me.label118.Text = "Properties"
            Me.label118.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label119
            '
            Me.label119.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label119.Location = New System.Drawing.Point(67, 261)
            Me.label119.Name = "label119"
            Me.label119.Size = New System.Drawing.Size(650, 1)
            Me.label119.TabIndex = 80
            '
            'label120
            '
            Me.label120.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label120.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label120.Image = CType(resources.GetObject("label120.Image"), System.Drawing.Image)
            Me.label120.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label120.Location = New System.Drawing.Point(63, 365)
            Me.label120.Name = "label120"
            Me.label120.Size = New System.Drawing.Size(109, 24)
            Me.label120.TabIndex = 79
            Me.label120.Text = "Drag And Drop"
            Me.label120.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label121
            '
            Me.label121.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label121.Location = New System.Drawing.Point(63, 389)
            Me.label121.Name = "label121"
            Me.label121.Size = New System.Drawing.Size(650, 1)
            Me.label121.TabIndex = 78
            '
            'editableList2
            '
            Me.editableList2.AllowDrop = True
            Me.editableList2.AutoScroll = True
            '
            '
            '
            Me.editableList2.Button.BackColor = System.Drawing.Color.Azure
            Me.editableList2.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.editableList2.Button.ImageList = Me.imageList1
            Me.editableList2.Button.Location = New System.Drawing.Point(112, 120)
            Me.editableList2.Button.Name = "button"
            Me.editableList2.Button.Size = New System.Drawing.Size(30, 20)
            Me.editableList2.Button.TabIndex = 2
            Me.editableList2.Button.Text = "..."
            Me.editableList2.Button.UseVisualStyleBackColor = False
            Me.editableList2.Button.Visible = False
            '
            '
            '
            Me.editableList2.ListBox.ColumnWidth = 1
            Me.editableList2.ListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editableList2.ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
            Me.editableList2.ListBox.Location = New System.Drawing.Point(0, 0)
            Me.editableList2.ListBox.Name = "listBox"
            Me.editableList2.ListBox.Size = New System.Drawing.Size(354, 97)
            Me.editableList2.ListBox.TabIndex = 0
            Me.editableList2.Location = New System.Drawing.Point(217, 457)
            Me.editableList2.Name = "editableList2"
            Me.editableList2.Size = New System.Drawing.Size(354, 97)
            Me.editableList2.TabIndex = 9
            '
            '
            '
            Me.editableList2.TextBox.BackColor = System.Drawing.SystemColors.Info
            Me.editableList2.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.editableList2.TextBox.Location = New System.Drawing.Point(8, 120)
            Me.editableList2.TextBox.Name = "textBox"
            Me.editableList2.TextBox.TabIndex = 2
            Me.editableList2.TextBox.Visible = False
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.label116)
            Me.gradientPanel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel3.Location = New System.Drawing.Point(89, 16)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(602, 55)
            Me.gradientPanel3.TabIndex = 8
            '
            'label116
            '
            Me.label116.BackColor = System.Drawing.Color.Transparent
            Me.label116.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label116.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label116.Image = CType(resources.GetObject("label116.Image"), System.Drawing.Image)
            Me.label116.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label116.Location = New System.Drawing.Point(0, 0)
            Me.label116.Name = "label116"
            Me.label116.Size = New System.Drawing.Size(600, 53)
            Me.label116.TabIndex = 1
            Me.label116.Text = "EditableList control provides an editable Windows Forms list box with a Windows F" & _
                "orms text box and button on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the current row to facilitate in-place editing.You" & _
                " need to double Click on items to edit"
            '
            'editableList1
            '
            Me.editableList1.AllowDrop = True
            Me.editableList1.AutoScroll = True
            Me.editableList1.BackColor = System.Drawing.Color.White
            Me.editableList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            '
            '
            '
            Me.editableList1.Button.BackColor = System.Drawing.Color.Azure
            Me.editableList1.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.editableList1.Button.ImageIndex = 0
            Me.editableList1.Button.Location = New System.Drawing.Point(448, 64)
            Me.editableList1.Button.Name = "button"
            Me.editableList1.Button.Size = New System.Drawing.Size(30, 20)
            Me.editableList1.Button.TabIndex = 2
            Me.editableList1.Button.Text = "..."
            Me.editableList1.Button.UseVisualStyleBackColor = False
            Me.editableList1.Button.Visible = False
            Me.editableList1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.editableList1.ListBox.ColumnWidth = 1
            Me.editableList1.ListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editableList1.ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
            Me.editableList1.ListBox.Items.AddRange(New Object() {"C:\Program Files\Syncfusion\Essential Suite\", "C:\Program Files\Syncfusion\Essential Suite\Tools\", "C:\Program Files\Syncfusion\Essential Suite\Tools\Samples\", "C:\Program Files\Syncfusion\Essential Suite\Tools\Samples\EditableList\", "C:\Program Files\Syncfusion\Essential Suite\Tools\Samples\EditableList\EditableLi" & _
                            "stDemo\", "C:\Program Files\Syncfusion\Essential Suite\Tools\Samples\EditableList\EditableLi" & _
                            "stDemo\CS\", "C:\Program Files\Syncfusion\Essential Suite\Tools\Samples\EditableList\EditableLi" & _
                            "stDemo\VB\"})
            Me.editableList1.ListBox.Location = New System.Drawing.Point(0, 0)
            Me.editableList1.ListBox.Name = "listBox"
            Me.editableList1.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.editableList1.ListBox.Size = New System.Drawing.Size(354, 113)
            Me.editableList1.ListBox.TabIndex = 0
            Me.editableList1.Location = New System.Drawing.Point(217, 94)
            Me.editableList1.Name = "editableList1"
            Me.editableList1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.editableList1.Size = New System.Drawing.Size(354, 113)
            Me.editableList1.TabIndex = 7
            '
            '
            '
            Me.editableList1.TextBox.BackColor = System.Drawing.SystemColors.Info
            Me.editableList1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.editableList1.TextBox.Location = New System.Drawing.Point(2, 64)
            Me.editableList1.TextBox.Name = "textBox"
            Me.editableList1.TextBox.Size = New System.Drawing.Size(446, 21)
            Me.editableList1.TextBox.TabIndex = 2
            Me.editableList1.TextBox.Visible = False
            '
            'tabPageAdv4
            '
            Me.tabPageAdv4.Controls.Add(Me.chkPullCharOnDelete)
            Me.tabPageAdv4.Controls.Add(Me.NumericUpDownExt9)
            Me.tabPageAdv4.Controls.Add(Me.Label139)
            Me.tabPageAdv4.Controls.Add(Me.comboBox18)
            Me.tabPageAdv4.Controls.Add(Me.label126)
            Me.tabPageAdv4.Controls.Add(Me.label79)
            Me.tabPageAdv4.Controls.Add(Me.checkBox29)
            Me.tabPageAdv4.Controls.Add(Me.comboBox16)
            Me.tabPageAdv4.Controls.Add(Me.checkBox30)
            Me.tabPageAdv4.Controls.Add(Me.comboBox17)
            Me.tabPageAdv4.Controls.Add(Me.label125)
            Me.tabPageAdv4.Controls.Add(Me.label98)
            Me.tabPageAdv4.Controls.Add(Me.comboBox15)
            Me.tabPageAdv4.Controls.Add(Me.buttonEdit3)
            Me.tabPageAdv4.Controls.Add(Me.label80)
            Me.tabPageAdv4.Controls.Add(Me.label81)
            Me.tabPageAdv4.Controls.Add(Me.label90)
            Me.tabPageAdv4.Controls.Add(Me.comboBox7)
            Me.tabPageAdv4.Controls.Add(Me.label93)
            Me.tabPageAdv4.Controls.Add(Me.label94)
            Me.tabPageAdv4.Controls.Add(Me.radioButton8)
            Me.tabPageAdv4.Controls.Add(Me.buttonEdit4)
            Me.tabPageAdv4.Controls.Add(Me.radioButton9)
            Me.tabPageAdv4.Controls.Add(Me.buttonEdit5)
            Me.tabPageAdv4.Controls.Add(Me.label95)
            Me.tabPageAdv4.Controls.Add(Me.comboBox14)
            Me.tabPageAdv4.Controls.Add(Me.label96)
            Me.tabPageAdv4.Controls.Add(Me.label97)
            Me.tabPageAdv4.Controls.Add(Me.label71)
            Me.tabPageAdv4.Controls.Add(Me.label74)
            Me.tabPageAdv4.Controls.Add(Me.groupBox6)
            Me.tabPageAdv4.Location = New System.Drawing.Point(1, 26)
            Me.tabPageAdv4.Name = "tabPageAdv4"
            Me.tabPageAdv4.Size = New System.Drawing.Size(835, 579)
            Me.tabPageAdv4.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv4.TabIndex = 7
            Me.tabPageAdv4.Text = "Masked Edit"
            Me.tabPageAdv4.ThemesEnabled = False
            '
            'NumericUpDownExt9
            '
            Me.NumericUpDownExt9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.NumericUpDownExt9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.NumericUpDownExt9.Location = New System.Drawing.Point(557, 366)
            Me.NumericUpDownExt9.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.NumericUpDownExt9.Name = "NumericUpDownExt9"
            Me.NumericUpDownExt9.Size = New System.Drawing.Size(109, 21)
            Me.NumericUpDownExt9.TabIndex = 170
            '
            'Label139
            '
            Me.Label139.AutoSize = True
            Me.Label139.Location = New System.Drawing.Point(474, 366)
            Me.Label139.Margin = New System.Windows.Forms.Padding(0)
            Me.Label139.Name = "Label139"
            Me.Label139.Size = New System.Drawing.Size(72, 13)
            Me.Label139.TabIndex = 169
            Me.Label139.Text = "CornerRadius"
            '
            'comboBox18
            '
            Me.comboBox18.BackColor = System.Drawing.Color.White
            Me.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.comboBox18.ForeColor = System.Drawing.Color.Black
            Me.comboBox18.Items.AddRange(New Object() {"*", "#", "@"})
            Me.comboBox18.Location = New System.Drawing.Point(223, 390)
            Me.comboBox18.Name = "comboBox18"
            Me.comboBox18.Size = New System.Drawing.Size(120, 21)
            Me.comboBox18.TabIndex = 168
            '
            'label126
            '
            Me.label126.AutoSize = True
            Me.label126.Location = New System.Drawing.Point(101, 393)
            Me.label126.Name = "label126"
            Me.label126.Size = New System.Drawing.Size(104, 13)
            Me.label126.TabIndex = 167
            Me.label126.Text = "Password Character"
            '
            'label79
            '
            Me.label79.AutoSize = True
            Me.label79.Location = New System.Drawing.Point(101, 428)
            Me.label79.Name = "label79"
            Me.label79.Size = New System.Drawing.Size(55, 13)
            Me.label79.TabIndex = 162
            Me.label79.Text = "Text Align"
            '
            'checkBox29
            '
            Me.checkBox29.Location = New System.Drawing.Point(101, 500)
            Me.checkBox29.Name = "checkBox29"
            Me.checkBox29.Size = New System.Drawing.Size(112, 24)
            Me.checkBox29.TabIndex = 163
            Me.checkBox29.Text = "Right To Left"
            '
            'comboBox16
            '
            Me.comboBox16.BackColor = System.Drawing.Color.White
            Me.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox16.ForeColor = System.Drawing.Color.Black
            Me.comboBox16.Items.AddRange(New Object() {"Left", "Right", "Center"})
            Me.comboBox16.Location = New System.Drawing.Point(222, 425)
            Me.comboBox16.Name = "comboBox16"
            Me.comboBox16.Size = New System.Drawing.Size(121, 21)
            Me.comboBox16.TabIndex = 161
            '
            'checkBox30
            '
            Me.checkBox30.Location = New System.Drawing.Point(101, 469)
            Me.checkBox30.Name = "checkBox30"
            Me.checkBox30.Size = New System.Drawing.Size(112, 24)
            Me.checkBox30.TabIndex = 164
            Me.checkBox30.Text = "Read Only"
            '
            'comboBox17
            '
            Me.comboBox17.BackColor = System.Drawing.Color.White
            Me.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox17.ForeColor = System.Drawing.Color.Black
            Me.comboBox17.Items.AddRange(New Object() {"Normal", "Upper Case", "Lower Case"})
            Me.comboBox17.Location = New System.Drawing.Point(223, 349)
            Me.comboBox17.Name = "comboBox17"
            Me.comboBox17.Size = New System.Drawing.Size(120, 21)
            Me.comboBox17.TabIndex = 160
            '
            'label125
            '
            Me.label125.AutoSize = True
            Me.label125.Location = New System.Drawing.Point(101, 352)
            Me.label125.Name = "label125"
            Me.label125.Size = New System.Drawing.Size(90, 13)
            Me.label125.TabIndex = 159
            Me.label125.Text = "Character Casing"
            '
            'label98
            '
            Me.label98.AutoSize = True
            Me.label98.Location = New System.Drawing.Point(101, 305)
            Me.label98.Name = "label98"
            Me.label98.Size = New System.Drawing.Size(31, 13)
            Me.label98.TabIndex = 157
            Me.label98.Text = "Mask"
            '
            'comboBox15
            '
            '
            'chkPullCharOnDelete
            '
            Me.chkPullCharOnDelete.Location = New System.Drawing.Point(100, 532)
            Me.chkPullCharOnDelete.Name = "chkPullCharOnDelete"
            Me.chkPullCharOnDelete.Size = New System.Drawing.Size(163, 24)
            Me.chkPullCharOnDelete.TabIndex = 171
            Me.chkPullCharOnDelete.Text = "Pull Char On Delete"
            Me.toolTip1.SetToolTip(Me.chkPullCharOnDelete, "Pulls adjacent char to the postion being deleted like MS MaskedTextBox.")

            Me.comboBox15.BackColor = System.Drawing.Color.White
            Me.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.comboBox15.ForeColor = System.Drawing.Color.Black
            Me.comboBox15.Items.AddRange(New Object() {"None", "##/##/####", "##.##", "###-########"})
            Me.comboBox15.Location = New System.Drawing.Point(222, 305)
            Me.comboBox15.Name = "comboBox15"
            Me.comboBox15.Size = New System.Drawing.Size(120, 21)
            Me.comboBox15.TabIndex = 156
            '
            'buttonEdit3
            '
            Me.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit3.Buttons.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.Controls.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.Controls.Add(Me.textBoxExt2)
            Me.buttonEdit3.Location = New System.Drawing.Point(556, 502)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.ShowTextBox = False
            Me.buttonEdit3.Size = New System.Drawing.Size(110, 22)
            Me.buttonEdit3.TabIndex = 154
            Me.buttonEdit3.TextBox = Me.textBoxExt2
            Me.buttonEdit3.UseVisualStyle = True
            '
            'buttonEditChildButton3
            '
            Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton3.Image = Nothing
            Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
            Me.buttonEditChildButton3.PreferredWidth = 18
            Me.buttonEditChildButton3.TabIndex = 1
            Me.buttonEditChildButton3.Text = "..."
            '
            'textBoxExt2
            '
            Me.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt2.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt2.Name = "textBoxExt2"
            Me.textBoxExt2.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt2.Size = New System.Drawing.Size(97, 14)
            Me.textBoxExt2.TabIndex = 0
            '
            'label80
            '
            Me.label80.AutoSize = True
            Me.label80.Location = New System.Drawing.Point(474, 469)
            Me.label80.Name = "label80"
            Me.label80.Size = New System.Drawing.Size(57, 13)
            Me.label80.TabIndex = 141
            Me.label80.Text = "Back Color"
            '
            'label81
            '
            Me.label81.AutoSize = True
            Me.label81.Location = New System.Drawing.Point(474, 504)
            Me.label81.Name = "label81"
            Me.label81.Size = New System.Drawing.Size(57, 13)
            Me.label81.TabIndex = 142
            Me.label81.Text = "Fore Color"
            '
            'label90
            '
            Me.label90.AutoSize = True
            Me.label90.Location = New System.Drawing.Point(472, 545)
            Me.label90.Name = "label90"
            Me.label90.Size = New System.Drawing.Size(67, 13)
            Me.label90.TabIndex = 145
            Me.label90.Text = "Border Color"
            '
            'comboBox7
            '
            Me.comboBox7.BackColor = System.Drawing.Color.White
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.Enabled = False
            Me.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.comboBox7.ForeColor = System.Drawing.Color.Black
            Me.comboBox7.Location = New System.Drawing.Point(558, 390)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(108, 21)
            Me.comboBox7.TabIndex = 146
            '
            'label93
            '
            Me.label93.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label93.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label93.Image = CType(resources.GetObject("label93.Image"), System.Drawing.Image)
            Me.label93.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label93.Location = New System.Drawing.Point(452, 247)
            Me.label93.Name = "label93"
            Me.label93.Size = New System.Drawing.Size(142, 24)
            Me.label93.TabIndex = 152
            Me.label93.Text = "Appearance Settings"
            Me.label93.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label94
            '
            Me.label94.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label94.Location = New System.Drawing.Point(461, 271)
            Me.label94.Name = "label94"
            Me.label94.Size = New System.Drawing.Size(250, 1)
            Me.label94.TabIndex = 151
            '
            'radioButton8
            '
            Me.radioButton8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton8.Location = New System.Drawing.Point(558, 330)
            Me.radioButton8.Name = "radioButton8"
            Me.radioButton8.Size = New System.Drawing.Size(91, 26)
            Me.radioButton8.TabIndex = 150
            Me.radioButton8.Text = "Fixed3D"
            '
            'buttonEdit4
            '
            Me.buttonEdit4.BackColor = System.Drawing.Color.White
            Me.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton7)
            Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton7)
            Me.buttonEdit4.Location = New System.Drawing.Point(556, 544)
            Me.buttonEdit4.Name = "buttonEdit4"
            Me.buttonEdit4.ShowTextBox = False
            Me.buttonEdit4.Size = New System.Drawing.Size(110, 27)
            Me.buttonEdit4.TabIndex = 155
            Me.buttonEdit4.UseVisualStyle = True
            '
            'buttonEditChildButton7
            '
            Me.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton7.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton7.Image = Nothing
            Me.buttonEditChildButton7.Name = "buttonEditChildButton7"
            Me.buttonEditChildButton7.PreferredWidth = 18
            Me.buttonEditChildButton7.TabIndex = 1
            Me.buttonEditChildButton7.Text = "..."
            '
            'radioButton9
            '
            Me.radioButton9.Checked = True
            Me.radioButton9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton9.Location = New System.Drawing.Point(556, 303)
            Me.radioButton9.Name = "radioButton9"
            Me.radioButton9.Size = New System.Drawing.Size(91, 26)
            Me.radioButton9.TabIndex = 149
            Me.radioButton9.TabStop = True
            Me.radioButton9.Text = "FixedSingle"
            '
            'buttonEdit5
            '
            Me.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit5.Buttons.Add(Me.buttonEditChildButton8)
            Me.buttonEdit5.Controls.Add(Me.buttonEditChildButton8)
            Me.buttonEdit5.Controls.Add(Me.textBoxExt1)
            Me.buttonEdit5.Location = New System.Drawing.Point(557, 463)
            Me.buttonEdit5.Name = "buttonEdit5"
            Me.buttonEdit5.ShowTextBox = False
            Me.buttonEdit5.Size = New System.Drawing.Size(110, 22)
            Me.buttonEdit5.TabIndex = 153
            Me.buttonEdit5.TextBox = Me.textBoxExt1
            Me.buttonEdit5.UseVisualStyle = True
            '
            'buttonEditChildButton8
            '
            Me.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton8.Image = Nothing
            Me.buttonEditChildButton8.Name = "buttonEditChildButton8"
            Me.buttonEditChildButton8.PreferredWidth = 18
            Me.buttonEditChildButton8.TabIndex = 1
            Me.buttonEditChildButton8.Text = "..."
            '
            'textBoxExt1
            '
            Me.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt1.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(97, 14)
            Me.textBoxExt1.TabIndex = 0
            '
            'label95
            '
            Me.label95.AutoSize = True
            Me.label95.Location = New System.Drawing.Point(472, 308)
            Me.label95.Name = "label95"
            Me.label95.Size = New System.Drawing.Size(66, 13)
            Me.label95.TabIndex = 148
            Me.label95.Text = "Border Style"
            '
            'comboBox14
            '
            Me.comboBox14.BackColor = System.Drawing.Color.White
            Me.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox14.ForeColor = System.Drawing.Color.Black
            Me.comboBox14.Items.AddRange(New Object() {"Left", "Top", "Right", "Bottom", "Middle", "All"})
            Me.comboBox14.Location = New System.Drawing.Point(557, 424)
            Me.comboBox14.Name = "comboBox14"
            Me.comboBox14.Size = New System.Drawing.Size(110, 21)
            Me.comboBox14.TabIndex = 147
            '
            'label96
            '
            Me.label96.AutoSize = True
            Me.label96.Location = New System.Drawing.Point(474, 432)
            Me.label96.Name = "label96"
            Me.label96.Size = New System.Drawing.Size(67, 13)
            Me.label96.TabIndex = 144
            Me.label96.Text = "Border Sides"
            '
            'label97
            '
            Me.label97.AutoSize = True
            Me.label97.Location = New System.Drawing.Point(472, 390)
            Me.label97.Margin = New System.Windows.Forms.Padding(0)
            Me.label97.Name = "label97"
            Me.label97.Size = New System.Drawing.Size(79, 13)
            Me.label97.TabIndex = 143
            Me.label97.Text = "Border3D Style"
            '
            'label71
            '
            Me.label71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label71.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label71.Image = CType(resources.GetObject("label71.Image"), System.Drawing.Image)
            Me.label71.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label71.Location = New System.Drawing.Point(91, 246)
            Me.label71.Name = "label71"
            Me.label71.Size = New System.Drawing.Size(82, 24)
            Me.label71.TabIndex = 140
            Me.label71.Text = "Properties"
            Me.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label74
            '
            Me.label74.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label74.Location = New System.Drawing.Point(97, 270)
            Me.label74.Name = "label74"
            Me.label74.Size = New System.Drawing.Size(250, 1)
            Me.label74.TabIndex = 139
            '
            'groupBox6
            '
            Me.groupBox6.Controls.Add(Me.maskedEditBox1)
            Me.groupBox6.Controls.Add(Me.label64)
            Me.groupBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.groupBox6.Location = New System.Drawing.Point(268, 45)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Size = New System.Drawing.Size(326, 142)
            Me.groupBox6.TabIndex = 130
            Me.groupBox6.TabStop = False
            Me.groupBox6.Text = "MaskedEdit"
            '
            'maskedEditBox1
            '
            Me.maskedEditBox1.AccessibleDescription = "MaskedEdit TextBox"
            Me.maskedEditBox1.AccessibleName = "MaskedEditBox"
            Me.maskedEditBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
            Me.maskedEditBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.maskedEditBox1.Location = New System.Drawing.Point(109, 85)
            Me.maskedEditBox1.Name = "maskedEditBox1"
            Me.maskedEditBox1.OverflowIndicatorToolTipText = Nothing
            Me.maskedEditBox1.Size = New System.Drawing.Size(100, 21)
            Me.maskedEditBox1.TabIndex = 2
            Me.maskedEditBox1.ThemesEnabled = False
            Me.maskedEditBox1.UseLocaleDefault = False
            Me.maskedEditBox1.WordWrap = False
            '
            'label64
            '
            Me.label64.BackColor = System.Drawing.Color.Transparent
            Me.label64.Dock = System.Windows.Forms.DockStyle.Top
            Me.label64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label64.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label64.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label64.Location = New System.Drawing.Point(3, 17)
            Me.label64.Name = "label64"
            Me.label64.Size = New System.Drawing.Size(320, 56)
            Me.label64.TabIndex = 1
            Me.label64.Text = resources.GetString("label64.Text")
            '
            'label34
            '
            Me.label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label34.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label34.Image = CType(resources.GetObject("label34.Image"), System.Drawing.Image)
            Me.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label34.Location = New System.Drawing.Point(13, 98)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(100, 24)
            Me.label34.TabIndex = 16
            Me.label34.Text = "More Options"
            Me.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label13.Location = New System.Drawing.Point(13, 123)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(250, 1)
            Me.label13.TabIndex = 13
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.Checked = True
            Me.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox5.Location = New System.Drawing.Point(26, 55)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(68, 18)
            Me.checkBox5.TabIndex = 5
            Me.checkBox5.Text = "First Tab"
            Me.checkBox5.UseVisualStyleBackColor = True
            '
            'label35
            '
            Me.label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label35.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label35.Image = CType(resources.GetObject("label35.Image"), System.Drawing.Image)
            Me.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label35.Location = New System.Drawing.Point(291, 98)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(133, 24)
            Me.label35.TabIndex = 17
            Me.label35.Text = "Custom Primitives"
            Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label26
            '
            Me.label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label26.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label26.Image = CType(resources.GetObject("label26.Image"), System.Drawing.Image)
            Me.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label26.Location = New System.Drawing.Point(13, 11)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(75, 24)
            Me.label26.TabIndex = 15
            Me.label26.Text = "Visibility"
            Me.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label11.Location = New System.Drawing.Point(291, 123)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(230, 1)
            Me.label11.TabIndex = 10
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label9.Location = New System.Drawing.Point(13, 35)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(510, 1)
            Me.label9.TabIndex = 7
            '
            'checkBox9
            '
            Me.checkBox9.AutoSize = True
            Me.checkBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox9.Location = New System.Drawing.Point(142, 139)
            Me.checkBox9.Name = "checkBox9"
            Me.checkBox9.Size = New System.Drawing.Size(118, 18)
            Me.checkBox9.TabIndex = 12
            Me.checkBox9.Text = "Show Close button"
            Me.checkBox9.UseVisualStyleBackColor = True
            '
            'checkBox8
            '
            Me.checkBox8.AutoSize = True
            Me.checkBox8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox8.Location = New System.Drawing.Point(26, 139)
            Me.checkBox8.Name = "checkBox8"
            Me.checkBox8.Size = New System.Drawing.Size(110, 18)
            Me.checkBox8.TabIndex = 12
            Me.checkBox8.Text = "Show DropDown"
            Me.checkBox8.UseVisualStyleBackColor = True
            '
            'checkBox7
            '
            Me.checkBox7.AutoSize = True
            Me.checkBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox7.Location = New System.Drawing.Point(304, 139)
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Size = New System.Drawing.Size(136, 18)
            Me.checkBox7.TabIndex = 9
            Me.checkBox7.Text = "Show Custom Primitive"
            Me.checkBox7.UseVisualStyleBackColor = True
            '
            'checkBox6
            '
            Me.checkBox6.AutoSize = True
            Me.checkBox6.Checked = True
            Me.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox6.Location = New System.Drawing.Point(294, 55)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(69, 18)
            Me.checkBox6.TabIndex = 4
            Me.checkBox6.Text = "Next Tab"
            Me.checkBox6.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Checked = True
            Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox4.Location = New System.Drawing.Point(369, 55)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(75, 18)
            Me.checkBox4.TabIndex = 6
            Me.checkBox4.Text = "Next Page"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox3.Location = New System.Drawing.Point(100, 55)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(95, 18)
            Me.checkBox3.TabIndex = 1
            Me.checkBox3.Text = "Previous Page"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox10
            '
            Me.checkBox10.AutoSize = True
            Me.checkBox10.Checked = True
            Me.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox10.Location = New System.Drawing.Point(449, 55)
            Me.checkBox10.Name = "checkBox10"
            Me.checkBox10.Size = New System.Drawing.Size(68, 18)
            Me.checkBox10.TabIndex = 2
            Me.checkBox10.Text = "Last Tab"
            Me.checkBox10.UseVisualStyleBackColor = True
            '
            'checkBox11
            '
            Me.checkBox11.AutoSize = True
            Me.checkBox11.Checked = True
            Me.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox11.Location = New System.Drawing.Point(202, 55)
            Me.checkBox11.Name = "checkBox11"
            Me.checkBox11.Size = New System.Drawing.Size(89, 18)
            Me.checkBox11.TabIndex = 3
            Me.checkBox11.Text = "Previous Tab"
            Me.checkBox11.UseVisualStyleBackColor = True
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'treeViewAdv1
            '
            Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(245, Byte), Integer)))
            TreeNodeAdvStyleInfo4.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(132, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(132, Byte), Integer))})
            TreeNodeAdvStyleInfo4.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo4.TextColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(140, Byte), Integer))
            TreeNodeAdvStyleInfo5.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(245, Byte), Integer)))
            TreeNodeAdvStyleInfo5.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo6.BaseStyle = "Style1"
            TreeNodeAdvStyleInfo6.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo6.ShowPlusMinus = False
            TreeNodeAdvStyleInfo6.ThemesEnabled = False
            Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Style1", TreeNodeAdvStyleInfo4), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Style2", TreeNodeAdvStyleInfo5), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo6)})
            Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left
            Me.treeViewAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.treeViewAdv1.ForeColor = System.Drawing.Color.White
            Me.treeViewAdv1.FullRowSelect = True
            '
            '
            '
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.HotTracking = True
            Me.treeViewAdv1.ItemHeight = 56
            Me.treeViewAdv1.Location = New System.Drawing.Point(0, 49)
            Me.treeViewAdv1.Name = "treeViewAdv1"
            TreeNodeAdv7.BaseStyle = "Style2"
            TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.Expanded = True
            TreeNodeAdv7.Text = "Input Controls"
            TreeNodeAdv8.BaseStyle = "Style2"
            TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.Expanded = True
            TreeNodeAdv8.Text = "UpDownExt Controls"
            TreeNodeAdv9.BaseStyle = "Style2"
            TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.Text = "TextBoxExt"
            TreeNodeAdv10.BaseStyle = "Style2"
            TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.Text = "Currency Edit"
            TreeNodeAdv11.BaseStyle = "Style2"
            TreeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.Text = "Editable List"
            TreeNodeAdv12.BaseStyle = "Style2"
            TreeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.Text = "Masked Edit"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv7, TreeNodeAdv8, TreeNodeAdv9, TreeNodeAdv10, TreeNodeAdv11, TreeNodeAdv12})
            Me.treeViewAdv1.SelectedNodeBackground = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(132, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(132, Byte), Integer))})
            Me.treeViewAdv1.SelectedNodeForeColor = System.Drawing.Color.Black
            Me.treeViewAdv1.ShowLines = False
            Me.treeViewAdv1.ShowPlusMinus = False
            Me.treeViewAdv1.Size = New System.Drawing.Size(156, 610)
            Me.treeViewAdv1.TabIndex = 4
            Me.treeViewAdv1.Text = "treeViewAdv1"
            Me.treeViewAdv1.ThemesEnabled = False
            '
            '
            '
            Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
            Me.treeViewAdv1.ToolTipControl.TabIndex = 1
            Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(245, Byte), Integer))})
            Me.gradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientLabel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.gradientLabel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(1006, 49)
            Me.gradientLabel1.TabIndex = 5
            Me.gradientLabel1.Text = " Editor Controls"
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'CheckBox31
            '
            Me.CheckBox31.AutoSize = True
            Me.CheckBox31.Checked = True
            Me.CheckBox31.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox31.Location = New System.Drawing.Point(638, 471)
            Me.CheckBox31.Name = "CheckBox31"
            Me.CheckBox31.Size = New System.Drawing.Size(75, 17)
            Me.CheckBox31.TabIndex = 141
            Me.CheckBox31.Text = "Far Image"
            Me.CheckBox31.UseVisualStyleBackColor = True
            '
            'CheckBox32
            '
            Me.CheckBox32.AutoSize = True
            Me.CheckBox32.Checked = True
            Me.CheckBox32.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox32.Location = New System.Drawing.Point(724, 471)
            Me.CheckBox32.Name = "CheckBox32"
            Me.CheckBox32.Size = New System.Drawing.Size(82, 17)
            Me.CheckBox32.TabIndex = 142
            Me.CheckBox32.Text = "Near Image"
            Me.CheckBox32.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1006, 659)
            Me.Controls.Add(Me.treeViewAdv1)
            Me.Controls.Add(Me.gradientLabel1)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Editor Controls"
            CType(Me.currencyTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.integerTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            CType(Me.gradientPanel11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel11.ResumeLayout(False)
            Me.gradientPanel11.PerformLayout()
            CType(Me.NumericUpDownExt6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bannerClr, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bannerClr.ResumeLayout(False)
            Me.bannerClr.PerformLayout()
            CType(Me.cmbMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NegativeColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.NegativeColorEdit.ResumeLayout(False)
            Me.NegativeColorEdit.PerformLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit1.ResumeLayout(False)
            Me.buttonEdit1.PerformLayout()
            CType(Me.PositiveColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PositiveColorEdit.ResumeLayout(False)
            Me.PositiveColorEdit.PerformLayout()
            CType(Me.gradientPanel9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel9.ResumeLayout(False)
            Me.gradientPanel9.PerformLayout()
            CType(Me.gradientPanel12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel12.ResumeLayout(False)
            CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel7.ResumeLayout(False)
            Me.gradientPanel7.PerformLayout()
            CType(Me.integerTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel10.ResumeLayout(False)
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel5.ResumeLayout(False)
            Me.gradientPanel5.PerformLayout()
            CType(Me.percentTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel8.ResumeLayout(False)
            CType(Me.numericUpDownExt5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.integerTextBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            CType(Me.doubleTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel6.ResumeLayout(False)
            CType(Me.integerTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv3.ResumeLayout(False)
            Me.tabPageAdv3.PerformLayout()
            CType(Me.comboMode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bEditBanner, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bEditBanner.ResumeLayout(False)
            Me.bEditBanner.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            CType(Me.numericUpDownExt7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.DomainBorderColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DomainBorderColorEdit.ResumeLayout(False)
            Me.DomainBorderColorEdit.PerformLayout()
            CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv5.ResumeLayout(False)
            Me.tabPageAdv5.PerformLayout()
            CType(Me.NumericUpDownExt8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bannerClrEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bannerClrEdit.ResumeLayout(False)
            Me.bannerClrEdit.PerformLayout()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit2.ResumeLayout(False)
            Me.buttonEdit2.PerformLayout()
            Me.tabPageAdv2.ResumeLayout(False)
            Me.tabPageAdv2.PerformLayout()
            Me.groupBox5.ResumeLayout(False)
            CType(Me.currencyEdit1.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.currencyEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.tabPageAdv6.ResumeLayout(False)
            Me.tabPageAdv6.PerformLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.tabPageAdv4.ResumeLayout(False)
            Me.tabPageAdv4.PerformLayout()
            CType(Me.NumericUpDownExt9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit3.ResumeLayout(False)
            Me.buttonEdit3.PerformLayout()
            CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit4.ResumeLayout(False)
            Me.buttonEdit4.PerformLayout()
            CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit5.ResumeLayout(False)
            Me.buttonEdit5.PerformLayout()
            Me.groupBox6.ResumeLayout(False)
            Me.groupBox6.PerformLayout()
            CType(Me.maskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Main"
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub


#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Currency TextBox
            PopulateCultures()
            Me.comboBoxAdv1.SelectedIndex = 0
            'Syncfusion.Windows.Forms.WinFormsUtils.UpdateDirectoryPath(Me.oleDbConnection1, "Data", "CurrencyDataBinding.mdb")

            Dim mdbFile As String = Application.StartupPath & " \..\..\..\..\..\..\..\..\..\Common\Data\CurrencyDataBinding.mdb"

            ' Database connection string
            Me.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mdbFile


            'CurrencyEdit
            ' Load all Specific Cultures to the Combo Box
            For Each info As CultureInfo In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                comboBox1.Items.Add(info.DisplayName)
                comboBox2.Items.Add(info.Name)
            Next info
            ' Populate cboButtontype Combo Box with ButtonTypes
            Dim str As String() = System.Enum.GetNames(GetType(ButtonTypes))
            cboButtonType.Items.AddRange(str)

            cboButtonType.SelectedIndex = 1
            comboBox1.SelectedIndex = 64

            'Populate DomainUpDown Border3DStyles
            Dim str1 As String() = System.Enum.GetNames(GetType(Border3DStyle))
            comboBox3.Items.AddRange(str1)
            'Populate TextBoxes Border3DStyles
            comboBox6.Items.AddRange(str1)
            'Populate TextBoxExt Border3DStyles
            comboBox11.Items.AddRange(str1)
            'Populate MaskedEdit Border3DStyles
            comboBox7.Items.AddRange(str1)

            comboBox3.SelectedIndex = 0
            comboBox4.SelectedIndex = 5
            comboBox5.SelectedIndex = 5
            comboBox6.SelectedIndex = 0
            comboBox11.SelectedIndex = 0
            comboBox10.SelectedIndex = 5
            comboBox9.SelectedIndex = 0
            comboBox8.SelectedIndex = 0
            comboBox12.SelectedIndex = 0
            comboBox15.SelectedIndex = 1
            comboBox17.SelectedIndex = 0
            comboBox16.SelectedIndex = 0
            comboBox14.SelectedIndex = 5

            comboBox1.SelectedItem = "English (Australia)"
            comboBox13.SelectedIndex = 0
            Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.Nodes(0)
            Me.treeViewAdv1.Nodes(0).BaseStyle = "Style1"
            For Each tabPage As TabPageAdv In Me.tabControlAdv1.TabPages
                tabPage.Hide()
            Next tabPage
            Me.tabPageAdv1.Show()
            cmbMode.SelectedIndex = 0
            comboMode.SelectedIndex = 0
            AddHandler Application.Idle, AddressOf Application_Idle
            Me.ColorScheme = Office2007Theme.Blue
            CreateDatatable()

        End Sub

#End Region

#Region "TextBox"

#Region "TextBox Culture Settings"
        Private Sub PopulateCultures()
            comboBoxAdv2.Items.Add("(Default)")
            comboBoxAdv2.Items.Add("(UICulture)")
            comboBoxAdv2.Items.Add("(InstalledUICulture)")
            For Each c As CultureInfo In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                comboBoxAdv2.Items.Add(c.Name)
            Next c

            Me.comboBoxAdv2.SelectedIndex = 0
        End Sub

        Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxAdv2.SelectedIndexChanged
            Dim selected As String = Me.comboBoxAdv2.SelectedItem.ToString()

            If selected.Equals("(Default)") Then
                Me.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture
                Me.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture
                Me.integerTextBox2.SpecialCultureValue = SpecialCultureValues.CurrentCulture
                Me.percentTextBox1.SpecialCultureValue = SpecialCultureValues.CurrentCulture
                Me.currencyTextBox1.Culture = New CultureInfo(CultureInfo.CurrentCulture.LCID, Me.currencyTextBox1.UseUserOverride)
                Me.doubleTextBox1.Culture = New CultureInfo(CultureInfo.CurrentCulture.LCID, Me.doubleTextBox1.UseUserOverride)
                Me.integerTextBox2.Culture = New CultureInfo(CultureInfo.CurrentCulture.LCID, Me.integerTextBox2.UseUserOverride)
                Me.percentTextBox1.Culture = New CultureInfo(CultureInfo.CurrentCulture.LCID, Me.percentTextBox1.UseUserOverride)
            ElseIf selected.Equals("(UICulture)") Then
                Me.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture
                Me.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture
                Me.integerTextBox2.SpecialCultureValue = SpecialCultureValues.UICulture
                Me.percentTextBox1.SpecialCultureValue = SpecialCultureValues.UICulture
                Me.currencyTextBox1.Culture = New CultureInfo(CultureInfo.CurrentUICulture.LCID, Me.currencyTextBox1.UseUserOverride)
                Me.doubleTextBox1.Culture = New CultureInfo(CultureInfo.CurrentUICulture.LCID, Me.doubleTextBox1.UseUserOverride)
                Me.integerTextBox2.Culture = New CultureInfo(CultureInfo.CurrentUICulture.LCID, Me.integerTextBox2.UseUserOverride)
                Me.percentTextBox1.Culture = New CultureInfo(CultureInfo.CurrentUICulture.LCID, Me.percentTextBox1.UseUserOverride)

            ElseIf selected.Equals("(InstalledUICulture)") Then
                Me.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture
                Me.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture
                Me.integerTextBox2.SpecialCultureValue = SpecialCultureValues.InstalledCulture
                Me.percentTextBox1.SpecialCultureValue = SpecialCultureValues.InstalledCulture
                Me.currencyTextBox1.Culture = New CultureInfo(CultureInfo.InstalledUICulture.LCID, Me.currencyTextBox1.UseUserOverride)
                Me.doubleTextBox1.Culture = New CultureInfo(CultureInfo.InstalledUICulture.LCID, Me.doubleTextBox1.UseUserOverride)
                Me.integerTextBox2.Culture = New CultureInfo(CultureInfo.InstalledUICulture.LCID, Me.integerTextBox2.UseUserOverride)
                Me.percentTextBox1.Culture = New CultureInfo(CultureInfo.InstalledUICulture.LCID, Me.percentTextBox1.UseUserOverride)

            Else

                Me.currencyTextBox1.SpecialCultureValue = SpecialCultureValues.None
                Me.doubleTextBox1.SpecialCultureValue = SpecialCultureValues.None
                Me.integerTextBox2.SpecialCultureValue = SpecialCultureValues.None
                Me.percentTextBox1.SpecialCultureValue = SpecialCultureValues.None
                Me.currencyTextBox1.Culture = New CultureInfo(selected, Me.currencyTextBox1.UseUserOverride)
                Me.doubleTextBox1.Culture = New CultureInfo(selected, Me.doubleTextBox1.UseUserOverride)
                Me.integerTextBox2.Culture = New CultureInfo(selected, Me.integerTextBox2.UseUserOverride)
                Me.percentTextBox1.Culture = New CultureInfo(selected, Me.percentTextBox1.UseUserOverride)

            End If

            Me.currencyTextBox1.Text = Me.currencyTextBox1.Text
        End Sub
#End Region

#Region "TextBox DataBinding"
        'Databinding
        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            If Me.checkBox2.Checked = True Then
                Me.currencyTextBox1.DataBindings.Add("Text", Dt, "Amount")
                Me.doubleTextBox1.DataBindings.Add("Text", Dt, "Amount")
                Me.integerTextBox2.DataBindings.Add("Text", Dt, "Amount")

                Me.dataGrid1.DataSource = Dt
            Else
                Me.currencyTextBox1.DataBindings.Clear()
                Me.doubleTextBox1.DataBindings.Clear()
                Me.integerTextBox2.DataBindings.Clear()
                Me.currencyTextBox1.Text = "1"
                Me.dataGrid1.DataSource = Nothing
            End If
        End Sub

        Public Sub CreateDatatable()
            Dt = New DataTable()
            Dim column1 As New DataColumn("ID", GetType(Integer))
            Dim column2 As New DataColumn("PurchaseDate", GetType(DateTime))
            Dim column3 As New DataColumn("Amount", GetType(Integer))
            'DataColumn[] cols=new DataColumn[] {column1,column2,column3}; 
            Dt.Columns.Add(column1)
            Dt.Columns.Add(column2)
            Dt.Columns.Add(column3)

            Dt.Rows.Add("1", "12/1/2004", 21)
            Dt.Rows.Add("2", "11/5/2004", 33)
            Dt.Rows.Add("3", "8/4/2005", 4434)
            Dt.Rows.Add("4", "5/7/2006", 4555)
            Dt.Rows.Add("5", "12/6/2007", 3466)


        End Sub

#End Region


#Region "TextBox Text Colors"
        'Positive color
        Private Sub PositiveColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles PositiveColorEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PositiveColorEdit.TextBox.BackColor = colorDialog1.Color
                Me.currencyTextBox1.PositiveColor = colorDialog1.Color
                Me.doubleTextBox1.PositiveColor = colorDialog1.Color
                Me.integerTextBox2.PositiveColor = colorDialog1.Color
                Me.percentTextBox1.PositiveColor = colorDialog1.Color

            End If

        End Sub
        'Negative color
        Private Sub NegativeColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles NegativeColorEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                NegativeColorEdit.TextBox.BackColor = colorDialog1.Color
                Me.currencyTextBox1.NegativeColor = colorDialog1.Color
                Me.doubleTextBox1.NegativeColor = colorDialog1.Color
                Me.integerTextBox2.NegativeColor = colorDialog1.Color
                Me.percentTextBox1.NegativeColor = colorDialog1.Color
            End If
        End Sub
#End Region

#Region "TextBox BorderStyle"
        Private Sub radioButton7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton7.CheckedChanged
            If Me.radioButton7.Checked Then
                Me.currencyTextBox1.BorderStyle = BorderStyle.FixedSingle
                Me.doubleTextBox1.BorderStyle = BorderStyle.FixedSingle
                Me.integerTextBox2.BorderStyle = BorderStyle.FixedSingle
                Me.percentTextBox1.BorderStyle = BorderStyle.FixedSingle
                Me.comboBox6.Enabled = False
            End If
        End Sub

        Private Sub radioButton6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton6.CheckedChanged
            If Me.radioButton6.Checked Then
                Me.NumericUpDownExt6.Value = 0
                Me.currencyTextBox1.CornerRadius = 0
                Me.doubleTextBox1.CornerRadius = 0
                Me.integerTextBox2.CornerRadius = 0
                Me.percentTextBox1.CornerRadius = 0
                Me.currencyTextBox1.BorderStyle = BorderStyle.Fixed3D
                Me.doubleTextBox1.BorderStyle = BorderStyle.Fixed3D
                Me.integerTextBox2.BorderStyle = BorderStyle.Fixed3D
                Me.percentTextBox1.BorderStyle = BorderStyle.Fixed3D
                Me.comboBox6.Enabled = True
            End If
        End Sub
        Private Sub NumericUpDownExt6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownExt6.ValueChanged

            If Me.NumericUpDownExt6.Value <> 0 Then
                Me.radioButton6.Checked = False
                Me.radioButton7.Checked = True

                Me.currencyTextBox1.CornerRadius = CInt(Me.NumericUpDownExt6.Value)
                Me.currencyTextBox1.CornerRadius = CInt(Me.NumericUpDownExt6.Value)
                Me.doubleTextBox1.CornerRadius = CInt(Me.NumericUpDownExt6.Value)
                Me.integerTextBox2.CornerRadius = CInt(Me.NumericUpDownExt6.Value)
                Me.percentTextBox1.CornerRadius = CInt(Me.NumericUpDownExt6.Value)
            End If

        End Sub
#End Region

#Region "TextBox Controls Border3DStyle"
        Private Sub comboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox6.SelectedIndexChanged
            Me.checkBox1.Checked = False
            Select Case comboBox6.Items(comboBox6.SelectedIndex).ToString()
                Case "RaisedOuter"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.RaisedOuter
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.RaisedOuter
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.RaisedOuter
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.RaisedOuter

                Case "Adjust"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.Adjust
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.Adjust
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.Adjust
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.Adjust
                Case "Bump"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.Bump
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.Bump
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.Bump
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.Bump

                Case "Etched"

                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.Etched
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.Etched
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.Etched
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.Etched


                Case "Flat"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.Flat
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.Flat
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.Flat
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.Flat


                Case "Raised"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.Raised
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.Raised
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.Raised
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.Raised


                Case "RaisedInner"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.RaisedInner
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.RaisedInner
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.RaisedInner
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.RaisedInner
                Case "Sunken"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.Sunken
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.Sunken
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.Sunken
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.Sunken

                Case "SunkenInner"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.SunkenInner
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.SunkenInner
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.SunkenInner
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.SunkenInner
                Case "SunkenOuter"
                    Me.currencyTextBox1.Border3DStyle = Border3DStyle.SunkenOuter
                    Me.doubleTextBox1.Border3DStyle = Border3DStyle.SunkenOuter
                    Me.integerTextBox2.Border3DStyle = Border3DStyle.SunkenOuter
                    Me.percentTextBox1.Border3DStyle = Border3DStyle.SunkenOuter

            End Select
        End Sub
#End Region

#Region "TextBox BorderColor"
        Private Sub buttonEdit1_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit1.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.radioButton7.Checked = True
                Me.buttonEdit1.TextBox.BackColor = colorDialog1.Color
                Me.currencyTextBox1.BorderColor = colorDialog1.Color
                Me.doubleTextBox1.BorderColor = colorDialog1.Color
                Me.integerTextBox2.BorderColor = colorDialog1.Color
                Me.percentTextBox1.BorderColor = colorDialog1.Color
            End If
        End Sub
#End Region

#Region "TextBox BorderSides"
        Private Sub comboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox5.SelectedIndexChanged
            Select Case comboBox5.Items(comboBox5.SelectedIndex).ToString()
                Case "Left"
                    Me.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left
                    Me.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left
                    Me.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Left
                    Me.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Left

                Case "Top"
                    Me.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top
                    Me.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top
                    Me.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Top
                    Me.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Top
                Case "Right"
                    Me.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right
                    Me.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right
                    Me.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Right
                    Me.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Right
                Case "Bottom"
                    Me.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                    Me.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                    Me.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                    Me.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                Case "Middle"
                    Me.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle
                    Me.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle
                    Me.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.Middle
                    Me.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle
                Case "All"
                    Me.currencyTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All
                    Me.doubleTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All
                    Me.integerTextBox2.BorderSides = System.Windows.Forms.Border3DSide.All
                    Me.percentTextBox1.BorderSides = System.Windows.Forms.Border3DSide.All

            End Select
        End Sub
#End Region

#Region "TextBox TextAlignment"
        Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
            If Me.comboBoxAdv1.Text = "Left" Then
                Me.currencyTextBox1.TextAlign = HorizontalAlignment.Left
                Me.doubleTextBox1.TextAlign = HorizontalAlignment.Left
                Me.integerTextBox2.TextAlign = HorizontalAlignment.Left
                Me.percentTextBox1.TextAlign = HorizontalAlignment.Left
            ElseIf Me.comboBoxAdv1.Text = "Right" Then
                Me.currencyTextBox1.TextAlign = HorizontalAlignment.Right
                Me.doubleTextBox1.TextAlign = HorizontalAlignment.Right
                Me.integerTextBox2.TextAlign = HorizontalAlignment.Right
                Me.percentTextBox1.TextAlign = HorizontalAlignment.Right
            Else
                Me.currencyTextBox1.TextAlign = HorizontalAlignment.Center
                Me.doubleTextBox1.TextAlign = HorizontalAlignment.Center
                Me.integerTextBox2.TextAlign = HorizontalAlignment.Center
                Me.percentTextBox1.TextAlign = HorizontalAlignment.Center
            End If
        End Sub
#End Region

#Region "TextBox ThemesEnabled"
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.currencyTextBox1.ThemesEnabled = Me.checkBox1.Checked
            Me.doubleTextBox1.ThemesEnabled = Me.checkBox1.Checked
            Me.integerTextBox2.ThemesEnabled = Me.checkBox1.Checked
            Me.percentTextBox1.ThemesEnabled = Me.checkBox1.Checked
        End Sub
#End Region

#Region "TextBox ShowOverFlowIndicator"
        Private Sub checkBox16_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox16.CheckedChanged
            Me.currencyTextBox1.ShowOverflowIndicator = Me.checkBox16.Checked
            Me.doubleTextBox1.ShowOverflowIndicator = Me.checkBox16.Checked
            Me.integerTextBox2.ShowOverflowIndicator = Me.checkBox16.Checked
            Me.percentTextBox1.ShowOverflowIndicator = Me.checkBox16.Checked
        End Sub
#End Region

#Region "TextBox ShowOverFlowIndicatorToolTip"
        Private Sub checkBox20_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox20.CheckedChanged
            Me.currencyTextBox1.ShowOverflowIndicatorToolTip = Me.checkBox20.Checked
            Me.doubleTextBox1.ShowOverflowIndicatorToolTip = Me.checkBox20.Checked
            Me.integerTextBox2.ShowOverflowIndicatorToolTip = Me.checkBox20.Checked
            Me.percentTextBox1.ShowOverflowIndicatorToolTip = Me.checkBox20.Checked

        End Sub
#End Region

#Region "Properties"

#Region "Currency TextBox Properties"
        'To set the currency symbol of the Currency TextBox
        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
            Try
                Me.currencyTextBox1.CurrencySymbol = Me.textBox1.Text
            Catch e1 As Exception
                MessageBox.Show(e1.Message)
                Me.textBox1.Text = "$"
            End Try
        End Sub

        'To set the CurrencyDecimalDigits of the IntegerTextBox
        Private Sub integerTextbox1_IntegerValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles integerTextBox1.IntegerValueChanged
            Try
                Me.currencyTextBox1.CurrencyDecimalDigits = CInt(Me.integerTextBox1.IntegerValue)
            Catch
                MessageBox.Show("Values between 0 to 99 are only allowed")
              Me.integerTextBox1.IntegerValue = -Me.integerTextBox1.IntegerValue
            End Try
        End Sub
#End Region

#Region "DoubleTextBox"
        Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.TextChanged
            If Me.textBox2.Text <> "" Then
                Me.doubleTextBox1.NumberDecimalSeparator = Me.textBox2.Text
            End If

        End Sub

        Private Sub integerTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles integerTextBox3.TextChanged
            Dim decimalValue As Integer
            decimalValue = Convert.ToInt16(Me.integerTextBox3.Text)
            If (decimalValue > 0 & decimalValue < 99) Then
                Me.doubleTextBox1.NumberDecimalDigits = Convert.ToInt16(Me.integerTextBox3.Text)
            Else
                Me.integerTextBox3.Text = "0"
            End If

        End Sub

        Private Sub textBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox3.TextChanged
            Me.doubleTextBox1.NumberGroupSeparator = Me.textBox3.Text
        End Sub


        Private Sub numericUpDownExt2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt2.ValueChanged
            Dim x As Integer = Convert.ToInt16(Me.numericUpDownExt2.Value)
            Me.doubleTextBox1.NumberGroupSizes = New Integer() {x}
        End Sub

#End Region

#Region "PercentTextBox"
        'To set the Percent Value of the PercentTextBox
        Private Sub numericUpDownExt5_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt5.ValueChanged
            Dim x As Double = Convert.ToDouble(Me.numericUpDownExt5.Value)
            Me.percentTextBox1.PercentValue = x
        End Sub

        'To set the Decimal Separator of PercentTextBox
        Private Sub textBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox6.TextChanged
            If Me.textBox6.Text <> "" Then
                Me.percentTextBox1.PercentDecimalSeparator = Me.textBox6.Text
            End If
        End Sub
        'To set the Decimal Digits of PercentTextBox
        Private Sub integerTextBox7_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles integerTextBox7.TextChanged
            Try
                Me.percentTextBox1.PercentDecimalDigits = Convert.ToInt16(Me.integerTextBox7.Text)
            Catch
                MessageBox.Show("Values between 0 to 99 are only allowed")
				Me.integerTextBox7.IntegerValue = -Me.integerTextBox7.IntegerValue
            End Try
        End Sub



        'To set the PercentPositivePattern  of PercentTextBox
        Private Sub numericUpDownExt4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt4.ValueChanged
            Dim x As Integer = Convert.ToInt16(Me.numericUpDownExt4.Value)

            Me.percentTextBox1.PercentPositivePattern = x
        End Sub

#End Region

#Region "IntegerTextBox properties"
        'To set the NumberNegativePattern of IntegerTextBox
        Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt1.ValueChanged
            Dim x As Integer = Convert.ToInt16(Me.numericUpDownExt1.Value)

            Me.integerTextBox2.NumberNegativePattern = x

        End Sub

        'To set the NumberGroupSeparator of IntegerTextBox
        Private Sub textBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox4.TextChanged
            If Me.textBox4.Text <> "" Then
                Me.integerTextBox2.NumberGroupSeparator = Me.textBox4.Text
            End If
        End Sub

        'To set the NumberGroupSizes of IntegerTextBox
        Private Sub numericUpDownExt3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt3.ValueChanged
            Dim x As Integer = Convert.ToInt16(Me.numericUpDownExt3.Value)
            Me.integerTextBox2.NumberGroupSizes = New Integer() {x}

        End Sub




#End Region

#End Region

#End Region

#Region "Currency Edit"

#Region "Culture Settings"
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            comboBox2.SelectedIndex = comboBox1.SelectedIndex
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            comboBox1.SelectedIndex = comboBox2.SelectedIndex
            Dim culture As String = comboBox2.Items(comboBox2.SelectedIndex).ToString()
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)
            currencyEdit1.TextBox.SpecialCultureValue = SpecialCultureValues.UICulture
            currencyEdit1.TextBox.Culture = New System.Globalization.CultureInfo(culture)
        End Sub
#End Region

#Region "Calculator Type"
        Private Sub radWinStd_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radWinStd.CheckedChanged
            If radWinStd.Checked = True Then
                currencyEdit1.CalculatorLayoutType = CalculatorLayoutTypes.WindowsStandard
            End If

        End Sub

        Private Sub radFinancial_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radFinancial.CheckedChanged
            If radFinancial.Checked = True Then
                currencyEdit1.CalculatorLayoutType = CalculatorLayoutTypes.Financial
            End If

        End Sub
#End Region

        Private Sub checkBox12_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox12.CheckedChanged
            Me.currencyEdit1.Text = "0"
            Me.currencyEdit1.ShowCalculator = Me.checkBox12.Checked

        End Sub

        Private Sub currencyEdit1_CalculatorShowing(ByVal sender As Object, ByVal e As CancelEventArgs) Handles currencyEdit1.CalculatorShowing
            currencyEdit1.CalcPopup.Calculator.UseVerticalAndHorizontalSpacing = True
            currencyEdit1.CalcPopup.Calculator.HorizontalSpacing = 0
            currencyEdit1.CalcPopup.Calculator.VerticalSpacing = 0

        End Sub


        Private Sub checkBox17_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox17.CheckedChanged
            Me.currencyEdit1.TransferFromCalculator = Me.checkBox17.Checked
        End Sub

        Private Sub checkBox18_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox18.CheckedChanged
            Me.currencyEdit1.TransferToCalculator = Me.checkBox18.Checked

        End Sub


#Region "Set Button Style"

        Private Sub ButtonStyle_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radClassic.CheckedChanged, radOffice2000.CheckedChanged, radOffice2007.CheckedChanged, radOfficeXP.CheckedChanged, radWinXP.CheckedChanged, radOffice2003.CheckedChanged
            If sender Is radClassic Then

                currencyEdit1.ButtonStyle = ButtonAppearance.Classic
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Classic
            ElseIf sender Is radOffice2000 Then

                currencyEdit1.ButtonStyle = ButtonAppearance.Office2000
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2000
            ElseIf sender Is radOffice2003 Then

                currencyEdit1.ButtonStyle = ButtonAppearance.Office2003
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2003
            ElseIf sender Is radOffice2007 Then

                currencyEdit1.ButtonStyle = ButtonAppearance.Office2007
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.Office2007
            ElseIf sender Is radOfficeXP Then

                currencyEdit1.ButtonStyle = ButtonAppearance.OfficeXP
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.OfficeXP
            ElseIf sender Is radWinXP Then

                currencyEdit1.ButtonStyle = ButtonAppearance.WindowsXP
                currencyEdit1.CalcPopup.Calculator.ButtonStyle = ButtonAppearance.WindowsXP
            End If
        End Sub

#End Region

#Region "Currency Edit Button Type"
        Private Sub cboButtonType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboButtonType.SelectedIndexChanged
            Select Case cboButtonType.Items(cboButtonType.SelectedIndex).ToString()
                Case "Browse"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Browse
                Case "Calculator"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Calculator
                Case "Check"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Check
                Case "ComboXPDown"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.ComboXPDown
                Case "Currency"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Currency
                Case "Down"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Down
                Case "Left"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Left
                Case "LeftEnd"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.LeftEnd
                Case "Normal"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Normal
                Case "Redo"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Redo
                Case "Right"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Right
                Case "RightEnd"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.RightEnd
                Case "Undo"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Undo
                Case "Up"
                    currencyEdit1.CalculatorButton.ButtonType = ButtonTypes.Up
            End Select
        End Sub
#End Region

#Region "ReadOnly"
        Private Sub checkBox13_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox13.CheckedChanged
            Me.currencyEdit1.TextBox.ReadOnly = checkBox13.Checked
            Me.currencyEdit1.CalculatorButton.Enabled = Not checkBox13.Checked
        End Sub
#End Region

#End Region

#Region "DomainUpDownExt"

#Region "Border3DStyle"
        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
            Select Case comboBox3.Items(comboBox3.SelectedIndex).ToString()
                Case "RaisedOuter"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.RaisedOuter
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.RaisedOuter
                Case "Adjust"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.Adjust
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.Adjust
                Case "Bump"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.Bump
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.Bump
                Case "Etched"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.Etched
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.Etched
                Case "Flat"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.Flat
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.Flat
                Case "Raised"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.Raised
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.Raised
                Case "RaisedInner"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.RaisedInner
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.RaisedOuter
                Case "Sunken"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.Sunken
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.Sunken
                Case "SunkenInner"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.SunkenInner
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.SunkenInner
                Case "SunkenOuter"
                    Me.domainUpDownExt1.Border3DStyle = Border3DStyle.SunkenOuter
                    Me.numericUpDownExt7.Border3DStyle = Border3DStyle.SunkenOuter
            End Select
        End Sub
#End Region

#Region "BorderSides"

        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged
            Select Case comboBox4.Items(comboBox4.SelectedIndex).ToString()
                Case "Left"
                    Me.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Left
                    Me.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Left
                Case "Top"
                    Me.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Top
                    Me.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Top
                Case "Right"
                    Me.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Right
                    Me.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Right
                Case "Bottom"
                    Me.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                    Me.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                Case "Middle"
                    Me.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.Middle
                    Me.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.Middle
                Case "All"
                    Me.domainUpDownExt1.BorderSides = System.Windows.Forms.Border3DSide.All
                    Me.numericUpDownExt7.BorderSides = System.Windows.Forms.Border3DSide.All

            End Select


        End Sub
#End Region

#Region "BorderColor"
        Private Sub DomainBorderColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles DomainBorderColorEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.radioButton1.Checked = True
                Me.domainUpDownExt1.BorderStyle = BorderStyle.FixedSingle
                DomainBorderColorEdit.TextBox.BackColor = colorDialog1.Color
                Me.domainUpDownExt1.BorderColor = colorDialog1.Color
                Me.numericUpDownExt7.BorderColor = colorDialog1.Color
            End If
        End Sub
#End Region

#Region "UpDownExt BorderStyle"
        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
            If Me.radioButton1.Checked Then
                Me.domainUpDownExt1.BorderStyle = BorderStyle.FixedSingle
                Me.numericUpDownExt7.BorderStyle = BorderStyle.FixedSingle
                Me.comboBox3.Enabled = False
                Me.comboBox4.Enabled = True
                DomainBorderColorEdit.Enabled = True
            End If
        End Sub

        Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged
            If Me.radioButton2.Checked Then
                Me.domainUpDownExt1.BorderStyle = BorderStyle.Fixed3D
                Me.numericUpDownExt7.BorderStyle = BorderStyle.Fixed3D
                Me.comboBox3.Enabled = True
                Me.comboBox4.Enabled = True
                DomainBorderColorEdit.Enabled = False
            End If
        End Sub
#End Region

#Region "UpDownExt Themes Enabled"

        Private Sub checkBox14_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox14.CheckedChanged
            If Me.checkBox14.Checked Then
                Me.comboBox3.Enabled = False
                Me.comboBox4.Enabled = False
                DomainBorderColorEdit.Enabled = False
                Me.radioButton1.Enabled = False
                Me.radioButton2.Enabled = False
                Me.domainUpDownExt1.ThemesEnabled = True
                Me.numericUpDownExt7.ThemesEnabled = True
            Else
                Me.comboBox3.Enabled = True
                Me.comboBox4.Enabled = True
                DomainBorderColorEdit.Enabled = True
                Me.radioButton1.Enabled = True
                Me.radioButton2.Enabled = True
                Me.domainUpDownExt1.ThemesEnabled = False
                Me.numericUpDownExt7.ThemesEnabled = False
            End If
        End Sub
#End Region

#Region "UpDownExt InterceptArrowKeys"
        Private Sub checkBox15_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox15.CheckedChanged
            Console.WriteLine(Me.checkBox15.Checked)
            Me.domainUpDownExt1.InterceptArrowKeys = Me.checkBox15.Checked
            Me.numericUpDownExt7.InterceptArrowKeys = Me.checkBox15.Checked
        End Sub
#End Region

#Region "UpDownExt Office2007Style"
        Private Sub OfficeStyle_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton5.CheckedChanged, radioButton4.CheckedChanged, radioButton3.CheckedChanged, RadioButton12.CheckedChanged
            If Me.radioButton3.Checked Then
                Me.domainUpDownExt1.VisualStyle = VisualStyle.Office2007
                Me.domainUpDownExt1.ColorScheme = Office2007Theme.Blue
                Me.numericUpDownExt7.VisualStyle = VisualStyle.Office2007
                Me.numericUpDownExt7.ColorScheme = Office2007Theme.Blue
            End If
            If Me.radioButton4.Checked Then
                Me.domainUpDownExt1.VisualStyle = VisualStyle.Office2007
                Me.domainUpDownExt1.ColorScheme = Office2007Theme.Silver
                Me.numericUpDownExt7.VisualStyle = VisualStyle.Office2007
                Me.numericUpDownExt7.ColorScheme = Office2007Theme.Silver
            End If
            If Me.radioButton5.Checked Then
                Me.domainUpDownExt1.VisualStyle = VisualStyle.Office2007
                Me.domainUpDownExt1.ColorScheme = Office2007Theme.Black
                Me.numericUpDownExt7.VisualStyle = VisualStyle.Office2007
                Me.numericUpDownExt7.ColorScheme = Office2007Theme.Black
            End If

            If Me.RadioButton12.Checked Then
                Me.domainUpDownExt1.VisualStyle = VisualStyle.Office2007
                Me.domainUpDownExt1.ColorScheme = Office2007Theme.Managed
                Me.numericUpDownExt7.VisualStyle = VisualStyle.Office2007
                Me.numericUpDownExt7.ColorScheme = Office2007Theme.Managed

                Office2007Colors.ApplyManagedColors(Me, Color.Orange)
            End If
        End Sub
#End Region

#Region "UpDownExt DataBinding"
        Private Sub checkBox19_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox19.CheckedChanged
            If Me.checkBox19.Checked = True Then
                Me.domainUpDownExt1.DataBindings.Add("Text", Me.dataSet11.Sales, "Amount")
                Me.numericUpDownExt7.DataBindings.Add("Text", Me.dataSet11.Sales, "Amount")
                Me.oleDbDataAdapter1.Fill(Me.dataSet11.Sales)
                Me.dataGrid2.DataSource = Me.dataSet11.Sales
            Else
                Me.domainUpDownExt1.DataBindings.Clear()
                Me.numericUpDownExt7.DataBindings.Clear()
                Me.dataGrid2.DataSource = Nothing
            End If
        End Sub
#End Region

#Region "DomainUpDownSpinOrientation"

        Private Sub UpdownExtSpinOrientation_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox19.SelectedIndexChanged
            Me.domainUpDownExt1.SpinOrientation = CType(System.Enum.Parse(GetType(Orientation), Me.comboBox19.SelectedItem.ToString()), Orientation)
        End Sub
#End Region


#End Region

#Region "TextBoxExt"


#Region "TextBoxExt BorderStyle"
        Private Sub radioButton11_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton11.CheckedChanged
            If Me.radioButton11.Checked Then
                Me.textBoxExt4.BorderStyle = BorderStyle.FixedSingle
                Me.comboBox11.Enabled = False
            End If
        End Sub

        Private Sub radioButton10_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton10.CheckedChanged
            If Me.radioButton10.Checked Then
                Me.textBoxExt4.CornerRadius = 0
                Me.NumericUpDownExt8.Value = 0
                Me.textBoxExt4.BorderStyle = BorderStyle.Fixed3D
                Me.comboBox11.Enabled = True
            End If
        End Sub
#End Region

#Region "TextBoxExt BorderSides"
        Private Sub comboBox10_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox10.SelectedIndexChanged
            Select Case comboBox10.Items(comboBox10.SelectedIndex).ToString()
                Case "Left"
                    Me.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Left
                Case "Top"
                    Me.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Top
                Case "Right"
                    Me.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Right
                Case "Bottom"
                    Me.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                Case "Middle"
                    Me.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.Middle
                Case "All"
                    Me.textBoxExt4.BorderSides = System.Windows.Forms.Border3DSide.All

            End Select
        End Sub
#End Region

#Region "TextBoxExt Border3DStyle"
        Private Sub comboBox11_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox11.SelectedIndexChanged
            Select Case comboBox11.Items(comboBox11.SelectedIndex).ToString()
                Case "RaisedOuter"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.RaisedOuter
                Case "Adjust"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.Adjust
                Case "Bump"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.Bump
                Case "Etched"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.Etched
                Case "Flat"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.Flat
                Case "Raised"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.Raised
                Case "RaisedInner"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.RaisedInner
                Case "Sunken"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.Sunken
                Case "SunkenInner"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.SunkenInner
                Case "SunkenOuter"
                    Me.textBoxExt4.Border3DStyle = Border3DStyle.SunkenOuter
            End Select
        End Sub
#End Region

#Region "TextBoxExt Character casing"
        Private Sub comboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox8.SelectedIndexChanged
            Select Case comboBox8.Items(comboBox8.SelectedIndex).ToString()
                Case "Normal"
                    Me.textBoxExt4.CharacterCasing = CharacterCasing.Normal
                Case "Upper Case"
                    Me.textBoxExt4.CharacterCasing = CharacterCasing.Upper
                Case "Lower Case"
                    Me.textBoxExt4.CharacterCasing = CharacterCasing.Lower
            End Select
        End Sub
#End Region

#Region "TextBoxExt TextAlign"
        Private Sub comboBox12_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox12.SelectedIndexChanged
            Select Case comboBox12.Items(comboBox12.SelectedIndex).ToString()
                Case "Left"
                    Me.textBoxExt4.TextAlign = HorizontalAlignment.Left
                Case "Right"
                    Me.textBoxExt4.TextAlign = HorizontalAlignment.Right
                Case "Center"
                    Me.textBoxExt4.TextAlign = HorizontalAlignment.Center
            End Select
        End Sub
#End Region

        'To set as MultiLine
        Private Sub checkBox25_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox25.CheckedChanged
            If Me.checkBox25.Checked Then
                Me.textBoxExt4.Multiline = True
                Me.textBoxExt4.Text = "We are a leading provider of software components and tools for the Microsoft .NET platform. Powerful and feature-rich, Syncfusion’s broad range of products are vital to mission-critical applications in organizations ranging from small businesses to multinational Fortune 100 companies.  Syncfusion's mission is to produce world-class software components that enable developers to produce quality software for the most demanding of environments. Our innovative libraries are designed to be extensible to ensure maximum benefit to customers, and we provide full source code to enable seamless integration of our libraries with our customers' projects. We firmly believe that our success is closely tied to that of our customers. To help our customers succeed, we strive to offer technical support that is accessible, accurate, and fast."
                Me.textBoxExt4.Size = New Size(242, 77)
            Else
                Me.textBoxExt4.Multiline = False
                Me.textBoxExt4.Text = "TextBoxExt"
            End If
        End Sub

        'To make the TextBoxExt as readOnly
        Private Sub checkBox24_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox24.CheckedChanged
            Me.textBoxExt4.ReadOnly = Me.checkBox24.Checked
        End Sub

        'Right To Left
        Private Sub checkBox23_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox23.CheckedChanged
            If Me.checkBox23.Checked Then

                Me.textBoxExt4.RightToLeft = Windows.Forms.RightToLeft.Yes
            Else
                Me.textBoxExt4.RightToLeft = Windows.Forms.RightToLeft.No
            End If
        End Sub

        'To set Word Wrap
        Private Sub checkBox22_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox22.CheckedChanged
            Me.textBoxExt4.WordWrap = Me.checkBox22.Checked
        End Sub

#Region "TextBoxExt ScrollBars"
        Private Sub comboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox9.SelectedIndexChanged
            Select Case comboBox9.Items(comboBox9.SelectedIndex).ToString()
                Case "None"
                    Me.textBoxExt4.ScrollBars = ScrollBars.None
                Case "Horizontal"
                    Me.textBoxExt4.ScrollBars = ScrollBars.Horizontal
                Case "Vertical"
                    Me.textBoxExt4.ScrollBars = ScrollBars.Vertical
                Case "Both"
                    Me.textBoxExt4.ScrollBars = ScrollBars.Both
            End Select
        End Sub
#End Region

        'To set the TextBoxExt OverflowIndicatorToolTip Text
        Private Sub textBox11_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox11.TextChanged
            If Me.textBox11.Text <> "" Then
                Me.textBoxExt4.OverflowIndicatorToolTipText = Me.textBox11.Text
            End If
        End Sub

        'To show the TextBoxExt OverflowIndicatorToolTip
        Private Sub checkBox26_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox26.CheckedChanged
            Me.textBoxExt4.ShowOverflowIndicatorToolTip = Me.checkBox26.Checked
        End Sub

        'To show the TextBoxExt OverflowIndicator
        Private Sub checkBox21_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox21.CheckedChanged
            Me.textBoxExt4.ShowOverflowIndicator = Me.checkBox21.Checked
        End Sub

        'TextBoxExt BorderColor
        Private Sub buttonEdit2_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit2.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.buttonEdit2.TextBox.BackColor = colorDialog1.Color
                Me.textBoxExt4.BorderColor = colorDialog1.Color
            End If

        End Sub

        Private Sub NumericUpDownExt8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownExt8.ValueChanged
            If Me.NumericUpDownExt8.Value <> 0 Then
                Me.radioButton10.Checked = False
                Me.radioButton11.Checked = True
                Me.textBoxExt4.BorderStyle = BorderStyle.FixedSingle
                Me.textBoxExt4.CornerRadius = CInt(Me.NumericUpDownExt8.Value)
            End If
        End Sub
#End Region

#Region "EditableList"

#Region "DragDrop"
        Private Sub editableList2_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles editableList2.DragDrop
            Dim files As String() = CType(e.Data.GetData("FileDrop", False), String())

            For Each s As String In files
                Me.editableList2.ListBox.Items.Add(s.Substring(1 & s.LastIndexOf("\")))
            Next s
        End Sub
#End Region

#Region "DragEnter"
        Private Sub editableList2_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles editableList2.DragEnter
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then

                e.Effect = DragDropEffects.All

            Else

                e.Effect = DragDropEffects.None
            End If

        End Sub
#End Region


#Region "ListBoxTextAlign"

        Private Sub comboBox13_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox13.SelectedIndexChanged
            Select Case comboBox13.Items(comboBox13.SelectedIndex).ToString()
                Case "Left"
                    Me.editableList1.ListBoxTextAlignment = TextAlignment.Left
                Case "Right"
                    Me.editableList1.ListBoxTextAlignment = TextAlignment.Right
                Case "Center"
                    Me.editableList1.ListBoxTextAlignment = TextAlignment.Center
            End Select
        End Sub
#End Region

#Region "Want Button"
        Private Sub checkBox27_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox27.CheckedChanged
            Me.editableList1.WantButton = Me.checkBox27.Checked
        End Sub
#End Region

#Region "RightToLeft"
        Private Sub checkBox28_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox28.CheckedChanged
            If Me.checkBox28.Checked Then
                Me.editableList1.RightToLeft = Windows.Forms.RightToLeft.Yes
            Else

                Me.editableList1.RightToLeft = Windows.Forms.RightToLeft.No
            End If
        End Sub
#End Region

#End Region

#Region "Control Visible"

        Private Sub treeViewAdv1_AfterSelect(ByVal sender As Object, ByVal e As EventArgs) Handles treeViewAdv1.AfterSelect
            Me.treeViewAdv1.Nodes(0).BaseStyle = "Style2"
            For Each tabPage As TabPageAdv In Me.tabControlAdv1.TabPages
                tabPage.Hide()
            Next tabPage
            If Me.treeViewAdv1.SelectedNode.Text = "Input Controls" Then
                Me.tabPageAdv1.Show()
            End If
            If Me.treeViewAdv1.SelectedNode.Text = "UpDownExt Controls" Then
                Me.tabPageAdv3.Show()

            End If
            If Me.treeViewAdv1.SelectedNode.Text = "TextBoxExt" Then
                Me.tabPageAdv5.Show()
            End If
            If Me.treeViewAdv1.SelectedNode.Text = "Currency Edit" Then
                Me.tabPageAdv2.Show()
            End If
            If Me.treeViewAdv1.SelectedNode.Text = "Editable List" Then
                Me.tabPageAdv6.Show()
            End If
            If Me.treeViewAdv1.SelectedNode.Text = "Masked Edit" Then
                Me.tabPageAdv4.Show()
            End If
        End Sub
#End Region

#Region "MaskedEditBox"
        Private Sub radioButton9_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton9.CheckedChanged
            Me.maskedEditBox1.BorderStyle = BorderStyle.FixedSingle
            Me.comboBox7.Enabled = False
        End Sub

        Private Sub radioButton8_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton8.CheckedChanged
            If Me.radioButton8.Checked Then
                Me.maskedEditBox1.CornerRadius = 0
                Me.NumericUpDownExt9.Value = 0
                Me.maskedEditBox1.BorderStyle = BorderStyle.Fixed3D
                Me.comboBox7.Enabled = True
            End If
        End Sub

        Private Sub NumericUpDownExt9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownExt9.ValueChanged
            If Me.NumericUpDownExt9.Value <> 0 Then
                Me.radioButton8.Checked = False
                Me.radioButton9.Checked = True
                Me.maskedEditBox1.BorderStyle = BorderStyle.FixedSingle
                Me.maskedEditBox1.CornerRadius = CInt(Me.NumericUpDownExt9.Value)
            End If

        End Sub

        Private Sub comboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox7.SelectedIndexChanged
            Select Case comboBox7.Items(comboBox7.SelectedIndex).ToString()
                Case "RaisedOuter"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.RaisedOuter

                Case "Adjust"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.Adjust
                Case "Bump"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.Bump

                Case "Etched"

                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.Etched


                Case "Flat"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.Flat


                Case "Raised"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.Raised

                Case "RaisedInner"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.RaisedInner
                Case "Sunken"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.Sunken

                Case "SunkenInner"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.SunkenInner
                Case "SunkenOuter"
                    Me.maskedEditBox1.Border3DStyle = Border3DStyle.SunkenOuter

            End Select
        End Sub

        Private Sub comboBox14_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox14.SelectedIndexChanged
            Select Case comboBox14.Items(comboBox14.SelectedIndex).ToString()
                Case "Left"
                    Me.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Left
                Case "Top"
                    Me.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Top
                Case "Right"
                    Me.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Right
                Case "Bottom"
                    Me.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
                Case "Middle"
                    Me.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.Middle
                Case "All"
                    Me.maskedEditBox1.BorderSides = System.Windows.Forms.Border3DSide.All

            End Select
        End Sub

        Private Sub buttonEdit5_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit5.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Me.buttonEdit5.TextBox.BackColor = colorDialog1.Color
                Me.maskedEditBox1.BackColor = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonEdit3_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit3.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Me.buttonEdit3.TextBox.BackColor = colorDialog1.Color
                Me.maskedEditBox1.ForeColor = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonEdit4_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit4.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Me.buttonEdit4.TextBox.BackColor = colorDialog1.Color
                Me.maskedEditBox1.BorderColor = colorDialog1.Color
            End If
        End Sub

        Private Sub comboBox15_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox15.SelectedIndexChanged
            Select Case comboBox15.Items(comboBox15.SelectedIndex).ToString()
                Case "None"
                    Me.maskedEditBox1.Mask = ""


                Case "##/##/####"
                    Me.maskedEditBox1.Mask = "##/##/####"

                Case "##.##"
                    Me.maskedEditBox1.Mask = "##.##"

                Case "###-########"
                    Me.maskedEditBox1.Mask = "###-########"

            End Select



        End Sub


        Private Sub comboBox17_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox17.SelectedIndexChanged
            Select Case comboBox17.Items(comboBox17.SelectedIndex).ToString()
                Case "Normal"
                    Me.maskedEditBox1.CharacterCasing = CharacterCasing.Normal
                Case "Upper Case"
                    Me.maskedEditBox1.CharacterCasing = CharacterCasing.Upper
                Case "Lower Case"
                    Me.maskedEditBox1.CharacterCasing = CharacterCasing.Lower
            End Select
        End Sub

        Private Sub comboBox16_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox16.SelectedIndexChanged
            Select Case comboBox16.Items(comboBox16.SelectedIndex).ToString()
                Case "Left"
                    Me.maskedEditBox1.TextAlign = HorizontalAlignment.Left

                    Exit Select
                Case "Right"
                    Me.maskedEditBox1.TextAlign = HorizontalAlignment.Right

                    Exit Select
                Case "Center"
                    Me.maskedEditBox1.TextAlign = HorizontalAlignment.Center

                    Exit Select
            End Select


        End Sub

        Private Sub checkBox30_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox30.CheckedChanged
            Me.maskedEditBox1.ReadOnly = Me.checkBox30.Checked

        End Sub

        Private Sub checkBox29_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox29.CheckedChanged
            If Me.checkBox29.Checked Then
                Me.maskedEditBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
            Else

                Me.maskedEditBox1.RightToLeft = Windows.Forms.RightToLeft.No
            End If
        End Sub


        Private Sub comboBox18_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox18.SelectedIndexChanged
            Select Case comboBox18.Items(comboBox18.SelectedIndex).ToString()
                Case "*"
                    Me.maskedEditBox1.PasswordChar = "*"c
                Case "#"
                    Me.maskedEditBox1.PasswordChar = "#"c
                Case "@"
                    Me.maskedEditBox1.PasswordChar = "@"c
            End Select
        End Sub



#End Region

#Region "Banner Text Settings"

        Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
            If txtBanner.Text = "" Then
                button1.Enabled = False
            Else
                button1.Enabled = True
            End If

            If txtBnr.Text = "" Then
                btnSetBanner.Enabled = False
            Else
                btnSetBanner.Enabled = True
            End If

            If textBanner.Text = "" Then
                buttonBanner.Enabled = False
            Else
                buttonBanner.Enabled = True
            End If
        End Sub

        'TextBoxExt
        Private Sub bannerClrEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles bannerClrEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                bannerClrEdit.TextBox.BackColor = colorDialog1.Color
            End If
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim mode As BannerTextMode
            If rdoEdit.Checked Then
                mode = BannerTextMode.EditMode
            Else
                mode = BannerTextMode.FocusMode
            End If

            Dim binfo As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.textBoxExt4)
            binfo.Text = txtBanner.Text
            binfo.Mode = mode
            binfo.Color = bannerClrEdit.TextBox.BackColor

            Me.textBoxExt4.Refresh()
        End Sub

        'Input Controls
        Private Sub bannerClr_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles bannerClr.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                bannerClr.TextBox.BackColor = colorDialog1.Color
            End If
        End Sub

        Private Sub btnSetBanner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetBanner.Click
            Dim mode As BannerTextMode = CType(System.Enum.Parse(GetType(BannerTextMode), cmbMode.SelectedItem.ToString()), BannerTextMode)
            Dim binfo As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.currencyTextBox1)
            binfo.Text = txtBnr.Text
            binfo.Mode = mode
            binfo.Color = bannerClr.TextBox.BackColor
            currencyTextBox1.Refresh()

            Dim binfo2 As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.integerTextBox2)
            binfo2.Text = txtBnr.Text
            binfo2.Mode = mode
            binfo2.Color = bannerClr.TextBox.BackColor
            integerTextBox1.Refresh()

            Dim binfo3 As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.doubleTextBox1)
            binfo3.Text = txtBnr.Text
            binfo3.Mode = mode
            binfo3.Color = bannerClr.TextBox.BackColor
            doubleTextBox1.Refresh()

            Dim binfo4 As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.percentTextBox1)
            binfo4.Text = txtBnr.Text
            binfo4.Mode = mode
            binfo4.Color = bannerClr.TextBox.BackColor
            percentTextBox1.Refresh()
        End Sub

        'UpDown controls
        Private Sub bEditBanner_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles bEditBanner.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                bEditBanner.TextBox.BackColor = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonBanner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonBanner.Click
            Dim mode As BannerTextMode = CType(System.Enum.Parse(GetType(BannerTextMode), comboMode.SelectedItem.ToString()), BannerTextMode)

            Dim binfo As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.domainUpDownExt1)
            binfo.Text = textBanner.Text
            binfo.Mode = mode
            binfo.Color = bEditBanner.TextBox.BackColor
            domainUpDownExt1.Refresh()

            Dim binfo2 As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.numericUpDownExt7)
            binfo2.Text = textBanner.Text
            binfo2.Mode = mode
            binfo2.Color = bEditBanner.TextBox.BackColor
            Me.numericUpDownExt7.Refresh()
        End Sub
#End Region




        Private Sub currencyEdit1_CalculatorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles currencyEdit1.CalculatorButton.Click

        End Sub

        Private Sub CheckBox31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox31.CheckedChanged
            If (Not Me.CheckBox31.Checked) Then
                Me.textBoxExt4.FarImage = Nothing
            Else
                Me.textBoxExt4.FarImage = New Bitmap("..//..//FarImage.png")
            End If

        End Sub

        Private Sub CheckBox32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox32.CheckedChanged
            If (Not Me.CheckBox32.Checked) Then
                Me.textBoxExt4.NearImage = Nothing
            Else
                Me.textBoxExt4.NearImage = New Bitmap("..//..//NearImage.png")
            End If

        End Sub
        Private Sub chkPullCharOnDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPullCharOnDelete.CheckedChanged
            '            Me.maskedEditBox1.PullCharOnDelete = chkPullCharOnDelete.Checked
        End Sub

    End Class
End Namespace