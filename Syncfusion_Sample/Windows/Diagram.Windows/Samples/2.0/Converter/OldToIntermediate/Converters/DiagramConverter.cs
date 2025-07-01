using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Rectangle = Syncfusion.Windows.Forms.Diagram.Rectangle;
using Label = Syncfusion.Windows.Forms.Diagram.Label;
using FontStyle = Syncfusion.Windows.Forms.Diagram.FontStyle;
using BorderStyle=Syncfusion.Windows.Forms.Diagram.BorderStyle;
using Syncfusion.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace OldToIntermediate
{
	/// <summary>
	/// Summary description for DiagramConverter.
	/// </summary>
	public class DiagramConverter
	{
		#region Class constants
		private const string c_strDOCUMENT_EXTENSION = @"\.edd";
		private const string c_strPALETTE_EXTENSION = @"\.edp";
		#endregion
		
		#region Class members
		private XmlDocument m_intermediateFormat;
		private Diagram m_diagramTemp;
		private SymbolPalette m_paletteTemp;
		private bool m_bSymbolParsing;
		private bool m_bPaletteParsing;
		/// <summary>
		/// Helper matrix containing parent( symbols, groups ) transformations.
		/// </summary>
		private Matrix m_matrixParent;
		#endregion
		
		#region Class properties
		private bool PaletteParsing
		{
			get{ return m_bPaletteParsing; }
			set{ m_bPaletteParsing = value; }
		}
		private bool SymbolParsing
		{
			get{ return m_bSymbolParsing; }
			set{ m_bSymbolParsing = value; }
		}
		private Matrix ParentTransforms
		{
			get
			{
				if( m_matrixParent == null )
				{
					m_matrixParent = new Matrix();
				}
				
				 return m_matrixParent;
			}
		}
		/// <summary>
		/// Document in intermediate format.
		/// </summary>
		private XmlDocument DocIntmdFormat
		{
			get
			{
				if( m_intermediateFormat == null )
				{
					m_intermediateFormat = new XmlDocument();
				}
				
				return m_intermediateFormat;
			}
		}
		#endregion
		
		#region Class public methods
		public bool TryLoadDocument( string strDocumentPath )
		{
			bool bSuccess = false;
			
			if( File.Exists( strDocumentPath ) && IsDocument( strDocumentPath ) )
			{
				m_diagramTemp = new Diagram();
				
				if( TryLoadDocumentBinary( m_diagramTemp, strDocumentPath ) )
				{
					bSuccess = true;
				}
				else if( TryLoadDocumentSoap( m_diagramTemp, strDocumentPath ) )
				{
					bSuccess = true;
				}
			}
				
			return bSuccess;
		}
		public bool TryLoadPalette( string strPalettePath )
		{
			bool bSuccess = false;
			
			if( File.Exists( strPalettePath ) && IsPalette( strPalettePath ) )
			{
				FileStream iStream = null;

				try
				{
					iStream = new FileStream( strPalettePath, FileMode.Open, FileAccess.Read );

					AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler( AssemblyResolver );
					m_paletteTemp = GetPaletteFromStream( iStream );
				}
				finally
				{
					AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler( AssemblyResolver );

					if (iStream != null)
						iStream.Close();
				}

				if( m_paletteTemp != null )
				{
					bSuccess = true;
				}
			}
				
			return bSuccess;
		}
		public void ParseDocument()
		{
			if( m_diagramTemp == null || m_diagramTemp.Model == null )
				throw new ArgumentNullException( "diagram" );
			
			this.DocIntmdFormat.RemoveAll();
			// change model units to pixels
			m_diagramTemp.Model.MeasurementUnits = GraphicsUnit.Pixel;
			// Root element
			XmlNode nodeRoot = this.DocIntmdFormat.CreateElement( "Document" );
			this.DocIntmdFormat.AppendChild( nodeRoot );
			// parse model
			XmlNode nodeXmlCur = ParseModel( m_diagramTemp.Model );
			nodeRoot.AppendChild( nodeXmlCur );
			// parse model nodes
			NodeCollection nodesModel = MakeZOrderSort( ( NodeCollection ) m_diagramTemp.Model.Nodes );
			XmlNode nodes = ParseNodes( nodesModel );
			nodeRoot.AppendChild( nodes );
		}
		private XmlNode ParseNodes( NodeCollection nodes )
		{
			// parse nodes
			XmlElement nodesToReturn = this.DocIntmdFormat.CreateElement( "Nodes" );
			XmlNode nodeXmlCur = null;
			
			foreach( INode nodeCur in nodes )
			{
				Type type = nodeCur.GetType();
				
				if( nodeCur is ICompositeNode && !( nodeCur is Link ) )
				{
					nodeXmlCur = ParseSymbol( ( ICompositeNode ) nodeCur );
				}

				if( nodeCur is Rectangle )
				{
					nodeXmlCur = ParseRectangle( ( Rectangle )nodeCur );
				}
				else if( nodeCur is RoundRect )
				{
					nodeXmlCur = ParseRoundRectangle( ( RoundRect )nodeCur );
				}
				else if( nodeCur is Ellipse )
				{
					nodeXmlCur = ParseEllipse( ( Ellipse )nodeCur );
				}
				else if( nodeCur is Line )
				{
					nodeXmlCur = ParseLine( ( Line )nodeCur );
				}
				else if( nodeCur is Arc )
				{
					nodeXmlCur = ParseArc( ( Arc )nodeCur );
				}
				else if( nodeCur is ClosedCurve )
				{
					nodeXmlCur = ParseClosedCurve( ( ClosedCurve )nodeCur );
				}
				else if( nodeCur is Curve )
				{
					nodeXmlCur = ParseCurve( ( Curve )nodeCur );
				}
				else if( nodeCur is PolyLine )
				{
					nodeXmlCur = ParsePolyLine( ( PolyLine )nodeCur );
				}
				else if( nodeCur is Polygon )
				{
					nodeXmlCur = ParsePolygon( ( Polygon )nodeCur );
				}
				else if( nodeCur is MetafileNode )
				{
					nodeXmlCur = ParseMetafileNode( ( MetafileNode )nodeCur );
				}
				else if( nodeCur is BitmapNode )
				{
					nodeXmlCur = ParseBitmapNode( ( BitmapNode )nodeCur );
				}
				else if( nodeCur is Figure )
				{
					nodeXmlCur = ParseFigure( ( Figure )nodeCur );
				}
				else if( nodeCur is TextNode && !( nodeCur is Label ) )
				{
					nodeXmlCur = ParseTextNode( ( TextNode )nodeCur );
				}
				else if( nodeCur is RichTextNode )
				{
					nodeXmlCur = ParseRichTextNode( ( RichTextNode )nodeCur );
				}
				else if( type == typeof( Link ) )
				{
					nodeXmlCur = ParseLink( ( Link )nodeCur );
				}
				
				if( nodeXmlCur != null )
				{
					// node name
					XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Name" );
					attr.Value = nodeCur.Name;
				
					nodeXmlCur.Attributes.SetNamedItem( attr );
				
					// node type
					nodesToReturn.AppendChild( nodeXmlCur );
				}
			}
			
			return nodesToReturn;
		}
		private XmlNode ParseSymbolNodes( NodeCollection nodes )
		{
			// parse nodes
			XmlElement nodesToReturn = this.DocIntmdFormat.CreateElement( "Symbol" );
			XmlElement nodesSymbol = this.DocIntmdFormat.CreateElement( "Nodes" );
			XmlNode nodeXmlCur = null;
			
			foreach( INode nodeCur in nodes )
			{
				Type type = nodeCur.GetType();
				
				if( type == typeof( Rectangle ) )
				{
					nodeXmlCur = ParseRectangle( ( Rectangle )nodeCur );
				}
				else if( type == typeof( RoundRect ) )
				{
					nodeXmlCur = ParseRoundRectangle( ( RoundRect )nodeCur );
				}
				else if( type == typeof( Ellipse ) )
				{
					nodeXmlCur = ParseEllipse( ( Ellipse )nodeCur );
				}
				else if( type == typeof( Line ) )
				{
					nodeXmlCur = ParseLine( ( Line )nodeCur );
				}
				else if( type == typeof( Arc ) )
				{
					nodeXmlCur = ParseArc( ( Arc )nodeCur );
				}
				else if( type == typeof( ClosedCurve ) )
				{
					nodeXmlCur = ParseClosedCurve( ( ClosedCurve )nodeCur );
				}
				else if( type == typeof( Curve ) )
				{
					nodeXmlCur = ParseCurve( ( Curve )nodeCur );
				}
				else if( type == typeof( PolyLine ) )
				{
					nodeXmlCur = ParsePolyLine( ( PolyLine )nodeCur );
				}
				else if( type == typeof( Polygon ) )
				{
					nodeXmlCur = ParsePolygon( ( Polygon )nodeCur );
				}
				else if( type == typeof( MetafileNode ) )
				{
					nodeXmlCur = ParseMetafileNode( ( MetafileNode )nodeCur );
				}
				else if( type == typeof( BitmapNode ) )
				{
					nodeXmlCur = ParseBitmapNode( ( BitmapNode )nodeCur );
				}
				else if( type == typeof( Figure ) )
				{
					nodeXmlCur = ParseFigure( ( Figure )nodeCur );
				}
				else if( type == typeof( TextNode ) )
				{
					nodeXmlCur = ParseTextNode( ( TextNode )nodeCur );
				}
				else if( type == typeof( RichTextNode ) )
				{
					nodeXmlCur = ParseRichTextNode( ( RichTextNode )nodeCur );
				}
				else if( type == typeof( Link ) )
				{
					nodeXmlCur = ParseLink( ( Link )nodeCur );
				}
				else if( type == typeof( Symbol ) )
				{
					nodeXmlCur = ParseSymbol( ( Symbol )nodeCur );
				}
								
				if( nodeXmlCur != null )
				{
					// node name
					XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Name" );
					attr.Value = nodeCur.Name;
				
					nodeXmlCur.Attributes.SetNamedItem( attr );
				
					// node type
					nodesSymbol.AppendChild( nodeXmlCur );
				}
			}
			
			nodesToReturn.AppendChild( nodesSymbol );
			return nodesToReturn;
		}
		private XmlNode ParsePaletteNodes( NodeCollection nodes )
		{
			// parse nodes
			XmlElement nodesToReturn = this.DocIntmdFormat.CreateElement( "Nodes" );
			XmlNode nodeXmlCur = null;
			
			foreach( SymbolModel symbolModel in nodes )
			{
				// Update helper parent's matrix
				this.ParentTransforms.Reset();
				this.ParentTransforms.Multiply( symbolModel.LocalTransform );

				this.SymbolParsing = true;
				
				NodeCollection nodesSymbol = MakeZOrderSort( ( NodeCollection ) symbolModel.Nodes );
				nodeXmlCur = ParseSymbolNodes( nodesSymbol );

				// parse labels
				if( symbolModel.Labels != null && symbolModel.Labels.Count > 0 ) 
				{
					XmlNode labelsXml = ParseLabels( symbolModel.Labels );
					nodeXmlCur.AppendChild( labelsXml );
				}

				this.SymbolParsing = false;

				this.ParentTransforms.Reset();
				
				if( nodeXmlCur != null )
				{
					// node name
					XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Name" );
					attr.Value = symbolModel.Name;
				
					nodeXmlCur.Attributes.SetNamedItem( attr );
				
					// node type
					nodesToReturn.AppendChild( nodeXmlCur );
				}
			}
			
			return nodesToReturn;
		}
		private NodeCollection MakeZOrderSort( NodeCollection nodes )
		{
			NodeCollection nodesZOrderSorted = new NodeCollection();
			ArrayList arrList = new ArrayList();
			arrList.AddRange( nodes );
			arrList.Sort( new ZOrderComparer() );
				
			foreach( INode node in arrList )
			{
				nodesZOrderSorted.Add( node );
			}
			
			return nodesZOrderSorted;
		}
		public void ParsePalette()
		{
			if( m_paletteTemp == null )
				throw new ArgumentNullException( "palette" );

			this.DocIntmdFormat.RemoveAll();
			// Root element
			XmlNode nodeRoot = this.DocIntmdFormat.CreateElement( "Palette" );
			this.DocIntmdFormat.AppendChild( nodeRoot );
			// Palette Name
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Name" );
			nodeTemp.Value = m_paletteTemp.Name;
			nodeRoot.Attributes.SetNamedItem( nodeTemp );

			// parse palette nodes
			m_bPaletteParsing = true;
			// parse model nodes
			XmlNode nodes = ParsePaletteNodes( ( NodeCollection )m_paletteTemp.Nodes );
			m_bPaletteParsing = false;
			nodeRoot.AppendChild( nodes );
		}
		/// <summary>
		/// Saves XML document containting intermediate format into file specified.
		/// </summary>
		public void Save( string strFilePath )
		{
			XmlTextWriter writer = new XmlTextWriter( strFilePath, Encoding.Unicode );
			writer.Formatting = Formatting.Indented;
			this.DocIntmdFormat.Save( writer );
		}
		#endregion
		
		#region Class helper methods
		
		#region Parsing
		private XmlNode ParseModel( Model model )
		{
			if( model == null )
				throw new ArgumentNullException( "model" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Model" );
			XmlNode xmlNodeTemp;
			
			// parse bounds
			ParseBounds( nodeToReturn, model );
			// BoundaryConstraintsEnabled
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "BoundaryConstraintsEnabled" );
			// regardless of set value - it is always true --> set false
			xmlNodeTemp.InnerText = "false";
			nodeToReturn.AppendChild( xmlNodeTemp );
			// LineBridgeSize
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "LineBridgeSize" );
			xmlNodeTemp.InnerText = model.LineBridgeSize.ToString();
			nodeToReturn.AppendChild( xmlNodeTemp );
			// LineBridgingEnabled
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "LineBridgingEnabled" );
			xmlNodeTemp.InnerText = model.LineBridgingEnabled.ToString();
			nodeToReturn.AppendChild( xmlNodeTemp );
			// LineRoutingEnabled
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "LineRoutingEnabled" );
			xmlNodeTemp.InnerText = model.LineRoutingEnabled.ToString();
			nodeToReturn.AppendChild( xmlNodeTemp );
			// MeasurementUnits
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "MeasurementUnits" );
			xmlNodeTemp.InnerText = model.MeasurementUnits.ToString();
			nodeToReturn.AppendChild( xmlNodeTemp );
			// Name
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "Name" );
			xmlNodeTemp.InnerText = model.Name.ToString();
			nodeToReturn.AppendChild( xmlNodeTemp );
			// SizeToContent
			xmlNodeTemp = this.DocIntmdFormat.CreateElement( "SizeToContent" );
			xmlNodeTemp.InnerText = model.SizeToContent.ToString();
			nodeToReturn.AppendChild( xmlNodeTemp );
			// MinimumSize
			xmlNodeTemp = ParseSize( "MinimumSize", model.MinimumSize );
			nodeToReturn.AppendChild( xmlNodeTemp );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses RichTextNode into appropriate XmlNode.
		/// </summary>
		/// <param name="nodeRTF"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="nodeRTF"></param>
		/// <returns></returns>
		private XmlNode ParseRichTextNode( RichTextNode nodeRTF )
		{
			if( nodeRTF == null )
				throw new ArgumentNullException( "nodeRTF" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "RTFTextNode" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, nodeRTF );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = nodeRTF.Visible.ToString();
			nodeToReturn.Attributes.SetNamedItem( nodeTemp );
			
			// parse bounds
			ParseBounds( nodeToReturn, nodeRTF );
			ParseRTFNodeProperties( nodeRTF, nodeToReturn );

			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( nodeRTF.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Border style
			nodeTemp = ParseBorderStyle( nodeRTF.BorderStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		private void ParseRTFNodeProperties( RichTextNode nodeRTF, XmlElement nodeToReturn )
		{
			XmlNode nodeTemp;
			// RTF
			nodeTemp = this.DocIntmdFormat.CreateElement( "RTF" );
			nodeTemp.InnerText = nodeRTF.RichText;
			nodeToReturn.AppendChild( nodeTemp );
			// ReadOnly
			nodeTemp = this.DocIntmdFormat.CreateElement( "ReadOnly" );
			nodeTemp.InnerText = nodeRTF.ReadOnly.ToString();
			nodeToReturn.AppendChild( nodeTemp );
		}
		/// <summary>
		/// Parses nodeText into appropriate XmlNode.
		/// </summary>
		/// <param name="nodeText"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="nodeText"></param>
		/// <returns></returns>
		private XmlNode ParseTextNode( TextNode nodeText )
		{
			if( nodeText == null )
				throw new ArgumentNullException( "nodeText" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "TextNode" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, nodeText );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = nodeText.Visible.ToString();
			nodeToReturn.Attributes.SetNamedItem( nodeTemp );
			
			// parse bounds
			ParseBounds( nodeToReturn, nodeText );
			ParseTextNodeProperties( nodeText, nodeToReturn );

			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( nodeText.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Border style
			nodeTemp = ParseBorderStyle( nodeText.BorderStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Fill style
			nodeTemp = ParseFillStyle( nodeText.FillStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Backgrounds style
			nodeTemp = ParseBackgroundStyle( nodeText.BackgroundStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Font style
			nodeTemp = ParseFontStyle( nodeText.FontStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		private void ParseTextNodeProperties( TextNode nodeText, XmlElement nodeToReturn )
		{
			XmlNode nodeTemp;
			// Text
			nodeTemp = this.DocIntmdFormat.CreateElement( "Text" );
			nodeTemp.InnerText = nodeText.Text;
			nodeToReturn.AppendChild( nodeTemp );
			// DirectionRightToLeft
			nodeTemp = this.DocIntmdFormat.CreateElement( "DirectionRightToLeft" );
			nodeTemp.InnerText = nodeText.DirectionRightToLeft.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// DirectionVertical
			nodeTemp = this.DocIntmdFormat.CreateElement( "DirectionVertical" );
			nodeTemp.InnerText = nodeText.DirectionVertical.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// FitBlackBox
			nodeTemp = this.DocIntmdFormat.CreateElement( "FitBlackBox" );
			nodeTemp.InnerText = nodeText.FitBlackBox.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// HorizontalAlignment
			nodeTemp = this.DocIntmdFormat.CreateElement( "HorizontalAlignment" );
			nodeTemp.InnerText = nodeText.HorizontalAlignment.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// LineLimit
			nodeTemp = this.DocIntmdFormat.CreateElement( "LineLimit" );
			nodeTemp.InnerText = nodeText.LineLimit.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// MeasureTrailingSpaces
			nodeTemp = this.DocIntmdFormat.CreateElement( "MeasureTrailingSpaces" );
			nodeTemp.InnerText = nodeText.MeasureTrailingSpaces.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// NoClip
			nodeTemp = this.DocIntmdFormat.CreateElement( "NoClip" );
			nodeTemp.InnerText = nodeText.NoClip.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// ReadOnly
			nodeTemp = this.DocIntmdFormat.CreateElement( "ReadOnly" );
			nodeTemp.InnerText = nodeText.ReadOnly.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// VerticalAlignment
			nodeTemp = this.DocIntmdFormat.CreateElement( "VerticalAlignment" );
			nodeTemp.InnerText = nodeText.VerticalAlignment.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// WrapText
			nodeTemp = this.DocIntmdFormat.CreateElement( "WrapText" );
			nodeTemp.InnerText = nodeText.WrapText.ToString();
			nodeToReturn.AppendChild( nodeTemp );
		}
		/// <summary>
		/// Parses BitmapNode into appropriate XmlNode.
		/// </summary>
		/// <param name="bitmapNode"></param>
		/// <returns></returns>
		private XmlNode ParseBitmapNode( BitmapNode bitmapNode )
		{
			if( bitmapNode == null )
				throw new ArgumentNullException( "bitmapNode" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "BitmapNode" );

			ParseImageNode( nodeToReturn, bitmapNode );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses MetafileNode into appropriate XmlNode.
		/// </summary>
		/// <param name="metafileNode"></param>
		/// <returns></returns>
		private XmlNode ParseMetafileNode( MetafileNode metafileNode )
		{
			if( metafileNode == null )
				throw new ArgumentNullException( "metafileNode" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "MetafileNode" );

			ParseImageNode( nodeToReturn, metafileNode );
			
			return nodeToReturn;
		}
		private void ParseImageNode( XmlNode nodeXmlImage, ImageNode nodeImage )
		{
			// parse attributes
			// name
			ParseName( nodeXmlImage, nodeImage );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = nodeImage.Visible.ToString();

			nodeXmlImage.Attributes.SetNamedItem( nodeTemp );

			// parse bounds
			ParseBounds( nodeXmlImage, nodeImage );
			// parse image
			if( nodeImage.Image != null )
			{
				nodeTemp = this.DocIntmdFormat.CreateElement( "Image" );
				byte[] byteArray = ImageToByteArray( nodeImage.Image );
				nodeTemp.InnerText = Convert.ToBase64String( byteArray );
				nodeXmlImage.AppendChild( nodeTemp );
			}

			nodeXmlImage.AppendChild( nodeTemp );
		}
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="line"></param>
		/// <returns></returns>
		private XmlNode ParseLine( Line line )
		{
			if( line == null )
				throw new ArgumentNullException( "line" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Line" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, line );
			// visible
			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
			attr.Value = line.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( attr );
			
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			// path points
			XmlNode nodeTemp = ParsePath( line.GraphicsPath, line );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );
			
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( line.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseLineStyle( line.LineStyle );
			nodeStyles.AppendChild( nodeTemp );

			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses link node into appropriate XmlNode.
		/// </summary>
		/// <param name="link"></param>
		/// <returns></returns>
		private XmlNode ParseLink( Link link )
		{
			if( link == null )
				throw new ArgumentNullException( "link" );
		
			XmlElement nodeToReturn = null;
			
			NodeCollection nodes = FilterPorts( link.Nodes );
			
			// if link has one child node and it's line -- make connector
			if( nodes.Count == 1 && ( ( IGraphics )nodes[ 0 ] ).GraphicsPath.PathPoints.Length == 2 )
			{
				nodeToReturn = this.DocIntmdFormat.CreateElement( "LineConnector" );
			
				// parse attributes
				// name
				ParseName( nodeToReturn, link );
				// visible
				XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
				attr.Value = link.Visible.ToString();
			
				nodeToReturn.Attributes.SetNamedItem( attr );
			
				XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
				// path points
				XmlNode nodeTemp = ParsePath( ( ( IGraphics ) nodes[ 0 ] ).GraphicsPath, nodes[ 0 ] );
				nodePath.AppendChild( nodeTemp );
				nodeToReturn.AppendChild( nodePath );
			
				// parse styles
				XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
				// Edit Styles
				nodeTemp = ParseEditStyle( link.EditStyle );
				nodeStyles.AppendChild( nodeTemp );

				// Line Styles
				nodeTemp = ParseLineStyle( ( ( Shape ) link.Nodes[ 0 ] ).LineStyle );
				nodeStyles.AppendChild( nodeTemp );

				nodeToReturn.AppendChild( nodeStyles );
			}
			else if( nodes.Count == 1 && IsOrthogonal( ( ( IGraphics )nodes[ 0 ] ).GraphicsPath ) )
			{
				nodeToReturn = this.DocIntmdFormat.CreateElement( "OrthogonalConnector" );
			
				// parse attributes
				// name
				ParseName( nodeToReturn, link );
				// visible
				XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
				attr.Value = link.Visible.ToString();
			
				nodeToReturn.Attributes.SetNamedItem( attr );
			
				XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
				// path points
//				XmlNode nodeTemp = ParsePath( ( ( IGraphics ) nodes[ 0 ] ).GraphicsPath, nodes[ 0 ] );
				XmlNode nodeTemp = ParsePath( link.GraphicsPath, link );
				nodePath.AppendChild( nodeTemp );
				nodeToReturn.AppendChild( nodePath );

				// parse styles
				XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
				// Edit Styles
				nodeTemp = ParseEditStyle( link.EditStyle );
				nodeStyles.AppendChild( nodeTemp );

				// Line Styles
				nodeTemp = ParseLineStyle( ( ( Shape ) link.Nodes[ 0 ] ).LineStyle );
				nodeStyles.AppendChild( nodeTemp );

				nodeToReturn.AppendChild( nodeStyles );
			}
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses figure node into appropriate XmlNode.
		/// </summary>
		/// <param name="figure"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="figure"></param>
		/// <returns></returns>
		private XmlNode ParseFigure( Figure figure )
		{
			if( figure == null )
				throw new ArgumentNullException( "figure" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Figure" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, figure );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = figure.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( nodeTemp );
			GraphicsPath path = null;
			
			try
			{
				path = figure.GraphicsPath;
			}
			catch(Exception)
			{}
			if( path == null )
			{
				path = GetPath( figure );
			}

			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			nodeTemp = ParsePath( path, figure );
			nodePath.AppendChild( nodeTemp );
			
			nodeTemp = this.DocIntmdFormat.CreateElement( "PathTypes" );
			
			nodeTemp.InnerText = Convert.ToBase64String( path.PathTypes );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath 	);
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( figure.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseLineStyle( figure.LineStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Fill style
			nodeTemp = ParseFillStyle( figure.FillStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses figure node into appropriate XmlNode.
		/// </summary>
		/// <param name="curve"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="curve"></param>
		/// <returns></returns>
		private XmlNode ParseCurve( Curve curve )
		{
			if( curve == null )
				throw new ArgumentNullException( "curve" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Curve" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, curve );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = curve.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( nodeTemp );
			
			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			nodeTemp = ParsePath( curve.GraphicsPath, curve );
			nodePath.AppendChild( nodeTemp );
			
			nodeTemp = this.DocIntmdFormat.CreateElement( "PathTypes" );
			nodeTemp.InnerText = Convert.ToBase64String( curve.GraphicsPath.PathTypes );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );
			
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( curve.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseLineStyle( curve.LineStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses figure node into appropriate XmlNode.
		/// </summary>
		/// <param name="curveClosed"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="curveClosed"></param>
		/// <returns></returns>
		private XmlNode ParseClosedCurve( ClosedCurve curveClosed )
		{
			if( curveClosed == null )
				throw new ArgumentNullException( "curveClosed" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "ClosedCurve" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, curveClosed );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = curveClosed.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( nodeTemp );

			// parse bounds
			GraphicsPath path = curveClosed.GraphicsPath;
			
			if ( path == null )
			{
				path = GetPath( curveClosed );

				if ( path == null )
				{
					throw new ArgumentNullException( "path" );
				}
			}

			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			nodeTemp = ParsePath( path, curveClosed );
			nodePath.AppendChild( nodeTemp );

			nodeTemp = this.DocIntmdFormat.CreateElement( "PathTypes" );
			nodeTemp.InnerText = Convert.ToBase64String( path.PathTypes );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );

			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( curveClosed.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Border style
			nodeTemp = ParseBorderStyle( curveClosed.BorderStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Fill style
			nodeTemp = ParseFillStyle( curveClosed.FillStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Shadow style
			nodeTemp = ParseShadowStyle( curveClosed.ShadowStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses figure node into appropriate XmlNode.
		/// </summary>
		/// <param name="arc"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="arc"></param>
		/// <returns></returns>
		private XmlNode ParseArc( Arc arc )
		{
			if( arc == null )
				throw new ArgumentNullException( "arc" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Bezier" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, arc );
			// visible
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "Visible" );
			nodeTemp.Value = arc.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( nodeTemp );
			
			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			nodeTemp = ParsePath( arc.GraphicsPath, arc );
			nodePath.AppendChild( nodeTemp );
			
			nodeTemp = this.DocIntmdFormat.CreateElement( "PathTypes" );
			GraphicsPath path = arc.GraphicsPath;
			
			if( path == null )
			{
				path = GetPath( arc );
			}
			
			nodeTemp.InnerText = Convert.ToBase64String( path.PathTypes );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );
			
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( arc.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseLineStyle( arc.LineStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="polygon"></param>
		/// <returns></returns>
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="polygon"></param>
		/// <returns></returns>
		private XmlNode ParsePolygon( Polygon polygon )
		{
			if( polygon == null )
				throw new ArgumentNullException( "polyline" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Polygon" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, polygon );
			// visible
			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
			attr.Value = polygon.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( attr );
			
			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			
			// path points
			XmlNode nodeTemp = ParsePath( polygon.GraphicsPath, polygon );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );
			
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( polygon.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseBorderStyle( polygon.BorderStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Fill style
			nodeTemp = ParseFillStyle( polygon.FillStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Shadow style
			nodeTemp = ParseShadowStyle( polygon.ShadowStyle );
			nodeStyles.AppendChild( nodeTemp );
			
			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		private XmlNode ParsePolyLine( PolyLine polyline )
		{
			if( polyline == null )
				throw new ArgumentNullException( "polyline" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Polyline" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, polyline );
			// visible
			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
			attr.Value = polyline.Visible.ToString();
			nodeToReturn.Attributes.SetNamedItem( attr );
			
			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			// path points
			XmlNode nodeTemp = ParsePath( polyline.GraphicsPath, polyline );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );
			
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			nodeTemp = ParseEditStyle( polyline.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseLineStyle( polyline.LineStyle );
			nodeStyles.AppendChild( nodeTemp );

			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="rectangle"></param>
		/// <returns></returns>
		private XmlNode ParseRectangle( Rectangle rectangle )
		{
			if( rectangle == null )
				throw new ArgumentNullException( "rectangle" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Rectangle" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, rectangle );
			// visible
			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
			attr.Value = rectangle.Visible.ToString();
			// append attribute
			nodeToReturn.Attributes.SetNamedItem( attr );
			// parse 
			GraphicsPath path = rectangle.GraphicsPath;
			if( path == null )
			{
				path = GetPath( rectangle );
				
				if( path == null )
				{
					throw new ArgumentNullException( "path" );
				}
			}

			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			// path points
			XmlNode nodeTemp = ParsePath( rectangle.GraphicsPath, rectangle );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );

//			ParseRectBounds( nodeToReturn, path, rectangle.LocalTransform );
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// edit Styles
			nodeTemp = ParseEditStyle( rectangle.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// lLine style
			nodeTemp = ParseBorderStyle( rectangle.BorderStyle );
			nodeStyles.AppendChild( nodeTemp );
			// fill style
			nodeTemp = ParseFillStyle( rectangle.FillStyle );
			nodeStyles.AppendChild( nodeTemp );
			// shadow style
			nodeTemp = ParseShadowStyle( rectangle.ShadowStyle );
			nodeStyles.AppendChild( nodeTemp );

			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses rectangle node into appropriate XmlNode.
		/// </summary>
		/// <param name="rectangle"></param>
		/// <returns></returns>
		private XmlNode ParseRoundRectangle( RoundRect rectangle )
		{
			if( rectangle == null )
				throw new ArgumentNullException( "roundRectangle" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "RoundRectangle" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, rectangle );
			// visible
			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
			attr.Value = rectangle.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( attr );
			
			// parse bounds
			GraphicsPath path = rectangle.GraphicsPath;
			if( path == null )
			{
				path = GetPath( rectangle );
				
				if( path == null )
				{
					throw new ArgumentNullException( "path" );
				}
			}

			ParseRoundRectBounds( nodeToReturn, path, rectangle.LocalTransform );
			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			XmlNode nodeTemp = ParseEditStyle( rectangle.EditStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Line style
			nodeTemp = ParseBorderStyle( rectangle.BorderStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Fill style
			nodeTemp = ParseFillStyle( rectangle.FillStyle );
			nodeStyles.AppendChild( nodeTemp );
			// Shadow style
			nodeTemp = ParseShadowStyle( rectangle.ShadowStyle );
			nodeStyles.AppendChild( nodeTemp );

			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		/// <summary>
		/// Parses RoundRectangle node location, size and rotation angle.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		private void ParseRoundRectBounds( XmlNode nodeXml, GraphicsPath path, Matrix mtxTransform )
		{
			// get bounding rect without transforms
			PointF[] pts = path.PathPoints;
			
			Matrix matrix = mtxTransform.Clone();
			matrix.Multiply( this.ParentTransforms );
			//			matrix.Invert();
			matrix.TransformPoints( pts );
			
			//			this.ParentTransforms.TransformPoints( pts );

			RectangleF rect = Geometry.CreateRect( pts );

			// calc Size
			SizeF szSize = rect.Size;
			
			if( this.SymbolParsing )
			{
				if( !this.PaletteParsing )
				{
					szSize.Width = ( float )Geometry.PointDistance( path.PathPoints[ 0 ]
						, path.PathPoints[ 7 ] );
			
					szSize.Height = ( float )Geometry.PointDistance( path.PathPoints[ 2 ]
						, path.PathPoints[ 16 ] );
				}
				else
				{
					szSize.Width = ( float )Geometry.PointDistance( pts[ 0 ]
						, pts[ 7 ] );
			
					szSize.Height = ( float )Geometry.PointDistance( pts[ 2 ]
						, pts[ 16 ] );
				}
			}
			// calc center point
			Point ptCenter = new Point( ( int ) ( rect.X + szSize.Width / 2 ), ( int ) ( rect.Y + szSize.Height / 2 ) );
			// get first point - without rotation
			Point pt1 = new Point( ( int ) pts[ 0 ].X, ( int ) pts[ 0 ].Y );

			// create bounding rect of transformed points
			RectangleF rectPath;
			pts = ( PointF[] ) path.PathPoints.Clone();
			
			if( this.SymbolParsing )
			{

				if( this.PaletteParsing )
				{
					matrix.TransformPoints( pts );					
				}
				else
				{
					this.ParentTransforms.TransformPoints( pts );
				}
			}

			rectPath = Geometry.CreateRect( pts );

			// get transformed rect center
			PointF ptCenterPath =
				new Point( ( int ) ( rectPath.X + rectPath.Width / 2 ), ( int ) ( rectPath.Y + rectPath.Height / 2 ) );
			// calc transformed point
			Point pt2 = Point.Empty;
			
			pt2.X = ( int ) ( pts[ 0 ].X - ( ptCenterPath.X - ptCenter.X ) );
			pt2.Y = ( int ) ( pts[ 0 ].Y - ( ptCenterPath.Y - ptCenter.Y ) );
			
			// calc rotation angle
			float fAngle = 0;//( float ) ( Geometry.LineAngle( pt1, ptCenter, pt2 ) * ( 180f / Math.PI ) );
			
			// Rotation angle
			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "RotationAngle" );
			attr.Value = fAngle.ToString();
			// Append attribute
			nodeXml.Attributes.SetNamedItem( attr );
			
			// parse bounds
			XmlNode nodeBounds = this.DocIntmdFormat.CreateElement( "Bounds" );
			// Location
			//			PointF[] ptLocation =
			//				new PointF[] { new PointF( ptCenterPath.X - szSize.Width / 2, ptCenterPath.Y - szSize.Height / 2 ) };
			SizeF szOffset = new SizeF( szSize.Width / 2, szSize.Height / 2 );
			
			if( this.SymbolParsing )
			{
				//				szOffset = SizeF.Empty;
			}

			PointF ptLocation = new PointF( ptCenterPath.X - szOffset.Width, ptCenterPath.Y - szOffset.Height );

			//		this.ParentTransforms.TransformPoints( ptLocation );
			XmlNode nodeTemp = ParsePoint( "Location", ptLocation );
			nodeBounds.AppendChild( nodeTemp );
			// Size
			nodeTemp = ParseSize( "Size", szSize );
			nodeBounds.AppendChild( nodeTemp );
			
			nodeXml.AppendChild( nodeBounds );
			
//			// get bounding rect without transforms
//			PointF[] pts = path.PathPoints;
//			
//			Matrix matrix = mtxTransform.Clone();
//			matrix.Multiply( this.ParentTransforms );
//			//			matrix.Invert();
//			matrix.TransformPoints( pts );
////			Matrix matrix = mtxTransform.Clone();
////			matrix.Invert();
////			matrix.TransformPoints( pts );
//
//			RectangleF rect = Geometry.CreateRect( pts );
//
//			// calc Size
//			SizeF szSize = SizeF.Empty;
//			
//			if( this.SymbolParsing )
//			{
//				if( !this.PaletteParsing )
//				{
//					szSize.Width = ( float )Geometry.PointDistance( path.PathPoints[ 0 ]
//						, path.PathPoints[ 1 ] );
//			
//					szSize.Height = ( float )Geometry.PointDistance( path.PathPoints[ 3 ]
//						, path.PathPoints[ 0 ] );
//				}
//				else
//				{
//					szSize.Width = ( float )Geometry.PointDistance( pts[ 0 ]
//						, pts[ 1 ] );
//			
//					szSize.Height = ( float )Geometry.PointDistance( pts[ 3 ]
//						, pts[ 0 ] );
//				}
//			}
//			
//			// get transformed rect center
//			PointF ptCenterPath =
//				new Point( ( int ) ( rectPath.X + rectPath.Width / 2 ), ( int ) ( rectPath.Y + rectPath.Height / 2 ) );
//			// calc transformed point
//			Point pt2 = Point.Empty;
//			
//			pt2.X = ( int ) ( pts[ 0 ].X - ( ptCenterPath.X - ptCenter.X ) );
//			pt2.Y = ( int ) ( pts[ 0 ].Y - ( ptCenterPath.Y - ptCenter.Y ) );
//			
//			// calc rotation angle
//			float fAngle = ( float ) ( Geometry.LineAngle( pt1, ptCenter, pt2 ) * ( 180f / Math.PI ) );
//
////			// calc center point
////			Point ptCenter = new Point( ( int ) ( rect.X + szSize.Width / 2 ), ( int ) ( rect.Y + szSize.Height / 2 ) );
////			// get first point - without rotation
////			Point pt1 = new Point( ( int ) pts[ 0 ].X, ( int ) pts[ 0 ].Y );
//
//			// create bounding rect of transformed points
//			RectangleF rectPath;
//			pts = ( PointF[] ) path.PathPoints.Clone();
//			SizeF szOffset = new SizeF( szSize.Width / 2, szSize.Height / 2 );
//			PointF ptLocation = new PointF( ptCenter.X - szOffset.Width, ptCenter.Y - szOffset.Height );
//
////			if( this.SymbolParsing )
////			{
////				this.ParentTransforms.TransformPoints( pts );
////				rectPath = Geometry.CreateRect( pts );
////			}
////			else
////			{
////				rectPath = Geometry.CreateRect( pts );
////			}
//			
//			// get transformed rect center
////			PointF ptCenterPath =
////				new Point( ( int ) ( rectPath.X + rectPath.Width / 2 ), ( int ) ( rectPath.Y + rectPath.Height / 2 ) );
////			// calc transformed point
////			Point pt2 = Point.Empty;
////			pt2.X = ( int ) ( pts[ 0 ].X - ( ptCenterPath.X - ptCenter.X ) );
////			pt2.Y = ( int ) ( pts[ 0 ].Y - ( ptCenterPath.Y - ptCenter.Y ) );
//			// calc rotation angle
//			float fAngle = ( float ) ( Geometry.LineAngle( pt1, ptCenter, pt2 ) * ( 180f / Math.PI ) );
//			
//			// Rotation angle
//			XmlNode attr = this.DocIntmdFormat.CreateAttribute( "RotationAngle" );
//			attr.Value = fAngle.ToString();
//			// Append attribute
//			nodeXml.Attributes.SetNamedItem( attr );
//			
//			// parse bounds
//			XmlNode nodeBounds = this.DocIntmdFormat.CreateElement( "Bounds" );
//			// Location
//			PointF ptLocation = new PointF( ptCenterPath.X - szSize.Width / 2, ptCenterPath.Y - szSize.Height / 2 );
//			XmlNode nodeTemp = ParsePoint( "Location", ptLocation );
//			nodeBounds.AppendChild( nodeTemp );
//			// Size
//			nodeTemp = ParseSize( "Size", szSize );
//			nodeBounds.AppendChild( nodeTemp );
//			
//			nodeXml.AppendChild( nodeBounds );
		}
		/// <summary>
		/// Parses ellipse node into appropriate XmlNode.
		/// </summary>
		/// <param name="ellipse"></param>
		/// <returns></returns>
		private XmlNode ParseEllipse( Ellipse ellipse )
		{
			if( ellipse == null )
				throw new ArgumentNullException( "ellipse" );
			
			XmlElement nodeToReturn = this.DocIntmdFormat.CreateElement( "Ellipse" );
			
			// parse attributes
			// name
			ParseName( nodeToReturn, ellipse );
			// visible
			XmlAttribute attr = this.DocIntmdFormat.CreateAttribute( "Visible" );
			attr.Value = ellipse.Visible.ToString();
			
			nodeToReturn.Attributes.SetNamedItem( attr );
			
			// MaxPoints
			XmlNode nodeTemp = this.DocIntmdFormat.CreateElement( "MaxPoints" );
			nodeTemp.InnerText = ellipse.MaxPoints.ToString();
			nodeToReturn.AppendChild( nodeTemp );
			// MinPoints
			nodeTemp = this.DocIntmdFormat.CreateElement( "MinPoints" );
			nodeTemp.InnerText = ellipse.MinPoints.ToString();
			nodeToReturn.AppendChild( nodeTemp );

			// parse bounds
			GraphicsPath path = ellipse.GraphicsPath;
			if( path == null )
			{
				path = GetPath( ellipse );
				
				if( path == null )
				{
					throw new ArgumentNullException( "path" );
				}
			}

			// GraphicsPath
			XmlNode nodePath = this.DocIntmdFormat.CreateElement( "Path" );
			// path points
			nodeTemp = ParsePath( path, ellipse );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );

			nodeTemp = this.DocIntmdFormat.CreateElement( "PathTypes" );
			nodeTemp.InnerText = Convert.ToBase64String( path.PathTypes );
			nodePath.AppendChild( nodeTemp );
			nodeToReturn.AppendChild( nodePath );

			// parse styles
			XmlElement nodeStyles = this.DocIntmdFormat.CreateElement( "Styles" );
			// Edit Styles
			XmlNode nodeStyle = ParseEditStyle( ellipse.EditStyle );
			nodeStyles.AppendChild( nodeStyle );
			// Line style
			nodeStyle = ParseBorderStyle( ellipse.BorderStyle );
			nodeStyles.AppendChild( nodeStyle );
			// Fill style
			nodeStyle = ParseFillStyle( ellipse.FillStyle );
			nodeStyles.AppendChild( nodeStyle );
			// Shadow style
			nodeStyle = ParseShadowStyle( ellipse.ShadowStyle );
			nodeStyles.AppendChild( nodeStyle );

			nodeToReturn.AppendChild( nodeStyles );
			
			return nodeToReturn;
		}
		private XmlNode ParseSymbol( ICompositeNode nodeComposite )
		{
			if( nodeComposite == null )
			{
				throw new ArgumentNullException( "symbol" );
			}

			bool bSymbolParsing = this.SymbolParsing;
			this.SymbolParsing = true;

			// Symbol element
			XmlNode nodeSymbol = this.DocIntmdFormat.CreateElement( "Group" );
			Symbol symbol = nodeComposite as Symbol;

			// Update helper parent's matrix
			if ( symbol != null )
			{
				ParseBoundsInfo( nodeSymbol, nodeComposite as IBounds2DF );
			}
			else
			{
				UpdateMatrix( nodeComposite );
			}

			NodeCollection nodes1 = GetCompositeNodeChildren( nodeComposite );

			// Filter ports
			NodeCollection nodes = FilterPorts( nodes1 );
			// parse model nodes
			NodeCollection nodesSymbol = MakeZOrderSort( nodes );
			
			XmlNode nodeTemp = ParseNodes( nodesSymbol );
			nodeSymbol.AppendChild( nodeTemp );

			ParsePorts( nodeComposite, nodeSymbol );

			ILabelContainer labelContainer = nodeComposite as ILabelContainer;
			
			if( labelContainer != null )
			{
				LabelCollection labels = labelContainer.Labels;
				
				nodeTemp = ParseLabels( labels );
				nodeSymbol.AppendChild( nodeTemp );
				
			}

			this.SymbolParsing = bSymbolParsing;

			// reset parent transform
			if( !bSymbolParsing )
				this.ParentTransforms.Reset();

			return nodeSymbol;
		}
		private XmlNode ParseLabels( LabelCollection labels )
		{
			if( labels == null )
			{
				throw new ArgumentNullException( "labels" );
			}
				
			XmlNode nodeToReturn = this.DocIntmdFormat.CreateElement( "Labels" );
			XmlNode nodeTemp;
				
			foreach( Label label in labels )
			{
				nodeTemp = ParseLabel( label );
				
				if( nodeTemp != null )
				{
					nodeToReturn.AppendChild( nodeTemp );
				}
			}
			
			return nodeToReturn;
		}
		private XmlNode ParseLabel( Label label )
		{
			if( label == null )
				throw new ArgumentNullException( "label" );
			
			if( !label.Visible ) return null;
			
			// Ports element
			XmlNode nodeToReturn = this.DocIntmdFormat.CreateElement( "Label" );
			PointF ptLabelPosition = PointF.Empty;
			ptLabelPosition.X = label.OffsetX ;
			ptLabelPosition.Y = label.OffsetY;
			
			// add text
			XmlNode nodeTemp = this.DocIntmdFormat.CreateElement( "Text" );
			nodeTemp.InnerText = label.Text;
			nodeToReturn.AppendChild( nodeTemp );
			// add position
			nodeTemp = ParsePoint( "Position", ptLabelPosition );
			nodeToReturn.AppendChild( nodeTemp );
			// add font style
			nodeTemp = ParseFontStyle( label.FontStyle );
			nodeToReturn.AppendChild( nodeTemp );
			
			return nodeToReturn;
		}
		private void ParsePorts( ICompositeNode nodeComposite, XmlNode nodeSymbol )
		{
			XmlNode nodesXml;
			// get ports
			IPortContainer portContainer = nodeComposite as IPortContainer;
			
			if( portContainer != null )
			{
				// parse ports
				PortCollection ports = portContainer.Ports;
				nodesXml = ParsePorts( ports );

				// check for center port
				SymbolBase symbolBase = nodeComposite as Symbol;
				
				if( symbolBase != null )
				{
					Port portCenter = symbolBase.CenterPort;
//					bool bCenterPortEnabled = ( symbolBase.CenterPort != null );
					
//					// Enable Center Port Attribute
//					XmlAttribute nodeECPAttr = this.DocIntmdFormat.CreateAttribute( "EnableCenterPort" );
//					nodeECPAttr.Value = bCenterPortEnabled.ToString();
//					nodesXml.Attributes.SetNamedItem( nodeECPAttr );
					
					XmlNode nodeTemp = ParsePort( portCenter, ports.Count, "CenterPort" );
					nodesXml.AppendChild( nodeTemp );
				}

				nodeSymbol.AppendChild( nodesXml );
			}
		}
		private NodeCollection GetCompositeNodeChildren( ICompositeNode nodeComposite )
		{
			NodeCollection nodes1 = new NodeCollection();
			int nChildrenCount = nodeComposite.ChildCount;
			int nCounter = 0;
			
			while( nCounter < nChildrenCount )
			{
				nodes1.Add( nodeComposite.GetChild( nCounter ) );
				nCounter++;
			}
			return nodes1;
		}
		private void UpdateMatrix( ICompositeNode nodeComposite )
		{
			ITransform transform = nodeComposite as ITransform;
			
			if( transform != null )
			{
				this.ParentTransforms.Reset();
				this.ParentTransforms.Multiply( transform.LocalTransform );
			}
		}
		private XmlNode ParsePorts( PortCollection ports )
		{
			if( ports == null )
				throw new ArgumentNullException( "ports" );
			
			// Ports element
			XmlNode nodePorts = this.DocIntmdFormat.CreateElement( "Ports" );
			XmlNode nodeTemp;
			Port port;
			
			for( int i = 0, nLength = ports.Count; i < nLength; i++ )
			{
				port = ports[ i ];
				nodeTemp = ParsePort( port, i, "Port" );
				
				if( nodeTemp != null )
				{
					nodePorts.AppendChild( nodeTemp );
				}
			}
			
			return nodePorts;
		}
		private XmlNode ParsePort( Port port, int nPortID, string strElementName )
		{
			if( port == null )
				throw new ArgumentNullException( "port" );
			
			if( port.Container == null ) return null;
			
			// Ports element
			XmlNode nodePortToReturn = this.DocIntmdFormat.CreateElement( strElementName );
			
			// add port ID
			XmlNode nodeTemp = this.DocIntmdFormat.CreateAttribute( "ID" );
			nodeTemp.Value = nPortID.ToString();
			
			nodePortToReturn.Attributes.SetNamedItem( nodeTemp );
			
//			Matrix mtx = port.LocalTransform;
//			PointF[] pts = new PointF[] { PointF.Empty };
//			mtx.TransformPoints( pts );
//			PointF ptPortPosition = pts[ 0 ];
			
			PointF ptPortPosition = PointF.Empty;
			ptPortPosition.X = port.Location.X - ( ( SymbolBase ) port.Container ).Location.X;
			ptPortPosition.Y = port.Location.Y - ( ( SymbolBase ) port.Container ).Location.Y;
			
			nodeTemp = ParsePoint( "Position", ptPortPosition );
			nodePortToReturn.AppendChild( nodeTemp );
			
			if( port.Container != null )
			{
				if( port.Container.Connections != null )
				{
					ConnectionCollection connections = port.Container.Connections;
				
					if( connections != null && connections.Count > 0 )
					{
						nodeTemp = ParseConnections( connections );
						nodePortToReturn.AppendChild( nodeTemp );
					}
				}
			}
				
			return nodePortToReturn;
		}
		private ConnectionCollection GetPortConections( Port port )
		{
			ConnectionCollection connToReturn = null;
			
			if( port.Container != null )
			{
				connToReturn = port.Container.Connections;
			}
			
			return connToReturn;
		}
		private XmlNode ParseConnections( ConnectionCollection connections )
		{
			if( connections == null )
				throw new ArgumentNullException( "connections" );
			
			XmlNode nodeConnectionsToReturn = this.DocIntmdFormat.CreateElement( "Connections" );
			XmlNode nodeTemp;
			
			foreach( Connection conn in connections )
			{
				nodeTemp = ParseConnection( conn );
				
				if( nodeTemp != null )
					nodeConnectionsToReturn.AppendChild( nodeTemp );
			}
			
			return nodeConnectionsToReturn;
		}
		private XmlNode ParseConnection( Connection connection )
		{
			if( connection == null )
				throw new ArgumentNullException( "connection" );
			
			Port port = connection.TargetPort;
			Link portContainer = port.Container as Link;
			
			if( portContainer == null )
			{
				port = connection.SourcePort;
				portContainer = port.Container as Link;
			}

			XmlNode nodeConnectionToReturn = null;
			
			if( portContainer != null )
			{
				nodeConnectionToReturn = this.DocIntmdFormat.CreateElement( "Connection" );

				// 
				XmlNode nodeTemp = this.DocIntmdFormat.CreateElement( "ConnectorName" );
				nodeTemp.InnerText = portContainer.FullName;
				nodeConnectionToReturn.AppendChild( nodeTemp );

				// define EndPoint type
				nodeTemp = this.DocIntmdFormat.CreateElement( "EndPointType" );

				if( portContainer.HeadPort.Equals( port ) )
				{
					nodeTemp.InnerText = "HeadEndPoint";
					nodeConnectionToReturn.AppendChild( nodeTemp );
				}
				else if( portContainer.TailPort.Equals( port ) )
				{
					nodeTemp.InnerText = "TailEndPoint";
					nodeConnectionToReturn.AppendChild( nodeTemp );
				}
			}
			
			return nodeConnectionToReturn;
		}
		
		#region primitives parsing
		
		#region styles
		
		private XmlNode ParseFontStyle( FontStyle styleFont )
		{
			if( styleFont == null )
				throw new ArgumentNullException( "styleFont" );
			
			XmlNode xmlFillStyleToReturn = this.DocIntmdFormat.CreateElement( "FontStyle" );
			XmlNode xmlStyleTemp;

			// Family
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Family" );
			xmlStyleTemp.InnerText = styleFont.Family;
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// Name
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Name" );
			xmlStyleTemp.InnerText = styleFont.Name;
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// Size
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Size" );
			xmlStyleTemp.InnerText = styleFont.PointSize.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// Unit
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Unit" );
			xmlStyleTemp.InnerText = styleFont.Unit.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Style" );
			xmlStyleTemp.InnerText = styleFont.Style.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			return xmlFillStyleToReturn;
		}
		private XmlNode ParseShadowStyle( ShadowStyle styleShadow )
		{
			if( styleShadow == null )
				throw new ArgumentNullException();
			
			XmlNode xmlEditStyleToReturn = this.DocIntmdFormat.CreateElement( "ShadowStyle" );
			XmlNode xmlStyleTemp;
			
			// AlphaFactor
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "AlphaFactor" );
			xmlStyleTemp.InnerText = styleShadow.AlphaFactor.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Color
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Color" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( styleShadow.Color );
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// OffsetX
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "OffsetX" );
			xmlStyleTemp.InnerText = styleShadow.OffsetX.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// OffsetY
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "OffsetY" );
			xmlStyleTemp.InnerText = styleShadow.OffsetY.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Visible
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Visible" );
			xmlStyleTemp.InnerText = styleShadow.Visible.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			return xmlEditStyleToReturn;
		}
		private XmlNode ParseBorderStyle( BorderStyle styleBorder )
		{
			if( styleBorder == null )
				throw new ArgumentNullException( "styleBorder" );
			
			XmlNode xmlLineStyleToReturn = this.DocIntmdFormat.CreateElement( "LineStyle" );
			XmlNode xmlStyleTemp;

			// Line Color
			Color clr = ( styleBorder.ShowBorder ) ? styleBorder.BorderColor : Color.Transparent;
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "LineColor" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( clr );
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// LineWidth
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "LineWidth" );
			xmlStyleTemp.InnerText = styleBorder.BorderWidth.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// DashStyle
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "DashStyle" );
			xmlStyleTemp.InnerText = styleBorder.DashStyle.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			return xmlLineStyleToReturn;
		}		
		private XmlNode ParseLineStyle( LineStyle styleLine )
		{
			if( styleLine == null )
				throw new ArgumentNullException();
			
			XmlNode xmlLineStyleToReturn = this.DocIntmdFormat.CreateElement( "LineStyle" );
			XmlNode xmlStyleTemp;

			// Line Color
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "LineColor" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( styleLine.LineColor );
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// DashCap
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "DashCap" );
			xmlStyleTemp.InnerText = styleLine.DashCap.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// DashOffset
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "DashOffset" );
			xmlStyleTemp.InnerText = styleLine.DashOffset.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// DashStyle
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "DashStyle" );
			xmlStyleTemp.InnerText = styleLine.DashStyle.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// EndCap
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "EndCap" );
			xmlStyleTemp.InnerText = styleLine.EndCap.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// LineJoin
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "LineJoin" );
			xmlStyleTemp.InnerText = styleLine.LineJoin.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// MiterLimit
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "MiterLimit" );
			xmlStyleTemp.InnerText = styleLine.MiterLimit.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			// LineWidth
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "LineWidth" );
			xmlStyleTemp.InnerText = styleLine.LineWidth.ToString();
			xmlLineStyleToReturn.AppendChild( xmlStyleTemp );

			return xmlLineStyleToReturn;
		}
		private XmlNode ParseBackgroundStyle( BackgroundStyle styleBackground )
		{
			if( styleBackground == null )
				throw new ArgumentNullException( "styleBackground" );
			
			XmlNode xmlBackStyleToReturn = this.DocIntmdFormat.CreateElement( "BackgroundStyle" );
			XmlNode xmlStyleTemp;

			// Color
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Color" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( styleBackground.Color );
			xmlBackStyleToReturn.AppendChild( xmlStyleTemp );

			// ForeColor
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "ForeColor" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( styleBackground.ForeColor );
			xmlBackStyleToReturn.AppendChild( xmlStyleTemp );

			// GradientAngle
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "GradientAngle" );
			xmlStyleTemp.InnerText = styleBackground.GradientAngle.ToString();
			xmlBackStyleToReturn.AppendChild( xmlStyleTemp );

			// Texture
			if( styleBackground.Texture != null )
			{
				xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Texture" );
				byte[] byteArray = ImageToByteArray( styleBackground.Texture );
				xmlStyleTemp.InnerText = Convert.ToBase64String( byteArray );
				xmlBackStyleToReturn.AppendChild( xmlStyleTemp );
			}

			// TextureWrapMode
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "TextureWrapMode" );
			xmlStyleTemp.InnerText = styleBackground.TextureWrapMode.ToString();
			xmlBackStyleToReturn.AppendChild( xmlStyleTemp );

			// Type
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Type" );
			xmlStyleTemp.InnerText = styleBackground.Type.ToString();
			xmlBackStyleToReturn.AppendChild( xmlStyleTemp );

			return xmlBackStyleToReturn;
		}
		private XmlNode ParseFillStyle( FillStyle styleFill )
		{
			if( styleFill == null )
				throw new ArgumentNullException();
			
			XmlNode xmlFillStyleToReturn = this.DocIntmdFormat.CreateElement( "FillStyle" );
			XmlNode xmlStyleTemp;

			// Color
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Color" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( styleFill.Color );
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// ColorAlphaFactor
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "ColorAlphaFactor" );
			xmlStyleTemp.InnerText = ( styleFill.Color == Color.Transparent ) ? "0" : styleFill.ColorAlphaFactor.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// ForeColor
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "ForeColor" );
			xmlStyleTemp.InnerText = ColorTranslator.ToHtml( styleFill.ForeColor );
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// ForeColorAlphaFactor
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "ForeColorAlphaFactor" );
			xmlStyleTemp.InnerText = ( styleFill.ForeColor == Color.Transparent ) ? "0" : styleFill.ForeColorAlphaFactor.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// GradientAngle
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "GradientAngle" );
			xmlStyleTemp.InnerText = styleFill.GradientAngle.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// GradientCenter
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "GradientCenter" );
			xmlStyleTemp.InnerText = styleFill.GradientCenter.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// HatchBrushStyle
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "HatchBrushStyle" );
			xmlStyleTemp.InnerText = styleFill.HatchBrushStyle.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// Texture
			if( styleFill.Texture != null )
			{
				xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Texture" );
				byte[] byteArray = ImageToByteArray( styleFill.Texture );
				xmlStyleTemp.InnerText = Convert.ToBase64String( byteArray );
				xmlFillStyleToReturn.AppendChild( xmlStyleTemp );
			}

			// GradientCenter
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "GradientCenter" );
			xmlStyleTemp.InnerText = styleFill.GradientCenter.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// TextureWrapMode
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "TextureWrapMode" );
			xmlStyleTemp.InnerText = styleFill.TextureWrapMode.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			// Type
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Type" );
			xmlStyleTemp.InnerText = styleFill.Type.ToString();
			xmlFillStyleToReturn.AppendChild( xmlStyleTemp );

			return xmlFillStyleToReturn;
		}
		private XmlNode ParseEditStyle( EditStyle editStyle )
		{
			if( editStyle == null )
				throw new ArgumentNullException();
			
			XmlNode xmlEditStyleToReturn = this.DocIntmdFormat.CreateElement( "EditStyle" );
			XmlNode xmlStyleTemp;
			// Allow select
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "AllowSelect" );
			xmlStyleTemp.InnerText = editStyle.AllowSelect.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );
			
			// Allow Vertex Edit
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "AllowVertexEdit" );
			xmlStyleTemp.InnerText = editStyle.AllowVertexEdit.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Allow Rotate
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "AllowRotate" );
			xmlStyleTemp.InnerText = editStyle.AllowRotate.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Allow Resize
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "AllowResize" );
			xmlStyleTemp.InnerText = editStyle.AllowResize.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Allow Move
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "AllowMove" );
			xmlStyleTemp.InnerText = editStyle.AllowMove.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Enabled
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "Enabled" );
			xmlStyleTemp.InnerText = editStyle.Enabled.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );

			// Handle Edit Mode
			xmlStyleTemp = this.DocIntmdFormat.CreateElement( "HandleEditMode" );
			xmlStyleTemp.InnerText = editStyle.DefaultHandleEditMode.ToString();
			xmlEditStyleToReturn.AppendChild( xmlStyleTemp );
			
			return xmlEditStyleToReturn;
		}
		#endregion
		
		private XmlNode ParsePath( GraphicsPath path, INode node )
		{
			if( node == null )
				throw new ArgumentNullException( "node" );

			if( path == null )
			{
				path = GetPath( node );
				
				if( path == null )
				{
					throw new ArgumentNullException( "path" );
				}
			}
			
			// if we are parsing symbol children append symbol's matrix
			if( this.SymbolParsing )
			{
				if( this.PaletteParsing )
				{
					Matrix matrix = this.ParentTransforms.Clone();
					matrix.Multiply( ( ( ITransform ) node ).LocalTransform, MatrixOrder.Append );
				
					path.Transform( matrix );
				}
				else
				{
					path.Transform( this.ParentTransforms );
				}
			}
			
			// get path points regarding to node they belongs to
			PointF[] pts = GetPoints( path, node );
			
			XmlNode nodeToReturn = this.DocIntmdFormat.CreateElement( "PathPoints" );
			XmlNode nodeTemp;
			
			for( int n = 0, nLength = pts.Length; nLength > n; n++ )
			{
				nodeTemp = ParsePoint( "Point" + n.ToString(), pts[ n ] );
				nodeToReturn.AppendChild( nodeTemp );
			}
			
			return nodeToReturn;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="nodeXml"></param>
		/// <param name="node"></param>
		private void ParseName( XmlNode nodeXml, INode node )
		{
			XmlAttribute attr = this.DocIntmdFormat.CreateAttribute( "Name" );
			attr.Value = node.Name;
			
			nodeXml.Attributes.SetNamedItem( attr );
		}
		/// <summary>
		/// Parses given node bounds info and adds appropriate element to given XmlNode
		/// </summary>
		/// <param name="nodeXml"></param>
		/// <param name="bounds"></param>
		private void ParseBoundsInfo(XmlNode nodeXml, IBounds2DF bounds)
		{
			if ( bounds == null )
				throw new ArgumentNullException( "boundsinfo" );

			// Bounds
			XmlNode nodeBounds = this.DocIntmdFormat.CreateElement( "BoundsInfo" );
			// Location
			PointF[] pts = new PointF[] { Geometry.CenterPoint( bounds.Bounds ) };

			if ( !this.SymbolParsing )
				this.ParentTransforms.TransformPoints( pts );

			// Pin point
			XmlNode nodeTemp = ParsePoint( "Location", pts[0] );
			nodeBounds.AppendChild( nodeTemp );

			// Rotation angle
			Symbol symbol = bounds as Symbol;
			float fAngle = 0;
			SizeF szSize = bounds.Bounds.Size;

			if ( symbol != null )
			{
				fAngle = GetRotationAngle( symbol );
				nodeTemp = ParseRotation( nodeBounds, symbol );

				if ( fAngle != 0 )
				{
					GraphicsPath path = (GraphicsPath)symbol.GraphicsPath.Clone();
					Matrix mtx = new Matrix();
					mtx.Rotate( -(float)fAngle );
					szSize = path.GetBounds( mtx ).Size;
				}
			}

			// Size
			nodeTemp = ParseSize( "Size", szSize );
			nodeBounds.AppendChild( nodeTemp );

			nodeXml.AppendChild( nodeBounds );
		}
		/// <summary>
		/// Parses given node bounds and adds appropriate element to given XmlNode
		/// </summary>
		/// <param name="nodeXml"></param>
		/// <param name="bounds"></param>
		private void ParseBounds( XmlNode nodeXml, IBounds2DF bounds )
		{
			if( bounds == null )
				throw new ArgumentNullException( "bounds" );
			
//			SizeF szSize = this.UnitConverter.ConvertToPixels( bounds.Bounds.Size, this.MeasureUnits );
//			PointF ptPinLocation = this.UnitConverter.ConvertToPixels( bounds.Bounds.Location, this.MeasureUnits );
			
			// Bounds
			XmlNode nodeBounds = this.DocIntmdFormat.CreateElement( "Bounds" );
			// Location
			PointF[] pts = new PointF[] { bounds.Bounds.Location };

			if( !this.SymbolParsing )
				this.ParentTransforms.TransformPoints( pts );
			
			XmlNode nodeTemp = ParsePoint( "Location", pts[ 0 ] );
			nodeBounds.AppendChild( nodeTemp );
			// Size
			nodeTemp = ParseSize( "Size", bounds.Bounds.Size );
			nodeBounds.AppendChild( nodeTemp );
			
			nodeXml.AppendChild( nodeBounds );
		}
		/// <summary>
		/// Parses given point and adds appropriate attribute to given XmlNode
		/// </summary>
		/// <param name="strElementName">elementName</param>
		/// <param name="szParsing">size being parsed</param>
		/// <returns>corrensonding XmlNode</returns>
		private XmlNode ParseSize( string strElementName, SizeF szParsing )
		{
			XmlElement nodeSize = this.DocIntmdFormat.CreateElement( strElementName );

			XmlAttribute attr = this.DocIntmdFormat.CreateAttribute( "Width" );
			attr.Value = szParsing.Width.ToString();
			nodeSize.Attributes.SetNamedItem( attr );

			attr = this.DocIntmdFormat.CreateAttribute( "Height" );
			attr.Value = szParsing.Height.ToString();
			nodeSize.Attributes.SetNamedItem( attr );
			
			return nodeSize;
		}
		/// <summary>
		/// Parses given point and adds appropriate attribute to given XmlNode
		/// </summary>
		/// <param name="strElementName">elementName</param>
		/// <param name="ptParsing">point being parsed</param>
		/// <returns>corrensonding XmlNode</returns>
		private XmlNode ParsePoint( string strElementName, PointF ptParsing )
		{
			XmlElement nodePoint = this.DocIntmdFormat.CreateElement( strElementName );
			
			XmlAttribute attr = this.DocIntmdFormat.CreateAttribute( "X" );
			attr.Value = ptParsing.X.ToString();
			nodePoint.Attributes.SetNamedItem( attr );

			attr = this.DocIntmdFormat.CreateAttribute( "Y" );
			attr.Value = ptParsing.Y.ToString();
			nodePoint.Attributes.SetNamedItem( attr );
			
			return nodePoint;
		}
		/// <summary>
		/// Parses given rotation angle and adds appropriate attribute to given XmlNode
		/// </summary>
		/// <param name="strElementName">elementName</param>
		/// <param name="fAngle">The rotation angle.</param>
		/// <returns>corrensonding XmlNode</returns>
		private XmlNode ParseRotation(XmlNode nodeAngle, Symbol shape)
		{
			float fAngle = GetRotationAngle(shape);
			XmlAttribute attr = this.DocIntmdFormat.CreateAttribute( "RotationAngle" );
			attr.Value = fAngle.ToString();
			nodeAngle.Attributes.SetNamedItem( attr );

			return nodeAngle;
		}
		private float GetRotationAngle(Symbol symbol)
		{
			// parse transform
			PointF[] ptPoint = new PointF[] { new PointF( 1, 0 ) };
			symbol.LocalTransform.TransformPoints( ptPoint );
			return (float)( Geometry.LineAngle( new PointF( symbol.LocalTransform.OffsetX, symbol.LocalTransform.OffsetY ), ptPoint[0] ) * 180f / Math.PI );
		}
		private byte[] ImageToByteArray(Image img)
		{
			byte[] bytesToReturn;
			
			// Save to memory stream
			MemoryStream strmMem = new MemoryStream();
			img.Save( strmMem, img.RawFormat );
			// Read from stream to byte array
			strmMem.Seek( 0, SeekOrigin.Begin );
			// create byte array
			bytesToReturn = new byte[ strmMem.Length ];
			strmMem.Read( bytesToReturn, 0, ( int ) strmMem.Length );
			
			return bytesToReturn;
		}
		private PointF[] GetPoints( GraphicsPath path, INode node )
		{
			if( path == null || path.PathPoints.Length == 0 )
				throw new ArgumentNullException( "path" );

			if( node == null )
				throw new ArgumentNullException( "node" );
			
			PointF[] ptsToReturn = null;
			PointF[] ptsPath = path.PathPoints;
			Type nodeType = node.GetType();
				
			if( nodeType == typeof( Line ) )
			{
				ptsToReturn = new PointF[] { ptsPath[ 0 ], ptsPath[ 1 ] };
			}
			else
			{
				ptsToReturn = ptsPath;
			}
			
			return ptsToReturn;
		}
		private bool IsOrthogonal( GraphicsPath path )
		{
			bool bSuccess = true;
			PointF[] pts = path.PathPoints;

			if( bSuccess )
			{
				for( int i = 0, nLength = pts.Length - 1; i < nLength; i++ )
				{
					if( !CheckPointOnLine( pts[ i ], pts[ i + 1 ] ) )
					{
						bSuccess = false;
						break;
					}
				}
			}			
			return bSuccess;
		}
		protected bool CheckPointOnLine( PointF ptStart, PointF ptEnd )
		{
			Point ptStartPoint = new Point( ( int ) Math.Round( ptStart.X ), ( int ) Math.Round( ptStart.Y ) );
			Point ptEndtPoint = new Point( ( int ) Math.Round( ptEnd.X ), ( int ) Math.Round( ptEnd.Y ) );

			return ( ptStartPoint.X == ptEndtPoint.X ) || ( ptStartPoint.Y == ptEndtPoint.Y ) || ( ptStartPoint == ptEndtPoint );
		}
		private NodeCollection FilterPorts( NodeCollection linkNodes )
		{
			NodeCollection nodesToReturn = new NodeCollection();
			
			foreach( INode node in linkNodes )
			{
				if( !( node is Port ) )
				{
					nodesToReturn.Add( node );
				}
			}
			
			return nodesToReturn;
		}
		private GraphicsPath GetPath( INode node )
		{
			GraphicsPath pathToReturn = null;
			FieldInfo field = null;
			
			if( node is Figure )
			{
				field = node.GetType().GetField( "grfxPath", BindingFlags.NonPublic | BindingFlags.Instance );
				pathToReturn = ( GraphicsPath ) field.GetValue( node );
			}
			else
			{
				field = node.GetType().GetField( "m_grfxPath", BindingFlags.NonPublic | BindingFlags.Instance );
				pathToReturn = ( GraphicsPath ) field.GetValue( node );
			}

			pathToReturn = (GraphicsPath)pathToReturn.Clone();
			Shape shape = node as Shape;

			if ( shape != null )
				pathToReturn.Transform( shape.LocalTransform );

			return pathToReturn;
		}
		#endregion
		
		#endregion
		
		#region Loading
		private SymbolPalette GetPaletteFromStream( Stream iStream )
		{
			SymbolPalette curPalette = null;

			// try load soap
			SoapFormatter formatter = new SoapFormatter();
			formatter.Binder = AppStateSerializer.CustomBinder;
			formatter.AssemblyFormat = FormatterAssemblyStyle.Simple;

			try
			{
				curPalette = (SymbolPalette)formatter.Deserialize( iStream );
			}
			catch
			{
				// reset stream position
				iStream.Position = 0;

				// try load binary
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Binder = AppStateSerializer.CustomBinder;
				binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;

				curPalette = (SymbolPalette)binaryFormatter.Deserialize( iStream );
			}
			
			return curPalette;
		}
		/// <summary>
		/// Checks whether given file is of EDD format.
		/// </summary>
		/// <param name="strPalettePath">file path to check</param>
		/// <returns>true - if given file is EDD, otherwise - false</returns>
		private bool IsPalette( string strPalettePath )
		{
			bool bSuccess = false;
			RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
			Match match = Regex.Match( strPalettePath, c_strPALETTE_EXTENSION, options );

			if ( match.Success )
			{
				bSuccess = true;
			}
				
			return bSuccess;
		}
		/// <summary>
		/// Checks whether given file is of EDD format.
		/// </summary>
		/// <param name="strDocumentPath">file path to check</param>
		/// <returns>true - if given file is EDD, otherwise - false</returns>
		private bool IsDocument( string strDocumentPath )
		{
			bool bSuccess = false;
			RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
			Match match = Regex.Match( strDocumentPath, c_strDOCUMENT_EXTENSION, options );

			if ( match.Success )
			{
				bSuccess = true;
			}
				
			return bSuccess;
		}
		/// <summary>
		/// Tries to load document saved in binary format.
		/// </summary>
		/// <param name="diagram">Diagram to load document in</param>
		/// <param name="strFilePath">file path to saved document</param>
		/// <returns>true - if document loaded succesfully, otherwise - false</returns>
		private bool TryLoadDocumentBinary( Diagram diagram, string strFilePath )
		{
			bool bSuccess = false;
			FileStream iStream = new FileStream(strFilePath, FileMode.Open);
			
			try
			{
				diagram.LoadBinary( iStream );
				bSuccess = true;
			}
			catch( Exception ex )
			{
				System.Diagnostics.Trace.WriteLine( ex.Message) ;
			}
			finally
			{
				iStream.Close();
			}
			
			return bSuccess;
		}
		/// <summary>
		/// Tries to load document saved in soap format.
		/// </summary>
		/// <param name="diagram">Diagram to load document in</param>
		/// <param name="strFilePath">file path to saved document</param>
		/// <returns>true - if document loaded succesfully, otherwise - false</returns>
		private bool TryLoadDocumentSoap( Diagram diagram, string strFilePath )
		{
			bool bSuccess = false;
			FileStream iStream = new FileStream(strFilePath, FileMode.Open);
			
			try
			{				
				diagram.LoadSoap( iStream );
				bSuccess = true;
			}
			catch( Exception ex )
			{
				System.Diagnostics.Trace.WriteLine( ex.Message) ;
			}
			finally
			{
				iStream.Close();
			}
			
			return bSuccess;
		}
		
		public static Assembly AssemblyResolver( object sender, ResolveEventArgs e )
		{
			if (e.Name.StartsWith( Syncfusion.DiagramBaseAssembly.Name ) || e.Name.StartsWith( Syncfusion.DiagramBaseAssembly.LegacyName ))
			{
				return Syncfusion.DiagramBaseAssembly.Assembly;
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

				for (int n = 0; n < assemblies.Length; n++)
				{
					if (assemblies[n].GetName().Name == e.Name)
					{
						return assemblies[n];
					}
				}
			}

			return null;
		}
		#endregion
		
		#endregion
	}
	
	public class ZOrderComparer
		: IComparer
	{
		#region IComparer Members

		public int Compare( object x, object y )
		{
			INode node1 = x as INode;
			INode node2 = y as INode;
			
			if( node1 == null )
				throw new ArgumentNullException( "node1" );

			if( node2 == null )
				throw new ArgumentNullException( "node2" );
			
			IZOrderContainer container1;
			IZOrderContainer container2;
			
			if( node1.Parent is IZOrderContainer )
			{
				container1 = node1.Parent as IZOrderContainer;
				container2 = node2.Parent as IZOrderContainer;
			}
			else
			{
				container1 = node1.Root as IZOrderContainer;
				container2 = node2.Root as IZOrderContainer;
			}
			
			if( container1 == null || container2 == null || !container1.Equals( container2 ) )
				throw new ArgumentNullException( "modelNode" );

			int nZOrderNode1 = container1.GetZOrder( node1 );
			int nZOrderNode2 = container2.GetZOrder( node2 );
			
			return nZOrderNode1 - nZOrderNode2;
		}

		#endregion
	}
}
