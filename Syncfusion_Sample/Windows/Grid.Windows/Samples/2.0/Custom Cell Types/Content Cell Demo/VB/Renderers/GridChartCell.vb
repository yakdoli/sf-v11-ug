Imports Microsoft.VisualBasic
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports System.Security.Permissions
Imports System.ComponentModel

Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Styles
Imports Syncfusion.Drawing

Namespace ContentCellDemo
	#Region "ChartCellModel class"
	<Serializable> _
	Public Class GridChartCellModel
		Inherits GridStaticCellModel

		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
			Me.cellvalueGridRangeInfo = New GridRangeInfo()
			Me.chartareaGridRangeInfo = New GridRangeInfo()
		End Sub

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		''' <override/>
		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New GridChartCellRenderer(control, Me)
		End Function

		Public Sub InitializeChartProperties(ByVal chart As ChartControl, ByVal style As GridStyleInfo)
			chart.BeginUpdate()



			'if(chart.Series.Count == 1)
				Dim range As GridRangeInfo = Me.cellvalueGridRangeInfo

				chart.Series.Clear()
				For i As Integer = 0 To range.Width - 1
					Dim series As New ChartSeries(String.Format("Team {0}", i)) ',csp.ChartType);
					'series = chart.Model.NewSeries(string.Format("Team {0}", i));
					series.Text = series.Name
					series.SeriesModel = New ChartGridSeriesModel(Me.Grid, range, i)
					chart.Series.Add(series)
				Next i

			Dim csp As New ChartStyleProperties(style)
			chart.Text=csp.TitleText
			chart.TextAlignment=csp.TitleAlignment
			'chart.TextPosition=csp.TitlePostion;
			chart.Palette=csp.ColorPalette
			If csp.ChartBackColor <> Color.Transparent Then
				chart.BackColor=csp.ChartBackColor
			End If
			chart.ChartArea.BackInterior=csp.ChartAreaBackInterior
			'chart.Legend.Visible=true;
			'chart.ShowLegend=csp.ShowLegend;
			'chart.LegendPosition=csp.LegendPosition;
			chart.Series3D=csp.Series3D
			chart.PrimaryXAxis.DrawGrid=csp.XAxisGridLines
			chart.PrimaryYAxis.DrawGrid=csp.YAxisGridLines
			chart.PrimaryXAxis.Title=csp.XAxisTitle
			chart.PrimaryYAxis.Title=csp.YAxisTitle
			For Each ss As ChartSeries In chart.Series
				ss.Type=csp.ChartType
			Next ss
			chart.EndUpdate()
		End Sub

		Private cellvalueGridRangeInfo As GridRangeInfo
		Private chartareaGridRangeInfo As GridRangeInfo

		Public Property ChartAreaRangeInfo() As GridRangeInfo
			Get
				Return Me.chartareaGridRangeInfo
			End Get
			Set(ByVal value As GridRangeInfo)
				Me.chartareaGridRangeInfo = value
			End Set
		End Property

		Public Property CellValueRangeInfo() As GridRangeInfo
			Get
				Return Me.cellvalueGridRangeInfo
			End Get
			Set(ByVal value As GridRangeInfo)
				Me.cellvalueGridRangeInfo = value
			End Set
		End Property
	End Class
	#End Region

	#Region "ChartCellRenderer class"
	Public Class GridChartCellRenderer
		Inherits GridStaticCellRenderer
		Private chartControl As GridChartControl
		Private bmp As Bitmap

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			chartControl = New GridChartControl(Me)
		End Sub

		Private Sub FixParent(ByVal chart As GridChartControl)
			If Me.chartControl.Parent IsNot Grid Then
				Me.chartControl.Visible = True
				Me.chartControl.Location = New Point(10000, 10000)
				Me.chartControl.CausesValidation = False
				Grid.Controls.Add(chartControl)
				Me.chartControl.Visible = False
			End If
		End Sub

		Protected Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)
			' Get the client bounds taking floated cells into consideration.
			Dim bounds As Rectangle = GetCellClientRectangle(rowIndex, colIndex, style, True)
			Me.chartControl.Location = bounds.Location
			Me.chartControl.BackColor = Color.FromArgb(255, Grid.GetBackColor(style.Interior.BackColor))
			'this.chartControl.Legend.Visible=true;

			Dim model As GridChartCellModel = TryCast(Me.Model, GridChartCellModel)

			model.InitializeChartProperties(Me.chartControl,style)

			FixParent(Me.chartControl)

			If bmp Is Nothing Then
				bmp = New Bitmap(bounds.Width, bounds.Height)
			End If

			chartControl.Draw(bmp)

			g.DrawImage(bmp, bounds)
		End Sub

	End Class
	#End Region

	#Region "GridChartControl class"
	<ToolboxItem(False)> _
	Public Class GridChartControl
		Inherits ChartControl
'INSTANT VB NOTE: The variable parent was renamed since Visual Basic does not allow class members with the same name:
		Private parent_Renamed As GridChartCellRenderer

		Public Sub New(ByVal parent As GridChartCellRenderer)
			Me.parent_Renamed = parent
		End Sub

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property ParentCell() As GridChartCellRenderer
			Get
				Return Me.parent_Renamed
			End Get
		End Property
	End Class
	#End Region

	#Region "ChartStyleProperties class"
	''' <summary>
	''' Provides custom properties specific for slider control. All properties
	''' support the style inheritance mechanism. You can change these propeties
	''' in the property grid.
	''' </summary>
	Public Class ChartStyleProperties
		Inherits GridStyleInfoCustomProperties
		' static initialization of property descriptors
		Private Shared t As Type = GetType(ChartStyleProperties)

		Private ReadOnly Shared ChartTypeProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "ChartType")
		Private ReadOnly Shared TitleTextProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "TitleText")
		Private ReadOnly Shared TitleAlignmentProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "TitleAlignment")
		'readonly static StyleInfoProperty TitlePositionProperty = CreateStyleInfoProperty(t, "TitlePosition");
		Private ReadOnly Shared ColorPaletteProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "ColorPalette")
		Private ReadOnly Shared ChartBackColorProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "ChartBackColor")
		'readonly static StyleInfoProperty ShowLegendProperty = CreateStyleInfoProperty(t, "ShowLegend");
		'readonly static StyleInfoProperty LegendPositionProperty = CreateStyleInfoProperty(t, "LegendPosition");
		Private ReadOnly Shared ChartAreaBackInteriorProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "ChartAreaBackInterior")
		Private ReadOnly Shared Series3DProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "Series3D")
		Private ReadOnly Shared XAxisGridLinesProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "XAxisGridLines")
		Private ReadOnly Shared YAxisGridLinesProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "YAxisGridLines")
		Private ReadOnly Shared XAxisTitleProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "XAxisTitle")
		Private ReadOnly Shared YAxisTitleProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "YAxisTitle")

		' default settings for all properties this object holds
		Private Shared defaultObject As ChartStyleProperties

		' initialize default settings for all properties in static ctor
		Shared Sub New()
			' all properties must be initialized for the Default property
			defaultObject = New ChartStyleProperties(GridStyleInfo.Default)
			Dim chartCtrl As New ChartControl()
			defaultObject.ChartType=ChartSeriesType.Column
			defaultObject.TitleText=chartCtrl.Text
			defaultObject.ColorPalette=chartCtrl.Palette
			defaultObject.ChartBackColor=chartCtrl.BackColor
			defaultObject.ChartAreaBackInterior=chartCtrl.ChartArea.BackInterior
			'defaultObject.ShowLegend=chartCtrl.ShowLegend;
			'defaultObject.TitlePostion=chartCtrl.TextPosition;
			defaultObject.TitleAlignment=chartCtrl.TextAlignment
			'defaultObject.LegendPosition=chartCtrl.LegendPosition;
			defaultObject.Series3D=chartCtrl.Series3D
			defaultObject.XAxisGridLines=chartCtrl.PrimaryXAxis.DrawGrid
			defaultObject.YAxisGridLines=chartCtrl.PrimaryYAxis.DrawGrid
			defaultObject.XAxisTitle=chartCtrl.PrimaryXAxis.Title
			defaultObject.YAxisTitle=chartCtrl.PrimaryYAxis.Title
		End Sub

		''' <summary>
		''' Provides access to default values for this type
		''' </summary>
		Public Shared ReadOnly Property [Default]() As ChartStyleProperties
			Get
				Return defaultObject
			End Get
		End Property

		''' <summary>
		''' Force static ctor being called at least once
		''' </summary>
		Public Shared Sub Initialize()
		End Sub

		' explicit cast from GridStyleInfo to ChartStyleProperties
		' (Note: this will only work for C#, Visual Basic does not support dynamic casts)

		''' <summary>
		''' Explicit cast from GridStyleInfo to this custom propety object
		''' </summary>
		''' <returns>A new custom properties object.</returns>
		Public Shared Narrowing Operator CType(ByVal style As GridStyleInfo) As ChartStyleProperties
			Return New ChartStyleProperties(style)
		End Operator

		''' <summary>
		''' Initializes a ChartStyleProperties object with a style object that holds all data
		''' </summary>
		Public Sub New(ByVal style As GridStyleInfo)
			MyBase.New(style)
		End Sub

		''' <summary>
		''' Initializes a ChartStyleProperties object with an empty style object. Design
		''' time environment will use this ctor and later copy the values to a style object
		''' by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		''' <summary>
		''' Gets or sets Chart Type
		''' </summary>
		<Description("Provides the chart type for this cell"), Browsable(True), Category("Chart")> _
		Public Property ChartType() As ChartSeriesType
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(ChartTypeProperty), ChartSeriesType)
			End Get
			Set(ByVal value As ChartSeriesType)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ChartTypeProperty, value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets Title Text of the chart
		''' </summary>
		<Description("Provides the Text for this cell"), Browsable(True), Category("Chart")> _
		Public Property TitleText() As String
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CStr(style.GetValue(TitleTextProperty))
			End Get
			Set(ByVal value As String)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TitleTextProperty, value)
			End Set
		End Property

		''' <summary>
		''' Specifies the Horizontal Alignment of TitleText of the chart
		''' </summary>
		<Description("Provides the Alignment for TitleText of the chart cell"), Browsable(True), Category("Chart")> _
		Public Property TitleAlignment() As StringAlignment
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(TitleAlignmentProperty), StringAlignment)
			End Get
			Set(ByVal value As StringAlignment)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TitleAlignmentProperty, value)
			End Set
		End Property

'		/// <summary>
'		/// Specifies the position of the TitleText of the chart
'		/// </summary>
'		[
'		Description("Provides the TitlePosition of the chart cell"),
'		Browsable(true),
'		Category("Chart")
'		]
'		public ChartTextPosition TitlePostion
'		{
'			get
'			{
'				//TraceUtil.TraceCurrentMethodInfo();
'				return (ChartTextPosition) style.GetValue(TitlePositionProperty);
'			}
'			set
'			{
'				//TraceUtil.TraceCurrentMethodInfo(value);
'				style.SetValue(TitlePositionProperty, value);
'			}
'		}

'		/// <summary>
'		/// Specifies whether the Legend should be displayed or not
'		/// </summary>
'		[
'		Description("Specifies whether the Legend should be displayed or not"),
'		Browsable(true),
'		Category("Chart")
'		]
'		public bool ShowLegend
'		{
'			get
'			{
'				//TraceUtil.TraceCurrentMethodInfo();
'				return (bool) style.GetValue(ShowLegendProperty);
'			}
'			set
'			{
'				//TraceUtil.TraceCurrentMethodInfo(value);
'				style.SetValue(ShowLegendProperty, value);
'			}
'		}
'
'		/// <summary>
'		/// Specifies the LegendPosition of the chart
'		/// </summary>
'		[
'		Description("Provides the LegendPosition for the chart cell"),
'		Browsable(true),
'		Category("Chart")
'		]
'		public ChartDock LegendPosition
'		{
'			get
'			{
'				//TraceUtil.TraceCurrentMethodInfo();
'				return (ChartDock) style.GetValue(LegendPositionProperty);
'			}
'			set
'			{
'				//TraceUtil.TraceCurrentMethodInfo(value);
'				style.SetValue(LegendPositionProperty, value);
'			}
'		}

		''' <summary>
		''' Gets or sets Color Palette of the chart
		''' </summary>
		<Description("Provides the Color Palette for the chart"), Browsable(True), Category("Chart")> _
		Public Property ColorPalette() As ChartColorPalette
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(ColorPaletteProperty), ChartColorPalette)
			End Get
			Set(ByVal value As ChartColorPalette)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ColorPaletteProperty, value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets BackColor
		''' </summary>
		<Description("Provides the BackColor for this cell"), Browsable(True), Category("Chart")> _
		Public Property ChartBackColor() As Color
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(ChartBackColorProperty), Color)
			End Get
			Set(ByVal value As Color)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ChartBackColorProperty, value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets Interior of the ChartArea
		''' </summary>
		<Description("Provides the Interior for the ChartArea of this cell"), Browsable(True), Category("Chart")> _
		Public Property ChartAreaBackInterior() As BrushInfo
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(ChartAreaBackInteriorProperty), BrushInfo)
			End Get
			Set(ByVal value As BrushInfo)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ChartAreaBackInteriorProperty, value)
			End Set
		End Property

		''' <summary>
		''' Allows 3DStyle
		''' </summary>
		<Description("Allows 3D style"), Browsable(True), Category("Chart")> _
		Public Property Series3D() As Boolean
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CBool(style.GetValue(Series3DProperty))
			End Get
			Set(ByVal value As Boolean)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(Series3DProperty, value)
			End Set
		End Property

		''' <summary>
		''' Specifies whether to display grid lines along the Primary X-Axis or not
		''' </summary>
		<Description("Specifies whether to display grid lines along the Primary X-Axis or not"), Browsable(True), Category("Chart")> _
		Public Property XAxisGridLines() As Boolean
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CBool(style.GetValue(XAxisGridLinesProperty))
			End Get
			Set(ByVal value As Boolean)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(XAxisGridLinesProperty, value)
			End Set
		End Property

		''' <summary>
		''' Specifies whether to display grid lines along the Primary Y-Axis or not
		''' </summary>
		<Description("Specifies whether to display grid lines along the Primary Y-Axis or not"), Browsable(True), Category("Chart")> _
		Public Property YAxisGridLines() As Boolean
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CBool(style.GetValue(YAxisGridLinesProperty))
			End Get
			Set(ByVal value As Boolean)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(YAxisGridLinesProperty, value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the title of the x-axis
		''' </summary>
		<Description("Privides the Title for Primary X-Axis"), Browsable(True), Category("Chart")> _
		Public Property XAxisTitle() As String
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CStr(style.GetValue(XAxisTitleProperty))
			End Get
			Set(ByVal value As String)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(XAxisTitleProperty, value)
			End Set
		End Property

		''' <summary>
		''' Gets or sets the title of the y-axis
		''' </summary>
		<Description("Privides the Title for Primary Y-Axis"), Browsable(True), Category("Chart")> _
		Public Property YAxisTitle() As String
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CStr(style.GetValue(YAxisTitleProperty))
			End Get
			Set(ByVal value As String)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(YAxisTitleProperty, value)
			End Set
		End Property
	End Class
	#End Region
End Namespace
