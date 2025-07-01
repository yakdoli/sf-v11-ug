Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Design
Imports Syncfusion.Collections
Imports Syncfusion.ComponentModel
Imports System.Drawing.Design
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.Runtime.Serialization
Imports System.Reflection
Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms.Grid

Namespace ExcelLikeUI_2005
	''' <summary>
	''' Summary description for FontComboBoxBarItem.
	''' </summary>
	Public Class FontComboBoxBarItem
		Inherits ComboBoxBarItem
		Public Sub New()
			MyBase.New()
			'
			' TODO: Add constructor logic here
			'
			Me.ListBox = New FontListBox()

		End Sub
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			Me.ListBox = New FontListBox()
		End Sub


	End Class


	Public Class FontListBox
		Inherits System.Windows.Forms.ListBox
		#Region "Private variables"
		'private ArrayList favourites;
		Private nonreadable As String()
		Private image_Renamed As Image
        Private Shadows defaultFont As Font
		Private nonReadableStringFormat As StringFormat
		Private standardStringFormat As StringFormat
		#End Region

		#Region "Constructors"
		Public Sub New()
			Me.DrawMode = DrawMode.OwnerDrawFixed

			'maxFavourites = 5;
			image_Renamed = Nothing
			defaultFont = New Font("Tahoma", 8)
			nonReadableStringFormat = New StringFormat()
			nonReadableStringFormat.LineAlignment = StringAlignment.Center

			standardStringFormat = New StringFormat()
			standardStringFormat.FormatFlags = StringFormatFlags.NoWrap
			'favourites = new ArrayList();

			If (Not DesignMode) Then
				GetFonts(Me.CreateGraphics())

				'favourites.Add("Arial");
				'this.Items.Insert(0, favourites[0].ToString());
			End If

			nonreadable = New String(){"CommercialPi BT","GreekC","GreekS","Marlett", "Monotype Corsiva", "MS Outlook","Nokia PC Composer", "UniversalMath1 BT", "Symusic", "Symeteo", "Symbol", "Symath", "Symap", "Syastro", "Webdings", "Wingdings", "Wingdings 2", "Wingdings 3"}
		End Sub

		#End Region

		#Region "Public Properties"
        Public Property Image() As System.Drawing.Image
            Get
                Return image_Renamed
            End Get
            Set(ByVal value As System.Drawing.Image)
                image_Renamed = value
                Me.Invalidate()
            End Set
        End Property

        <Browsable(False)> _
        Public Property NonReadableFonts() As String()
            Get
                Return nonreadable
            End Get
            Set(ByVal value As String())
                nonreadable = value
                Me.Invalidate()
            End Set
        End Property

        '		[DefaultValue(5)]
        '		public int MaximumFavourites
        '		{
        '			get
        '			{
        '				return maxFavourites;
        '			}
        '			set
        '			{
        '				maxFavourites = value;
        '				this.Invalidate();
        '			}
        '		}

#End Region

		#Region "Private Functions"
		Private Sub GetFonts(ByVal g As Graphics)
			Dim installedFonts As System.Drawing.Text.InstalledFontCollection = New System.Drawing.Text.InstalledFontCollection()

			Dim fonts As FontFamily() = installedFonts.Families
			Me.BeginUpdate()
			Dim name As String = ""
			For Each font As FontFamily In fonts
				name = font.Name.Trim()
				If (Not Me.Items.Contains(name)) Then
					Me.Items.Add(name)
				End If
			Next font
			Me.EndUpdate()
		End Sub

		Private Sub DrawSeperator(ByVal g As Graphics, ByVal rect As Rectangle)
			Dim pen As Pen = New Pen(ControlPaint.LightLight(Me.ForeColor))
			g.DrawLine(pen, rect.X + 1, rect.Y + rect.Height - 3, rect.X + rect.Width - 2, rect.Y + rect.Height - 3)
			g.DrawLine(pen, rect.X + 1, rect.Y + rect.Height - 1, rect.X + rect.Width - 2, rect.Y + rect.Height - 1)
		End Sub

		Private Function IsNonReadableFont(ByVal FontName As String) As Boolean
			For Each non As String In nonreadable
				If FontName = non Then
					Return True
				End If
			Next non
			Return False
		End Function

		#End Region

		#Region "Overriden Functions / Events"
		Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
			If e.Index < 0 Then
				Return
			End If
			If (e.Index = 0) AndAlso (Items.Count = 0) Then
				Return
			End If
			Dim g As Graphics = e.Graphics
			Dim imgRect As Rectangle
			Dim textRect As Rectangle
			Dim font As Font = Nothing
			Dim brush As SolidBrush = New SolidBrush(e.ForeColor)
			Dim fontName As String = Me.Items(e.Index).ToString()

			Try
				font = New Font(fontName, Me.Font.Size)
			Catch
				font = defaultFont
			End Try


			e.DrawBackground()

			If Not image_Renamed Is Nothing Then
				imgRect = New Rectangle(e.Bounds.X, e.Bounds.Y, image_Renamed.Width, image_Renamed.Height)
			Else
				' No image
				imgRect = New Rectangle(e.Bounds.X, e.Bounds.Y, 0, 0)
			End If

			textRect = New Rectangle(imgRect.X + imgRect.Width + 2, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)

			If Not image_Renamed Is Nothing Then
				g.DrawImage(image_Renamed, imgRect)
			End If

			If IsNonReadableFont(fontName) Then
				g.DrawString(fontName, defaultFont, brush, textRect, nonReadableStringFormat)
				Dim wordwidth As Integer = g.MeasureString(fontName, defaultFont).ToSize().Width
				g.DrawString(fontName, font, brush, New Rectangle(textRect.X + wordwidth, textRect.Y, e.Bounds.Width, e.Bounds.Height), standardStringFormat)
			Else
				g.DrawString(fontName, font, brush, textRect, standardStringFormat)
			End If

			e.DrawFocusRectangle()

'			if (favourites.Count - 1 == e.Index)
'			{
'				DrawSeperator(g, e.Bounds);
'			}
		End Sub
		Protected Overrides Sub OnSelectedIndexChanged(ByVal e As EventArgs)
			MyBase.OnSelectedIndexChanged(e)

			Dim fontName As String = Me.Text

			If fontName = "" Then
				Return
			End If
'			int indexOf = favourites.IndexOf(fontName);
'			if (indexOf == -1)
'			{
'				if (maxFavourites > favourites.Count)
'				{
'					// Insert new
'					favourites.Insert(0, fontName);
'					this.Items.Insert(0, fontName);
'				}
'				else
'				{
'					// Don't add any new fonts - replace instead
'					favourites.RemoveAt(maxFavourites - 1);
'					favourites.Insert(0, fontName);
'					this.Items.RemoveAt(maxFavourites - 1);
'					this.Items.Insert(0, fontName);
'				}
'			}
'			else
'				// Move existing arount
'				if (favourites.Count > 1)
'				{
'					favourites.RemoveAt(indexOf);
'					favourites.Insert(0, fontName);
'					this.Items.RemoveAt(indexOf);
'					this.Items.Insert(0, fontName);
'				}
			Me.EndUpdate()

		End Sub

		Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
			MyBase.OnFontChanged(e)
			Me.ItemHeight = Me.Font.Height + 3
			' 3 is used here to allow for the favourites seperator line 
		End Sub

		#End Region

		#Region "Hidden Properties"
		<Browsable(False)> _
		Public Overrides Property DrawMode() As DrawMode
			Get
				Return MyBase.DrawMode
			End Get
			Set(ByVal value As DrawMode)
				MyBase.DrawMode = value
			End Set
		End Property
		<Browsable(False)> _
		Public Overrides Property SelectionMode() As SelectionMode
			Get
				Return MyBase.SelectionMode
			End Get
			Set(ByVal value As SelectionMode)
				MyBase.SelectionMode = value
			End Set
		End Property
		'		[Browsable(false)]
		'		public override int ItemHeight
		'		{
		'			get
		'			{
		'				return base.ItemHeight;
		'			}
		'			set
		'			{
		'				base.ItemHeight = value;
		'			}
		'		}
		#End Region


	End Class
End Namespace
