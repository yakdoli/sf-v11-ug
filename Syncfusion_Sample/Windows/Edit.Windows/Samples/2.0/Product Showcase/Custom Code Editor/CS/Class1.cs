using System;
using System.Collections;
using System.Text;

using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Enums;

namespace CustomCodeEditorDemo
{
	/// <summary>
	/// Autoformatter for CSharp.
	/// </summary>
	public class HTMLFormatter
		: IAutoFormatter
	{
		#region IAutoFormatter Members
		/// <summary>
		/// Formats given list of lexem wrappers.
		/// </summary>
		/// <param name="lexems">List of ILexemWrapper instances.</param>
		/// <returns>String with formatted text.</returns>
		public string Format( IList lexems )
		{
			if( null == lexems )
				throw new ArgumentNullException( "lexems" );

			// Whitespace at the beginning of first line. Is inserted at the beginning of every line.
			string strStartLineWhitespace = GetStartWhitespace( lexems );
            bool starttag=false; 
			if( 0 == lexems.Count ) return strStartLineWhitespace;

			// Number of indentation tabs to insert at the begining of current line.
			int iIndents = 0;

			StringBuilder result = new StringBuilder( strStartLineWhitespace );
			ILexemWrapper curLex = null;

			// Helper variable.
			string strLexText = string.Empty;

			do
			{
				curLex = ( ILexemWrapper )lexems[ 0 ];

				// Omit parsing of comments.
				if( FormatType.Comment == curLex.Config.Type || FormatType.String == curLex.Config.Type
					|| "CommentXML" == curLex.Config.FormatName )
				{
					AddFirstLexem( result, lexems );
				}
					// If lexem is new line mark.
				else if( -1 != curLex.Text.IndexOf( "\n" ) ) 
				{
					RemoveEndWhitespace( result, false );
					AddNewLineAndIndent( result, iIndents, strStartLineWhitespace, lexems );
					lexems.RemoveAt( 0 );
					RemoveStartWhitespace( lexems, false );
				}
				else
				{
					switch( curLex.Text )
					{
						case "<" :
							starttag=true;
							strLexText = curLex.Text;
							if(iIndents>0)
							{
                               AddNewLineAndIndent( result, iIndents, strStartLineWhitespace, lexems );
							}
                        	AddFirstLexem( result, lexems );
							
							if( 0 == lexems.Count ) break;

							AddLexemsInBrackets( result, lexems );
							
							RemoveEndWhitespace( result, true );
							iIndents++;
							RemoveStartWhitespace( lexems, true );
							break;

						case "</" :
							 strLexText = curLex.Text;
							RemoveEndWhitespace( result, true );
                            iIndents--; 
							AddNewLineAndIndent( result, iIndents, strStartLineWhitespace, lexems );
							AddFirstLexem( result, lexems );
							if( 0 == lexems.Count ) break;

							AddLexemsInBrackets( result, lexems );
							RemoveFirstNewLineMark( lexems );
							break;

						default:
							if(starttag)
							{
							   AddNewLineAndIndent( result, iIndents, strStartLineWhitespace, lexems );
                               starttag=false;  
							}
							AddFirstLexem( result, lexems );
							break;
					}
				}
			}
			while( lexems.Count > 0 );

			return result.ToString();
		}
		#endregion

		#region Class Utility Methods
		/// <summary>
		/// Removes whitespace from the end of string builder.
		/// </summary>
		/// <param name="s">StringBuilder instance to remove whitespace from.</param>
		/// <param name="bRemoveNewLineMarks">Indicates whether new line marks should be removerd.</param>
		private void RemoveEndWhitespace( StringBuilder s, bool bRemoveNewLineMarks )
		{
			if( null == s )
				throw new ArgumentNullException( "s" );

			int iWhitespaceLength = 0;

			for( int i = s.Length - 1; i >= 0; i-- )
			{
				if(
					( ' ' == s[ i ] || '\t' == s[ i ] )
					||
					bRemoveNewLineMarks && ( '\n' == s[ i ] || '\r' == s[ i ] )
					)
				{
					iWhitespaceLength++; 
				}
				else
				{
					break;
				}
			}

			s.Remove( s.Length - iWhitespaceLength, iWhitespaceLength );
		}
		/// <summary>
		/// Adds to string builder new line mark and required indentation whitespace at the begining of the next line.
		/// </summary>
		/// <param name="s">StringBuildet instance to work with.</param>
		/// <param name="iIndents">Number of required indents at the beginning of the next line.</param>
		/// <param name="strStartLineWhitespace">Whitespace to insert at the beginning
		/// of the next line (indentation follows it).</param>
		/// <param name="lexems">List of lexems. Used for checking whether current line is the last one.</param>
		private void AddNewLineAndIndent( StringBuilder s, int iIndents, string strStartLineWhitespace, IList lexems )
		{
			if( null == s )
				throw new ArgumentNullException( "s" );
			if( iIndents < 0 )
				throw new ArgumentOutOfRangeException( "iIndents" );
			if( null == strStartLineWhitespace )
				throw new ArgumentNullException( "strStartLineWhitespace" );

			if( 0 != s.Length )	s.Append( '\n' );

			if( IsLastLine( lexems ) ) return;

			s.Append( strStartLineWhitespace + new string( '\t', iIndents ) );
		}
		/// <summary>
		/// Removes all whitespace lexems from the beginning of lexems list.
		/// </summary>
		/// <param name="lexems">List of lexems.</param>
		/// <param name="bRemoveNewLineMarks">Indicates whether new line marks should be removerd.</param>
		private void RemoveStartWhitespace( IList lexems, bool bRemoveNewLineMarks )
		{
			ILexemWrapper lex = null;

			while( lexems.Count > 0 )
			{
				lex = ( ILexemWrapper )lexems[ 0 ];

				if( FormatType.Whitespace == lex.Config.Type || ( bRemoveNewLineMarks && -1 != lex.Text.IndexOf( "\n" ) ) )
				{
					lexems.RemoveAt( 0 );
				}
				else return;
			}
		}
		/// <summary>
		/// Gets whitespace at the beginning of first line.
		/// </summary>
		/// <param name="lexems">List of lexem wrappers.</param>
		/// <returns>String with required whitespace.</returns>
		private string GetStartWhitespace( IList lexems )
		{
			if( null == lexems )
				throw new ArgumentNullException( "lexems" );

			string result = string.Empty;
			ILexemWrapper lex = null;

			while( lexems.Count > 0 )
			{
				lex = ( ILexemWrapper )lexems[ 0 ];

				if( FormatType.Whitespace == lex.Config.Type )
				{
					result += lex.Text;
					lexems.RemoveAt( 0 );
				}
				else break;
			}

			return result;
		}
		/// <summary>
		/// Adds first lexem of list to string builder and removes it from list.
		/// </summary>
		/// <param name="s">StringBuilder instance to add lexem to.</param>
		/// <param name="lexems">List of lexems.</param>
		private void AddFirstLexem( StringBuilder s, IList lexems )
		{
			if( null == s )
				throw new ArgumentNullException( "s" );
			if( null == lexems )
				throw new ArgumentNullException( "lexems" );
			if( lexems.Count < 1 )
				throw new ArgumentException( "lexems" );

			s.Append( ( ( ILexemWrapper )lexems[ 0 ] ).Text );
			lexems.RemoveAt( 0 );
		}
	
		/// <summary>
		/// Adds lexems in brackets without changes.
		/// </summary>
		/// <param name="s">String builder to work with.</param>
		/// <param name="lexems">List of lexems.</param>
		private void AddLexemsInBrackets( StringBuilder s, IList lexems )
		{
			if( null == s )
				throw new ArgumentNullException( "s" );
			if( null == lexems )
				throw new ArgumentNullException( "lexems" );


			string curLexText = string.Empty;


			while(  ">" != curLexText && 0 != lexems.Count )
			{
				curLexText = ( ( ILexemWrapper )lexems[ 0 ] ).Text;
				AddFirstLexem( s, lexems );
			}
		}
		/// <summary>
		/// Adds lexems without any change until specefied
		/// </summary>
		/// <param name="s">String builder instance to add text to.</param>
		/// <param name="lexems">List of lexems.</param>
		/// <param name="lexem">Text of lexem that should and operation.</param>
		private void AddUntilLexem( StringBuilder s, IList lexems, string lexem )
		{
			if( null == s )
				throw new ArgumentNullException( "s" );
			if( null == lexems )
				throw new ArgumentNullException( "lexems" );
			if( null == lexem )
				throw new ArgumentNullException( "lexem" );
			if( string.Empty == lexem )
				throw new ArgumentOutOfRangeException( "lexem" );

			string curLexText = string.Empty;

			while( lexem != curLexText && 0 != lexems.Count )
			{
				curLexText = ( ( ILexemWrapper )lexems[ 0 ] ).Text;
				AddFirstLexem( s, lexems );
			}
		}
		/// <summary>
		/// Checks whether given line is the last in given list of lexems..
		/// </summary>
		/// <param name="lexems">List of lexems.</param>
		/// <returns>True if current line is the last; otherwise false.</returns>
		private bool IsLastLine( IList lexems )
		{
			ILexemWrapper lex;

			if( 0 == lexems.Count ) return true;

			for( int i = 0; i < lexems.Count - 1; i++ )
			{
				lex = ( ILexemWrapper )lexems[ i ];

				if( -1 != lex.Text.IndexOf( "\n" ) || FormatType.Whitespace != lex.Config.Type ) return false;
			}

			return true;
		}
		/// <summary>
		/// Removes all whitespace until the second new line mark.
		/// </summary>
		/// <param name="lexems">List of lexems.</param>
		private void RemoveFirstNewLineMark( IList lexems )
		{
			ILexemWrapper lex = null;

			bool bFirstNewLineFound = false;

			while( lexems.Count > 0 )
			{
				lex = ( ILexemWrapper )lexems[ 0 ];

				if( FormatType.Whitespace == lex.Config.Type ) 
				{
					lexems.RemoveAt( 0 );
					continue;
				}

				if( -1 != lex.Text.IndexOf( "\n" ) && !bFirstNewLineFound )
				{
					lexems.RemoveAt( 0 );
					bFirstNewLineFound = true;
					continue;
				}

				return;
			}
		}
		#endregion
	}
}