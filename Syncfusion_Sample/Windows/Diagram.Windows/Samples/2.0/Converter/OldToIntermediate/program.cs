using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OldToIntermediate
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Program
	{
		#region Class constants
		private const int c_nESSENTIAL_DIAGRAM_EXTENSIONS_LENGTH = 4;
		private const string c_strESSENTIAL_DIAGRAM_INTMD_EXTENSION = "intmdedd";
		private const string c_strESSENTIAL_DIAGRAM_PALETTE_INTMD_EXTENSION = "intmdedp";
		private const string c_strSEPARATOR = ".";
		#endregion
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[ STAThread ]
		static void Main( string[] args )
		{
			string strLoadPath;
			string strSavePath = string.Empty;
			DiagramConverter converter = new DiagramConverter();
			
			if( args.Length > 0 )
			{
				// 1 - load old version document | palette
				strLoadPath = args[ 0 ];
				
				if( args.Length > 1 )
				{
					strSavePath = args[ 1 ];
				}
			
				// if input file is document
				if( converter.TryLoadDocument( strLoadPath ) )
				{
					converter.ParseDocument();
				
					converter.Save( strSavePath );
				}
				else if( converter.TryLoadPalette( strLoadPath ) )
				{
					converter.ParsePalette();
				
					converter.Save( strSavePath );
				}
			}
			else
			{
				string strStartupPath = Application.StartupPath;
				string[] strFilePaths = Directory.GetFiles( strStartupPath );
				
				foreach( string strFilePath in strFilePaths )
				{
					Match match = Regex.Match( strFilePath, @"(ed[pd])$" );
					
					if( !match.Success ) continue;
						
					if( converter.TryLoadDocument( strFilePath ) )
					{
						// convert to intermediate
						converter.ParseDocument();
				
						int nFilePathLength = strFilePath.Length;
						int n = strFilePath.IndexOf( c_strSEPARATOR, nFilePathLength - c_nESSENTIAL_DIAGRAM_EXTENSIONS_LENGTH );
						strSavePath = strFilePath.Substring( 0, n )
						              + c_strSEPARATOR
						              + c_strESSENTIAL_DIAGRAM_INTMD_EXTENSION;
						
						// save
						converter.Save( strSavePath );
					}
					else if( converter.TryLoadPalette( strFilePath ) )
					{
						converter.ParsePalette();

						int nFilePathLength = strFilePath.Length;
						int n = strFilePath.IndexOf( ".", nFilePathLength - c_nESSENTIAL_DIAGRAM_EXTENSIONS_LENGTH );
						strSavePath = strFilePath.Substring( 0, n ) + c_strSEPARATOR
						              + c_strESSENTIAL_DIAGRAM_PALETTE_INTMD_EXTENSION;

						converter.Save( strSavePath );
					}
				}
			}
		}
	}
}
