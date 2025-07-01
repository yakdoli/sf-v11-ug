Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace FolderBrowser
	''' <summary>
	''' Summary description for FileCollection.
	''' </summary>
	Friend Class FileData : Inherits ArrayList
		Private ffilePath As String
		Public Sub New(ByVal ffilePath As String)
			FilePath = ffilePath
		End Sub
		Public Property FilePath() As String
			Get
				Return ffilePath
			End Get
			Set
				If FilePath = Value Then
				Return
				End If
				Clear()
				Me.ffilePath = Value
				Try
					Dim dirs As String() = System.IO.Directory.GetDirectories(ffilePath)
					Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < dirs.Length; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
					Do While i < dirs.Length
						Add(New FileDataItem(FileDataItemType.Directory, dirs(i)))
						i += 1
					Loop
					Dim files As String() = System.IO.Directory.GetFiles(ffilePath)
					i = 0
'ORIGINAL LINE: for(int i = 0; i < files.Length; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
					Do While i < files.Length
						Add(New FileDataItem(FileDataItemType.File, files(i)))
						i += 1
					Loop
				Catch

				End Try
			End Set
		End Property
		Public Shadows ReadOnly Default Property Item(ByVal index As Integer) As FileDataItem
			Get
                Return CType(MyBase.Item(index), FileDataItem)
			End Get
		End Property
        Public Overloads Function IndexOf(ByVal path As String) As Integer
            Dim i As Integer
            For i = 0 To Count - 1
                If path.Equals(Me(i).FullName) Then
                    Return i
                End If
            Next i
            Return -1
        End Function
    End Class
	Public Enum FileDataItemType
		Up = 0
		File
		Directory
	End Enum
	Public Class FileDataItem
		Private fitemType As FileDataItemType
		Private fname, fdisplayName As String
        Private ffileSize As Long
		Private fmodified As DateTime

		Public Sub New(ByVal fitemType As FileDataItemType, ByVal fname As String)
			Me.fitemType = fitemType
			Me.fname = fname
			Me.fdisplayName = IIf(ItemType <> FileDataItemType.Up, System.IO.Path.GetFileName(fname), "..")
			Me.ffileSize = -1
		End Sub
		Public ReadOnly Property ItemType() As FileDataItemType
			Get
				Return Me.fitemType
			End Get
		End Property
		Public ReadOnly Property Name() As String
			Get
				Return Me.fdisplayName
			End Get
		End Property
		Public ReadOnly Property FullName() As String
			Get
				Return IIf(ItemType = FileDataItemType.Up, System.IO.Path.GetDirectoryName(Me.fname), Me.fname)
			End Get
		End Property
		Public ReadOnly Property DirectoryName() As String
			Get
				Return IIf(ItemType <> FileDataItemType.Up, System.IO.Path.GetDirectoryName(Me.fname), Me.fname)
			End Get
		End Property
		Public ReadOnly Property ImageIndex() As Integer
			Get
				Return CInt(ItemType -1)
			End Get
		End Property
		Public ReadOnly Property Size() As Long
			Get
				If ItemType = FileDataItemType.File Then
					UpdateFileInfo()
                    Return Me.ffileSize
                    'ElseIf ItemType = FileDataItemType.Directory Then
                    '    UpdateDirInfo()
                    '    Return Me.dirsize
                Else
                    Return 0
				End If
			End Get
		End Property
		Public ReadOnly Property Modified() As DateTime
			Get
				If ItemType = FileDataItemType.File Then
					UpdateFileInfo()
					Return Me.fmodified
				Else
					UpdateDirInfo()
					Return Me.fmodified
				End If
			End Get
		End Property
		Private Sub UpdateFileInfo()
			If Me.ffileSize >= 0 Then
			Return
			End If
			Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(Me.fname)
			Me.ffileSize = fileInfo.Length
			Me.fmodified = fileInfo.LastWriteTime
		End Sub
		Private Sub UpdateDirInfo()
            Dim dirInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Me.fname)
            'Dim finfo() As FileInfo = dirInfo.GetFiles()
            'For Each ff As FileInfo In finfo
            '    Me.dirsize += ff.Length
            'Next ff
			Me.fmodified = dirInfo.LastWriteTime
		End Sub
	End Class
End Namespace
