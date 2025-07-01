using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;
using FontStyle = Syncfusion.Windows.Forms.Diagram.FontStyle;
using Group = Syncfusion.Windows.Forms.Diagram.Group;

namespace IntermediateToNew
{
	/// <summary>
	/// Summary description for DiagramConverter.
	/// </summary>
	public class DiagramConverter
	{
		#region Class constants
		private const int c_nHEXADECIMAL = 16;
		#endregion
		
		#region Class members
		/// <summary>
		/// Inermediate format document.
		/// </summary>
		private XmlDocument m_docIntrFmt;
		private Hashtable m_hashConnections;
		#endregion
		
		#region Class properties
		protected Hashtable Connections
		{
			get
			{
				if( m_hashConnections == null )
				{
					m_hashConnections = new Hashtable();
				}
				
				return m_hashConnections;
			}
		}
		protected XmlDocument DocInmdFmt
		{
			get{ return m_docIntrFmt; }
		}
		#endregion
		
		#region Class public members
		public bool TryLoadDocument( string strDocumentPath )
		{
			bool bSuccess = false;
			
			if( File.Exists( strDocumentPath ) )
			{
				try
				{
					XmlDocument document = new XmlDocument();
					document.Load( strDocumentPath );
					
					m_docIntrFmt = document;
					bSuccess = true;
				}
				catch( Exception )
				{
					throw new FileLoadException( "Invalid document format" );
				}
			}
				
			return bSuccess;
		}
		public bool TryLoadPalette( string strPalettePath )
		{
			bool bSuccess = false;
			
			if( File.Exists( strPalettePath ) )
			{
				try
				{
					XmlDocument document = new XmlDocument();
					document.Load( strPalettePath );
					
					m_docIntrFmt = document;
					bSuccess = true;
				}
				catch( Exception )
				{
					throw new FileLoadException( "Invalid palette format" );
				}
			}
				
			return bSuccess;
		}
		public Diagram ConvertDocument()
		{
			if( this.DocInmdFmt == null )
				throw new ArgumentNullException( "no document loaded! \r\n Load document first" );
			
			Diagram dgmToReturn = new Diagram();
			Model document = new Model();
			
			if ( this.DocInmdFmt.HasChildNodes )
			{
				foreach ( XmlNode node in this.DocInmdFmt.DocumentElement.ChildNodes )
				{
					switch ( node.LocalName.ToLower() )
					{
						case "model":
							ParseModel( node, document );
							break;
						case "nodes":
							ParseNodes( node, document );
							break;
					}
				}
			}

			// parse connections
			if( this.Connections.Count > 0 )
			{
				foreach( DictionaryEntry connection in this.Connections )
				{
					ParseConnection( ( ConnectionPoint )connection.Key, ( XmlNode )connection.Value, document.Nodes );
				}
			}
			
			dgmToReturn.Model = document;
			return dgmToReturn;
		}
		public SymbolPalette ConvertPalette()
		{
			SymbolPalette paletteToReturn = new SymbolPalette();

			if ( this.DocInmdFmt.HasChildNodes )
			{
				foreach ( XmlNode node in this.DocInmdFmt.DocumentElement.ChildNodes )
				{
					switch ( node.LocalName.ToLower() )
					{
						case "nodes":
							ParseNodes( node, paletteToReturn );
							break;
					}
				}
			}
			
			paletteToReturn.Name = this.DocInmdFmt.DocumentElement.Attributes.GetNamedItem( "Name" ).InnerText;

			return paletteToReturn;
		}
		#endregion
		
		#region Class helper methods
		private void ParseModel( XmlNode nodeXmlModel, Model document )
		{
			if( document == null )
				throw new ArgumentNullException( "document" );

			if( nodeXmlModel == null )
				throw new ArgumentNullException( "nodeXmlModel" );
			
			foreach ( XmlNode node in nodeXmlModel.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "bounds":
						document.Size = ParseRectangleNode( node ).Size;
						break;
					case "boundaryconstraintsenabled":
						document.BoundaryConstraintsEnabled = bool.Parse( node.InnerText );
						break;
					case "linebridgesize":
						document.LineBridgeSize = ParseValue( node );
						break;
					case "linebridgingenabled":
						document.LineBridgingEnabled = bool.Parse( node.InnerText );
						break;
					case "lineroutingenabled":
						document.LineRoutingEnabled = bool.Parse( node.InnerText );
						break;
					case "measurementunits":
						document.MeasurementUnits = ( MeasureUnits ) Enum.Parse( typeof( MeasureUnits ), node.InnerText );
						break;
					case "name":
						document.Name = node.InnerText;
						break;
					case "sizetocontent":
						document.SizeToContent = bool.Parse( node.InnerText );
						break;
					case "minimumsize":
						document.MinimumSize = ParseSize( node );
						break;
				}
			}
		}
		private void ParseNodes( XmlNode nodeXmlNodes, SymbolPalette palette )
		{
			if( nodeXmlNodes == null )
				throw new ArgumentNullException( "nodeXmlNodes" );

			if( palette == null )
				throw new ArgumentNullException( "palette" );

			Node nodeDiagram = null;
				
			foreach ( XmlNode node in nodeXmlNodes.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "rectangle":
						nodeDiagram = ParseRectangle( node );
						break;
					case "roundrectangle":
						nodeDiagram = ParseRoundRectangle( node );
						break;
					case "ellipse":
						nodeDiagram = ParseEllipse( node );
						break;
					case "line":
						nodeDiagram = ParseLine( node );
						break;
					case "orthogonalconnector":
						nodeDiagram = ParseOrthoConnector( node );
						break;
					case "lineconnector":
						nodeDiagram = ParseConnector( node );
						break;
					case "polyline":
						nodeDiagram = ParsePolyLine( node );
						break;
					case "polygon":
						nodeDiagram = ParsePolygon( node );
						break;
					case "bitmapnode":
						nodeDiagram = ParseBitmapNode( node );
						break;
					case "metafilenode":
						nodeDiagram = ParseMetafileNode( node );
						break;
					case "figure":
						nodeDiagram = ParseFigure( node );
						break;
					case "textnode":
						nodeDiagram = ParseTextNode( node );
						break;
					case "rtftextnode":
						nodeDiagram = ParseRichTextNode( node );
						break;
					case "bezier":
						nodeDiagram = ParseArc( node );
						break;
					case "closedcurve":
						nodeDiagram = ParseClosedCurve( node );
						break;
					case "curve":
						nodeDiagram = ParseCurve( node );
						break;
					case "symbol":
						nodeDiagram = ParseGroup( node );
						break;
				}
				
				if( nodeDiagram != null )
				{
					palette.AppendChild( nodeDiagram );
				}
			}
		}
		private void ParseNodes( XmlNode nodeXmlNodes, ICompositeNode nodeComposite )
		{
			if( nodeComposite == null )
				throw new ArgumentNullException( "nodeComposite" );

			if( nodeXmlNodes == null )
				throw new ArgumentNullException( "nodeXmlNodes" );

			Node nodeDiagram = null;
				
			foreach ( XmlNode node in nodeXmlNodes.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "rectangle":
						nodeDiagram = ParseRectangle( node );
						break;
					case "roundrectangle":
						nodeDiagram = ParseRoundRectangle( node );
						break;
					case "ellipse":
						nodeDiagram = ParseEllipse( node );
						break;
					case "line":
						nodeDiagram = ParseLine( node );
						break;
					case "orthogonalconnector":
						nodeDiagram = ParseOrthoConnector( node );
						break;
					case "lineconnector":
						nodeDiagram = ParseConnector( node );
						break;
					case "polyline":
						nodeDiagram = ParsePolyLine( node );
						break;
					case "polygon":
						nodeDiagram = ParsePolygon( node );
						break;
					case "bitmapnode":
						nodeDiagram = ParseBitmapNode( node );
						break;
					case "metafilenode":
						nodeDiagram = ParseMetafileNode( node );
						break;
					case "figure":
						nodeDiagram = ParseFigure( node );
						break;
					case "textnode":
						nodeDiagram = ParseTextNode( node );
						break;
					case "rtftextnode":
						nodeDiagram = ParseRichTextNode( node );
						break;
					case "bezier":
						nodeDiagram = ParseArc( node );
						break;
					case "closedcurve":
						nodeDiagram = ParseClosedCurve( node );
						break;
					case "curve":
						nodeDiagram = ParseCurve( node );
						break;
					case "group":
						nodeDiagram = ParseGroup( node );
						break;
				}
				
				if( nodeDiagram != null )
				{
					nodeComposite.AppendChild( nodeDiagram );
				}
			}
		}
		private void ParseNodes( XmlNode nodeXmlNodes, NodeCollection nodes )
		{
			if( nodes == null )
				throw new ArgumentNullException( "node" );

			if( nodeXmlNodes == null )
				throw new ArgumentNullException( "nodeXmlNodes" );

			Node nodeDiagram = null;
				
			foreach ( XmlNode node in nodeXmlNodes.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "rectangle":
						nodeDiagram = ParseRectangle( node );
						break;
					case "roundrectangle":
						nodeDiagram = ParseRoundRectangle( node );
						break;
					case "ellipse":
						nodeDiagram = ParseEllipse( node );
						break;
					case "line":
						nodeDiagram = ParseLine( node );
						break;
					case "lineconnector":
						nodeDiagram = ParseConnector( node );
						break;
					case "polyline":
						nodeDiagram = ParsePolyLine( node );
						break;
					case "polygon":
						nodeDiagram = ParsePolygon( node );
						break;
					case "bitmapnode":
						nodeDiagram = ParseBitmapNode( node );
						break;
					case "metafilenode":
						nodeDiagram = ParseMetafileNode( node );
						break;
					case "figure":
						nodeDiagram = ParseFigure( node );
						break;
					case "textnode":
						nodeDiagram = ParseTextNode( node );
						break;
					case "rtftextnode":
						nodeDiagram = ParseRichTextNode( node );
						break;
					case "bezier":
						nodeDiagram = ParseArc( node );
						break;
					case "closedcurve":
						nodeDiagram = ParseClosedCurve( node );
						break;
					case "curve":
						nodeDiagram = ParseCurve( node );
						break;
					case "group":
						nodeDiagram = ParseGroup( node );
						break;
				}
				
				if( nodeDiagram != null )
				{
					nodes.Add( nodeDiagram );
				}
			}
		}
		private Node ParseGroup( XmlNode nodeXmlSymbol )
		{
			if( nodeXmlSymbol == null )
				throw new ArgumentNullException( "nodeXmlSymbol" );
			
			Node nodeToReturn = null;
			XmlNode nodeTemp = GetNodeByName( nodeXmlSymbol, "Nodes" );
			
			string strName = nodeXmlSymbol.Attributes.GetNamedItem( "Name" ).InnerText;
			NodeCollection nodes = new NodeCollection();
			ParseNodes( nodeTemp, nodes );

			if( nodes.Count > 1 )
			{
				Group group = new Group();
				int n;
				foreach( Node node in nodes )
				{
					node.EditStyle.Enabled = true;
					node.EditStyle.AllowMoveX = true;
					node.EditStyle.AllowMoveY = true;
				}	
					
				group.AppendChildren( nodes, out n );

				nodeToReturn = group;
			}
			else if( nodes.Count == 1 )
			{
				nodes[ 0 ].EditStyle.Enabled = true;
				nodes[ 0 ].EditStyle.AllowMoveX = true;
				nodes[ 0 ].EditStyle.AllowMoveY = true;

				nodeToReturn = nodes[ 0 ];
			}

			// parse ports
			nodeTemp = GetNodeByName( nodeXmlSymbol, "Ports" );
			
			if( nodeTemp != null && nodeToReturn != null )
			{
				ParsePorts( nodeToReturn, nodeTemp );
			}

			// parse labels
			nodeTemp = GetNodeByName( nodeXmlSymbol, "Labels" );
			
			if( nodeTemp != null && nodeToReturn != null )
			{
				ParseLabels( nodeToReturn, nodeTemp );
			}

			// parse bounds
			nodeTemp = GetNodeByName( nodeXmlSymbol, "BoundsInfo" );

			if ( nodeTemp != null && nodeToReturn != null )
			{
				RectangleF rcBounds = ParseRectangleNode( nodeTemp );
				nodeToReturn.PinPoint = rcBounds.Location;
				nodeToReturn.Size = rcBounds.Size;
				nodeToReturn.RotationAngle = ParseRotationAngle( nodeTemp );
			}

			if( nodeToReturn != null )
			{
				nodeToReturn.Name = strName;
			}
			
			return nodeToReturn;
		}
		private void ParseLabels( Node node, XmlNode nodeLabels )
		{
			if( node == null )
				throw new ArgumentNullException( "node" );
			
			if( nodeLabels == null )
				throw new ArgumentNullException( "nodeLabels" );
			
			Label label;
			XmlNode nodeTemp;
			
			LabelCollection labels = null;
					
			if( node is PathNode )
			{
				labels = ( ( PathNode ) node ).Labels;
			}
					
			if( node is Group )
			{
				labels = ( ( Group ) node ).Labels;
			}

			foreach( XmlNode nodeLabel in nodeLabels.ChildNodes )
			{
				if( nodeLabel.Name == "Label" )
				{
					string strText = GetNodeByName( nodeLabel, "Text" ).InnerText;
					label = new Label( node, strText );
					
					nodeTemp = GetNodeByName( nodeLabel, "Position" );
					PointF ptPosition = ParsePoint( nodeTemp );
					label.OffsetX = ptPosition.X;
					label.OffsetY = ptPosition.Y;

					// parse font style
					nodeTemp = GetNodeByName( nodeLabel, "FontStyle" );
					ParseFontStyle( label.FontStyle, nodeTemp );

					labels.Add( label );
				}
			}
		}
		private void ParsePorts( Node node, XmlNode nodePorts )
		{
			if( node == null )
				throw new ArgumentNullException( "node" );
			
			if( nodePorts == null )
				throw new ArgumentNullException( "nodePorts" );
			
			ConnectionPoint portToReturn = null;
			
			foreach( XmlNode nodePort in nodePorts.ChildNodes )
			{
				if( nodePort.Name == "Port" ) 
				{
					portToReturn = new ConnectionPoint();
					portToReturn.Container = node;
					
					ParsePortConnections( portToReturn, nodePort );
					ParsePort( portToReturn, nodePort );
				}
				else if( nodePort.Name == "CenterPort" )
				{
					if( !node.EnableCentralPort )
					{
						node.EnableCentralPort = true;
					}
				
					portToReturn = node.CentralPort;
					ParsePortConnections( portToReturn, nodePort );
				}
				
				if( portToReturn != null )
					node.Ports.Add( portToReturn );
			}
		}
		private void ParsePortConnections( ConnectionPoint port, XmlNode nodePort )
		{
			if( port == null )
				throw new ArgumentNullException( "port" );

			if( nodePort == null )
				throw new ArgumentNullException( "nodePort" );

			XmlNode nodeTemp = GetNodeByName( nodePort, "Connections" );
			
			if( nodeTemp != null )
			{
				// parse connections after whole model is converted
				this.Connections.Add( port, nodeTemp );
			}
		}
		private void ParseConnection( ConnectionPoint port, XmlNode connection, NodeCollection nodes )
		{
			if( port == null )
				throw new ArgumentNullException( "port" );

			if( connection == null )
				throw new ArgumentNullException( "connection" );

			foreach( XmlNode nodeConn in connection.ChildNodes )
			{
				
			// get full qualified connector name
			XmlNode nodeTemp = GetNodeByName( nodeConn, "ConnectorName" );
			
				if( nodeTemp != null )
				{
					string strTemp = nodeTemp.InnerText;
					// skip model name
					int nSeparatorIndex = strTemp.IndexOf( "." );
					strTemp = strTemp.Substring( nSeparatorIndex + 1, strTemp.Length - nSeparatorIndex -1 );

					IEndPointContainer connector = GetConnector( strTemp, nodes );
					// get endpoint type
					nodeTemp = GetNodeByName( nodeConn, "EndPointType" );
				
					if( nodeTemp != null && connector != null )
					{
						strTemp = nodeTemp.InnerText;

						EndPoint endPoint = null;
			
						if( strTemp == "TailEndPoint" )
						{
							endPoint = connector.TailEndPoint;
						}
						else if( strTemp == "HeadEndPoint" )
						{
							endPoint = connector.HeadEndPoint;
						}
			
						if( endPoint != null )
						{
							port.TryConnect( endPoint );
						}
					}
				}
			}
		}
		private IEndPointContainer GetConnector( string strFullEndpointContainerName, NodeCollection nodes )
		{
			if( nodes == null )
				throw new ArgumentNullException( "nodes" );
			
			if( strFullEndpointContainerName == null )
				throw new ArgumentNullException( "strFullEndpointContainerName" );
			
			IEndPointContainer connectorToReturn = null;
			int nSeparatorIndex = strFullEndpointContainerName.IndexOf( "." );

			if( nSeparatorIndex == -1 )
			{
				foreach( Node node in nodes )
				{
					if( node.Name == strFullEndpointContainerName )
					{
						connectorToReturn = node as IEndPointContainer;
						break;
					}
				}
			}
			else
			{
				string strSubContainerName = strFullEndpointContainerName.Substring( 0, nSeparatorIndex );
				ICompositeNode nodeComposite = null;
				
				foreach( Node node in nodes )
				{
					if( node.Name == strFullEndpointContainerName )
					{
						nodeComposite = node as ICompositeNode;
						break;
					}
				}

				if( nodeComposite != null )
				{
					strSubContainerName = strFullEndpointContainerName.Substring( 0, nSeparatorIndex + 1 );

					NodeCollection nodesChildren = new NodeCollection();
					int nCounter = 0;
					int nLength = nodeComposite.ChildCount;
					Node nodeTemp;
					
					while( nCounter > nLength )
					{
						nodeTemp = nodeComposite.GetChild( nCounter );
						nodesChildren.Add( nodeTemp );
						nCounter++;
					}
					
					connectorToReturn = GetConnector( strSubContainerName, nodesChildren );
				}
			}

			return connectorToReturn;
		}
		private ConnectionPoint ParsePort( ConnectionPoint port, XmlNode nodePort )
		{
			if( port == null )
				throw new ArgumentNullException( "port" );

			if( nodePort == null )
				throw new ArgumentNullException( "nodePort" );
			
			XmlNode nodeTemp = GetNodeByName( nodePort, "Position" );
			PointF ptPosition = ParsePoint( nodeTemp );
			
			if( ptPosition.IsEmpty )
			{
				port.Position = Position.TopLeft;
			}
			else if( ptPosition.X == 50 && ptPosition.Y == 0 )
			{
				port.Position = Position.TopCenter;
			}
			else if( ptPosition.X == 100 && ptPosition.Y == 0 )
			{
				port.Position = Position.TopRight;
			}
			else if( ptPosition.X == 0 && ptPosition.Y == 50 )
			{
				port.Position = Position.MiddleLeft;
			}
			else if( ptPosition.X == 50 && ptPosition.Y == 50 )
			{
				port.Position = Position.Center;
			}
			else if( ptPosition.X == 50 && ptPosition.Y == 100 )
			{
				port.Position = Position.MiddleRight;
			}
			else if( ptPosition.X == 100 && ptPosition.Y == 0 )
			{
				port.Position = Position.BottomLeft;
			}
			else if( ptPosition.X == 100 && ptPosition.Y == 50 )
			{
				port.Position = Position.BottomCenter;
			}
			else if( ptPosition.X == 100 && ptPosition.Y == 100 )
			{
				port.Position = Position.BottomRight;
			}
			else
			{
				port.OffsetX = ptPosition.X;
				port.OffsetY = ptPosition.Y;
			}
			
			return port;
		}
		private Node ParseFigure( XmlNode nodeXmlFigure )
		{
			if( nodeXmlFigure == null )
				throw new ArgumentNullException( "nodeXmlFigure" );

			FilledPath nodeToReturn = null;
			// Create GraphicsPath
			// get points
			PointF[] pts = GetPoints( nodeXmlFigure );
			// get points types
			XmlNode nodeTemp = GetNodeByName( nodeXmlFigure, "Path" );
			
			if( nodeTemp == null ) return nodeToReturn;
			
			nodeTemp = GetNodeByName( nodeTemp, "PathTypes" );
			byte[] pathTypes = System.Convert.FromBase64String( nodeTemp.InnerText );
			// create graphics path
			GraphicsPath path = new GraphicsPath( pts, pathTypes );
			
			// create FilledPath
			nodeToReturn = new FilledPath( path );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlFigure );
			AppendVisibility( nodeToReturn, nodeXmlFigure );
			// parse styles
			foreach( XmlNode node in nodeXmlFigure.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseCurve( XmlNode nodeXmlCurve )
		{
			if( nodeXmlCurve == null )
				throw new ArgumentNullException( "nodeXmlCurve" );

			// Create GraphicsPath
			// get points
			PointF[] pts = GetPoints( nodeXmlCurve );
			// get points types
			XmlNode nodeTemp = GetNodeByName( nodeXmlCurve, "Path" );
			nodeTemp = GetNodeByName( nodeTemp, "PathTypes" );
			byte[] pathTypes = System.Convert.FromBase64String( nodeTemp.InnerText );
			// create graphics path
			GraphicsPath path = new GraphicsPath( pts, pathTypes );
			
			pts = path.PathPoints;
			PointF[] ptsNew = new PointF[ ( pts.Length / 3 ) + 1 ];
			int k = 0;
			
			for( int n = 0, nLength = ptsNew.Length; nLength > n; n ++ )
			{
				ptsNew[ n ] = pts[ k ];
				k += 3;
			}
			
			
			// create FilledPath
			CurveNode nodeToReturn = new CurveNode( ptsNew );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlCurve );
			AppendVisibility( nodeToReturn, nodeXmlCurve );
			// parse styles
			foreach( XmlNode node in nodeXmlCurve.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseClosedCurve(XmlNode nodeXmlClosedCurve)
		{
			if ( nodeXmlClosedCurve == null )
				throw new ArgumentNullException( "nodeXmlClosedCurve" );

			ClosedCurveNode nodeToReturn = null;

			// Create GraphicsPath
			// get points
			PointF[] pts = GetPoints( nodeXmlClosedCurve );
			// get points types
			if ( pts != null )
			{
				XmlNode nodeTemp = GetNodeByName( nodeXmlClosedCurve, "Path" );
				nodeTemp = GetNodeByName( nodeTemp, "PathTypes" );
				byte[] pathTypes = System.Convert.FromBase64String( nodeTemp.InnerText );
				// create graphics path
				GraphicsPath path = new GraphicsPath( pts, pathTypes );

				pts = path.PathPoints;
				PointF[] ptsNew = new PointF[pts.Length / 3];
				int k = 0;

				for ( int n = 0, nLength = ptsNew.Length; nLength > n; n++ )
				{
					ptsNew[n] = pts[k];
					k += 3;
				}

				// create FilledPath
				nodeToReturn = new ClosedCurveNode( ptsNew );

				// get node name and visibility value
				AppendName( nodeToReturn, nodeXmlClosedCurve );
				AppendVisibility( nodeToReturn, nodeXmlClosedCurve );
				// parse styles
				foreach ( XmlNode node in nodeXmlClosedCurve.ChildNodes )
				{
					switch ( node.LocalName.ToLower() )
					{
						case "styles":
							ParseStyles( node, nodeToReturn );
							break;
					}
				}
			}

			return nodeToReturn;
		}
		private Node ParseArc( XmlNode nodeXmlArc )
		{
			if( nodeXmlArc == null )
				throw new ArgumentNullException( "nodeXmlArc" );

			// Create GraphicsPath
			// get points
			PointF[] pts = GetPoints( nodeXmlArc );
			// get points types
			XmlNode nodeTemp = GetNodeByName( nodeXmlArc, "Path" );
			nodeTemp = GetNodeByName( nodeTemp, "PathTypes" );
			byte[] pathTypes = Convert.FromBase64String( nodeTemp.InnerText );
			// create graphics path
			GraphicsPath path = new GraphicsPath( pts, pathTypes );
			pts = path.PathPoints;
			
			BezierCurve nodeToReturn = null;
			
			if( pts.Length > 2 )
			{
				// create FilledPath
				nodeToReturn = new BezierCurve( pts[ 0 ], pts[ 1 ], pts[ 3 ], pts[ 2 ] );
			
				// get node name and visibility value
				AppendName( nodeToReturn, nodeXmlArc );
				AppendVisibility( nodeToReturn, nodeXmlArc );
				// parse styles
				foreach( XmlNode node in nodeXmlArc.ChildNodes )
				{
					switch ( node.LocalName.ToLower() )
					{
						case "styles":
							ParseStyles( node, nodeToReturn );
							break;
					}
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseBitmapNode( XmlNode nodeXmlBitmap )
		{
			if( nodeXmlBitmap == null )
				throw new ArgumentNullException( "nodeXmlBitmap" );
			
			RectangleF rectBounds = GetBounds( nodeXmlBitmap );
			
			XmlNode nodeImage = GetNodeByName( nodeXmlBitmap, "Image" );
			byte[] byteArray = System.Convert.FromBase64String( nodeImage.InnerText );
			MemoryStream strmMem = new MemoryStream( byteArray );
			// create image
			Bitmap image = ( Bitmap )Image.FromStream( strmMem );

			Node nodeToReturn = new BitmapNode( image, rectBounds );

			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlBitmap );
			AppendVisibility( nodeToReturn, nodeXmlBitmap );

			return nodeToReturn;
		}

		private Node ParseMetafileNode( XmlNode nodeXmlMetafile )
		{
			if( nodeXmlMetafile == null )
				throw new ArgumentNullException( "nodeXmlMetafile" );
			
			RectangleF rectBounds = GetBounds( nodeXmlMetafile );
			
			XmlNode nodeImage = GetNodeByName( nodeXmlMetafile, "Image" );
			byte[] byteArray = System.Convert.FromBase64String( nodeImage.InnerText );
			MemoryStream strmMem = new MemoryStream( byteArray );
			// create image
			Metafile image = ( Metafile )Image.FromStream( strmMem );

			Node nodeToReturn = new MetafileNode( image, rectBounds );

			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlMetafile );
			AppendVisibility( nodeToReturn, nodeXmlMetafile );

			return nodeToReturn;
		}
		private Node ParsePolygon( XmlNode nodeXmlPolygon )
		{
			if( nodeXmlPolygon == null )
				throw new ArgumentNullException( "nodeXmlPolygon" );
			
			PointF[] pts = GetPoints( nodeXmlPolygon );
			Polygon nodeToReturn = new Polygon( pts );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlPolygon );
			AppendVisibility( nodeToReturn, nodeXmlPolygon );

			foreach( XmlNode node in nodeXmlPolygon.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParsePolyLine( XmlNode nodeXmlPolyLine )
		{
			if( nodeXmlPolyLine == null )
				throw new ArgumentNullException( "nodeXmlPolyLine" );
			
			PointF[] pts = GetPoints( nodeXmlPolyLine );
			PolylineNode nodeToReturn = new PolylineNode( pts );

			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlPolyLine );
			AppendVisibility( nodeToReturn, nodeXmlPolyLine );

			foreach( XmlNode node in nodeXmlPolyLine.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseLine( XmlNode nodeXmlLine )
		{
			if( nodeXmlLine == null )
				throw new ArgumentNullException( "nodeXmlLine" );
			
			PointF[] pts = GetPoints( nodeXmlLine );
			Line nodeToReturn = new Line( pts );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlLine );
			AppendVisibility( nodeToReturn, nodeXmlLine );

			foreach( XmlNode node in nodeXmlLine.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseOrthoConnector( XmlNode nodeXmlConnector )
		{
			if( nodeXmlConnector == null )
				throw new ArgumentNullException( "nodeXmlConnector" );
			
			PointF[] pts = GetPoints( nodeXmlConnector );
//			PointF ptHead = pts[ 0 ];
//			PointF ptTail = pts[ 0 ];
//			XmlNode nodePoints = GetNodeByName( nodeXmlPoints, "Path" );
//			nodePoints = GetNodeByName( nodePoints, "PathPoints" );
			
			OrthogonalConnector nodeToReturn = new OrthogonalConnector( pts[ 0 ], pts[ pts.Length - 1 ] );
			
			Matrix mtx = nodeToReturn.GetTransformations();
			nodeToReturn.AppendFlipTransforms( mtx );
			
			mtx.Invert();
			mtx.TransformPoints( pts );
			
			nodeToReturn.SetPoints( pts );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlConnector );
			AppendVisibility( nodeToReturn, nodeXmlConnector );

			foreach( XmlNode node in nodeXmlConnector.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseConnector( XmlNode nodeXmlConnector )
		{
			if( nodeXmlConnector == null )
				throw new ArgumentNullException( "nodeXmlConnector" );
			
			PointF[] pts = GetPoints( nodeXmlConnector );
			LineConnector nodeToReturn = new LineConnector( pts[ 0 ], pts[ 1 ] );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlConnector );
			AppendVisibility( nodeToReturn, nodeXmlConnector );

			foreach( XmlNode node in nodeXmlConnector.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseRectangle( XmlNode nodeXmlRectangle )
		{
			if( nodeXmlRectangle == null )
				throw new ArgumentNullException(  );
			
			PointF[] pts = GetPoints( nodeXmlRectangle );
			Polygon nodeToReturn = new Polygon( pts );
			
			AppendName( nodeToReturn, nodeXmlRectangle );
			AppendVisibility( nodeToReturn, nodeXmlRectangle );
			
			foreach ( XmlNode node in nodeXmlRectangle.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseRoundRectangle( XmlNode nodeXmlRoundRectangle )
		{
			if( nodeXmlRoundRectangle == null )
				throw new ArgumentNullException(  );
			
			RectangleF rectBounds = GetBounds( nodeXmlRoundRectangle );
			RoundRect nodeToReturn = new RoundRect( rectBounds );
			
			// get node name and visibility value
			AppendRotationAngle( nodeToReturn, nodeXmlRoundRectangle );
			AppendName( nodeToReturn, nodeXmlRoundRectangle );
			AppendVisibility( nodeToReturn, nodeXmlRoundRectangle );
			
			foreach ( XmlNode node in nodeXmlRoundRectangle.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseEllipse( XmlNode nodeXmlEllipse )
		{
			if( nodeXmlEllipse == null )
				throw new ArgumentNullException( "nodeXmlEllipse" );
			
			// Create GraphicsPath
			// get points
			PointF[] pts = GetPoints( nodeXmlEllipse );
			// get points types
			XmlNode nodeTemp = GetNodeByName( nodeXmlEllipse, "Path" );
			nodeTemp = GetNodeByName( nodeTemp, "PathTypes" );
			byte[] pathTypes = Convert.FromBase64String( nodeTemp.InnerText );
			
			RectangleF rect = Geometry.CreateRect( pts );
					
			for( int nCounter = 0, nLength = pts.Length; nCounter < nLength; nCounter++ )
			{
				pts[ nCounter ].X -= rect.X;
				pts[ nCounter ].Y -= rect.Y;
			}

			// create graphics path
			GraphicsPath path = new GraphicsPath( pts, pathTypes );
			PointF pt = rect.Location;
			PointF[] ptsNew = new PointF[ 3 ] { pt, pt, pt };
			
			// create FilledPath
			Ellipse nodeToReturn = new Ellipse( rect );

			// update node's path
			GraphicsPath pathh = nodeToReturn.GraphicsPath;
			pathh.Reset();
			pathh.AddPath( path, false );

			// update path points
			PropertyInfo pi = nodeToReturn.GetType().GetProperty( "PathPoints", BindingFlags.Instance | BindingFlags.NonPublic );
			pi.SetValue( nodeToReturn, pathh.PathPoints.Clone(), null );

			// call UpdatePathNodeData explicitly
			MethodInfo mi =
				nodeToReturn.GetType().GetMethod( "UpdatePathNodeData", BindingFlags.Instance | BindingFlags.NonPublic );
			mi.Invoke( nodeToReturn, null );

			// update PinPoint and PinPointOffset
			nodeToReturn.PinPoint = new PointF( rect.X + rect.Width / 2, rect.Y + rect.Height / 2 );
			nodeToReturn.PinPointOffset = new SizeF( rect.Width / 2, rect.Height / 2 );
			nodeToReturn.Size = rect.Size;
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlEllipse );
			AppendVisibility( nodeToReturn, nodeXmlEllipse );

			foreach ( XmlNode node in nodeXmlEllipse.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseRichTextNode( XmlNode nodeXmlRTFNode )
		{
			if( nodeXmlRTFNode == null )
				throw new ArgumentNullException( "nodeXmlRTFNode" );

			string strText = GetNodeByName( nodeXmlRTFNode, "RTF" ).InnerText;
			RectangleF rectBounds = GetBounds( nodeXmlRTFNode );
			RichTextNode nodeToReturn = new RichTextNode( strText, rectBounds );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlRTFNode );
			AppendVisibility( nodeToReturn, nodeXmlRTFNode );

			foreach( XmlNode node in nodeXmlRTFNode.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
					case "readonly":
						nodeToReturn.ReadOnly = bool.Parse( node.InnerText );
						break;
				}
			}
			
			return nodeToReturn;
		}
		private Node ParseTextNode( XmlNode nodeXmlTextNode )
		{
			if( nodeXmlTextNode == null )
				throw new ArgumentNullException( "nodeXmlTextNode" );

			string strText = GetNodeByName( nodeXmlTextNode, "Text" ).InnerText;
			RectangleF rectBounds = GetBounds( nodeXmlTextNode );
			TextNode nodeToReturn = new TextNode( strText, rectBounds );
		
			// get node name and visibility value
			AppendName( nodeToReturn, nodeXmlTextNode );
			AppendVisibility( nodeToReturn, nodeXmlTextNode );

			foreach( XmlNode node in nodeXmlTextNode.ChildNodes )
			{
				switch ( node.LocalName.ToLower() )
				{
					case "styles":
						ParseStyles( node, nodeToReturn );
						break;
					case "readonly":
						nodeToReturn.ReadOnly = bool.Parse( node.InnerText );
						break;
					case "directionrighttoleft":
						nodeToReturn.DirectionRightToLeft = bool.Parse( node.InnerText );
						break;
					case "directionvertical":
						nodeToReturn.DirectionVertical = bool.Parse( node.InnerText );
						break;
					case "fitblackbox":
						nodeToReturn.FitBlackBox = bool.Parse( node.InnerText );
						break;
					case "horizontalalignment":
						nodeToReturn.HorizontalAlignment =
							( StringAlignment ) Enum.Parse( typeof( StringAlignment ), node.InnerText );
						break;
					case "linelimit":
						nodeToReturn.LineLimit = bool.Parse( node.InnerText );
						break;
					case "measuretrailingspaces":
						nodeToReturn.MeasureTrailingSpaces = bool.Parse( node.InnerText );
						break;
					case "noclip":
						nodeToReturn.NoClip = bool.Parse( node.InnerText );
						break;
					case "verticalalignment":
						nodeToReturn.VerticalAlignment =
							( StringAlignment ) Enum.Parse( typeof( StringAlignment ), node.InnerText );
						break;
					case "wraptext":
						nodeToReturn.WrapText = bool.Parse( node.InnerText );
						break;
				}
			}
			
			return nodeToReturn;
		}

		#region Styles parsing
		private void ParseStyles( XmlNode nodeStyles, Node nodeDiagram )
		{
			if( nodeStyles == null )
				throw new ArgumentNullException( "nodeStyles" );
			
			foreach( XmlNode node in nodeStyles.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "fillstyle":
						if( nodeDiagram is TextNode )
						{
							ParseFillStyle( ( ( TextNode ) nodeDiagram ).FontColorStyle, node );
						}
						else if( nodeDiagram is FilledPath )
						{
							ParseFillStyle( ( ( FilledPath ) nodeDiagram ).FillStyle, node );
						}
						break;
					case "editstyle":
						ParseEditStyle( nodeDiagram.EditStyle, node );
						break;
					case "linestyle":
						ParseLineStyle( nodeDiagram.LineStyle, node );
						break;
					case "shadowstyle":
						ParseShadowStyle( nodeDiagram.ShadowStyle, node );
						break;
					case "backgroundstyle":
						if( nodeDiagram is TextNode )
						{
							ParseBackgroundStyle( ( ( TextNode ) nodeDiagram ).BackgroundStyle, node );
						}
						break;
					case "fontstyle":
						if( nodeDiagram is TextNode )
						{
							ParseFontStyle( ( ( TextNode ) nodeDiagram ).FontStyle, node );
						}
						break;
				}
			}
		}
		private void ParseFontStyle( FontStyle styleFont, XmlNode nodeFontStyle )
		{
			if( styleFont == null )
				throw new ArgumentNullException( "styleFont" );

			if( nodeFontStyle == null )
				throw new ArgumentNullException( "nodeFontStyle" );
			
			foreach( XmlNode node in nodeFontStyle.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "family":
						styleFont.Family = node.InnerText;
						break;
					case "name":
						styleFont.Name = node.InnerText;
						break;
					case "size":
						styleFont.PointSize = ParseValue( node );
						break;
					case "unit":
						styleFont.Unit = ( MeasureUnits ) Enum.Parse( typeof( MeasureUnits ), node.InnerText );
						break;
					case "style":
						styleFont.Style =
							( System.Drawing.FontStyle ) Enum.Parse( typeof( System.Drawing.FontStyle ), node.InnerText );
						break;
				}
			}
		}
		private void ParseShadowStyle( ShadowStyle styleShadow, XmlNode nodeShadowStyle )
		{
			if( styleShadow == null )
				throw new ArgumentNullException( "styleShadow" );

			if( nodeShadowStyle == null )
				throw new ArgumentNullException( "nodeShadowStyle" );
			
			foreach( XmlNode node in nodeShadowStyle.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "alphafactor":
						styleShadow.ColorAlphaFactor = ( int ) ParseValue( node );
						break;
					case "color":
						styleShadow.Color = ColorTranslator.FromHtml( node.InnerText );
						break;
					case "offsetx":
						styleShadow.OffsetX = ParseValue( node );
						break;
					case "offsety":
						styleShadow.OffsetY = ParseValue( node );
						break;
					case "visible":
						styleShadow.Visible = bool.Parse( node.InnerText );
						break;
				}
			}
		}
		private void ParseLineStyle( LineStyle styleLine, XmlNode nodeLineStyle )
		{
			if( styleLine == null )
				throw new ArgumentNullException( "styleLine" );

			if( nodeLineStyle == null )
				throw new ArgumentNullException( "nodeStyle" );
			
			foreach( XmlNode node in nodeLineStyle.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "linecolor":
						styleLine.LineColor = ColorTranslator.FromHtml( node.InnerText );
						break;
					case "dashcap":
						styleLine.DashCap = ( DashCap )Enum.Parse( typeof( DashCap ), node.InnerText );
						break;
					case "dashoffset":
						styleLine.DashOffset = ParseValue( node );
						break;
					case "dashstyle":
						styleLine.DashStyle = ( DashStyle )Enum.Parse( typeof( DashStyle ), node.InnerText );
						break;
					case "endcap":
						styleLine.EndCap = ( LineCap )Enum.Parse( typeof( LineCap ), node.InnerText );
						break;
					case "linejoin":
						styleLine.LineJoin = ( LineJoin )Enum.Parse( typeof( LineJoin ), node.InnerText );
						break;
					case "miterlimit":
						styleLine.MiterLimit = ParseValue( node );
						break;
					case "linewidth":
						styleLine.LineWidth = ParseValue( node );
						break;
				}
			}
		}
		private void ParseBackgroundStyle( FillStyle styleFill, XmlNode nodeStyle )
		{
			// make background colors opaque
			styleFill.ForeColorAlphaFactor = 255;
			styleFill.ColorAlphaFactor = 255;
			
			ParseFillStyle( styleFill, nodeStyle );
			
			if( styleFill.Color == Color.Transparent )
			{
				styleFill.ColorAlphaFactor = 0;
			}
			
			if( styleFill.ForeColor == Color.Transparent )
			{
				styleFill.ForeColorAlphaFactor = 0;
			}
		}
		private void ParseFillStyle( FillStyle styleFill, XmlNode nodeStyle )
		{
			if( styleFill == null )
				throw new ArgumentNullException( "styleFill" );
			
			if( nodeStyle == null )
				throw new ArgumentNullException( "nodeStyle" );
			
			
			foreach( XmlNode node in nodeStyle.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "color":
						styleFill.Color = ColorTranslator.FromHtml( node.InnerText );
						break;
					case "coloralphafactor":
						styleFill.ColorAlphaFactor = ( int ) ParseValue( node );
						break;
					case "forecolor":
						styleFill.ForeColor = ColorTranslator.FromHtml( node.InnerText );
						break;
					case "forecoloralphafactor":
						styleFill.ForeColorAlphaFactor = ( int ) ParseValue( node );
						break;
					case "gradientangle":
						styleFill.GradientAngle = ( int ) ParseValue( node );
						break;
					case "gradientcenter":
						styleFill.GradientCenter = ( int ) ParseValue( node );
						break;
					case "hatchbrushstyle":
						styleFill.HatchBrushStyle = ( HatchStyle )Enum.Parse( typeof( HatchStyle ), node.InnerText );
						break;
					case "texture":
						if( node.Value != string.Empty )
						{
							byte[] byteArray = System.Convert.FromBase64String( node.InnerText );
							MemoryStream strmMem = new MemoryStream( byteArray );
							// create image
							styleFill.Texture = Image.FromStream( strmMem );
						}
						break;
					case "texturewrapmode":
						styleFill.TextureWrapMode = ( WrapMode )Enum.Parse( typeof( WrapMode ), node.InnerText );
						break;
					case "type":
						styleFill.Type = ( FillStyleType )Enum.Parse( typeof( FillStyleType ), node.InnerText );
						break;
				}
			}
		}
		private void ParseEditStyle( EditStyle styleEdit, XmlNode nodeStyle )
		{
			if( styleEdit == null )
				throw new ArgumentNullException( "styleEdit" );

			if( nodeStyle== null )
				throw new ArgumentNullException( "nodeStyle" );

			foreach( XmlNode node in nodeStyle.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "allowselect":
						styleEdit.AllowSelect = bool.Parse( node.InnerText );
						break;
					case "allowvertexedit":
						styleEdit.AllowVertexEdit = bool.Parse( node.InnerText );
						break;
					case "allowrotate":
						styleEdit.AllowRotate = bool.Parse( node.InnerText );
						break;
					case "allowresize":
						bool bCanResize = bool.Parse( node.InnerText );
						
						if( !bCanResize )
						{
							styleEdit.AllowChangeHeight = false;
							styleEdit.AllowChangeWidth = false;
						} 
						break;
					case "allowmove":
						bool bCanMove = bool.Parse( node.InnerText );
						
						if( !bCanMove )
						{
							styleEdit.AllowMoveX = false;
							styleEdit.AllowMoveY = false;
						}
						break;
					case "enabled":
						styleEdit.Enabled = bool.Parse( node.InnerText );
						break;
					case "handleeditmode":
						styleEdit.DefaultHandleEditMode =
							( HandleEditMode ) Enum.Parse( typeof( HandleEditMode ), node.InnerText );
						break;

				}
			}
		}
		#endregion

		private void AppendRotationAngle( Node node, XmlNode nodeXml )
		{
			XmlNode nodeRotation = nodeXml.Attributes.GetNamedItem( "RotationAngle" );
			node.RotationAngle = ParseValue( nodeRotation );
		}
		private void AppendName( Node node, XmlNode nodeXml )
		{
			node.Name = nodeXml.Attributes.GetNamedItem( "Name" ).InnerText;
		}
		private void AppendVisibility( Node node, XmlNode nodeXml )
		{
			string nodeValue = nodeXml.Attributes.GetNamedItem( "Visible" ).InnerText;
			node.Visible = bool.Parse( nodeValue );
		}
		/// <summary>
		/// Searches for xml Bounds element.
		/// </summary>
		/// <param name="nodeXmlRectangle"></param>
		/// <returns></returns>
		private XmlNode GetNodeByName( XmlNode nodeXml, string strNodeLocalName )
		{
			if( nodeXml == null ) return null;
			
			XmlNode nodeToReturn = null;
			
			foreach( XmlNode node in nodeXml.ChildNodes )
			{
				if( node.LocalName.ToLower() == strNodeLocalName.ToLower() )
				{
					nodeToReturn = node;
					break;
				}
			}
			
			return nodeToReturn;
		}
		private PointF[] GetPoints( XmlNode nodeXmlPoints )
		{
			if( nodeXmlPoints == null )
				throw new ArgumentNullException( "nodeXmlPoints" );
			
			XmlNode nodePoints = GetNodeByName( nodeXmlPoints, "Path" );
			nodePoints = GetNodeByName( nodePoints, "PathPoints" );
			
			PointF[] ptsToReturn = null;
			
			if( nodePoints != null )
				ptsToReturn = ParsePoints( nodePoints );
			
			return ptsToReturn;
		}
		private RectangleF GetBounds( XmlNode nodeXmlRectangle )
		{
			// get xml boudns
			XmlNode nodeBounds = GetNodeByName( nodeXmlRectangle, "Bounds" );
			
			return ParseRectangleNode( nodeBounds );
		}
		private PointF[] ParsePoints( XmlNode nodePathPoints )
		{
			PointF[] ptsToReturn = new PointF[ nodePathPoints.ChildNodes.Count ];
			
			for( int n = 0, nLength = nodePathPoints.ChildNodes.Count; nLength > n; n++ )
			{
				ptsToReturn[ n ] = ParsePoint( nodePathPoints.ChildNodes[ n ] );
			}
			
			return ptsToReturn;
		}
		private RectangleF ParseRectangleNode( XmlNode nodeRectangle )
		{
			SizeF szSize = SizeF.Empty;
			PointF ptLocation = PointF.Empty;
			// parse xml bounds
			foreach( XmlNode node in nodeRectangle.ChildNodes )
			{
				switch( node.LocalName.ToLower() )
				{
					case "location":
						ptLocation = ParsePoint( node );
						break;
					case "size":
						szSize = ParseSize( node );
						break;
				}
			}
			
			return new RectangleF( ptLocation, szSize );
		}
		private PointF ParsePoint( XmlNode nodePoint )
		{
			// parse X
			XmlNode attr = nodePoint.Attributes.GetNamedItem( "X" );
			float fX = ParseValue( attr );
			// parse X
			attr = nodePoint.Attributes.GetNamedItem( "Y" );
			float fY = ParseValue( attr );
			
			return new PointF( fX, fY );
		}
		private SizeF ParseSize( XmlNode nodeSize )
		{
			// parse Width
			XmlNode attr = nodeSize.Attributes.GetNamedItem( "Width" );
			float fWidth = ParseValue( attr );
			// parse Height
			attr = nodeSize.Attributes.GetNamedItem( "Height" );
			float fHeight = ParseValue( attr );
			
			return new SizeF( fWidth, fHeight );
		}
		private float ParseRotationAngle(XmlNode nodeRotation)
		{
			float fAngle = 0f;

			// parse rotation angle
			XmlNode attr = nodeRotation.Attributes.GetNamedItem( "RotationAngle" );

			if( attr != null )
				fAngle = ParseValue( attr );

			return fAngle;
		}
		private float ParseValue(XmlNode node)
		{
			CultureInfo ci = ( CultureInfo ) CultureInfo.CurrentCulture.Clone();
			ci.NumberFormat.NumberDecimalDigits = c_nHEXADECIMAL;
			double doubleOut;
			float fReturnValue = 0;

			string strTemp = node.InnerText;

			// Search for decimal separator and set it in NumberFormatInfo.NumberDecimalSeparator
			// to avoid CurrentCultureInfo problems
			RegexOptions regexOptions = RegexOptions.IgnoreCase;

			Match match = Regex.Match( strTemp, "[.,]", regexOptions );
			
			if ( match.Success )
			{
				ci.NumberFormat.NumberDecimalSeparator = match.Value;	
			}

			if ( double.TryParse( strTemp, NumberStyles.Any, ci, out doubleOut ) )
			{
				fReturnValue = ( float ) doubleOut;
			}
		
			return fReturnValue;
		}
		#endregion
	}
}