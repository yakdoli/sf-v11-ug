using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms.Diagram.Controls;

namespace IntermediateToNew
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		#region Class constants
		private const string c_strPALETTE_INTMD_EXTENSION = ".intmdedp";
		private const string c_strDOCUMENT_INTMD_EXTENSION = ".intmdedd";
		private const string c_strDOCUMENT_EXTENSION = "edd";
		private const string c_strPALETTE_EXTENSION = "edp";
		private const string c_strSEPARATOR = ".";
		#endregion
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[ STAThread ]
		static void Main( string[] args )
		{
			string strLoadPath;
			string strSavePath;
			DiagramConverter converter = new DiagramConverter();
			
			if( args.Length > 0 )
			{
				// 1 - load intmd version document | palette
				strLoadPath = args[ 0 ];
				// 	2 - get save path			
				strSavePath = GetSavePath( args, strLoadPath );
				// 3 - covert
				string strFileExtension = Path.GetExtension( strLoadPath );
				
				if( strFileExtension == c_strDOCUMENT_INTMD_EXTENSION )
				{
					ConvertDocument( converter, strLoadPath, strSavePath );
				}
				else if( strFileExtension == c_strPALETTE_INTMD_EXTENSION 
				         && converter.TryLoadPalette( strLoadPath ) )
				{
					// Parse palette
					SymbolPalette palette = converter.ConvertPalette();
					// Save Palette
					SavePalette( palette, strSavePath );
				}
			}
			else
			{
				string strStartupPath = Application.StartupPath;
				string[] strFilePaths = Directory.GetFiles( strStartupPath );
			
				foreach( string strFilePath in strFilePaths )
				{
					Convert( converter, strFilePath );
				}
			}
		}
		private static string GetSavePath( string[] args, string strLoadPath )
		{
			string strSavePath;
			if( args.Length > 1 )
			{
				strSavePath = args[ 1 ];
			}
			else
			{
				string strFileExtension = Path.GetExtension( strLoadPath );
					
					
				if( strFileExtension == c_strDOCUMENT_INTMD_EXTENSION )
				{
					strFileExtension = c_strDOCUMENT_EXTENSION;
				}
				else if( strFileExtension == c_strPALETTE_INTMD_EXTENSION )
				{
					strFileExtension = c_strPALETTE_EXTENSION;
				}

				int nFilePathLength = strLoadPath.Length;
				int n = strLoadPath.IndexOf( c_strSEPARATOR,
					nFilePathLength - ( c_strDOCUMENT_INTMD_EXTENSION.Length + 1 ) );

				strSavePath = strLoadPath.Substring( 0, n )
					+ c_strSEPARATOR
					+ strFileExtension;
			}
			return strSavePath;
		}
		private static void Convert( DiagramConverter converter, string strFilePath )
		{
			string strSavePath;
			string strFileExtension = Path.GetExtension( strFilePath );
					
			if( strFileExtension == c_strDOCUMENT_INTMD_EXTENSION )
			{
				int nFilePathLength = strFilePath.Length;
				int n = strFilePath.IndexOf( c_strSEPARATOR,
					nFilePathLength - ( c_strDOCUMENT_INTMD_EXTENSION.Length + 1 ) );

				strSavePath = strFilePath.Substring( 0, n )
					+ c_strSEPARATOR
					+ c_strDOCUMENT_EXTENSION;
						
				ConvertDocument( converter, strFilePath, strSavePath );
			}
			else if( strFileExtension == c_strPALETTE_INTMD_EXTENSION
					&& converter.TryLoadPalette( strFilePath ) )
			{
				SymbolPalette palette = converter.ConvertPalette();

				SavePalette( palette, strFilePath );
			}
		}
		private static void ConvertDocument( DiagramConverter converter, string strLoadPath, string strSavePath )
		{
			// Load Intermediate XmlDocument
			if( converter.TryLoadDocument( strLoadPath ) )
			{
				// convert to intermediate
				Diagram diagram = converter.ConvertDocument();
				// save
				diagram.SaveBinary( strSavePath );
			}
		}
		private static void SavePalette( SymbolPalette palette, string strFilePath )
		{
			string strSavePath;
			int nFilePathLength = strFilePath.Length;
			int n = strFilePath.IndexOf( ".", nFilePathLength
				- ( c_strDOCUMENT_INTMD_EXTENSION.Length + 1 ) );

			strSavePath = strFilePath.Substring( 0, n )
				+ c_strSEPARATOR
				+ c_strPALETTE_EXTENSION;

			// Save palette
			SaveBinary( palette, strSavePath );
		}
		private static void SaveBinary( SymbolPalette palette, string strSavePath )
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream( strSavePath, FileMode.OpenOrCreate );

			formatter.Serialize( stream, palette );
			stream.Close();
		}
	}
}
